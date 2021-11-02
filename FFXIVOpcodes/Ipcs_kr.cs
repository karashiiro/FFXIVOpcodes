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
        ActorCast = 0x02C5, // 5.55
        ActorControl = 0x01DA, // 5.55
        ActorControlSelf = 0x0333, // 5.55
        ActorControlTarget = 0x039C, // 5.55
        ActorGauge = 0x03BB, // 5.55
        ActorMove = 0x00D2, // 5.55
        ActorSetPos = 0x0266, // 5.55
        AirshipExplorationResult = 0x020A, // 5.55
        AirshipStatus = 0x019D, // 5.55
        AirshipStatusList = 0x00F7, // 5.55
        AirshipTimers = 0x00D4, // 5.55
        AoeEffect16 = 0x023E, // 5.55
        AoeEffect24 = 0x030C, // 5.55
        AoeEffect32 = 0x010C, // 5.55
        AoeEffect8 = 0x03B3, // 5.55
        CFNotify = 0x028E, // 5.55
        CFPreferredRole = 0x00D6, // 5.55
        ContainerInfo = 0x029C, // 5.55
        CurrencyCrystalInfo = 0x0245, // 5.55
        DesynthResult = 0x026F, // 5.55
        Effect = 0x013F, // 5.55
        EffectResult = 0x0120, // 5.55
        EventFinish = 0x01A6, // 5.55
        EventPlay = 0x0112, // 5.55
        EventPlay32 = 0x0235, // 5.55
        EventPlay4 = 0x01D4, // 5.55
        EventStart = 0x0261, // 5.55
        Examine = 0x008F, // 5.55
        ExamineFreeCompanyInfo = 0x0178, // 5.55
        ExamineSearchInfo = 0x017B, // 5.55
        FreeCompanyDialog = 0x0218, // 5.55
        FreeCompanyInfo = 0x0195, // 5.55
        HousingWardInfo = 0x02E3, // 5.55
        InitZone = 0x02F0, // 5.55
        InventoryActionAck = 0x02C6, // 5.55
        InventoryTransaction = 0x038D, // 5.55
        InventoryTransactionFinish = 0x0186, // 5.55
        ItemInfo = 0x0147, // 5.55
        ItemMarketBoardInfo = 0x0300, // 5.55
        Logout = 0x01F0, // 5.55
        MarketBoardItemListing = 0x035B, // 5.55
        MarketBoardItemListingCount = 0x02B2, // 5.55
        MarketBoardItemListingHistory = 0x0319, // 5.55
        MarketBoardPurchase = 0x01A0, // 5.55
        MarketBoardSearchResult = 0x0222, // 5.55
        MiniCactpotInit = 0x034A, // 5.55
        NpcSpawn = 0x034E, // 5.55
        ObjectSpawn = 0x0271, // 5.55
        PlaceFieldMarker = 0x020D, // 5.55
        PlaceFieldMarkerPreset = 0x0220, // 5.55
        PlayerSetup = 0x0230, // 5.55
        PlayerSpawn = 0x036B, // 5.55
        PlayerStats = 0x0365, // 5.55
        Playtime = 0x019C, // 5.55
        PrepareZoning = 0x02B8, // 5.55
        ResultDialog = 0x0289, // 5.55
        RetainerInformation = 0x02BB, // 5.55
        SomeDirectorUnk4 = 0x012E, // 5.55
        StatusEffectList = 0x0369, // 5.55
        StatusEffectList2 = 0x0170, // 5.55
        SubmarineExplorationResult = 0x025E, // 5.55
        SubmarineProgressionStatus = 0x0160, // 5.55
        SubmarineStatusList = 0x0156, // 5.55
        SubmarineTimers = 0x0309, // 5.55
        UpdateClassInfo = 0x0345, // 5.55
        UpdateHpMpTp = 0x0166, // 5.55
        UpdateInventorySlot = 0x00DD, // 5.55
        UpdateSearchInfo = 0x00E9, // 5.55
        WeatherChange = 0x02EB, // 5.55
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0320, // 5.55
        ClientTrigger = 0x0328, // 5.55
        InventoryModifyHandler = 0x026C, // 5.55 (Base offset: 0x0273)
        LogoutHandler = 0x039F, // 5.55
        MarketBoardPurchaseHandler = 0x021C, // 5.55
        SetSearchInfoHandler = 0x0373, // 5.55
        UpdatePositionHandler = 0x0138, // 5.55
        UpdatePositionInstance = 0x00D2, // 5.55
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
