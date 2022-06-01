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
        ActorCast = 0x01F6, // 6.01
        ActorControl = 0x0240, // 6.01
        ActorControlSelf = 0x0099, // 6.01
        ActorControlTarget = 0x00CD, // 6.01
        ActorGauge = 0x018C, // 6.01
        ActorMove = 0x00CB, // 6.01
        ActorSetPos = 0x0277, // 6.01
        AirshipExplorationResult = 0x0323, // 6.01
        AirshipStatus = 0x03C4, // 6.01
        AirshipStatusList = 0x00AC, // 6.01
        AirshipTimers = 0x018F, // 6.01
        AoeEffect16 = 0x0318, // 6.01
        AoeEffect24 = 0x018E, // 6.01
        AoeEffect32 = 0x0250, // 6.01
        AoeEffect8 = 0x00B2, // 6.01
        CFNotify = 0x03DE, // 6.01
        CFPreferredRole = 0x039A, // 6.01
        ContainerInfo = 0x030B, // 6.01
        CurrencyCrystalInfo = 0x0098, // 6.01
        DesynthResult = 0x02B8, // 6.01
        Effect = 0x019F, // 6.01
        EffectResult = 0x02CB, // 6.01
        EffectResultBasic = 0x007A, // 6.01
        EventFinish = 0x0248, // 6.01
        EventPlay = 0x017D, // 6.01
        EventPlay32 = 0x0398, // 6.01
        EventPlay4 = 0x034A, // 6.01
        EventStart = 0x0286, // 6.01
        Examine = 0x030C, // 6.01
        ExamineFreeCompanyInfo = 0x0335, // 6.01
        ExamineSearchInfo = 0x025F, // 6.01
        FreeCompanyDialog = 0x01BD, // 6.01
        FreeCompanyInfo = 0x02BD, // 6.01
        HousingWardInfo = 0x03DC, // 6.01
        InitZone = 0x00A8, // 6.01
        InventoryActionAck = 0x0352, // 6.01
        InventoryTransaction = 0x020C, // 6.01
        InventoryTransactionFinish = 0x038E, // 6.01
        ItemInfo = 0x0339, // 6.01
        ItemMarketBoardInfo = 0x02FB, // 6.01
        Logout = 0x02D5, // 6.01
        MarketBoardItemListing = 0x0314, // 6.01
        MarketBoardItemListingCount = 0x0224, // 6.01
        MarketBoardItemListingHistory = 0x01A1, // 6.01
        MarketBoardPurchase = 0x025A, // 6.01
        MarketBoardSearchResult = 0x00F8, // 6.01
        MiniCactpotInit = 0x036E, // 6.01
        NpcSpawn = 0x01E5, // 6.01
        ObjectSpawn = 0x009C, // 6.01
        PlaceFieldMarker = 0x02EC, // 6.01
        PlaceFieldMarkerPreset = 0x0341, // 6.01
        PlayerSetup = 0x0065, // 6.01
        PlayerSpawn = 0x0195, // 6.01
        PlayerStats = 0x02AD, // 6.01
        Playtime = 0x03A2, // 6.01
        PrepareZoning = 0x01CE, // 6.01
        ResultDialog = 0x0382, // 6.01
        RetainerInformation = 0x031A, // 6.01
        SomeDirectorUnk4 = 0x02A0, // (SystemLogMessage) 6.01
        StatusEffectList = 0x0211, // 6.01
        StatusEffectList2 = 0x0179, // 6.01
        StatusEffectList3 = 0x013A, // 6.01
        SubmarineExplorationResult = 0x03B6, // 6.01
        SubmarineProgressionStatus = 0x011E, // 6.01
        SubmarineStatusList = 0x02CA, // 6.01
        SubmarineTimers = 0x03A5, // 6.01
        UpdateClassInfo = 0x03D6, // 6.01
        UpdateHpMpTp = 0x02B2, // 6.01
        UpdateInventorySlot = 0x02E8, // 6.01
        UpdateSearchInfo = 0x0343, // 6.01
        WeatherChange = 0x0237, // 6.01
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00D1, // 6.01
        ClientTrigger = 0x037E, // 6.01
        InventoryModifyHandler = 0x0354, // 6.01 (Base offset: 0x035B)
        LogoutHandler = 0x025E, // 6.01
        MarketBoardPurchaseHandler = 0x0268, // 6.01
        SetSearchInfoHandler = 0x00B6, // 6.01
        UpdatePositionHandler = 0x0256, // 6.01
        UpdatePositionInstance = 0x02DC, // 6.01
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
