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
        ActorCast = 0x0151, // 7.45
        ActorControl = 0x0392, // 7.45
        ActorControlSelf = 0x00F7, // 7.45
        ActorControlTarget = 0x02E5, // 7.45
        ActorGauge = 0x03C1, // 7.45
        ActorMove = 0x02E0, // 7.45
        ActorSetPos = 0x019E, // 7.45
        AirshipExplorationResult = 0x011D, // 7.45
        AirshipStatus = 0x025F, // 7.45
        AirshipStatusList = 0x032F, // 7.45
        AirshipTimers = 0x00AD, // 7.45
        AoeEffect16 = 0x0240, // 7.45
        AoeEffect24 = 0x010C, // 7.45
        AoeEffect32 = 0x0202, // 7.45
        AoeEffect8 = 0x03D0, // 7.45
        ApplyIDScramble = 0x01BF, // 7.45
        BalloonTalk2 = 0x03B9, // 7.45
        BalloonTalk4 = 0x00EA, // 7.45
        BalloonTalk8 = 0x0384, // 7.45
        BattleTalk2 = 0x0277, // 7.45
        BattleTalk4 = 0x02A0, // 7.45
        BattleTalk8 = 0x00B5, // 7.45
        BlackList = 0x0322, // 7.45
        CEDirector = 0x01E0, // 7.45
        CeremonySetActorAppearance = 0x0111, // 7.45
        CFCancel = 0x01BB, // 7.45
        CFDutyInfo = 0x0078, // 7.45
        CFNotify = 0x03CC, // 7.45
        CFPreferredRole = 0x0348, // 7.45
        CFRegistered = 0x006D, // 7.45
        CharaNameReq = 0x01E1, // 7.45
        CharaVisualEffect = 0x010D, // 7.45
        Chat = 0x00B3, // 7.45
        CompletedAchievements = 0x03E2, // 7.45
        ContainerInfo = 0x037A, // 7.45
        ContentDirectorSync = 0x020F, // 7.45
        Countdown = 0x03D1, // 7.45
        CountdownCancel = 0x028C, // 7.45
        CreateTreasure = 0x033E, // 7.45
        CrossWorldLinkshellList = 0x029F, // 7.45
        CurrencyCrystalInfo = 0x01A5, // 7.45
        DailyQuestRepeatFlags = 0x01C3, // 7.45
        DailyQuests = 0x0276, // 7.45
        DeepDungeonChests = 0x00BB, // 7.45
        DeepDungeonItems = 0x034E, // 7.45
        DeepDungeonMap = 0x0247, // 7.45
        DeepDungeonParty = 0x023E, // 7.45
        DespawnCharacter = 0x006A, // 7.45
        DesynthResult = 0x033A, // 7.45
        DirectorVars = 0x00DB, // 7.45
        Discovery = 0x0109, // 7.45
        Effect = 0x0203, // 7.45
        EffectResult = 0x012C, // 7.45
        EffectResult16 = 0x0252, // 7.45
        EffectResult4 = 0x0073, // 7.45
        EffectResult8 = 0x020A, // 7.45
        EffectResultBasic = 0x02DE, // 7.45
        EffectResultBasic16 = 0x0399, // 7.45
        EffectResultBasic32 = 0x011B, // 7.45
        EffectResultBasic4 = 0x022A, // 7.45
        EffectResultBasic64 = 0x00BF, // 7.45
        EffectResultBasic8 = 0x01FC, // 7.45
        EnvironmentControl = 0x0145, // 7.45
        EnvironmentControl12 = 0x0140, // 7.45
        EnvironmentControl4 = 0x0102, // 7.45
        EnvironmentControl8 = 0x0269, // 7.45
        EorzeaTimeOffset = 0x0142, // 7.45
        EquipDisplayFlags = 0x0068, // 7.45
        EventContinue = 0x01B5, // 7.45
        EventFinish = 0x03DE, // 7.45
        EventPlay = 0x01A7, // 7.45
        EventPlay128 = 0x03D4, // 7.45
        EventPlay16 = 0x029E, // 7.45
        EventPlay255 = 0x0152, // 7.45
        EventPlay32 = 0x036E, // 7.45
        EventPlay4 = 0x0323, // 7.45
        EventPlay64 = 0x0349, // 7.45
        EventPlay8 = 0x00D8, // 7.45
        EventStart = 0x02ED, // 7.45
        Examine = 0x01D8, // 7.45
        ExamineFreeCompanyInfo = 0x0165, // 7.45
        ExamineSearchComment = 0x0178, // 7.45
        ExamineSearchInfo = 0x03A9, // 7.45
        Fall = 0x02AF, // 7.45
        FateInfo = 0x0364, // 7.45
        FateTrade = 0x025A, // 7.45
        FellowshipList = 0x01D4, // 7.45
        FirstAttack = 0x021B, // 7.45
        FreeCompanyDialog = 0x02AD, // 7.45
        FreeCompanyInfo = 0x02BE, // 7.45
        GCAffiliation = 0x038A, // 7.45
        HousingEstateGreeting = 0x00ED, // 7.45
        HousingIndoorInitialize = 0x0326, // 7.45
        HousingInternalObjectSpawn = 0x01D6, // 7.45
        HousingLandFlags = 0x036D, // 7.45
        HousingObjectDye = 0x01BD, // 7.45
        HousingObjectInitialize = 0x02F9, // 7.45
        HousingObjectMove = 0x0273, // 7.45
        HousingShowEstateGuestAccess = 0x01C4, // 7.45
        HousingUpdateLandFlagsSlot = 0x0239, // 7.45
        HousingWardInfo = 0x02A1, // 7.45
        HuntingLogEntry = 0x0074, // 7.45
        Init = 0x01D9, // 7.45
        InitSearchInfo = 0x02D1, // 7.45
        InitZone = 0x00D0, // 7.45
        InventoryActionAck = 0x0163, // 7.45
        InventoryTransaction = 0x0133, // 7.45
        InventoryTransactionFinish = 0x0177, // 7.45
        IslandWorkshopDemandResearch = 0x02EA, // 7.45
        IslandWorkshopFavors = 0x01D2, // 7.45
        IslandWorkshopGranaryResult = 0x03DC, // 7.45
        IslandWorkshopSupplyDemand = 0x03C3, // 7.45
        ItemInfo = 0x009E, // 7.45
        ItemMarketBoardInfo = 0x02C7, // 7.45
        ItemMarketBoardSummary = 0x0286, // 7.45
        LandAvailability = 0x0092, // 7.45
        LandInfoSign = 0x03AC, // 7.45
        LandPriceUpdate = 0x00FC, // 7.45
        LandRename = 0x01FE, // 7.45
        LandSetInitialize = 0x00FB, // 7.45
        LandSetMap = 0x0174, // 7.45
        LandUpdate = 0x02AE, // 7.45
        LandUpdateHouseName = 0x0340, // 7.45
        LinkshellList = 0x02B5, // 7.45
        LogMessage = 0x018D, // 7.45
        Logout = 0x01B7, // 7.45
        LootMessage = 0x00A9, // 7.45
        MailDeleteRequest = 0x02DA, // 7.45
        MailDetail = 0x019C, // 7.45
        MailList = 0x0324, // 7.45
        MapUpdate = 0x01B1, // 7.45
        MapUpdate128 = 0x0346, // 7.45
        MapUpdate16 = 0x019F, // 7.45
        MapUpdate32 = 0x0310, // 7.45
        MapUpdate4 = 0x018C, // 7.45
        MapUpdate64 = 0x0127, // 7.45
        MapUpdate8 = 0x022E, // 7.45
        MarketBoardItemListing = 0x0293, // 7.45
        MarketBoardItemListingCount = 0x01BE, // 7.45
        MarketBoardItemListingHistory = 0x03E6, // 7.45
        MarketBoardPurchase = 0x01DF, // 7.45
        MarketBoardSale = 0x02B3, // 7.45
        MarketBoardSearchResult = 0x0121, // 7.45
        MiniCactpotInit = 0x039A, // 7.45
        ModelEquip = 0x0305, // 7.45
        Mount = 0x0169, // 7.45
        MSQTrackerComplete = 0x00E8, // 7.45
        NpcSpawn = 0x01B0, // 7.45
        NpcSpawn2 = 0x0320, // 7.45
        NpcYell = 0x00E4, // 7.45
        ObjectDespawn = 0x02DF, // 7.45
        ObjectSpawn = 0x02E8, // 7.45
        OpenTreasure = 0x00B6, // 7.45
        PartyMessage = 0x013C, // 7.45
        Ping = 0x0144, // 7.45
        PlaceFieldMarker = 0x0303, // 7.45
        PlaceFieldMarkerPreset = 0x00CB, // 7.45
        PlayActionTimelineSync = 0x03DF, // 7.45
        PlayerAddedToBlacklist = 0x0137, // 7.45
        PlayerBlueMageActions = 0x01F1, // 7.45
        PlayerClassInfo = 0x0262, // 7.45
        PlayerRemovedFromBlacklist = 0x0183, // 7.45
        PlayerRetainerInfo = 0x0184, // 7.45
        PlayerSetup = 0x023C, // 7.45
        PlayerSpawn = 0x033D, // 7.45
        PlayerStateFlags = 0x0301, // 7.45
        PlayerStats = 0x0263, // 7.45
        PlayerTitleList = 0x0241, // 7.45
        PlayerUpdateLook = 0x00E6, // 7.45
        PlayMotionSync = 0x03AF, // 7.45
        Playtime = 0x0075, // 7.45
        PrepareZoning = 0x0161, // 7.45
        QuestActiveList = 0x011F, // 7.45
        QuestCompleteList = 0x019A, // 7.45
        QuestFinish = 0x0386, // 7.45
        QuestTracker = 0x00E7, // 7.45
        QuestUpdate = 0x0070, // 7.45
        ResultDialog = 0x0242, // 7.45
        RetainerInformation = 0x01E6, // 7.45
        RetainerSaleHistory = 0x02E9, // 7.45
        RetainerState = 0x0314, // 7.45
        RetainerSummary = 0x00BD, // 7.45
        RSFData = 0x01FB, // 7.45
        RSVData = 0x026B, // 7.45
        ServerNotice = 0x00A7, // 7.45
        ServerNoticeShort = 0x031E, // 7.45
        ServerRequestCallbackResponse = 0x0284, // 7.45
        ServerRequestCallbackResponse2 = 0x01A9, // 7.45
        ServerRequestCallbackResponse3 = 0x00E2, // 7.45
        SetOnlineStatus = 0x0300, // 7.45
        SharedEstateSettingsResponse = 0x01F9, // 7.45
        SocialList = 0x00D3, // 7.45
        SocialMessage = 0x02B1, // 7.45
        SocialMessage2 = 0x0257, // 7.45
        SocialRequestResponse = 0x00C3, // 7.45
        StatusEffectList = 0x024B, // 7.45
        StatusEffectListBozja = 0x0261, // 7.45
        StatusEffectListDouble = 0x02A6, // 7.45
        StatusEffectListEureka = 0x02E6, // 7.45
        StatusEffectListOccult = 0x030C, // 7.45
        StatusEffectListPlayer = 0x016B, // 7.45
        StatusEffectListPlayerDouble = 0x0253, // 7.45
        SubmarineExplorationResult = 0x0150, // 7.45
        SubmarineProgressionStatus = 0x0296, // 7.45
        SubmarineStatusList = 0x01ED, // 7.45
        SubmarineTimers = 0x00A2, // 7.45
        SystemLogMessage = 0x0088, // 7.45
        SystemLogMessage16 = 0x00E0, // 7.45
        SystemLogMessage2 = 0x03D7, // 7.45
        SystemLogMessage4 = 0x038C, // 7.45
        SystemLogMessage8 = 0x0385, // 7.45
        Transfer = 0x0382, // 7.45
        TreasureFadeOut = 0x039E, // 7.45
        UnMount = 0x0342, // 7.45
        UpdateAllianceNormal = 0x01AD, // 7.45
        UpdateAllianceNormalMemberPositions = 0x00F0, // 7.45
        UpdateAllianceSmall = 0x0138, // 7.45
        UpdateAllianceSmallMemberPositions = 0x01D5, // 7.45
        UpdateClassInfo = 0x02E4, // 7.45
        UpdateClassInfoBozja = 0x0194, // 7.45
        UpdateClassInfoEureka = 0x0173, // 7.45
        UpdateClassInfoForay3 = 0x02AA, // 7.45
        UpdateDutyRecastTimes = 0x0093, // 7.45
        UpdateDutyRecastTimes5 = 0x00F1, // 7.45
        UpdateHate = 0x03B8, // 7.45
        UpdateHater = 0x03C7, // 7.45
        UpdateHpMpTp = 0x02C0, // 7.45
        UpdateInventorySlot = 0x0309, // 7.45
        UpdateParty = 0x01F8, // 7.45
        UpdatePartyMemberPositions = 0x013E, // 7.45
        UpdateRecastTimes = 0x028A, // 7.45
        UpdateSearchInfo = 0x0357, // 7.45
        WeatherChange = 0x00A0, // 7.45
        YardObjectSpawn = 0x028E, // 7.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0383, // 7.45
        ActionRequestGroundTargeted = 0x00E9, // 7.45
        ChatHandler = 0x01E8, // 7.45
        ClientCountdownInitiate = 0x019C, // 7.45
        ClientTrigger = 0x00E3, // 7.45
        InventoryModifyHandler = 0x009D, // 7.45
        LogoutHandler = 0x006B, // 7.45
        MarketBoardPurchaseHandler = 0x026B, // 7.45
        SetSearchInfoHandler = 0x039B, // 7.45
        UpdatePositionHandler = 0x032D, // 7.45
        UpdatePositionInstance = 0x033D, // 7.45
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
