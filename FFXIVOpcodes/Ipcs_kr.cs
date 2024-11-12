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
        ActorCast = 0x031B, // 6.58
        ActorControl = 0x00DB, // 6.58
        ActorControlSelf = 0x02BD, // 6.58
        ActorControlTarget = 0x00FA, // 6.58
        ActorGauge = 0x018A, // 6.58
        ActorMove = 0x023F, // 6.58
        ActorSetPos = 0x0317, // 6.58
        AirshipExplorationResult = 0x0112, // 6.58
        AirshipStatus = 0x0169, // 6.58
        AirshipStatusList = 0x0237, // 6.58
        AirshipTimers = 0x0291, // 6.58
        AoeEffect16 = 0x02E6, // 6.58
        AoeEffect24 = 0x033E, // 6.58
        AoeEffect32 = 0x00B4, // 6.58
        AoeEffect8 = 0x0264, // 6.58
        ApplyIDScramble = 0x019E, // 6.58
        BalloonTalk2 = 0x036A, // 6.58
        BalloonTalk4 = 0x0080, // 6.58
        BalloonTalk8 = 0x03AD, // 6.58
        BattleTalk2 = 0x02EF, // 6.58
        BattleTalk4 = 0x0262, // 6.58
        BattleTalk8 = 0x03A9, // 6.58
        BlackList = 0x0361, // 6.58
        CEDirector = 0x0132, // 6.58
        CeremonySetActorAppearance = 0x00A9, // 6.58
        CFCancel = 0x01CD, // 6.58
        CFDutyInfo = 0x0346, // 6.58
        CFNotify = 0x0316, // 6.58
        CFPreferredRole = 0x02B1, // 6.58
        CFRegistered = 0x0384, // 6.58
        CharaNameReq = 0x02D2, // 6.58
        CharaVisualEffect = 0x020F, // 6.58
        Chat = 0x024B, // 6.58
        ContainerInfo = 0x036E, // 6.58
        ContentDirectorSync = 0x03BB, // 6.58
        Countdown = 0x039D, // 6.58
        CountdownCancel = 0x0376, // 6.58
        CreateTreasure = 0x0340, // 6.58
        CrossWorldLinkshellList = 0x03C5, // 6.58
        CurrencyCrystalInfo = 0x0219, // 6.58
        DailyQuestRepeatFlags = 0x0186, // 6.58
        DailyQuests = 0x00F9, // 6.58
        DespawnCharacter = 0x02B0, // 6.58
        DesynthResult = 0x032B, // 6.58
        DirectorVars = 0x00D0, // 6.58
        Discovery = 0x0234, // 6.58
        Effect = 0x0159, // 6.58
        EffectResult = 0x02D9, // 6.58
        EffectResult16 = 0x0236, // 6.58
        EffectResult4 = 0x01CC, // 6.58
        EffectResult8 = 0x0082, // 6.58
        EffectResultBasic = 0x01FB, // 6.58
        EffectResultBasic16 = 0x0358, // 6.58
        EffectResultBasic32 = 0x00CC, // 6.58
        EffectResultBasic4 = 0x02EE, // 6.58
        EffectResultBasic64 = 0x010C, // 6.58
        EffectResultBasic8 = 0x033A, // 6.58
        EnvironmentControl = 0x03BE, // 6.58
        EorzeaTimeOffset = 0x0077, // 6.58
        EquipDisplayFlags = 0x0211, // 6.58
        EventContinue = 0x0373, // 6.58
        EventFinish = 0x03B1, // 6.58
        EventPlay = 0x0185, // 6.58
        EventPlay128 = 0x0187, // 6.58
        EventPlay16 = 0x01C2, // 6.58
        EventPlay255 = 0x031D, // 6.58
        EventPlay32 = 0x01EC, // 6.58
        EventPlay4 = 0x035E, // 6.58
        EventPlay64 = 0x0247, // 6.58
        EventPlay8 = 0x0393, // 6.58
        EventStart = 0x03B5, // 6.58
        Examine = 0x02B4, // 6.58
        ExamineFreeCompanyInfo = 0x00E5, // 6.58
        ExamineSearchComment = 0x03D9, // 6.58
        ExamineSearchInfo = 0x02BC, // 6.58
        Fall = 0x01D5, // 6.58
        FateInfo = 0x00DC, // 6.58
        FellowshipList = 0x00C4, // 6.58
        FirstAttack = 0x02AC, // 6.58
        FreeCompanyDialog = 0x0322, // 6.58
        FreeCompanyInfo = 0x03C3, // 6.58
        GCAffiliation = 0x01D0, // 6.58
        HousingEstateGreeting = 0x030C, // 6.58
        HousingIndoorInitialize = 0x0245, // 6.58
        HousingInternalObjectSpawn = 0x00A3, // 6.58
        HousingLandFlags = 0x02D5, // 6.58
        HousingObjectDye = 0x02CE, // 6.58
        HousingObjectInitialize = 0x006B, // 6.58
        HousingObjectMove = 0x02B2, // 6.58
        HousingShowEstateGuestAccess = 0x0301, // 6.58
        HousingUpdateLandFlagsSlot = 0x029A, // 6.58
        HousingWardInfo = 0x03D7, // 6.58
        HuntingLogEntry = 0x0357, // 6.58
        Init = 0x00D7, // 6.58
        InitSearchInfo = 0x0222, // 6.58
        InitZone = 0x01F4, // 6.58
        InventoryActionAck = 0x0315, // 6.58
        InventoryTransaction = 0x0253, // 6.58
        InventoryTransactionFinish = 0x01ED, // 6.58
        IslandWorkshopSupplyDemand = 0x0289, // 6.58
        ItemInfo = 0x027F, // 6.58
        ItemMarketBoardInfo = 0x01B0, // 6.58
        LandAvailability = 0x01B5, // 6.58
        LandInfoSign = 0x013B, // 6.58
        LandPriceUpdate = 0x018F, // 6.58
        LandRename = 0x0287, // 6.58
        LandSetInitialize = 0x011A, // 6.58
        LandSetMap = 0x0250, // 6.58
        LandUpdate = 0x0386, // 6.58
        LandUpdateHouseName = 0x02A8, // 6.58
        LinkshellList = 0x03C1, // 6.58
        LogMessage = 0x01C6, // 6.58
        Logout = 0x01F6, // 6.58
        LootMessage = 0x037E, // 6.58
        MailDeleteRequest = 0x035F, // 6.58
        MapUpdate = 0x0144, // 6.58
        MapUpdate128 = 0x0102, // 6.58
        MapUpdate16 = 0x0328, // 6.58
        MapUpdate32 = 0x00FB, // 6.58
        MapUpdate4 = 0x0387, // 6.58
        MapUpdate64 = 0x02D4, // 6.58
        MapUpdate8 = 0x01F9, // 6.58
        MarketBoardItemListing = 0x030B, // 6.58
        MarketBoardItemListingCount = 0x01FA, // 6.58
        MarketBoardItemListingHistory = 0x012B, // 6.58
        MarketBoardPurchase = 0x0389, // 6.58
        MarketBoardSearchResult = 0x02F8, // 6.58
        MiniCactpotInit = 0x0304, // 6.58
        ModelEquip = 0x028C, // 6.58
        Mount = 0x0071, // 6.58
        MSQTrackerComplete = 0x03A4, // 6.58
        NpcSpawn = 0x01EF, // 6.58
        NpcSpawn2 = 0x0115, // 6.58
        NpcYell = 0x0326, // 6.58
        ObjectDespawn = 0x0252, // 6.58
        ObjectSpawn = 0x00FD, // 6.58
        OpenTreasure = 0x020E, // 6.58
        PartyMessage = 0x0241, // 6.58
        Ping = 0x03D2, // 6.58
        PlaceFieldMarker = 0x017A, // 6.58
        PlaceFieldMarkerPreset = 0x03DC, // 6.58
        PlaceMarker = 0x0312, // 6.58
        PlayerAddedToBlacklist = 0x03DA, // 6.58
        PlayerClassInfo = 0x0274, // 6.58
        PlayerRemovedFromBlacklist = 0x02CF, // 6.58
        PlayerSetup = 0x0138, // 6.58
        PlayerSpawn = 0x0306, // 6.58
        PlayerStateFlags = 0x0223, // 6.58
        PlayerStats = 0x00BB, // 6.58
        PlayerTitleList = 0x0392, // 6.58
        PlayerUpdateLook = 0x02CC, // 6.58
        PlayMotionSync = 0x0205, // 6.58
        Playtime = 0x0220, // 6.58
        PrepareZoning = 0x025E, // 6.58
        QuestActiveList = 0x029C, // 6.58
        QuestCompleteList = 0x0300, // 6.58
        QuestFinish = 0x0182, // 6.58
        QuestTracker = 0x0160, // 6.58
        QuestUpdate = 0x0388, // 6.58
        ResultDialog = 0x028E, // 6.58
        RetainerInformation = 0x0350, // 6.58
        RetainerSaleHistory = 0x01CB, // 6.58
        RSFData = 0x0188, // 6.58
        RSVData = 0x00B0, // 6.58
        ServerNotice = 0x0165, // 6.58
        ServerNoticeShort = 0x02E5, // 6.58
        SetOnlineStatus = 0x03AA, // 6.58
        SharedEstateSettingsResponse = 0x0157, // 6.58
        SocialList = 0x0218, // 6.58
        SocialMessage = 0x03A5, // 6.58
        SocialMessage2 = 0x0372, // 6.58
        SocialRequestResponse = 0x0379, // 6.58
        StatusEffectList = 0x0353, // 6.58
        StatusEffectListBozja = 0x0199, // 6.58 (StatusEffectList2)
        StatusEffectListDouble = 0x0305, // 6.58 (BossStatusEffectList)
        StatusEffectListEureka = 0x01F5, // 6.58
        StatusEffectListPlayer = 0x026A, // 6.58 (StatusEffectList3)
        StatusEffectListPlayerDouble = 0x02E8, // 6.58
        SubmarineExplorationResult = 0x02D0, // 6.58
        SubmarineProgressionStatus = 0x0270, // 6.58
        SubmarineStatusList = 0x0275, // 6.58
        SubmarineTimers = 0x0170, // 6.58
        SystemLogMessage = 0x01AF, // 6.58
        SystemLogMessage16 = 0x021D, // 6.58
        SystemLogMessage2 = 0x028D, // 6.58
        SystemLogMessage4 = 0x029E, // 6.58
        SystemLogMessage8 = 0x025D, // 6.58
        Transfer = 0x0329, // 6.58
        TreasureFadeOut = 0x022F, // 6.58
        UnMount = 0x03C4, // 6.58
        UpdateAllianceNormal = 0x03E4, // 6.58
        UpdateAllianceNormalMemberPositions = 0x0390, // 6.58
        UpdateAllianceSmall = 0x01C1, // 6.58
        UpdateAllianceSmallMemberPositions = 0x0277, // 6.58
        UpdateClassInfo = 0x0292, // 6.58
        UpdateClassInfoBozja = 0x031F, // 6.58
        UpdateClassInfoEureka = 0x00DE, // 6.58
        UpdateHate = 0x02D1, // 6.58
        UpdateHater = 0x02F5, // 6.58
        UpdateHpMpTp = 0x02FB, // 6.58
        UpdateInventorySlot = 0x02D3, // 6.58
        UpdateParty = 0x021C, // 6.58
        UpdatePartyMemberPositions = 0x02B6, // 6.58
        UpdateRecastTimes = 0x015A, // 6.58
        UpdateSearchInfo = 0x0212, // 6.58
        WeatherChange = 0x01E8, // 6.58
        YardObjectSpawn = 0x022E, // 6.58
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0107, // 6.58
        ActionRequestGroundTargeted = 0x030F, // 6.58
        ChatHandler = 0x015C, // 6.58
        ClientCountdownInitiate = 0x030B, // 6.58
        ClientTrigger = 0x008D, // 6.58
        InventoryModifyHandler = 0x02C2, // 6.58 (Base offset: 0x02C9)
        LogoutHandler = 0x0321, // 6.58
        MarketBoardPurchaseHandler = 0x0372, // 6.58
        SetSearchInfoHandler = 0x00C5, // 6.58
        UpdatePositionHandler = 0x01EB, // 6.58
        UpdatePositionInstance = 0x02AE, // 6.58
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
