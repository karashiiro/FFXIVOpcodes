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
        ActorCast = 0x03B0, // 6.11
        ActorControl = 0x0231, // 6.11
        ActorControlSelf = 0x014F, // 6.11
        ActorControlTarget = 0x0254, // 6.11
        ActorGauge = 0x006E, // 6.11
        ActorMove = 0x038F, // 6.11
        ActorSetPos = 0x0146, // 6.11
        AirshipExplorationResult = 0x0372, // 6.11
        AirshipStatus = 0x033E, // 6.11
        AirshipStatusList = 0x01F5, // 6.11
        AirshipTimers = 0x036F, // 6.11
        AoeEffect16 = 0x0236, // 6.11
        AoeEffect24 = 0x00E7, // 6.11
        AoeEffect32 = 0x00E1, // 6.11
        AoeEffect8 = 0x021B, // 6.11
        CEDirector = 0x0368, // 6.11
        CFNotify = 0x0099, // 6.11
        CFPreferredRole = 0x01B4, // 6.11
        ContainerInfo = 0x00BD, // 6.11
        CurrencyCrystalInfo = 0x0362, // 6.11
        DesynthResult = 0x03BB, // 6.11
        Effect = 0x017D, // 6.11
        EffectResult = 0x01BB, // 6.11
        EffectResultBasic = 0x01F8, // 6.11
        EventFinish = 0x02E6, // 6.11
        EventPlay = 0x0071, // 6.11
        EventPlay32 = 0x0276, // 6.11
        EventPlay4 = 0x00BB, // 6.11
        EventStart = 0x01E1, // 6.11
        Examine = 0x018B, // 6.11
        ExamineFreeCompanyInfo = 0x390, // 6.11
        ExamineSearchInfo = 0x0348, // 6.11
        FreeCompanyDialog = 0x0258, // 6.11
        FreeCompanyInfo = 0x035E, // 6.11
        HousingWardInfo = 0x0249, // 6.11
        InitZone = 0x013F, // 6.11
        InventoryActionAck = 0x01A2, // 6.11
        InventoryTransaction = 0x01B9, // 6.11
        InventoryTransactionFinish = 0x034A, // 6.11
        ItemInfo = 0x03AB, // 6.11
        ItemMarketBoardInfo = 0x0319, // 6.11
        Logout = 0x039A, // 6.11
        MapEffect = 0x010A, // 6.11
        MarketBoardItemListing = 0x02CC, // 6.11
        MarketBoardItemListingCount = 0x0068, // 6.11
        MarketBoardItemListingHistory = 0x0243, // 6.11
        MarketBoardPurchase = 0x0350, // 6.11
        MarketBoardSearchResult = 0x0363, // 6.11
        MiniCactpotInit = 0x00F3, // 6.11
        NpcSpawn = 0x00EC, // 6.11
        ObjectSpawn = 0x02FB, // 6.11
        PlaceFieldMarker = 0x02F5, // 6.11
        PlaceFieldMarkerPreset = 0x013C, // 6.11
        PlayerSetup = 0x0280, // 6.11
        PlayerSpawn = 0x00A5, // 6.11
        PlayerStats = 0x018D, // 6.11
        Playtime = 0x008E, // 6.11
        PrepareZoning = 0x00CC, // 6.11
        ResultDialog = 0x0269, // 6.11
        RetainerInformation = 0x00D1, // 6.11
        SocialList = 0x0238, // 6.11
        StatusEffectList = 0x00D9, // 6.11
        StatusEffectList2 = 0x02E7, // 6.11
        StatusEffectList3 = 0x03AF, // 6.11
        SubmarineExplorationResult = 0x016A, // 6.11
        SubmarineProgressionStatus = 0x00BF, // 6.11
        SubmarineStatusList = 0x03CC, // 6.11
        SubmarineTimers = 0x027C, // 6.11
        SystemLogMessage = 0x0103, // 6.11
        UpdateClassInfo = 0x02EA, // 6.11
        UpdateHpMpTp = 0x0192, // 6.11
        UpdateInventorySlot = 0x027F, // 6.11
        UpdateSearchInfo = 0x0221, // 6.11
        WeatherChange = 0x0366, // 6.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x016D, // 6.11
        ClientTrigger = 0x0097, // 6.11
        InventoryModifyHandler = 0x031C, // 6.11 (Base offset: 0x0323)
        LogoutHandler = 0x0375, // 6.11
        MarketBoardPurchaseHandler = 0x0174, // 6.11
        SetSearchInfoHandler = 0x019E, // 6.11
        UpdatePositionHandler = 0x00FC, // 6.11
        UpdatePositionInstance = 0x034F, // 6.11
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
