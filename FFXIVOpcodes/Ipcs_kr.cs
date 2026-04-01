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
        ActorCast = 0x0152, // 7.45h
        ActorControl = 0x03A1, // 7.45h
        ActorControlSelf = 0x022A, // 7.45h
        ActorControlTarget = 0x018E, // 7.45h
        ActorGauge = 0x01B8, // 7.45h
        ActorMove = 0x0066, // 7.45h
        ActorSetPos = 0x031B, // 7.45h
        AirshipExplorationResult = 0x02F1, // 7.45h
        AirshipStatus = 0x03AA, // 7.45h
        AirshipStatusList = 0x0288, // 7.45h
        AirshipTimers = 0x020F, // 7.45h
        AoeEffect16 = 0x032C, // 7.45h
        AoeEffect24 = 0x016E, // 7.45h
        AoeEffect32 = 0x0175, // 7.45h
        AoeEffect8 = 0x02E3, // 7.45h
        ApplyIDScramble = 0x0104, // 7.45h
        BalloonTalk2 = 0x02C0, // 7.45h
        BalloonTalk4 = 0x0320, // 7.45h
        BalloonTalk8 = 0x0270, // 7.45h
        BattleTalk2 = 0x0203, // 7.45h
        BattleTalk4 = 0x00A5, // 7.45h
        BattleTalk8 = 0x0204, // 7.45h
        BlackList = 0x0321, // 7.45h
        CEDirector = 0x031F, // 7.45h
        CeremonySetActorAppearance = 0x0172, // 7.45h
        CFCancel = 0x02F7, // 7.45h
        CFDutyInfo = 0x01C4, // 7.45h
        CFNotify = 0x021A, // 7.45h
        CFPreferredRole = 0x01A2, // 7.45h
        CFRegistered = 0x02D4, // 7.45h
        CharaNameReq = 0x023E, // 7.45h
        CharaVisualEffect = 0x01AD, // 7.45h
        Chat = 0x0230, // 7.45h
        CompletedAchievements = 0x012D, // 7.45h
        ContainerInfo = 0x0363, // 7.45h
        ContentDirectorSync = 0x0399, // 7.45h
        Countdown = 0x011A, // 7.45h
        CountdownCancel = 0x03A8, // 7.45h
        CreateTreasure = 0x02BF, // 7.45h
        CrossWorldLinkshellList = 0x0366, // 7.45h
        CurrencyCrystalInfo = 0x0139, // 7.45h
        DailyQuestRepeatFlags = 0x0374, // 7.45h
        DailyQuests = 0x0377, // 7.45h
        DeepDungeonChests = 0x0274, // 7.45h
        DeepDungeonItems = 0x00CB, // 7.45h
        DeepDungeonMap = 0x015A, // 7.45h
        DeepDungeonParty = 0x00DC, // 7.45h
        DespawnCharacter = 0x00F5, // 7.45h
        DesynthResult = 0x00FE, // 7.45h
        DirectorVars = 0x017B, // 7.45h
        Discovery = 0x037A, // 7.45h
        Effect = 0x010C, // 7.45h
        EffectResult = 0x0381, // 7.45h
        EffectResult16 = 0x03B1, // 7.45h
        EffectResult4 = 0x0296, // 7.45h
        EffectResult8 = 0x013D, // 7.45h
        EffectResultBasic = 0x00BA, // 7.45h
        EffectResultBasic16 = 0x00A7, // 7.45h
        EffectResultBasic32 = 0x039F, // 7.45h
        EffectResultBasic4 = 0x0382, // 7.45h
        EffectResultBasic64 = 0x0181, // 7.45h
        EffectResultBasic8 = 0x03E5, // 7.45h
        EnvironmentControl = 0x01BF, // 7.45h
        EnvironmentControl12 = 0x0338, // 7.45h
        EnvironmentControl4 = 0x016C, // 7.45h
        EnvironmentControl8 = 0x0188, // 7.45h
        EorzeaTimeOffset = 0x0336, // 7.45h
        EquipDisplayFlags = 0x0357, // 7.45h
        EventContinue = 0x0146, // 7.45h
        EventFinish = 0x017A, // 7.45h
        EventPlay = 0x02EC, // 7.45h
        EventPlay128 = 0x01DF, // 7.45h
        EventPlay16 = 0x02AA, // 7.45h
        EventPlay255 = 0x0132, // 7.45h
        EventPlay32 = 0x025C, // 7.45h
        EventPlay4 = 0x0100, // 7.45h
        EventPlay64 = 0x016B, // 7.45h
        EventPlay8 = 0x0207, // 7.45h
        EventStart = 0x0097, // 7.45h
        Examine = 0x03E4, // 7.45h
        ExamineFreeCompanyInfo = 0x0359, // 7.45h
        ExamineSearchComment = 0x010B, // 7.45h
        ExamineSearchInfo = 0x0153, // 7.45h
        Fall = 0x0226, // 7.45h
        FateInfo = 0x0133, // 7.45h
        FateTrade = 0x02D9, // 7.45h
        FellowshipList = 0x02A9, // 7.45h
        FirstAttack = 0x02AB, // 7.45h
        FreeCompanyDialog = 0x02C8, // 7.45h
        FreeCompanyInfo = 0x0138, // 7.45h
        GCAffiliation = 0x0266, // 7.45h
        HousingEstateGreeting = 0x02EE, // 7.45h
        HousingIndoorInitialize = 0x033E, // 7.45h
        HousingInternalObjectSpawn = 0x01AB, // 7.45h
        HousingLandFlags = 0x0102, // 7.45h
        HousingObjectDye = 0x0106, // 7.45h
        HousingObjectInitialize = 0x024C, // 7.45h
        HousingObjectMove = 0x01E6, // 7.45h
        HousingShowEstateGuestAccess = 0x02C4, // 7.45h
        HousingUpdateLandFlagsSlot = 0x01A9, // 7.45h
        HousingWardInfo = 0x0352, // 7.45h
        HuntingLogEntry = 0x012A, // 7.45h
        Init = 0x00F2, // 7.45h
        InitSearchInfo = 0x01BB, // 7.45h
        InitZone = 0x035F, // 7.45h
        InventoryActionAck = 0x02AD, // 7.45h
        InventoryTransaction = 0x008D, // 7.45h
        InventoryTransactionFinish = 0x0110, // 7.45h
        IslandWorkshopDemandResearch = 0x0254, // 7.45h
        IslandWorkshopFavors = 0x00FA, // 7.45h
        IslandWorkshopGranaryResult = 0x0192, // 7.45h
        IslandWorkshopSupplyDemand = 0x0347, // 7.45h
        ItemInfo = 0x0290, // 7.45h
        ItemMarketBoardInfo = 0x0131, // 7.45h
        ItemMarketBoardSummary = 0x03AC, // 7.45h
        LandAvailability = 0x026D, // 7.45h
        LandInfoSign = 0x01A8, // 7.45h
        LandPriceUpdate = 0x0277, // 7.45h
        LandRename = 0x0361, // 7.45h
        LandSetInitialize = 0x038E, // 7.45h
        LandSetMap = 0x00B6, // 7.45h
        LandUpdate = 0x009B, // 7.45h
        LandUpdateHouseName = 0x01C1, // 7.45h
        LinkshellList = 0x0200, // 7.45h
        LogMessage = 0x00F7, // 7.45h
        Logout = 0x015E, // 7.45h
        LootMessage = 0x0148, // 7.45h
        MailDeleteRequest = 0x016D, // 7.45h
        MailDetail = 0x01D4, // 7.45h
        MailList = 0x00D1, // 7.45h
        MapUpdate = 0x01B5, // 7.45h
        MapUpdate128 = 0x034E, // 7.45h
        MapUpdate16 = 0x0241, // 7.45h
        MapUpdate32 = 0x0219, // 7.45h
        MapUpdate4 = 0x00C7, // 7.45h
        MapUpdate64 = 0x02EF, // 7.45h
        MapUpdate8 = 0x0244, // 7.45h
        MarketBoardItemListing = 0x0353, // 7.45h
        MarketBoardItemListingCount = 0x032D, // 7.45h
        MarketBoardItemListingHistory = 0x01F0, // 7.45h
        MarketBoardPurchase = 0x027B, // 7.45h
        MarketBoardSale = 0x00CC, // 7.45h
        MarketBoardSearchResult = 0x0368, // 7.45h
        MiniCactpotInit = 0x016F, // 7.45h
        ModelEquip = 0x024F, // 7.45h
        Mount = 0x00C4, // 7.45h
        MSQTrackerComplete = 0x01B4, // 7.45h
        NpcSpawn = 0x0335, // 7.45h
        NpcSpawn2 = 0x02BD, // 7.45h
        NpcYell = 0x0198, // 7.45h
        ObjectDespawn = 0x015F, // 7.45h
        ObjectSpawn = 0x00C6, // 7.45h
        OpenTreasure = 0x02A0, // 7.45h
        PartyFinderList = 0x01D8, // 7.45h
        PartyMessage = 0x00ED, // 7.45h
        Ping = 0x032E, // 7.45h
        PlaceFieldMarker = 0x020B, // 7.45h
        PlaceFieldMarkerPreset = 0x009E, // 7.45h
        PlayActionTimelineSync = 0x034B, // 7.45h
        PlayerAddedToBlacklist = 0x0275, // 7.45h
        PlayerBlueMageActions = 0x00B9, // 7.45h
        PlayerClassInfo = 0x03C3, // 7.45h
        PlayerRemovedFromBlacklist = 0x03D6, // 7.45h
        PlayerRetainerInfo = 0x021B, // 7.45h
        PlayerSetup = 0x0273, // 7.45h
        PlayerSpawn = 0x0358, // 7.45h
        PlayerStateFlags = 0x01F8, // 7.45h
        PlayerStats = 0x0161, // 7.45h
        PlayerTitleList = 0x0351, // 7.45h
        PlayerUpdateLook = 0x0276, // 7.45h
        PlayMotionSync = 0x019F, // 7.45h
        Playtime = 0x02B0, // 7.45h
        PrepareZoning = 0x01F3, // 7.45h
        QuestActiveList = 0x0129, // 7.45h
        QuestCompleteList = 0x0156, // 7.45h
        QuestFinish = 0x02A3, // 7.45h
        QuestTracker = 0x01C3, // 7.45h
        QuestUpdate = 0x00B0, // 7.45h
        ResultDialog = 0x0264, // 7.45h
        RetainerInformation = 0x01C6, // 7.45h
        RetainerSaleHistory = 0x030C, // 7.45h
        RetainerState = 0x0262, // 7.45h
        RetainerSummary = 0x032A, // 7.45h
        RSFData = 0x0332, // 7.45h
        RSVData = 0x02B2, // 7.45h
        ServerNotice = 0x0340, // 7.45h
        ServerNoticeShort = 0x03CF, // 7.45h
        ServerRequestCallbackResponse = 0x0249, // 7.45h
        ServerRequestCallbackResponse2 = 0x008E, // 7.45h
        ServerRequestCallbackResponse3 = 0x0256, // 7.45h
        SetOnlineStatus = 0x0137, // 7.45h
        SharedEstateSettingsResponse = 0x027C, // 7.45h
        SocialList = 0x020E, // 7.45h
        SocialMessage = 0x0169, // 7.45h
        SocialMessage2 = 0x03B7, // 7.45h
        SocialRequestResponse = 0x039B, // 7.45h
        StatusEffectList = 0x035B, // 7.45h
        StatusEffectListBozja = 0x0199, // 7.45h
        StatusEffectListDouble = 0x01AC, // 7.45h
        StatusEffectListEureka = 0x0371, // 7.45h
        StatusEffectListOccult = 0x0313, // 7.45h
        StatusEffectListPlayer = 0x01E7, // 7.45h
        StatusEffectListPlayerDouble = 0x0127, // 7.45h
        SubmarineExplorationResult = 0x00E9, // 7.45h
        SubmarineProgressionStatus = 0x0077, // 7.45h
        SubmarineStatusList = 0x023D, // 7.45h
        SubmarineTimers = 0x008B, // 7.45h
        SystemLogMessage = 0x007C, // 7.45h
        SystemLogMessage16 = 0x038B, // 7.45h
        SystemLogMessage2 = 0x0369, // 7.45h
        SystemLogMessage4 = 0x0395, // 7.45h
        SystemLogMessage8 = 0x0218, // 7.45h
        Transfer = 0x02A8, // 7.45h
        TreasureFadeOut = 0x0310, // 7.45h
        UnMount = 0x03D1, // 7.45h
        UpdateAllianceNormal = 0x03BB, // 7.45h
        UpdateAllianceNormalMemberPositions = 0x0154, // 7.45h
        UpdateAllianceSmall = 0x02DE, // 7.45h
        UpdateAllianceSmallMemberPositions = 0x02DD, // 7.45h
        UpdateClassInfo = 0x00CF, // 7.45h
        UpdateClassInfoBozja = 0x0121, // 7.45h
        UpdateClassInfoEureka = 0x013B, // 7.45h
        UpdateClassInfoForay3 = 0x0113, // 7.45h
        UpdateDutyRecastTimes = 0x0116, // 7.45h
        UpdateDutyRecastTimes5 = 0x02C5, // 7.45h
        UpdateHate = 0x0398, // 7.45h
        UpdateHater = 0x0135, // 7.45h
        UpdateHpMpTp = 0x00A8, // 7.45h
        UpdateInventorySlot = 0x0337, // 7.45h
        UpdateParty = 0x02DC, // 7.45h
        UpdatePartyMemberPositions = 0x00F0, // 7.45h
        UpdateRecastTimes = 0x0281, // 7.45h
        UpdateSearchInfo = 0x0091, // 7.45h
        WeatherChange = 0x01D1, // 7.45h
        YardObjectSpawn = 0x013C, // 7.45h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x01EC, // 7.45h
        ActionRequestGroundTargeted = 0x01FF, // 7.45h
        ChatHandler = 0x0221, // 7.45h
        ClientCountdownInitiate = 0x01D4, // 7.45h
        ClientTrigger = 0x022F, // 7.45h
        InventoryModifyHandler = 0x011E, // 7.45h
        LogoutHandler = 0x0105, // 7.45h
        MarketBoardPurchaseHandler = 0x02B2, // 7.45h
        SetSearchInfoHandler = 0x024B, // 7.45h
        UpdatePositionHandler = 0x01FD, // 7.45h
        UpdatePositionInstance = 0x0358, // 7.45h
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
