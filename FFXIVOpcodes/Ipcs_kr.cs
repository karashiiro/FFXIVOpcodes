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
        ActorCast = 0x01E2, // 6.25
        ActorControl = 0x0303, // 6.25
        ActorControlSelf = 0x00F4, // 6.25
        ActorControlTarget = 0x022B, // 6.25
        ActorGauge = 0x030C, // 6.25
        ActorMove = 0x0367, // 6.25
        ActorSetPos = 0x03CC, // 6.25
        AirshipExplorationResult = 0x01C6, // 6.25
        AirshipStatus = 0x0333, // 6.25
        AirshipStatusList = 0x01E6, // 6.25
        AirshipTimers = 0x0381, // 6.25
        AoeEffect16 = 0x0069, // 6.25
        AoeEffect24 = 0x03B1, // 6.25
        AoeEffect32 = 0x01CA, // 6.25
        AoeEffect8 = 0x00F6, // 6.25
        CEDirector = 0x0365, // 6.25
        CFNotify = 0x0229, // 6.25
        CFPreferredRole = 0x0261, // 6.25
        ContainerInfo = 0x0341, // 6.25
        CurrencyCrystalInfo = 0x02A5, // 6.25
        DesynthResult = 0x013A, // 6.25
        Effect = 0x0070, // 6.25
        EffectResult = 0x0123, // 6.25
        EffectResultBasic = 0x006E, // 6.25
        EventFinish = 0x020F, // 6.25
        EventPlay = 0x0092, // 6.25
        EventPlay32 = 0x0384, // 6.25
        EventPlay4 = 0x01B1, // 6.25
        EventStart = 0x01BB, // 6.25
        Examine = 0x02AE, // 6.25
        ExamineFreeCompanyInfo = 0x00A7, // 6.25
        ExamineSearchInfo = 0x007F, // 6.25
        FreeCompanyDialog = 0x021A, // 6.25
        FreeCompanyInfo = 0x017F, // 6.25
        HousingWardInfo = 0x0199, // 6.25
        InitZone = 0x028E, // 6.25
        InventoryActionAck = 0x0388, // 6.25
        InventoryTransaction = 0x0218, // 6.25
        InventoryTransactionFinish = 0x0249, // 6.25
        IslandWorkshopSupplyDemand = 0x03C9, // 6.25
        ItemInfo = 0x0191, // 6.25
        ItemMarketBoardInfo = 0x00C8, // 6.25
        Logout = 0x0370, // 6.25
        MapEffect = 0x02E8, // 6.25
        MarketBoardItemListing = 0x0227, // 6.25
        MarketBoardItemListingCount = 0x01E4, // 6.25
        MarketBoardItemListingHistory = 0x0266, // 6.25
        MarketBoardPurchase = 0x027B, // 6.25
        MarketBoardSearchResult = 0x0338, // 6.25
        MiniCactpotInit = 0x027A, // 6.25
        NpcSpawn = 0x0120, // 6.25
        ObjectSpawn = 0x019C, // 6.25
        PlaceFieldMarker = 0x0312, // 6.25
        PlaceFieldMarkerPreset = 0x010E, // 6.25
        PlayerSetup = 0x0164, // 6.25
        PlayerSpawn = 0x0395, // 6.25
        PlayerStats = 0x02C0, // 6.25
        Playtime = 0x00A4, // 6.25
        PrepareZoning = 0x02B3, // 6.25
        ResultDialog = 0x00CF, // 6.25
        RetainerInformation = 0x03BA, // 6.25
        SocialList = 0x02E7, // 6.25
        StatusEffectList = 0x033E, // 6.25
        StatusEffectList2 = 0x03DD, // 6.25
        StatusEffectList3 = 0x0122, // 6.25
        SubmarineExplorationResult = 0x03B4, // 6.25
        SubmarineProgressionStatus = 0x02F8, // 6.25
        SubmarineStatusList = 0x0159, // 6.25
        SubmarineTimers = 0x00FC, // 6.25
        SystemLogMessage = 0x0201, // 6.25
        UpdateClassInfo = 0x02B8, // 6.25
        UpdateHpMpTp = 0x008C, // 6.25
        UpdateInventorySlot = 0x0113, // 6.25
        UpdateSearchInfo = 0x007B, // 6.25
        WeatherChange = 0x01B9, // 6.25
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0203, // 6.25
        ClientTrigger = 0x016A, // 6.25
        InventoryModifyHandler = 0x024D, // 6.25 (Base offset: 0x0254)
        LogoutHandler = 0x02FF, // 6.25
        MarketBoardPurchaseHandler = 0x03E5, // 6.25
        SetSearchInfoHandler = 0x0256, // 6.25
        UpdatePositionHandler = 0x01E8, // 6.25
        UpdatePositionInstance = 0x0139, // 6.25
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
