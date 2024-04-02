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
        ActorCast = 0x0242, // 6.5
        ActorControl = 0x00CE, // 6.5
        ActorControlSelf = 0x0074, // 6.5
        ActorControlTarget = 0x0100, // 6.5
        ActorGauge = 0x0280, // 6.5
        ActorMove = 0x02A7, // 6.5
        ActorSetPos = 0x0188, // 6.5
        AirshipExplorationResult = 0x00E3, // 6.5
        AirshipStatus = 0x02D9, // 6.5
        AirshipStatusList = 0x02EA, // 6.5
        AirshipTimers = 0x0261, // 6.5
        AoeEffect16 = 0x00E1, // 6.5
        AoeEffect24 = 0x028D, // 6.5
        AoeEffect32 = 0x0265, // 6.5
        AoeEffect8 = 0x02ED, // 6.5
        ApplyIDScramble = 0x006D, // 6.5
        BalloonTalk2 = 0x0108, // 6.5
        BalloonTalk4 = 0x03D5, // 6.5
        BalloonTalk8 = 0x0070, // 6.5
        BattleTalk2 = 0x02A2, // 6.5
        BattleTalk4 = 0x0343, // 6.5
        BattleTalk8 = 0x01AD, // 6.5
        BlackList = 0x0387, // 6.5
        CEDirector = 0x0393, // 6.5
        CeremonySetActorAppearance = 0x0166, // 6.5
        CFCancel = 0x01FD, // 6.5
        CFDutyInfo = 0x033D, // 6.5
        CFNotify = 0x016F, // 6.5
        CFPreferredRole = 0x00DF, // 6.5
        CFRegistered = 0x03D3, // 6.5
        CharaNameReq = 0x0182, // 6.5
        CharaVisualEffect = 0x02B7, // 6.5
        Chat = 0x0351, // 6.5
        ContainerInfo = 0x01B3, // 6.5
        ContentDirectorSync = 0x0397, // 6.5
        Countdown = 0x00D8, // 6.5
        CountdownCancel = 0x0140, // 6.5
        CreateTreasure = 0x01C1, // 6.5
        CrossWorldLinkshellList = 0x0089, // 6.5
        CurrencyCrystalInfo = 0x01FE, // 6.5
        DailyQuestRepeatFlags = 0x03AC, // 6.5
        DailyQuests = 0x0174, // 6.5
        DespawnCharacter = 0x007B, // 6.5
        DesynthResult = 0x02AC, // 6.5
        DirectorVars = 0x0392, // 6.5
        Discovery = 0x0391, // 6.5
        Effect = 0x0320, // 6.5
        EffectResult = 0x027B, // 6.5
        EffectResult16 = 0x03CC, // 6.5
        EffectResult4 = 0x0311, // 6.5
        EffectResult8 = 0x0086, // 6.5
        EffectResultBasic = 0x0073, // 6.5
        EffectResultBasic16 = 0x009E, // 6.5
        EffectResultBasic32 = 0x021F, // 6.5
        EffectResultBasic4 = 0x01B8, // 6.5
        EffectResultBasic64 = 0x00CA, // 6.5
        EffectResultBasic8 = 0x0347, // 6.5
        EnvironmentControl = 0x00CD, // 6.5
        EorzeaTimeOffset = 0x0357, // 6.5
        EquipDisplayFlags = 0x00D3, // 6.5
        EventContinue = 0x03B6, // 6.5
        EventFinish = 0x00A6, // 6.5
        EventPlay = 0x025B, // 6.5
        EventPlay128 = 0x0346, // 6.5
        EventPlay16 = 0x0305, // 6.5
        EventPlay255 = 0x01DD, // 6.5
        EventPlay32 = 0x0145, // 6.5
        EventPlay4 = 0x01A6, // 6.5
        EventPlay64 = 0x0201, // 6.5
        EventPlay8 = 0x0298, // 6.5
        EventStart = 0x01A0, // 6.5
        Examine = 0x01E0, // 6.5
        ExamineFreeCompanyInfo = 0x03B3, // 6.5
        ExamineSearchComment = 0x00FD, // 6.5
        ExamineSearchInfo = 0x031F, // 6.5
        Fall = 0x01DE, // 6.5
        FateInfo = 0x0095, // 6.5
        FellowshipList = 0x02A8, // 6.5
        FirstAttack = 0x016B, // 6.5
        FreeCompanyDialog = 0x02E8, // 6.5
        FreeCompanyInfo = 0x015A, // 6.5
        GCAffiliation = 0x0381, // 6.5
        HousingEstateGreeting = 0x02F6, // 6.5
        HousingIndoorInitialize = 0x012D, // 6.5
        HousingInternalObjectSpawn = 0x012C, // 6.5
        HousingLandFlags = 0x01CD, // 6.5
        HousingObjectDye = 0x00EE, // 6.5
        HousingObjectInitialize = 0x0288, // 6.5
        HousingObjectMove = 0x00F3, // 6.5
        HousingShowEstateGuestAccess = 0x00EB, // 6.5
        HousingUpdateLandFlagsSlot = 0x01D0, // 6.5
        HousingWardInfo = 0x00D1, // 6.5
        HuntingLogEntry = 0x028E, // 6.5
        Init = 0x012B, // 6.5
        InitSearchInfo = 0x0119, // 6.5
        InitZone = 0x037C, // 6.5
        InventoryActionAck = 0x0204, // 6.5
        InventoryTransaction = 0x01E3, // 6.5
        InventoryTransactionFinish = 0x009A, // 6.5
        IslandWorkshopSupplyDemand = 0x03B5, // 6.5
        ItemInfo = 0x033B, // 6.5
        ItemMarketBoardInfo = 0x02D4, // 6.5
        LandAvailability = 0x00EF, // 6.5
        LandInfoSign = 0x02DA, // 6.5
        LandPriceUpdate = 0x0068, // 6.5
        LandRename = 0x01D8, // 6.5
        LandSetInitialize = 0x02C6, // 6.5
        LandSetMap = 0x029D, // 6.5
        LandUpdate = 0x01D7, // 6.5
        LandUpdateHouseName = 0x0067, // 6.5
        LinkshellList = 0x0097, // 6.5
        LogMessage = 0x0360, // 6.5
        Logout = 0x01F8, // 6.5
        LootMessage = 0x02BC, // 6.5
        MailDeleteRequest = 0x0120, // 6.5
        MapUpdate = 0x0302, // 6.5
        MapUpdate128 = 0x0146, // 6.5
        MapUpdate16 = 0x0081, // 6.5
        MapUpdate32 = 0x00E2, // 6.5
        MapUpdate4 = 0x02D7, // 6.5
        MapUpdate64 = 0x01C0, // 6.5
        MapUpdate8 = 0x038A, // 6.5
        MarketBoardItemListing = 0x01BA, // 6.5
        MarketBoardItemListingCount = 0x0299, // 6.5
        MarketBoardItemListingHistory = 0x018E, // 6.5
        MarketBoardPurchase = 0x01F7, // 6.5
        MarketBoardSearchResult = 0x00FA, // 6.5
        MiniCactpotInit = 0x03AB, // 6.5
        ModelEquip = 0x008B, // 6.5
        Mount = 0x03C6, // 6.5
        MSQTrackerComplete = 0x00E0, // 6.5
        NpcSpawn = 0x0313, // 6.5
        NpcSpawn2 = 0x0300, // 6.5
        NpcYell = 0x0088, // 6.5
        ObjectDespawn = 0x03D6, // 6.5
        ObjectSpawn = 0x0181, // 6.5
        OpenTreasure = 0x03E3, // 6.5
        PartyMessage = 0x02C5, // 6.5
        Ping = 0x03BB, // 6.5
        PlaceFieldMarker = 0x0255, // 6.5
        PlaceFieldMarkerPreset = 0x01A2, // 6.5
        PlaceMarker = 0x02AA, // 6.5
        PlayerAddedToBlacklist = 0x0183, // 6.5
        PlayerClassInfo = 0x01B6, // 6.5
        PlayerRemovedFromBlacklist = 0x032A, // 6.5
        PlayerSetup = 0x00BB, // 6.5
        PlayerSpawn = 0x023A, // 6.5
        PlayerStateFlags = 0x029E, // 6.5
        PlayerStats = 0x0090, // 6.5
        PlayerTitleList = 0x012E, // 6.5
        PlayerUpdateLook = 0x0262, // 6.5
        PlayMotionSync = 0x039F, // 6.5
        Playtime = 0x027F, // 6.5
        PrepareZoning = 0x015C, // 6.5
        QuestActiveList = 0x0162, // 6.5
        QuestCompleteList = 0x0069, // 6.5
        QuestFinish = 0x03C3, // 6.5
        QuestTracker = 0x0318, // 6.5
        QuestUpdate = 0x00A4, // 6.5
        ResultDialog = 0x0171, // 6.5
        RetainerInformation = 0x01A5, // 6.5
        RetainerSaleHistory = 0x0155, // 6.5
        RSFData = 0x01AB, // 6.5
        RSVData = 0x01CF, // 6.5
        ServerNotice = 0x00F2, // 6.5
        ServerNoticeShort = 0x0284, // 6.5
        SetOnlineStatus = 0x016C, // 6.5
        SharedEstateSettingsResponse = 0x01B1, // 6.5
        SocialList = 0x0368, // 6.5
        SocialMessage = 0x00FC, // 6.5
        SocialMessage2 = 0x00AA, // 6.5
        SocialRequestResponse = 0x0136, // 6.5
        StatusEffectList = 0x0379, // 6.5
        StatusEffectListBozja = 0x006E, // 6.5
        StatusEffectListDouble = 0x0376, // 6.5
        StatusEffectListEureka = 0x009C, // 6.5
        StatusEffectListPlayer = 0x0107, // 6.5
        StatusEffectListPlayerDouble = 0x0238, // 6.5
        SubmarineExplorationResult = 0x0126, // 6.5
        SubmarineProgressionStatus = 0x0319, // 6.5
        SubmarineStatusList = 0x03A0, // 6.5
        SubmarineTimers = 0x03C8, // 6.5
        SystemLogMessage = 0x024B, // 6.5
        SystemLogMessage16 = 0x01C8, // 6.5
        SystemLogMessage2 = 0x03B9, // 6.5
        SystemLogMessage4 = 0x02C3, // 6.5
        SystemLogMessage8 = 0x03BD, // 6.5
        Transfer = 0x0336, // 6.5
        TreasureFadeOut = 0x013E, // 6.5
        UnMount = 0x03CD, // 6.5
        UpdateAllianceNormal = 0x0206, // 6.5
        UpdateAllianceNormalMemberPositions = 0x02FA, // 6.5
        UpdateAllianceSmall = 0x0244, // 6.5
        UpdateAllianceSmallMemberPositions = 0x00D6, // 6.5
        UpdateClassInfo = 0x007E, // 6.5
        UpdateClassInfoBozja = 0x0389, // 6.5
        UpdateClassInfoEureka = 0x03DA, // 6.5
        UpdateHate = 0x02C8, // 6.5
        UpdateHater = 0x0256, // 6.5
        UpdateHpMpTp = 0x02CB, // 6.5
        UpdateInventorySlot = 0x0221, // 6.5
        UpdateParty = 0x02B9, // 6.5
        UpdatePartyMemberPositions = 0x0322, // 6.5
        UpdateRecastTimes = 0x0384, // 6.5
        UpdateSearchInfo = 0x009D, // 6.5
        WeatherChange = 0x01A4, // 6.5
        YardObjectSpawn = 0x010C, // 6.5
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x02FC, // 6.5
        ClientTrigger = 0x0175, // 6.5
        InventoryModifyHandler = 0x02A5, // 6.5 (Base offset: 0x02AC)
        LogoutHandler = 0x0122, // 6.5
        MarketBoardPurchaseHandler = 0x00AA, // 6.5
        SetSearchInfoHandler = 0x02D2, // 6.5
        UpdatePositionHandler = 0x0358, // 6.5
        UpdatePositionInstance = 0x00C3, // 6.5
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
