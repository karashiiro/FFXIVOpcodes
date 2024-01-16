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
        ActorCast = 0x019F, // 6.45
        ActorControl = 0x00E0, // 6.45
        ActorControlSelf = 0x0067, // 6.45
        ActorControlTarget = 0x0216, // 6.45
        ActorGauge = 0x03BE, // 6.45
        ActorMove = 0x0289, // 6.45
        ActorSetPos = 0x00BC, // 6.45
        AirshipExplorationResult = 0x035A, // 6.45
        AirshipStatus = 0x01F3, // 6.45
        AirshipStatusList = 0x0071, // 6.45
        AirshipTimers = 0x009F, // 6.45
        AoeEffect16 = 0x03B5, // 6.45
        AoeEffect24 = 0x008E, // 6.45
        AoeEffect32 = 0x03C4, // 6.45
        AoeEffect8 = 0x025A, // 6.45
        ApplyIDScramble = 0x014A, // 6.45
        BalloonTalk2 = 0x017D, // 6.45
        BalloonTalk4 = 0x00FD, // 6.45
        BalloonTalk8 = 0x00DA, // 6.45
        BattleTalk2 = 0x00F5, // 6.45
        BattleTalk4 = 0x01C6, // 6.45
        BattleTalk8 = 0x02B9, // 6.45
        BlackList = 0x01FB, // 6.45
        CEDirector = 0x021C, // 6.45
        CeremonySetActorAppearance = 0x03CE, // 6.45
        CFCancel = 0x0346, // 6.45
        CFDutyInfo = 0x0379, // 6.45
        CFNotify = 0x01E3, // 6.45
        CFPreferredRole = 0x03E2, // 6.45
        CFRegistered = 0x00E7, // 6.45
        CharaNameReq = 0x00BA, // 6.45
        CharaVisualEffect = 0x0340, // 6.45
        Chat = 0x006B, // 6.45
        ContainerInfo = 0x03E4, // 6.45
        ContentDirectorSync = 0x037C, // 6.45
        Countdown = 0x017A, // 6.45
        CountdownCancel = 0x0360, // 6.45
        CreateTreasure = 0x0381, // 6.45
        CrossWorldLinkshellList = 0x0157, // 6.45
        CurrencyCrystalInfo = 0x01AE, // 6.45
        DailyQuestRepeatFlags = 0x0185, // 6.45
        DailyQuests = 0x0083, // 6.45
        DespawnCharacter = 0x0065, // 6.45
        DespawnObject = 0x0136, // 6.45
        DesynthResult = 0x016B, // 6.45
        DirectorVars = 0x00ED, // 6.45
        Discovery = 0x0345, // 6.45
        Effect = 0x01CB, // 6.45
        EffectResult = 0x00A0, // 6.45
        EffectResult16 = 0x024E, // 6.45
        EffectResult4 = 0x03C0, // 6.45
        EffectResult8 = 0x0264, // 6.45
        EffectResultBasic = 0x0229, // 6.45
        EffectResultBasic16 = 0x0249, // 6.45
        EffectResultBasic32 = 0x02A9, // 6.45
        EffectResultBasic4 = 0x014B, // 6.45
        EffectResultBasic64 = 0x0200, // 6.45
        EffectResultBasic8 = 0x0275, // 6.45
        EnvControl = 0x03D2, // 6.45
        EorzeaTimeOffset = 0x0139, // 6.45
        EquipDisplayFlags = 0x00A3, // 6.45
        EventContinue = 0x02C4, // 6.45
        EventFinish = 0x0119, // 6.45
        EventPlay = 0x03CC, // 6.45
        EventPlay128 = 0x02B1, // 6.45
        EventPlay16 = 0x01CF, // 6.45
        EventPlay255 = 0x00A5, // 6.45
        EventPlay32 = 0x02F1, // 6.45
        EventPlay4 = 0x0258, // 6.45
        EventPlay64 = 0x0195, // 6.45
        EventPlay8 = 0x015C, // 6.45
        EventStart = 0x00E6, // 6.45
        Examine = 0x02E0, // 6.45
        ExamineFreeCompanyInfo = 0x0196, // 6.45
        ExamineSearchComment = 0x03E0, // 6.45
        ExamineSearchInfo = 0x01DB, // 6.45
        Fall = 0x02A4, // 6.45
        FateInfo = 0x02C8, // 6.45
        FellowshipList = 0x0309, // 6.45
        FirstAttack = 0x01B1, // 6.45
        FreeCompanyDialog = 0x035F, // 6.45
        FreeCompanyInfo = 0x007B, // 6.45
        GCAffiliation = 0x0338, // 6.45
        HousingEstateGreeting = 0x006C, // 6.45
        HousingIndoorInitialize = 0x015F, // 6.45
        HousingInternalObjectSpawn = 0x0366, // 6.45
        HousingLandFlags = 0x0178, // 6.45
        HousingObjectDye = 0x0174, // 6.45
        HousingObjectInitialize = 0x01BC, // 6.45
        HousingObjectMove = 0x0238, // 6.45
        HousingShowEstateGuestAccess = 0x00AE, // 6.45
        HousingUpdateLandFlagsSlot = 0x02B2, // 6.45
        HousingWardInfo = 0x03D9, // 6.45
        HuntingLogEntry = 0x01EF, // 6.45
        Init = 0x01D6, // 6.45
        InitSearchInfo = 0x00B4, // 6.45
        InitZone = 0x01B9, // 6.45
        InventoryActionAck = 0x0152, // 6.45
        InventoryTransaction = 0x03C2, // 6.45
        InventoryTransactionFinish = 0x037F, // 6.45
        IslandWorkshopSupplyDemand = 0x00A6, // 6.45
        ItemInfo = 0x0079, // 6.45
        ItemMarketBoardInfo = 0x030B, // 6.45
        LandAvailability = 0x026C, // 6.45
        LandInfoSign = 0x0213, // 6.45
        LandPriceUpdate = 0x0332, // 6.45
        LandRename = 0x01A8, // 6.45
        LandSetInitialize = 0x0331, // 6.45
        LandSetMap = 0x0288, // 6.45
        LandUpdate = 0x019B, // 6.45
        LandUpdateHouseName = 0x02A5, // 6.45
        LogMessage = 0x0116, // 6.45
        Logout = 0x02B3, // 6.45
        LootMessage = 0x0359, // 6.45
        MailDeleteRequest = 0x012F, // 6.45
        MapUpdate = 0x02CF, // 6.45
        MapUpdate128 = 0x032C, // 6.45
        MapUpdate16 = 0x023C, // 6.45
        MapUpdate32 = 0x0107, // 6.45
        MapUpdate4 = 0x01DC, // 6.45
        MapUpdate64 = 0x0109, // 6.45
        MapUpdate8 = 0x008D, // 6.45
        MarketBoardItemListing = 0x024C, // 6.45
        MarketBoardItemListingCount = 0x00D4, // 6.45
        MarketBoardItemListingHistory = 0x00A1, // 6.45
        MarketBoardPurchase = 0x03AC, // 6.45
        MarketBoardSearchResult = 0x0397, // 6.45
        MiniCactpotInit = 0x03CF, // 6.45
        ModelEquip = 0x009D, // 6.45
        Mount = 0x0203, // 6.45
        MSQTrackerComplete = 0x026D, // 6.45
        NpcSpawn = 0x008F, // 6.45
        NpcSpawn2 = 0x0097, // 6.45
        NpcYell = 0x0271, // 6.45
        ObjectSpawn = 0x0237, // 6.45
        OpenTreasure = 0x0296, // 6.45
        PartyMessage = 0x03D8, // 6.45
        Ping = 0x01E9, // 6.45
        PlaceFieldMarker = 0x026A, // 6.45
        PlaceFieldMarkerPreset = 0x01D4, // 6.45
        PlaceMarker = 0x0291, // 6.45
        PlayerAddedToBlacklist = 0x02D5, // 6.45
        PlayerClassInfo = 0x02F6, // 6.45
        PlayerRemovedFromBlacklist = 0x01ED, // 6.45
        PlayerSetup = 0x00FC, // 6.45
        PlayerSpawn = 0x0201, // 6.45
        PlayerStateFlags = 0x013D, // 6.45
        PlayerStats = 0x024D, // 6.45
        PlayerTitleList = 0x0239, // 6.45
        PlayerUpdateLook = 0x0321, // 6.45
        PlayMotionSync = 0x03B8, // 6.45
        Playtime = 0x0092, // 6.45
        PrepareZoning = 0x0155, // 6.45
        QuestActiveList = 0x022B, // 6.45
        QuestCompleteList = 0x02A3, // 6.45
        QuestFinish = 0x0283, // 6.45
        QuestTracker = 0x013E, // 6.45
        QuestUpdate = 0x015E, // 6.45
        ResultDialog = 0x03B2, // 6.45
        RetainerInformation = 0x0211, // 6.45
        RetainerSaleHistory = 0x0146, // 6.45
        RSFData = 0x0078, // 6.45
        RSVData = 0x00A8, // 6.45
        ServerNotice = 0x030D, // 6.45
        ServerNoticeShort = 0x00AD, // 6.45
        SetOnlineStatus = 0x0268, // 6.45
        SharedEstateSettingsResponse = 0x0076, // 6.45
        SocialList = 0x01B2, // 6.45
        SocialMessage = 0x00EF, // 6.45
        SocialMessage2 = 0x0297, // 6.45
        SocialRequestResponse = 0x01D5, // 6.45
        StatusEffectList = 0x0086, // 6.45
        StatusEffectListBozja = 0x0273, // 6.45
        StatusEffectListDouble = 0x0088, // 6.45
        StatusEffectListEureka = 0x036C, // 6.45
        StatusEffectListPlayer = 0x026B, // 6.45
        SubmarineExplorationResult = 0x0212, // 6.45
        SubmarineProgressionStatus = 0x0124, // 6.45
        SubmarineStatusList = 0x03D6, // 6.45
        SubmarineTimers = 0x02F4, // 6.45
        SystemLogMessage = 0x01F6, // 6.45
        SystemLogMessage16 = 0x0374, // 6.45
        SystemLogMessage2 = 0x0380, // 6.45
        SystemLogMessage4 = 0x033F, // 6.45
        SystemLogMessage8 = 0x008A, // 6.45
        Transfer = 0x0341, // 6.45
        TreasureFadeOut = 0x0217, // 6.45
        UnMount = 0x03E1, // 6.45
        UpdateAllianceNormal = 0x02C3, // 6.45
        UpdateAllianceNormalMemberPositions = 0x02D4, // 6.45
        UpdateAllianceSmall = 0x029C, // 6.45
        UpdateAllianceSmallMemberPositions = 0x03C5, // 6.45
        UpdateClassInfo = 0x00DE, // 6.45
        UpdateClassInfoBozja = 0x0140, // 6.45
        UpdateClassInfoEureka = 0x0333, // 6.45
        UpdateHate = 0x021F, // 6.45
        UpdateHater = 0x02DF, // 6.45
        UpdateHpMpTp = 0x02A8, // 6.45
        UpdateInventorySlot = 0x011D, // 6.45
        UpdateParty = 0x037B, // 6.45
        UpdatePartyMemberPositions = 0x01A0, // 6.45
        UpdateRecastTimes = 0x03C8, // 6.45
        UpdateSearchInfo = 0x02EC, // 6.45
        WeatherChange = 0x01BD, // 6.45
        YardObjectSpawn = 0x03D4, // 6.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x020A, // 6.45
        ClientTrigger = 0x031C, // 6.45
        InventoryModifyHandler = 0x03BA, // 6.45 (Base offset: 0x03C1)
        LogoutHandler = 0x03AE, // 6.45
        MarketBoardPurchaseHandler = 0x00EF, // 6.45
        SetSearchInfoHandler = 0x0177, // 6.45
        UpdatePositionHandler = 0x0245, // 6.45
        UpdatePositionInstance = 0x029D, // 6.45
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
