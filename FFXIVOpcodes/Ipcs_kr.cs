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
        ActorCast = 0x0163, // 6.35
        ActorControl = 0x0129, // 6.35
        ActorControlSelf = 0x029D, // 6.35
        ActorControlTarget = 0x0180, // 6.35
        ActorGauge = 0x00CC, // 6.35
        ActorMove = 0x0144, // 6.35
        ActorSetPos = 0x0368, // 6.35
        AirshipExplorationResult = 0x00E2, // 6.35
        AirshipStatus = 0x009D, // 6.35
        AirshipStatusList = 0x01D5, // 6.35
        AirshipTimers = 0x0314, // 6.35
        AoeEffect16 = 0x01C3, // 6.35
        AoeEffect24 = 0x008C, // 6.35
        AoeEffect32 = 0x02F7, // 6.35
        AoeEffect8 = 0x019B, // 6.35
        CEDirector = 0x0259, // 6.35
        CFNotify = 0x009B, // 6.35
        CFPreferredRole = 0x0304, // 6.35
        ContainerInfo = 0x011B, // 6.35
        CurrencyCrystalInfo = 0x0384, // 6.35
        DesynthResult = 0x032F, // 6.35
        Effect = 0x0096, // 6.35
        EffectResult = 0x00A6, // 6.35
        EffectResultBasic = 0x019A, // 6.35
        EventFinish = 0x0240, // 6.35
        EventPlay = 0x0291, // 6.35
        EventPlay32 = 0x02D7, // 6.35
        EventPlay4 = 0x0170, // 6.35
        EventStart = 0x014B, // 6.35
        Examine = 0x0331, // 6.35
        ExamineFreeCompanyInfo = 0x00C3, // 6.35
        ExamineSearchInfo = 0x006A, // 6.35
        FreeCompanyDialog = 0x023E, // 6.35
        FreeCompanyInfo = 0x01D8, // 6.35
        HousingWardInfo = 0x029A, // 6.35
        InitZone = 0x01C8, // 6.35
        InventoryActionAck = 0x012B, // 6.35
        InventoryTransaction = 0x0276, // 6.35
        InventoryTransactionFinish = 0x02E4, // 6.35
        IslandWorkshopSupplyDemand = 0x0396, // 6.35
        ItemInfo = 0x0258, // 6.35
        ItemMarketBoardInfo = 0x038C, // 6.35
        Logout = 0x0087, // 6.35
        MapEffect = 0x01B3, // 6.35
        MarketBoardItemListing = 0x0380, // 6.35
        MarketBoardItemListingCount = 0x0125, // 6.35
        MarketBoardItemListingHistory = 0x014C, // 6.35
        MarketBoardPurchase = 0x03BC, // 6.35
        MarketBoardSearchResult = 0x023C, // 6.35
        MiniCactpotInit = 0x01C1, // 6.35
        NpcSpawn = 0x03D5, // 6.35
        ObjectSpawn = 0x0203, // 6.35
        PlaceFieldMarker = 0x027A, // 6.35
        PlaceFieldMarkerPreset = 0x0206, // 6.35
        PlayerSetup = 0x0367, // 6.35
        PlayerSpawn = 0x006F, // 6.35
        PlayerStats = 0x03B1, // 6.35
        Playtime = 0x00FD, // 6.35
        PrepareZoning = 0x01AF, // 6.35
        ResultDialog = 0x0333, // 6.35
        RetainerInformation = 0x00FE, // 6.35
        // RSVData = 0x0169, // 6.31
        SocialList = 0x013F, // 6.35
        StatusEffectList = 0x0097, // 6.35
        StatusEffectList2 = 0x01B2, // 6.35
        StatusEffectList3 = 0x03B3, // 6.35
        SubmarineExplorationResult = 0x0292, // 6.35
        SubmarineProgressionStatus = 0x014A, // 6.35
        SubmarineStatusList = 0x0146, // 6.35
        SubmarineTimers = 0x0283, // 6.35
        SystemLogMessage = 0x00AC, // 6.35
        UpdateClassInfo = 0x02C8, // 6.35
        UpdateHpMpTp = 0x0222, // 6.35
        UpdateInventorySlot = 0x027D, // 6.35
        UpdateSearchInfo = 0x0309, // 6.35
        WeatherChange = 0x00CD, // 6.35
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00C0, // 6.35
        ClientTrigger = 0x02F6, // 6.35
        InventoryModifyHandler = 0x01A5, // 6.35 (Base offset: 0x01AC)
        LogoutHandler = 0x0199, // 6.35
        MarketBoardPurchaseHandler = 0x039D, // 6.35
        SetSearchInfoHandler = 0x0244, // 6.35
        UpdatePositionHandler = 0x038A, // 6.35
        UpdatePositionInstance = 0x02FB, // 6.35
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
