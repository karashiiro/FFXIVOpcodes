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
        PlayerSetup = 0x03E6, // updated 6.41
        UpdateHpMpTp = 0x0316, // updated 6.41
        UpdateClassInfo = 0x00A0, // updated 6.41
        PlayerStats = 0x0343, // updated 6.41
        ActorControl = 0x019D, // updated 6.41
        ActorControlSelf = 0x00A6, // updated 6.41
        ActorControlTarget = 0x02FE, // updated 6.41
        Playtime = 0x03A3, // updated 6.41
        UpdateSearchInfo = 0x0092, // updated 6.41
        ExamineSearchInfo = 0x03DA, // updated 6.41
        Examine = 0x0228, // updated 6.41
        ActorCast = 0x01C0, // updated 6.41
        CurrencyCrystalInfo = 0x01A4, // updated 6.41
        InitZone = 0x01D5, // updated 6.41
        WeatherChange = 0x02D9, // updated 6.41
        PlayerSpawn = 0x01A7, // updated 6.41
        ActorSetPos = 0x015F, // updated 6.41
        PrepareZoning = 0x039C, // updated 6.41
        ContainerInfo = 0x021F, // updated 6.41
        ItemInfo = 0x0388, // updated 6.41
        PlaceFieldMarker = 0x0139, // updated 6.41
        PlaceFieldMarkerPreset = 0x00CC, // updated 6.41
        EffectResult = 0x010C, // updated 6.41
        EventStart = 0x03A6, // updated 6.41
        EventFinish = 0x02FA, // updated 6.41
        DesynthResult = 0x0325, // updated 6.41
        FreeCompanyInfo = 0x00CE, // updated 6.41
        FreeCompanyDialog = 0x033E, // updated 6.41
        MarketBoardSearchResult = 0x019F, // updated 6.41
        MarketBoardItemListingCount = 0x0067, // updated 6.41
        MarketBoardItemListingHistory = 0x0069, // updated 6.41
        MarketBoardItemListing = 0x0221, // updated 6.41
        MarketBoardPurchase = 0x01B6, // updated 6.41
        UpdateInventorySlot = 0x0079, // updated 6.41
        InventoryActionAck = 0x034C, // updated 6.41
        InventoryTransaction = 0x0252, // updated 6.41
        InventoryTransactionFinish = 0x01D1, // updated 6.41
        ResultDialog = 0x007D, // updated 6.41
        RetainerInformation = 0x0229, // updated 6.41
        NpcSpawn = 0x00AC, // updated 6.41
        ItemMarketBoardInfo = 0x00FE, // updated 6.41
        ObjectSpawn = 0x0295, // updated 6.41
        EffectResultBasic = 0x039F, // updated 6.41
        Effect = 0x01BB, // updated 6.41
        StatusEffectList = 0x0171, // updated 6.41
        StatusEffectList2 = 0x032F, // updated 6.41
        StatusEffectList3 = 0x009E, // updated 6.41
        ActorGauge = 0x026D, // updated 6.41
        CFNotify = 0x021A, // updated 6.41
        SystemLogMessage = 0x039D, // updated 6.41
        AirshipTimers = 0x03C5, // updated 6.41
        SubmarineTimers = 0x0372, // updated 6.41
        AirshipStatusList = 0x0265, // updated 6.41
        AirshipStatus = 0x0172, // updated 6.41
        AirshipExplorationResult = 0x021E, // updated 6.41
        SubmarineProgressionStatus = 0x01EA, // updated 6.41
        SubmarineStatusList = 0x0383, // updated 6.41
        SubmarineExplorationResult = 0x01D3, // updated 6.41

        ActorMove = 0x02C4, // updated 6.41

        EventPlay = 0x036F, // updated 6.41
        EventPlay4 = 0x0124, // updated 6.41
        EventPlay8 = 0x009A, // updated 6.41
        EventPlay16 = 0x02F2, // updated 6.41
        EventPlay32 = 0x00E3, // updated 6.41
        EventPlay64 = 0x038F, // updated 6.41
        EventPlay128 = 0x0197, // updated 6.41
        EventPlay255 = 0x0202, // updated 6.41

        EnvironmentControl = 0x02E0, // updated 6.41
        IslandWorkshopSupplyDemand = 0x027C, // updated 6.41
        Logout = 0x0363, // updated 6.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02DF, // updated 6.41
        ClientTrigger = 0x023F, // updated 6.41
        ChatHandler = 0x03C1, // updated 6.41
        SetSearchInfoHandler = 0x0084, // updated 6.41
        MarketBoardPurchaseHandler = 0x031E, // updated 6.41
        InventoryModifyHandler = 0x0322, // updated 6.41
        UpdatePositionInstance = 0x0212, // updated 6.41
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
