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
        ActorCast = 0x02F0, // 7.15
        ActorControl = 0x0153, // 7.15
        ActorControlSelf = 0x0087, // 7.15
        ActorControlTarget = 0x01F6, // 7.15
        ActorGauge = 0x0251, // 7.15
        ActorMove = 0x0265, // 7.15
        ActorSetPos = 0x03DD, // 7.15
        AirshipExplorationResult = 0x0379, // 7.15
        AirshipStatus = 0x021E, // 7.15
        AirshipStatusList = 0x02E9, // 7.15
        AirshipTimers = 0x00E9, // 7.15
        AoeEffect16 = 0x01B3, // 7.15
        AoeEffect24 = 0x0320, // 7.15
        AoeEffect32 = 0x0236, // 7.15
        AoeEffect8 = 0x0091, // 7.15
        ApplyIDScramble = 0x0222, // 7.15
        BalloonTalk2 = 0x007D, // 7.15
        BalloonTalk4 = 0x024B, // 7.15
        BalloonTalk8 = 0x00A8, // 7.15
        BattleTalk2 = 0x0138, // 7.15
        BattleTalk4 = 0x0242, // 7.15
        BattleTalk8 = 0x01C5, // 7.15
        BlackList = 0x02A7, // 7.15
        CEDirector = 0x037D, // 7.15
        CeremonySetActorAppearance = 0x01CB, // 7.15
        CFCancel = 0x0338, // 7.15
        CFDutyInfo = 0x0235, // 7.15
        CFNotify = 0x0328, // 7.15
        CFPreferredRole = 0x01A9, // 7.15
        CFRegistered = 0x020A, // 7.15
        CharaNameReq = 0x025F, // 7.15
        CharaVisualEffect = 0x02AA, // 7.15
        Chat = 0x00FF, // 7.15
        CompletedAchievements = 0x0104, // 7.15
        ContainerInfo = 0x03B7, // 7.15
        ContentDirectorSync = 0x0373, // 7.15
        Countdown = 0x007A, // 7.15
        CountdownCancel = 0x009D, // 7.15
        CreateTreasure = 0x028F, // 7.15
        CrossWorldLinkshellList = 0x034D, // 7.15
        CurrencyCrystalInfo = 0x00B2, // 7.15
        DailyQuestRepeatFlags = 0x0241, // 7.15
        DailyQuests = 0x02FB, // 7.15
        DespawnCharacter = 0x0196, // 7.15
        DesynthResult = 0x0364, // 7.15
        DirectorVars = 0x0386, // 7.15
        Discovery = 0x02AD, // 7.15
        Effect = 0x0376, // 7.15
        EffectResult = 0x00E5, // 7.15
        EffectResult16 = 0x0176, // 7.15
        EffectResult4 = 0x038F, // 7.15
        EffectResult8 = 0x0162, // 7.15
        EffectResultBasic = 0x0279, // 7.15
        EffectResultBasic16 = 0x0317, // 7.15
        EffectResultBasic32 = 0x0088, // 7.15
        EffectResultBasic4 = 0x01C4, // 7.15
        EffectResultBasic64 = 0x02B7, // 7.15
        EffectResultBasic8 = 0x00F6, // 7.15
        EnvironmentControl = 0x0365, // 7.15
        EorzeaTimeOffset = 0x00BF, // 7.15
        EquipDisplayFlags = 0x01CA, // 7.15
        EventContinue = 0x00D3, // 7.15
        EventFinish = 0x00FD, // 7.15
        EventPlay = 0x02E4, // 7.15
        EventPlay128 = 0x008F, // 7.15
        EventPlay16 = 0x0262, // 7.15
        EventPlay255 = 0x0168, // 7.15
        EventPlay32 = 0x030C, // 7.15
        EventPlay4 = 0x0145, // 7.15
        EventPlay64 = 0x016F, // 7.15
        EventPlay8 = 0x00E7, // 7.15
        EventStart = 0x01E6, // 7.15
        Examine = 0x0152, // 7.15
        ExamineFreeCompanyInfo = 0x00EC, // 7.15
        ExamineSearchComment = 0x026E, // 7.15
        ExamineSearchInfo = 0x0093, // 7.15
        Fall = 0x0068, // 7.15
        FashionReport = 0x0151, // 7.15
        FateInfo = 0x0210, // 7.15
        FellowshipList = 0x03C5, // 7.15
        FirstAttack = 0x02C4, // 7.15
        FreeCompanyDialog = 0x02EC, // 7.15
        FreeCompanyInfo = 0x02AC, // 7.15
        GCAffiliation = 0x025C, // 7.15
        HousingEstateGreeting = 0x0139, // 7.15
        HousingIndoorInitialize = 0x03D4, // 7.15
        HousingInternalObjectSpawn = 0x0191, // 7.15
        HousingLandFlags = 0x02B2, // 7.15
        HousingObjectDye = 0x0090, // 7.15
        HousingObjectInitialize = 0x02E5, // 7.15
        HousingObjectMove = 0x03CB, // 7.15
        HousingShowEstateGuestAccess = 0x0396, // 7.15
        HousingUpdateLandFlagsSlot = 0x03C3, // 7.15
        HousingWardInfo = 0x0298, // 7.15
        HuntingLogEntry = 0x0125, // 7.15
        Init = 0x0255, // 7.15
        InitSearchInfo = 0x036C, // 7.15
        InitZone = 0x033F, // 7.15
        InventoryActionAck = 0x03A3, // 7.15
        InventoryTransaction = 0x0187, // 7.15
        InventoryTransactionFinish = 0x011D, // 7.15
        IslandWorkshopDemandResearch = 0x03B6, // 7.15
        IslandWorkshopFavors = 0x00BB, // 7.15
        IslandWorkshopSupplyDemand = 0x028B, // 7.15
        ItemInfo = 0x025D, // 7.15
        ItemMarketBoardInfo = 0x01FE, // 7.15
        ItemMarketBoardSummary = 0x02F2, // 7.15
        LandAvailability = 0x019A, // 7.15
        LandInfoSign = 0x02EB, // 7.15
        LandPriceUpdate = 0x01FF, // 7.15
        LandRename = 0x010A, // 7.15
        LandSetInitialize = 0x0391, // 7.15
        LandSetMap = 0x0319, // 7.15
        LandUpdate = 0x01D5, // 7.15
        LandUpdateHouseName = 0x0393, // 7.15
        LinkshellList = 0x008B, // 7.15
        LogMessage = 0x03E1, // 7.15
        Logout = 0x031B, // 7.15
        LootMessage = 0x02FA, // 7.15
        MailDeleteRequest = 0x03AD, // 7.15
        MailDetail = 0x022D, // 7.15
        MailList = 0x0264, // 7.15
        MapUpdate = 0x0195, // 7.15
        MapUpdate128 = 0x02A9, // 7.15
        MapUpdate16 = 0x0372, // 7.15
        MapUpdate32 = 0x0107, // 7.15
        MapUpdate4 = 0x00AD, // 7.15
        MapUpdate64 = 0x0294, // 7.15
        MapUpdate8 = 0x023E, // 7.15
        MarketBoardItemListing = 0x01E3, // 7.15
        MarketBoardItemListingCount = 0x0128, // 7.15
        MarketBoardItemListingHistory = 0x02B0, // 7.15
        MarketBoardPurchase = 0x00AE, // 7.15
        MarketBoardSale = 0x023F, // 7.15
        MarketBoardSearchResult = 0x0209, // 7.15
        MiniCactpotInit = 0x034C, // 7.15
        ModelEquip = 0x03C6, // 7.15
        Mount = 0x03BD, // 7.15
        MSQTrackerComplete = 0x0184, // 7.15
        NpcSpawn = 0x0189, // 7.15
        NpcSpawn2 = 0x01D3, // 7.15
        NpcYell = 0x03AA, // 7.15
        ObjectDespawn = 0x0094, // 7.15
        ObjectSpawn = 0x037C, // 7.15
        OpenTreasure = 0x027A, // 7.15
        PartyMessage = 0x00F4, // 7.15
        Ping = 0x01E4, // 7.15
        PlaceFieldMarker = 0x0288, // 7.15
        PlaceFieldMarkerPreset = 0x03D8, // 7.15
        PlaceMarker = 0x03CC, // 7.15
        PlayerAddedToBlacklist = 0x03D7, // 7.15
        PlayerBlueMageActions = 0x01A2, // 7.15
        PlayerClassInfo = 0x00CC, // 7.15
        PlayerRemovedFromBlacklist = 0x0179, // 7.15
        PlayerRetainerInfo = 0x026F, // 7.15
        PlayerSetup = 0x028E, // 7.15
        PlayerSpawn = 0x02BF, // 7.15
        PlayerStateFlags = 0x0397, // 7.15
        PlayerStats = 0x029E, // 7.15
        PlayerTitleList = 0x01BE, // 7.15
        PlayerUpdateLook = 0x0378, // 7.15
        PlayMotionSync = 0x0357, // 7.15
        Playtime = 0x00CB, // 7.15
        PrepareZoning = 0x0105, // 7.15
        QuestActiveList = 0x0348, // 7.15
        QuestCompleteList = 0x02CD, // 7.15
        QuestFinish = 0x0257, // 7.15
        QuestTracker = 0x03A2, // 7.15
        QuestUpdate = 0x01DD, // 7.15
        ResultDialog = 0x029A, // 7.15
        RetainerInformation = 0x02C0, // 7.15
        RetainerSaleHistory = 0x018F, // 7.15
        RetainerState = 0x035A, // 7.15
        RetainerSummary = 0x01D4, // 7.15
        RSFData = 0x01F7, // 7.15
        RSVData = 0x0219, // 7.15
        ServerNotice = 0x015C, // 7.15
        ServerNoticeShort = 0x01AF, // 7.15
        ServerRequestCallbackResponse1 = 0x0350, // 7.15
        ServerRequestCallbackResponse2 = 0x0313, // 7.15
        ServerRequestCallbackResponse3 = 0x0327, // 7.15
        SetOnlineStatus = 0x02A0, // 7.15
        SharedEstateSettingsResponse = 0x03A1, // 7.15
        SocialList = 0x037F, // 7.15
        SocialMessage = 0x010E, // 7.15
        SocialMessage2 = 0x030B, // 7.15
        SocialRequestResponse = 0x00F0, // 7.15
        StatusEffectList = 0x013D, // 7.15
        StatusEffectListBozja = 0x02C5, // 7.15
        StatusEffectListDouble = 0x00CF, // 7.15
        StatusEffectListEureka = 0x0133, // 7.15
        StatusEffectListForay3 = 0x03AF, // 7.15
        StatusEffectListPlayer = 0x013E, // 7.15
        StatusEffectListPlayerDouble = 0x0177, // 7.15
        SubmarineExplorationResult = 0x0082, // 7.15
        SubmarineProgressionStatus = 0x03D3, // 7.15
        SubmarineStatusList = 0x0118, // 7.15
        SubmarineTimers = 0x0115, // 7.15
        SystemLogMessage = 0x015F, // 7.15
        SystemLogMessage16 = 0x023A, // 7.15
        SystemLogMessage2 = 0x0329, // 7.15
        SystemLogMessage4 = 0x0178, // 7.15
        SystemLogMessage8 = 0x0280, // 7.15
        Transfer = 0x0285, // 7.15
        TreasureFadeOut = 0x0106, // 7.15
        UnMount = 0x01E7, // 7.15
        UpdateAllianceNormal = 0x01C9, // 7.15
        UpdateAllianceNormalMemberPositions = 0x020D, // 7.15
        UpdateAllianceSmall = 0x026A, // 7.15
        UpdateAllianceSmallMemberPositions = 0x0197, // 7.15
        UpdateClassInfo = 0x0077, // 7.15
        UpdateClassInfoBozja = 0x038B, // 7.15
        UpdateClassInfoEureka = 0x02FD, // 7.15
        UpdateClassInfoForay3 = 0x00E4, // 7.15
        UpdateDutyRecastTimes = 0x00C4, // 7.15
        UpdateDutyRecastTimes5 = 0x00FB, // 7.15
        UpdateHate = 0x03CE, // 7.15
        UpdateHater = 0x037A, // 7.15
        UpdateHpMpTp = 0x0216, // 7.15
        UpdateInventorySlot = 0x0383, // 7.15
        UpdateParty = 0x0202, // 7.15
        UpdatePartyMemberPositions = 0x015E, // 7.15
        UpdateRecastTimes = 0x0354, // 7.15
        UpdateSearchInfo = 0x0096, // 7.15
        WeatherChange = 0x02DF, // 7.15
        YardObjectSpawn = 0x0273, // 7.15
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02D0, // 7.15
        ActionRequestGroundTargeted = 0x03D6, // 7.15
        ChatHandler = 0x02AB, // 7.15
        ClientCountdownInitiate = 0x03AD, // 7.15
        ClientTrigger = 0x022B, // 7.15
        InventoryModifyHandler = 0x0306, // 7.15
        LogoutHandler = 0x03BB, // 7.11
        MarketBoardPurchaseHandler = 0x0263, // 7.15
        SetSearchInfoHandler = 0x0193, // 7.15
        UpdatePositionHandler = 0x0081, // 7.15
        UpdatePositionInstance = 0x0231, // 7.15
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
