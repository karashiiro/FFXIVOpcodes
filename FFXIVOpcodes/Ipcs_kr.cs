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
        ActorCast = 0x0112, // 6.18
        ActorControl = 0x010F, // 6.18
        ActorControlSelf = 0x01B8, // 6.18
        ActorControlTarget = 0x0089, // 6.18
        ActorGauge = 0x01FA, // 6.18
        ActorMove = 0x0259, // 6.18
        ActorSetPos = 0x014D, // 6.18
        AirshipExplorationResult = 0x01C2, // 6.18
        AirshipStatus = 0x033C, // 6.18
        AirshipStatusList = 0x028A, // 6.18
        AirshipTimers = 0x026E, // 6.18
        AoeEffect16 = 0x033E, // 6.18
        AoeEffect24 = 0x03A7, // 6.18
        AoeEffect32 = 0x0253, // 6.18
        AoeEffect8 = 0x0078, // 6.18
        BossStatusEffectList = 0x009B, // 6.18
        CEDirector = 0x0388, // 6.18
        CFNotify = 0x01A2, // 6.18
        CFPreferredRole = 0x037A, // 6.18
        ContainerInfo = 0x011C, // 6.18
        CurrencyCrystalInfo = 0x00D9, // 6.18
        DesynthResult = 0x03C3, // 6.18
        Effect = 0x00EC, // 6.18
        EffectResult = 0x00BE, // 6.18
        EffectResultBasic = 0x0198, // 6.18
        EventFinish = 0x0349, // 6.18
        EventPlay = 0x0341, // 6.18
        EventPlay32 = 0x01D4, // 6.18
        EventPlay4 = 0x00E0, // 6.18
        EventStart = 0x0326, // 6.18
        Examine = 0x245, // 6.18
        ExamineFreeCompanyInfo = 0x035F, // 6.18
        ExamineSearchInfo = 0x00C2, // 6.18
        FreeCompanyDialog = 0x0176, // 6.18
        FreeCompanyInfo = 0x0159, // 6.18
        HousingWardInfo = 0x02C4, // 6.18
        InitZone = 0x015F, // 6.18
        InventoryActionAck = 0x00A8, // 6.18
        InventoryTransaction = 0x00C1, // 6.18
        InventoryTransactionFinish = 0x017A, // 6.18
        ItemInfo = 0x0302, // 6.18
        ItemMarketBoardInfo = 0x0170, // 6.18
        Logout = 0x02F2, // 6.18
        MapEffect = 0x02BA, // 6.18
        MarketBoardItemListing = 0x0322, // 6.18
        MarketBoardItemListingCount = 0x0229, // 6.18
        MarketBoardItemListingHistory = 0x015C, // 6.18
        MarketBoardPurchase = 0x0289, // 6.18
        MarketBoardSearchResult = 0x01A6, // 6.18
        MiniCactpotInit = 0x037E, // 6.18
        NpcSpawn = 0x0163, // 6.18
        NpcSpawn2 = 0x0269, // 6.18
        ObjectSpawn = 0x0366, // 6.18
        PlaceFieldMarker = 0x029B, // 6.18
        PlaceFieldMarkerPreset = 0x025B, // 6.18
        PlayerSetup = 0x024E, // 6.18
        PlayerSpawn = 0x02C9, // 6.18
        PlayerStats = 0x03E0, // 6.18
        Playtime = 0x0230, // 6.18
        PrepareZoning = 0x03A9, // 6.18
        ResultDialog = 0x0267, // 6.18
        RetainerInformation = 0x0277, // 6.18
        SocialList = 0x019A, // 6.18
        StatusEffectList = 0x035B, // 6.18
        StatusEffectList2 = 0x01C0, // 6.18
        StatusEffectList3 = 0x00F4, // 6.18
        SubmarineExplorationResult = 0x02C2, // 6.18
        SubmarineProgressionStatus = 0x0309, // 6.18
        SubmarineStatusList = 0x014B, // 6.18
        SubmarineTimers = 0x0223, // 6.18
        SystemLogMessage = 0x008E, // 6.18
        UpdateClassInfo = 0x00B2, // 6.18
        UpdateHpMpTp = 0x00F9, // 6.18
        UpdateInventorySlot = 0x021F, // 6.18
        UpdateSearchInfo = 0x02A9, // 6.18
        WeatherChange = 0x0191, // 6.18
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00A9, // 6.18
        ClientTrigger = 0x01EA, // 6.18
        InventoryModifyHandler = 0x0234, // 6.18 (Base offset: 0x023B)
        LogoutHandler = 0x02C6, // 6.18
        MarketBoardPurchaseHandler = 0x024A, // 6.18
        SetSearchInfoHandler = 0x0236, // 6.18
        UpdatePositionHandler = 0x03AE, // 6.18
        UpdatePositionInstance = 0x006D, // 6.18
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
