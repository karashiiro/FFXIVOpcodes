namespace FFXIVOpcodes.KR
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
        ActorCast = 0x0374, // 6.2
        ActorControl = 0x0259, // 6.2
        ActorControlSelf = 0x00E5, // 6.2
        ActorControlTarget = 0x0233, // 6.2
        ActorGauge = 0x02D3, // 6.2
        ActorMove = 0x01E9, // 6.2
        ActorSetPos = 0x0330, // 6.2
        AirshipExplorationResult = 0x00E4, // 6.2
        AirshipStatus = 0x0204, // 6.2
        AirshipStatusList = 0x00AC, // 6.2
        AirshipTimers = 0x0175, // 6.2
        AoeEffect16 = 0x006A, // 6.2
        AoeEffect24 = 0x0095, // 6.2
        AoeEffect32 = 0x023C, // 6.2
        AoeEffect8 = 0x00D8, // 6.2
        CEDirector = 0x03B5, // 6.2
        CFNotify = 0x01B5, // 6.2
        CFPreferredRole = 0x00D7, // 6.2
        ContainerInfo = 0x033E, // 6.2
        CurrencyCrystalInfo = 0x0211, // 6.2
        DesynthResult = 0x02AA, // 6.2
        Effect = 0x034A, // 6.2
        EffectResult = 0x0195, // 6.2
        EffectResultBasic = 0x013D, // 6.2
        EventFinish = 0x0258, // 6.2
        EventPlay = 0x0264, // 6.2
        EventPlay32 = 0x01D3, // 6.2
        EventPlay4 = 0x03D8, // 6.2
        EventStart = 0x0344, // 6.2
        Examine = 0x0234, // 6.2
        ExamineFreeCompanyInfo = 0x0209, // 6.2
        ExamineSearchInfo = 0x0250, // 6.2
        FreeCompanyDialog = 0x0168, // 6.2
        FreeCompanyInfo = 0x0086, // 6.2
        HousingWardInfo = 0x009B, // 6.2
        InitZone = 0x00F5, // 6.2
        InventoryActionAck = 0x02A5, // 6.2
        InventoryTransaction = 0x0183, // 6.2
        InventoryTransactionFinish = 0x021D, // 6.2
        IslandWorkshopSupplyDemand = 0x0076, // 6.2
        ItemInfo = 0x03E2, // 6.2
        ItemMarketBoardInfo = 0x0260, // 6.2
        Logout = 0x0265, // 6.2
        MapEffect = 0x02FA, // 6.2
        MarketBoardItemListing = 0x0282, // 6.2
        MarketBoardItemListingCount = 0x022A, // 6.2
        MarketBoardItemListingHistory = 0x0332, // 6.2
        MarketBoardPurchase = 0x01DC, // 6.2
        MarketBoardSearchResult = 0x025B, // 6.2
        MiniCactpotInit = 0x00E7, // 6.2
        NpcSpawn = 0x008E, // 6.2
        ObjectSpawn = 0x009E, // 6.2
        PlaceFieldMarker = 0x02AB, // 6.2
        PlaceFieldMarkerPreset = 0x026D, // 6.2
        PlayerSetup = 0x0358, // 6.2
        PlayerSpawn = 0x0317, // 6.2
        PlayerStats = 0x03E3, // 6.2
        Playtime = 0x030A, // 6.2
        PrepareZoning = 0x03AD, // 6.2
        ResultDialog = 0x0291, // 6.2
        RetainerInformation = 0x0140, // 6.2
        SocialList = 0x0100, // 6.2
        StatusEffectList = 0x01CF, // 6.2
        StatusEffectList2 = 0x01D7, // 6.2
        StatusEffectList3 = 0x01A2, // 6.2
        SubmarineExplorationResult = 0x00E0, // 6.2
        SubmarineProgressionStatus = 0x017C, // 6.2
        SubmarineStatusList = 0x00AD, // 6.2
        SubmarineTimers = 0x030C, // 6.2
        SystemLogMessage = 0x016C, // 6.2
        UpdateClassInfo = 0x00FC, // 6.2
        UpdateHpMpTp = 0x03C3, // 6.2
        UpdateInventorySlot = 0x010B, // 6.2
        UpdateSearchInfo = 0x034E, // 6.2
        WeatherChange = 0x016A, // 6.2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x01DF, // 6.2
        ClientTrigger = 0x00DF, // 6.2
        InventoryModifyHandler = 0x017A, // 6.2 (Base offset: 0x0181)
        LogoutHandler = 0x01D5, // 6.2
        MarketBoardPurchaseHandler = 0x0398, // 6.2
        SetSearchInfoHandler = 0x00BD, // 6.2
        UpdatePositionHandler = 0x0186, // 6.2
        UpdatePositionInstance = 0x0161, // 6.2
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {

    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {

    };
}
