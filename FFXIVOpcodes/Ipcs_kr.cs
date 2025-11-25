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
        ActorCast = 0x033C, // 7.31
        ActorControl = 0x021B, // 7.31
        ActorControlSelf = 0x020B, // 7.31
        ActorControlTarget = 0x0223, // 7.31
        ActorGauge = 0x0271, // 7.31
        ActorMove = 0x03B4, // 7.31
        ActorSetPos = 0x0243, // 7.31
        AirshipExplorationResult = 0x008F, // 7.31
        AirshipStatus = 0x00E2, // 7.31
        AirshipStatusList = 0x032A, // 7.31
        AirshipTimers = 0x02B5, // 7.31
        AoeEffect16 = 0x0299, // 7.31
        AoeEffect24 = 0x010B, // 7.31
        AoeEffect32 = 0x03C6, // 7.31
        AoeEffect8 = 0x03C8, // 7.31
        ApplyIDScramble = 0x0088, // 7.31
        BalloonTalk2 = 0x01DB, // 7.31
        BalloonTalk4 = 0x0160, // 7.31
        BalloonTalk8 = 0x0125, // 7.31
        BattleTalk2 = 0x015B, // 7.31
        BattleTalk4 = 0x0137, // 7.31
        BattleTalk8 = 0x0161, // 7.31
        BlackList = 0x026A, // 7.31
        CEDirector = 0x0080, // 7.31
        CFCancel = 0x00BC, // 7.31
        CFDutyInfo = 0x02B3, // 7.31
        CFNotify = 0x0385, // 7.31
        CFPreferredRole = 0x01C4, // 7.31
        CFRegistered = 0x0184, // 7.31
        Chat = 0x02DE, // 7.31
        ContainerInfo = 0x0154, // 7.31
        Countdown = 0x0231, // 7.31
        CountdownCancel = 0x03B7, // 7.31
        CraftingCalculations = 0x0218, // 7.31
        CrossWorldLinkshellList = 0x035B, // 7.31
        CrossWorldLinkshellMember = 0x02A1, // 7.31
        CurrencyCrystalInfo = 0x0155, // 7.31
        DespawnCharacter = 0x012F, // 7.31
        DesynthResult = 0x02E6, // 7.31
        Effect = 0x0257, // 7.31
        EffectResult = 0x022D, // 7.31
        EffectResult16 = 0x0391, // 7.31
        EffectResult4 = 0x032B, // 7.31
        EffectResult8 = 0x02DD, // 7.31
        EffectResultBasic = 0x03E6, // 7.31
        EffectResultBasic16 = 0x01A9, // 7.31
        EffectResultBasic32 = 0x01F3, // 7.31
        EffectResultBasic4 = 0x0202, // 7.31
        EffectResultBasic64 = 0x02BF, // 7.31
        EffectResultBasic8 = 0x00EF, // 7.31
        EnvironmentControl = 0x03B1, // 7.31
        EnvironmentControl12 = 0x014D, // 7.31
        EnvironmentControl4 = 0x02A3, // 7.31
        EnvironmentControl8 = 0x013C, // 7.31
        EventFinish = 0x0381, // 7.31
        EventPlay = 0x02A0, // 7.31
        EventPlay128 = 0x00A3, // 7.31
        EventPlay16 = 0x01AE, // 7.31
        EventPlay255 = 0x02B2, // 7.31
        EventPlay32 = 0x02B1, // 7.31
        EventPlay4 = 0x0126, // 7.31
        EventPlay64 = 0x00BB, // 7.31
        EventPlay8 = 0x016B, // 7.31
        EventStart = 0x01E6, // 7.31
        Examine = 0x01DC, // 7.31
        ExamineFreeCompanyInfo = 0x016D, // 7.31
        ExamineSearchInfo = 0x0370, // 7.31
        FashionReport = 0x02AD, // 7.31
        FellowshipList = 0x0242, // 7.31
        FellowshipSearchList = 0x030D, // 7.31
        FirstAttack = 0x02AE, // 7.31
        FreeCompanyDialog = 0x0220, // 7.31
        FreeCompanyInfo = 0x0199, // 7.31
        HousingObjectDye = 0x0072, // 7.31
        HousingObjectMove = 0x0165, // 7.31
        HousingWardInfo = 0x01A6, // 7.31
        Init = 0x03C2, // 7.31
        InitZone = 0x02FB, // 7.31
        InventoryActionAck = 0x0260, // 7.31
        InventoryTransaction = 0x0086, // 7.31
        InventoryTransactionFinish = 0x007F, // 7.31
        IslandWorkshopDemandResearch = 0x00BF, // 7.31
        IslandWorkshopFavors = 0x0313, // 7.31
        IslandWorkshopSupplyDemand = 0x034B, // 7.31
        ItemInfo = 0x02F7, // 7.31
        ItemMarketBoardInfo = 0x018A, // 7.31
        ItemMarketBoardSummary = 0x02BD, // 7.31
        LogMessage = 0x02D7, // 7.31
        Logout = 0x0240, // 7.31
        MapUpdate = 0x022B, // 7.31
        MapUpdate128 = 0x0091, // 7.31
        MapUpdate16 = 0x00D4, // 7.31
        MapUpdate32 = 0x008B, // 7.31
        MapUpdate4 = 0x0136, // 7.31
        MapUpdate64 = 0x0147, // 7.31
        MapUpdate8 = 0x038F, // 7.31
        MarketBoardItemListing = 0x03CE, // 7.31
        MarketBoardItemListingCount = 0x03DA, // 7.31
        MarketBoardItemListingHistory = 0x0107, // 7.31
        MarketBoardPurchase = 0x00C4, // 7.31
        MarketBoardSale = 0x01DA, // 7.31
        MarketBoardSearchResult = 0x02FF, // 7.31
        MiniCactpotInit = 0x0384, // 7.31
        ModelEquip = 0x0131, // 7.31
        Mount = 0x036F, // 7.31
        NpcSpawn = 0x0201, // 7.31
        NpcSpawn2 = 0x018C, // 7.31
        NpcYell = 0x02E2, // 7.31
        ObjectDespawn = 0x009E, // 7.31
        ObjectSpawn = 0x037B, // 7.31
        PartyMessage = 0x02E4, // 7.31
        Ping = 0x016E, // 7.31
        PlaceFieldMarker = 0x0303, // 7.31
        PlaceFieldMarkerPreset = 0x00CC, // 7.31
        PlayerAddedToBlacklist = 0x00E0, // 7.31
        PlayerBlueMageActions = 0x0308, // 7.31
        PlayerClassInfo = 0x01EF, // 7.31
        PlayerRemovedFromBlacklist = 0x01C5, // 7.31
        PlayerRetainerInfo = 0x02C9, // 7.31
        PlayerSetup = 0x03A9, // 7.31
        PlayerSpawn = 0x00F1, // 7.31
        PlayerStateFlags = 0x029F, // 7.31
        PlayerStats = 0x0215, // 7.31
        PlayerUpdateLook = 0x0256, // 7.31
        Playtime = 0x01BC, // 7.31
        PrepareZoning = 0x00BA, // 7.31
        ResultDialog = 0x016A, // 7.31
        RetainerInformation = 0x03E7, // 7.31
        RetainerSaleHistory = 0x00D7, // 7.31
        RetainerState = 0x028E, // 7.31
        RetainerSummary = 0x016F, // 7.31
        RSFData = 0x02CF, // 7.31
        RSVData = 0x02E7, // 7.31
        ServerNotice = 0x0096, // 7.31
        ServerNoticeShort = 0x0297, // 7.31
        SetOnlineStatus = 0x0192, // 7.31
        SocialList = 0x024B, // 7.31
        SocialMessage = 0x03BC, // 7.31
        SocialMessage2 = 0x00F4, // 7.31
        SocialRequestResponse = 0x0081, // 7.31
        StatusEffectList = 0x008C, // 7.31
        StatusEffectListBozja = 0x03CD, // 7.31
        StatusEffectListDouble = 0x0334, // 7.31
        StatusEffectListEureka = 0x01C6, // 7.31
        StatusEffectListForay3 = 0x019A, // 7.31
        StatusEffectListPlayer = 0x01AD, // 7.31
        StatusEffectListPlayerDouble = 0x00F8, // 7.31
        SubmarineExplorationResult = 0x03E3, // 7.31
        SubmarineProgressionStatus = 0x0266, // 7.31
        SubmarineStatusList = 0x0208, // 7.31
        SubmarineTimers = 0x0076, // 7.31
        SystemLogMessage = 0x03B6, // 7.31
        SystemLogMessage16 = 0x0248, // 7.31
        SystemLogMessage2 = 0x0101, // 7.31
        SystemLogMessage4 = 0x03CA, // 7.31
        SystemLogMessage8 = 0x025E, // 7.31
        UpdateAllianceNormal = 0x0398, // 7.31
        UpdateAllianceNormalMemberPositions = 0x01C3, // 7.31
        UpdateAllianceSmall = 0x00FD, // 7.31
        UpdateAllianceSmallMemberPositions = 0x026F, // 7.31
        UpdateClassInfo = 0x02D3, // 7.31
        UpdateClassInfoBozja = 0x012A, // 7.31
        UpdateClassInfoEureka = 0x01B3, // 7.31
        UpdateClassInfoForay3 = 0x00C3, // 7.31
        UpdateDutyRecastTimes = 0x00E3, // 7.31
        UpdateDutyRecastTimes5 = 0x02DB, // 7.31
        UpdateHate = 0x00B9, // 7.31
        UpdateHater = 0x00FC, // 7.31
        UpdateHpMpTp = 0x01AB, // 7.31
        UpdateInventorySlot = 0x03C9, // 7.31
        UpdateParty = 0x0146, // 7.31
        UpdatePartyMemberPositions = 0x038D, // 7.31
        UpdateRecastTimes = 0x0194, // 7.31
        UpdateSearchInfo = 0x0175, // 7.31
        WeatherChange = 0x0222, // 7.31
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0220, // 7.31
        ActionRequestGroundTargeted = 0x0332, // 7.31
        ChatHandler = 0x013B, // 7.31
        ClientCountdownInitiate = 0x03A6, // 7.31
        ClientTrigger = 0x0199, // 7.31
        InventoryModifyHandler = 0x0315, // 7.31
        LogoutHandler = 0x031F, // 7.31
        MarketBoardPurchaseHandler = 0x0111, // 7.31
        SetSearchInfoHandler = 0x02A7, // 7.31
        UpdatePositionHandler = 0x029B, // 7.31
        UpdatePositionInstance = 0x039B, // 7.31
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
