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
        ActorCast = 0x00B9, // 6.55
        ActorControl = 0x03CB, // 6.55
        ActorControlSelf = 0x0269, // 6.55
        ActorControlTarget = 0x018B, // 6.55
        ActorGauge = 0x0163, // 6.55
        ActorMove = 0x0363, // 6.55
        ActorSetPos = 0x02B0, // 6.55
        AirshipExplorationResult = 0x02AB, // 6.55
        AirshipStatus = 0x0149, // 6.55
        AirshipStatusList = 0x01B5, // 6.55
        AirshipTimers = 0x0271, // 6.55
        AoeEffect16 = 0x03E5, // 6.55
        AoeEffect24 = 0x01A5, // 6.55
        AoeEffect32 = 0x01A0, // 6.55
        AoeEffect8 = 0x00A3, // 6.55
        ApplyIDScramble = 0x010C, // 6.55
        BalloonTalk2 = 0x029B, // 6.55
        BalloonTalk4 = 0x00F4, // 6.55
        BalloonTalk8 = 0x0255, // 6.55
        BattleTalk2 = 0x00A4, // 6.55
        BattleTalk4 = 0x01D9, // 6.55
        BattleTalk8 = 0x0216, // 6.55
        BlackList = 0x0334, // 6.55
        CEDirector = 0x02BF, // 6.55
        CeremonySetActorAppearance = 0x0264, // 6.55
        CFCancel = 0x011D, // 6.55
        CFDutyInfo = 0x0173, // 6.55
        CFNotify = 0x0130, // 6.55
        CFPreferredRole = 0x01C3, // 6.55
        CFRegistered = 0x01FA, // 6.55
        CharaNameReq = 0x0080, // 6.55
        CharaVisualEffect = 0x02D7, // 6.55
        Chat = 0x01F2, // 6.55
        ContainerInfo = 0x01B0, // 6.55
        ContentDirectorSync = 0x014B, // 6.55
        Countdown = 0x0208, // 6.55
        CountdownCancel = 0x00D4, // 6.55
        CreateTreasure = 0x0123, // 6.55
        CrossWorldLinkshellList = 0x01F8, // 6.55
        CurrencyCrystalInfo = 0x00E0, // 6.55
        DailyQuestRepeatFlags = 0x02E2, // 6.55
        DailyQuests = 0x0319, // 6.55
        DespawnCharacter = 0x0259, // 6.55
        DesynthResult = 0x03B3, // 6.55
        DirectorVars = 0x03BD, // 6.55
        Discovery = 0x0374, // 6.55
        Effect = 0x031A, // 6.55
        EffectResult = 0x0305, // 6.55
        EffectResult16 = 0x0331, // 6.55
        EffectResult4 = 0x01F4, // 6.55
        EffectResult8 = 0x037A, // 6.55
        EffectResultBasic = 0x01BF, // 6.55
        EffectResultBasic16 = 0x0254, // 6.55
        EffectResultBasic32 = 0x01E1, // 6.55
        EffectResultBasic4 = 0x01CF, // 6.55
        EffectResultBasic64 = 0x01A4, // 6.55
        EffectResultBasic8 = 0x0170, // 6.55
        EnvironmentControl = 0x0252, // 6.55
        EorzeaTimeOffset = 0x0185, // 6.55
        EquipDisplayFlags = 0x0191, // 6.55
        EventContinue = 0x02B9, // 6.55
        EventFinish = 0x0349, // 6.55
        EventPlay = 0x01F0, // 6.55
        EventPlay128 = 0x03D3, // 6.55
        EventPlay16 = 0x03AE, // 6.55
        EventPlay255 = 0x02A3, // 6.55
        EventPlay32 = 0x0085, // 6.55
        EventPlay4 = 0x023B, // 6.55
        EventPlay64 = 0x02C9, // 6.55
        EventPlay8 = 0x0210, // 6.55
        EventStart = 0x03AD, // 6.55
        Examine = 0x0118, // 6.55
        ExamineFreeCompanyInfo = 0x0371, // 6.55
        ExamineSearchComment = 0x0303, // 6.55
        ExamineSearchInfo = 0x01A1, // 6.55
        Fall = 0x02E1, // 6.55
        FateInfo = 0x0381, // 6.55
        FellowshipList = 0x00D3, // 6.55
        FirstAttack = 0x03D9, // 6.55
        FreeCompanyDialog = 0x0205, // 6.55
        FreeCompanyInfo = 0x01F7, // 6.55
        GCAffiliation = 0x0195, // 6.55
        HousingEstateGreeting = 0x0098, // 6.55
        HousingIndoorInitialize = 0x02ED, // 6.55
        HousingInternalObjectSpawn = 0x00D5, // 6.55
        HousingLandFlags = 0x0100, // 6.55
        HousingObjectDye = 0x022C, // 6.55
        HousingObjectInitialize = 0x03B6, // 6.55
        HousingObjectMove = 0x0304, // 6.55
        HousingShowEstateGuestAccess = 0x010B, // 6.55
        HousingUpdateLandFlagsSlot = 0x0356, // 6.55
        HousingWardInfo = 0x0362, // 6.55
        HuntingLogEntry = 0x0128, // 6.55
        Init = 0x0302, // 6.55
        InitSearchInfo = 0x0174, // 6.55
        InitZone = 0x0084, // 6.55
        InventoryActionAck = 0x008E, // 6.55
        InventoryTransaction = 0x0329, // 6.55
        InventoryTransactionFinish = 0x01B1, // 6.55
        IslandWorkshopSupplyDemand = 0x02F7, // 6.55
        ItemInfo = 0x02BE, // 6.55
        ItemMarketBoardInfo = 0x0273, // 6.55
        LandAvailability = 0x03D1, // 6.55
        LandInfoSign = 0x02DD, // 6.55
        LandPriceUpdate = 0x0337, // 6.55
        LandRename = 0x02D9, // 6.55
        LandSetInitialize = 0x02DA, // 6.55
        LandSetMap = 0x037C, // 6.55
        LandUpdate = 0x011C, // 6.55
        LandUpdateHouseName = 0x01F5, // 6.55
        LinkshellList = 0x0157, // 6.55
        LogMessage = 0x028B, // 6.55
        Logout = 0x0206, // 6.55
        LootMessage = 0x010A, // 6.55
        MailDeleteRequest = 0x0267, // 6.55
        MapUpdate = 0x0147, // 6.55
        MapUpdate128 = 0x0346, // 6.55
        MapUpdate16 = 0x0077, // 6.55
        MapUpdate32 = 0x0122, // 6.55
        MapUpdate4 = 0x00A7, // 6.55
        MapUpdate64 = 0x030D, // 6.55
        MapUpdate8 = 0x00F9, // 6.55
        MarketBoardItemListing = 0x008C, // 6.55
        MarketBoardItemListingCount = 0x032C, // 6.55
        MarketBoardItemListingHistory = 0x00A6, // 6.55
        MarketBoardPurchase = 0x00D1, // 6.55
        MarketBoardSearchResult = 0x0137, // 6.55
        MiniCactpotInit = 0x02E4, // 6.55
        ModelEquip = 0x017A, // 6.55
        Mount = 0x03D2, // 6.55
        MSQTrackerComplete = 0x01B7, // 6.55
        NpcSpawn = 0x010F, // 6.55
        NpcSpawn2 = 0x025B, // 6.55
        NpcYell = 0x00C0, // 6.55
        ObjectDespawn = 0x0081, // 6.55
        ObjectSpawn = 0x0153, // 6.55
        OpenTreasure = 0x02B7, // 6.55
        PartyMessage = 0x031E, // 6.55
        Ping = 0x02C7, // 6.55
        PlaceFieldMarker = 0x009E, // 6.55
        PlaceFieldMarkerPreset = 0x036A, // 6.55
        PlaceMarker = 0x029D, // 6.55
        PlayerAddedToBlacklist = 0x0094, // 6.55
        PlayerClassInfo = 0x0142, // 6.55
        PlayerRemovedFromBlacklist = 0x009C, // 6.55
        PlayerSetup = 0x02FD, // 6.55
        PlayerSpawn = 0x007E, // 6.55
        PlayerStateFlags = 0x01D4, // 6.55
        PlayerStats = 0x032D, // 6.55
        PlayerTitleList = 0x03CD, // 6.55
        PlayerUpdateLook = 0x0382, // 6.55
        PlayMotionSync = 0x038B, // 6.55
        Playtime = 0x01DA, // 6.55
        PrepareZoning = 0x035E, // 6.55
        QuestActiveList = 0x0203, // 6.55
        QuestCompleteList = 0x029C, // 6.55
        QuestFinish = 0x0366, // 6.55
        QuestTracker = 0x01FD, // 6.55
        QuestUpdate = 0x00CD, // 6.55
        ResultDialog = 0x0086, // 6.55
        RetainerInformation = 0x01B8, // 6.55
        RetainerSaleHistory = 0x0321, // 6.55
        RSFData = 0x035F, // 6.55
        RSVData = 0x0150, // 6.55
        ServerNotice = 0x01BC, // 6.55
        ServerNoticeShort = 0x0280, // 6.55
        SetOnlineStatus = 0x0101, // 6.55
        SharedEstateSettingsResponse = 0x02FF, // 6.55
        SocialList = 0x0348, // 6.55
        SocialMessage = 0x0065, // 6.55
        SocialMessage2 = 0x0068, // 6.55
        SocialRequestResponse = 0x0250, // 6.55
        StatusEffectList = 0x0148, // 6.55
        StatusEffectListBozja = 0x0121, // 6.55 (StatusEffectList2)
        StatusEffectListDouble = 0x00BA, // 6.55 (BossStatusEffectList)
        StatusEffectListEureka = 0x01EA, // 6.55
        StatusEffectListPlayer = 0x0314, // 6.55 (StatusEffectList3)
        StatusEffectListPlayerDouble = 0x01FB, // 6.55
        SubmarineExplorationResult = 0x026C, // 6.55
        SubmarineProgressionStatus = 0x022D, // 6.55
        SubmarineStatusList = 0x02B4, // 6.55
        SubmarineTimers = 0x0306, // 6.55
        SystemLogMessage = 0x022F, // 6.55
        SystemLogMessage16 = 0x016C, // 6.55
        SystemLogMessage2 = 0x0069, // 6.55
        SystemLogMessage4 = 0x015B, // 6.55
        SystemLogMessage8 = 0x01DB, // 6.55
        Transfer = 0x025F, // 6.55
        TreasureFadeOut = 0x0386, // 6.55
        UpdateAllianceNormal = 0x013E, // 6.55
        UpdateAllianceNormalMemberPositions = 0x02C3, // 6.55
        UpdateAllianceSmall = 0x0159, // 6.55
        UpdateAllianceSmallMemberPositions = 0x0190, // 6.55
        UpdateClassInfo = 0x00AB, // 6.55
        UpdateClassInfoBozja = 0x0193, // 6.55
        UpdateClassInfoEureka = 0x0097, // 6.55
        UpdateHate = 0x0350, // 6.55
        UpdateHater = 0x0225, // 6.55
        UpdateHpMpTp = 0x0162, // 6.55
        UpdateInventorySlot = 0x02BA, // 6.55
        UpdateParty = 0x02DF, // 6.55
        UpdatePartyMemberPositions = 0x0296, // 6.55
        UpdateRecastTimes = 0x025A, // 6.55
        UpdateSearchInfo = 0x0160, // 6.55
        WeatherChange = 0x02A4, // 6.55
        YardObjectSpawn = 0x030F, // 6.55
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02FA, // 6.55
        ActionRequestGroundTargeted = 0x01D3, // 6.55
        ChatHandler = 0x0112, // 6.55
        ClientCountdownInitiate = 0x008C, // 6.55
        ClientTrigger = 0x00BB, // 6.55
        Heartbeat = 0x0146, // 6.55
        InventoryModifyHandler = 0x0192, // 6.55 (Base offset: 0x0199)
        LogoutHandler = 0x0285, // 6.55
        MarketBoardPurchaseHandler = 0x0068, // 6.55
        SetSearchInfoHandler = 0x01F6, // 6.55
        UpdatePositionHandler = 0x024B, // 6.55
        UpdatePositionInstance = 0x031B, // 6.55
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
