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
        ActionEffect = 0x0305, // 6.401
        ActionEffect16 = 0x01DB, // 6.401
        ActionEffect24 = 0x011C, // 6.401
        ActionEffect32 = 0x011B, // 6.401
        ActionEffect8 = 0x01C8, // 6.401
        ActorCast = 0x02DE, // 6.401
        ActorControl = 0x020D, // 6.401
        ActorControlSelf = 0x035B, // 6.401
        ActorControlTarget = 0x01A8, // 6.401
        ActorGauge = 0x0102, // 6.401
        ActorMove = 0x02AB, // 6.401
        ActorSetPos = 0x0190, // 6.401
        AirshipExplorationResult = 0x01FB, // 6.401
        AirshipStatus = 0x00DC, // 6.401
        AirshipStatusList = 0x00AC, // 6.401
        AirshipTimers = 0x0364, // 6.401
        ApplyIDScramble = 0x011F, // 6.401
        BalloonTalk2 = 0x0220, // 6.401
        BalloonTalk4 = 0x0215, // 6.401
        BalloonTalk8 = 0x010A, // 6.401
        BattleTalk2 = 0x032B, // 6.401
        BattleTalk4 = 0x00AF, // 6.401
        BattleTalk8 = 0x00C6, // 6.401
        BlackList = 0x01E5, // 6.401
        CEDirector = 0x0082, // 6.401
        CeremonySetActorAppearance = 0x033D, // 6.401
        CFCancel = 0x02CF, // 6.401
        CFDutyInfo = 0x020C, // 6.401
        CFNotify = 0x033C, // 6.401
        CFPreferredRole = 0x00CF, // 6.401
        CFRegistered = 0x013F, // 6.401
        CharaNameReq = 0x0134, // 6.401
        CharaVisualEffect = 0x0203, // 6.401
        Chat = 0x01F5, // 6.401
        ContainerInfo = 0x010B, // 6.401
        ContentDirectorSync = 0x00D1, // 6.401
        Countdown = 0x0358, // 6.401
        CountdownCancel = 0x012E, // 6.401
        CreateTreasure = 0x03B9, // 6.401
        CrossWorldLinkshellList = 0x03B4, // 6.401
        CurrencyCrystalInfo = 0x01A4, // 6.401
        DailyQuestRepeatFlags = 0x00BB, // 6.401
        DailyQuests = 0x03C7, // 6.401
        DespawnCharacter = 0x00A9, // 6.401
        DespawnObject = 0x036E, // 6.401
        DesynthResult = 0x024F, // 6.401
        DirectorVars = 0x0148, // 6.401
        Discovery = 0x032A, // 6.401
        EffectResult = 0x013A, // 6.401
        EffectResult16 = 0x00A2, // 6.401
        EffectResult4 = 0x0133, // 6.401
        EffectResult8 = 0x02A2, // 6.401
        EffectResultBasic = 0x03A1, // 6.401
        EffectResultBasic16 = 0x0109, // 6.401
        EffectResultBasic32 = 0x0340, // 6.401
        EffectResultBasic4 = 0x02C8, // 6.401
        EffectResultBasic64 = 0x00A8, // 6.401
        EffectResultBasic8 = 0x0223, // 6.401
        EnvControl = 0x00D9, // 6.401
        EorzeaTimeOffset = 0x0251, // 6.401
        EquipDisplayFlags = 0x03C2, // 6.401
        EventContinue = 0x0378, // 6.401
        EventFinish = 0x02F2, // 6.401
        EventPlay = 0x03BA, // 6.401
        EventPlay128 = 0x028E, // 6.401
        EventPlay16 = 0x03B7, // 6.401
        EventPlay255 = 0x0380, // 6.401
        EventPlay32 = 0x008B, // 6.401
        EventPlay4 = 0x01D3, // 6.401
        EventPlay64 = 0x0335, // 6.401
        EventPlay8 = 0x011A, // 6.401
        EventStart = 0x013C, // 6.401
        Examine = 0x0298, // 6.401
        ExamineFreeCompanyInfo = 0x01FC, // 6.401
        ExamineSearchComment = 0x018D, // 6.401
        ExamineSearchInfo = 0x0121, // 6.401
        Fall = 0x02C2, // 6.401
        FateInfo = 0x02ED, // 6.401
        FellowshipList = 0x016B, // 6.401
        FirstAttack = 0x0297, // 6.401
        FreeCompanyDialog = 0x0132, // 6.401
        FreeCompanyInfo = 0x03AE, // 6.401
        GCAffiliation = 0x024E, // 6.401
        HousingEstateGreeting = 0x0292, // 6.401
        HousingIndoorInitialize = 0x015E, // 6.401
        HousingInternalObjectSpawn = 0x01D0, // 6.401
        HousingLandFlags = 0x03C9, // 6.401
        HousingObjectDye = 0x03B1, // 6.401
        HousingObjectInitialize = 0x034F, // 6.401
        HousingObjectMove = 0x0326, // 6.401
        HousingShowEstateGuestAccess = 0x0230, // 6.401
        HousingUpdateLandFlagsSlot = 0x00BF, // 6.401
        HousingWardInfo = 0x0239, // 6.401
        HuntingLogEntry = 0x0240, // 6.401
        Init = 0x02C1, // 6.401
        InitSearchInfo = 0x025B, // 6.401
        InitZone = 0x0316, // 6.401
        InventoryActionAck = 0x02F7, // 6.401
        InventoryTransaction = 0x0216, // 6.401
        InventoryTransactionFinish = 0x0116, // 6.401
        IslandWorkshopSupplyDemand = 0x01D2, // 6.401
        ItemInfo = 0x010C, // 6.401
        ItemMarketBoardInfo = 0x0336, // 6.401
        LandAvailability = 0x038E, // 6.401
        LandInfoSign = 0x03E6, // 6.401
        LandPriceUpdate = 0x00A1, // 6.401
        LandRename = 0x006A, // 6.401
        LandSetInitialize = 0x0256, // 6.401
        LandSetMap = 0x02B2, // 6.401
        LandUpdate = 0x0171, // 6.401
        LandUpdateHouseName = 0x01FD, // 6.401
        LinkshellList = 0x02A1, // 6.401
        LogMessage = 0x012D, // 6.401
        Logout = 0x0367, // 6.401
        LootMessage = 0x01AE, // 6.401
        MailDeleteRequest = 0x035F, // 6.401
        MapUpdate = 0x025C, // 6.401
        MapUpdate128 = 0x0130, // 6.401
        MapUpdate16 = 0x039A, // 6.401
        MapUpdate32 = 0x0379, // 6.401
        MapUpdate4 = 0x03E5, // 6.401
        MapUpdate64 = 0x00E3, // 6.401
        MapUpdate8 = 0x02A9, // 6.401
        MarketBoardItemListing = 0x0318, // 6.401
        MarketBoardItemListingCount = 0x0390, // 6.401
        MarketBoardItemListingHistory = 0x02F6, // 6.401
        MarketBoardPurchase = 0x0127, // 6.401
        MarketBoardSearchResult = 0x02B5, // 6.401
        MiniCactpotInit = 0x024B, // 6.401
        ModelEquip = 0x0272, // 6.401
        Mount = 0x01C5, // 6.401
        MSQTrackerComplete = 0x0267, // 6.401
        NpcSpawn = 0x03C8, // 6.401
        NpcSpawn2 = 0x02D1, // 6.401
        NpcYell = 0x02BE, // 6.401
        ObjectSpawn = 0x0128, // 6.401
        OpenTreasure = 0x01CC, // 6.401
        PartyMessage = 0x03DF, // 6.401
        Ping = 0x0141, // 6.401
        PlaceFieldMarker = 0x0271, // 6.401
        PlaceFieldMarkerPreset = 0x03DB, // 6.401
        PlaceMarker = 0x028D, // 6.401
        PlayerAddedToBlacklist = 0x0147, // 6.401
        PlayerClassInfo = 0x0322, // 6.401
        PlayerRemovedFromBlacklist = 0x01A6, // 6.401
        PlayerSetup = 0x0175, // 6.401
        PlayerSpawn = 0x032F, // 6.401
        PlayerStateFlags = 0x0225, // 6.401
        PlayerStats = 0x00CE, // 6.401
        PlayerTitleList = 0x02C5, // 6.401
        PlayerUpdateLook = 0x02FA, // 6.401
        PlayMotionSync = 0x01B6, // 6.401
        Playtime = 0x0195, // 6.401
        PrepareZoning = 0x017C, // 6.401
        QuestActiveList = 0x021A, // 6.401
        QuestCompleteList = 0x00B1, // 6.401
        QuestFinish = 0x029C, // 6.401
        QuestTracker = 0x0290, // 6.401
        QuestUpdate = 0x0111, // 6.401
        ResultDialog = 0x0229, // 6.401
        RetainerInformation = 0x00AE, // 6.401
        RetainerSaleHistory = 0x0270, // 6.401
        RSFData = 0x039C, // 6.401
        RSVData = 0x00C7, // 6.401
        ServerNotice = 0x034D, // 6.401
        ServerNoticeShort = 0x02C3, // 6.401
        SetOnlineStatus = 0x013E, // 6.401
        SharedEstateSettingsResponse = 0x020F, // 6.401
        SocialList = 0x03C0, // 6.401
        SocialMessage = 0x0359, // 6.401
        SocialMessage2 = 0x031F, // 6.401
        SocialRequestResponse = 0x02AF, // 6.401
        StatusEffectList = 0x03AA, // 6.401
        StatusEffectListBozja = 0x02D5, // 6.401
        StatusEffectListDouble = 0x022A, // 6.401
        StatusEffectListEureka = 0x0257, // 6.401
        StatusEffectListPlayer = 0x014F, // 6.401
        SubmarineExplorationResult = 0x01E4, // 6.401
        SubmarineProgressionStatus = 0x00B5, // 6.401
        SubmarineStatusList = 0x02A7, // 6.401
        SubmarineTimers = 0x0345, // 6.401
        SystemLogMessage = 0x03CF, // 6.401
        SystemLogMessage16 = 0x0285, // 6.401
        SystemLogMessage2 = 0x0194, // 6.401
        SystemLogMessage4 = 0x01E3, // 6.401
        SystemLogMessage8 = 0x039F, // 6.401
        Transfer = 0x0346, // 6.401
        TreasureFadeOut = 0x01C7, // 6.401
        UnMount = 0x0373, // 6.401
        UpdateAllianceNormal = 0x0086, // 6.401
        UpdateAllianceNormalMemberPositions = 0x02FE, // 6.401
        UpdateAllianceSmall = 0x0155, // 6.401
        UpdateAllianceSmallMemberPositions = 0x03A8, // 6.401
        UpdateClassInfo = 0x00A5, // 6.401
        UpdateClassInfoBozja = 0x03C3, // 6.401
        UpdateClassInfoEureka = 0x0294, // 6.401
        UpdateHate = 0x0200, // 6.401
        UpdateHater = 0x02F3, // 6.401
        UpdateHpMpTp = 0x00FA, // 6.401
        UpdateInventorySlot = 0x00C4, // 6.401
        UpdateParty = 0x00EB, // 6.401
        UpdatePartyMemberPositions = 0x0207, // 6.401
        UpdateRecastTimes = 0x00D2, // 6.401
        UpdateSearchInfo = 0x026C, // 6.401
        WeatherChange = 0x023C, // 6.401
        YardObjectSpawn = 0x03D0, // 6.401
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x028B, // 6.401
        ClientTrigger = 0x00F3, // 6.401
        InventoryModifyHandler = 0x0319, // 6.401
        // LogoutHandler = 0x0199, // 6.35
        MarketBoardPurchaseHandler = 0x0359, // 6.401
        SetSearchInfoHandler = 0x00A3, // 6.401
        UpdatePositionHandler = 0x0280, // 6.401
        UpdatePositionInstance = 0x01F7, // 6.401
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
