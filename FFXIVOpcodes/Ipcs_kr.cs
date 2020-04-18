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
        ActorCast = 0x03E5, // updated 5.11
        ActorControl = 0x0282, // updated 5.11 (ActorControl142)
        ActorControlSelf = 0x032A, // updated 5.11 (ActorControl143)
        ActorControlTarget = 0x0387, // updated 5.11 (ActorControl144)
        ActorGauge = 0x0352, // updated 5.11
        ActorSetPos = 0x033C, // updated 5.11
        AddStatusEffect = 0x010B, // updated 5.11
        AoeEffect16 = 0x0212, // updated 5.11 (ActionEffect16)
        AoeEffect24 = 0x022D, // updated 5.11 (ActionEffect24)
        AoeEffect32 = 0x023E, // updated 5.11 (ActionEffect32)
        AoeEffect8 = 0x03B6, // updated 5.11 (ActionEffect8)
        //BossStatusEffectList = 0x037F, // updated 5.1
        CFNotify = 0x014E, // updated 5.11
        CFPreferredRole = 0x0205, // updated 5.11
        CurrencyCrystalInfo = 0x0112, // updated 5.11
        Effect = 0x0306, // updated 5.11 (ActionEffect)
        EventFinish = 0x009B, // updated 5.11
        EventPlay = 0x0081, // updated 5.11
        EventPlay4 = 0x00E1, // updated 5.11
        EventStart = 0x0203, // updated 5.11
        Examine = 0x0241, // updated 5.11
        ExamineSearchInfo = 0x00DA, // updated 5.11
        InitZone = 0x03CA, // updated 5.11
        InventoryTransaction = 0x0334, // updated 5.1
        //InventoryTransactionFinish
        ItemInfo = 0x00FD, // updated 5.11
        MarketBoardItemListing = 0x011C, // updated 5.11 (MarketBoardOfferings)
        MarketBoardItemListingCount = 0x01A0, // updated 5.11 (MarketBoardItemRequestStart)
        MarketBoardItemListingHistory = 0x027F, // updated 5.11 (MarketBoardHistory)
        MarketBoardSearchResult = 0x02DA, // updated 5.11
        MarketTaxRates = 0x016D, // updated 5.11
        NpcSpawn = 0x026E, // updated 5.11
        PlayerSetup = 0x02A2, // updated 5.11
        PlayerSpawn = 0x0289, // updated 5.11
        PlayerStats = 0x0200, // updated 5.11
        Playtime = 0x0332, // updated 5.11
        RetainerInformation = 0x02E7, // updated 5.11
        SomeDirectorUnk4 = 0x026C, // updated 5.11
        StatusEffectList = 0x029B, // updated 5.11
        UpdateClassInfo = 0x0316, // updated 5.11
        UpdateHpMpTp = 0x0367, // updated 5.11
        UpdateInventorySlot = 0x00AE, // updated 5.11
        UpdateSearchInfo = 0x019A, // updated 5.11
        UseMooch = 0x0334, // updated 5.11
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x037C, // updated 5.11
        ClientTrigger = 0x012B, // updated 5.11
        InventoryModifyHandler = 0x0188, // updated 5.1
        SetSearchInfoHandler = 0x023C, // updated 5.11
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