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
        ActorCast = 0x031E, // 6.38
        ActorControl = 0x02EE, // 6.38
        ActorControlSelf = 0x0273, // 6.38
        ActorControlTarget = 0x037A, // 6.38
        ActorGauge = 0x0093, // 6.38
        ActorMove = 0x0200, // 6.38
        ActorSetPos = 0x01B6, // 6.38
        AirshipExplorationResult = 0x02A6, // 6.38
        AirshipStatus = 0x025A, // 6.38
        AirshipStatusList = 0x00A0, // 6.38
        AirshipTimers = 0x0192, // 6.38
        AoeEffect16 = 0x0182, // 6.38
        AoeEffect24 = 0x01BA, // 6.38
        AoeEffect32 = 0x0304, // 6.38
        AoeEffect8 = 0x03AC, // 6.38
        CEDirector = 0x00D3, // 6.38
        CFNotify = 0x01F8, // 6.38
        CFPreferredRole = 0x0261, // 6.38
        ContainerInfo = 0x0236, // 6.38
        CurrencyCrystalInfo = 0x03A2, // 6.38
        DesynthResult = 0x0360, // 6.38
        Effect = 0x01A4, // 6.38
        EffectResult = 0x0209, // 6.38
        EffectResultBasic = 0x016A, // 6.38
        EnvironmentControl = 0x032C, // 6.38
        EventFinish = 0x010F, // 6.38
        EventStart = 0x01DA, // 6.38
        Examine = 0x01AA, // 6.38
        ExamineFreeCompanyInfo = 0x00F3, // 6.38
        ExamineSearchInfo = 0x0176, // 6.38
        FreeCompanyDialog = 0x02A7, // 6.38
        FreeCompanyInfo = 0x012D, // 6.38
        HousingWardInfo = 0x038C, // 6.38
        InitZone = 0x0380, // 6.38
        InventoryActionAck = 0x039E, // 6.38
        InventoryTransaction = 0x026D, // 6.38
        InventoryTransactionFinish = 0x00CD, // 6.38
        IslandWorkshopSupplyDemand = 0x03A9, // 6.38
        ItemInfo = 0x02FD, // 6.38
        ItemMarketBoardInfo = 0x03AD, // 6.38
        Logout = 0x0114, // 6.38
        MarketBoardItemListing = 0x0115, // 6.38
        MarketBoardItemListingCount = 0x01BD, // 6.38
        MarketBoardItemListingHistory = 0x01EB, // 6.38
        MarketBoardPurchase = 0x00CA, // 6.38
        MarketBoardSearchResult = 0x0283, // 6.38
        MiniCactpotInit = 0x00A3, // 6.38
        NpcSpawn = 0x02C0, // 6.38
        ObjectSpawn = 0x00AE, // 6.38
        PlaceFieldMarker = 0x0161, // 6.38
        PlaceFieldMarkerPreset = 0x015A, // 6.38
        PlayerSetup = 0x01C0, // 6.38
        PlayerSpawn = 0x03B6, // 6.38
        PlayerStats = 0x033B, // 6.38
        Playtime = 0x019D, // 6.38
        PrepareZoning = 0x014C, // 6.38
        ResultDialog = 0x027C, // 6.38
        RetainerInformation = 0x01E3, // 6.38
        RSVData = 0x03C1, // 6.38
        SocialList = 0x00FA, // 6.38
        StatusEffectList = 0x0212, // 6.38
        StatusEffectList2 = 0x018E, // 6.38
        StatusEffectList3 = 0x0399, // 6.38
        SubmarineExplorationResult = 0x038F, // 6.38
        SubmarineProgressionStatus = 0x01B2, // 6.38
        SubmarineStatusList = 0x030B, // 6.38
        SubmarineTimers = 0x0251, // 6.38
        SystemLogMessage = 0x0211, // 6.38
        UpdateClassInfo = 0x03A4, // 6.38
        UpdateHpMpTp = 0x039C, // 6.38
        UpdateInventorySlot = 0x02BA, // 6.38
        UpdateSearchInfo = 0x0196, // 6.38
        WeatherChange = 0x0335, // 6.38

        EventPlay = 0x01B3, // 6.38
        EventPlay4 = 0x01BC, // 6.38
        EventPlay8 = 0x0320, // 6.38
        EventPlay16 = 0x00C7, // 6.38
        EventPlay32 = 0x034B, // 6.38
        EventPlay64 = 0x02E3, // 6.38
        EventPlay128 = 0x01AE, // 6.38
        EventPlay255 = 0x00DF, // 6.38
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x020A, // 6.38
        ClientTrigger = 0x0142, // 6.38
        InventoryModifyHandler = 0x015F, // 6.38 (Base offset: 0x0166)
        LogoutHandler = 0x03D7, // 6.38
        MarketBoardPurchaseHandler = 0x03BB, // 6.38
        SetSearchInfoHandler = 0x01D0, // 6.38
        UpdatePositionHandler = 0x0230, // 6.38
        UpdatePositionInstance = 0x00F2, // 6.38
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
