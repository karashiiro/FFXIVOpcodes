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
        ActorCast = 0x033C, // v5.41
        ActorControl = 0x0217, // v5.41
        ActorControlSelf = 0x03B3, // v5.41
        ActorControlTarget = 0x01A2, // v5.41
        ActorGauge = 0x02BF, // v5.41
        ActorMove = 0x01BB, // v5.41
        ActorSetPos = 0x0382, // v5.41
        AirshipExplorationResult = 0x01FB, // v5.41
        AirshipStatus = 0x0071, // v5.41
        AirshipStatusList = 0x01E2, // v5.41
        AirshipTimers = 0x02F9, // v5.41
        AoeEffect16 = 0x01F6, // v5.41
        AoeEffect24 = 0x010C, // v5.41
        AoeEffect32 = 0x0384, // v5.41
        AoeEffect8 = 0x00D7, // v5.41
        CFNotify = 0x01D8, // v5.41
        CFPreferredRole = 0x01CB, // v5.41
        ContainerInfo = 0x007A, // v5.41
        CurrencyCrystalInfo = 0x02CA, // v5.41
        DesynthResult = 0x029A, // v5.41
        Effect = 0x0210, // v5.41
        EffectResult = 0x00A6, // v5.41
        EventFinish = 0x022B, // v5.41
        EventPlay = 0x0322, // v5.41
        EventPlay32 = 0x0398, // v5.41
        EventPlay4 = 0x0119, // v5.41
        EventStart = 0x0067, // v5.41
        Examine = 0x02FE, // v5.41
        ExamineFreeCompanyInfo = 0x033E, // v5.41
        ExamineSearchInfo = 0x00FD, // v5.41
        FreeCompanyDialog = 0x015E, // v5.41
        FreeCompanyInfo = 0x037A, // v5.41
        HousingWardInfo = 0x0266, // v5.41
        InitZone = 0x01F1, // v5.41
        InventoryActionAck = 0x014E, // v5.41
        InventoryTransaction = 0x02E5, // v5.41
        InventoryTransactionFinish = 0x0075, // v5.41
        ItemInfo = 0x02A5, // v5.41
        Logout = 0x0358, // v5.41
        MarketBoardItemListing = 0x0081, // v5.41
        MarketBoardItemListingCount = 0x03A4, // v5.41
        MarketBoardItemListingHistory = 0x00C9, // v5.41
        MarketBoardPurchase = 0x00DC, // v5.41
        MarketBoardSearchResult = 0x0365, // v5.41
        MiniCactpotInit = 0x0268, // v5.41
        NpcSpawn = 0x03E3, // v5.41
        ObjectSpawn = 0x0312, // v5.41
        PlaceFieldMarker = 0x026A, // v5.41
        PlaceFieldMarkerPreset = 0x03D4, // v5.41
        PlayerSetup = 0x0107, // v5.41
        PlayerSpawn = 0x00A9, // v5.41
        PlayerStats = 0x0308, // v5.41
        Playtime = 0x03AC, // v5.41
        PrepareZoning = 0x0288, // v5.41
        ResultDialog = 0x00CC, // v5.41
        RetainerInformation = 0x011B, // v5.41
        SomeDirectorUnk4 = 0x00F5, // v5.41
        StatusEffectList = 0x0235, // v5.41
        StatusEffectList2 = 0x02EA, // v5.41
        SubmarineExplorationResult = 0x01C8, // v5.41
        SubmarineProgressionStatus = 0x01B5, // v5.41
        SubmarineStatusList = 0x01B6, // v5.41
        SubmarineTimers = 0x0176, // v5.41
        UpdateClassInfo = 0x00B9, // v5.41
        UpdateHpMpTp = 0x00AD, // v5.41
        UpdateInventorySlot = 0x026E, // v5.41
        UpdateSearchInfo = 0x0342, // v5.41
        WeatherChange = 0x019E, // v5.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00D0, // v5.41
        ClientTrigger = 0x013E, // v5.41
        InventoryModifyHandler = 0x0145, // v5.41 (Base offset: 0x014C)
        LogoutHandler = 0x03AB, // v5.41
        MarketBoardPurchaseHandler = 0x0142, // v5.41
        SetSearchInfoHandler = 0x00E7, // v5.41
        UpdatePositionHandler = 0x0182, // v5.41
        UpdatePositionInstance = 0x0135, // v5.41
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
