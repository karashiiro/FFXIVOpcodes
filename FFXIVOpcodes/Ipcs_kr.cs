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
        ActorCast = 0x01C9, // 6.051
        ActorControl = 0x02D7, // 6.051
        ActorControlSelf = 0x0135, // 6.051
        ActorControlTarget = 0x039D, // 6.051
        ActorGauge = 0x02B4, // 6.051
        ActorMove = 0x01B8, // 6.051
        ActorSetPos = 0x0352, // 6.051
        AirshipExplorationResult = 0x03AA, // 6.051
        AirshipStatus = 0x0253, // 6.051
        AirshipStatusList = 0x03DC, // 6.051
        AirshipTimers = 0x0140, // 6.051
        AoeEffect16 = 0x02B2, // 6.051
        AoeEffect24 = 0x03DB, // 6.051
        AoeEffect32 = 0x02EA, // 6.051
        AoeEffect8 = 0x00C7, // 6.051
        CEDirector = 0x01A7, // 6.051
        CFNotify = 0x015A, // 6.051
        CFPreferredRole = 0x00D8, // 6.051
        ContainerInfo = 0x0251, // 6.051
        CurrencyCrystalInfo = 0x01B1, // 6.051
        DesynthResult = 0x031B, // 6.051
        Effect = 0x022D, // 6.051
        EffectResult = 0x0331, // 6.051
        EffectResultBasic = 0x02B7, // 6.051
        EventFinish = 0x0086, // 6.051
        EventPlay = 0x0339, // 6.051
        EventPlay32 = 0x01BF, // 6.051
        EventPlay4 = 0x0383, // 6.051
        EventStart = 0x019E, // 6.051
        Examine = 0x0279, // 6.051
        ExamineFreeCompanyInfo = 0x0177, // 6.051
        ExamineSearchInfo = 0x03CC, // 6.051
        FreeCompanyDialog = 0x00D7, // 6.051
        FreeCompanyInfo = 0x02DE, // 6.051
        HousingWardInfo = 0x01D1, // 6.051
        InitZone = 0x021D, // 6.051
        InventoryActionAck = 0x0227, // 6.051
        InventoryTransaction = 0x0295, // 6.051
        InventoryTransactionFinish = 0x00AE, // 6.051
        ItemInfo = 0x0108, // 6.051
        ItemMarketBoardInfo = 0x024D, // 6.051
        Logout = 0x035D, // 6.051
        MapEffect = 0x0194, // 6.051
        MarketBoardItemListing = 0x01FC, // 6.051
        MarketBoardItemListingCount = 0x027D, // 6.051
        MarketBoardItemListingHistory = 0x0233, // 6.051
        MarketBoardPurchase = 0x0195, // 6.051
        MarketBoardSearchResult = 0x0172, // 6.051
        MiniCactpotInit = 0x009D, // 6.051
        NpcSpawn = 0x0175, // 6.051
        ObjectSpawn = 0x0192, // 6.051
        PlaceFieldMarker = 0x0395, // 6.051
        PlaceFieldMarkerPreset = 0x0370, // 6.051
        PlayerSetup = 0x00F7, // 6.051
        PlayerSpawn = 0x02ED, // 6.051
        PlayerStats = 0x0399, // 6.051
        Playtime = 0x0393, // 6.051
        PrepareZoning = 0x01D6, // 6.051
        ResultDialog = 0x035A, // 6.051
        RetainerInformation = 0x0113, // 6.051
        StatusEffectList = 0x0131, // 6.051
        StatusEffectList2 = 0x008F, // 6.051
        StatusEffectList3 = 0x0160, // 6.051
        SubmarineExplorationResult = 0x0129, // 6.051
        SubmarineProgressionStatus = 0x00B9, // 6.051
        SubmarineStatusList = 0x00B7, // 6.051
        SubmarineTimers = 0x00DB, // 6.051
        SystemLogMessage = 0x0105, // 6.051
        UpdateClassInfo = 0x00E5, // 6.051
        UpdateHpMpTp = 0x037D, // 6.051
        UpdateInventorySlot = 0x0348, // 6.051
        UpdateSearchInfo = 0x02C3, // 6.051
        WeatherChange = 0x0322, // 6.051
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x02BB, // 6.051
        ClientTrigger = 0x0297, // 6.051
        InventoryModifyHandler = 0x0381, // 6.051 (Base offset: 0x0388)
        LogoutHandler = 0x0152, // 6.051
        MarketBoardPurchaseHandler = 0x03C9, // 6.051
        SetSearchInfoHandler = 0x0292, // 6.051
        UpdatePositionHandler = 0x035B, // 6.051
        UpdatePositionInstance = 0x0229, // 6.051
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
