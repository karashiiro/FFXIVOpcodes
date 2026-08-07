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
        Init = 0x024D, // 7.55h
        Logout = 0x0239, // 7.55h
        CFCancel = 0x016A, // 7.55h
        CFDutyInfo = 0x0204, // 7.55h
        CFNotify = 0x00B8, // 7.55h
        CFPreferredRole = 0x00DF, // 7.55h
        PartyFinderList = 0x007C, // 7.55h
        CFRegistered = 0x00C4, // 7.55h
        Playtime = 0x037F, // 7.55h
        RSVData = 0x03D3, // 7.55h
        RSFData = 0x03B3, // 7.55h
        SocialMessage = 0x027A, // 7.55h
        SocialMessage2 = 0x006C, // 7.55h
        SocialList = 0x02CF, // 7.55h
        SocialRequestResponse = 0x0200, // 7.55h
        ExamineSearchInfo = 0x0302, // 7.55h
        UpdateSearchInfo = 0x0086, // 7.55h
        InitSearchInfo = 0x0353, // 7.55h
        ServerNoticeShort = 0x027D, // 7.55h
        ServerNotice = 0x0219, // 7.55h
        SetOnlineStatus = 0x0145, // 7.55h
        LogMessage = 0x01FD, // 7.55h
        Countdown = 0x0322, // 7.55h
        CountdownCancel = 0x01A9, // 7.55h
        PartyMessage = 0x025A, // 7.55h
        PlayerAddedToBlacklist = 0x02C1, // 7.55h
        PlayerRemovedFromBlacklist = 0x02B8, // 7.55h
        BlackList = 0x02A9, // 7.55h
        MarketBoardItemListingCount = 0x0256, // 7.55h
        MarketBoardItemListing = 0x0356, // 7.55h
        PlayerRetainerInfo = 0x02EE, // 7.55h
        MarketBoardPurchase = 0x0075, // 7.55h
        MarketBoardSale = 0x03D4, // 7.55h
        MarketBoardItemListingHistory = 0x0127, // 7.55h
        RetainerSaleHistory = 0x00E8, // 7.55h
        RetainerState = 0x021C, // 7.55h
        MarketBoardSearchResult = 0x036D, // 7.55h
        FreeCompanyInfo = 0x01CF, // 7.55h
        ExamineFreeCompanyInfo = 0x02CC, // 7.55h
        FreeCompanyDialog = 0x0357, // 7.55h
        StatusEffectList = 0x01F1, // 7.55h
        StatusEffectListEureka = 0x03C6, // 7.55h
        StatusEffectListBozja = 0x009B, // 7.55h
        StatusEffectListOccult = 0x00DC, // 7.55h
        StatusEffectListDouble = 0x0320, // 7.55h
        EffectResult = 0x02F5, // 7.55h
        EffectResult4 = 0x03D7, // 7.55h
        EffectResult8 = 0x02D1, // 7.55h
        EffectResult16 = 0x02A7, // 7.55h
        EffectResultBasic = 0x03A3, // 7.55h
        EffectResultBasic4 = 0x0271, // 7.55h
        EffectResultBasic8 = 0x03E5, // 7.55h
        EffectResultBasic16 = 0x036C, // 7.55h
        EffectResultBasic32 = 0x03B0, // 7.55h
        EffectResultBasic64 = 0x01D3, // 7.55h
        ActorControl = 0x01DA, // 7.55h
        ActorControlSelf = 0x035D, // 7.55h
        ActorControlTarget = 0x013C, // 7.55h
        UpdateHpMpTp = 0x02E7, // 7.55h
        Effect = 0x0296, // 7.55h
        AoeEffect8 = 0x0164, // 7.55h
        AoeEffect16 = 0x01B1, // 7.55h
        AoeEffect24 = 0x039B, // 7.55h
        AoeEffect32 = 0x0372, // 7.55h
        StatusEffectListPlayer = 0x0153, // 7.55h
        StatusEffectListPlayerDouble = 0x010C, // 7.55h
        UpdateRecastTimes = 0x0077, // 7.55h
        UpdateDutyRecastTimes = 0x0346, // 7.55h
        UpdateDutyRecastTimes5 = 0x0100, // 7.55h
        UpdateAllianceNormal = 0x00CC, // 7.55h
        UpdateAllianceSmall = 0x0387, // 7.55h
        UpdatePartyMemberPositions = 0x011C, // 7.55h
        UpdateAllianceNormalMemberPositions = 0x0113, // 7.55h
        UpdateAllianceSmallMemberPositions = 0x0393, // 7.55h
        GCAffiliation = 0x0104, // 7.55h
        GatheringLog = 0x0395, // 7.55h
        CraftingLog = 0x0182, // 7.55h
        PlayerSpawn = 0x0398, // 7.55h
        NpcSpawn = 0x006F, // 7.55h
        BossSpawn = 0x0287, // 7.55h
        DespawnCharacter = 0x0276, // 7.55h
        ActorMove = 0x038D, // 7.55h
        ActorSetPos = 0x03DF, // 7.55h
        ActorCast = 0x018C, // 7.55h
        InitZone = 0x028D, // 7.55h
        UpdateHate = 0x02E1, // 7.55h
        UpdateHater = 0x0119, // 7.55h
        ObjectSpawn = 0x00B1, // 7.55h
        ObjectDespawn = 0x0110, // 7.55h
        UpdateClassInfo = 0x0350, // 7.55h
        UpdateClassInfoEureka = 0x0304, // 7.55h
        UpdateClassInfoBozja = 0x0161, // 7.55h
        UpdateClassInfoOccult = 0x0388, // 7.55h
        PlayerSetup = 0x03DD, // 7.55h
        PlayerStats = 0x0325, // 7.55h
        FirstAttack = 0x0341, // 7.55h
        PlayerStateFlags = 0x01FC, // 7.55h
        PlayerClassInfo = 0x00F3, // 7.55h
        PlayerBlueMageActions = 0x0118, // 7.55h
        ModelEquip = 0x0336, // 7.55h
        Examine = 0x02BB, // 7.55h
        RetainerSummary = 0x01DC, // 7.55h
        RetainerInformation = 0x0315, // 7.55h
        ItemMarketBoardSummary = 0x00F2, // 7.55h
        ItemMarketBoardInfo = 0x017A, // 7.55h
        ItemInfo = 0x013A, // 7.55h
        ContainerInfo = 0x0218, // 7.55h
        InventoryTransactionFinish = 0x0188, // 7.55h
        InventoryTransaction = 0x01C8, // 7.55h
        CurrencyCrystalInfo = 0x02E0, // 7.55h
        InventoryActionAck = 0x015A, // 7.55h
        UpdateInventorySlot = 0x018E, // 7.55h
        EventPlay = 0x02DD, // 7.55h
        EventPlay4 = 0x012F, // 7.55h
        EventPlay8 = 0x0228, // 7.55h
        EventPlay16 = 0x013E, // 7.55h
        EventPlay32 = 0x027C, // 7.55h
        EventPlay64 = 0x00F1, // 7.55h
        EventPlay128 = 0x0235, // 7.55h
        EventPlay255 = 0x03A9, // 7.55h
        EventStart = 0x016D, // 7.55h
        EventFinish = 0x016E, // 7.55h
        ResultDialog = 0x01AA, // 7.55h
        DesynthResult = 0x037B, // 7.55h
        MiniCactpotInit = 0x012D, // 7.55h
        EnvironmentControl = 0x00BC, // 7.55h
        EnvironmentControl4 = 0x03D9, // 7.55h
        EnvironmentControl8 = 0x030C, // 7.55h
        EnvironmentControl12 = 0x0366, // 7.55h
        SystemLogMessage = 0x01E7, // 7.55h
        SystemLogMessage2 = 0x0071, // 7.55h
        SystemLogMessage4 = 0x024E, // 7.55h
        SystemLogMessage8 = 0x00BA, // 7.55h
        SystemLogMessage16 = 0x00C6, // 7.55h
        BattleTalk2 = 0x02AD, // 7.55h
        BattleTalk4 = 0x030E, // 7.55h
        BattleTalk8 = 0x0396, // 7.55h
        MapUpdate = 0x00A9, // 7.55h
        MapUpdate4 = 0x00C5, // 7.55h
        MapUpdate8 = 0x02FF, // 7.55h
        MapUpdate16 = 0x0397, // 7.55h
        MapUpdate32 = 0x0214, // 7.55h
        MapUpdate64 = 0x0310, // 7.55h
        MapUpdate128 = 0x03BE, // 7.55h
        BalloonTalk2 = 0x010A, // 7.55h
        BalloonTalk4 = 0x009E, // 7.55h
        BalloonTalk8 = 0x021B, // 7.55h
        WeatherChange = 0x03B5, // 7.55h
        PlayerTitleList = 0x0352, // 7.55h
        NpcYell = 0x0328, // 7.55h
        HousingWardInfo = 0x01CC, // 7.55h
        AirshipTimers = 0x022F, // 7.55h
        PlaceFieldMarkerPreset = 0x0149, // 7.55h
        PlaceFieldMarker = 0x0171, // 7.55h
        AirshipStatusList = 0x02F0, // 7.55h
        AirshipStatus = 0x018D, // 7.55h
        AirshipExplorationResult = 0x0368, // 7.55h
        SubmarineStatusList = 0x01EF, // 7.55h
        SubmarineProgressionStatus = 0x00CD, // 7.55h
        SubmarineExplorationResult = 0x018F, // 7.55h
        SubmarineTimers = 0x02B1, // 7.55h
        PrepareZoning = 0x02C9, // 7.55h
        ActorGauge = 0x0221, // 7.55h
        FashionReport = 0x03E1, // 7.55h
        CEDirector = 0x0092, // 7.55h
        IslandWorkshopDemandResearch = 0x0295, // 7.55h
        IslandWorkshopSupplyDemand = 0x025E, // 7.55h
        IslandWorkshopGranaryResult = 0x00C1, // 7.55h
        IslandWorkshopFavors = 0x02D4, // 7.55h
        FishCaught = 0x032D, // 7.55h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0216, // 7.55h
        ActionRequestGroundTargeted = 0x0241, // 7.55h
        ChatHandler = 0x03CD, // 7.55h
        ClientCountdownInitiate = 0x0307, // 7.55h
        ClientTrigger = 0x0357, // 7.55h
        InventoryModifyHandler = 0x0240, // 7.55h
        LogoutHandler = 0x0290, // 7.55h
        MarketBoardPurchaseHandler = 0x00B3, // 7.55h
        MarketBoardRequestItemListingInfo = 0x0070, // 7.55h
        SetSearchInfoHandler = 0x00EE, // 7.55h
        UpdatePositionHandler = 0x01A2, // 7.55h
        UpdatePositionInstance = 0x01DF, // 7.55h
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
