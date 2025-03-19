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
        ActorCast = 0x0280, // 7.1
        ActorControl = 0x01AA, // 7.1
        ActorControlSelf = 0x0103, // 7.1
        ActorControlTarget = 0x012B, // 7.1
        ActorGauge = 0x02DC, // 7.1
        ActorMove = 0x008A, // 7.1
        ActorSetPos = 0x02BF, // 7.1
        AirshipExplorationResult = 0x028D, // 7.1
        AirshipStatus = 0x0295, // 7.1
        AirshipStatusList = 0x00A9, // 7.1
        AirshipTimers = 0x0089, // 7.1
        AoeEffect16 = 0x0207, // 7.1
        AoeEffect24 = 0x0110, // 7.1
        AoeEffect32 = 0x0186, // 7.1
        AoeEffect8 = 0x014A, // 7.1
        ApplyIDScramble = 0x03BD, // 7.1
        BalloonTalk2 = 0x030A, // 7.1
        BalloonTalk4 = 0x03CA, // 7.1
        BalloonTalk8 = 0x019E, // 7.1
        BattleTalk2 = 0x03D0, // 7.1
        BattleTalk4 = 0x00E0, // 7.1
        BattleTalk8 = 0x0267, // 7.1
        BlackList = 0x027B, // 7.1
        CEDirector = 0x00AD, // 7.1
        CeremonySetActorAppearance = 0x0126, // 7.1
        CFCancel = 0x0272, // 7.1
        CFDutyInfo = 0x0344, // 7.1
        CFNotify = 0x03C3, // 7.1
        CFPreferredRole = 0x0220, // 7.1
        CFRegistered = 0x036D, // 7.1
        CharaNameReq = 0x00A1, // 7.1
        CharaVisualEffect = 0x0232, // 7.1
        Chat = 0x01E9, // 7.1
        CompletedAchievements = 0x037B, // 7.1
        ContainerInfo = 0x020D, // 7.1
        ContentDirectorSync = 0x0263, // 7.1
        Countdown = 0x02F1, // 7.1
        CountdownCancel = 0x016E, // 7.1
        CreateTreasure = 0x02CC, // 7.1
        CrossWorldLinkshellList = 0x03A5, // 7.1
        CurrencyCrystalInfo = 0x021D, // 7.1
        DailyQuestRepeatFlags = 0x0125, // 7.1
        DailyQuests = 0x03A9, // 7.1
        DespawnCharacter = 0x0290, // 7.1
        DesynthResult = 0x026F, // 7.1
        DirectorVars = 0x0385, // 7.1
        Discovery = 0x00E6, // 7.1
        Effect = 0x0277, // 7.1
        EffectResult = 0x038A, // 7.1
        EffectResult16 = 0x02BA, // 7.1
        EffectResult4 = 0x00DB, // 7.1
        EffectResult8 = 0x033C, // 7.1
        EffectResultBasic = 0x0323, // 7.1
        EffectResultBasic16 = 0x030F, // 7.1
        EffectResultBasic32 = 0x01ED, // 7.1
        EffectResultBasic4 = 0x01D0, // 7.1
        EffectResultBasic64 = 0x0294, // 7.1
        EffectResultBasic8 = 0x024D, // 7.1
        EnvironmentControl = 0x00C7, // 7.1
        EorzeaTimeOffset = 0x0216, // 7.1
        EquipDisplayFlags = 0x0201, // 7.1
        EventContinue = 0x00F1, // 7.1
        EventFinish = 0x010E, // 7.1
        EventPlay = 0x0234, // 7.1
        EventPlay128 = 0x00F6, // 7.1
        EventPlay16 = 0x0188, // 7.1
        EventPlay255 = 0x0352, // 7.1
        EventPlay32 = 0x01E3, // 7.1
        EventPlay4 = 0x02C3, // 7.1
        EventPlay64 = 0x01D7, // 7.1
        EventPlay8 = 0x015A, // 7.1
        EventStart = 0x019F, // 7.1
        Examine = 0x0166, // 7.1
        ExamineFreeCompanyInfo = 0x032F, // 7.1
        ExamineSearchComment = 0x01AD, // 7.1
        ExamineSearchInfo = 0x007D, // 7.1
        Fall = 0x0076, // 7.1
        FateInfo = 0x038F, // 7.1
        FellowshipList = 0x00F5, // 7.1
        FirstAttack = 0x0164, // 7.1
        FreeCompanyDialog = 0x00D3, // 7.1
        FreeCompanyInfo = 0x0079, // 7.1
        GCAffiliation = 0x0174, // 7.1
        HousingEstateGreeting = 0x0245, // 7.1
        HousingIndoorInitialize = 0x0127, // 7.1
        HousingInternalObjectSpawn = 0x02ED, // 7.1
        HousingLandFlags = 0x0388, // 7.1
        HousingObjectDye = 0x0306, // 7.1
        HousingObjectInitialize = 0x033E, // 7.1
        HousingObjectMove = 0x01E8, // 7.1
        HousingShowEstateGuestAccess = 0x01FA, // 7.1
        HousingUpdateLandFlagsSlot = 0x0147, // 7.1
        HousingWardInfo = 0x02E0, // 7.1
        HuntingLogEntry = 0x02D9, // 7.1
        Init = 0x0265, // 7.1
        InitSearchInfo = 0x0182, // 7.1
        InitZone = 0x017B, // 7.1
        InventoryActionAck = 0x0327, // 7.1
        InventoryTransaction = 0x01E5, // 7.1
        InventoryTransactionFinish = 0x03A2, // 7.1
        IslandWorkshopDemandResearch = 0x03AE, // 7.1
        IslandWorkshopFavors = 0x02C4, // 7.1
        IslandWorkshopSupplyDemand = 0x01CB, // 7.1
        ItemInfo = 0x0097, // 7.1
        ItemMarketBoardInfo = 0x0149, // 7.1
        ItemMarketBoardSummary = 0x02F6, // 7.1
        LandAvailability = 0x00FE, // 7.1
        LandInfoSign = 0x026E, // 7.1
        LandPriceUpdate = 0x0109, // 7.1
        LandRename = 0x039A, // 7.1
        LandSetInitialize = 0x01C1, // 7.1
        LandSetMap = 0x0260, // 7.1
        LandUpdate = 0x03B6, // 7.1
        LandUpdateHouseName = 0x00EC, // 7.1
        LinkshellList = 0x0357, // 7.1
        LogMessage = 0x02AB, // 7.1
        Logout = 0x006C, // 7.1
        LootMessage = 0x01CF, // 7.1
        MailDeleteRequest = 0x01EB, // 7.1
        MailDetail = 0x030E, // 7.1
        MailList = 0x0214, // 7.1
        MapUpdate = 0x0241, // 7.1
        MapUpdate128 = 0x02A0, // 7.1
        MapUpdate16 = 0x01B1, // 7.1
        MapUpdate32 = 0x020B, // 7.1
        MapUpdate4 = 0x0253, // 7.1
        MapUpdate64 = 0x0138, // 7.1
        MapUpdate8 = 0x0329, // 7.1
        MarketBoardItemListing = 0x03DB, // 7.1
        MarketBoardItemListingCount = 0x0184, // 7.1
        MarketBoardItemListingHistory = 0x0254, // 7.1
        MarketBoardPurchase = 0x0238, // 7.1
        MarketBoardSale = 0x025D, // 7.1
        MarketBoardSearchResult = 0x0178, // 7.1
        MiniCactpotInit = 0x0317, // 7.1
        ModelEquip = 0x00CC, // 7.1
        Mount = 0x031F, // 7.1
        MSQTrackerComplete = 0x00DF, // 7.1
        NpcSpawn = 0x01D2, // 7.1
        NpcSpawn2 = 0x0249, // 7.1
        NpcYell = 0x0112, // 7.1
        ObjectDespawn = 0x0381, // 7.1
        ObjectSpawn = 0x0132, // 7.1
        OpenTreasure = 0x03D4, // 7.1
        PartyMessage = 0x00F8, // 7.1
        Ping = 0x028A, // 7.1
        PlaceFieldMarker = 0x0274, // 7.1
        PlaceFieldMarkerPreset = 0x02E8, // 7.1
        PlaceMarker = 0x0262, // 7.1
        PlayerAddedToBlacklist = 0x00A7, // 7.1
        PlayerBlueMageActions = 0x0218, // 7.1
        PlayerClassInfo = 0x03B7, // 7.1
        PlayerRemovedFromBlacklist = 0x032E, // 7.1
        PlayerRetainerInfo = 0x0135, // 7.1
        PlayerSetup = 0x03D2, // 7.1
        PlayerSpawn = 0x02A4, // 7.1
        PlayerStateFlags = 0x029D, // 7.1
        PlayerStats = 0x0228, // 7.1
        PlayerTitleList = 0x007C, // 7.1
        PlayerUpdateLook = 0x0368, // 7.1
        PlayMotionSync = 0x01BB, // 7.1
        Playtime = 0x010A, // 7.1
        PrepareZoning = 0x015E, // 7.1
        QuestActiveList = 0x0393, // 7.1
        QuestCompleteList = 0x01B5, // 7.1
        QuestFinish = 0x0137, // 7.1
        QuestTracker = 0x026C, // 7.1
        QuestUpdate = 0x0331, // 7.1
        ResultDialog = 0x029F, // 7.1
        RetainerInformation = 0x00F0, // 7.1
        RetainerSaleHistory = 0x0070, // 7.1
        RetainerState = 0x0335, // 7.1
        RetainerSummary = 0x026B, // 7.1
        RSFData = 0x0185, // 7.1
        RSVData = 0x034C, // 7.1
        ServerNotice = 0x0383, // 7.1
        ServerNoticeShort = 0x0131, // 7.1
        ServerRequestCallbackResponse1 = 0x01BD, // 7.1
        ServerRequestCallbackResponse2 = 0x00DD, // 7.1
        ServerRequestCallbackResponse3 = 0x00E4, // 7.1
        SetOnlineStatus = 0x035E, // 7.1
        SharedEstateSettingsResponse = 0x0310, // 7.1
        SocialList = 0x01C2, // 7.1
        SocialMessage = 0x0266, // 7.1
        SocialMessage2 = 0x02D2, // 7.1
        SocialRequestResponse = 0x00C0, // 7.1
        StatusEffectList = 0x0194, // 7.1
        StatusEffectListBozja = 0x01F7, // 7.1
        StatusEffectListDouble = 0x0154, // 7.1
        StatusEffectListEureka = 0x025F, // 7.1
        StatusEffectListForay3 = 0x02B8, // 7.1
        StatusEffectListPlayer = 0x0326, // 7.1
        StatusEffectListPlayerDouble = 0x0379, // 7.1
        SubmarineExplorationResult = 0x021C, // 7.1
        SubmarineProgressionStatus = 0x01E0, // 7.1
        SubmarineStatusList = 0x0318, // 7.1
        SubmarineTimers = 0x0229, // 7.1
        SystemLogMessage = 0x0180, // 7.1
        SystemLogMessage16 = 0x0339, // 7.1
        SystemLogMessage2 = 0x0167, // 7.1
        SystemLogMessage4 = 0x00A3, // 7.1
        SystemLogMessage8 = 0x01BC, // 7.1
        Transfer = 0x0347, // 7.1
        TreasureFadeOut = 0x01D4, // 7.1
        UnMount = 0x011A, // 7.1
        UpdateAllianceNormal = 0x00E3, // 7.1
        UpdateAllianceNormalMemberPositions = 0x0341, // 7.1
        UpdateAllianceSmall = 0x035A, // 7.1
        UpdateAllianceSmallMemberPositions = 0x0373, // 7.1
        UpdateClassInfo = 0x02E9, // 7.1
        UpdateClassInfoBozja = 0x012D, // 7.1
        UpdateClassInfoEureka = 0x0243, // 7.1
        UpdateClassInfoForay3 = 0x0307, // 7.1
        UpdateDutyRecastTimes = 0x036C, // 7.1
        UpdateDutyRecastTimes5 = 0x0356, // 7.1
        UpdateHate = 0x0313, // 7.1
        UpdateHater = 0x03E5, // 7.1
        UpdateHpMpTp = 0x011F, // 7.1
        UpdateInventorySlot = 0x019D, // 7.1
        UpdateParty = 0x00B7, // 7.1
        UpdatePartyMemberPositions = 0x019A, // 7.1
        UpdateRecastTimes = 0x0377, // 7.1
        UpdateSearchInfo = 0x0256, // 7.1
        WeatherChange = 0x00F9, // 7.1
        YardObjectSpawn = 0x0198, // 7.1
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x035B, // 7.1
        ActionRequestGroundTargeted = 0x0399, // 7.1
        ChatHandler = 0x02D0, // 7.1
        ClientCountdownInitiate = 0x01EB, // 7.1
        ClientTrigger = 0x012C, // 7.1
        InventoryModifyHandler = 0x0237, // 7.1
        LogoutHandler = 0x0272, // 7.1
        MarketBoardPurchaseHandler = 0x02CB, // 7.1
        SetSearchInfoHandler = 0x0139, // 7.1
        UpdatePositionHandler = 0x0264, // 7.1
        UpdatePositionInstance = 0x01B8, // 7.1
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
