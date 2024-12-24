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
        ActorCast = 0x0367, // 7.01
        ActorControl = 0x01CA, // 7.01
        ActorControlSelf = 0x0328, // 7.01
        ActorControlTarget = 0x010D, // 7.01
        ActorGauge = 0x02F6, // 7.01
        ActorMove = 0x0106, // 7.01
        ActorSetPos = 0x01CB, // 7.01
        AirshipExplorationResult = 0x015B, // 7.01
        AirshipStatus = 0x012A, // 7.01
        AirshipStatusList = 0x0217, // 7.01
        AirshipTimers = 0x01E4, // 7.01
        AoeEffect16 = 0x0293, // 7.01
        AoeEffect24 = 0x02BA, // 7.01
        AoeEffect32 = 0x018A, // 7.01
        AoeEffect8 = 0x0121, // 7.01
        BattleTalk2 = 0x03C1, // 7.01
        BattleTalk4 = 0x00F1, // 7.01
        BattleTalk8 = 0x0234, // 7.01
        CEDirector = 0x015D, // 7.01
        CFNotify = 0x00F0, // 7.01
        CFPreferredRole = 0x039D, // 7.01
        ContainerInfo = 0x00E8, // 7.01
        Countdown = 0x0243, // 7.01
        CountdownCancel = 0x006E, // 7.01
        CraftingLog = 0x0233, // 7.01
        CurrencyCrystalInfo = 0x027A, // 7.01
        DespawnCharacter = 0x0122, // 7.01
        DesynthResult = 0x0127, // 7.01
        Effect = 0x01BC, // 7.01
        EffectResult = 0x0295, // 7.01
        EffectResult16 = 0x0260, // 7.01
        EffectResult32 = 0x006C, // 7.01
        EffectResult4 = 0x018D, // 7.01
        EffectResult8 = 0x01F7, // 7.01
        EffectResultBasic = 0x0311, // 7.01
        EffectResultBasic16 = 0x0173, // 7.01
        EffectResultBasic32 = 0x0353, // 7.01
        EffectResultBasic4 = 0x0292, // 7.01
        EffectResultBasic64 = 0x0355, // 7.01
        EffectResultBasic8 = 0x02B8, // 7.01
        EnvironmentControl = 0x01E2, // 7.01
        EventFinish = 0x02B4, // 7.01
        EventPlay = 0x03C9, // 7.01
        EventPlay128 = 0x0298, // 7.01
        EventPlay16 = 0x014F, // 7.01
        EventPlay255 = 0x02C2, // 7.01
        EventPlay32 = 0x01C2, // 7.01
        EventPlay4 = 0x02C8, // 7.01
        EventPlay64 = 0x01E0, // 7.01
        EventPlay8 = 0x00CB, // 7.01
        EventStart = 0x01B3, // 7.01
        ExamineFreeCompanyInfo = 0x02EA, // 7.01
        ExamineSearchComment = 0x0246, // 7.01
        ExamineSearchInfo = 0x0341, // 7.01
        FirstAttack = 0x03AD, // 7.01
        FreeCompanyDialog = 0x0160, // 7.01
        FreeCompanyInfo = 0x00AC, // 7.01
        HousingWardInfo = 0x038D, // 7.01
        Init = 0x02C9, // 7.01
        InitSearchInfo = 0x00BC, // 7.01
        InitZone = 0x02CB, // 7.01
        InventoryActionAck = 0x028D, // 7.01
        InventoryTransaction = 0x020B, // 7.01
        InventoryTransactionFinish = 0x00FD, // 7.01
        IslandWorkshopSupplyDemand = 0x014D, // 7.01
        ItemInfo = 0x0312, // 7.01
        ItemMarketBoardInfo = 0x009F, // 7.01
        LogMessage = 0x00CF, // 7.01
        Logout = 0x013E, // 7.01
        MarketBoardItemListing = 0x0113, // 7.01
        MarketBoardItemListingCount = 0x00BE, // 7.01
        MarketBoardItemListingHistory = 0x03AA, // 7.01
        MarketBoardPurchase = 0x0110, // 7.01
        MarketBoardSearchResult = 0x02B3, // 7.01
        MiniCactpotInit = 0x0229, // 7.01
        NpcSpawn = 0x03D5, // 7.01
        NpcSpawn2 = 0x0137, // 7.01
        NpcYell = 0x0169, // 7.01
        ObjectSpawn = 0x037F, // 7.01
        Ping = 0x00C8, // 7.01
        PlaceFieldMarker = 0x0286, // 7.01
        PlaceFieldMarkerPreset = 0x00DC, // 7.01
        PlayerSetup = 0x0065, // 7.01
        PlayerSpawn = 0x0300, // 7.01
        PlayerStats = 0x0145, // 7.01
        PlayerUpdateLook = 0x031E, // 7.01
        Playtime = 0x02C5, // 7.01
        PrepareZoning = 0x0199, // 7.01
        RetainerInformation = 0x021E, // 7.01
        RSFData = 0x031B, // 7.01
        RSVData = 0x0175, // 7.01
        ServerNotice = 0x00E5, // 7.01
        ServerNoticeShort = 0x02D4, // 7.01
        SetOnlineStatus = 0x0364, // 7.01
        SocialList = 0x027B, // 7.01
        SocialMessage = 0x00AA, // 7.01
        SocialMessage2 = 0x032A, // 7.01
        SocialRequestResponse = 0x03B8, // 7.01
        StatusEffectList = 0x0381, // 7.01
        StatusEffectListBozja = 0x02E0, // 7.01
        StatusEffectListDouble = 0x012D, // 7.01
        StatusEffectListEureka = 0x0326, // 7.01
        StatusEffectListPlayer = 0x00A9, // 7.01
        StatusEffectListPlayerDouble = 0x019C, // 7.01
        SubmarineExplorationResult = 0x01FF, // 7.01
        SubmarineProgressionStatus = 0x01F1, // 7.01
        SubmarineStatusList = 0x023A, // 7.01
        SubmarineTimers = 0x010A, // 7.01
        SystemLogMessage = 0x032B, // 7.01
        SystemLogMessage16 = 0x036B, // 7.01
        SystemLogMessage2 = 0x0098, // 7.01
        SystemLogMessage4 = 0x019E, // 7.01
        SystemLogMessage8 = 0x0150, // 7.01
        UpdateClassInfo = 0x03BD, // 7.01
        UpdateClassInfoBozja = 0x0285, // 7.01
        UpdateClassInfoEureka = 0x0223, // 7.01
        UpdateHpMpTp = 0x0176, // 7.01
        UpdateInventorySlot = 0x029F, // 7.01
        UpdateSearchInfo = 0x0391, // 7.01
        WeatherChange = 0x03CE, // 7.01
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x00D2, // 7.01
        ActionRequestGroundTargeted = 0x00ED, // 7.01
        ChatHandler = 0x009C, // 7.01
        ClientCountdownInitiate = 0x00A8, // 7.01
        ClientTrigger = 0x0160, // 7.01
        InventoryModifyHandler = 0x022B, // 7.01
        LogoutHandler = 0x021A, // 7.01
        MarketBoardPurchaseHandler = 0x0175, // 7.01
        SetSearchInfoHandler = 0x006A, // 7.01
        UpdatePositionHandler = 0x0280, // 7.01
        UpdatePositionInstance = 0x03D5, // 7.01
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
