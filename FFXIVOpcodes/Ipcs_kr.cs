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
        ActorCast = 0x0121, // v5.45
        ActorControl = 0x014B, // v5.45
        ActorControlSelf = 0x0149, // v5.45
        ActorControlTarget = 0x01CE, // v5.45
        ActorGauge = 0x037F, // v5.45
        ActorMove = 0x00D7, // v5.45
        ActorSetPos = 0x02F5, // v5.45
        AirshipExplorationResult = 0x0270, // v5.45
        AirshipStatus = 0x02B7, // v5.45
        AirshipStatusList = 0x0123, // v5.45
        AirshipTimers = 0x01FC, // v5.45
        AoeEffect16 = 0x019C, // v5.45
        AoeEffect24 = 0x02DD, // v5.45
        AoeEffect32 = 0x0079, // v5.45
        AoeEffect8 = 0x0225, // v5.45
        CFNotify = 0x0128, // v5.45
        CFPreferredRole = 0x0239, // v5.45
        ContainerInfo = 0x00C2, // v5.45
        CurrencyCrystalInfo = 0x03DE, // v5.45
        DesynthResult = 0x0341, // v5.45
        Effect = 0x026F, // v5.45
        EffectResult = 0x00B1, // v5.45
        EventFinish = 0x019E, // v5.45
        EventPlay = 0x0068, // v5.45
        EventPlay32 = 0x015E, // v5.45
        EventPlay4 = 0x00A7, // v5.45
        EventStart = 0x00E8, // v5.45
        Examine = 0x02BD, // v5.45
        ExamineFreeCompanyInfo = 0x025C, // v5.45
        ExamineSearchInfo = 0x0080, // v5.45
        FreeCompanyDialog = 0x019D, // v5.45
        FreeCompanyInfo = 0x02BB, // v5.45
        HousingWardInfo = 0x03A6, // v5.45
        InitZone = 0x01B2, // v5.45
        InventoryActionAck = 0x0327, // v5.45
        InventoryTransaction = 0x0259, // v5.45
        InventoryTransactionFinish = 0x00CE, // v5.45
        ItemInfo = 0x01E9, // v5.45
        Logout = 0x00CA, // v5.45
        MarketBoardItemListing = 0x0092, // v5.45
        MarketBoardItemListingCount = 0x021F, // v5.45
        MarketBoardItemListingHistory = 0x01DE, // v5.45
        MarketBoardPurchase = 0x0317, // v5.45
        MarketBoardSearchResult = 0x03E4, // v5.45
        MiniCactpotInit = 0x017E, // v5.45
        NpcSpawn = 0x0148, // v5.45
        ObjectSpawn = 0x011A, // v5.45
        PlaceFieldMarker = 0x00BD, // v5.45
        PlaceFieldMarkerPreset = 0x0374, // v5.45
        PlayerSetup = 0x018B, // v5.45
        PlayerSpawn = 0x020C, // v5.45
        PlayerStats = 0x0150, // v5.45
        Playtime = 0x03AF, // v5.45
        PrepareZoning = 0x03BC, // v5.45
        ResultDialog = 0x02BC, // v5.45
        RetainerInformation = 0x02EF, // v5.45
        SomeDirectorUnk4 = 0x0181, // v5.45
        StatusEffectList = 0x03E3, // v5.45
        StatusEffectList2 = 0x0318, // v5.45
        SubmarineExplorationResult = 0x0302, // v5.45
        SubmarineProgressionStatus = 0x0250, // v5.45
        SubmarineStatusList = 0x0292, // v5.45
        SubmarineTimers = 0x01AC, // v5.45
        UpdateClassInfo = 0x032D, // v5.45
        UpdateHpMpTp = 0x0277, // v5.45
        UpdateInventorySlot = 0x026A, // v5.45
        UpdateSearchInfo = 0x0325, // v5.45
        WeatherChange = 0x00E5, // v5.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x0314, // v5.45
        ClientTrigger = 0x011D, // v5.45
        InventoryModifyHandler = 0x02A4, // v5.45 (Base offset: 0x02AB)
        LogoutHandler = 0x0135, // v5.45
        MarketBoardPurchaseHandler = 0x0072, // v5.45
        SetSearchInfoHandler = 0x02C3, // v5.45
        UpdatePositionHandler = 0x0170, // v5.45
        UpdatePositionInstance = 0x03D9, // v5.45
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
