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
        PlayerSetup = 0x0244, // updated 7.25
        UpdateHpMpTp = 0x018B, // updated 7.25
        UpdateClassInfo = 0x01B8, // updated 7.25
        PlayerStats = 0x02B2, // updated 7.25
        ActorControl = 0x0110, // updated 7.25
        ActorControlSelf = 0x00E8, // updated 7.25
        ActorControlTarget = 0x0169, // updated 7.25
        Playtime = 0x03D3, // updated 7.25
        UpdateSearchInfo = 0x00BD, // updated 7.25
        ExamineSearchInfo = 0x0150, // updated 7.25
        Examine = 0x03A1, // updated 7.25
        ActorCast = 0x0383, // updated 7.25
        CurrencyCrystalInfo = 0x01B0, // updated 7.25
        InitZone = 0x0161, // updated 7.25
        WeatherChange = 0x02B1, // updated 7.25
        PlayerSpawn = 0x00A9, // updated 7.25
        ActorSetPos = 0x021D, // updated 7.25
        PrepareZoning = 0x0096, // updated 7.25
        ContainerInfo = 0x02C4, // updated 7.25
        ItemInfo = 0x01C5, // updated 7.25
        PlaceFieldMarker = 0x024E, // updated 7.25
        PlaceFieldMarkerPreset = 0x0265, // updated 7.25
        EffectResult = 0x02AC, // updated 7.25
        EventStart = 0x02C3, // updated 7.25
        EventFinish = 0x00F3, // updated 7.25
        DesynthResult = 0x01F8, // updated 7.25
        FreeCompanyInfo = 0x01A9, // updated 7.25
        FreeCompanyDialog = 0x03D5, // updated 7.25
        MarketBoardSearchResult = 0x02CD, // updated 7.25
        MarketBoardItemListingCount = 0x00D1, // updated 7.25
        MarketBoardItemListingHistory = 0x02AA, // updated 7.25
        MarketBoardItemListing = 0x0341, // updated 7.25
        MarketBoardPurchase = 0x0196, // updated 7.25
        UpdateInventorySlot = 0x02F2, // updated 7.25
        InventoryActionAck = 0x0075, // updated 7.25
        InventoryTransaction = 0x0117, // updated 7.25
        InventoryTransactionFinish = 0x01A3, // updated 7.25
        ResultDialog = 0x015C, // updated 7.25
        RetainerInformation = 0x0177, // updated 7.25
        NpcSpawn = 0x02E4, // updated 7.25
        ItemMarketBoardInfo = 0x03DF, // updated 7.25
        ObjectSpawn = 0x00D4, // updated 7.25
        EffectResultBasic = 0x02BA, // updated 7.25
        Effect = 0x016C, // updated 7.25
        StatusEffectList = 0x02CC, // updated 7.25
        StatusEffectList2 = 0x00EF, // updated 7.25
        StatusEffectList3 = 0x0212, // updated 7.25
        ActorGauge = 0x0087, // updated 7.25
        CFNotify = 0x03C8, // updated 7.25
        SystemLogMessage = 0x021F, // updated 7.25
        AirshipTimers = 0x007E, // updated 7.25
        SubmarineTimers = 0x0362, // updated 7.25
        AirshipStatusList = 0x0118, // updated 7.25
        AirshipStatus = 0x0139, // updated 7.25
        AirshipExplorationResult = 0x0263, // updated 7.25
        SubmarineProgressionStatus = 0x035A, // updated 7.25
        SubmarineStatusList = 0x0109, // updated 7.25
        SubmarineExplorationResult = 0x00A8, // updated 7.25

        CraftingLog = 0x00C0, // updated 7.25
        GatheringLog = 0x0374, // updated 7.25

        ActorMove = 0x0093, // updated 7.25

        EventPlay = 0x011A, // updated 7.25
        EventPlay4 = 0x0211, // updated 7.25
        EventPlay8 = 0x03D8, // updated 7.25
        EventPlay16 = 0x0287, // updated 7.25
        EventPlay32 = 0x0228, // updated 7.25
        EventPlay64 = 0x0264, // updated 7.25
        EventPlay128 = 0x02EA, // updated 7.25
        EventPlay255 = 0x02A4, // updated 7.25

        EnvironmentControl = 0x0099, // updated 7.25
        IslandWorkshopSupplyDemand = 0x038F, // updated 7.25
        Logout = 0x009F, // updated 7.25
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0073, // updated 7.25
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0388, // updated 7.25
        MarketBoardPurchaseHandler = 0x02FC, // updated 7.25
        InventoryModifyHandler = 0x031F, // updated 7.25
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