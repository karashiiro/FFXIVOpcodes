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
        PlayerSetup = 0x0121, // updated 7.0
        UpdateHpMpTp = 0x007E, // updated 7.0
        UpdateClassInfo = 0x031B, // updated 7.0
        PlayerStats = 0x03C6, // updated 7.0
        ActorControl = 0x0187, // updated 7.0
        ActorControlSelf = 0x0141, // updated 7.0
        ActorControlTarget = 0x0103, // updated 7.0
        Playtime = 0x025E, // updated 7.0
        UpdateSearchInfo = 0x031D, // updated 7.0
        ExamineSearchInfo = 0x035A, // updated 7.0
        Examine = 0x028A, // updated 7.0
        ActorCast = 0x00F1, // updated 7.0
        CurrencyCrystalInfo = 0x008E, // updated 7.0
        InitZone = 0x03DD, // updated 7.0
        WeatherChange = 0x0398, // updated 7.0
        PlayerSpawn = 0x0338, // updated 7.0
        ActorSetPos = 0x032B, // updated 7.0
        PrepareZoning = 0x0307, // updated 7.0
        ContainerInfo = 0x014B, // updated 7.0
        ItemInfo = 0x0305, // updated 7.0
        PlaceFieldMarker = 0x01B3, // updated 7.0
        PlaceFieldMarkerPreset = 0x0315, // updated 7.0
        EffectResult = 0x01F9, // updated 7.0
        EventStart = 0x036B, // updated 7.0
        EventFinish = 0x00FD, // updated 7.0
        DesynthResult = 0x0375, // updated 7.0
        FreeCompanyInfo = 0x00D6, // updated 7.0
        FreeCompanyDialog = 0x0318, // updated 7.0
        MarketBoardSearchResult = 0x01B0, // updated 7.0
        MarketBoardItemListingCount = 0x01D7, // updated 7.0
        MarketBoardItemListingHistory = 0x022B, // updated 7.0
        MarketBoardItemListing = 0x00FC, // updated 7.0
        MarketBoardPurchase = 0x0356, // updated 7.0
        UpdateInventorySlot = 0x00D9, // updated 7.0
        InventoryActionAck = 0x02C9, // updated 7.0
        InventoryTransaction = 0x008F, // updated 7.0
        InventoryTransactionFinish = 0x01C3, // updated 7.0
        ResultDialog = 0x01DB, // updated 7.0
        RetainerInformation = 0x00FB, // updated 7.0
        NpcSpawn = 0x0300, // updated 7.0
        ItemMarketBoardInfo = 0x0340, // updated 7.0
        ObjectSpawn = 0x02F2, // updated 7.0
        EffectResultBasic = 0x0239, // updated 7.0
        Effect = 0x0369, // updated 7.0
        StatusEffectList = 0x02EB, // updated 7.0
        StatusEffectList2 = 0x0350, // updated 7.0
        StatusEffectList3 = 0x03DA, // updated 7.0
        ActorGauge = 0x035B, // updated 7.0
        CFNotify = 0x0181, // updated 7.0
        SystemLogMessage = 0x02F7, // updated 7.0
        AirshipTimers = 0x021F, // updated 7.0
        SubmarineTimers = 0x017D, // updated 7.0
        AirshipStatusList = 0x00AE, // updated 7.0
        AirshipStatus = 0x0393, // updated 7.0
        AirshipExplorationResult = 0x0132, // updated 7.0
        SubmarineProgressionStatus = 0x00BC, // updated 7.0
        SubmarineStatusList = 0x0192, // updated 7.0
        SubmarineExplorationResult = 0x0217, // updated 7.0

        ActorMove = 0x0346, // updated 7.0

        EventPlay = 0x020E, // updated 7.0
        EventPlay4 = 0x0080, // updated 7.0
        EventPlay8 = 0x0148, // updated 7.0
        EventPlay16 = 0x018A, // updated 7.0
        EventPlay32 = 0x00B5, // updated 7.0
        EventPlay64 = 0x0360, // updated 7.0
        EventPlay128 = 0x0380, // updated 7.0
        EventPlay255 = 0x0082, // updated 7.0

        EnvironmentControl = 0x00FF, // updated 7.0
        IslandWorkshopSupplyDemand = 0x0106, // updated 7.0
        Logout = 0x0269, // updated 7.0
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03E4, // updated 7.0
        ClientTrigger = 0x0318, // updated 7.0
        SetSearchInfoHandler = 0x0143, // updated 7.0
        MarketBoardPurchaseHandler = 0x03BA, // updated 7.0
        InventoryModifyHandler = 0x030E, // updated 7.0
        UpdatePositionInstance = 0x0300, // updated 7.0
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