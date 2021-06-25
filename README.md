# FFXIVOpcodes
Opcode/constant repository for FFXIV. Builds JSON stores of opcodes from enums.

The current opcodes file and constants file can be retrieved either from the GitHub CDN directly, or (for China) through jsDelivr ([opcodes](https://cdn.jsdelivr.net/gh/karashiiro/FFXIVOpcodes@latest/opcodes.min.json) [constants](https://cdn.jsdelivr.net/gh/karashiiro/FFXIVOpcodes@latest/constants.min.json)).

## Version convention
By default, we follow the game versions (4.1, 5.57, etc.), but for hotfixes we increment the game version by 0.001.

For example, a hotfix on 5.57 would change our version to 5.571, and another would change it to 5.572.