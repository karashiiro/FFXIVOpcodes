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
        PlayerSetup = 0x016E, // updated 7.01
        UpdateHpMpTp = 0x03D7, // updated 7.01
        UpdateClassInfo = 0x02DC, // updated 7.01
        PlayerStats = 0x03DE, // updated 7.01
        ActorControl = 0x02DF, // updated 7.01
        ActorControlSelf = 0x0251, // updated 7.01
        ActorControlTarget = 0x0110, // updated 7.01
        Playtime = 0x0147, // updated 7.01
        UpdateSearchInfo = 0x037B, // updated 7.01
        ExamineSearchInfo = 0x031C, // updated 7.01
        Examine = 0x0338, // updated 7.01
        ActorCast = 0x03B3, // updated 7.01
        CurrencyCrystalInfo = 0x00D3, // updated 7.01
        InitZone = 0x023D, // updated 7.01
        WeatherChange = 0x00A3, // updated 7.01
        PlayerSpawn = 0x0154, // updated 7.01
        ActorSetPos = 0x023A, // updated 7.01
        PrepareZoning = 0x025C, // updated 7.01
        ContainerInfo = 0x02F6, // updated 7.01
        ItemInfo = 0x0197, // updated 7.01
        PlaceFieldMarker = 0x01A2, // updated 7.01
        PlaceFieldMarkerPreset = 0x0139, // updated 7.01
        EffectResult = 0x0237, // updated 7.01
        EventStart = 0x01C3, // updated 7.01
        EventFinish = 0x030D, // updated 7.01
        DesynthResult = 0x039A, // updated 7.01
        FreeCompanyInfo = 0x0143, // updated 7.01
        FreeCompanyDialog = 0x02BD, // updated 7.01
        MarketBoardSearchResult = 0x02B1, // updated 7.01
        MarketBoardItemListingCount = 0x03B5, // updated 7.01
        MarketBoardItemListingHistory = 0x01AB, // updated 7.01
        MarketBoardItemListing = 0x03B2, // updated 7.01
        MarketBoardPurchase = 0x031E, // updated 7.01
        UpdateInventorySlot = 0x035B, // updated 7.01
        InventoryActionAck = 0x0141, // updated 7.01
        InventoryTransaction = 0x01DC, // updated 7.01
        InventoryTransactionFinish = 0x0345, // updated 7.01
        ResultDialog = 0x010C, // updated 7.01
        RetainerInformation = 0x0271, // updated 7.01
        NpcSpawn = 0x01C4, // updated 7.01
        ItemMarketBoardInfo = 0x0121, // updated 7.01
        ObjectSpawn = 0x0099, // updated 7.01
        EffectResultBasic = 0x0230, // updated 7.01
        Effect = 0x0173, // updated 7.01
        StatusEffectList = 0x01C5, // updated 7.01
        StatusEffectList2 = 0x010F, // updated 7.01
        StatusEffectList3 = 0x02F8, // updated 7.01
        ActorGauge = 0x017B, // updated 7.01
        CFNotify = 0x01AE, // updated 7.01
        SystemLogMessage = 0x012A, // updated 7.01
        AirshipTimers = 0x00DD, // updated 7.01
        SubmarineTimers = 0x0078, // updated 7.01
        AirshipStatusList = 0x022A, // updated 7.01
        AirshipStatus = 0x017E, // updated 7.01
        AirshipExplorationResult = 0x0322, // updated 7.01
        SubmarineProgressionStatus = 0x014C, // updated 7.01
        SubmarineStatusList = 0x012C, // updated 7.01
        SubmarineExplorationResult = 0x0392, // updated 7.01

        CraftingLog = 0x02DA, // updated 7.01
        GatheringLog = 0x0232, // updated 7.01

        ActorMove = 0x03B7, // updated 7.01

        EventPlay = 0x02EB, // updated 7.01
        EventPlay4 = 0x00F0, // updated 7.01
        EventPlay8 = 0x01B4, // updated 7.01
        EventPlay16 = 0x03E2, // updated 7.01
        EventPlay32 = 0x02A7, // updated 7.01
        EventPlay64 = 0x0306, // updated 7.01
        EventPlay128 = 0x0235, // updated 7.01
        EventPlay255 = 0x00C0, // updated 7.01

        EnvironmentControl = 0x01A3, // updated 7.01
        IslandWorkshopSupplyDemand = 0x0372, // updated 7.01
        Logout = 0x01FA, // updated 7.01
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0144, // updated 7.01
        ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x02DD, // updated 7.01
        MarketBoardPurchaseHandler = 0x02A1, // updated 7.01
        InventoryModifyHandler = 0x029C, // updated 7.01
        UpdatePositionInstance = 0x03CE, // updated 7.0h
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