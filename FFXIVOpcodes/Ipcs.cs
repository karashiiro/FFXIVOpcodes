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
        PlayerSetup = 0x0359, // updated 7.3h
        UpdateHpMpTp = 0x01B4, // updated 7.3h
        UpdateClassInfo = 0x022D, // updated 7.3h
        PlayerStats = 0x00E6, // updated 7.3h
        ActorControl = 0x02E0, // updated 7.3h
        ActorControlSelf = 0x01F4, // updated 7.3h
        ActorControlTarget = 0x0187, // updated 7.3h
        Playtime = 0x0171, // updated 7.3h
        UpdateSearchInfo = 0x009F, // updated 7.3h
        ExamineSearchInfo = 0x0202, // updated 7.3h
        Examine = 0x031B, // updated 7.3h
        ActorCast = 0x026F, // updated 7.3h
        CurrencyCrystalInfo = 0x03A1, // updated 7.3h
        InitZone = 0x036C, // updated 7.3h
        WeatherChange = 0x0350, // updated 7.3h
        PlayerSpawn = 0x037A, // updated 7.3h
        ActorSetPos = 0x01B2, // updated 7.3h
        PrepareZoning = 0x028D, // updated 7.3h
        ContainerInfo = 0x03AA, // updated 7.3h
        ItemInfo = 0x02A4, // updated 7.3h
        PlaceFieldMarker = 0x01C0, // updated 7.3h
        PlaceFieldMarkerPreset = 0x02B5, // updated 7.3h
        EffectResult = 0x01BD, // updated 7.3h
        EventStart = 0x0253, // updated 7.3h
        EventFinish = 0x039F, // updated 7.3h
        DesynthResult = 0x01D9, // updated 7.3h
        FreeCompanyInfo = 0x0154, // updated 7.3h
        FreeCompanyDialog = 0x0258, // updated 7.3h
        MarketBoardSearchResult = 0x027C, // updated 7.3h
        MarketBoardItemListingCount = 0x03CD, // updated 7.3h
        MarketBoardItemListingHistory = 0x0077, // updated 7.3h
        MarketBoardItemListing = 0x0103, // updated 7.3h
        MarketBoardPurchase = 0x00A5, // updated 7.3h
        UpdateInventorySlot = 0x023E, // updated 7.3h
        InventoryActionAck = 0x016A, // updated 7.3h
        InventoryTransaction = 0x0192, // updated 7.3h
        InventoryTransactionFinish = 0x03B4, // updated 7.3h
        ResultDialog = 0x0150, // updated 7.3h
        RetainerInformation = 0x02A9, // updated 7.3h
        NpcSpawn = 0x00C4, // updated 7.3h
        ItemMarketBoardInfo = 0x0153, // updated 7.3h
        ObjectSpawn = 0x009A, // updated 7.3h
        EffectResultBasic = 0x0269, // updated 7.3h
        Effect = 0x0247, // updated 7.3h
        StatusEffectList = 0x02C9, // updated 7.3h
        StatusEffectList2 = 0x0384, // updated 7.3h
        StatusEffectList3 = 0x0100, // updated 7.3h
        ActorGauge = 0x014F, // updated 7.3h
        CFNotify = 0x019F, // updated 7.3h
        SystemLogMessage = 0x0317, // updated 7.3h
        AirshipTimers = 0x037F, // updated 7.3h
        SubmarineTimers = 0x01B0, // updated 7.3h
        AirshipStatusList = 0x00B3, // updated 7.3h
        AirshipStatus = 0x0262, // updated 7.3h
        AirshipExplorationResult = 0x0084, // updated 7.3h
        SubmarineProgressionStatus = 0x016C, // updated 7.3h
        SubmarineStatusList = 0x0356, // updated 7.3h
        SubmarineExplorationResult = 0x01ED, // updated 7.3h

        CraftingLog = 0x0204, // updated 7.3h
        GatheringLog = 0x012D, // updated 7.3h

        ActorMove = 0x0096, // updated 7.3h

        EventPlay = 0x00A3, // updated 7.3h
        EventPlay4 = 0x0074, // updated 7.3h
        EventPlay8 = 0x02AA, // updated 7.3h
        EventPlay16 = 0x0388, // updated 7.3h
        EventPlay32 = 0x010C, // updated 7.3h
        EventPlay64 = 0x03AD, // updated 7.3h
        EventPlay128 = 0x011A, // updated 7.3h
        EventPlay255 = 0x0075, // updated 7.3h

        EnvironmentControl = 0x0272, // updated 7.3h
        IslandWorkshopSupplyDemand = 0x01CB, // updated 7.3h
        Logout = 0x0172, // updated 7.3h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0175, // updated 7.3h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x024D, // updated 7.3h
        MarketBoardPurchaseHandler = 0x0073, // updated 7.3h
        InventoryModifyHandler = 0x009D, // updated 7.3h
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