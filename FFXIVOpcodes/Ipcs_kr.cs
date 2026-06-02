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
        Init = 0x0080, // 7.51
        Logout = 0x0315, // 7.51
        CFCancel = 0x0385, // 7.51
        CFDutyInfo = 0x00E3, // 7.51
        CFNotify = 0x02F2, // 7.51
        CFPreferredRole = 0x01F3, // 7.51
        PartyFinderList = 0x029D, // 7.51
        CFRegistered = 0x0195, // 7.51
        Playtime = 0x0174, // 7.51
        RSVData = 0x020B, // 7.51
        RSFData = 0x0234, // 7.51
        SocialMessage = 0x00E0, // 7.51
        SocialMessage2 = 0x036D, // 7.51
        SocialList = 0x0302, // 7.51
        SocialRequestResponse = 0x0321, // 7.51
        ExamineSearchInfo = 0x00E1, // 7.51
        UpdateSearchInfo = 0x0352, // 7.51
        InitSearchInfo = 0x033B, // 7.51
        ServerNoticeShort = 0x00B6, // 7.51
        ServerNotice = 0x0294, // 7.51
        SetOnlineStatus = 0x02BC, // 7.51
        LogMessage = 0x03BA, // 7.51
        Countdown = 0x0248, // 7.51
        CountdownCancel = 0x008F, // 7.51
        PartyMessage = 0x03B1, // 7.51
        PlayerAddedToBlacklist = 0x0221, // 7.51
        PlayerRemovedFromBlacklist = 0x0299, // 7.51
        BlackList = 0x01C1, // 7.51
        MarketBoardItemListingCount = 0x0287, // 7.51
        MarketBoardItemListing = 0x0244, // 7.51
        PlayerRetainerInfo = 0x009B, // 7.51
        MarketBoardPurchase = 0x00B7, // 7.51
        MarketBoardSale = 0x018E, // 7.51
        MarketBoardItemListingHistory = 0x0113, // 7.51
        RetainerSaleHistory = 0x036A, // 7.51
        RetainerState = 0x02E9, // 7.51
        MarketBoardSearchResult = 0x0262, // 7.51
        FreeCompanyInfo = 0x0347, // 7.51
        ExamineFreeCompanyInfo = 0x01CF, // 7.51
        FreeCompanyDialog = 0x0320, // 7.51
        StatusEffectList = 0x0295, // 7.51
        StatusEffectListEureka = 0x00C1, // 7.51
        StatusEffectListBozja = 0x02AF, // 7.51
        StatusEffectListOccult = 0x0076, // 7.51
        StatusEffectListDouble = 0x0346, // 7.51
        EffectResult = 0x00D7, // 7.51
        EffectResult4 = 0x00E5, // 7.51
        EffectResult8 = 0x02A9, // 7.51
        EffectResult16 = 0x03CA, // 7.51
        EffectResultBasic = 0x0254, // 7.51
        EffectResultBasic4 = 0x01A9, // 7.51
        EffectResultBasic8 = 0x0070, // 7.51
        EffectResultBasic16 = 0x00D0, // 7.51
        EffectResultBasic32 = 0x0094, // 7.51
        EffectResultBasic64 = 0x0189, // 7.51
        ActorControl = 0x01E8, // 7.51
        ActorControlSelf = 0x01C9, // 7.51
        ActorControlTarget = 0x027D, // 7.51
        UpdateHpMpTp = 0x00DE, // 7.51
        Effect = 0x0393, // 7.51
        AoeEffect8 = 0x00D3, // 7.51
        AoeEffect16 = 0x00A7, // 7.51
        AoeEffect24 = 0x0147, // 7.51
        AoeEffect32 = 0x03D1, // 7.51
        StatusEffectListPlayer = 0x0138, // 7.51
        StatusEffectListPlayerDouble = 0x01DD, // 7.51
        UpdateRecastTimes = 0x0140, // 7.51
        UpdateDutyRecastTimes = 0x0144, // 7.51
        UpdateDutyRecastTimes5 = 0x0107, // 7.51
        UpdateAllianceNormal = 0x0103, // 7.51
        UpdateAllianceSmall = 0x025C, // 7.51
        UpdatePartyMemberPositions = 0x01E2, // 7.51
        UpdateAllianceNormalMemberPositions = 0x01DC, // 7.51
        UpdateAllianceSmallMemberPositions = 0x01A6, // 7.51
        GCAffiliation = 0x0237, // 7.51
        GatheringLog = 0x00AC, // 7.51
        CraftingLog = 0x03D3, // 7.51
        PlayerSpawn = 0x0255, // 7.51
        NpcSpawn = 0x026B, // 7.51
        BossSpawn = 0x0242, // 7.51
        DespawnCharacter = 0x02DD, // 7.51
        ActorMove = 0x03B6, // 7.51
        ActorSetPos = 0x028F, // 7.51
        ActorCast = 0x02F6, // 7.51
        InitZone = 0x0096, // 7.51
        UpdateHate = 0x0303, // 7.51
        UpdateHater = 0x0130, // 7.51
        ObjectSpawn = 0x01B5, // 7.51
        ObjectDespawn = 0x008D, // 7.51
        UpdateClassInfo = 0x007D, // 7.51
        UpdateClassInfoEureka = 0x03E5, // 7.51
        UpdateClassInfoBozja = 0x01A5, // 7.51
        UpdateClassInfoOccult = 0x01B4, // 7.51
        PlayerSetup = 0x023F, // 7.51
        PlayerStats = 0x02DB, // 7.51
        FirstAttack = 0x033D, // 7.51
        PlayerStateFlags = 0x0296, // 7.51
        PlayerClassInfo = 0x0344, // 7.51
        PlayerBlueMageActions = 0x015D, // 7.51
        ModelEquip = 0x0127, // 7.51
        Examine = 0x03A2, // 7.51
        RetainerSummary = 0x0228, // 7.51
        RetainerInformation = 0x010E, // 7.51
        ItemMarketBoardSummary = 0x01DA, // 7.51
        ItemMarketBoardInfo = 0x0214, // 7.51
        ItemInfo = 0x033E, // 7.51
        ContainerInfo = 0x03B0, // 7.51
        InventoryTransactionFinish = 0x03AA, // 7.51
        InventoryTransaction = 0x028E, // 7.51
        CurrencyCrystalInfo = 0x036C, // 7.51
        InventoryActionAck = 0x0391, // 7.51
        UpdateInventorySlot = 0x01B0, // 7.51
        EventPlay = 0x007E, // 7.51
        EventPlay4 = 0x0243, // 7.51
        EventPlay8 = 0x0280, // 7.51
        EventPlay16 = 0x00BF, // 7.51
        EventPlay32 = 0x00F4, // 7.51
        EventPlay64 = 0x0099, // 7.51
        EventPlay128 = 0x0098, // 7.51
        EventPlay255 = 0x0293, // 7.51
        EventStart = 0x0251, // 7.51
        EventFinish = 0x02CB, // 7.51
        ResultDialog = 0x00D5, // 7.51
        DesynthResult = 0x0069, // 7.51
        MiniCactpotInit = 0x030C, // 7.51
        EnvironmentControl = 0x03B7, // 7.51
        EnvironmentControl4 = 0x023D, // 7.51
        EnvironmentControl8 = 0x0241, // 7.51
        EnvironmentControl12 = 0x0073, // 7.51
        SystemLogMessage = 0x00FA, // 7.51
        SystemLogMessage2 = 0x0394, // 7.51
        SystemLogMessage4 = 0x0200, // 7.51
        SystemLogMessage8 = 0x03CD, // 7.51
        SystemLogMessage16 = 0x016D, // 7.51
        BattleTalk2 = 0x02B4, // 7.51
        BattleTalk4 = 0x007C, // 7.51
        BattleTalk8 = 0x0322, // 7.51
        MapUpdate = 0x032C, // 7.51
        MapUpdate4 = 0x03C1, // 7.51
        MapUpdate8 = 0x0186, // 7.51
        MapUpdate16 = 0x0067, // 7.51
        MapUpdate32 = 0x02BF, // 7.51
        MapUpdate64 = 0x0259, // 7.51
        MapUpdate128 = 0x017B, // 7.51
        BalloonTalk2 = 0x0219, // 7.51
        BalloonTalk4 = 0x03DE, // 7.51
        BalloonTalk8 = 0x01C4, // 7.51
        WeatherChange = 0x0131, // 7.51
        PlayerTitleList = 0x0365, // 7.51
        NpcYell = 0x0265, // 7.51
        HousingWardInfo = 0x0153, // 7.51
        AirshipTimers = 0x0081, // 7.51
        PlaceFieldMarkerPreset = 0x02BA, // 7.51
        PlaceFieldMarker = 0x018B, // 7.51
        AirshipStatusList = 0x0261, // 7.51
        AirshipStatus = 0x0163, // 7.51
        AirshipExplorationResult = 0x0374, // 7.51
        SubmarineStatusList = 0x03CF, // 7.51
        SubmarineProgressionStatus = 0x036E, // 7.51
        SubmarineExplorationResult = 0x027F, // 7.51
        SubmarineTimers = 0x0068, // 7.51
        PrepareZoning = 0x0193, // 7.51
        ActorGauge = 0x0204, // 7.51
        CEDirector = 0x03DA, // 7.51
        IslandWorkshopDemandResearch = 0x01F8, // 7.51
        IslandWorkshopSupplyDemand = 0x00F1, // 7.51
        IslandWorkshopGranaryResult = 0x025F, // 7.51
        IslandWorkshopFavors = 0x021F, // 7.51
        FishCaught = 0x01D0, // 7.51
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x00FB, // 7.51
        ActionRequestGroundTargeted = 0x01C6, // 7.51
        ChatHandler = 0x00E4, // 7.51
        ClientCountdownInitiate = 0x034F, // 7.51
        ClientTrigger = 0x0320, // 7.51
        InventoryModifyHandler = 0x00F2, // 7.51
        LogoutHandler = 0x02FE, // 7.51
        MarketBoardPurchaseHandler = 0x01A2, // 7.51
        SetSearchInfoHandler = 0x020D, // 7.51
        UpdatePositionHandler = 0x0297, // 7.51
        UpdatePositionInstance = 0x0319, // 7.51
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
