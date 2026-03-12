#!/usr/bin/env python3
"""Import opcode diffs from xivdev/opcodediff into the Global Ipcs.cs file."""

import json
import re
import sys
import urllib.request

IPCS_PATH = "FFXIVOpcodes/Ipcs.cs"
CONSTANTS_PATH = "FFXIVConstants/Global.cs"
DIFF_URL = "https://raw.githubusercontent.com/xivdev/opcodediff/refs/heads/main/diffs/{version}.diff.json"


def fetch_diff(source: str) -> list[dict]:
    """Load diff JSON from a URL or local file path."""
    if source.startswith(("http://", "https://")):
        with urllib.request.urlopen(source) as r:
            return json.loads(r.read())
    with open(source) as f:
        return json.load(f)


def apply_diff(ipcs_text: str, diff: list[dict], version: str) -> tuple[str, int, int]:
    """Replace old opcode hex values with new ones in the C# source."""
    # Build old->new lookup (normalized to uppercase 0xNNNN)
    # We precompute a mapping and run in a single pass to avoid cascading replacements.
    mapping: dict[str, str] = {}
    for entry in diff:
        old_hex = f"0x{int(entry['old'][0], 16):04X}"
        new_hex = f"0x{int(entry['new'][0], 16):04X}"
        mapping[old_hex] = new_hex

    matched = 0
    unmatched = len(mapping)

    # Single-pass regex: match any uncommented opcode assignment line
    pattern = re.compile(
        r"^(\s+\w.*=\s*)(0x[0-9A-Fa-f]+)(\s*,\s*//\s*updated\s+)\S+",
        re.IGNORECASE | re.MULTILINE,
    )

    def replacer(m: re.Match) -> str:
        nonlocal matched, unmatched
        old_hex = f"0x{int(m.group(2), 16):04X}"
        if old_hex in mapping:
            matched += 1
            unmatched -= 1
            return f"{m.group(1)}{mapping[old_hex]}{m.group(3)}{version}"
        return m.group(0)

    ipcs_text = pattern.sub(replacer, ipcs_text)
    return ipcs_text, matched, unmatched


def update_constants(ipcs_text: str) -> bool:
    """Update InventoryOperationBaseValue in Global.cs from InventoryModifyHandler + 7."""
    m = re.search(r"InventoryModifyHandler\s*=\s*(0x[0-9A-Fa-f]+)", ipcs_text)
    if not m:
        print("  WARN: InventoryModifyHandler not found in Ipcs.cs, skipping constants update")
        return False

    handler_hex = m.group(1)

    with open(CONSTANTS_PATH, "r") as f:
        constants = f.read()

    new_constants = re.sub(
        r'("InventoryOperationBaseValue",\s*)0x[0-9A-Fa-f]+\+7',
        rf"\g<1>{handler_hex}+7",
        constants,
    )

    if new_constants == constants:
        print(f"  InventoryOperationBaseValue already up to date")
        return False

    with open(CONSTANTS_PATH, "w") as f:
        f.write(new_constants)

    print(f"  Updated InventoryOperationBaseValue to {handler_hex}+7 in {CONSTANTS_PATH}")
    return True


def resolve_source(arg: str) -> tuple[str, str]:
    """Return (url_or_path, version) from a version string or explicit path/URL."""
    # Already a URL or file path
    if arg.startswith(("http://", "https://")) or "." in arg and "/" in arg:
        m = re.search(r"(\d+\.\d+\w*)\.diff\.json", arg)
        return arg, m.group(1) if m else arg

    # Bare version like "7.45h"
    return DIFF_URL.format(version=arg), arg


def main():
    if len(sys.argv) < 2:
        print(f"Usage: {sys.argv[0]} <version | diff_url | diff_path>")
        print(f"  e.g. {sys.argv[0]} 7.45h")
        sys.exit(1)

    source, version = resolve_source(sys.argv[1])

    print(f"Fetching diff from {source}...")
    diff = fetch_diff(source)
    print(f"  {len(diff)} opcode changes in diff")

    with open(IPCS_PATH, "r") as f:
        original = f.read()

    result, matched, unmatched = apply_diff(original, diff, version)

    with open(IPCS_PATH, "w") as f:
        f.write(result)

    update_constants(result)

    print(f"Done! {matched} opcodes updated in {IPCS_PATH}")
    if unmatched:
        print(f"  {unmatched} unmatched entries (not tracked in this file)")


if __name__ == "__main__":
    main()
