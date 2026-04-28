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
        PlayerSetup = 0x0354, // updated 7.5
        UpdateHpMpTp = 0x03BD, // updated 7.5
        UpdateClassInfo = 0x022C, // updated 7.5
        PlayerStats = 0x0072, // updated 7.5
        ActorControl = 0x0328, // updated 7.5
        ActorControlSelf = 0x03E7, // updated 7.5
        ActorControlTarget = 0x03AA, // updated 7.5
        Playtime = 0x025C, // updated 7.5
        UpdateSearchInfo = 0x00F2, // updated 7.5
        ExamineSearchInfo = 0x0113, // updated 7.5
        Examine = 0x016B, // updated 7.5
        ActorCast = 0x0345, // updated 7.5
        CurrencyCrystalInfo = 0x0103, // updated 7.5
        InitZone = 0x0098, // updated 7.5
        WeatherChange = 0x0120, // updated 7.5
        PlayerSpawn = 0x0343, // updated 7.5
        ActorSetPos = 0x0154, // updated 7.5
        PrepareZoning = 0x032C, // updated 7.5
        ContainerInfo = 0x01DC, // updated 7.5
        ItemInfo = 0x013B, // updated 7.5
        PlaceFieldMarker = 0x02D7, // updated 7.5
        PlaceFieldMarkerPreset = 0x0235, // updated 7.5
        EffectResult = 0x00EA, // updated 7.5
        EventStart = 0x02C1, // updated 7.5
        EventFinish = 0x020F, // updated 7.5
        DesynthResult = 0x0227, // updated 7.5
        FreeCompanyInfo = 0x028A, // updated 7.5
        FreeCompanyDialog = 0x00B9, // updated 7.5
        MarketBoardSearchResult = 0x00AD, // updated 7.5
        MarketBoardItemListingCount = 0x0342, // updated 7.5
        MarketBoardItemListingHistory = 0x020A, // updated 7.5
        MarketBoardItemListing = 0x036F, // updated 7.5
        MarketBoardPurchase = 0x03C2, // updated 7.5
        UpdateInventorySlot = 0x00BC, // updated 7.5
        InventoryActionAck = 0x030A, // updated 7.5
        InventoryTransaction = 0x03DF, // updated 7.5
        InventoryTransactionFinish = 0x0205, // updated 7.5
        ResultDialog = 0x023F, // updated 7.5
        RetainerInformation = 0x02ED, // updated 7.5
        NpcSpawn = 0x02AE, // updated 7.5
        ItemMarketBoardInfo = 0x02C2, // updated 7.5
        ObjectSpawn = 0x0245, // updated 7.5
        EffectResultBasic = 0x01C3, // updated 7.5
        Effect = 0x039A, // updated 7.5
        StatusEffectList = 0x0117, // updated 7.5
        StatusEffectList2 = 0x012B, // updated 7.5
        StatusEffectList3 = 0x0336, // updated 7.5
        ActorGauge = 0x0322, // updated 7.5
        CFNotify = 0x025F, // updated 7.5
        SystemLogMessage = 0x01E2, // updated 7.5
        AirshipTimers = 0x008F, // updated 7.5
        SubmarineTimers = 0x019C, // updated 7.5
        AirshipStatusList = 0x0338, // updated 7.5
        AirshipStatus = 0x0191, // updated 7.5
        AirshipExplorationResult = 0x014B, // updated 7.5
        SubmarineProgressionStatus = 0x0294, // updated 7.5
        SubmarineStatusList = 0x030C, // updated 7.5
        SubmarineExplorationResult = 0x03B8, // updated 7.5

        CraftingLog = 0x026C, // updated 7.5
        GatheringLog = 0x0204, // updated 7.5

        ActorMove = 0x00D3, // updated 7.5

        EventPlay = 0x03B9, // updated 7.5
        EventPlay4 = 0x0175, // updated 7.5
        EventPlay8 = 0x0230, // updated 7.5
        EventPlay16 = 0x034E, // updated 7.5
        EventPlay32 = 0x0296, // updated 7.5
        EventPlay64 = 0x00C3, // updated 7.5
        EventPlay128 = 0x00C2, // updated 7.5
        EventPlay255 = 0x00B2, // updated 7.5

        EnvironmentControl = 0x01FF, // updated 7.5
        IslandWorkshopSupplyDemand = 0x01D1, // updated 7.5
        Logout = 0x0334, // updated 7.5
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0118, // updated 7.5
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0305, // updated 7.5
        MarketBoardPurchaseHandler = 0x030B, // updated 7.5
        InventoryModifyHandler = 0x037B, // updated 7.5
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