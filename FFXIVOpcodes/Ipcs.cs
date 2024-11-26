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
        PlayerSetup = 0x036D, // updated 7.11
        UpdateHpMpTp = 0x010E, // updated 7.11
        UpdateClassInfo = 0x00F8, // updated 7.11
        PlayerStats = 0x03B9, // updated 7.11
        ActorControl = 0x01C5, // updated 7.11
        ActorControlSelf = 0x018B, // updated 7.11
        ActorControlTarget = 0x038F, // updated 7.11
        Playtime = 0x03B7, // updated 7.11
        UpdateSearchInfo = 0x0381, // updated 7.11
        ExamineSearchInfo = 0x0237, // updated 7.11
        Examine = 0x033D, // updated 7.11
        ActorCast = 0x01E1, // updated 7.11
        CurrencyCrystalInfo = 0x03B3, // updated 7.11
        InitZone = 0x0247, // updated 7.11
        WeatherChange = 0x031D, // updated 7.11
        PlayerSpawn = 0x012A, // updated 7.11
        ActorSetPos = 0x0112, // updated 7.11
        PrepareZoning = 0x014D, // updated 7.11
        ContainerInfo = 0x00F1, // updated 7.11
        ItemInfo = 0x0380, // updated 7.11
        PlaceFieldMarker = 0x011B, // updated 7.11
        PlaceFieldMarkerPreset = 0x0207, // updated 7.11
        EffectResult = 0x018F, // updated 7.11
        EventStart = 0x02B5, // updated 7.11
        EventFinish = 0x01E9, // updated 7.11
        DesynthResult = 0x0353, // updated 7.11
        FreeCompanyInfo = 0x01CA, // updated 7.11
        FreeCompanyDialog = 0x022C, // updated 7.11
        MarketBoardSearchResult = 0x022F, // updated 7.11
        MarketBoardItemListingCount = 0x01EC, // updated 7.11
        MarketBoardItemListingHistory = 0x01A2, // updated 7.11
        MarketBoardItemListing = 0x0311, // updated 7.11
        MarketBoardPurchase = 0x0225, // updated 7.11
        UpdateInventorySlot = 0x03D4, // updated 7.11
        InventoryActionAck = 0x03E7, // updated 7.11
        InventoryTransaction = 0x028B, // updated 7.11
        InventoryTransactionFinish = 0x033E, // updated 7.11
        ResultDialog = 0x009A, // updated 7.11
        RetainerInformation = 0x00D4, // updated 7.11
        NpcSpawn = 0x03A3, // updated 7.11
        ItemMarketBoardInfo = 0x0104, // updated 7.11
        ObjectSpawn = 0x0136, // updated 7.11
        EffectResultBasic = 0x02FA, // updated 7.11
        Effect = 0x0199, // updated 7.11
        StatusEffectList = 0x02C9, // updated 7.11
        StatusEffectList2 = 0x0201, // updated 7.11
        StatusEffectList3 = 0x0399, // updated 7.11
        ActorGauge = 0x0350, // updated 7.11
        CFNotify = 0x013F, // updated 7.11
        SystemLogMessage = 0x010C, // updated 7.11
        AirshipTimers = 0x0097, // updated 7.11
        SubmarineTimers = 0x02BA, // updated 7.11
        AirshipStatusList = 0x0360, // updated 7.11
        AirshipStatus = 0x039A, // updated 7.11
        AirshipExplorationResult = 0x0286, // updated 7.11
        SubmarineProgressionStatus = 0x0356, // updated 7.11
        SubmarineStatusList = 0x0368, // updated 7.11
        SubmarineExplorationResult = 0x016B, // updated 7.11

        CraftingLog = 0x00A6, // updated 7.11
        GatheringLog = 0x0284, // updated 7.11

        ActorMove = 0x02E7, // updated 7.11

        EventPlay = 0x0206, // updated 7.11
        EventPlay4 = 0x039D, // updated 7.11
        EventPlay8 = 0x036F, // updated 7.11
        EventPlay16 = 0x0301, // updated 7.11
        EventPlay32 = 0x00FA, // updated 7.11
        EventPlay64 = 0x02C7, // updated 7.11
        EventPlay128 = 0x01DA, // updated 7.11
        EventPlay255 = 0x0159, // updated 7.11

        EnvironmentControl = 0x014C, // updated 7.11
        IslandWorkshopSupplyDemand = 0x02FF, // updated 7.11
        Logout = 0x0304, // updated 7.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02A8, // updated 7.11
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0320, // updated 7.11
        MarketBoardPurchaseHandler = 0x03D5, // updated 7.11
        InventoryModifyHandler = 0x00E3, // updated 7.11
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