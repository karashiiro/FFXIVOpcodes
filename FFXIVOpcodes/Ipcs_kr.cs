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
        ActorCast = 0x00F2, // 6.57
        ActorControl = 0x01D1, // 6.57
        ActorControlSelf = 0x03BE, // 6.57
        ActorControlTarget = 0x02EB, // 6.57
        ActorGauge = 0x0270, // 6.57
        ActorMove = 0x00D8, // 6.57
        ActorSetPos = 0x03E5, // 6.57
        AirshipExplorationResult = 0x03DE, // 6.57
        AirshipStatus = 0x0338, // 6.57
        AirshipStatusList = 0x0267, // 6.57
        AirshipTimers = 0x011B, // 6.57
        AoeEffect16 = 0x0237, // 6.57
        AoeEffect24 = 0x00EA, // 6.57
        AoeEffect32 = 0x02C7, // 6.57
        AoeEffect8 = 0x0114, // 6.57
        ApplyIDScramble = 0x0098, // 6.57
        BalloonTalk2 = 0x034D, // 6.57
        BalloonTalk4 = 0x03C5, // 6.57
        BalloonTalk8 = 0x0352, // 6.57
        BattleTalk2 = 0x00F5, // 6.57
        BattleTalk4 = 0x00D1, // 6.57
        BattleTalk8 = 0x02C0, // 6.57
        BlackList = 0x036C, // 6.57
        CEDirector = 0x02B8, // 6.57
        CeremonySetActorAppearance = 0x0368, // 6.57
        CFCancel = 0x0210, // 6.57
        CFDutyInfo = 0x00D2, // 6.57
        CFNotify = 0x00D0, // 6.57
        CFPreferredRole = 0x0212, // 6.57
        CFRegistered = 0x0318, // 6.57
        CharaNameReq = 0x02D5, // 6.57
        CharaVisualEffect = 0x02A8, // 6.57
        Chat = 0x0370, // 6.57
        ContainerInfo = 0x0092, // 6.57
        ContentDirectorSync = 0x0346, // 6.57
        Countdown = 0x00F0, // 6.57
        CountdownCancel = 0x00C4, // 6.57
        CreateTreasure = 0x023B, // 6.57
        CrossWorldLinkshellList = 0x02D4, // 6.57
        CurrencyCrystalInfo = 0x0269, // 6.57
        DailyQuestRepeatFlags = 0x015A, // 6.57
        DailyQuests = 0x03AC, // 6.57
        DespawnCharacter = 0x03DD, // 6.57
        DesynthResult = 0x01EE, // 6.57
        DirectorVars = 0x0215, // 6.57
        Discovery = 0x0274, // 6.57
        Effect = 0x0250, // 6.57
        EffectResult = 0x0268, // 6.57
        EffectResult16 = 0x0084, // 6.57
        EffectResult4 = 0x006F, // 6.57
        EffectResult8 = 0x01D8, // 6.57
        EffectResultBasic = 0x02F5, // 6.57
        EffectResultBasic16 = 0x02FA, // 6.57
        EffectResultBasic32 = 0x02CF, // 6.57
        EffectResultBasic4 = 0x018D, // 6.57
        EffectResultBasic64 = 0x0080, // 6.57
        EffectResultBasic8 = 0x0178, // 6.57
        EnvironmentControl = 0x009A, // 6.57
        EorzeaTimeOffset = 0x0086, // 6.57
        EquipDisplayFlags = 0x0392, // 6.57
        EventContinue = 0x033B, // 6.57
        EventFinish = 0x00A4, // 6.57
        EventPlay = 0x036D, // 6.57
        EventPlay128 = 0x0138, // 6.57
        EventPlay16 = 0x0078, // 6.57
        EventPlay255 = 0x039A, // 6.57
        EventPlay32 = 0x0255, // 6.57
        EventPlay4 = 0x008E, // 6.57
        EventPlay64 = 0x01A8, // 6.57
        EventPlay8 = 0x0076, // 6.57
        EventStart = 0x0207, // 6.57
        Examine = 0x01A9, // 6.57
        ExamineFreeCompanyInfo = 0x00FC, // 6.57
        ExamineSearchComment = 0x025B, // 6.57
        ExamineSearchInfo = 0x010B, // 6.57
        Fall = 0x02BD, // 6.57
        FateInfo = 0x024A, // 6.57
        FellowshipList = 0x00D9, // 6.57
        FirstAttack = 0x01C3, // 6.57
        FreeCompanyDialog = 0x02DC, // 6.57
        FreeCompanyInfo = 0x0381, // 6.57
        GCAffiliation = 0x02DE, // 6.57
        HousingEstateGreeting = 0x02A3, // 6.57
        HousingIndoorInitialize = 0x0127, // 6.57
        HousingInternalObjectSpawn = 0x03A1, // 6.57
        HousingLandFlags = 0x0271, // 6.57
        HousingObjectDye = 0x01C0, // 6.57
        HousingObjectInitialize = 0x01FF, // 6.57
        HousingObjectMove = 0x03D6, // 6.57
        HousingShowEstateGuestAccess = 0x011C, // 6.57
        HousingUpdateLandFlagsSlot = 0x0374, // 6.57
        HousingWardInfo = 0x039B, // 6.57
        HuntingLogEntry = 0x02EA, // 6.57
        Init = 0x0143, // 6.57
        InitSearchInfo = 0x038B, // 6.57
        InitZone = 0x02E9, // 6.57
        InventoryActionAck = 0x01F7, // 6.57
        InventoryTransaction = 0x01BA, // 6.57
        InventoryTransactionFinish = 0x014E, // 6.57
        IslandWorkshopSupplyDemand = 0x035F, // 6.57
        ItemInfo = 0x0102, // 6.57
        ItemMarketBoardInfo = 0x02F3, // 6.57
        LandAvailability = 0x0117, // 6.57
        LandInfoSign = 0x02DA, // 6.57
        LandPriceUpdate = 0x03D9, // 6.57
        LandRename = 0x0131, // 6.57
        LandSetInitialize = 0x03AF, // 6.57
        LandSetMap = 0x03B6, // 6.57
        LandUpdate = 0x037A, // 6.57
        LandUpdateHouseName = 0x01E4, // 6.57
        LinkshellList = 0x03A0, // 6.57
        LogMessage = 0x03BC, // 6.57
        Logout = 0x021B, // 6.57
        LootMessage = 0x0165, // 6.57
        MailDeleteRequest = 0x011E, // 6.57
        MapUpdate = 0x0068, // 6.57
        MapUpdate128 = 0x016C, // 6.57
        MapUpdate16 = 0x02D7, // 6.57
        MapUpdate32 = 0x00CE, // 6.57
        MapUpdate4 = 0x03BF, // 6.57
        MapUpdate64 = 0x011A, // 6.57
        MapUpdate8 = 0x02AF, // 6.57
        MarketBoardItemListing = 0x013E, // 6.57
        MarketBoardItemListingCount = 0x01A3, // 6.57
        MarketBoardItemListingHistory = 0x0322, // 6.57
        MarketBoardPurchase = 0x0073, // 6.57
        MarketBoardSearchResult = 0x0331, // 6.57
        // MiniCactpotInit = 0x02E4, // 6.55
        ModelEquip = 0x03A3, // 6.57
        Mount = 0x0261, // 6.57
        MSQTrackerComplete = 0x0291, // 6.57
        NpcSpawn = 0x029F, // 6.57
        NpcSpawn2 = 0x01D0, // 6.57
        NpcYell = 0x00B7, // 6.57
        ObjectDespawn = 0x03A9, // 6.57
        ObjectSpawn = 0x0213, // 6.57
        OpenTreasure = 0x0342, // 6.57
        PartyMessage = 0x01EC, // 6.57
        Ping = 0x03BB, // 6.57
        PlaceFieldMarker = 0x0325, // 6.57
        PlaceFieldMarkerPreset = 0x0388, // 6.57
        PlaceMarker = 0x0358, // 6.57
        PlayerAddedToBlacklist = 0x017C, // 6.57
        PlayerClassInfo = 0x0071, // 6.57
        PlayerRemovedFromBlacklist = 0x0336, // 6.57
        PlayerSetup = 0x03B3, // 6.57
        PlayerSpawn = 0x02E1, // 6.57
        PlayerStateFlags = 0x01A5, // 6.57
        PlayerStats = 0x03AD, // 6.57
        PlayerTitleList = 0x0067, // 6.57
        PlayerUpdateLook = 0x02B5, // 6.57
        PlayMotionSync = 0x0128, // 6.57
        Playtime = 0x00BF, // 6.57
        PrepareZoning = 0x038F, // 6.57
        QuestActiveList = 0x00CF, // 6.57
        QuestCompleteList = 0x01E6, // 6.57
        QuestFinish = 0x0383, // 6.57
        QuestTracker = 0x01CD, // 6.57
        QuestUpdate = 0x00BC, // 6.57
        ResultDialog = 0x02C9, // 6.57
        RetainerInformation = 0x0276, // 6.57
        RetainerSaleHistory = 0x0344, // 6.57
        RSFData = 0x0364, // 6.57
        RSVData = 0x0272, // 6.57
        ServerNotice = 0x015D, // 6.57
        ServerNoticeShort = 0x0399, // 6.57
        SetOnlineStatus = 0x016E, // 6.57
        SharedEstateSettingsResponse = 0x020D, // 6.57
        SocialList = 0x0339, // 6.57
        SocialMessage = 0x0218, // 6.57
        SocialMessage2 = 0x01F4, // 6.57
        SocialRequestResponse = 0x02D6, // 6.57
        StatusEffectList = 0x00C7, // 6.57
        StatusEffectListBozja = 0x03A8, // 6.57 (StatusEffectList2)
        StatusEffectListDouble = 0x01CB, // 6.57 (BossStatusEffectList)
        StatusEffectListEureka = 0x026A, // 6.57
        StatusEffectListPlayer = 0x02B1, // 6.57 (StatusEffectList3)
        StatusEffectListPlayerDouble = 0x013B, // 6.57
        SubmarineExplorationResult = 0x0355, // 6.57
        SubmarineProgressionStatus = 0x01C7, // 6.57
        SubmarineStatusList = 0x0301, // 6.57
        SubmarineTimers = 0x0356, // 6.57
        SystemLogMessage = 0x0341, // 6.57
        SystemLogMessage16 = 0x03B8, // 6.57
        SystemLogMessage2 = 0x020E, // 6.57
        SystemLogMessage4 = 0x0376, // 6.57
        SystemLogMessage8 = 0x034A, // 6.57
        Transfer = 0x01A7, // 6.57
        TreasureFadeOut = 0x00F3, // 6.57
        UnMount = 0x0147, // 6.57
        UpdateAllianceNormal = 0x01DE, // 6.57
        UpdateAllianceNormalMemberPositions = 0x010C, // 6.57
        UpdateAllianceSmall = 0x00A6, // 6.57
        UpdateAllianceSmallMemberPositions = 0x038C, // 6.57
        UpdateClassInfo = 0x009D, // 6.57
        UpdateClassInfoBozja = 0x0176, // 6.57
        UpdateClassInfoEureka = 0x0222, // 6.57
        UpdateHate = 0x0398, // 6.57
        UpdateHater = 0x024B, // 6.57
        UpdateHpMpTp = 0x0088, // 6.57
        UpdateInventorySlot = 0x03DB, // 6.57
        UpdateParty = 0x0220, // 6.57
        UpdatePartyMemberPositions = 0x02EF, // 6.57
        UpdateRecastTimes = 0x0335, // 6.57
        UpdateSearchInfo = 0x014A, // 6.57
        WeatherChange = 0x010D, // 6.57
        YardObjectSpawn = 0x015B, // 6.57
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        // ActionRequest = 0x02FA, // 6.55
        // ActionRequestGroundTargeted = 0x01D3, // 6.55
        // ChatHandler = 0x0112, // 6.55
        ClientCountdownInitiate = 0x013E, // 6.57
        // ClientTrigger = 0x00BB, // 6.55
        // Heartbeat = 0x0146, // 6.55
        // InventoryModifyHandler = 0x0192, // 6.55 (Base offset: 0x0199)
        // LogoutHandler = 0x0285, // 6.55
        MarketBoardPurchaseHandler = 0x01F4, // 6.57
        SetSearchInfoHandler = 0x0167, // 6.57
        UpdatePositionHandler = 0x031B, // 6.57
        UpdatePositionInstance = 0x0229, // 6.57
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
