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
        ActorCast = 0x0333, // 6.05
        ActorControl = 0x01A2, // 6.05
        ActorControlSelf = 0x01A6, // 6.05
        ActorControlTarget = 0x030A, // 6.05
        ActorGauge = 0x0272, // 6.05
        ActorMove = 0x0260, // 6.05
        ActorSetPos = 0x0397, // 6.05
        AirshipExplorationResult = 0x02F5, // 6.05
        AirshipStatus = 0x01CE, // 6.05
        AirshipStatusList = 0x01F4, // 6.05
        AirshipTimers = 0x01DD, // 6.05
        AoeEffect16 = 0x0298, // 6.05
        AoeEffect24 = 0x02B1, // 6.05
        AoeEffect32 = 0x00FF, // 6.05
        AoeEffect8 = 0x01FE, // 6.05
        CFNotify = 0x0332, // 6.05
        CFPreferredRole = 0x0170, // 6.05
        ContainerInfo = 0x01AD, // 6.05
        CurrencyCrystalInfo = 0x01CC, // 6.05
        DesynthResult = 0x01C8, // 6.05
        Effect = 0x00B6, // 6.05
        EffectResult = 0x00C2, // 6.05
        EffectResultBasic = 0x014F, // 6.05
        EventFinish = 0x02A0, // 6.05
        EventPlay = 0x0080, // 6.05
        EventPlay32 = 0x0222, // 6.05
        EventPlay4 = 0x02A5, // 6.05
        EventStart = 0x00E6, // 6.05
        Examine = 0x01A4, // 6.05
        ExamineFreeCompanyInfo = 0x0207, // 6.05
        ExamineSearchInfo = 0x00D9, // 6.05
        FreeCompanyDialog = 0x0278, // 6.05
        FreeCompanyInfo = 0x017C, // 6.05
        HousingWardInfo = 0x0099, // 6.05
        InitZone = 0x034D, // 6.05
        InventoryActionAck = 0x02D8, // 6.05
        InventoryTransaction = 0x0357, // 6.05
        InventoryTransactionFinish = 0x0330, // 6.05
        ItemInfo = 0x0150, // 6.05
        ItemMarketBoardInfo = 0x0180, // 6.05
        Logout = 0x0152, // 6.05
        MarketBoardItemListing = 0x03AA, // 6.05
        MarketBoardItemListingCount = 0x0263, // 6.05
        MarketBoardItemListingHistory = 0x0240, // 6.05
        MarketBoardPurchase = 0x033E, // 6.05
        MarketBoardSearchResult = 0x0385, // 6.05
        MiniCactpotInit = 0x0230, // 6.05
        NpcSpawn = 0x031D, // 6.05
        ObjectSpawn = 0x00DA, // 6.05
        PlaceFieldMarker = 0x0302, // 6.05
        PlaceFieldMarkerPreset = 0x02FF, // 6.05
        PlayerSetup = 0x01B5, // 6.05
        PlayerSpawn = 0x0300, // 6.05
        PlayerStats = 0x0173, // 6.05
        Playtime = 0x0280, // 6.05
        PrepareZoning = 0x0244, // 6.05
        ResultDialog = 0x0283, // 6.05
        RetainerInformation = 0x03E7, // 6.05
        StatusEffectList = 0x01C1, // 6.05
        StatusEffectList2 = 0x01FA, // 6.05
        StatusEffectList3 = 0x007B, // 6.05
        SubmarineExplorationResult = 0x01C0, // 6.05
        SubmarineProgressionStatus = 0x0373, // 6.05
        SubmarineStatusList = 0x0395, // 6.05
        SubmarineTimers = 0x0184, // 6.05
        SystemLogMessage = 0x02E9, // 6.05
        UpdateClassInfo = 0x02DB, // 6.05
        UpdateHpMpTp = 0x0293, // 6.05
        UpdateInventorySlot = 0x024A, // 6.05
        UpdateSearchInfo = 0x0135, // 6.05
        WeatherChange = 0x01B0, // 6.05
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x012F, // 6.05
        ClientTrigger = 0x0331, // 6.05
        InventoryModifyHandler = 0x0087, // 6.05 (Base offset: 0x008E)
        LogoutHandler = 0x00B2, // 6.05
        MarketBoardPurchaseHandler = 0x03CE, // 6.05
        SetSearchInfoHandler = 0x03D0, // 6.05
        UpdatePositionHandler = 0x025D, // 6.05
        UpdatePositionInstance = 0x03E0, // 6.05
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
