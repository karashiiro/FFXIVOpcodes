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
        ActorCast = 0x00BD, // 7.11
        ActorControl = 0x011B, // 7.11
        ActorControlSelf = 0x0311, // 7.11
        ActorControlTarget = 0x0283, // 7.11
        ActorGauge = 0x0309, // 7.11
        ActorMove = 0x0238, // 7.11
        ActorSetPos = 0x02B0, // 7.11
        AirshipExplorationResult = 0x01F4, // 7.11
        AirshipStatus = 0x0071, // 7.11
        AirshipStatusList = 0x0126, // 7.11
        AirshipTimers = 0x02E2, // 7.11
        AoeEffect16 = 0x00B9, // 7.11
        AoeEffect24 = 0x0122, // 7.11
        AoeEffect32 = 0x01CF, // 7.11
        AoeEffect8 = 0x0368, // 7.11
        ApplyIDScramble = 0x00A2, // 7.11
        BalloonTalk2 = 0x015D, // 7.11
        BalloonTalk4 = 0x00A0, // 7.11
        BalloonTalk8 = 0x01AC, // 7.11
        BattleTalk2 = 0x021B, // 7.11
        BattleTalk4 = 0x02EE, // 7.11
        BattleTalk8 = 0x01B5, // 7.11
        BlackList = 0x021C, // 7.11
        CEDirector = 0x01F2, // 7.11
        CeremonySetActorAppearance = 0x0080, // 7.11
        CFCancel = 0x006A, // 7.11
        CFDutyInfo = 0x018F, // 7.11
        CFNotify = 0x03A6, // 7.11
        CFPreferredRole = 0x00E9, // 7.11
        CFRegistered = 0x029D, // 7.11
        CharaNameReq = 0x01CB, // 7.11
        CharaVisualEffect = 0x016E, // 7.11
        Chat = 0x0188, // 7.11
        CompletedAchievements = 0x0169, // 7.11
        ContainerInfo = 0x00E4, // 7.11
        ContentDirectorSync = 0x0218, // 7.11
        Countdown = 0x01FE, // 7.11
        CountdownCancel = 0x0391, // 7.11
        CreateTreasure = 0x038C, // 7.11
        CrossWorldLinkshellList = 0x01DC, // 7.11
        CurrencyCrystalInfo = 0x015F, // 7.11
        DailyQuestRepeatFlags = 0x0214, // 7.11
        DailyQuests = 0x0158, // 7.11
        DespawnCharacter = 0x033B, // 7.11
        DesynthResult = 0x030E, // 7.11
        DirectorVars = 0x0367, // 7.11
        Discovery = 0x00C6, // 7.11
        Effect = 0x007D, // 7.11
        EffectResult = 0x03AC, // 7.11
        EffectResult16 = 0x00E3, // 7.11
        EffectResult4 = 0x0151, // 7.11
        EffectResult8 = 0x0209, // 7.11
        EffectResultBasic = 0x03E4, // 7.11
        EffectResultBasic16 = 0x02B4, // 7.11
        EffectResultBasic32 = 0x0265, // 7.11
        EffectResultBasic4 = 0x03C7, // 7.11
        EffectResultBasic64 = 0x0325, // 7.11
        EffectResultBasic8 = 0x03C4, // 7.11
        EnvironmentControl = 0x0208, // 7.11
        EorzeaTimeOffset = 0x029F, // 7.11
        EquipDisplayFlags = 0x01BF, // 7.11
        EventContinue = 0x0160, // 7.11
        EventFinish = 0x02C7, // 7.11
        EventPlay = 0x025B, // 7.11
        EventPlay128 = 0x02ED, // 7.11
        EventPlay16 = 0x011A, // 7.11
        EventPlay255 = 0x02E3, // 7.11
        EventPlay32 = 0x0334, // 7.11
        EventPlay4 = 0x0175, // 7.11
        EventPlay64 = 0x02AC, // 7.11
        EventPlay8 = 0x034E, // 7.11
        EventStart = 0x0327, // 7.11
        Examine = 0x00BA, // 7.11
        ExamineFreeCompanyInfo = 0x0186, // 7.11
        ExamineSearchComment = 0x00EC, // 7.11
        ExamineSearchInfo = 0x01C7, // 7.11
        Fall = 0x02FC, // 7.11
        FashionReport = 0x0241, // 7.11
        FateInfo = 0x03D2, // 7.11
        FellowshipList = 0x01DA, // 7.11
        FirstAttack = 0x01C9, // 7.11
        FreeCompanyDialog = 0x016F, // 7.11
        FreeCompanyInfo = 0x00B4, // 7.11
        GCAffiliation = 0x02B1, // 7.11
        HousingEstateGreeting = 0x01FA, // 7.11
        HousingIndoorInitialize = 0x02BD, // 7.11
        HousingInternalObjectSpawn = 0x009C, // 7.11
        HousingLandFlags = 0x018B, // 7.11
        HousingObjectDye = 0x028C, // 7.11
        HousingObjectInitialize = 0x0263, // 7.11
        HousingObjectMove = 0x00CC, // 7.11
        HousingShowEstateGuestAccess = 0x024B, // 7.11
        HousingUpdateLandFlagsSlot = 0x0384, // 7.11
        HousingWardInfo = 0x0237, // 7.11
        HuntingLogEntry = 0x0371, // 7.11
        Init = 0x00D3, // 7.11
        InitSearchInfo = 0x0365, // 7.11
        InitZone = 0x020E, // 7.11
        InventoryActionAck = 0x013B, // 7.11
        InventoryTransaction = 0x01CC, // 7.11
        InventoryTransactionFinish = 0x00B0, // 7.11
        IslandWorkshopDemandResearch = 0x018D, // 7.11
        IslandWorkshopFavors = 0x01DB, // 7.11
        IslandWorkshopSupplyDemand = 0x03BF, // 7.11
        ItemInfo = 0x025D, // 7.11
        ItemMarketBoardInfo = 0x00DB, // 7.11
        ItemMarketBoardSummary = 0x0266, // 7.11
        LandAvailability = 0x01AA, // 7.11
        LandInfoSign = 0x013A, // 7.11
        LandPriceUpdate = 0x007A, // 7.11
        LandRename = 0x0328, // 7.11
        LandSetInitialize = 0x00A4, // 7.11
        LandSetMap = 0x0281, // 7.11
        LandUpdate = 0x0219, // 7.11
        LandUpdateHouseName = 0x0290, // 7.11
        LinkshellList = 0x0380, // 7.11
        LogMessage = 0x0344, // 7.11
        Logout = 0x00D1, // 7.11
        LootMessage = 0x02C6, // 7.11
        MailDeleteRequest = 0x0267, // 7.11
        MailDetail = 0x0168, // 7.11
        MailList = 0x02E8, // 7.11
        MapUpdate = 0x0381, // 7.11
        MapUpdate128 = 0x0361, // 7.11
        MapUpdate16 = 0x0211, // 7.11
        MapUpdate32 = 0x0187, // 7.11
        MapUpdate4 = 0x032B, // 7.11
        MapUpdate64 = 0x008D, // 7.11
        MapUpdate8 = 0x03DA, // 7.11
        MarketBoardItemListing = 0x02C9, // 7.11
        MarketBoardItemListingCount = 0x00B2, // 7.11
        MarketBoardItemListingHistory = 0x00E2, // 7.11
        MarketBoardPurchase = 0x033E, // 7.11
        MarketBoardSale = 0x03C1, // 7.11
        MarketBoardSearchResult = 0x00FB, // 7.11
        MiniCactpotInit = 0x013C, // 7.11
        ModelEquip = 0x0376, // 7.11
        Mount = 0x0397, // 7.11
        MSQTrackerComplete = 0x0075, // 7.11
        NpcSpawn = 0x0231, // 7.11
        NpcSpawn2 = 0x0295, // 7.11
        NpcYell = 0x00C1, // 7.11
        ObjectDespawn = 0x02C1, // 7.11
        ObjectSpawn = 0x0065, // 7.11
        OpenTreasure = 0x0261, // 7.11
        PartyMessage = 0x00C3, // 7.11
        Ping = 0x01C6, // 7.11
        PlaceFieldMarker = 0x013F, // 7.11
        PlaceFieldMarkerPreset = 0x019D, // 7.11
        PlaceMarker = 0x00FA, // 7.11
        PlayerAddedToBlacklist = 0x025A, // 7.11
        PlayerBlueMageActions = 0x039C, // 7.11
        PlayerClassInfo = 0x037E, // 7.11
        PlayerRemovedFromBlacklist = 0x00FF, // 7.11
        PlayerRetainerInfo = 0x0091, // 7.11
        PlayerSetup = 0x01B3, // 7.11
        PlayerSpawn = 0x03C8, // 7.11
        PlayerStateFlags = 0x00C4, // 7.11
        PlayerStats = 0x034D, // 7.11
        PlayerTitleList = 0x02EA, // 7.11
        PlayerUpdateLook = 0x02B5, // 7.11
        PlayMotionSync = 0x022B, // 7.11
        Playtime = 0x0364, // 7.11
        PrepareZoning = 0x0362, // 7.11
        QuestActiveList = 0x0216, // 7.11
        QuestCompleteList = 0x0233, // 7.11
        QuestFinish = 0x00BC, // 7.11
        QuestTracker = 0x01A8, // 7.11
        QuestUpdate = 0x01D2, // 7.11
        ResultDialog = 0x0242, // 7.11
        RetainerInformation = 0x02FA, // 7.11
        RetainerSaleHistory = 0x031A, // 7.11
        RetainerState = 0x0240, // 7.11
        RetainerSummary = 0x00B1, // 7.11
        RSFData = 0x0096, // 7.11
        RSVData = 0x013D, // 7.11
        ServerNotice = 0x015E, // 7.11
        ServerNoticeShort = 0x0130, // 7.11
        ServerRequestCallbackResponse1 = 0x010C, // 7.11
        ServerRequestCallbackResponse2 = 0x0181, // 7.11
        ServerRequestCallbackResponse3 = 0x0086, // 7.11
        SetOnlineStatus = 0x0252, // 7.11
        SharedEstateSettingsResponse = 0x02F2, // 7.11
        SocialList = 0x03AB, // 7.11
        SocialMessage = 0x012F, // 7.11
        SocialMessage2 = 0x01E9, // 7.11
        SocialRequestResponse = 0x01A9, // 7.11
        StatusEffectList = 0x023A, // 7.11
        StatusEffectListBozja = 0x02AE, // 7.11
        StatusEffectListDouble = 0x0135, // 7.11
        StatusEffectListEureka = 0x02B6, // 7.11
        StatusEffectListForay3 = 0x0331, // 7.11
        StatusEffectListPlayer = 0x0315, // 7.11
        StatusEffectListPlayerDouble = 0x0098, // 7.11
        SubmarineExplorationResult = 0x0312, // 7.11
        SubmarineProgressionStatus = 0x033A, // 7.11
        SubmarineStatusList = 0x022F, // 7.11
        SubmarineTimers = 0x039E, // 7.11
        SystemLogMessage = 0x030A, // 7.11
        SystemLogMessage16 = 0x0150, // 7.11
        SystemLogMessage2 = 0x0301, // 7.11
        SystemLogMessage4 = 0x03DC, // 7.11
        SystemLogMessage8 = 0x01B0, // 7.11
        Transfer = 0x02A8, // 7.11
        TreasureFadeOut = 0x039D, // 7.11
        UnMount = 0x0335, // 7.11
        UpdateAllianceNormal = 0x035E, // 7.11
        UpdateAllianceNormalMemberPositions = 0x0398, // 7.11
        UpdateAllianceSmall = 0x00D0, // 7.11
        UpdateAllianceSmallMemberPositions = 0x01B8, // 7.11
        UpdateClassInfo = 0x036B, // 7.11
        UpdateClassInfoBozja = 0x01E7, // 7.11
        UpdateClassInfoEureka = 0x014B, // 7.11
        UpdateClassInfoForay3 = 0x00A3, // 7.11
        UpdateDutyRecastTimes = 0x03C5, // 7.11
        UpdateDutyRecastTimes5 = 0x02B2, // 7.11
        UpdateHate = 0x017A, // 7.11
        UpdateHater = 0x00A7, // 7.11
        UpdateHpMpTp = 0x0068, // 7.11
        UpdateInventorySlot = 0x01D8, // 7.11
        UpdateParty = 0x02F5, // 7.11
        UpdatePartyMemberPositions = 0x0319, // 7.11
        UpdateRecastTimes = 0x0354, // 7.11
        UpdateSearchInfo = 0x010F, // 7.11
        WeatherChange = 0x00FE, // 7.11
        YardObjectSpawn = 0x007E, // 7.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x01BA, // 7.11
        ActionRequestGroundTargeted = 0x00F2, // 7.11
        ChatHandler = 0x0178, // 7.11
        ClientCountdownInitiate = 0x0267, // 7.11
        ClientTrigger = 0x0305, // 7.11
        InventoryModifyHandler = 0x03B0, // 7.11
        LogoutHandler = 0x0234, // 7.11
        MarketBoardPurchaseHandler = 0x01FD, // 7.11
        SetSearchInfoHandler = 0x019B, // 7.11
        UpdatePositionHandler = 0x01AE, // 7.11
        UpdatePositionInstance = 0x022D, // 7.11
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
