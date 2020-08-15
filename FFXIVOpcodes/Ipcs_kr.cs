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
        ActorCast = 0x028D, // updated 5.18
        ActorControl = 0x02DB, // updated 5.18 (ActorControl142)
        ActorControlSelf = 0x0363, // updated 5.18 (ActorControl143)
        ActorControlTarget = 0x02AA, // updated 5.18 (ActorControl144)
        ActorGauge = 0x00E9, // updated 5.18
        ActorSetPos = 0x01F9, // updated 5.18
        AddStatusEffect = 0x0365, // updated 5.18
        AoeEffect16 = 0x0167, // updated 5.18 (ActionEffect16)
        AoeEffect24 = 0x02A4, // updated 5.18 (ActionEffect24)
        AoeEffect32 = 0x0265, // updated 5.18 (ActionEffect32)
        AoeEffect8 = 0x02B9, // updated 5.18 (ActionEffect8)
        //BossStatusEffectList
        CFNotify = 0x01D6, // updated 5.18
        CFPreferredRole = 0x03A9, // updated 5.18
        CurrencyCrystalInfo = 0x024A, // updated 5.18
        Effect = 0x0213, // updated 5.18 (ActionEffect)
        EventFinish = 0x02E7, // updated 5.18
        EventPlay = 0x0118, // updated 5.18
        EventPlay4 = 0x00DF, // updated 5.18
        EventStart = 0x01FC, // updated 5.18
        Examine = 0x028A, // updated 5.18
        ExamineSearchInfo = 0x0174, // updated 5.18
        InitZone = 0x0360, // updated 5.18
        InventoryTransaction = 0x02FA, // updated 5.18
        InventoryTransactionFinish = 0x0267, // updated 5.18
        ItemInfo = 0x02F6, // updated 5.18
        MarketBoardItemListing = 0x01AD, // updated 5.18 (MarketBoardOfferings)
        MarketBoardItemListingCount = 0x0187, // updated 5.18 (MarketBoardItemRequestStart)
        MarketBoardItemListingHistory = 0x0153, // updated 5.18 (MarketBoardHistory)
        MarketBoardSearchResult = 0x0109, // updated 5.18
        MarketTaxRates = 0x023E, // updated 5.18
        NpcSpawn = 0x0125, // updated 5.18
        PlayerSetup = 0x0207, // updated 5.18
        PlayerSpawn = 0x0377, // updated 5.18
        PlayerStats = 0x036C, // updated 5.18
        Playtime = 0x0350, // updated 5.18
        RetainerInformation = 0x02FC, // updated 5.18
        SomeDirectorUnk4 = 0x03C4, // updated 5.18
        StatusEffectList = 0x00AE, // updated 5.18
        UpdateClassInfo = 0x00C6, // updated 5.18
        UpdateHpMpTp = 0x033F, // updated 5.18
        UpdateInventorySlot = 0x028E, // updated 5.18
        UpdateSearchInfo = 0x03D7, // updated 5.18 
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0113, // updated 5.18
        ClientTrigger = 0x038B, // updated 5.18
        InventoryModifyHandler = 0x01AC, // updated 5.18
        SetSearchInfoHandler = 0x0123, // updated 5.18
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