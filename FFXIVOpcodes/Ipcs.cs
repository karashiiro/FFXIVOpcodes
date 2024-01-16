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
        PlayerSetup = 0x0361, // updated 6.55
        UpdateHpMpTp = 0x039C, // updated 6.55
        UpdateClassInfo = 0x021F, // updated 6.55
        PlayerStats = 0x02CB, // updated 6.55
        ActorControl = 0x0333, // updated 6.55
        ActorControlSelf = 0x0294, // updated 6.55
        ActorControlTarget = 0x007E, // updated 6.55
        Playtime = 0x031C, // updated 6.55
        UpdateSearchInfo = 0x010E, // updated 6.55
        ExamineSearchInfo = 0x0145, // updated 6.55
        Examine = 0x0084, // updated 6.55
        ActorCast = 0x0164, // updated 6.55
        CurrencyCrystalInfo = 0x03C3, // updated 6.55
        InitZone = 0x0336, // updated 6.55
        WeatherChange = 0x0121, // updated 6.55
        PlayerSpawn = 0x0152, // updated 6.55
        ActorSetPos = 0x02EE, // updated 6.55
        PrepareZoning = 0x030D, // updated 6.55
        ContainerInfo = 0x027D, // updated 6.55
        ItemInfo = 0x0217, // updated 6.55
        PlaceFieldMarker = 0x0111, // updated 6.55
        PlaceFieldMarkerPreset = 0x0221, // updated 6.55
        EffectResult = 0x03DF, // updated 6.55
        EventStart = 0x00FC, // updated 6.55
        EventFinish = 0x0129, // updated 6.55
        DesynthResult = 0x025D, // updated 6.55
        FreeCompanyInfo = 0x0151, // updated 6.55
        FreeCompanyDialog = 0x038E, // updated 6.55
        MarketBoardSearchResult = 0x02A1, // updated 6.55
        MarketBoardItemListingCount = 0x0360, // updated 6.55
        MarketBoardItemListingHistory = 0x00B1, // updated 6.55
        MarketBoardItemListing = 0x03DE, // updated 6.55
        MarketBoardPurchase = 0x021E, // updated 6.55
        UpdateInventorySlot = 0x0066, // updated 6.55
        InventoryActionAck = 0x02C4, // updated 6.55
        InventoryTransaction = 0x0332, // updated 6.55
        InventoryTransactionFinish = 0x00E6, // updated 6.55
        ResultDialog = 0x01EF, // updated 6.55
        RetainerInformation = 0x0191, // updated 6.55
        NpcSpawn = 0x0117, // updated 6.55
        ItemMarketBoardInfo = 0x00A3, // updated 6.55
        ObjectSpawn = 0x0341, // updated 6.55
        EffectResultBasic = 0x0150, // updated 6.55
        Effect = 0x00F8, // updated 6.55
        StatusEffectList = 0x02CC, // updated 6.55
        StatusEffectList2 = 0x0297, // updated 6.55
        StatusEffectList3 = 0x03A9, // updated 6.55
        ActorGauge = 0x015C, // updated 6.55
        CFNotify = 0x02E8, // updated 6.55
        SystemLogMessage = 0x0340, // updated 6.55
        AirshipTimers = 0x00D0, // updated 6.55
        SubmarineTimers = 0x035D, // updated 6.55
        AirshipStatusList = 0x01CD, // updated 6.55
        AirshipStatus = 0x020C, // updated 6.55
        AirshipExplorationResult = 0x00E0, // updated 6.55
        SubmarineProgressionStatus = 0x032D, // updated 6.55
        SubmarineStatusList = 0x030B, // updated 6.55
        SubmarineExplorationResult = 0x01BB, // updated 6.55

        ActorMove = 0x019C, // updated 6.55

        EventPlay = 0x03D1, // updated 6.55
        EventPlay4 = 0x01E4, // updated 6.55
        EventPlay8 = 0x037D, // updated 6.55
        EventPlay16 = 0x00E9, // updated 6.55
        EventPlay32 = 0x02C8, // updated 6.55
        EventPlay64 = 0x011D, // updated 6.55
        EventPlay128 = 0x0189, // updated 6.55
        EventPlay255 = 0x01EE, // updated 6.55

        EnvironmentControl = 0x0220, // updated 6.55
        IslandWorkshopSupplyDemand = 0x01E9, // updated 6.55
        Logout = 0x0205, // updated 6.55
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0090, // updated 6.55
        ClientTrigger = 0x0254, // updated 6.55
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x0107, // updated 6.55
        MarketBoardPurchaseHandler = 0x0097, // updated 6.55
        InventoryModifyHandler = 0x0102, // updated 6.55
        UpdatePositionInstance = 0x03DB, // updated 6.55
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