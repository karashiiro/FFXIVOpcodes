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
        ActorCast = 0x03BE, // 6.31
        ActorControl = 0x0353, // 6.31
        ActorControlSelf = 0x00CD, // 6.31
        ActorControlTarget = 0x0148, // 6.31
        ActorGauge = 0x01CD, // 6.31
        ActorMove = 0x02D4, // 6.31
        ActorSetPos = 0x0268, // 6.31
        AirshipExplorationResult = 0x0305, // 6.31
        AirshipStatus = 0x00B8, // 6.31
        AirshipStatusList = 0x01D2, // 6.31
        AirshipTimers = 0x016E, // 6.31
        AoeEffect16 = 0x0231, // 6.31
        AoeEffect24 = 0x0339, // 6.31
        AoeEffect32 = 0x0079, // 6.31
        AoeEffect8 = 0x0191, // 6.31
        CEDirector = 0x0187, // 6.31
        CFNotify = 0x0394, // 6.31
        CFPreferredRole = 0x03AB, // 6.31
        ContainerInfo = 0x00BA, // 6.31
        CurrencyCrystalInfo = 0x03CF, // 6.31
        DesynthResult = 0x00B2, // 6.31
        Effect = 0x031B, // 6.31
        EffectResult = 0x017E, // 6.31
        EffectResultBasic = 0x01BD, // 6.31
        EventFinish = 0x0354, // 6.31
        EventPlay = 0x02AD, // 6.31
        EventPlay32 = 0x026F, // 6.31
        EventPlay4 = 0x02EE, // 6.31
        EventStart = 0x039E, // 6.31
        Examine = 0x01B3, // 6.31
        ExamineFreeCompanyInfo = 0x01BA, // 6.31
        ExamineSearchInfo = 0x019C, // 6.31
        FreeCompanyDialog = 0x0277, // 6.31
        FreeCompanyInfo = 0x0188, // 6.31
        HousingWardInfo = 0x009E, // 6.31
        InitZone = 0x0065, // 6.31
        InventoryActionAck = 0x02B2, // 6.31
        InventoryTransaction = 0x0151, // 6.31
        InventoryTransactionFinish = 0x038B, // 6.31
        IslandWorkshopSupplyDemand = 0x03E5, // 6.31
        ItemInfo = 0x0361, // 6.31
        ItemMarketBoardInfo = 0x00AE, // 6.31
        Logout = 0x03AF, // 6.31
        MapEffect = 0x02B9, // 6.31
        MarketBoardItemListing = 0x0375, // 6.31
        MarketBoardItemListingCount = 0x030A, // 6.31
        MarketBoardItemListingHistory = 0x00D5, // 6.31
        MarketBoardPurchase = 0x02F3, // 6.31
        MarketBoardSearchResult = 0x02AC, // 6.31
        MiniCactpotInit = 0x03C8, // 6.31
        NpcSpawn = 0x03DC, // 6.31
        ObjectSpawn = 0x01EF, // 6.31
        PlaceFieldMarker = 0x024B, // 6.31
        PlaceFieldMarkerPreset = 0x03CB, // 6.31
        PlayerSetup = 0x034A, // 6.31
        PlayerSpawn = 0x0139, // 6.31
        PlayerStats = 0x0257, // 6.31
        Playtime = 0x006F, // 6.31
        PrepareZoning = 0x0071, // 6.31
        ResultDialog = 0x00EC, // 6.31
        RetainerInformation = 0x026D, // 6.31
        RSVData = 0x0169, // 6.31
        SocialList = 0x01F7, // 6.31
        StatusEffectList = 0x0090, // 6.31
        StatusEffectList2 = 0x007F, // 6.31
        StatusEffectList3 = 0x01B0, // 6.31
        SubmarineExplorationResult = 0x01D0, // 6.31
        SubmarineProgressionStatus = 0x02E7, // 6.31
        SubmarineStatusList = 0x033C, // 6.31
        SubmarineTimers = 0x039D, // 6.31
        SystemLogMessage = 0x01E2, // 6.31
        UpdateClassInfo = 0x01A4, // 6.31
        UpdateHpMpTp = 0x01A6, // 6.31
        UpdateInventorySlot = 0x035B, // 6.31
        UpdateSearchInfo = 0x02C0, // 6.31
        WeatherChange = 0x03D8, // 6.31
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00D3, // 6.31
        ClientTrigger = 0x0210, // 6.31
        InventoryModifyHandler = 0x02E0,// 6.31 (Base offset: 0x02E7)
        LogoutHandler = 0x013A, // 6.31
        MarketBoardPurchaseHandler = 0x018B, // 6.31
        SetSearchInfoHandler = 0x03B8,// 6.31
        UpdatePositionHandler = 0x01DB,// 6.31
        UpdatePositionInstance = 0x012D,// 6.31
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
