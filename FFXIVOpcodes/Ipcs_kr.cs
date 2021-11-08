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
        ActorCast = 0x0171, // 5.551
        ActorControl = 0x016D, // 5.551
        ActorControlSelf = 0x01CD, // 5.551
        ActorControlTarget = 0x01F9, // 5.551
        ActorGauge = 0x03D6, // 5.551
        ActorMove = 0x01FA, // 5.551
        ActorSetPos = 0x02B7, // 5.551
        AirshipExplorationResult = 0x01DC, // 5.551
        AirshipStatus = 0x00F9, // 5.551
        AirshipStatusList = 0x03C8, // 5.551
        AirshipTimers = 0x008D, // 5.551
        AoeEffect16 = 0x0273, // 5.551
        AoeEffect24 = 0x01E9, // 5.551
        AoeEffect32 = 0x035A, // 5.551
        AoeEffect8 = 0x02BD, // 5.551
        CFNotify = 0x012E, // 5.551
        CFPreferredRole = 0x00BA, // 5.551
        ContainerInfo = 0x01F3, // 5.551
        CurrencyCrystalInfo = 0x0341, // 5.551
        DesynthResult = 0x0233, // 5.551
        Effect = 0x034F, // 5.551
        EffectResult = 0x00DA, // 5.551
        EventFinish = 0x018D, // 5.551
        EventPlay = 0x00C8, // 5.551
        EventPlay32 = 0x017A, // 5.551
        EventPlay4 = 0x0226, // 5.551
        EventStart = 0x02C1, // 5.551
        Examine = 0x00E4, // 5.551
        ExamineFreeCompanyInfo = 0x0181, // 5.551
        ExamineSearchInfo = 0x007A, // 5.551
        FreeCompanyDialog = 0x029F, // 5.551
        FreeCompanyInfo = 0x03E3, // 5.551
        HousingWardInfo = 0x0192, // 5.551
        InitZone = 0x0335, // 5.551
        InventoryActionAck = 0x01B8, // 5.551
        InventoryTransaction = 0x02D4, // 5.551
        InventoryTransactionFinish = 0x0396, // 5.551
        ItemInfo = 0x02FE, // 5.551
        ItemMarketBoardInfo = 0x0165, // 5.551
        Logout = 0x036C, // 5.551
        MarketBoardItemListing = 0x0232, // 5.551
        MarketBoardItemListingCount = 0x0392, // 5.551
        MarketBoardItemListingHistory = 0x0371, // 5.551
        MarketBoardPurchase = 0x0218, // 5.551
        MarketBoardSearchResult = 0x029C, // 5.551
        MiniCactpotInit = 0x0213, // 5.551
        NpcSpawn = 0x02CD, // 5.551
        ObjectSpawn = 0x0176, // 5.551
        PlaceFieldMarker = 0x0202, // 5.551
        PlaceFieldMarkerPreset = 0x00F2, // 5.551
        PlayerSetup = 0x009F, // 5.551
        PlayerSpawn = 0x014D, // 5.551
        PlayerStats = 0x00BD, // 5.551
        Playtime = 0x00EE, // 5.551
        PrepareZoning = 0x0141, // 5.551
        ResultDialog = 0x00F0, // 5.551
        RetainerInformation = 0x0277, // 5.551
        SomeDirectorUnk4 = 0x0275, // 5.551
        StatusEffectList = 0x01A9, // 5.551
        StatusEffectList2 = 0x02A4, // 5.551
        SubmarineExplorationResult = 0x039C, // 5.551
        SubmarineProgressionStatus = 0x02DC, // 5.551
        SubmarineStatusList = 0x029D, // 5.551
        SubmarineTimers = 0x0166, // 5.551
        UpdateClassInfo = 0x012A, // 5.551
        UpdateHpMpTp = 0x00DE, // 5.551
        UpdateInventorySlot = 0x0363, // 5.551
        UpdateSearchInfo = 0x0102, // 5.551
        WeatherChange = 0x020E, // 5.551
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0139, // 5.551
        ClientTrigger = 0x0146, // 5.551
        InventoryModifyHandler = 0x01E1, // 5.551 (Base offset: 0x01E8)
        LogoutHandler = 0x0250, // 5.551
        MarketBoardPurchaseHandler = 0x0263, // 5.551
        SetSearchInfoHandler = 0x0379, // 5.551
        UpdatePositionHandler = 0x01B6, // 5.551
        UpdatePositionInstance = 0x01FA, // 5.551
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
