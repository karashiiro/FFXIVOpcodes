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
        PlayerSetup = 0x0309, // updated 7.25h2
        UpdateHpMpTp = 0x00FC, // updated 7.25h2
        UpdateClassInfo = 0x0162, // updated 7.25h2
        PlayerStats = 0x0349, // updated 7.25h2
        ActorControl = 0x03E7, // updated 7.25h2
        ActorControlSelf = 0x0117, // updated 7.25h2
        ActorControlTarget = 0x0251, // updated 7.25h2
        Playtime = 0x0196, // updated 7.25h2
        UpdateSearchInfo = 0x022D, // updated 7.25h2
        ExamineSearchInfo = 0x0096, // updated 7.25h2
        Examine = 0x03AB, // updated 7.25h2
        ActorCast = 0x0087, // updated 7.25h2
        CurrencyCrystalInfo = 0x0224, // updated 7.25h2
        InitZone = 0x037E, // updated 7.25h2
        WeatherChange = 0x01D7, // updated 7.25h2
        PlayerSpawn = 0x032A, // updated 7.25h2
        ActorSetPos = 0x033D, // updated 7.25h2
        PrepareZoning = 0x033A, // updated 7.25h2
        ContainerInfo = 0x0122, // updated 7.25h2
        ItemInfo = 0x038E, // updated 7.25h2
        PlaceFieldMarker = 0x021A, // updated 7.25h2
        PlaceFieldMarkerPreset = 0x03CC, // updated 7.25h2
        EffectResult = 0x03E5, // updated 7.25h2
        EventStart = 0x0290, // updated 7.25h2
        EventFinish = 0x0086, // updated 7.25h2
        DesynthResult = 0x0255, // updated 7.25h2
        FreeCompanyInfo = 0x03C2, // updated 7.25h2
        FreeCompanyDialog = 0x0217, // updated 7.25h2
        MarketBoardSearchResult = 0x02A8, // updated 7.25h2
        MarketBoardItemListingCount = 0x0223, // updated 7.25h2
        MarketBoardItemListingHistory = 0x00A3, // updated 7.25h2
        MarketBoardItemListing = 0x0167, // updated 7.25h2
        MarketBoardPurchase = 0x02B0, // updated 7.25h2
        UpdateInventorySlot = 0x0320, // updated 7.25h2
        InventoryActionAck = 0x01E3, // updated 7.25h2
        InventoryTransaction = 0x0115, // updated 7.25h2
        InventoryTransactionFinish = 0x032C, // updated 7.25h2
        ResultDialog = 0x009D, // updated 7.25h2
        RetainerInformation = 0x00BF, // updated 7.25h2
        NpcSpawn = 0x038C, // updated 7.25h2
        ItemMarketBoardInfo = 0x03B3, // updated 7.25h2
        ObjectSpawn = 0x00D8, // updated 7.25h2
        EffectResultBasic = 0x00C1, // updated 7.25h2
        Effect = 0x00BC, // updated 7.25h2
        StatusEffectList = 0x02EC, // updated 7.25h2
        StatusEffectList2 = 0x020A, // updated 7.25h2
        StatusEffectList3 = 0x03B6, // updated 7.25h2
        ActorGauge = 0x02DD, // updated 7.25h2
        CFNotify = 0x00A5, // updated 7.25h2
        SystemLogMessage = 0x03CB, // updated 7.25h2
        AirshipTimers = 0x00C7, // updated 7.25h2
        SubmarineTimers = 0x02F9, // updated 7.25h2
        AirshipStatusList = 0x025D, // updated 7.25h2
        AirshipStatus = 0x01D1, // updated 7.25h2
        AirshipExplorationResult = 0x03CD, // updated 7.25h2
        SubmarineProgressionStatus = 0x025A, // updated 7.25h2
        SubmarineStatusList = 0x0259, // updated 7.25h2
        SubmarineExplorationResult = 0x0363, // updated 7.25h2

        CraftingLog = 0x02D3, // updated 7.25h2
        GatheringLog = 0x007D, // updated 7.25h2

        ActorMove = 0x02CD, // updated 7.25h2

        EventPlay = 0x01E0, // updated 7.25h2
        EventPlay4 = 0x03C4, // updated 7.25h2
        EventPlay8 = 0x0313, // updated 7.25h2
        EventPlay16 = 0x00BA, // updated 7.25h2
        EventPlay32 = 0x0119, // updated 7.25h2
        EventPlay64 = 0x03DC, // updated 7.25h2
        EventPlay128 = 0x0370, // updated 7.25h2
        EventPlay255 = 0x00F3, // updated 7.25h2

        EnvironmentControl = 0x02EB, // updated 7.25h2
        IslandWorkshopSupplyDemand = 0x01EE, // updated 7.25h2
        Logout = 0x03C5, // updated 7.25h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0150, // updated 7.25h2
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0103, // updated 7.25h2
        MarketBoardPurchaseHandler = 0x0246, // updated 7.25h2
        InventoryModifyHandler = 0x01BD, // updated 7.25h2
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