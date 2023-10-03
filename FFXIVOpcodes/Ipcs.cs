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
        PlayerSetup = 0x006D, // updated 6.5
        UpdateHpMpTp = 0x022F, // updated 6.5
        UpdateClassInfo = 0x00FA, // updated 6.5
        PlayerStats = 0x033C, // updated 6.5
        ActorControl = 0x0243, // updated 6.5
        ActorControlSelf = 0x0196, // updated 6.5
        ActorControlTarget = 0x01A2, // updated 6.5
        Playtime = 0x0378, // updated 6.5
        UpdateSearchInfo = 0x0242, // updated 6.5
        ExamineSearchInfo = 0x0116, // updated 6.5
        Examine = 0x03BC, // updated 6.5
        ActorCast = 0x0396, // updated 6.5
        CurrencyCrystalInfo = 0x02AD, // updated 6.5
        InitZone = 0x038F, // updated 6.5
        WeatherChange = 0x03DA, // updated 6.5
        PlayerSpawn = 0x0379, // updated 6.5
        ActorSetPos = 0x0280, // updated 6.5
        PrepareZoning = 0x01F3, // updated 6.5
        ContainerInfo = 0x01B5, // updated 6.5
        ItemInfo = 0x015B, // updated 6.5
        PlaceFieldMarker = 0x0212, // updated 6.5
        PlaceFieldMarkerPreset = 0x01BD, // updated 6.5
        EffectResult = 0x0197, // updated 6.5
        EventStart = 0x0109, // updated 6.5
        EventFinish = 0x02D1, // updated 6.5
        DesynthResult = 0x01AD, // updated 6.5
        FreeCompanyInfo = 0x02B1, // updated 6.5
        FreeCompanyDialog = 0x0391, // updated 6.5
        MarketBoardSearchResult = 0x0169, // updated 6.5
        MarketBoardItemListingCount = 0x0168, // updated 6.5
        MarketBoardItemListingHistory = 0x039F, // updated 6.5
        MarketBoardItemListing = 0x0233, // updated 6.5
        MarketBoardPurchase = 0x0133, // updated 6.5
        UpdateInventorySlot = 0x0369, // updated 6.5
        InventoryActionAck = 0x034C, // updated 6.5
        InventoryTransaction = 0x011D, // updated 6.5
        InventoryTransactionFinish = 0x029A, // updated 6.5
        ResultDialog = 0x01C3, // updated 6.5
        RetainerInformation = 0x03D5, // updated 6.5
        NpcSpawn = 0x03E2, // updated 6.5
        ItemMarketBoardInfo = 0x033A, // updated 6.5
        ObjectSpawn = 0x02C2, // updated 6.5
        EffectResultBasic = 0x01AF, // updated 6.5
        Effect = 0x0222, // updated 6.5
        StatusEffectList = 0x0237, // updated 6.5
        StatusEffectList2 = 0x026A, // updated 6.5
        StatusEffectList3 = 0x0202, // updated 6.5
        ActorGauge = 0x0319, // updated 6.5
        CFNotify = 0x010C, // updated 6.5
        SystemLogMessage = 0x0089, // updated 6.5
        AirshipTimers = 0x020C, // updated 6.5
        SubmarineTimers = 0x0354, // updated 6.5
        AirshipStatusList = 0x01DF, // updated 6.5
        AirshipStatus = 0x01C9, // updated 6.5
        AirshipExplorationResult = 0x00ED, // updated 6.5
        SubmarineProgressionStatus = 0x009E, // updated 6.5
        SubmarineStatusList = 0x0390, // updated 6.5
        SubmarineExplorationResult = 0x032E, // updated 6.5

        ActorMove = 0x0173, // updated 6.5

        EventPlay = 0x036E, // updated 6.5
        EventPlay4 = 0x0153, // updated 6.5
        EventPlay8 = 0x035D, // updated 6.5
        EventPlay16 = 0x01F0, // updated 6.5
        EventPlay32 = 0x02A7, // updated 6.5
        EventPlay64 = 0x0175, // updated 6.5
        EventPlay128 = 0x0296, // updated 6.5
        EventPlay255 = 0x0305, // updated 6.5

        EnvironmentControl = 0x0154, // updated 6.5
        IslandWorkshopSupplyDemand = 0x02A9, // updated 6.5
        Logout = 0x03B0, // updated 6.5
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0297, // updated 6.5
        ClientTrigger = 0x01F6, // updated 6.5
        ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x035A, // updated 6.5
        MarketBoardPurchaseHandler = 0x02F2, // updated 6.5
        InventoryModifyHandler = 0x02E5, // updated 6.5 (Base offset: 0x02EC)
        UpdatePositionInstance = 0x0294, // updated 6.5
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
