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
        // ActorFreeSpawn = 0x01A4, // updated v5.4
        // AddStatusEffect = 0x0119, // updated v5.4
        // BossStatusEffectList = 0x0292, // updated 5.25
        ActorCast = 0x00C5, // updated v5.4
        ActorControl = 0x020A, // updated v5.4
        ActorControlSelf = 0x01A8, // updated v5.4
        ActorControlTarget = 0x0151, // updated v5.4
        ActorGauge = 0x0112, // updated v5.4
        ActorMove = 0x019C, // updated v5.4
        ActorSetPos = 0x0130, // updated v5.4
        AirshipExplorationResult = 0x02B4, // updated v5.4
        AirshipStatus = 0x0100, // updated v5.4
        AirshipStatusList = 0x01BA, // updated v5.4
        AirshipTimers = 0x0256, // updated v5.4
        AoeEffect16 = 0x00B9, // updated v5.4
        AoeEffect24 = 0x018F, // updated v5.4
        AoeEffect32 = 0x0195, // updated v5.4
        AoeEffect8 = 0x017F, // updated v5.4
        CFNotify = 0x0248, // updated v5.4
        CFPreferredRole = 0x0222, // updated v5.4
        ContainerInfo = 0x03CC, // updated v5.4
        CurrencyCrystalInfo = 0x034D, // updated v5.4
        DesynthResult = 0x01B1, // updated v5.4
        Effect = 0x02EA, // updated v5.4
        EffectResult = 0x0119, // updated v5.4
        EventFinish = 0x00DE, // updated v5.4
        EventPlay = 0x031F, // updated v5.4
        EventPlay32 = 0x00DF, // updated v5.4
        EventPlay4 = 0x0072, // updated v5.4
        EventStart = 0x00AF, // updated v5.4
        Examine = 0x0154, // updated v5.4
        ExamineFreeCompanyInfo = 0x02AC, // updated v5.4
        ExamineSearchInfo = 0x0233, // updated v5.4
        FreeCompanyDialog = 0x00F4, // updated v5.4
        FreeCompanyInfo = 0x0255, // updated v5.4
        HousingWardInfo = 0x0293, // updated v5.4
        InitZone = 0x0308, // updated v5.4
        InventoryActionAck = 0x03C0, // updated v5.4
        InventoryTransaction = 0x02D0, // updated v5.4
        InventoryTransactionFinish = 0x0229, // updated v5.4
        ItemInfo = 0x02FC, // updated v5.4
        Logout = 0x0110, // updated v5.4
        MarketBoardItemListing = 0x02E1, // updated v5.4
        MarketBoardItemListingCount = 0x0263, // updated v5.4
        MarketBoardItemListingHistory = 0x01B0, // updated v5.4
        MarketBoardPurchase = 0x0099, // updated v5.4
        MarketBoardSearchResult = 0x0253, // updated v5.4
        MiniCactpotInit = 0x01FB, // updated v5.4
        NpcSpawn = 0x0349, // updated v5.4
        ObjectSpawn = 0x00FE, // updated v5.4
        PlaceFieldMarker = 0x03E4, // updated v5.4
        PlaceFieldMarkerPreset = 0x01BD, // updated v5.4
        PlayerSetup = 0x01F7, // updated v5.4
        PlayerSpawn = 0x02C2, // updated v5.4
        PlayerStats = 0x03BC, // updated v5.4
        Playtime = 0x033B, // updated v5.4
        PrepareZoning = 0x00C6, // updated v5.4
        ResultDialog = 0x01ED, // updated v5.4
        RetainerInformation = 0x03C3, // updated v5.4
        SomeDirectorUnk4 = 0x02E7, // updated v5.4
        StatusEffectList = 0x00EB, // updated v5.4
        StatusEffectList2 = 0x025C, // updated v5.4
        SubmarineExplorationResult = 0x0302, // updated v5.4
        SubmarineProgressionStatus = 0x0087, // updated v5.4
        SubmarineStatusList = 0x01AB, // updated v5.4
        SubmarineTimers = 0x00BA, // updated v5.4
        UpdateClassInfo = 0x0067, // updated v5.4
        UpdateHpMpTp = 0x01A4, // updated v5.4
        UpdateInventorySlot = 0x038D, // updated v5.4
        UpdateSearchInfo = 0x03AD, // updated v5.4
        WeatherChange = 0x009F, // updated v5.4
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00B7, // updated v5.4
        ClientTrigger = 0x031A, // updated v5.4
        InventoryModifyHandler = 0x0283, // updated v5.4 (Base offset: 0x028A)
        LogoutHandler = 0x03B3, // updated v5.4
        MarketBoardPurchaseHandler = 0x0367, // updated v5.4
        SetSearchInfoHandler = 0x0094, // updated v5.4
        UpdatePositionHandler = 0x0224, // updated v5.4
        UpdatePositionInstance = 0x01E2, // updated v5.4
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
