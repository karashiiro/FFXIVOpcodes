namespace FFXIVOpcodes.Global
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
        Init = 0x0152, // 7.56h
        Logout = 0x01D6, // 7.56h
        CFCancel = 0x02D4, // 7.56h
        CFDutyInfo = 0x00C5, // 7.56h
        CFNotify = 0x0333, // 7.56h
        CFPreferredRole = 0x01B2, // 7.56h
        PartyFinderList = 0x02E6, // 7.56h
        CFRegistered = 0x03A6, // 7.56h
        Playtime = 0x006D, // 7.56h
        RSVData = 0x00F3, // 7.56h
        RSFData = 0x0102, // 7.56h
        SocialMessage = 0x01A9, // 7.56h
        SocialMessage2 = 0x0389, // 7.56h
        SocialList = 0x02F3, // 7.56h
        SocialRequestResponse = 0x00A7, // 7.56h
        ExamineSearchInfo = 0x02CF, // 7.56h
        UpdateSearchInfo = 0x0220, // 7.56h
        InitSearchInfo = 0x03E6, // 7.56h
        ServerNoticeShort = 0x00FF, // 7.56h
        ServerNotice = 0x0250, // 7.56h
        SetOnlineStatus = 0x0364, // 7.56h
        LogMessage = 0x02ED, // 7.56h
        Countdown = 0x034E, // 7.56h
        CountdownCancel = 0x01B9, // 7.56h
        PartyMessage = 0x02CD, // 7.56h
        PlayerAddedToBlacklist = 0x01DF, // 7.56h
        PlayerRemovedFromBlacklist = 0x02EC, // 7.56h
        BlackList = 0x0101, // 7.56h
        MarketBoardItemListingCount = 0x00C0, // 7.56h
        MarketBoardItemListing = 0x034D, // 7.56h
        PlayerRetainerInfo = 0x0257, // 7.56h
        MarketBoardPurchase = 0x0299, // 7.56h
        MarketBoardSale = 0x011E, // 7.56h
        MarketBoardItemListingHistory = 0x0241, // 7.56h
        RetainerSaleHistory = 0x00A1, // 7.56h
        RetainerState = 0x038C, // 7.56h
        MarketBoardSearchResult = 0x01D8, // 7.56h
        FreeCompanyInfo = 0x01BC, // 7.56h
        ExamineFreeCompanyInfo = 0x0369, // 7.56h
        FreeCompanyDialog = 0x0187, // 7.56h
        StatusEffectList = 0x0083, // 7.56h
        StatusEffectListEureka = 0x01C0, // 7.56h
        StatusEffectListBozja = 0x0151, // 7.56h
        StatusEffectListOccult = 0x0163, // 7.56h
        StatusEffectListDouble = 0x0066, // 7.56h
        EffectResult = 0x0131, // 7.56h
        EffectResult4 = 0x00B5, // 7.56h
        EffectResult8 = 0x02B2, // 7.56h
        EffectResult16 = 0x0148, // 7.56h
        EffectResultBasic = 0x02B9, // 7.56h
        EffectResultBasic4 = 0x00B0, // 7.56h
        EffectResultBasic8 = 0x00E7, // 7.56h
        EffectResultBasic16 = 0x0294, // 7.56h
        EffectResultBasic32 = 0x00C7, // 7.56h
        EffectResultBasic64 = 0x03D6, // 7.56h
        ActorControl = 0x025F, // 7.56h
        ActorControlSelf = 0x0204, // 7.56h
        ActorControlTarget = 0x0358, // 7.56h
        UpdateHpMpTp = 0x011B, // 7.56h
        Effect = 0x0313, // 7.56h
        AoeEffect8 = 0x021C, // 7.56h
        AoeEffect16 = 0x008C, // 7.56h
        AoeEffect24 = 0x030A, // 7.56h
        AoeEffect32 = 0x03AA, // 7.56h
        StatusEffectListPlayer = 0x03DC, // 7.56h
        StatusEffectListPlayerDouble = 0x02BF, // 7.56h
        UpdateRecastTimes = 0x01F7, // 7.56h
        UpdateDutyRecastTimes = 0x03A8, // 7.56h
        UpdateDutyRecastTimes5 = 0x014B, // 7.56h
        UpdateAllianceNormal = 0x01F4, // 7.56h
        UpdateAllianceSmall = 0x0352, // 7.56h
        UpdatePartyMemberPositions = 0x03D9, // 7.56h
        UpdateAllianceNormalMemberPositions = 0x0395, // 7.56h
        UpdateAllianceSmallMemberPositions = 0x024E, // 7.56h
        GCAffiliation = 0x02DC, // 7.56h
        GatheringLog = 0x00B9, // 7.56h
        CraftingLog = 0x026A, // 7.56h
        PlayerSpawn = 0x01C4, // 7.56h
        NpcSpawn = 0x020C, // 7.56h
        BossSpawn = 0x01BD, // 7.56h
        DespawnCharacter = 0x03CE, // 7.56h
        ActorMove = 0x01D9, // 7.56h
        ActorSetPos = 0x02AE, // 7.56h
        ActorCast = 0x0162, // 7.56h
        InitZone = 0x032B, // 7.56h
        UpdateHate = 0x029F, // 7.56h
        UpdateHater = 0x022E, // 7.56h
        ObjectSpawn = 0x00EE, // 7.56h
        ObjectDespawn = 0x012D, // 7.56h
        UpdateClassInfo = 0x0314, // 7.56h
        UpdateClassInfoEureka = 0x013D, // 7.56h
        UpdateClassInfoBozja = 0x0345, // 7.56h
        UpdateClassInfoOccult = 0x0145, // 7.56h
        PlayerSetup = 0x0093, // 7.56h
        PlayerStats = 0x00D0, // 7.56h
        FirstAttack = 0x00D6, // 7.56h
        PlayerStateFlags = 0x0203, // 7.56h
        PlayerClassInfo = 0x01EA, // 7.56h
        PlayerBlueMageActions = 0x0192, // 7.56h
        ModelEquip = 0x010F, // 7.56h
        Examine = 0x01F2, // 7.56h
        RetainerSummary = 0x0312, // 7.56h
        RetainerInformation = 0x02F5, // 7.56h
        ItemMarketBoardSummary = 0x01BA, // 7.56h
        ItemMarketBoardInfo = 0x0139, // 7.56h
        ItemInfo = 0x0084, // 7.56h
        ContainerInfo = 0x01B3, // 7.56h
        InventoryTransactionFinish = 0x03C2, // 7.56h
        InventoryTransaction = 0x023A, // 7.56h
        CurrencyCrystalInfo = 0x01A6, // 7.56h
        InventoryActionAck = 0x0134, // 7.56h
        UpdateInventorySlot = 0x02A2, // 7.56h
        EventPlay = 0x01FD, // 7.56h
        EventPlay4 = 0x01C6, // 7.56h
        EventPlay8 = 0x034B, // 7.56h
        EventPlay16 = 0x0396, // 7.56h
        EventPlay32 = 0x019D, // 7.56h
        EventPlay64 = 0x0351, // 7.56h
        EventPlay128 = 0x03A2, // 7.56h
        EventPlay255 = 0x015E, // 7.56h
        EventStart = 0x02E1, // 7.56h
        EventFinish = 0x00D9, // 7.56h
        ResultDialog = 0x0267, // 7.56h
        DesynthResult = 0x00FB, // 7.56h
        MiniCactpotInit = 0x024D, // 7.56h
        EnvironmentControl = 0x0198, // 7.56h
        EnvironmentControl4 = 0x03AE, // 7.56h
        EnvironmentControl8 = 0x02C7, // 7.56h
        EnvironmentControl12 = 0x0226, // 7.56h
        SystemLogMessage = 0x00A8, // 7.56h
        SystemLogMessage2 = 0x02C2, // 7.56h
        SystemLogMessage4 = 0x01D2, // 7.56h
        SystemLogMessage8 = 0x026C, // 7.56h
        SystemLogMessage16 = 0x026B, // 7.56h
        BattleTalk2 = 0x01E1, // 7.56h
        BattleTalk4 = 0x0114, // 7.56h
        BattleTalk8 = 0x02D8, // 7.56h
        MapUpdate = 0x0115, // 7.56h
        MapUpdate4 = 0x02A8, // 7.56h
        MapUpdate8 = 0x0165, // 7.56h
        MapUpdate16 = 0x0264, // 7.56h
        MapUpdate32 = 0x02DF, // 7.56h
        MapUpdate64 = 0x0178, // 7.56h
        MapUpdate128 = 0x01A1, // 7.56h
        BalloonTalk2 = 0x02E5, // 7.56h
        BalloonTalk4 = 0x0331, // 7.56h
        BalloonTalk8 = 0x009B, // 7.56h
        WeatherChange = 0x032F, // 7.56h
        PlayerTitleList = 0x01FE, // 7.56h
        NpcYell = 0x00DD, // 7.56h
        HousingWardInfo = 0x0363, // 7.56h
        AirshipTimers = 0x006C, // 7.56h
        PlaceFieldMarkerPreset = 0x0167, // 7.56h
        PlaceFieldMarker = 0x029D, // 7.56h
        AirshipStatusList = 0x03E4, // 7.56h
        AirshipStatus = 0x0126, // 7.56h
        AirshipExplorationResult = 0x02F4, // 7.56h
        SubmarineStatusList = 0x038A, // 7.56h
        SubmarineProgressionStatus = 0x01CC, // 7.56h
        SubmarineExplorationResult = 0x0212, // 7.56h
        SubmarineTimers = 0x01EC, // 7.56h
        PrepareZoning = 0x00FE, // 7.56h
        ActorGauge = 0x0266, // 7.56h
        FashionReport = 0x036C, // 7.56h
        CEDirector = 0x031E, // 7.56h
        IslandWorkshopDemandResearch = 0x03AD, // 7.56h
        IslandWorkshopSupplyDemand = 0x037A, // 7.56h
        IslandWorkshopGranaryResult = 0x0262, // 7.56h
        IslandWorkshopFavors = 0x009A, // 7.56h
        FishCaught = 0x0110, // 7.56h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0391, // 7.56h
        ActionRequestGroundTargeted = 0x037B, // 7.56h
        ChatHandler = 0x0230, // 7.56h
        ClientCountdownInitiate = 0x037E, // 7.56h
        ClientTrigger = 0x0187, // 7.56h
        InventoryModifyHandler = 0x01FB, // 7.56h
        LogoutHandler = 0x01AF, // 7.56h
        MarketBoardPurchaseHandler = 0x02FD, // 7.56h
        MarketBoardRequestItemListingInfo = 0x0320, // 7.56h
        SetSearchInfoHandler = 0x0279, // 7.56h
        UpdatePositionHandler = 0x0398, // 7.56h
        UpdatePositionInstance = 0x019B, // 7.56h
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //Tell = 0x0064, // updated for sb
        //TellErrNotFound = 0x0066,

        //FreeCompanyEvent = 0x012C, // added 5.0
    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        //TellReq = 0x0064,
    };
}