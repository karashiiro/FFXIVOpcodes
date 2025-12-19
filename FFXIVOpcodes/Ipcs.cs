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
        PlayerSetup = 0x036F, // updated 7.4h
        UpdateHpMpTp = 0x0167, // updated 7.4h
        UpdateClassInfo = 0x0379, // updated 7.4h
        PlayerStats = 0x02BF, // updated 7.4h
        ActorControl = 0x00D8, // updated 7.4h
        ActorControlSelf = 0x038A, // updated 7.4h
        ActorControlTarget = 0x03E3, // updated 7.4h
        Playtime = 0x0107, // updated 7.4h
        UpdateSearchInfo = 0x012B, // updated 7.4h
        ExamineSearchInfo = 0x039D, // updated 7.4h
        Examine = 0x03C9, // updated 7.4h
        ActorCast = 0x0385, // updated 7.4h
        CurrencyCrystalInfo = 0x0290, // updated 7.4h
        InitZone = 0x012E, // updated 7.4h
        WeatherChange = 0x006A, // updated 7.4h
        PlayerSpawn = 0x018B, // updated 7.4h
        ActorSetPos = 0x01F8, // updated 7.4h
        PrepareZoning = 0x03C2, // updated 7.4h
        ContainerInfo = 0x0125, // updated 7.4h
        ItemInfo = 0x022C, // updated 7.4h
        PlaceFieldMarker = 0x014E, // updated 7.4h
        PlaceFieldMarkerPreset = 0x02A7, // updated 7.4h
        EffectResult = 0x020E, // updated 7.4h
        EventStart = 0x0076, // updated 7.4h
        EventFinish = 0x00AF, // updated 7.4h
        DesynthResult = 0x02C8, // updated 7.4h
        FreeCompanyInfo = 0x027E, // updated 7.4h
        FreeCompanyDialog = 0x034F, // updated 7.4h
        MarketBoardSearchResult = 0x01B7, // updated 7.4h
        MarketBoardItemListingCount = 0x0368, // updated 7.4h
        MarketBoardItemListingHistory = 0x026B, // updated 7.4h
        MarketBoardItemListing = 0x0147, // updated 7.4h
        MarketBoardPurchase = 0x01C5, // updated 7.4h
        UpdateInventorySlot = 0x00B2, // updated 7.4h
        InventoryActionAck = 0x02A0, // updated 7.4h
        InventoryTransaction = 0x035F, // updated 7.4h
        InventoryTransactionFinish = 0x0254, // updated 7.4h
        ResultDialog = 0x030F, // updated 7.4h
        RetainerInformation = 0x02DE, // updated 7.4h
        NpcSpawn = 0x011E, // updated 7.4h
        ItemMarketBoardInfo = 0x02E6, // updated 7.4h
        ObjectSpawn = 0x01B8, // updated 7.4h
        EffectResultBasic = 0x02F2, // updated 7.4h
        Effect = 0x00C1, // updated 7.4h
        StatusEffectList = 0x03D7, // updated 7.4h
        StatusEffectList2 = 0x019F, // updated 7.4h
        StatusEffectList3 = 0x0101, // updated 7.4h
        ActorGauge = 0x0074, // updated 7.4h
        CFNotify = 0x0214, // updated 7.4h
        SystemLogMessage = 0x0287, // updated 7.4h
        AirshipTimers = 0x008F, // updated 7.4h
        SubmarineTimers = 0x0228, // updated 7.4h
        AirshipStatusList = 0x02C7, // updated 7.4h
        AirshipStatus = 0x0134, // updated 7.4h
        AirshipExplorationResult = 0x00E0, // updated 7.4h
        SubmarineProgressionStatus = 0x025F, // updated 7.4h
        SubmarineStatusList = 0x0215, // updated 7.4h
        SubmarineExplorationResult = 0x03C5, // updated 7.4h

        CraftingLog = 0x00CD, // updated 7.4h
        GatheringLog = 0x017A, // updated 7.4h

        ActorMove = 0x0266, // updated 7.4h

        EventPlay = 0x0250, // updated 7.4h
        EventPlay4 = 0x0267, // updated 7.4h
        EventPlay8 = 0x02D7, // updated 7.4h
        EventPlay16 = 0x0169, // updated 7.4h
        EventPlay32 = 0x0270, // updated 7.4h
        EventPlay64 = 0x0119, // updated 7.4h
        EventPlay128 = 0x03E7, // updated 7.4h
        EventPlay255 = 0x03BF, // updated 7.4h

        EnvironmentControl = 0x0127, // updated 7.4h
        IslandWorkshopSupplyDemand = 0x0226, // updated 7.4h
        Logout = 0x007C, // updated 7.4h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01D7, // updated 7.4h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0132, // updated 7.4h
        MarketBoardPurchaseHandler = 0x0238, // updated 7.4h
        InventoryModifyHandler = 0x028C, // updated 7.4h
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