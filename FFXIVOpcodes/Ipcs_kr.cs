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
        ActorCast = 0x0135, // 6.1
        ActorControl = 0x01E1, // 6.1
        ActorControlSelf = 0x0289, // 6.1
        ActorControlTarget = 0x028C, // 6.1
        ActorGauge = 0x0361, // 6.1
        ActorMove = 0x0266, // 6.1
        ActorSetPos = 0x0070, // 6.1
        AirshipExplorationResult = 0x02D6, // 6.1
        AirshipStatus = 0x02AA, // 6.1
        AirshipStatusList = 0x0089, // 6.1
        AirshipTimers = 0x02E1, // 6.1
        AoeEffect16 = 0x0128, // 6.1
        AoeEffect24 = 0x0378, // 6.1
        AoeEffect32 = 0x0312, // 6.1
        AoeEffect8 = 0x0145, // 6.1
        CEDirector = 0x0237, // 6.1
        CFNotify = 0x0120, // 6.1
        CFPreferredRole = 0x0088, // 6.1
        ContainerInfo = 0x03A5, // 6.1
        CurrencyCrystalInfo = 0x026F, // 6.1
        DesynthResult = 0x0181, // 6.1
        Effect = 0x0292, // 6.1
        EffectResult = 0x014E, // 6.1
        EffectResultBasic = 0x031E, // 6.1
        EventFinish = 0x0346, // 6.1
        EventPlay = 0x0189, // 6.1
        EventPlay32 = 0x0129, // 6.1
        EventPlay4 = 0x01FC, // 6.1
        EventStart = 0x0311, // 6.1
        Examine = 0x02F4, // 6.1
        ExamineFreeCompanyInfo = 0x01B5, // 6.1
        ExamineSearchInfo = 0x0121, // 6.1
        FreeCompanyDialog = 0x0372, // 6.1
        FreeCompanyInfo = 0x00CA, // 6.1
        HousingWardInfo = 0x03BD, // 6.1
        InitZone = 0x018C, // 6.1
        InventoryActionAck = 0x03DA, // 6.1
        InventoryTransaction = 0x023C, // 6.1
        InventoryTransactionFinish = 0x02CF, // 6.1
        ItemInfo = 0x03B1, // 6.1
        ItemMarketBoardInfo = 0x0105, // 6.1
        Logout = 0x018E, // 6.1
        MapEffect = 0x02EE, // 6.1
        MarketBoardItemListing = 0x028B, // 6.1
        MarketBoardItemListingCount = 0x013E, // 6.1
        MarketBoardItemListingHistory = 0x02CB, // 6.1
        MarketBoardPurchase = 0x01BC, // 6.1
        MarketBoardSearchResult = 0x00CF, // 6.1
        MiniCactpotInit = 0x0186, // 6.1
        NpcSpawn = 0x030F, // 6.1
        ObjectSpawn = 0x029B, // 6.1
        PlaceFieldMarker = 0x024C, // 6.1
        PlaceFieldMarkerPreset = 0x0261, // 6.1
        PlayerSetup = 0x01DD, // 6.1
        PlayerSpawn = 0x0178, // 6.1
        PlayerStats = 0x039F, // 6.1
        Playtime = 0x03C7, // 6.1
        PrepareZoning = 0x01CC, // 6.1
        ResultDialog = 0x0290, // 6.1
        RetainerInformation = 0x03AC, // 6.1
        SocialList = 0x039A, // 6.1
        StatusEffectList = 0x0229, // 6.1
        StatusEffectList2 = 0x00C0, // 6.1
        StatusEffectList3 = 0x013D, // 6.1
        SubmarineExplorationResult = 0x00B3, // 6.1
        SubmarineProgressionStatus = 0x0195, // 6.1
        SubmarineStatusList = 0x00DB, // 6.1
        SubmarineTimers = 0x008F, // 6.1
        SystemLogMessage = 0x0331, // 6.1
        UpdateClassInfo = 0x0275, // 6.1
        UpdateHpMpTp = 0x0243, // 6.1
        UpdateInventorySlot = 0x03C0, // 6.1
        UpdateSearchInfo = 0x0367, // 6.1
        WeatherChange = 0x02C2, // 6.1
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0294, // 6.1
        ClientTrigger = 0x02A0, // 6.1
        InventoryModifyHandler = 0x010D, // 6.1 (Base offset: 0x0114)
        LogoutHandler = 0x0370, // 6.1
        MarketBoardPurchaseHandler = 0x0147, // 6.1
        SetSearchInfoHandler = 0x014D, // 6.1
        UpdatePositionHandler = 0x0332, // 6.1
        UpdatePositionInstance = 0x03E3, // 6.1
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
