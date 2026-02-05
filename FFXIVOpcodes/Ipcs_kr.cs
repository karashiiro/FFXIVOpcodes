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
        ActorCast = 0x007C, // 7.4
        ActorControl = 0x027F, // 7.4
        ActorControlSelf = 0x0204, // 7.4
        ActorControlTarget = 0x033A, // 7.4
        ActorGauge = 0x0134, // 7.4
        ActorMove = 0x009A, // 7.4
        ActorSetPos = 0x01D9, // 7.4
        AirshipExplorationResult = 0x0268, // 7.4
        AirshipStatus = 0x02B7, // 7.4
        AirshipStatusList = 0x0205, // 7.4
        AirshipTimers = 0x018F, // 7.4
        AoeEffect16 = 0x03A6, // 7.4
        AoeEffect24 = 0x020F, // 7.4
        AoeEffect32 = 0x019B, // 7.4
        AoeEffect8 = 0x021C, // 7.4
        ApplyIDScramble = 0x00AC, // 7.4
        BalloonTalk2 = 0x00CF, // 7.4
        BalloonTalk4 = 0x03D7, // 7.4
        BalloonTalk8 = 0x00B7, // 7.4
        BattleTalk2 = 0x0200, // 7.4
        BattleTalk4 = 0x01AF, // 7.4
        BattleTalk8 = 0x037D, // 7.4
        BlackList = 0x025F, // 7.4
        CEDirector = 0x01C1, // 7.4
        CeremonySetActorAppearance = 0x00DF, // 7.4
        CFCancel = 0x0151, // 7.4
        CFDutyInfo = 0x02A6, // 7.4
        CFNotify = 0x0373, // 7.4
        CFPreferredRole = 0x0079, // 7.4
        CFRegistered = 0x02C5, // 7.4
        CharaNameReq = 0x0263, // 7.4
        CharaVisualEffect = 0x02B3, // 7.4
        Chat = 0x0082, // 7.4
        CompletedAchievements = 0x00EF, // 7.4
        ContainerInfo = 0x037A, // 7.4
        ContentDirectorSync = 0x02AE, // 7.4
        Countdown = 0x0235, // 7.4
        CountdownCancel = 0x038B, // 7.4
        CreateTreasure = 0x008E, // 7.4
        CrossWorldLinkshellList = 0x03AC, // 7.4
        CurrencyCrystalInfo = 0x00E1, // 7.4
        DailyQuestRepeatFlags = 0x023B, // 7.4
        DailyQuests = 0x022E, // 7.4
        DeepDungeonChests = 0x00C6, // 7.4
        DeepDungeonItems = 0x00AB, // 7.4
        DeepDungeonMap = 0x0208, // 7.4
        DeepDungeonParty = 0x018D, // 7.4
        DespawnCharacter = 0x0329, // 7.4
        DesynthResult = 0x01C7, // 7.4
        DirectorVars = 0x012F, // 7.4
        Discovery = 0x0226, // 7.4
        Effect = 0x0395, // 7.4
        EffectResult = 0x0177, // 7.4
        EffectResult16 = 0x01A6, // 7.4
        EffectResult4 = 0x00AD, // 7.4
        EffectResult8 = 0x03AE, // 7.4
        EffectResultBasic = 0x006A, // 7.4
        EffectResultBasic16 = 0x02A9, // 7.4
        EffectResultBasic32 = 0x0084, // 7.4
        EffectResultBasic4 = 0x01D0, // 7.4
        EffectResultBasic64 = 0x03B8, // 7.4
        EffectResultBasic8 = 0x036E, // 7.4
        EnvironmentControl = 0x02B5, // 7.4
        EnvironmentControl12 = 0x02AB, // 7.4
        EnvironmentControl4 = 0x01AA, // 7.4
        EnvironmentControl8 = 0x0071, // 7.4
        EorzeaTimeOffset = 0x035C, // 7.4
        EquipDisplayFlags = 0x0379, // 7.4
        EventContinue = 0x0102, // 7.4
        EventFinish = 0x00D2, // 7.4
        EventPlay = 0x02D2, // 7.4
        EventPlay128 = 0x0260, // 7.4
        EventPlay16 = 0x02C4, // 7.4
        EventPlay255 = 0x038A, // 7.4
        EventPlay32 = 0x03BA, // 7.4
        EventPlay4 = 0x017A, // 7.4
        EventPlay64 = 0x03CA, // 7.4
        EventPlay8 = 0x0273, // 7.4
        EventStart = 0x0327, // 7.4
        Examine = 0x0169, // 7.4
        ExamineFreeCompanyInfo = 0x0252, // 7.4
        ExamineSearchComment = 0x03E6, // 7.4
        ExamineSearchInfo = 0x02AA, // 7.4
        Fall = 0x00D0, // 7.4
        FateInfo = 0x02F0, // 7.4
        FateTrade = 0x02D9, // 7.4
        FellowshipList = 0x03E5, // 7.4
        FirstAttack = 0x03CF, // 7.4
        FreeCompanyDialog = 0x01E3, // 7.4
        FreeCompanyInfo = 0x0162, // 7.4
        GCAffiliation = 0x03A5, // 7.4
        HousingEstateGreeting = 0x028A, // 7.4
        HousingIndoorInitialize = 0x0391, // 7.4
        HousingInternalObjectSpawn = 0x00D5, // 7.4
        HousingLandFlags = 0x010B, // 7.4
        HousingObjectDye = 0x0249, // 7.4
        HousingObjectInitialize = 0x035E, // 7.4
        HousingObjectMove = 0x035B, // 7.4
        HousingShowEstateGuestAccess = 0x010A, // 7.4
        HousingUpdateLandFlagsSlot = 0x023A, // 7.4
        HousingWardInfo = 0x02EB, // 7.4
        HuntingLogEntry = 0x033E, // 7.4
        Init = 0x01E8, // 7.4
        InitSearchInfo = 0x01E5, // 7.4
        InitZone = 0x01BD, // 7.4
        InventoryActionAck = 0x014B, // 7.4
        InventoryTransaction = 0x00E2, // 7.4
        InventoryTransactionFinish = 0x00D8, // 7.4
        IslandWorkshopDemandResearch = 0x0130, // 7.4
        IslandWorkshopFavors = 0x0360, // 7.4
        IslandWorkshopSupplyDemand = 0x03C4, // 7.4
        ItemInfo = 0x019C, // 7.4
        ItemMarketBoardInfo = 0x02DE, // 7.4
        ItemMarketBoardSummary = 0x0310, // 7.4
        LandAvailability = 0x01D5, // 7.4
        LandInfoSign = 0x039D, // 7.4
        LandPriceUpdate = 0x01DC, // 7.4
        LandRename = 0x0387, // 7.4
        LandSetInitialize = 0x0361, // 7.4
        LandSetMap = 0x02E4, // 7.4
        LandUpdate = 0x00DB, // 7.4
        LandUpdateHouseName = 0x0232, // 7.4
        LinkshellList = 0x01D3, // 7.4
        LogMessage = 0x0202, // 7.4
        Logout = 0x01C9, // 7.4
        LootMessage = 0x029E, // 7.4
        MailDeleteRequest = 0x0108, // 7.4
        MailDetail = 0x02EC, // 7.4
        MailList = 0x038C, // 7.4
        MapUpdate = 0x02C8, // 7.4
        MapUpdate128 = 0x02D6, // 7.4
        MapUpdate16 = 0x01EE, // 7.4
        MapUpdate32 = 0x0312, // 7.4
        MapUpdate4 = 0x0372, // 7.4
        MapUpdate64 = 0x0117, // 7.4
        MapUpdate8 = 0x0219, // 7.4
        MarketBoardItemListing = 0x02CD, // 7.4
        MarketBoardItemListingCount = 0x0269, // 7.4
        MarketBoardItemListingHistory = 0x0164, // 7.4
        MarketBoardPurchase = 0x01A7, // 7.4
        MarketBoardSale = 0x03DC, // 7.4
        MarketBoardSearchResult = 0x0180, // 7.4
        MiniCactpotInit = 0x00BA, // 7.4
        ModelEquip = 0x0115, // 7.4
        Mount = 0x01E1, // 7.4
        MSQTrackerComplete = 0x02B1, // 7.4
        NpcSpawn = 0x0101, // 7.4
        NpcSpawn2 = 0x028F, // 7.4
        NpcYell = 0x01AD, // 7.4
        ObjectDespawn = 0x01B7, // 7.4
        ObjectSpawn = 0x00A1, // 7.4
        OpenTreasure = 0x0247, // 7.4
        PartyMessage = 0x0255, // 7.4
        Ping = 0x0292, // 7.4
        PlaceFieldMarker = 0x036F, // 7.4
        PlaceFieldMarkerPreset = 0x03B6, // 7.4
        PlayActionTimelineSync = 0x038D, // 7.4
        PlayerAddedToBlacklist = 0x00A8, // 7.4
        PlayerBlueMageActions = 0x0239, // 7.4
        PlayerClassInfo = 0x01FD, // 7.4
        PlayerRemovedFromBlacklist = 0x03DA, // 7.4
        PlayerRetainerInfo = 0x03C1, // 7.4
        PlayerSetup = 0x0077, // 7.4
        PlayerSpawn = 0x00B1, // 7.4
        PlayerStateFlags = 0x0356, // 7.4
        PlayerStats = 0x026D, // 7.4
        PlayerTitleList = 0x00C8, // 7.4
        PlayerUpdateLook = 0x02BD, // 7.4
        PlayMotionSync = 0x02E2, // 7.4
        Playtime = 0x01C2, // 7.4
        PrepareZoning = 0x0090, // 7.4
        QuestActiveList = 0x02F1, // 7.4
        QuestCompleteList = 0x00B5, // 7.4
        QuestFinish = 0x0350, // 7.4
        QuestTracker = 0x02C9, // 7.4
        QuestUpdate = 0x0119, // 7.4
        ResultDialog = 0x0161, // 7.4
        RetainerInformation = 0x01D4, // 7.4
        RetainerSaleHistory = 0x0347, // 7.4
        RetainerState = 0x018B, // 7.4
        RetainerSummary = 0x015F, // 7.4
        RSFData = 0x023D, // 7.4
        RSVData = 0x014A, // 7.4
        ServerNotice = 0x0270, // 7.4
        ServerNoticeShort = 0x03CB, // 7.4
        ServerRequestCallbackResponse = 0x02FB, // 7.4
        ServerRequestCallbackResponse2 = 0x0125, // 7.4
        ServerRequestCallbackResponse3 = 0x03D2, // 7.4
        SetOnlineStatus = 0x00EC, // 7.4
        SharedEstateSettingsResponse = 0x0123, // 7.4
        SocialList = 0x018C, // 7.4
        SocialMessage = 0x00F0, // 7.4
        SocialMessage2 = 0x0172, // 7.4
        SocialRequestResponse = 0x016F, // 7.4
        StatusEffectList = 0x0246, // 7.4
        StatusEffectListBozja = 0x0224, // 7.4
        StatusEffectListDouble = 0x03B7, // 7.4
        StatusEffectListEureka = 0x0215, // 7.4
        StatusEffectListForay3 = 0x0188, // 7.4
        StatusEffectListPlayer = 0x0207, // 7.4
        StatusEffectListPlayerDouble = 0x01F8, // 7.4
        SubmarineExplorationResult = 0x024A, // 7.4
        SubmarineProgressionStatus = 0x02C2, // 7.4
        SubmarineStatusList = 0x02BF, // 7.4
        SubmarineTimers = 0x025E, // 7.4
        SystemLogMessage = 0x017B, // 7.4
        SystemLogMessage16 = 0x0103, // 7.4
        SystemLogMessage2 = 0x0193, // 7.4
        SystemLogMessage4 = 0x00D4, // 7.4
        SystemLogMessage8 = 0x0145, // 7.4
        Transfer = 0x01A0, // 7.4
        TreasureFadeOut = 0x0083, // 7.4
        UnMount = 0x0374, // 7.4
        UpdateAllianceNormal = 0x02E5, // 7.4
        UpdateAllianceNormalMemberPositions = 0x01E9, // 7.4
        UpdateAllianceSmall = 0x03D1, // 7.4
        UpdateAllianceSmallMemberPositions = 0x03DE, // 7.4
        UpdateClassInfo = 0x0233, // 7.4
        UpdateClassInfoBozja = 0x00A4, // 7.4
        UpdateClassInfoEureka = 0x00F7, // 7.4
        UpdateClassInfoForay3 = 0x0291, // 7.4
        UpdateDutyRecastTimes = 0x0129, // 7.4
        UpdateDutyRecastTimes5 = 0x0366, // 7.4
        UpdateHate = 0x01A5, // 7.4
        UpdateHater = 0x0179, // 7.4
        UpdateHpMpTp = 0x0135, // 7.4
        UpdateInventorySlot = 0x0070, // 7.4
        UpdateParty = 0x0085, // 7.4
        UpdatePartyMemberPositions = 0x026F, // 7.4
        UpdateRecastTimes = 0x0338, // 7.4
        UpdateSearchInfo = 0x0185, // 7.4
        WeatherChange = 0x03E3, // 7.4
        YardObjectSpawn = 0x0324, // 7.4
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0187, // 7.4
        ActionRequestGroundTargeted = 0x02AF, // 7.4
        ChatHandler = 0x023E, // 7.4
        ClientCountdownInitiate = 0x02EC, // 7.4
        ClientTrigger = 0x03C5, // 7.4
        InventoryModifyHandler = 0x0128, // 7.4
        LogoutHandler = 0x00D6, // 7.4
        MarketBoardPurchaseHandler = 0x014A, // 7.4
        SetSearchInfoHandler = 0x032D, // 7.4
        UpdatePositionHandler = 0x0315, // 7.4
        UpdatePositionInstance = 0x00B1, // 7.4
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
