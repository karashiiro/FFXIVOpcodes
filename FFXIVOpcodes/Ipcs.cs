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
        PlayerSetup = 0x263,// updated 6.40h
        UpdateHpMpTp = 0x8e,// updated 6.40h
        UpdateClassInfo = 0x158,// updated 6.40h
        PlayerStats = 0x26c,// updated 6.40h
        ActorControl = 0x3a0,// updated 6.40h
        ActorControlSelf = 0x286,// updated 6.40h
        ActorControlTarget = 0x3bd,// updated 6.40h
        Playtime = 0x18f,// updated 6.40h
        UpdateSearchInfo = 0xae,// updated 6.40h
        ExamineSearchInfo = 0x11b,// updated 6.40h
        Examine = 0x75, // updated 6.40h
        ActorCast = 0x34d,// updated 6.40h
        CurrencyCrystalInfo = 0x350,// updated 6.40h
        InitZone = 0x2d0,// updated 6.40h
        WeatherChange = 0x172,// updated 6.40h
        PlayerSpawn = 0x251,// updated 6.40h
        ActorSetPos = 0x2bb,// updated 6.40h
        PrepareZoning = 0x18a,// updated 6.40h
        ContainerInfo = 0x21c,// updated 6.40h
        ItemInfo = 0x103,// updated 6.40h
        PlaceFieldMarker = 0x2f8,// updated 6.40h
        PlaceFieldMarkerPreset = 0xb0,// updated 6.40h
        EffectResult = 0x140,// updated 6.40h
        EventStart = 0xaf,// updated 6.40h
        EventFinish = 0x14c,// updated 6.40h
        DesynthResult = 0x90,// updated 6.40h
        FreeCompanyInfo = 0x182,// updated 6.40h
        FreeCompanyDialog = 0x21e,// updated 6.40h
        MarketBoardSearchResult = 0x81,// updated 6.40h
        MarketBoardItemListingCount = 0x97,// updated 6.40h
        MarketBoardItemListingHistory = 0x3e3,// updated 6.40h
        MarketBoardItemListing = 0x122,// updated 6.40h
        MarketBoardPurchase = 0x24e,// updated 6.40h
        UpdateInventorySlot = 0x37a,// updated 6.40h
        InventoryActionAck = 0x162,// updated 6.40h
        InventoryTransaction = 0x2df,// updated 6.40h
        InventoryTransactionFinish = 0x16f,// updated 6.40h
        ResultDialog = 0x3dc,// updated 6.40h
        RetainerInformation = 0x233,// updated 6.40h
        NpcSpawn = 0x11c,// updated 6.40h
        ItemMarketBoardInfo = 0x2af,// updated 6.40h
        ObjectSpawn = 0x12a,// updated 6.40h
        EffectResultBasic = 0x366,// updated 6.40h
        Effect = 0x28a,// updated 6.40h
        StatusEffectList = 0x1cb,// updated 6.40h
        StatusEffectList2 = 0x18d, // updated 6.40h
        StatusEffectList3 = 0x39e, // updated 6.40h
        ActorGauge = 0x24f,// updated 6.40h
        CFNotify = 0x2d6,// updated 6.40h
        SystemLogMessage = 0x193,// updated 6.40h
        AirshipTimers = 0x3af,// updated 6.40h
        SubmarineTimers = 0x2ef,// updated 6.40h
        AirshipStatusList = 0xd6,// updated 6.40h
        AirshipStatus = 0x3e0,// updated 6.40h
        AirshipExplorationResult = 0xb5,// updated 6.40h
        SubmarineProgressionStatus = 0x181,// updated 6.40h
        SubmarineStatusList = 0x13d,// updated 6.40h
        SubmarineExplorationResult = 0x15f,// updated 6.40h

        ActorMove = 0x38d, // updated 6.40h

        EventPlay = 0x2d2, // updated 6.40h
        EventPlay4 = 0xbc, // updated 6.40h
        EventPlay8 = 0x250, // updated 6.40h
        EventPlay16 = 0x391, // updated 6.40h
        EventPlay32 = 0x1ff, // updated 6.40h
        EventPlay64 = 0x1be, // updated 6.40h
        EventPlay128 = 0x32f, // updated 6.40h
        EventPlay255 = 0xe4, // updated 6.40h

        EnvironmentControl = 0xf9, // updated 6.40h
        IslandWorkshopSupplyDemand = 0x16d, // updated 6.40h
        Logout = 0x18b, // updated 6.40h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x215,// updated 6.40h
        ClientTrigger = 0xda,// updated 6.40h
        ChatHandler = 0x31b,// updated 6.40h
        SetSearchInfoHandler = 0x10b,// updated 6.40h
        MarketBoardPurchaseHandler = 0x8d,// updated 6.40h
        InventoryModifyHandler = 0x0283,// updated 6.40h (Base offset: 0x028A)
        UpdatePositionInstance = 0x147,// updated 6.40h
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
