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
        ActorCast = 0x02B5, // 6.51
        ActorControl = 0x02BE, // 6.51
        ActorControlSelf = 0x00B6, // 6.51
        ActorControlTarget = 0x021E, // 6.51
        ActorGauge = 0x02C9, // 6.51
        ActorMove = 0x01E3, // 6.51
        ActorSetPos = 0x02FD, // 6.51
        AirshipExplorationResult = 0x02CC, // 6.51
        AirshipStatus = 0x02B0, // 6.51
        AirshipStatusList = 0x00AD, // 6.51
        AirshipTimers = 0x02A9, // 6.51
        AoeEffect16 = 0x0385, // 6.51
        AoeEffect24 = 0x01D5, // 6.51
        AoeEffect32 = 0x0165, // 6.51
        AoeEffect8 = 0x0168, // 6.51
        ApplyIDScramble = 0x013B, // 6.51
        BalloonTalk2 = 0x0105, // 6.51
        BalloonTalk4 = 0x0073, // 6.51
        BalloonTalk8 = 0x0167, // 6.51
        BattleTalk2 = 0x0282, // 6.51
        BattleTalk4 = 0x009A, // 6.51
        BattleTalk8 = 0x025B, // 6.51
        BlackList = 0x02AE, // 6.51
        CEDirector = 0x01A8, // 6.51
        CeremonySetActorAppearance = 0x0231, // 6.51
        CFCancel = 0x0128, // 6.51
        CFDutyInfo = 0x011A, // 6.51
        CFNotify = 0x0243, // 6.51
        CFPreferredRole = 0x03A1, // 6.51
        CFRegistered = 0x03D7, // 6.51
        CharaNameReq = 0x03C4, // 6.51
        CharaVisualEffect = 0x02EF, // 6.51
        Chat = 0x01F4, // 6.51
        ContainerInfo = 0x0307, // 6.51
        ContentDirectorSync = 0x0301, // 6.51
        Countdown = 0x00BE, // 6.51
        CountdownCancel = 0x03B6, // 6.51
        CreateTreasure = 0x026B, // 6.51
        CrossWorldLinkshellList = 0x00D7, // 6.51
        CurrencyCrystalInfo = 0x00CB, // 6.51
        DailyQuestRepeatFlags = 0x025A, // 6.51
        DailyQuests = 0x03D6, // 6.51
        DespawnCharacter = 0x01C0, // 6.51
        DesynthResult = 0x011F, // 6.51
        DirectorVars = 0x00DC, // 6.51
        Discovery = 0x01BC, // 6.51
        Effect = 0x037A, // 6.51
        EffectResult = 0x00E9, // 6.51
        EffectResult16 = 0x02CA, // 6.51
        EffectResult4 = 0x02A6, // 6.51
        EffectResult8 = 0x008A, // 6.51
        EffectResultBasic = 0x0315, // 6.51
        EffectResultBasic16 = 0x039C, // 6.51
        EffectResultBasic32 = 0x02E5, // 6.51
        EffectResultBasic4 = 0x01EF, // 6.51
        EffectResultBasic64 = 0x0338, // 6.51
        EffectResultBasic8 = 0x014D, // 6.51
        EnvironmentControl = 0x02F1, // 6.51
        EorzeaTimeOffset = 0x0187, // 6.51
        EquipDisplayFlags = 0x0145, // 6.51
        EventContinue = 0x0277, // 6.51
        EventFinish = 0x02D6, // 6.51
        EventPlay = 0x01CD, // 6.51
        EventPlay128 = 0x0156, // 6.51
        EventPlay16 = 0x0236, // 6.51
        EventPlay255 = 0x029E, // 6.51
        EventPlay32 = 0x030B, // 6.51
        EventPlay4 = 0x010E, // 6.51
        EventPlay64 = 0x022A, // 6.51
        EventPlay8 = 0x02FB, // 6.51
        EventStart = 0x0097, // 6.51
        Examine = 0x0340, // 6.51
        ExamineFreeCompanyInfo = 0x0106, // 6.51
        ExamineSearchComment = 0x01FC, // 6.51
        ExamineSearchInfo = 0x037B, // 6.51
        Fall = 0x0119, // 6.51
        FateInfo = 0x027B, // 6.51
        FellowshipList = 0x0113, // 6.51
        FirstAttack = 0x0393, // 6.51
        FreeCompanyDialog = 0x0381, // 6.51
        FreeCompanyInfo = 0x0363, // 6.51
        GCAffiliation = 0x00BC, // 6.51
        HousingEstateGreeting = 0x0175, // 6.51
        HousingIndoorInitialize = 0x023B, // 6.51
        HousingInternalObjectSpawn = 0x00BB, // 6.51
        HousingLandFlags = 0x0211, // 6.51
        HousingObjectDye = 0x00A0, // 6.51
        HousingObjectInitialize = 0x022C, // 6.51
        HousingObjectMove = 0x0239, // 6.51
        HousingShowEstateGuestAccess = 0x0199, // 6.51
        HousingUpdateLandFlagsSlot = 0x00ED, // 6.51
        HousingWardInfo = 0x03D8, // 6.51
        HuntingLogEntry = 0x01E4, // 6.51
        Init = 0x0265, // 6.51
        InitSearchInfo = 0x0173, // 6.51
        InitZone = 0x0375, // 6.51
        InventoryActionAck = 0x0090, // 6.51
        InventoryTransaction = 0x0320, // 6.51
        InventoryTransactionFinish = 0x0275, // 6.51
        IslandWorkshopSupplyDemand = 0x028A, // 6.51
        ItemInfo = 0x0241, // 6.51
        ItemMarketBoardInfo = 0x0160, // 6.51
        LandAvailability = 0x03DD, // 6.51
        LandInfoSign = 0x034F, // 6.51
        LandPriceUpdate = 0x0383, // 6.51
        LandRename = 0x0149, // 6.51
        LandSetInitialize = 0x0248, // 6.51
        LandSetMap = 0x0371, // 6.51
        LandUpdate = 0x0332, // 6.51
        LandUpdateHouseName = 0x0286, // 6.51
        LinkshellList = 0x01CE, // 6.51
        LogMessage = 0x0334, // 6.51
        Logout = 0x00D1, // 6.51
        LootMessage = 0x0214, // 6.51
        MailDeleteRequest = 0x0100, // 6.51
        MapUpdate = 0x0346, // 6.51
        MapUpdate128 = 0x03D0, // 6.51
        MapUpdate16 = 0x0229, // 6.51
        MapUpdate32 = 0x01A1, // 6.51
        MapUpdate4 = 0x0233, // 6.51
        MapUpdate64 = 0x02AF, // 6.51
        MapUpdate8 = 0x00D4, // 6.51
        MarketBoardItemListing = 0x0308, // 6.51
        MarketBoardItemListingCount = 0x00D6, // 6.51
        MarketBoardItemListingHistory = 0x0358, // 6.51
        MarketBoardPurchase = 0x03D2, // 6.51
        MarketBoardSearchResult = 0x02E9, // 6.51
        MiniCactpotInit = 0x03A6, // 6.51
        ModelEquip = 0x031F, // 6.51
        Mount = 0x03D3, // 6.51
        MSQTrackerComplete = 0x0255, // 6.51
        NpcSpawn = 0x0225, // 6.51
        NpcSpawn2 = 0x0114, // 6.51
        NpcYell = 0x02A2, // 6.51
        ObjectDespawn = 0x00C2, // 6.51
        ObjectSpawn = 0x033A, // 6.51
        OpenTreasure = 0x0364, // 6.51
        PartyMessage = 0x00F5, // 6.51
        Ping = 0x0197, // 6.51
        PlaceFieldMarker = 0x016E, // 6.51
        PlaceFieldMarkerPreset = 0x02AC, // 6.51
        PlaceMarker = 0x028E, // 6.51
        PlayerAddedToBlacklist = 0x01B2, // 6.51
        PlayerClassInfo = 0x0076, // 6.51
        PlayerRemovedFromBlacklist = 0x02F8, // 6.51
        PlayerSetup = 0x033B, // 6.51
        PlayerSpawn = 0x01B3, // 6.51
        PlayerStateFlags = 0x00C1, // 6.51
        PlayerStats = 0x0070, // 6.51
        PlayerTitleList = 0x01F9, // 6.51
        PlayerUpdateLook = 0x012A, // 6.51
        PlayMotionSync = 0x015A, // 6.51
        Playtime = 0x0300, // 6.51
        PrepareZoning = 0x03BA, // 6.51
        QuestActiveList = 0x0298, // 6.51
        QuestCompleteList = 0x03E3, // 6.51
        QuestFinish = 0x00A9, // 6.51
        QuestTracker = 0x0380, // 6.51
        QuestUpdate = 0x0198, // 6.51
        ResultDialog = 0x02D1, // 6.51
        RetainerInformation = 0x036D, // 6.51
        RetainerSaleHistory = 0x00B3, // 6.51
        RSFData = 0x0083, // 6.51
        RSVData = 0x032E, // 6.51
        ServerNotice = 0x00E1, // 6.51
        ServerNoticeShort = 0x00B0, // 6.51
        SetOnlineStatus = 0x03CC, // 6.51
        SharedEstateSettingsResponse = 0x0318, // 6.51
        SocialList = 0x026C, // 6.51
        SocialMessage = 0x02DF, // 6.51
        SocialMessage2 = 0x0172, // 6.51
        SocialRequestResponse = 0x016C, // 6.51
        StatusEffectList = 0x00E6, // 6.51
        StatusEffectListBozja = 0x00FD, // 6.51
        StatusEffectListDouble = 0x02E6, // 6.51
        StatusEffectListEureka = 0x0141, // 6.51
        StatusEffectListPlayer = 0x0216, // 6.51
        StatusEffectListPlayerDouble = 0x02A5, // 6.51
        SubmarineExplorationResult = 0x00DB, // 6.51
        SubmarineProgressionStatus = 0x03CA, // 6.51
        SubmarineStatusList = 0x0398, // 6.51
        SubmarineTimers = 0x0230, // 6.51
        SystemLogMessage = 0x02B1, // 6.51
        SystemLogMessage16 = 0x00A7, // 6.51
        SystemLogMessage2 = 0x0206, // 6.51
        SystemLogMessage4 = 0x0166, // 6.51
        SystemLogMessage8 = 0x029D, // 6.51
        Transfer = 0x0123, // 6.51
        TreasureFadeOut = 0x0294, // 6.51
        UnMount = 0x03BC, // 6.51
        UpdateAllianceNormal = 0x01D7, // 6.51
        UpdateAllianceNormalMemberPositions = 0x02E0, // 6.51
        UpdateAllianceSmall = 0x032C, // 6.51
        UpdateAllianceSmallMemberPositions = 0x0252, // 6.51
        UpdateClassInfo = 0x0092, // 6.51
        UpdateClassInfoBozja = 0x03D4, // 6.51
        UpdateClassInfoEureka = 0x0182, // 6.51
        UpdateHate = 0x02A0, // 6.51
        UpdateHater = 0x021D, // 6.51
        UpdateHpMpTp = 0x015B, // 6.51
        UpdateInventorySlot = 0x0336, // 6.51
        UpdateParty = 0x00D2, // 6.51
        UpdatePartyMemberPositions = 0x0382, // 6.51
        UpdateRecastTimes = 0x00A3, // 6.51
        UpdateSearchInfo = 0x0099, // 6.51
        WeatherChange = 0x0129, // 6.51
        YardObjectSpawn = 0x0289, // 6.51
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02A3, // 6.51
        ActionRequestGroundTargeted = 0x02D0, // 6.51
        ChatHandler = 0x008C, // 6.51
        ClientCountdownInitiate = 0x0308, // 6.51
        ClientTrigger = 0x0068, // 6.51
        InventoryModifyHandler = 0x027F, // 6.51 (Base offset: 0x0286)
        LogoutHandler = 0x0260, // 6.51
        MarketBoardPurchaseHandler = 0x0172, // 6.51
        SetSearchInfoHandler = 0x0349, // 6.51
        UpdatePositionHandler = 0x02B8, // 6.51
        UpdatePositionInstance = 0x0274, // 6.51
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
