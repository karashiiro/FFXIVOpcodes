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
        ActorCast = 0x03CF, // 7.401
        ActorControl = 0x0315, // 7.401
        ActorControlSelf = 0x019A, // 7.401
        ActorControlTarget = 0x01F1, // 7.401
        ActorGauge = 0x035F, // 7.401
        ActorMove = 0x02CE, // 7.401
        ActorSetPos = 0x0311, // 7.401
        AirshipExplorationResult = 0x0195, // 7.401
        AirshipStatus = 0x0373, // 7.401
        AirshipStatusList = 0x0157, // 7.401
        AirshipTimers = 0x02CD, // 7.401
        AoeEffect16 = 0x0128, // 7.401
        AoeEffect24 = 0x0154, // 7.401
        AoeEffect32 = 0x02E2, // 7.401
        AoeEffect8 = 0x02D5, // 7.401
        ApplyIDScramble = 0x0071, // 7.401
        BalloonTalk2 = 0x015F, // 7.401
        BalloonTalk4 = 0x028B, // 7.401
        BalloonTalk8 = 0x03BF, // 7.401
        BattleTalk2 = 0x0247, // 7.401
        BattleTalk4 = 0x032A, // 7.401
        BattleTalk8 = 0x0370, // 7.401
        BlackList = 0x011C, // 7.401
        CEDirector = 0x0191, // 7.401
        CeremonySetActorAppearance = 0x0245, // 7.401
        CFCancel = 0x0319, // 7.401
        CFDutyInfo = 0x020E, // 7.401
        CFNotify = 0x00DF, // 7.401
        CFPreferredRole = 0x029A, // 7.401
        CFRegistered = 0x030F, // 7.401
        CharaNameReq = 0x017D, // 7.401
        CharaVisualEffect = 0x00F1, // 7.401
        Chat = 0x01A7, // 7.401
        CompletedAchievements = 0x0282, // 7.401
        ContainerInfo = 0x02CB, // 7.401
        ContentDirectorSync = 0x032F, // 7.401
        Countdown = 0x01F3, // 7.401
        CountdownCancel = 0x01DD, // 7.401
        CreateTreasure = 0x00D6, // 7.401
        CrossWorldLinkshellList = 0x03DE, // 7.401
        CurrencyCrystalInfo = 0x0312, // 7.401
        DailyQuestRepeatFlags = 0x01B1, // 7.401
        DailyQuests = 0x0384, // 7.401
        DeepDungeonChests = 0x00F5, // 7.401
        DeepDungeonItems = 0x00FD, // 7.401
        DeepDungeonMap = 0x02CF, // 7.401
        DeepDungeonParty = 0x00CA, // 7.401
        DespawnCharacter = 0x033D, // 7.401
        DesynthResult = 0x00A5, // 7.401
        DirectorVars = 0x02F0, // 7.401
        Discovery = 0x027F, // 7.401
        Effect = 0x0261, // 7.401
        EffectResult = 0x03C9, // 7.401
        EffectResult16 = 0x0290, // 7.401
        EffectResult4 = 0x0389, // 7.401
        EffectResult8 = 0x0155, // 7.401
        EffectResultBasic = 0x02B0, // 7.401
        EffectResultBasic16 = 0x02E9, // 7.401
        EffectResultBasic32 = 0x01B2, // 7.401
        EffectResultBasic4 = 0x0332, // 7.401
        EffectResultBasic64 = 0x0231, // 7.401
        EffectResultBasic8 = 0x025B, // 7.401
        EnvironmentControl = 0x012B, // 7.401
        EnvironmentControl12 = 0x024A, // 7.401
        EnvironmentControl4 = 0x0303, // 7.401
        EnvironmentControl8 = 0x01B5, // 7.401
        EorzeaTimeOffset = 0x00B4, // 7.401
        EquipDisplayFlags = 0x0205, // 7.401
        EventContinue = 0x03E6, // 7.401
        EventFinish = 0x01B3, // 7.401
        EventPlay = 0x0230, // 7.401
        EventPlay128 = 0x016F, // 7.401
        EventPlay16 = 0x0177, // 7.401
        EventPlay255 = 0x0153, // 7.401
        EventPlay32 = 0x0103, // 7.401
        EventPlay4 = 0x01A2, // 7.401
        EventPlay64 = 0x0274, // 7.401
        EventPlay8 = 0x03AC, // 7.401
        EventStart = 0x013C, // 7.401
        Examine = 0x0396, // 7.401
        ExamineFreeCompanyInfo = 0x03E5, // 7.401
        ExamineSearchComment = 0x0326, // 7.401
        ExamineSearchInfo = 0x021F, // 7.401
        Fall = 0x00D8, // 7.401
        FateInfo = 0x0142, // 7.401
        FateTrade = 0x01C5, // 7.401
        FellowshipList = 0x0275, // 7.401
        FirstAttack = 0x03E1, // 7.401
        FreeCompanyDialog = 0x02CC, // 7.401
        FreeCompanyInfo = 0x0131, // 7.401
        GCAffiliation = 0x0109, // 7.401
        HousingEstateGreeting = 0x015D, // 7.401
        HousingIndoorInitialize = 0x037B, // 7.401
        HousingInternalObjectSpawn = 0x0087, // 7.401
        HousingLandFlags = 0x0309, // 7.401
        HousingObjectDye = 0x02FC, // 7.401
        HousingObjectInitialize = 0x030D, // 7.401
        HousingObjectMove = 0x00C6, // 7.401
        HousingShowEstateGuestAccess = 0x017B, // 7.401
        HousingUpdateLandFlagsSlot = 0x01A0, // 7.401
        HousingWardInfo = 0x00F2, // 7.401
        HuntingLogEntry = 0x039A, // 7.401
        Init = 0x021C, // 7.401
        InitSearchInfo = 0x01BE, // 7.401
        InitZone = 0x03CE, // 7.401
        InventoryActionAck = 0x03CB, // 7.401
        InventoryTransaction = 0x0107, // 7.401
        InventoryTransactionFinish = 0x0281, // 7.401
        IslandWorkshopDemandResearch = 0x02C9, // 7.401
        IslandWorkshopFavors = 0x0292, // 7.401
        IslandWorkshopSupplyDemand = 0x02EA, // 7.401
        ItemInfo = 0x0284, // 7.401
        ItemMarketBoardInfo = 0x01C6, // 7.401
        ItemMarketBoardSummary = 0x0190, // 7.401
        LandAvailability = 0x0173, // 7.401
        LandInfoSign = 0x03CC, // 7.401
        LandPriceUpdate = 0x019E, // 7.401
        LandRename = 0x016C, // 7.401
        LandSetInitialize = 0x0390, // 7.401
        LandSetMap = 0x009E, // 7.401
        LandUpdate = 0x011B, // 7.401
        LandUpdateHouseName = 0x0121, // 7.401
        LinkshellList = 0x0248, // 7.401
        LogMessage = 0x01A6, // 7.401
        Logout = 0x007C, // 7.401
        LootMessage = 0x00EB, // 7.401
        MailDeleteRequest = 0x0150, // 7.401
        MailDetail = 0x02C1, // 7.401
        MailList = 0x027D, // 7.401
        MapUpdate = 0x00B0, // 7.401
        MapUpdate128 = 0x016A, // 7.401
        MapUpdate16 = 0x0346, // 7.401
        MapUpdate32 = 0x03C5, // 7.401
        MapUpdate4 = 0x039D, // 7.401
        MapUpdate64 = 0x01E2, // 7.401
        MapUpdate8 = 0x008C, // 7.401
        MarketBoardItemListing = 0x00AA, // 7.401
        MarketBoardItemListingCount = 0x0241, // 7.401
        MarketBoardItemListingHistory = 0x03AA, // 7.401
        MarketBoardPurchase = 0x028E, // 7.401
        MarketBoardSale = 0x0081, // 7.401
        MarketBoardSearchResult = 0x033B, // 7.401
        MiniCactpotInit = 0x007A, // 7.401
        ModelEquip = 0x036F, // 7.401
        Mount = 0x01A4, // 7.401
        MSQTrackerComplete = 0x022A, // 7.401
        NpcSpawn = 0x0265, // 7.401
        NpcSpawn2 = 0x03CD, // 7.401
        NpcYell = 0x00E7, // 7.401
        ObjectDespawn = 0x01F5, // 7.401
        ObjectSpawn = 0x0305, // 7.401
        OpenTreasure = 0x039C, // 7.401
        PartyMessage = 0x0246, // 7.401
        Ping = 0x0180, // 7.401
        PlaceFieldMarker = 0x02A6, // 7.401
        PlaceFieldMarkerPreset = 0x0268, // 7.401
        PlayActionTimelineSync = 0x02B4, // 7.401
        PlayerAddedToBlacklist = 0x00C0, // 7.401
        PlayerBlueMageActions = 0x0256, // 7.401
        PlayerClassInfo = 0x0254, // 7.401
        PlayerRemovedFromBlacklist = 0x0285, // 7.401
        PlayerRetainerInfo = 0x006F, // 7.401
        PlayerSetup = 0x0229, // 7.401
        PlayerSpawn = 0x03D7, // 7.401
        PlayerStateFlags = 0x0366, // 7.401
        PlayerStats = 0x006C, // 7.401
        PlayerTitleList = 0x0079, // 7.401
        PlayerUpdateLook = 0x02B2, // 7.401
        PlayMotionSync = 0x007D, // 7.401
        Playtime = 0x0399, // 7.401
        PrepareZoning = 0x03BC, // 7.401
        QuestActiveList = 0x037A, // 7.401
        QuestCompleteList = 0x03A8, // 7.401
        QuestFinish = 0x01B8, // 7.401
        QuestTracker = 0x0077, // 7.401
        QuestUpdate = 0x02EC, // 7.401
        ResultDialog = 0x0137, // 7.401
        RetainerInformation = 0x0127, // 7.401
        RetainerSaleHistory = 0x0320, // 7.401
        RetainerState = 0x03BB, // 7.401
        RetainerSummary = 0x0277, // 7.401
        RSFData = 0x009D, // 7.401
        RSVData = 0x0117, // 7.401
        ServerNotice = 0x0355, // 7.401
        ServerNoticeShort = 0x01DA, // 7.401
        ServerRequestCallbackResponse = 0x0146, // 7.401
        ServerRequestCallbackResponse2 = 0x01AD, // 7.401
        ServerRequestCallbackResponse3 = 0x0371, // 7.401
        SetOnlineStatus = 0x025A, // 7.401
        SharedEstateSettingsResponse = 0x01D8, // 7.401
        SocialList = 0x0148, // 7.401
        SocialMessage = 0x0233, // 7.401
        SocialMessage2 = 0x0219, // 7.401
        SocialRequestResponse = 0x00BC, // 7.401
        StatusEffectList = 0x0380, // 7.401
        StatusEffectListBozja = 0x02D9, // 7.401
        StatusEffectListDouble = 0x02F4, // 7.401
        StatusEffectListEureka = 0x0259, // 7.401
        StatusEffectListForay3 = 0x035B, // 7.401
        StatusEffectListPlayer = 0x0392, // 7.401
        StatusEffectListPlayerDouble = 0x02E5, // 7.401
        SubmarineExplorationResult = 0x024C, // 7.401
        SubmarineProgressionStatus = 0x01B0, // 7.401
        SubmarineStatusList = 0x015E, // 7.401
        SubmarineTimers = 0x025E, // 7.401
        SystemLogMessage = 0x0323, // 7.401
        SystemLogMessage16 = 0x0234, // 7.401
        SystemLogMessage2 = 0x0339, // 7.401
        SystemLogMessage4 = 0x017F, // 7.401
        SystemLogMessage8 = 0x03B0, // 7.401
        Transfer = 0x0368, // 7.401
        TreasureFadeOut = 0x00ED, // 7.401
        UnMount = 0x03AE, // 7.401
        UpdateAllianceNormal = 0x0363, // 7.401
        UpdateAllianceNormalMemberPositions = 0x030A, // 7.401
        UpdateAllianceSmall = 0x0391, // 7.401
        UpdateAllianceSmallMemberPositions = 0x0381, // 7.401
        UpdateClassInfo = 0x00A3, // 7.401
        UpdateClassInfoBozja = 0x00E0, // 7.401
        UpdateClassInfoEureka = 0x0385, // 7.401
        UpdateClassInfoForay3 = 0x007F, // 7.401
        UpdateDutyRecastTimes = 0x037F, // 7.401
        UpdateDutyRecastTimes5 = 0x03BD, // 7.401
        UpdateHate = 0x00C2, // 7.401
        UpdateHater = 0x019C, // 7.401
        UpdateHpMpTp = 0x006B, // 7.401
        UpdateInventorySlot = 0x010D, // 7.401
        UpdateParty = 0x0083, // 7.401
        UpdatePartyMemberPositions = 0x0151, // 7.401
        UpdateRecastTimes = 0x0244, // 7.401
        UpdateSearchInfo = 0x00BB, // 7.401
        WeatherChange = 0x023A, // 7.401
        YardObjectSpawn = 0x03DA, // 7.401
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x00D4, // 7.401
        ActionRequestGroundTargeted = 0x034A, // 7.401
        ChatHandler = 0x00AD, // 7.401
        ClientCountdownInitiate = 0x02C1, // 7.401
        ClientTrigger = 0x0105, // 7.401
        InventoryModifyHandler = 0x0306, // 7.401
        LogoutHandler = 0x0099, // 7.401
        MarketBoardPurchaseHandler = 0x0117, // 7.401
        SetSearchInfoHandler = 0x023D, // 7.401
        UpdatePositionHandler = 0x023E, // 7.401
        UpdatePositionInstance = 0x03D7, // 7.401
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
