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
        ActorCast = 0x025D, // 6.0
        ActorControl = 0x031A, // 6.0
        ActorControlSelf = 0x02A0, // 6.0
        ActorControlTarget = 0x030E, // 6.0
        ActorGauge = 0x0223, // 6.0
        ActorMove = 0x012D, // 6.0
        ActorSetPos = 0x017D, // 6.0
        AirshipExplorationResult = 0x0174, // 6.0
        AirshipStatus = 0x00A3, // 6.0
        AirshipStatusList = 0x03CC, // 6.0
        AirshipTimers = 0x0373, // 6.0
        AoeEffect16 = 0x009B, // 6.0
        AoeEffect24 = 0x01F8, // 6.0
        AoeEffect32 = 0x024C, // 6.0
        AoeEffect8 = 0x0156, // 6.0
        CFNotify = 0x0200, // 6.0
        CFPreferredRole = 0x022B, // 6.0
        ContainerInfo = 0x0169, // 6.0
        CurrencyCrystalInfo = 0x0259, // 6.0
        DesynthResult = 0x01B1, // 6.0
        Effect = 0x03DE, // 6.0
        EffectResult = 0x0357, // 6.0
        EventFinish = 0x0237, // 6.0
        EventPlay = 0x0221, // 6.0
        EventPlay32 = 0x01B0, // 6.0
        EventPlay4 = 0x0351, // 6.0
        EventStart = 0x01A1, // 6.0
        Examine = 0x01DF, // 6.0
        ExamineFreeCompanyInfo = 0x031E, // 6.0
        ExamineSearchInfo = 0x00FA, // 6.0
        FreeCompanyDialog = 0x0335, // 6.0
        FreeCompanyInfo = 0x02B6, // 6.0
        HousingWardInfo = 0x039D, // 6.0
        InitZone = 0x02B3, // 6.0
        InventoryActionAck = 0x0264, // 6.0
        InventoryTransaction = 0x006A, // 6.0
        InventoryTransactionFinish = 0x00E7, // 6.0
        ItemInfo = 0x01DB, // 6.0
        ItemMarketBoardInfo = 0x01C1, // 6.0
        Logout = 0x0289, // 6.0
        MarketBoardItemListing = 0x0292, // 6.0
        MarketBoardItemListingCount = 0x02C0, // 6.0
        MarketBoardItemListingHistory = 0x03A4, // 6.0
        MarketBoardPurchase = 0x01C3, // 6.0
        MarketBoardSearchResult = 0x03DF, // 6.0
        MiniCactpotInit = 0x0146, // 6.0
        NpcSpawn = 0x0380, // 6.0
        ObjectSpawn = 0x03CB, // 6.0
        PlaceFieldMarker = 0x02FC, // 6.0
        PlaceFieldMarkerPreset = 0x02DB, // 6.0
        PlayerSetup = 0x03E0, // 6.0
        PlayerSpawn = 0x0266, // 6.0
        PlayerStats = 0x026F, // 6.0
        Playtime = 0x0106, // 6.0
        PrepareZoning = 0x02E1, // 6.0
        ResultDialog = 0x01F0, // 6.0
        RetainerInformation = 0x0163, // 6.0
        SomeDirectorUnk4 = 0x023C, // 6.0
        StatusEffectList = 0x02C8, // 6.0
        StatusEffectList2 = 0x0384, // 6.0
        StatusEffectList3 = 0x036D, // 6.0
        SubmarineExplorationResult = 0x00CD, // 6.0
        SubmarineProgressionStatus = 0x01A6, // 6.0
        SubmarineStatusList = 0x0270, // 6.0
        SubmarineTimers = 0x0098, // 6.0
        UpdateClassInfo = 0x0152, // 6.0
        UpdateHpMpTp = 0x0175, // 6.0
        UpdateInventorySlot = 0x00D6, // 6.0
        UpdateSearchInfo = 0x0170, // 6.0
        WeatherChange = 0x03A8, // 6.0
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x02CC, // 6.0
        ClientTrigger = 0x0307, // 6.0
        InventoryModifyHandler = 0x0368, // 6.0 (Base offset: 0x036F)
        LogoutHandler = 0x0255, // 6.0
        MarketBoardPurchaseHandler = 0x02A3, // 6.0
        SetSearchInfoHandler = 0x00AE, // 6.0
        UpdatePositionHandler = 0x0139, // 6.0
        UpdatePositionInstance = 0x03BB, // 6.0
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
