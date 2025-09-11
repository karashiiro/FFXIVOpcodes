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
        ActorCast = 0x028D, // 7.25
        ActorControl = 0x0079, // 7.25
        ActorControlSelf = 0x02F9, // 7.25
        ActorControlTarget = 0x0326, // 7.25
        ActorGauge = 0x00D3, // 7.25
        ActorMove = 0x031D, // 7.25
        ActorSetPos = 0x027D, // 7.25
        AirshipExplorationResult = 0x00AC, // 7.25
        AirshipStatus = 0x0361, // 7.25
        AirshipStatusList = 0x013E, // 7.25
        AirshipTimers = 0x00FD, // 7.25
        AoeEffect16 = 0x0381, // 7.25
        AoeEffect24 = 0x0372, // 7.25
        AoeEffect32 = 0x020E, // 7.25
        AoeEffect8 = 0x038E, // 7.25
        ApplyIDScramble = 0x00D9, // 7.25
        BalloonTalk2 = 0x0100, // 7.25
        BalloonTalk4 = 0x01C4, // 7.25
        BalloonTalk8 = 0x034B, // 7.25
        BattleTalk2 = 0x00F1, // 7.25
        BattleTalk4 = 0x0369, // 7.25
        BattleTalk8 = 0x021C, // 7.25
        CEDirector = 0x0173, // 7.25
        CFCancel = 0x028A, // 7.25
        CFDutyInfo = 0x021B, // 7.25
        CFNotify = 0x0157, // 7.25
        CFPreferredRole = 0x03C4, // 7.25
        CFRegistered = 0x025D, // 7.25
        Chat = 0x0237, // 7.25
        ContainerInfo = 0x0363, // 7.25
        CosmicWeatherMissions = 0x034F, // 7.25
        Countdown = 0x0086, // 7.25
        CountdownCancel = 0x03C7, // 7.25
        CraftingCalculations = 0x0154, // 7.25
        CrossWorldLinkshellList = 0x035D, // 7.25
        CurrencyCrystalInfo = 0x0119, // 7.25
        DespawnCharacter = 0x02DD, // 7.25
        DesynthResult = 0x02AC, // 7.25
        Discovery = 0x009C, // 7.25
        Effect = 0x01B1, // 7.25
        EffectResult = 0x0320, // 7.25
        EffectResult16 = 0x011E, // 7.25
        EffectResult4 = 0x00AE, // 7.25
        EffectResult8 = 0x0281, // 7.25
        EffectResultBasic = 0x01FE, // 7.25
        EffectResultBasic16 = 0x0382, // 7.25
        EffectResultBasic32 = 0x0338, // 7.25
        EffectResultBasic4 = 0x0125, // 7.25
        EffectResultBasic64 = 0x03A2, // 7.25
        EffectResultBasic8 = 0x02CC, // 7.25
        EnvironmentControl = 0x02EB, // 7.25
        EnvironmentControl12 = 0x0066, // 7.25
        EnvironmentControl4 = 0x01BD, // 7.25
        EnvironmentControl8 = 0x0241, // 7.25
        EorzeaTimeOffset = 0x03A0, // 7.25
        EquipDisplayFlags = 0x00F6, // 7.25
        EventFinish = 0x0289, // 7.25
        EventPlay = 0x02E8, // 7.25
        EventPlay128 = 0x00D1, // 7.25
        EventPlay16 = 0x00A2, // 7.25
        EventPlay255 = 0x0341, // 7.25
        EventPlay32 = 0x0306, // 7.25
        EventPlay4 = 0x00A0, // 7.25
        EventPlay64 = 0x023D, // 7.25
        EventPlay8 = 0x03B9, // 7.25
        EventStart = 0x0330, // 7.25
        Examine = 0x020F, // 7.25
        ExamineSearchComment = 0x02F3, // 7.25
        ExamineSearchInfo = 0x03B4, // 7.25
        FateInfo = 0x0065, // 7.25
        FellowshipList = 0x0198, // 7.25
        FirstAttack = 0x0228, // 7.25
        FreeCompanyDialog = 0x01C8, // 7.25
        FreeCompanyInfo = 0x00A1, // 7.25
        HousingWardInfo = 0x0080, // 7.25
        Init = 0x02EF, // 7.25
        InitSearchInfo = 0x00E4, // 7.25
        InitZone = 0x0263, // 7.25
        InventoryActionAck = 0x0259, // 7.25
        InventoryTransaction = 0x026F, // 7.25
        InventoryTransactionFinish = 0x0216, // 7.25
        IslandWorkshopDemandResearch = 0x03AA, // 7.25
        IslandWorkshopFavors = 0x02CD, // 7.25
        IslandWorkshopSupplyDemand = 0x03B3, // 7.25
        ItemInfo = 0x03DA, // 7.25
        ItemMarketBoardInfo = 0x02B3, // 7.25
        ItemMarketBoardSummary = 0x0159, // 7.25
        LogMessage = 0x0175, // 7.25
        Logout = 0x0319, // 7.25
        MapUpdate = 0x03E1, // 7.25
        MapUpdate128 = 0x0260, // 7.25
        MapUpdate16 = 0x0316, // 7.25
        MapUpdate32 = 0x0189, // 7.25
        MapUpdate4 = 0x0355, // 7.25
        MapUpdate64 = 0x00F3, // 7.25
        MapUpdate8 = 0x016F, // 7.25
        MarketBoardItemListing = 0x0349, // 7.25
        MarketBoardItemListingCount = 0x0304, // 7.25
        MarketBoardItemListingHistory = 0x02B6, // 7.25
        MarketBoardPurchase = 0x017E, // 7.25
        MarketBoardSale = 0x0287, // 7.25
        MarketBoardSearchResult = 0x01B6, // 7.25
        MiniCactpotInit = 0x01CD, // 7.25
        ModelEquip = 0x00D5, // 7.25
        Mount = 0x01D2, // 7.25
        NpcSpawn = 0x01AE, // 7.25
        NpcSpawn2 = 0x0250, // 7.25
        NpcYell = 0x02A6, // 7.25
        ObjectDespawn = 0x01E6, // 7.25
        ObjectSpawn = 0x0244, // 7.25
        Ping = 0x036B, // 7.25
        PlaceFieldMarker = 0x036A, // 7.25
        PlaceFieldMarkerPreset = 0x0383, // 7.25
        PlayerBlueMageActions = 0x016E, // 7.25
        PlayerClassInfo = 0x01BC, // 7.25
        PlayerRetainerInfo = 0x0111, // 7.25
        PlayerSetup = 0x03C3, // 7.25
        PlayerSpawn = 0x00F8, // 7.25
        PlayerStateFlags = 0x02FE, // 7.25
        PlayerStats = 0x025F, // 7.25
        PlayerTitleList = 0x03BD, // 7.25
        PlayerUpdateLook = 0x00E7, // 7.25
        Playtime = 0x01E3, // 7.25
        PrepareZoning = 0x01CE, // 7.25
        ResultDialog = 0x00CA, // 7.25
        RetainerInformation = 0x0088, // 7.25
        RetainerSaleHistory = 0x015F, // 7.25
        RetainerState = 0x0093, // 7.25
        RetainerSummary = 0x0223, // 7.25
        RSFData = 0x00EA, // 7.25
        RSVData = 0x023B, // 7.25
        ServerNotice = 0x00C8, // 7.25
        ServerNoticeShort = 0x0343, // 7.25
        SetOnlineStatus = 0x0213, // 7.25
        SocialList = 0x01AD, // 7.25
        SocialMessage = 0x01A0, // 7.25
        SocialMessage2 = 0x0264, // 7.25
        SocialRequestResponse = 0x00B2, // 7.25
        StatusEffectList = 0x0295, // 7.25
        StatusEffectListBozja = 0x037E, // 7.25
        StatusEffectListDouble = 0x0138, // 7.25
        StatusEffectListEureka = 0x009F, // 7.25
        StatusEffectListForay3 = 0x0299, // 7.25
        StatusEffectListPlayer = 0x0097, // 7.25
        StatusEffectListPlayerDouble = 0x0092, // 7.25
        SubmarineExplorationResult = 0x0085, // 7.25
        SubmarineProgressionStatus = 0x013C, // 7.25
        SubmarineStatusList = 0x0150, // 7.25
        SubmarineTimers = 0x03AD, // 7.25
        SystemLogMessage = 0x0294, // 7.25
        SystemLogMessage144 = 0x035A, // 7.25
        SystemLogMessage32 = 0x026C, // 7.25
        SystemLogMessage48 = 0x0243, // 7.25
        SystemLogMessage80 = 0x0329, // 7.25
        UpdateAllianceNormal = 0x014F, // 7.25
        UpdateAllianceNormalMemberPositions = 0x0386, // 7.25
        UpdateAllianceSmall = 0x02A3, // 7.25
        UpdateAllianceSmallMemberPositions = 0x008B, // 7.25
        UpdateClassInfo = 0x021D, // 7.25
        UpdateClassInfoBozja = 0x0133, // 7.25
        UpdateClassInfoEureka = 0x018A, // 7.25
        UpdateClassInfoForay3 = 0x01C6, // 7.25
        UpdateDutyRecastTimes = 0x00B4, // 7.25
        UpdateDutyRecastTimes5 = 0x0267, // 7.25
        UpdateHate = 0x035B, // 7.25
        UpdateHater = 0x032D, // 7.25
        UpdateHpMpTp = 0x02D2, // 7.25
        UpdateInventorySlot = 0x00FE, // 7.25
        UpdateParty = 0x02F7, // 7.25
        UpdatePartyMemberPositions = 0x036F, // 7.25
        UpdateRecastTimes = 0x013D, // 7.25
        UpdateSearchInfo = 0x018B, // 7.25
        WeatherChange = 0x01E0, // 7.25
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0214, // 7.25
        ActionRequestGroundTargeted = 0x024F, // 7.25
        ChatHandler = 0x0284, // 7.25
        ClientCountdownInitiate = 0x02E6, // 7.25
        ClientTrigger = 0x03D2, // 7.25
        InventoryModifyHandler = 0x0390,// 7.25
        LogoutHandler = 0x028A, // 7.25
        MarketBoardPurchaseHandler = 0x0116, // 7.25
        SetSearchInfoHandler = 0x0171, // 7.25
        UpdatePositionHandler = 0x02AA,// 7.25
        UpdatePositionInstance = 0x01DD,// 7.25
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
