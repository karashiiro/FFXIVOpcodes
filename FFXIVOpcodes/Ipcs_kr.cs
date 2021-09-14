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
        ActorCast = 0x01B9, // 5.5
        ActorControl = 0x02E7, // 5.5
        ActorControlSelf = 0x0310, // 5.5
        ActorControlTarget = 0x0247, // 5.5
        ActorGauge = 0x0351, // 5.5
        ActorMove = 0x02F6, // 5.5
        ActorSetPos = 0x0321, // 5.5
        AirshipExplorationResult = 0x01F0, // 5.5
        AirshipStatus = 0x0385, // 5.5
        AirshipStatusList = 0x0102, // 5.5
        AirshipTimers = 0x039A, // 5.5
        AoeEffect16 = 0x00BE, // 5.5
        AoeEffect24 = 0x0196, // 5.5
        AoeEffect32 = 0x034E, // 5.5
        AoeEffect8 = 0x01BE, // 5.5
        CFNotify = 0x02D6, // 5.5
        CFPreferredRole = 0x0195, // 5.5
        ContainerInfo = 0x02AF, // 5.5
        CurrencyCrystalInfo = 0x029D, // 5.5
        DesynthResult = 0x00F6, // 5.5
        Effect = 0x02F0, // 5.5
        EffectResult = 0x02E3, // 5.5
        EventFinish = 0x01B1, // 5.5
        EventPlay = 0x01EB, // 5.5
        EventPlay32 = 0x00D1, // 5.5
        EventPlay4 = 0x00E0, // 5.5
        EventStart = 0x0334, // 5.5
        Examine = 0x0126, // 5.5
        ExamineFreeCompanyInfo = 0x0184, // 5.5
        ExamineSearchInfo = 0x0140, // 5.5
        FreeCompanyDialog = 0x020E, // 5.5
        FreeCompanyInfo = 0x008A, // 5.5
        HousingWardInfo = 0x0287, // 5.5
        InitZone = 0x039F, // 5.5
        InventoryActionAck = 0x0143, // 5.5
        InventoryTransaction = 0x017A, // 5.5
        InventoryTransactionFinish = 0x03DA, // 5.5
        ItemInfo = 0x0280, // 5.5
        Logout = 0x0278, // 5.5
        MarketBoardItemListing = 0x0248, // 5.5
        MarketBoardItemListingCount = 0x0215, // 5.5
        MarketBoardItemListingHistory = 0x011D, // 5.5
        MarketBoardPurchase = 0x011E, // 5.5
        MarketBoardSearchResult = 0x0225, // 5.5
        MiniCactpotInit = 0x030D, // 5.5
        NpcSpawn = 0x0363, // 5.5
        ObjectSpawn = 0x0216, // 5.5
        PlaceFieldMarker = 0x0276, // 5.5
        PlaceFieldMarkerPreset = 0x009A, // 5.5
        PlayerSetup = 0x0244, // 5.5
        PlayerSpawn = 0x01E0, // 5.5
        PlayerStats = 0x0272, // 5.5
        Playtime = 0x026E, // 5.5
        PrepareZoning = 0x031E, // 5.5
        ResultDialog = 0x00DF, // 5.5
        RetainerInformation = 0x027A, // 5.5
        SomeDirectorUnk4 = 0x0300, // 5.5
        StatusEffectList = 0x0375, // 5.5
        StatusEffectList2 = 0x0359, // 5.5
        SubmarineExplorationResult = 0x036B, // 5.5
        SubmarineProgressionStatus = 0x0265, // 5.5
        SubmarineStatusList = 0x03C5, // 5.5
        SubmarineTimers = 0x01FC, // 5.5
        UpdateClassInfo = 0x0156, // 5.5
        UpdateHpMpTp = 0x02B4, // 5.5
        UpdateInventorySlot = 0x01AB, // 5.5
        UpdateSearchInfo = 0x01F2, // 5.5
        WeatherChange = 0x03AA, // 5.5
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x023D, // 5.5
        ClientTrigger = 0x006F, // 5.5
        InventoryModifyHandler = 0x0305, // 5.5 (Base offset: 0x030C)
        LogoutHandler = 0x01CD, // 5.5
        MarketBoardPurchaseHandler = 0x0203, // 5.5
        SetSearchInfoHandler = 0x033A, // 5.5
        UpdatePositionHandler = 0x00EC, // 5.5
        UpdatePositionInstance = 0x02F6, // 5.5
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
