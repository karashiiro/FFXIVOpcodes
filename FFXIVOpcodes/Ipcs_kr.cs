namespace FFXIVOpcodes.KR
{
    ////////////////////////////////////////////////////////////////////////////////
    /// Lobby Connection IPC Codes
    /**
    * Server IPC Lobby Type Codes.
    */
    enum ServerLobbyIpcType : ushort
    {
        LobbyError = 0x0002,
        LobbyServiceAccountList = 0x000C,
        LobbyCharList = 0x000D,
        LobbyCharCreate = 0x000E,
        LobbyEnterWorld = 0x000F,
        LobbyServerList = 0x0015,
        LobbyRetainerList = 0x0017,
    };
    /**
    * Client IPC Lobby Type Codes.
    */
    enum ClientLobbyIpcType : ushort
    {
        ReqCharList = 0x0003,
        ReqEnterWorld = 0x0004,
        ClientVersionInfo = 0x0005,
        ReqCharDelete = 0x000A,
        ReqCharCreate = 0x000B,
    };
    ////////////////////////////////////////////////////////////////////////////////
    /// Zone Connection IPC Codes
    /**
    * Server IPC Zone Type Codes.
    */
    enum ServerZoneIpcType : ushort
    {
        ActorCast = 0x0246, // updated 5.21
        ActorControl = 0x01C5, // updated 5.21
        ActorControlSelf = 0x013B, // updated 5.21
        ActorControlTarget = 0x0388, // updated 5.21
        // ActorFreeSpawn = 0x0343, // updated 5.21
        ActorGauge = 0x00E6, // updated 5.21
        ActorMove = 0x0379, // updated 5.21
        ActorSetPos = 0x00A4, // updated 5.21
        AddStatusEffect = 0x00CD, // updated 5.21
        AoeEffect16 = 0x018C, // updated 5.21
        AoeEffect24 = 0x016D, // updated 5.21
        AoeEffect32 = 0x01B4, // updated 5.21
        AoeEffect8 = 0x00D1, // updated 5.21
        CFNotify = 0x028B, // updated 5.21
        CFPreferredRole = 0x00FA, // updated 5.21
        CurrencyCrystalInfo = 0x0151, // updated 5.21
        Effect = 0x02DD, // updated 5.21
        EventFinish = 0x007F, // updated 5.21
        EventPlay = 0x0221, // updated 5.21
        EventPlay32 = 0x0087, // updated 5.21
        EventPlay4 = 0x028A, // updated 5.21
        EventStart = 0x019F, // updated 5.21
        Examine = 0x0157, // updated 5.21
        ExamineSearchInfo = 0x031D, // updated 5.21
        InitZone = 0x03AF, // updated 5.21
        InventoryActionAck = 0x0376, // updated 5.21
        InventoryTransaction = 0x01DF, // updated 5.21
        InventoryTransactionFinish = 0x0072, // updated 5.21
        ItemInfo = 0x021F, // updated 5.21
        MarketBoardItemListing = 0x01A3, // updated 5.21
        MarketBoardItemListingCount = 0x0104, // updated 5.21
        MarketBoardItemListingHistory = 0x0217, // updated 5.21
        MarketBoardSearchResult = 0x0199, // updated 5.21
        MarketTaxRates = 0x018E, // updated 5.21
        NpcSpawn = 0x03C7, // updated 5.21
        ObjectSpawn = 0x0212, // updated 5.21
        PlayerSetup = 0x0211, // updated 5.21
        PlayerSpawn = 0x03DF, // updated 5.21
        PlayerStats = 0x02DB, // updated 5.21
        Playtime = 0x006C, // updated 5.21
        RetainerInformation = 0x02BD, // updated 5.21
        SomeDirectorUnk4 = 0x02A9, // updated 5.21
        StatusEffectList = 0x02B7, // updated 5.21
        UpdateClassInfo = 0x0272, // updated 5.21
        UpdateHpMpTp = 0x0343, // updated 5.21
        UpdateInventorySlot = 0x0148, // updated 5.21
        // UpdatePositionInstance = 0x0379, // updated 5.21
        UpdateSearchInfo = 0x02A8, // updated 5.21
        // WaymarkPreset = 0x02DE, // updated 5.21
        // WaymarkSet = 0x02C2, // updated 5.21
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0180, // updated 5.21
        ClientTrigger = 0x02D5, // updated 5.21
        InventoryModifyHandler = 0x00BC, // updated 5.21 (Base offset: 0x00C3)
        SetSearchInfoHandler = 0x0191, // updated 5.21
        UpdatePositionHandler = 0x0077, // updated 5.21
    };
    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //    Tell = 0x0064, // updated for sb
        TellErrNotFound = 0x0066,
        FreeCompanyEvent = 0x012C, // added 5.0
    };
    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        TellReq = 0x0064,
    };
}