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
        PlayerSetup = 0x0256, // updated 7.4h2
        UpdateHpMpTp = 0x0363, // updated 7.4h2
        UpdateClassInfo = 0x00A0, // updated 7.4h2
        PlayerStats = 0x01E1, // updated 7.4h2
        ActorControl = 0x019B, // updated 7.4h2
        ActorControlSelf = 0x0347, // updated 7.4h2
        ActorControlTarget = 0x03D9, // updated 7.4h2
        Playtime = 0x02A2, // updated 7.4h2
        UpdateSearchInfo = 0x01B7, // updated 7.4h2
        ExamineSearchInfo = 0x026E, // updated 7.4h2
        Examine = 0x0177, // updated 7.4h2
        ActorCast = 0x02F2, // updated 7.4h2
        CurrencyCrystalInfo = 0x0106, // updated 7.4h2
        InitZone = 0x0242, // updated 7.4h2
        WeatherChange = 0x03E7, // updated 7.4h2
        PlayerSpawn = 0x00CA, // updated 7.4h2
        ActorSetPos = 0x01CC, // updated 7.4h2
        PrepareZoning = 0x0137, // updated 7.4h2
        ContainerInfo = 0x0240, // updated 7.4h2
        ItemInfo = 0x00EB, // updated 7.4h2
        PlaceFieldMarker = 0x02EC, // updated 7.4h2
        PlaceFieldMarkerPreset = 0x03DF, // updated 7.4h2
        EffectResult = 0x025E, // updated 7.4h2
        EventStart = 0x03DA, // updated 7.4h2
        EventFinish = 0x034A, // updated 7.4h2
        DesynthResult = 0x02F1, // updated 7.4h2
        FreeCompanyInfo = 0x006E, // updated 7.4h2
        FreeCompanyDialog = 0x0105, // updated 7.4h2
        MarketBoardSearchResult = 0x02EE, // updated 7.4h2
        MarketBoardItemListingCount = 0x01D8, // updated 7.4h2
        MarketBoardItemListingHistory = 0x025C, // updated 7.4h2
        MarketBoardItemListing = 0x01AD, // updated 7.4h2
        MarketBoardPurchase = 0x02FA, // updated 7.4h2
        UpdateInventorySlot = 0x012B, // updated 7.4h2
        InventoryActionAck = 0x021A, // updated 7.4h2
        InventoryTransaction = 0x02B7, // updated 7.4h2
        InventoryTransactionFinish = 0x0131, // updated 7.4h2
        ResultDialog = 0x00BD, // updated 7.4h2
        RetainerInformation = 0x0081, // updated 7.4h2
        NpcSpawn = 0x039B, // updated 7.4h2
        ItemMarketBoardInfo = 0x0356, // updated 7.4h2
        ObjectSpawn = 0x0307, // updated 7.4h2
        EffectResultBasic = 0x03A2, // updated 7.4h2
        Effect = 0x03D8, // updated 7.4h2
        StatusEffectList = 0x0253, // updated 7.4h2
        StatusEffectList2 = 0x0285, // updated 7.4h2
        StatusEffectList3 = 0x029C, // updated 7.4h2
        ActorGauge = 0x009C, // updated 7.4h2
        CFNotify = 0x03A7, // updated 7.4h2
        SystemLogMessage = 0x015D, // updated 7.4h2
        AirshipTimers = 0x03D5, // updated 7.4h2
        SubmarineTimers = 0x0139, // updated 7.4h2
        AirshipStatusList = 0x0152, // updated 7.4h2
        AirshipStatus = 0x00FA, // updated 7.4h2
        AirshipExplorationResult = 0x0248, // updated 7.4h2
        SubmarineProgressionStatus = 0x0367, // updated 7.4h2
        SubmarineStatusList = 0x0263, // updated 7.4h2
        SubmarineExplorationResult = 0x030A, // updated 7.4h2

        CraftingLog = 0x03AE, // updated 7.4h2
        GatheringLog = 0x00AA, // updated 7.4h2

        ActorMove = 0x02D4, // updated 7.4h2

        EventPlay = 0x0332, // updated 7.4h2
        EventPlay4 = 0x009F, // updated 7.4h2
        EventPlay8 = 0x0283, // updated 7.4h2
        EventPlay16 = 0x00DA, // updated 7.4h2
        EventPlay32 = 0x00CF, // updated 7.4h2
        EventPlay64 = 0x03CC, // updated 7.4h2
        EventPlay128 = 0x00A2, // updated 7.4h2
        EventPlay255 = 0x0187, // updated 7.4h2

        EnvironmentControl = 0x0223, // updated 7.4h2
        IslandWorkshopSupplyDemand = 0x0074, // updated 7.4h2
        Logout = 0x0124, // updated 7.4h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03AD, // updated 7.4h2
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x01D9, // updated 7.4h2
        MarketBoardPurchaseHandler = 0x03AB, // updated 7.4h2
        InventoryModifyHandler = 0x038C, // updated 7.4h2
        //UpdatePositionInstance = 0x03CE, // updated 7.0h
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
