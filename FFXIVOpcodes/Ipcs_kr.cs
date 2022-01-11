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
        // ActorFreeSpawn = 0x01F9, // v5.41
        // AddStatusEffect = 0x0119, // updated v5.4
        // BossStatusEffectList = 0x0292, // updated 5.25
        ActorCast = 0x00B9, // 5.58
        ActorControl = 0x03C8, // 5.58
        ActorControlSelf = 0x02A1, // 5.58
        ActorControlTarget = 0x030C, // 5.58
        ActorGauge = 0x00CE, // 5.58
        ActorMove = 0x00F4, // 5.58
        ActorSetPos = 0x01EE, // 5.58
        AirshipExplorationResult = 0x00E0, // 5.58
        AirshipStatus = 0x03D0, // 5.58
        AirshipStatusList = 0x01FF, // 5.58
        AirshipTimers = 0x00F6, // 5.58
        AoeEffect16 = 0x016C, // 5.58
        AoeEffect24 = 0x02AC, // 5.58
        AoeEffect32 = 0x0291, // 5.58
        AoeEffect8 = 0x0237, // 5.58
        CFNotify = 0x01FC, // 5.58
        CFPreferredRole = 0x01D5, // 5.58
        ContainerInfo = 0x009E, // 5.58
        CurrencyCrystalInfo = 0x0306, // 5.58
        DesynthResult = 0x01B4, // 5.58
        Effect = 0x019B, // 5.58
        EffectResult = 0x01E2, // 5.58
        EventFinish = 0x0249, // 5.58
        EventPlay = 0x0075, // 5.58
        EventPlay32 = 0x029A, // 5.58
        EventPlay4 = 0x0290, // 5.58
        EventStart = 0x0096, // 5.58
        Examine = 0x033E, // 5.58
        ExamineFreeCompanyInfo = 0x016B, // 5.58
        ExamineSearchInfo = 0x0220, // 5.58
        FreeCompanyDialog = 0x02C1, // 5.58
        FreeCompanyInfo = 0x0357, // 5.58
        HousingWardInfo = 0x0232, // 5.58
        InitZone = 0x0173, // 5.58
        InventoryActionAck = 0x026C, // 5.58
        InventoryTransaction = 0x0330, // 5.58
        InventoryTransactionFinish = 0x0184, // 5.58
        ItemInfo = 0x00D1, // 5.58
        ItemMarketBoardInfo = 0x00BC, // 5.58
        Logout = 0x03CB, // 5.58
        MarketBoardItemListing = 0x0304, // 5.58
        MarketBoardItemListingCount = 0x03B9, // 5.58
        MarketBoardItemListingHistory = 0x0327, // 5.58
        MarketBoardPurchase = 0x036D, // 5.58
        MarketBoardSearchResult = 0x0226, // 5.58
        MiniCactpotInit = 0x0396, // 5.58
        NpcSpawn = 0x019A, // 5.58
        ObjectSpawn = 0x0376, // 5.58
        PlaceFieldMarker = 0x03E5, // 5.58
        PlaceFieldMarkerPreset = 0x011C, // 5.58
        PlayerSetup = 0x0301, // 5.58
        PlayerSpawn = 0x0137, // 5.58
        PlayerStats = 0x00F8, // 5.58
        Playtime = 0x00A8, // 5.58
        PrepareZoning = 0x00AC, // 5.58
        ResultDialog = 0x02FF, // 5.58
        RetainerInformation = 0x00EF, // 5.58
        SomeDirectorUnk4 = 0x0277, // 5.58
        StatusEffectList = 0x015D, // 5.58
        StatusEffectList2 = 0x01CC, // 5.58
        SubmarineExplorationResult = 0x0162, // 5.58
        SubmarineProgressionStatus = 0x0372, // 5.58
        SubmarineStatusList = 0x00EB, // 5.58
        SubmarineTimers = 0x0120, // 5.58
        UpdateClassInfo = 0x014F, // 5.58
        UpdateHpMpTp = 0x020A, // 5.58
        UpdateInventorySlot = 0x025A, // 5.58
        UpdateSearchInfo = 0x0187, // 5.58
        WeatherChange = 0x027A, // 5.58
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x03E3, // 5.58
        ClientTrigger = 0x038B, // 5.58
        InventoryModifyHandler = 0x01BB, // 5.58 (Base offset: 0x01C2)
        LogoutHandler = 0x0334, // 5.58
        MarketBoardPurchaseHandler = 0x021A, // 5.58
        SetSearchInfoHandler = 0x0275, // 5.58
        UpdatePositionHandler = 0x038C, // 5.58
        UpdatePositionInstance = 0x00F4, // 5.58
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
