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
        ActorCast = 0x01C7, // 7.05
        ActorControl = 0x01B9, // 7.05
        ActorControlSelf = 0x0320, // 7.05
        ActorControlTarget = 0x016E, // 7.05
        ActorGauge = 0x00E8, // 7.05
        ActorMove = 0x03D8, // 7.05
        ActorSetPos = 0x012F, // 7.05
        AirshipExplorationResult = 0x024D, // 7.05
        AirshipStatus = 0x03C7, // 7.05
        AirshipStatusList = 0x02C4, // 7.05
        AirshipTimers = 0x01A4, // 7.05
        AoeEffect16 = 0x0174, // 7.05
        AoeEffect24 = 0x018D, // 7.05
        AoeEffect32 = 0x0146, // 7.05
        AoeEffect8 = 0x0335, // 7.05
        BattleTalk2 = 0x03CB, // 7.05
        BattleTalk4 = 0x01A7, // 7.05
        BattleTalk8 = 0x01FC, // 7.05
        CEDirector = 0x0322, // 7.05
        CFNotify = 0x01EA, // 7.05
        CFPreferredRole = 0x030B, // 7.05
        ContainerInfo = 0x00BC, // 7.05
        Countdown = 0x02B1, // 7.05
        CountdownCancel = 0x0281, // 7.05
        CraftingLog = 0x017A, // 7.05
        CurrencyCrystalInfo = 0x03D6, // 7.05
        DespawnCharacter = 0x00FD, // 7.05
        DesynthResult = 0x007C, // 7.05
        Effect = 0x037F, // 7.05
        EffectResult = 0x0232, // 7.05
        EffectResult16 = 0x0176, // 7.05
        EffectResult32 = 0x03B7, // 7.05
        EffectResult4 = 0x0328, // 7.05
        EffectResult8 = 0x026E, // 7.05
        EffectResultBasic = 0x0347, // 7.05
        EffectResultBasic16 = 0x00F4, // 7.05
        EffectResultBasic32 = 0x03E3, // 7.05
        EffectResultBasic4 = 0x0290, // 7.05
        EffectResultBasic64 = 0x028F, // 7.05
        EffectResultBasic8 = 0x018E, // 7.05
        EnvironmentControl = 0x0207, // 7.05
        EventFinish = 0x03AC, // 7.05
        EventPlay = 0x01EE, // 7.05
        EventPlay128 = 0x0237, // 7.05
        EventPlay16 = 0x01FF, // 7.05
        EventPlay255 = 0x015E, // 7.05
        EventPlay32 = 0x00DF, // 7.05
        EventPlay4 = 0x03C1, // 7.05
        EventPlay64 = 0x0268, // 7.05
        EventPlay8 = 0x038D, // 7.05
        EventStart = 0x02DA, // 7.05
        ExamineFreeCompanyInfo = 0x0117, // 7.05
        ExamineSearchComment = 0x0217, // 7.05
        ExamineSearchInfo = 0x02E9, // 7.05
        FashionReport = 0x015C, // 7.05
        FirstAttack = 0x0341, // 7.05
        FreeCompanyDialog = 0x01C4, // 7.05
        FreeCompanyInfo = 0x00AE, // 7.05
        HousingWardInfo = 0x01CA, // 7.05
        Init = 0x0200, // 7.05
        InitSearchInfo = 0x0170, // 7.05
        InitZone = 0x0244, // 7.05
        InventoryActionAck = 0x031F, // 7.05
        InventoryTransaction = 0x03E2, // 7.05
        InventoryTransactionFinish = 0x010D, // 7.05
        IslandWorkshopSupplyDemand = 0x0313, // 7.05
        ItemInfo = 0x025B, // 7.05
        ItemMarketBoardInfo = 0x0399, // 7.05
        LogMessage = 0x0189, // 7.05
        Logout = 0x01F8, // 7.05
        MarketBoardItemListing = 0x0226, // 7.05
        MarketBoardItemListingCount = 0x01E2, // 7.05
        MarketBoardItemListingHistory = 0x0301, // 7.05
        MarketBoardPurchase = 0x0228, // 7.05
        MarketBoardSearchResult = 0x033A, // 7.05
        MiniCactpotInit = 0x017C, // 7.05
        NpcSpawn = 0x02B4, // 7.05
        NpcSpawn2 = 0x008F, // 7.05
        NpcYell = 0x03A9, // 7.05
        ObjectSpawn = 0x02BB, // 7.05
        Ping = 0x0334, // 7.05
        PlaceFieldMarker = 0x02F6, // 7.05
        PlaceFieldMarkerPreset = 0x00CD, // 7.05
        PlayerSetup = 0x02D1, // 7.05
        PlayerSpawn = 0x00FF, // 7.05
        PlayerStats = 0x0069, // 7.05
        PlayerUpdateLook = 0x02F3, // 7.05
        Playtime = 0x0076, // 7.05
        PrepareZoning = 0x02D9, // 7.05
        RetainerInformation = 0x0393, // 7.05
        RSFData = 0x02EC, // 7.05
        RSVData = 0x02E4, // 7.05
        ServerNotice = 0x03CD, // 7.05
        ServerNoticeShort = 0x0144, // 7.05
        SetOnlineStatus = 0x0276, // 7.05
        SocialList = 0x0293, // 7.05
        SocialMessage = 0x00DD, // 7.05
        SocialMessage2 = 0x00CB, // 7.05
        SocialRequestResponse = 0x027C, // 7.05
        StatusEffectList = 0x00B9, // 7.05
        StatusEffectListBozja = 0x01D8, // 7.05
        StatusEffectListDouble = 0x0079, // 7.05
        StatusEffectListEureka = 0x02C2, // 7.05
        StatusEffectListPlayer = 0x0120, // 7.05
        StatusEffectListPlayerDouble = 0x03B2, // 7.05
        SubmarineExplorationResult = 0x0093, // 7.05
        SubmarineProgressionStatus = 0x0183, // 7.05
        SubmarineStatusList = 0x00F1, // 7.05
        SubmarineTimers = 0x017D, // 7.05
        SystemLogMessage = 0x021C, // 7.05
        SystemLogMessage16 = 0x02B9, // 7.05
        SystemLogMessage2 = 0x01B0, // 7.05
        SystemLogMessage4 = 0x02FA, // 7.05
        SystemLogMessage8 = 0x02D3, // 7.05
        Transfer = 0x0068, // 7.05
        UpdateClassInfo = 0x0257, // 7.05
        UpdateClassInfoBozja = 0x028A, // 7.05
        UpdateClassInfoEureka = 0x02D5, // 7.05
        UpdateHpMpTp = 0x0323, // 7.05
        UpdateInventorySlot = 0x0324, // 7.05
        UpdateSearchInfo = 0x032F, // 7.05
        WeatherChange = 0x006D, // 7.05
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0319, // 7.05
        ActionRequestGroundTargeted = 0x02F2, // 7.05
        ChatHandler = 0x027D, // 7.05
        ClientCountdownInitiate = 0x01CF, // 7.05
        ClientTrigger = 0x01C4, // 7.05
        InventoryModifyHandler = 0x038B, // 7.05
        LogoutHandler = 0x01FA, // 7.05
        MarketBoardPurchaseHandler = 0x02E4, // 7.05
        SetSearchInfoHandler = 0x015D, // 7.05
        UpdatePositionHandler = 0x00FA, // 7.05
        UpdatePositionInstance = 0x02B4, // 7.05
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
