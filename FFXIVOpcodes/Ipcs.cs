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
        PlayerSetup = 0x036A, // updated 7.16h
        UpdateHpMpTp = 0x02F9, // updated 7.16h
        UpdateClassInfo = 0x0103, // updated 7.16h
        PlayerStats = 0x0342, // updated 7.16h
        ActorControl = 0x01E2, // updated 7.16h
        ActorControlSelf = 0x0393, // updated 7.16h
        ActorControlTarget = 0x027F, // updated 7.16h
        Playtime = 0x039D, // updated 7.16h
        UpdateSearchInfo = 0x01D5, // updated 7.16h
        ExamineSearchInfo = 0x0146, // updated 7.16h
        Examine = 0x03E1, // updated 7.16h
        ActorCast = 0x006B, // updated 7.16h
        CurrencyCrystalInfo = 0x03B0, // updated 7.16h
        InitZone = 0x02F0, // updated 7.16h
        WeatherChange = 0x00B7, // updated 7.16h
        PlayerSpawn = 0x0325, // updated 7.16h
        ActorSetPos = 0x02E5, // updated 7.16h
        PrepareZoning = 0x02BF, // updated 7.16h
        ContainerInfo = 0x0250, // updated 7.16h
        ItemInfo = 0x0119, // updated 7.16h
        PlaceFieldMarker = 0x0091, // updated 7.16h
        PlaceFieldMarkerPreset = 0x0199, // updated 7.16h
        EffectResult = 0x02EE, // updated 7.16h
        EventStart = 0x00C1, // updated 7.16h
        EventFinish = 0x0381, // updated 7.16h
        DesynthResult = 0x0302, // updated 7.16h
        FreeCompanyInfo = 0x0314, // updated 7.16h
        FreeCompanyDialog = 0x0333, // updated 7.16h
        MarketBoardSearchResult = 0x01BD, // updated 7.16h
        MarketBoardItemListingCount = 0x027B, // updated 7.16h
        MarketBoardItemListingHistory = 0x00BF, // updated 7.16h
        MarketBoardItemListing = 0x01DE, // updated 7.16h
        MarketBoardPurchase = 0x02E3, // updated 7.16h
        UpdateInventorySlot = 0x0178, // updated 7.16h
        InventoryActionAck = 0x00FA, // updated 7.16h
        InventoryTransaction = 0x018A, // updated 7.16h
        InventoryTransactionFinish = 0x00CC, // updated 7.16h
        ResultDialog = 0x0162, // updated 7.16h
        RetainerInformation = 0x0170, // updated 7.16h
        NpcSpawn = 0x039A, // updated 7.16h
        ItemMarketBoardInfo = 0x01D8, // updated 7.16h
        ObjectSpawn = 0x0254, // updated 7.16h
        EffectResultBasic = 0x01D3, // updated 7.16h
        Effect = 0x01FC, // updated 7.16h
        StatusEffectList = 0x039B, // updated 7.16h
        StatusEffectList2 = 0x01F9, // updated 7.16h
        StatusEffectList3 = 0x0263, // updated 7.16h
        ActorGauge = 0x0385, // updated 7.16h
        CFNotify = 0x02FD, // updated 7.16h
        SystemLogMessage = 0x0196, // updated 7.16h
        AirshipTimers = 0x01EC, // updated 7.16h
        SubmarineTimers = 0x026C, // updated 7.16h
        AirshipStatusList = 0x02A9, // updated 7.16h
        AirshipStatus = 0x015B, // updated 7.16h
        AirshipExplorationResult = 0x03B9, // updated 7.16h
        SubmarineProgressionStatus = 0x0255, // updated 7.16h
        SubmarineStatusList = 0x00F2, // updated 7.16h
        SubmarineExplorationResult = 0x01BB, // updated 7.16h

        CraftingLog = 0x0206, // updated 7.16h
        GatheringLog = 0x00CA, // updated 7.16h

        ActorMove = 0x01A5, // updated 7.16h

        EventPlay = 0x0159, // updated 7.16h
        EventPlay4 = 0x0122, // updated 7.16h
        EventPlay8 = 0x018D, // updated 7.16h
        EventPlay16 = 0x00DA, // updated 7.16h
        EventPlay32 = 0x02C7, // updated 7.16h
        EventPlay64 = 0x021C, // updated 7.16h
        EventPlay128 = 0x014D, // updated 7.16h
        EventPlay255 = 0x026E, // updated 7.16h

        EnvironmentControl = 0x00A0, // updated 7.16h
        IslandWorkshopSupplyDemand = 0x022D, // updated 7.16h
        Logout = 0x01C9, // updated 7.16h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x025B, // updated 7.16h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0236, // updated 7.16h
        MarketBoardPurchaseHandler = 0x035D, // updated 7.16h
        InventoryModifyHandler = 0x016A, // updated 7.16h
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