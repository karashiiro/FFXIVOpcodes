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
        Init = 0x0221, // 7.57h
        Logout = 0x00DE, // 7.57h
        CFCancel = 0x0371, // 7.57h
        CFDutyInfo = 0x0134, // 7.57h
        CFNotify = 0x0117, // 7.57h
        CFPreferredRole = 0x013C, // 7.57h
        PartyFinderList = 0x01B6, // 7.57h
        CFRegistered = 0x02A9, // 7.57h
        Playtime = 0x00B9, // 7.57h
        RSVData = 0x0174, // 7.57h
        RSFData = 0x0228, // 7.57h
        SocialMessage = 0x032A, // 7.57h
        SocialMessage2 = 0x033D, // 7.57h
        SocialList = 0x0155, // 7.57h
        SocialRequestResponse = 0x0382, // 7.57h
        ExamineSearchInfo = 0x0194, // 7.57h
        UpdateSearchInfo = 0x021B, // 7.57h
        InitSearchInfo = 0x0274, // 7.57h
        ServerNoticeShort = 0x032F, // 7.57h
        ServerNotice = 0x0105, // 7.57h
        SetOnlineStatus = 0x0253, // 7.57h
        LogMessage = 0x015D, // 7.57h
        Countdown = 0x024B, // 7.57h
        CountdownCancel = 0x02AB, // 7.57h
        PartyMessage = 0x0328, // 7.57h
        PlayerAddedToBlacklist = 0x0199, // 7.57h
        PlayerRemovedFromBlacklist = 0x0111, // 7.57h
        BlackList = 0x0394, // 7.57h
        MarketBoardItemListingCount = 0x00FF, // 7.57h
        MarketBoardItemListing = 0x0131, // 7.57h
        PlayerRetainerInfo = 0x02CB, // 7.57h
        MarketBoardPurchase = 0x0161, // 7.57h
        MarketBoardSale = 0x0234, // 7.57h
        MarketBoardItemListingHistory = 0x02DA, // 7.57h
        RetainerSaleHistory = 0x0227, // 7.57h
        RetainerState = 0x02DF, // 7.57h
        MarketBoardSearchResult = 0x00F1, // 7.57h
        FreeCompanyInfo = 0x022A, // 7.57h
        ExamineFreeCompanyInfo = 0x029C, // 7.57h
        FreeCompanyDialog = 0x037D, // 7.57h
        StatusEffectList = 0x00D4, // 7.57h
        StatusEffectListEureka = 0x0398, // 7.57h
        StatusEffectListBozja = 0x0387, // 7.57h
        StatusEffectListOccult = 0x02D0, // 7.57h
        StatusEffectListDouble = 0x014C, // 7.57h
        EffectResult = 0x032C, // 7.57h
        EffectResult4 = 0x0269, // 7.57h
        EffectResult8 = 0x0191, // 7.57h
        EffectResult16 = 0x0222, // 7.57h
        EffectResultBasic = 0x00EB, // 7.57h
        EffectResultBasic4 = 0x01CC, // 7.57h
        EffectResultBasic8 = 0x022E, // 7.57h
        EffectResultBasic16 = 0x035A, // 7.57h
        EffectResultBasic32 = 0x018A, // 7.57h
        EffectResultBasic64 = 0x0388, // 7.57h
        ActorControl = 0x0229, // 7.57h
        ActorControlSelf = 0x0101, // 7.57h
        ActorControlTarget = 0x022B, // 7.57h
        UpdateHpMpTp = 0x02A4, // 7.57h
        Effect = 0x0363, // 7.57h
        AoeEffect8 = 0x0262, // 7.57h
        AoeEffect16 = 0x0299, // 7.57h
        AoeEffect24 = 0x0245, // 7.57h
        AoeEffect32 = 0x0385, // 7.57h
        StatusEffectListPlayer = 0x028E, // 7.57h
        StatusEffectListPlayerDouble = 0x03BA, // 7.57h
        UpdateRecastTimes = 0x00C8, // 7.57h
        UpdateDutyRecastTimes = 0x0353, // 7.57h
        UpdateDutyRecastTimes5 = 0x03B1, // 7.57h
        UpdateAllianceNormal = 0x0089, // 7.57h
        UpdateAllianceSmall = 0x0128, // 7.57h
        UpdatePartyMemberPositions = 0x0348, // 7.57h
        UpdateAllianceNormalMemberPositions = 0x02C5, // 7.57h
        UpdateAllianceSmallMemberPositions = 0x0206, // 7.57h
        GCAffiliation = 0x026A, // 7.57h
        GatheringLog = 0x0301, // 7.57h
        CraftingLog = 0x01E8, // 7.57h
        PlayerSpawn = 0x017C, // 7.57h
        NpcSpawn = 0x017D, // 7.57h
        BossSpawn = 0x01AB, // 7.57h
        DespawnCharacter = 0x0354, // 7.57h
        ActorMove = 0x0136, // 7.57h
        ActorSetPos = 0x0066, // 7.57h
        ActorCast = 0x007F, // 7.57h
        InitZone = 0x009C, // 7.57h
        UpdateHate = 0x03A6, // 7.57h
        UpdateHater = 0x0247, // 7.57h
        ObjectSpawn = 0x01ED, // 7.57h
        ObjectDespawn = 0x016E, // 7.57h
        UpdateClassInfo = 0x0335, // 7.57h
        UpdateClassInfoEureka = 0x031C, // 7.57h
        UpdateClassInfoBozja = 0x0294, // 7.57h
        UpdateClassInfoOccult = 0x016F, // 7.57h
        PlayerSetup = 0x02A6, // 7.57h
        PlayerStats = 0x036D, // 7.57h
        FirstAttack = 0x0236, // 7.57h
        PlayerStateFlags = 0x00C2, // 7.57h
        PlayerClassInfo = 0x018F, // 7.57h
        PlayerBlueMageActions = 0x03A5, // 7.57h
        ModelEquip = 0x0330, // 7.57h
        Examine = 0x019E, // 7.57h
        RetainerSummary = 0x01B3, // 7.57h
        RetainerInformation = 0x010F, // 7.57h
        ItemMarketBoardSummary = 0x0122, // 7.57h
        ItemMarketBoardInfo = 0x01D7, // 7.57h
        ItemInfo = 0x0239, // 7.57h
        ContainerInfo = 0x0340, // 7.57h
        InventoryTransactionFinish = 0x0272, // 7.57h
        InventoryTransaction = 0x01C9, // 7.57h
        CurrencyCrystalInfo = 0x02A2, // 7.57h
        InventoryActionAck = 0x0121, // 7.57h
        UpdateInventorySlot = 0x038D, // 7.57h
        EventPlay = 0x00B4, // 7.57h
        EventPlay4 = 0x0081, // 7.57h
        EventPlay8 = 0x00A3, // 7.57h
        EventPlay16 = 0x00E8, // 7.57h
        EventPlay32 = 0x01F0, // 7.57h
        EventPlay64 = 0x037C, // 7.57h
        EventPlay128 = 0x0364, // 7.57h
        EventPlay255 = 0x0076, // 7.57h
        EventStart = 0x0078, // 7.57h
        EventFinish = 0x01C3, // 7.57h
        ResultDialog = 0x020C, // 7.57h
        DesynthResult = 0x0211, // 7.57h
        MiniCactpotInit = 0x0146, // 7.57h
        EnvironmentControl = 0x01FE, // 7.57h
        EnvironmentControl4 = 0x0390, // 7.57h
        EnvironmentControl8 = 0x0124, // 7.57h
        EnvironmentControl12 = 0x010D, // 7.57h
        SystemLogMessage = 0x0250, // 7.57h
        SystemLogMessage2 = 0x0297, // 7.57h
        SystemLogMessage4 = 0x0321, // 7.57h
        SystemLogMessage8 = 0x0264, // 7.57h
        SystemLogMessage16 = 0x0317, // 7.57h
        BattleTalk2 = 0x03E5, // 7.57h
        BattleTalk4 = 0x02F7, // 7.57h
        BattleTalk8 = 0x02CE, // 7.57h
        MapUpdate = 0x0215, // 7.57h
        MapUpdate4 = 0x03B5, // 7.57h
        MapUpdate8 = 0x020A, // 7.57h
        MapUpdate16 = 0x0377, // 7.57h
        MapUpdate32 = 0x0271, // 7.57h
        MapUpdate64 = 0x030F, // 7.57h
        MapUpdate128 = 0x0346, // 7.57h
        BalloonTalk2 = 0x0141, // 7.57h
        BalloonTalk4 = 0x032B, // 7.57h
        BalloonTalk8 = 0x010A, // 7.57h
        WeatherChange = 0x01FB, // 7.57h
        PlayerTitleList = 0x0391, // 7.57h
        NpcYell = 0x0360, // 7.57h
        HousingWardInfo = 0x01EE, // 7.57h
        AirshipTimers = 0x032E, // 7.57h
        PlaceFieldMarkerPreset = 0x035E, // 7.57h
        PlaceFieldMarker = 0x03DA, // 7.57h
        AirshipStatusList = 0x024D, // 7.57h
        AirshipStatus = 0x03C8, // 7.57h
        AirshipExplorationResult = 0x0130, // 7.57h
        SubmarineStatusList = 0x0166, // 7.57h
        SubmarineProgressionStatus = 0x0345, // 7.57h
        SubmarineExplorationResult = 0x01DC, // 7.57h
        SubmarineTimers = 0x011A, // 7.57h
        PrepareZoning = 0x02E6, // 7.57h
        ActorGauge = 0x0326, // 7.57h
        FashionReport = 0x02D2, // 7.57h
        CEDirector = 0x034F, // 7.57h
        IslandWorkshopDemandResearch = 0x0318, // 7.57h
        IslandWorkshopSupplyDemand = 0x00D8, // 7.57h
        IslandWorkshopGranaryResult = 0x00B5, // 7.57h
        IslandWorkshopFavors = 0x0329, // 7.57h
        FishCaught = 0x006A, // 7.57h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x010E, // 7.57h
        ActionRequestGroundTargeted = 0x01EC, // 7.57h
        ChatHandler = 0x029F, // 7.57h
        ClientCountdownInitiate = 0x03B2, // 7.57h
        ClientTrigger = 0x037D, // 7.57h
        InventoryModifyHandler = 0x00E9, // 7.57h
        LogoutHandler = 0x0257, // 7.57h
        MarketBoardPurchaseHandler = 0x00F5, // 7.57h
        MarketBoardRequestItemListingInfo = 0x00F2, // 7.57h
        SetSearchInfoHandler = 0x01A8, // 7.57h
        UpdatePositionHandler = 0x0283, // 7.57h
        UpdatePositionInstance = 0x019A, // 7.57h
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