namespace FFXIVOpcodes.Global
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
        // Server Zone
        PlayerSetup = 0x2bf, // updated 6.38
        UpdateHpMpTp = 0x268, // updated 6.38
        UpdateClassInfo = 0x2f7, // updated 6.38
        PlayerStats = 0x2d8, // updated 6.38
        ActorControl = 0x2c2, // updated 6.38
        ActorControlSelf = 0x256, // updated 6.38
        ActorControlTarget = 0x1b8, // updated 6.38
        Playtime = 0xa3, // updated 6.38
        UpdateSearchInfo = 0x3dc, // updated 6.38
        ExamineSearchInfo = 0x213, // updated 6.38
        Examine = 0x22f, // updated 6.38
        ActorCast = 0x15f, // updated 6.38
        CurrencyCrystalInfo = 0x39a, // updated 6.38
        InitZone = 0x1fe, // updated 6.38
        WeatherChange = 0x17a, // updated 6.38
        PlayerSpawn = 0x94, // updated 6.38
        ActorSetPos = 0x2f0, // updated 6.38
        PrepareZoning = 0x267, // updated 6.38
        ContainerInfo = 0x2e4, // updated 6.38
        ItemInfo = 0x34d, // updated 6.38
        PlaceFieldMarker = 0x354, // updated 6.38
        PlaceFieldMarkerPreset = 0x286, // updated 6.38
        EffectResult = 0x3b5, // updated 6.38
        EventStart = 0x8b, // updated 6.38
        EventFinish = 0x362, // updated 6.38
        DesynthResult = 0x308, // updated 6.38
        FreeCompanyInfo = 0x199, // updated 6.38
        FreeCompanyDialog = 0x1d6, // updated 6.38
        MarketBoardSearchResult = 0xea, // updated 6.38
        MarketBoardItemListingCount = 0x174, // updated 6.38
        MarketBoardItemListingHistory = 0x3cd, // updated 6.38
        MarketBoardItemListing = 0x379, // updated 6.38
        MarketBoardPurchase = 0x370, // updated 6.38
        UpdateInventorySlot = 0x335, // updated 6.38
        InventoryActionAck = 0x2cf, // updated 6.38
        InventoryTransaction = 0x31b, // updated 6.38
        InventoryTransactionFinish = 0x2fc, // updated 6.38
        ResultDialog = 0x113, // updated 6.38
        RetainerInformation = 0x260, // updated 6.38
        NpcSpawn = 0x269, // updated 6.38
        ItemMarketBoardInfo = 0x209, // updated 6.38
        ObjectSpawn = 0x2d1, // updated 6.38
        EffectResultBasic = 0x2c4, // updated 6.38
        Effect = 0xfb, // updated 6.38
        StatusEffectList = 0x317, // updated 6.38
        StatusEffectList2 = 0x30d, // updated 6.38
        StatusEffectList3 = 0x12b, // updated 6.38
        ActorGauge = 0x136, // updated 6.38
        CFNotify = 0x38a, // updated 6.38
        SystemLogMessage = 0x1a6, // updated 6.38
        AirshipTimers = 0x3d0, // updated 6.38
        SubmarineTimers = 0x16d, // updated 6.38
        AirshipStatusList = 0x257, // updated 6.38
        AirshipStatus = 0x314, // updated 6.38
        AirshipExplorationResult = 0x288, // updated 6.38
        SubmarineProgressionStatus = 0x31a, // updated 6.38
        SubmarineStatusList = 0x1a4, // updated 6.38
        SubmarineExplorationResult = 0x147, // updated 6.38

        ActorMove = 0x25b, // updated 6.38

        EventPlay = 0x284, // updated 6.38
        EventPlay4 = 0xe2, // updated 6.38
        EventPlay8 = 0x2c1, // updated 6.38
        EventPlay16 = 0x7f, // updated 6.38
        EventPlay32 = 0xd3, // updated 6.38
        EventPlay64 = 0xc1, // updated 6.38
        EventPlay128 = 0x29d, // updated 6.38
        EventPlay255 = 0x326, // updated 6.38

        EnvironmentControl = 0x118, // updated 6.38
        IslandWorkshopSupplyDemand = 0x168, // updated 6.38
        Logout = 0x146, // updated 6.38
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x25f, // updated 6.38
        ClientTrigger = 0x1be, // updated 6.38
        ChatHandler = 0x1f2, // updated 6.38
        MarketBoardPurchaseHandler = 0x397, // updated 6.38
        InventoryModifyHandler = 0x024d, // updated 6.38 (Base offset: 0x0254)
        UpdatePositionInstance = 0x01a0, // updated 6.38
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //Tell = 0x0064, // updated for sb
        //TellErrNotFound = 0x0066,

        //FreeCompanyEvent = 0x012C, // added 5.0
    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        //TellReq = 0x0064,
    };
}
