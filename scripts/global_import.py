#!/usr/bin/env python3
"""Import opcode diffs from xivdev/opcodediff into the Global Ipcs.cs file."""

import json
import re
import sys
import urllib.request

IPCS_PATH = "FFXIVOpcodes/Ipcs.cs"
DIFF_URL = "https://raw.githubusercontent.com/xivdev/opcodediff/refs/heads/main/diffs/{version}.diff.json"


def fetch_diff(source: str) -> list[dict]:
    """Load diff JSON from a URL or local file path."""
    if source.startswith(("http://", "https://")):
        with urllib.request.urlopen(source) as r:
            return json.loads(r.read())
    with open(source) as f:
        return json.load(f)


def apply_diff(ipcs_text: str, diff: list[dict], version: str) -> tuple[str, int, list[str]]:
    """Replace old opcode hex values with new ones in the C# source."""
    matched = 0
    skipped = []

    for entry in diff:
        old_val = int(entry["old"][0], 16)
        new_val = int(entry["new"][0], 16)
        old_hex = f"0x{old_val:04X}"
        new_hex = f"0x{new_val:04X}"

        pattern = re.compile(
            rf"^(\s+\w.*=\s*){re.escape(old_hex)}(\s*,\s*//\s*updated\s+)\S+",
            re.IGNORECASE | re.MULTILINE,
        )
        ipcs_text, n = pattern.subn(
            lambda m, nh=new_hex: f"{m.group(1)}{nh}{m.group(2)}{version}",
            ipcs_text,
        )
        if n > 0:
            matched += n
        else:
            skipped.append(old_hex)

    return ipcs_text, matched, skipped


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

    result, matched, skipped = apply_diff(original, diff, version)

    with open(IPCS_PATH, "w") as f:
        f.write(result)

    print(f"Done! {matched} opcodes updated in {IPCS_PATH}")
    if skipped:
        print(f"  {len(skipped)} unmatched entries (not tracked in this file)")


if __name__ == "__main__":
    main()
