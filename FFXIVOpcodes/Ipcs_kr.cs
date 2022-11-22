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
        ActorCast = 0x038C, // 6.15
        ActorControl = 0x0168, // 6.15
        ActorControlSelf = 0x02C5, // 6.15
        ActorControlTarget = 0x020D, // 6.15
        ActorGauge = 0x00E3, // 6.15
        ActorMove = 0x0231, // 6.15
        ActorSetPos = 0x03E5, // 6.15
        AirshipExplorationResult = 0x035C, // 6.15
        AirshipStatus = 0x0186, // 6.15
        AirshipStatusList = 0x036B, // 6.15
        AirshipTimers = 0x02AF, // 6.15
        AoeEffect16 = 0x006C, // 6.15
        AoeEffect24 = 0x010D, // 6.15
        AoeEffect32 = 0x00FA, // 6.15
        AoeEffect8 = 0x0175, // 6.15
        BossStatusEffectList = 0x03B8, // 6.15
        CEDirector = 0x031F, // 6.15
        CFNotify = 0x01C6, // 6.15
        CFPreferredRole = 0x0260, // 6.15
        ContainerInfo = 0x03E4, // 6.15
        CurrencyCrystalInfo = 0x0365, // 6.15
        DesynthResult = 0x01DD, // 6.15
        Effect = 0x02FD, // 6.15
        EffectResult = 0x0347, // 6.15
        EffectResultBasic = 0x02C6, // 6.15
        EventFinish = 0x0351, // 6.15
        EventPlay = 0x032F, // 6.15
        EventPlay32 = 0x0089, // 6.15
        EventPlay4 = 0x038E, // 6.15
        EventStart = 0x0177, // 6.15
        Examine = 0x00CA, // 6.15
        ExamineFreeCompanyInfo = 0x0255, // 6.15
        ExamineSearchInfo = 0x036E, // 6.15
        FreeCompanyDialog = 0x02E4, // 6.15
        FreeCompanyInfo = 0x00EA, // 6.15
        HousingWardInfo = 0x0267, // 6.15
        InitZone = 0x00BB, // 6.15
        InventoryActionAck = 0x021C, // 6.15
        InventoryTransaction = 0x028C, // 6.15
        InventoryTransactionFinish = 0x00C2, // 6.15
        ItemInfo = 0x0306, // 6.15
        ItemMarketBoardInfo = 0x00DF, // 6.15
        Logout = 0x02CD, // 6.15
        MapEffect = 0x012C, // 6.15
        MarketBoardItemListing = 0x0106, // 6.15
        MarketBoardItemListingCount = 0x0174, // 6.15
        MarketBoardItemListingHistory = 0x019D, // 6.15
        MarketBoardPurchase = 0x0169, // 6.15
        MarketBoardSearchResult = 0x01F6, // 6.15
        MiniCactpotInit = 0x0100, // 6.15
        NpcSpawn = 0x030F, // 6.15
        NpcSpawn2 = 0x0324, // 6.15
        ObjectSpawn = 0x015B, // 6.15
        PlaceFieldMarker = 0x0335, // 6.15
        PlaceFieldMarkerPreset = 0x02A4, // 6.15
        PlayerSetup = 0x0381, // 6.15
        PlayerSpawn = 0x0209, // 6.15
        PlayerStats = 0x02BB, // 6.15
        Playtime = 0x0383, // 6.15
        PrepareZoning = 0x03E2, // 6.15
        ResultDialog = 0x00D5, // 6.15
        RetainerInformation = 0x03A6, // 6.15
        SocialList = 0x01EA, // 6.15
        StatusEffectList = 0x0375, // 6.15
        StatusEffectList2 = 0x0387, // 6.15
        StatusEffectList3 = 0x0382, // 6.15
        SubmarineExplorationResult = 0x00FD, // 6.15
        SubmarineProgressionStatus = 0x021A, // 6.15
        SubmarineStatusList = 0x00F9, // 6.15
        SubmarineTimers = 0x0268, // 6.15
        SystemLogMessage = 0x00BD, // 6.15
        UpdateClassInfo = 0x01BD, // 6.15
        UpdateHpMpTp = 0x022E, // 6.15
        UpdateInventorySlot = 0x01F7, // 6.15
        UpdateSearchInfo = 0x030D, // 6.15
        WeatherChange = 0x037B, // 6.15
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00BC, // 6.15
        ClientTrigger = 0x0203, // 6.15
        InventoryModifyHandler = 0x03B0, // 6.15 (Base offset: 0x03B7)
        LogoutHandler = 0x014B, // 6.15
        MarketBoardPurchaseHandler = 0x0069, // 6.15
        SetSearchInfoHandler = 0x0189, // 6.15
        UpdatePositionHandler = 0x010E, // 6.15
        UpdatePositionInstance = 0x00E6, // 6.15
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
