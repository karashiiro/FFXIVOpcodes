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
        ActorCast = 0x0231, // 6.3
        ActorControl = 0x02BE, // 6.3
        ActorControlSelf = 0x02ED, // 6.3
        ActorControlTarget = 0x0210, // 6.3
        ActorGauge = 0x0335, // 6.3
        ActorMove = 0x0365, // 6.3
        ActorSetPos = 0x030C, // 6.3
        AirshipExplorationResult = 0x0103, // 6.3
        AirshipStatus = 0x03B7, // 6.3
        AirshipStatusList = 0x0068, // 6.3
        AirshipTimers = 0x032D, // 6.3
        AoeEffect16 = 0x01C6, // 6.3
        AoeEffect24 = 0x0091, // 6.3
        AoeEffect32 = 0x039D, // 6.3
        AoeEffect8 = 0x0371, // 6.3
        CEDirector = 0x0309, // 6.3
        CFNotify = 0x006F, // 6.3
        CFPreferredRole = 0x01E9, // 6.3
        ContainerInfo = 0x02C5, // 6.3
        CurrencyCrystalInfo = 0x036D,
        DesynthResult = 0x03A8, // 6.3
        Effect = 0x00E8, // 6.3
        EffectResult = 0x01EC, // 6.3
        EffectResultBasic = 0x0222, // 6.3
        EventFinish = 0x02F6, // 6.3
        EventPlay = 0x0277, // 6.3
        EventPlay32 = 0x0392, // 6.3
        EventPlay4 = 0x025B, // 6.3
        EventStart = 0x008B, // 6.3
        Examine = 0x01C3, // 6.3
        ExamineFreeCompanyInfo = 0x0133, // 6.3
        ExamineSearchInfo = 0x0226, // 6.3
        FreeCompanyDialog = 0x02B1, // 6.3
        FreeCompanyInfo = 0x01A4, // 6.3
        HousingWardInfo = 0x01FB, // 6.3
        InitZone = 0x01DF, // 6.3
        InventoryActionAck = 0x033D, // 6.3
        InventoryTransaction = 0x0393, // 6.3
        InventoryTransactionFinish = 0x02E5, // 6.3
        IslandWorkshopSupplyDemand = 0x00B0, // 6.3
        ItemInfo = 0x0123, // 6.3
        ItemMarketBoardInfo = 0x00EA, // 6.3
        Logout = 0x038D, // 6.3
        MapEffect = 0x0275, // 6.3
        MarketBoardItemListing = 0x022A, // 6.3
        MarketBoardItemListingCount = 0x0117, // 6.3
        MarketBoardItemListingHistory = 0x0134, // 6.3
        MarketBoardPurchase = 0x0105, // 6.3
        MarketBoardSearchResult = 0x020B, // 6.3
        MiniCactpotInit = 0x01EB, // 6.3
        NpcSpawn = 0x022B, // 6.3
        ObjectSpawn = 0x02CB, // 6.3
        PlaceFieldMarker = 0x0223, // 6.3
        PlaceFieldMarkerPreset = 0x01A2, // 6.3
        PlayerSetup = 0x026E, // 6.3
        PlayerSpawn = 0x031E, // 6.3
        PlayerStats = 0x0341, // 6.3
        Playtime = 0x031F, // 6.3
        PrepareZoning = 0x034F, // 6.3
        ResultDialog = 0x00C6, // 6.3
        RetainerInformation = 0x010F, // 6.3
        SocialList = 0x009A, // 6.3
        StatusEffectList = 0x0067, // 6.3
        StatusEffectList2 = 0x3B0, // 6.3
        StatusEffectList3 = 0xDA, // 6.3
        SubmarineExplorationResult = 0x0191, // 6.3
        SubmarineProgressionStatus = 0x017E, // 6.3
        SubmarineStatusList = 0x0122, // 6.3
        SubmarineTimers = 0x019C, // 6.3
        SystemLogMessage = 0x03E0, // 6.3
        UpdateClassInfo = 0x03B6, // 6.3
        UpdateHpMpTp = 0x0166, // 6.3
        UpdateInventorySlot = 0x039C, // 6.3
        UpdateSearchInfo = 0x03BE, // 6.3
        WeatherChange = 0x0358, // 6.3
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0125, // 6.3
        ClientTrigger = 0x0390, // 6.3
        InventoryModifyHandler = 0x0282, // 6.3 (Base offset: 0x0289)
        LogoutHandler = 0x0273, // 6.3
        MarketBoardPurchaseHandler = 0x0258, // 6.3
        SetSearchInfoHandler = 0x0307, // 6.3
        UpdatePositionHandler = 0x0074, // 6.3
        UpdatePositionInstance = 0x0248, // 6.3
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
