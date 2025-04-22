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
        PlayerSetup = 0x0137, // updated 7.21
        UpdateHpMpTp = 0x021C, // updated 7.21
        UpdateClassInfo = 0x0399, // updated 7.21
        PlayerStats = 0x00B0, // updated 7.21
        ActorControl = 0x009C, // updated 7.21
        ActorControlSelf = 0x02E2, // updated 7.21
        ActorControlTarget = 0x0115, // updated 7.21
        Playtime = 0x02AD, // updated 7.21
        UpdateSearchInfo = 0x03B9, // updated 7.21
        ExamineSearchInfo = 0x0226, // updated 7.21
        Examine = 0x01F4, // updated 7.21
        ActorCast = 0x01D4, // updated 7.21
        CurrencyCrystalInfo = 0x02B1, // updated 7.21
        InitZone = 0x0316, // updated 7.21
        WeatherChange = 0x0244, // updated 7.21
        PlayerSpawn = 0x0374, // updated 7.21
        ActorSetPos = 0x0079, // updated 7.21
        PrepareZoning = 0x00C4, // updated 7.21
        ContainerInfo = 0x02AF, // updated 7.21
        ItemInfo = 0x0194, // updated 7.21
        PlaceFieldMarker = 0x02A1, // updated 7.21
        PlaceFieldMarkerPreset = 0x00FC, // updated 7.21
        EffectResult = 0x008D, // updated 7.21
        EventStart = 0x0127, // updated 7.21
        EventFinish = 0x0177, // updated 7.21
        DesynthResult = 0x00DA, // updated 7.21
        FreeCompanyInfo = 0x0261, // updated 7.21
        FreeCompanyDialog = 0x0230, // updated 7.21
        MarketBoardSearchResult = 0x018E, // updated 7.21
        MarketBoardItemListingCount = 0x0136, // updated 7.21
        MarketBoardItemListingHistory = 0x01E2, // updated 7.21
        MarketBoardItemListing = 0x018F, // updated 7.21
        MarketBoardPurchase = 0x00B7, // updated 7.21
        UpdateInventorySlot = 0x0398, // updated 7.21
        InventoryActionAck = 0x01BE, // updated 7.21
        InventoryTransaction = 0x0104, // updated 7.21
        InventoryTransactionFinish = 0x0107, // updated 7.21
        ResultDialog = 0x0271, // updated 7.21
        RetainerInformation = 0x00D6, // updated 7.21
        NpcSpawn = 0x025E, // updated 7.21
        ItemMarketBoardInfo = 0x03D0, // updated 7.21
        ObjectSpawn = 0x00AB, // updated 7.21
        EffectResultBasic = 0x02F2, // updated 7.21
        Effect = 0x00F5, // updated 7.21
        StatusEffectList = 0x027B, // updated 7.21
        StatusEffectList2 = 0x014F, // updated 7.21
        StatusEffectList3 = 0x01A6, // updated 7.21
        ActorGauge = 0x0151, // updated 7.21
        CFNotify = 0x0159, // updated 7.21
        SystemLogMessage = 0x0227, // updated 7.21
        AirshipTimers = 0x0353, // updated 7.21
        SubmarineTimers = 0x02EA, // updated 7.21
        AirshipStatusList = 0x00B6, // updated 7.21
        AirshipStatus = 0x0145, // updated 7.21
        AirshipExplorationResult = 0x0355, // updated 7.21
        SubmarineProgressionStatus = 0x0105, // updated 7.21
        SubmarineStatusList = 0x017A, // updated 7.21
        SubmarineExplorationResult = 0x0218, // updated 7.21

        CraftingLog = 0x0214, // updated 7.21
        GatheringLog = 0x0189, // updated 7.21

        ActorMove = 0x01E7, // updated 7.21

        EventPlay = 0x010D, // updated 7.21
        EventPlay4 = 0x03CD, // updated 7.21
        EventPlay8 = 0x020E, // updated 7.21
        EventPlay16 = 0x03E6, // updated 7.21
        EventPlay32 = 0x02A7, // updated 7.21
        EventPlay64 = 0x0068, // updated 7.21
        EventPlay128 = 0x0114, // updated 7.21
        EventPlay255 = 0x0190, // updated 7.21

        EnvironmentControl = 0x0221, // updated 7.21
        IslandWorkshopSupplyDemand = 0x0382, // updated 7.21
        Logout = 0x027D, // updated 7.21
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0284, // updated 7.21
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x029D, // updated 7.21
        MarketBoardPurchaseHandler = 0x013B, // updated 7.21
        InventoryModifyHandler = 0x0247, // updated 7.21
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