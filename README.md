# FFXIVOpcodes
A POC opcode repo for FFXIV. This is going to work a bit differently from [SapphireServer/FFXIVOpcodes](https://github.com/SapphireServer/FFXIVOpcodes), particularly because I support all game regions, so I'd rather not fork them at this time.

## Project Structure
C# is similar enough to C++ that we can just replace a couple things and end up with a compilable file. Moreover, C#, using reflection, can get the keys and values of the opcode enum at runtime. Therefore, we can write a simple Github Action to control making releases of the opcode JSON with no manual control whatsoever. Just edit the opcode list, and after a predefined condition is hit (every time, after certain opcodes are updated, etc.) the Action will and tag a new release with the output file.
