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
        ActorCast = 0x0303, // updated v5.31
        ActorControl = 0x0347, // updated v5.31
        ActorControlSelf = 0x02FC, // updated v5.31
        ActorControlTarget = 0x0325, // updated v5.31
        ActorFreeSpawn = 0x025F, // updated v5.31
        ActorGauge = 0x0192, // updated v5.31
        ActorMove = 0x02DA, // updated v5.31
        ActorSetPos = 0x022B, // updated v5.31
        //AddStatusEffect = 0x0151, // updated v5.31
        AirshipExplorationResult = 0x0113, // updated v5.31
        AirshipStatus = 0x0295, // updated v5.31
        AirshipStatusList = 0x0091, // updated v5.31
        AirshipTimers = 0x024A, // updated v5.31
        AoeEffect16 = 0x03E6, // updated v5.31
        AoeEffect24 = 0x01C0, // updated v5.31
        AoeEffect32 = 0x03B3, // updated v5.31
        AoeEffect8 = 0x03DA, // updated v5.31
        //BossStatusEffectList = 0x0292, // updated 5.25
        CFNotify = 0x0134, // updated v5.31
        CFPreferredRole = 0x0115, // updated v5.31
        CurrencyCrystalInfo = 0x0148, // updated v5.31
        DesynthResult = 0x0216, // updated v5.31
        Effect = 0x024B, // updated v5.31
        EffectResult = 0x0151, // updated v5.31
        EventFinish = 0x0236, // updated v5.31
        EventPlay = 0x0066, // updated v5.31
        EventPlay32 = 0x01AE, // updated v5.31
        EventPlay4 = 0x036D, // updated v5.31
        EventStart = 0x0182, // updated v5.31
        Examine = 0x017D, // updated v5.31
        ExamineFreeCompanyInfo = 0x0100, // updated v5.31
        ExamineSearchInfo = 0x0272, // updated v5.31
        InitZone = 0x00A6, // updated v5.31
        InventoryActionAck = 0x023C, // updated v5.31
        InventoryTransaction = 0x0304, // updated v5.31
        InventoryTransactionFinish = 0x00FE, // updated v5.31
        ItemInfo = 0x038C, // updated v5.31
        Logout = 0x0267, // updated v5.31
        MarketBoardItemListing = 0x0124, // updated v5.31
        MarketBoardItemListingCount = 0x00B3, // updated v5.31
        MarketBoardItemListingHistory = 0x021A, // updated v5.31
        MarketBoardSearchResult = 0x0207, // updated v5.31
        MarketTaxRates = 0x00BF, // updated v5.31
        MiniCactpotInit = 0x020C, // updated v5.31
        NpcSpawn = 0x02D4, // updated v5.31
        ObjectSpawn = 0x01B8, // updated v5.31
        PlaceFieldMarker = 0x00C0, // updated v5.31
        PlaceFieldMarkerPreset = 0x011C, // updated v5.31
        PlayerSetup = 0x0130, // updated v5.31
        PlayerSpawn = 0x027F, // updated v5.31
        PlayerStats = 0x0343, // updated v5.31
        Playtime = 0x034A, // updated v5.31
        PrepareZoning = 0x01F2, // updated v5.31
        RetainerInformation = 0x02AC, // updated v5.31
        ServerNotice = 0x01EB, // updated v5.31
        SomeDirectorUnk4 = 0x026E, // updated v5.31
        StatusEffectList = 0x012D, // updated v5.31
        SubmarineExplorationResult = 0x0344, // updated v5.31
        SubmarineProgressionStatus = 0x00BB, // updated v5.31
        SubmarineStatusList = 0x0371, // updated v5.31
        SubmarineTimers = 0x029C, // updated v5.31
        UpdateClassInfo = 0x0084, // updated v5.31
        UpdateHpMpTp = 0x0166, // updated v5.31
        UpdateInventorySlot = 0x009F, // updated v5.31
        UpdateSearchInfo = 0x0213, // updated v5.31
        WeatherChange = 0x0149, // updated v5.31
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0287, // updated v5.31
        ClientTrigger = 0x0187, // updated v5.31
        InventoryModifyHandler = 0x00CA, // updated v5.31 (Base offset: 0x00D1)
        SetSearchInfoHandler = 0x02EA, // updated v5.31
        UpdatePositionHandler = 0x01B7, // updated v5.31
        UpdatePositionInstance = 0x016D, // updated v5.31
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
