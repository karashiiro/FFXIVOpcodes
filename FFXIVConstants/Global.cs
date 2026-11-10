using System.Collections.Generic;

namespace FFXIVConstants
{
    static class Global
    {
        public static Dictionary<string, object> Constants = new Dictionary<string, object>
        {
            // This is InventoryModifyHandler + 7
            { "InventoryOperationBaseValue", 0x013E+7 }
        };
    }
}
