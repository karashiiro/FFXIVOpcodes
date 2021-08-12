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
        ActorCast = 0x01B4, // 5.45 Hotfix
        ActorControl = 0x02B6, // 5.45 Hotfix
        ActorControlSelf = 0x00AE, // 5.45 Hotfix
        ActorControlTarget = 0x01B9, // 5.45 Hotfix
        ActorGauge = 0x03E0, // 5.45 Hotfix
        ActorMove = 0x01FE, // 5.45 Hotfix
        ActorSetPos = 0x0174, // 5.45 Hotfix
        AirshipExplorationResult = 0x0085, // 5.45 Hotfix
        AirshipStatus = 0x0128, // 5.45 Hotfix
        AirshipStatusList = 0x0362, // 5.45 Hotfix
        AirshipTimers = 0x021C, // 5.45 Hotfix
        AoeEffect16 = 0x02CD, // 5.45 Hotfix
        AoeEffect24 = 0x0254, // 5.45 Hotfix
        AoeEffect32 = 0x00CC, // 5.45 Hotfix
        AoeEffect8 = 0x0197, // 5.45 Hotfix
        CFNotify = 0x008A, // 5.45 Hotfix
        CFPreferredRole = 0x0359, // 5.45 Hotfix
        ContainerInfo = 0x01BF, // 5.45 Hotfix
        CurrencyCrystalInfo = 0x0390, // 5.45 Hotfix
        DesynthResult = 0x0095, // 5.45 Hotfix
        Effect = 0x02DC, // 5.45 Hotfix
        EffectResult = 0x028C, // 5.45 Hotfix
        EventFinish = 0x037D, // 5.45 Hotfix
        EventPlay = 0x0130, // 5.45 Hotfix
        EventPlay32 = 0x0077, // 5.45 Hotfix
        EventPlay4 = 0x02D3, // 5.45 Hotfix
        EventStart = 0x02B4, // 5.45 Hotfix
        Examine = 0x032E, // 5.45 Hotfix
        ExamineFreeCompanyInfo = 0x00B7, // 5.45 Hotfix
        ExamineSearchInfo = 0x0219, // 5.45 Hotfix
        FreeCompanyDialog = 0x028A, // 5.45 Hotfix
        FreeCompanyInfo = 0x0200, // 5.45 Hotfix
        HousingWardInfo = 0x033F, // 5.45 Hotfix
        InitZone = 0x039E, // 5.45 Hotfix
        InventoryActionAck = 0x03C5, // 5.45 Hotfix
        InventoryTransaction = 0x00BA, // 5.45 Hotfix
        InventoryTransactionFinish = 0x0068, // 5.45 Hotfix
        ItemInfo = 0x00B3, // 5.45 Hotfix
        Logout = 0x01E1, // 5.45 Hotfix
        MarketBoardItemListing = 0x0339, // 5.45 Hotfix
        MarketBoardItemListingCount = 0x00C3, // 5.45 Hotfix
        MarketBoardItemListingHistory = 0x0173, // 5.45 Hotfix
        MarketBoardPurchase = 0x007D, // 5.45 Hotfix
        MarketBoardSearchResult = 0x019A, // 5.45 Hotfix
        MiniCactpotInit = 0x00F3, // 5.45 Hotfix
        NpcSpawn = 0x0246, // 5.45 Hotfix
        ObjectSpawn = 0x02FD, // 5.45 Hotfix
        PlaceFieldMarker = 0x02EF, // 5.45 Hotfix
        PlaceFieldMarkerPreset = 0x0135, // 5.45 Hotfix
        PlayerSetup = 0x0115, // 5.45 Hotfix
        PlayerSpawn = 0x01E9, // 5.45 Hotfix
        PlayerStats = 0x022A, // 5.45 Hotfix
        Playtime = 0x010E, // 5.45 Hotfix
        PrepareZoning = 0x03AF, // 5.45 Hotfix
        ResultDialog = 0x021E, // 5.45 Hotfix
        RetainerInformation = 0x0171, // 5.45 Hotfix
        SomeDirectorUnk4 = 0x0152, // 5.45 Hotfix
        StatusEffectList = 0x0222, // 5.45 Hotfix
        StatusEffectList2 = 0x0256, // 5.45 Hotfix
        SubmarineExplorationResult = 0x0119, // 5.45 Hotfix
        SubmarineProgressionStatus = 0x01F3, // 5.45 Hotfix
        SubmarineStatusList = 0x0356, // 5.45 Hotfix
        SubmarineTimers = 0x013A, // 5.45 Hotfix
        UpdateClassInfo = 0x03D0, // 5.45 Hotfix
        UpdateHpMpTp = 0x02D7, // 5.45 Hotfix
        UpdateInventorySlot = 0x0274, // 5.45 Hotfix
        UpdateSearchInfo = 0x01E2, // 5.45 Hotfix
        WeatherChange = 0x00D8, // 5.45 Hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0278, // 5.45 Hotfix
        ClientTrigger = 0x03B2, // 5.45 Hotfix
        InventoryModifyHandler = 0x0306, // 5.45 Hotfix (Base offset: 0x030D)
        LogoutHandler = 0x013D, // 5.45 Hotfix
        MarketBoardPurchaseHandler = 0x02C5, // 5.45 Hotfix
        SetSearchInfoHandler = 0x02E0, // 5.45 Hotfix
        UpdatePositionHandler = 0x02BB, // 5.45 Hotfix
        UpdatePositionInstance = 0x02E1, // 5.45 Hotfix
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
