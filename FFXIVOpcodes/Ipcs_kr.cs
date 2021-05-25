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
        // ActorFreeSpawn = 0x01A4, // updated v5.4
        // AddStatusEffect = 0x0119, // updated v5.4
        // BossStatusEffectList = 0x0292, // updated 5.25
        ActorCast = 0x00EB,// v5.4 Hot-fix
        ActorControl = 0x01CF,// v5.4 Hot-fix
        ActorControlSelf = 0x0307,// v5.4 Hot-fix
        ActorControlTarget = 0x01DF,// v5.4 Hot-fix
        ActorGauge = 0x00A5,// v5.4 Hot-fix
        ActorMove = 0x0182,// v5.4 Hot-fix
        ActorSetPos = 0x03B5,// v5.4 Hot-fix
        AirshipExplorationResult = 0x0130, // v5.4 Hot-fix
        AirshipStatus = 0x0333,// v5.4 Hot-fix
        AirshipStatusList = 0x02F3,// v5.4 Hot-fix
        AirshipTimers = 0x02D6,// v5.4 Hot-fix
        AoeEffect16 = 0x0131,// v5.4 Hot-fix
        AoeEffect24 = 0x03C0,// v5.4 Hot-fix
        AoeEffect32 = 0x0361,// v5.4 Hot-fix
        AoeEffect8 = 0x0235,// v5.4 Hot-fix
        CFNotify = 0x033D,// v5.4 Hot-fix
        CFPreferredRole = 0x0359,// v5.4 Hot-fix
        ContainerInfo = 0x038B,// v5.4 Hot-fix
        CurrencyCrystalInfo = 0x01C5,// v5.4 Hot-fix
        DesynthResult = 0x0203, // v5.4 Hot-fix
        Effect = 0x00B5,// v5.4 Hot-fix
        EffectResult = 0x01F2,// v5.4 Hot-fix
        EventFinish = 0x0224,// v5.4 Hot-fix
        EventPlay = 0x012C,// v5.4 Hot-fix
        EventPlay32 = 0x00D9, // v5.4 Hot-fix
        EventPlay4 = 0x01A6,// v5.4 Hot-fix
        EventStart = 0x030B,// v5.4 Hot-fix
        Examine = 0x0193,// v5.4 Hot-fix
        ExamineFreeCompanyInfo = 0x028B, // v5.4 Hot-fix
        ExamineSearchInfo = 0x02A4,// v5.4 Hot-fix
        FreeCompanyDialog = 0x0269,// v5.4 Hot-fix
        FreeCompanyInfo = 0x0087,// v5.4 Hot-fix
        HousingWardInfo = 0x00DF, // v5.4 Hot-fix
        InitZone = 0x035A,// v5.4 Hot-fix
        InventoryActionAck = 0x007E,// v5.4 Hot-fix
        InventoryTransaction = 0x0209,// v5.4 Hot-fix
        InventoryTransactionFinish = 0x00CE,// v5.4 Hot-fix
        ItemInfo = 0x01C6,// v5.4 Hot-fix
        Logout = 0x0396, // v5.4 Hot-fix
        MarketBoardItemListing = 0x009D,// v5.4 Hot-fix
        MarketBoardItemListingCount = 0x02FA,// v5.4 Hot-fix
        MarketBoardItemListingHistory = 0x03AE,// v5.4 Hot-fix
        MarketBoardPurchase = 0x02E6,// v5.4 Hot-fix
        MarketBoardSearchResult = 0x0220,// v5.4 Hot-fix
        MiniCactpotInit = 0x00A4,// v5.4 Hot-fix
        NpcSpawn = 0x0144,// v5.4 Hot-fix
        ObjectSpawn = 0x013D,// v5.4 Hot-fix
        PlaceFieldMarker = 0x02A7,// v5.4 Hot-fix
        PlaceFieldMarkerPreset = 0x0118,// v5.4 Hot-fix
        PlayerSetup = 0x02AA,// v5.4 Hot-fix
        PlayerSpawn = 0x00A7,// v5.4 Hot-fix
        PlayerStats = 0x02BF,// v5.4 Hot-fix
        Playtime = 0x0179,// v5.4 Hot-fix
        PrepareZoning = 0x0143, // v5.4 Hot-fix
        ResultDialog = 0x008F,// v5.4 Hot-fix
        RetainerInformation = 0x03BC,// v5.4 Hot-fix
        SomeDirectorUnk4 = 0x007C,// v5.4 Hot-fix
        StatusEffectList = 0x0113,// v5.4 Hot-fix
        StatusEffectList2 = 0x0389, // v5.4 Hot-fix
        SubmarineExplorationResult = 0x0117, // v5.4 Hot-fix
        SubmarineProgressionStatus = 0x0093,// v5.4 Hot-fix
        SubmarineStatusList = 0x03A0,// v5.4 Hot-fix
        SubmarineTimers = 0x018C,// v5.4 Hot-fix
        UpdateClassInfo = 0x0088,// v5.4 Hot-fix
        UpdateHpMpTp = 0x03E5,// v5.4 Hot-fix
        UpdateInventorySlot = 0x00BD,// v5.4 Hot-fix
        UpdateSearchInfo = 0x0344,// v5.4 Hot-fix
        WeatherChange = 0x01A9, // v5.4 Hot-fix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00D6,// v5.4 Hot-fix
        ClientTrigger = 0x014E,// v5.4 Hot-fix
        InventoryModifyHandler = 0x0200,// v5.4 Hot-fix (Base offset: 0x0207)
        LogoutHandler = 0x02FD, // v5.4 Hot-fix
        MarketBoardPurchaseHandler = 0x0357,// v5.4 Hot-fix
        SetSearchInfoHandler = 0x01B7,// v5.4 Hot-fix
        UpdatePositionHandler = 0x039C,// v5.4 Hot-fix
        UpdatePositionInstance = 0x034B,// v5.4 Hot-fix
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
