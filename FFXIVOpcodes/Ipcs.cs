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
        PlayerSetup = 0x00DA, // updated 7.2
        UpdateHpMpTp = 0x0145, // updated 7.2
        UpdateClassInfo = 0x0077, // updated 7.2
        PlayerStats = 0x0191, // updated 7.2
        ActorControl = 0x0208, // updated 7.2
        ActorControlSelf = 0x016F, // updated 7.2
        ActorControlTarget = 0x00E0, // updated 7.2
        Playtime = 0x0241, // updated 7.2
        UpdateSearchInfo = 0x00C7, // updated 7.2
        ExamineSearchInfo = 0x0257, // updated 7.2
        Examine = 0x01D6, // updated 7.2
        ActorCast = 0x017A, // updated 7.2
        CurrencyCrystalInfo = 0x0196, // updated 7.2
        InitZone = 0x02BB, // updated 7.2
        WeatherChange = 0x0175, // updated 7.2
        PlayerSpawn = 0x0331, // updated 7.2
        ActorSetPos = 0x0088, // updated 7.2
        PrepareZoning = 0x016C, // updated 7.2
        ContainerInfo = 0x0236, // updated 7.2
        ItemInfo = 0x0352, // updated 7.2
        PlaceFieldMarker = 0x0239, // updated 7.2
        PlaceFieldMarkerPreset = 0x019D, // updated 7.2
        EffectResult = 0x037B, // updated 7.2
        EventStart = 0x03BB, // updated 7.2
        EventFinish = 0x0246, // updated 7.2
        DesynthResult = 0x0280, // updated 7.2
        FreeCompanyInfo = 0x01BF, // updated 7.2
        FreeCompanyDialog = 0x0270, // updated 7.2
        MarketBoardSearchResult = 0x0136, // updated 7.2
        MarketBoardItemListingCount = 0x009D, // updated 7.2
        MarketBoardItemListingHistory = 0x030E, // updated 7.2
        MarketBoardItemListing = 0x01D1, // updated 7.2
        MarketBoardPurchase = 0x019F, // updated 7.2
        UpdateInventorySlot = 0x0118, // updated 7.2
        InventoryActionAck = 0x0106, // updated 7.2
        InventoryTransaction = 0x00C1, // updated 7.2
        InventoryTransactionFinish = 0x024B, // updated 7.2
        ResultDialog = 0x023B, // updated 7.2
        RetainerInformation = 0x015C, // updated 7.2
        NpcSpawn = 0x013F, // updated 7.2
        ItemMarketBoardInfo = 0x0264, // updated 7.2
        ObjectSpawn = 0x03C9, // updated 7.2
        EffectResultBasic = 0x0320, // updated 7.2
        Effect = 0x0311, // updated 7.2
        StatusEffectList = 0x0347, // updated 7.2
        StatusEffectList2 = 0x02E8, // updated 7.2
        StatusEffectList3 = 0x02C7, // updated 7.2
        ActorGauge = 0x03B2, // updated 7.2
        CFNotify = 0x022D, // updated 7.2
        SystemLogMessage = 0x0282, // updated 7.2
        AirshipTimers = 0x038B, // updated 7.2
        SubmarineTimers = 0x0240, // updated 7.2
        AirshipStatusList = 0x03DB, // updated 7.2
        AirshipStatus = 0x0340, // updated 7.2
        AirshipExplorationResult = 0x029E, // updated 7.2
        SubmarineProgressionStatus = 0x0225, // updated 7.2
        SubmarineStatusList = 0x00D6, // updated 7.2
        SubmarineExplorationResult = 0x0076, // updated 7.2

        CraftingLog = 0x01C8, // updated 7.2
        GatheringLog = 0x01BC, // updated 7.2

        ActorMove = 0x0159, // updated 7.2

        EventPlay = 0x03DF, // updated 7.2
        EventPlay4 = 0x007E, // updated 7.2
        EventPlay8 = 0x0227, // updated 7.2
        EventPlay16 = 0x0081, // updated 7.2
        EventPlay32 = 0x0315, // updated 7.2
        EventPlay64 = 0x02FF, // updated 7.2
        EventPlay128 = 0x00E6, // updated 7.2
        EventPlay255 = 0x01D3, // updated 7.2

        EnvironmentControl = 0x00F2, // updated 7.2
        IslandWorkshopSupplyDemand = 0x0322, // updated 7.2
        Logout = 0x0069, // updated 7.2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0231, // updated 7.2
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x020A, // updated 7.2
        MarketBoardPurchaseHandler = 0x023A, // updated 7.2
        InventoryModifyHandler = 0x013E, // updated 7.2
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