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
        Init = 0x0245, // 7.57
        Logout = 0x030D, // 7.57
        CFCancel = 0x02ED, // 7.57
        CFDutyInfo = 0x012C, // 7.57
        CFNotify = 0x028A, // 7.57
        CFPreferredRole = 0x00CE, // 7.57
        PartyFinderList = 0x0192, // 7.57
        CFRegistered = 0x02EE, // 7.57
        Playtime = 0x007A, // 7.57
        RSVData = 0x0112, // 7.57
        RSFData = 0x0399, // 7.57
        SocialMessage = 0x016B, // 7.57
        SocialMessage2 = 0x00E0, // 7.57
        SocialList = 0x038C, // 7.57
        SocialRequestResponse = 0x037B, // 7.57
        ExamineSearchInfo = 0x01CD, // 7.57
        UpdateSearchInfo = 0x0365, // 7.57
        InitSearchInfo = 0x006F, // 7.57
        ServerNoticeShort = 0x0290, // 7.57
        ServerNotice = 0x0139, // 7.57
        SetOnlineStatus = 0x013D, // 7.57
        LogMessage = 0x01D3, // 7.57
        Countdown = 0x01A4, // 7.57
        CountdownCancel = 0x0173, // 7.57
        PartyMessage = 0x03DC, // 7.57
        PlayerAddedToBlacklist = 0x03AF, // 7.57
        PlayerRemovedFromBlacklist = 0x015B, // 7.57
        BlackList = 0x025E, // 7.57
        MarketBoardItemListingCount = 0x010D, // 7.57
        MarketBoardItemListing = 0x0234, // 7.57
        PlayerRetainerInfo = 0x02C8, // 7.57
        MarketBoardPurchase = 0x0262, // 7.57
        MarketBoardSale = 0x01B6, // 7.57
        MarketBoardItemListingHistory = 0x011E, // 7.57
        RetainerSaleHistory = 0x0340, // 7.57
        RetainerState = 0x00F9, // 7.57
        MarketBoardSearchResult = 0x03C0, // 7.57
        FreeCompanyInfo = 0x03B9, // 7.57
        ExamineFreeCompanyInfo = 0x0098, // 7.57
        FreeCompanyDialog = 0x0368, // 7.57
        StatusEffectList = 0x02CE, // 7.57
        StatusEffectListEureka = 0x025A, // 7.57
        StatusEffectListBozja = 0x021B, // 7.57
        StatusEffectListOccult = 0x022B, // 7.57
        StatusEffectListDouble = 0x039B, // 7.57
        EffectResult = 0x00F2, // 7.57
        EffectResult4 = 0x02E3, // 7.57
        EffectResult8 = 0x03B8, // 7.57
        EffectResult16 = 0x0162, // 7.57
        EffectResultBasic = 0x0225, // 7.57
        EffectResultBasic4 = 0x0277, // 7.57
        EffectResultBasic8 = 0x0154, // 7.57
        EffectResultBasic16 = 0x00CD, // 7.57
        EffectResultBasic32 = 0x0108, // 7.57
        EffectResultBasic64 = 0x0189, // 7.57
        ActorControl = 0x0198, // 7.57
        ActorControlSelf = 0x01E6, // 7.57
        ActorControlTarget = 0x00C8, // 7.57
        UpdateHpMpTp = 0x03B7, // 7.57
        Effect = 0x00BD, // 7.57
        AoeEffect8 = 0x013F, // 7.57
        AoeEffect16 = 0x0390, // 7.57
        AoeEffect24 = 0x009E, // 7.57
        AoeEffect32 = 0x0276, // 7.57
        StatusEffectListPlayer = 0x0097, // 7.57
        StatusEffectListPlayerDouble = 0x0328, // 7.57
        UpdateRecastTimes = 0x008B, // 7.57
        UpdateDutyRecastTimes = 0x03BA, // 7.57
        UpdateDutyRecastTimes5 = 0x0354, // 7.57
        UpdateAllianceNormal = 0x01F4, // 7.57
        UpdateAllianceSmall = 0x01E1, // 7.57
        UpdatePartyMemberPositions = 0x0134, // 7.57
        UpdateAllianceNormalMemberPositions = 0x0311, // 7.57
        UpdateAllianceSmallMemberPositions = 0x0275, // 7.57
        GCAffiliation = 0x018E, // 7.57
        GatheringLog = 0x03D9, // 7.57
        CraftingLog = 0x038E, // 7.57
        PlayerSpawn = 0x0265, // 7.57
        NpcSpawn = 0x0114, // 7.57
        BossSpawn = 0x02F2, // 7.57
        DespawnCharacter = 0x01DC, // 7.57
        ActorMove = 0x0217, // 7.57
        ActorSetPos = 0x03E0, // 7.57
        ActorCast = 0x0301, // 7.57
        InitZone = 0x02CC, // 7.57
        UpdateHate = 0x02A1, // 7.57
        UpdateHater = 0x00AB, // 7.57
        ObjectSpawn = 0x0193, // 7.57
        ObjectDespawn = 0x02D2, // 7.57
        UpdateClassInfo = 0x0250, // 7.57
        UpdateClassInfoEureka = 0x02FB, // 7.57
        UpdateClassInfoBozja = 0x026E, // 7.57
        UpdateClassInfoOccult = 0x0299, // 7.57
        PlayerSetup = 0x0302, // 7.57
        PlayerStats = 0x0251, // 7.57
        FirstAttack = 0x0176, // 7.57
        PlayerStateFlags = 0x0326, // 7.57
        PlayerClassInfo = 0x00B5, // 7.57
        PlayerBlueMageActions = 0x027A, // 7.57
        ModelEquip = 0x03D5, // 7.57
        Examine = 0x019C, // 7.57
        RetainerSummary = 0x0078, // 7.57
        RetainerInformation = 0x01D2, // 7.57
        ItemMarketBoardSummary = 0x012F, // 7.57
        ItemMarketBoardInfo = 0x0183, // 7.57
        ItemInfo = 0x00D1, // 7.57
        ContainerInfo = 0x02DB, // 7.57
        InventoryTransactionFinish = 0x0088, // 7.57
        InventoryTransaction = 0x032D, // 7.57
        CurrencyCrystalInfo = 0x031E, // 7.57
        InventoryActionAck = 0x0291, // 7.57
        UpdateInventorySlot = 0x02A3, // 7.57
        EventPlay = 0x0256, // 7.57
        EventPlay4 = 0x0324, // 7.57
        EventPlay8 = 0x009B, // 7.57
        EventPlay16 = 0x01DB, // 7.57
        EventPlay32 = 0x01C5, // 7.57
        EventPlay64 = 0x01CB, // 7.57
        EventPlay128 = 0x028C, // 7.57
        EventPlay255 = 0x02F6, // 7.57
        EventStart = 0x0286, // 7.57
        EventFinish = 0x01A8, // 7.57
        ResultDialog = 0x0201, // 7.57
        DesynthResult = 0x0366, // 7.57
        MiniCactpotInit = 0x01FE, // 7.57
        EnvironmentControl = 0x01A6, // 7.57
        EnvironmentControl4 = 0x02B4, // 7.57
        EnvironmentControl8 = 0x0323, // 7.57
        EnvironmentControl12 = 0x0137, // 7.57
        SystemLogMessage = 0x00EB, // 7.57
        SystemLogMessage2 = 0x0360, // 7.57
        SystemLogMessage4 = 0x02F3, // 7.57
        SystemLogMessage8 = 0x0231, // 7.57
        SystemLogMessage16 = 0x0122, // 7.57
        BattleTalk2 = 0x00A2, // 7.57
        BattleTalk4 = 0x0381, // 7.57
        BattleTalk8 = 0x0194, // 7.57
        MapUpdate = 0x0091, // 7.57
        MapUpdate4 = 0x0166, // 7.57
        MapUpdate8 = 0x0161, // 7.57
        MapUpdate16 = 0x03D7, // 7.57
        MapUpdate32 = 0x0294, // 7.57
        MapUpdate64 = 0x026D, // 7.57
        MapUpdate128 = 0x02DC, // 7.57
        BalloonTalk2 = 0x023A, // 7.57
        BalloonTalk4 = 0x0267, // 7.57
        BalloonTalk8 = 0x02C9, // 7.57
        WeatherChange = 0x0254, // 7.57
        PlayerTitleList = 0x01BD, // 7.57
        NpcYell = 0x0065, // 7.57
        HousingWardInfo = 0x0153, // 7.57
        AirshipTimers = 0x0178, // 7.57
        PlaceFieldMarkerPreset = 0x01F8, // 7.57
        PlaceFieldMarker = 0x0281, // 7.57
        AirshipStatusList = 0x03A5, // 7.57
        AirshipStatus = 0x0389, // 7.57
        AirshipExplorationResult = 0x0125, // 7.57
        SubmarineStatusList = 0x0367, // 7.57
        SubmarineProgressionStatus = 0x02DA, // 7.57
        SubmarineExplorationResult = 0x01F2, // 7.57
        SubmarineTimers = 0x039C, // 7.57
        PrepareZoning = 0x0130, // 7.57
        ActorGauge = 0x02EC, // 7.57
        FashionReport = 0x035B, // 7.57
        CEDirector = 0x020A, // 7.57
        IslandWorkshopDemandResearch = 0x02F5, // 7.57
        IslandWorkshopSupplyDemand = 0x0199, // 7.57
        IslandWorkshopGranaryResult = 0x031C, // 7.57
        IslandWorkshopFavors = 0x029F, // 7.57
        FishCaught = 0x03CB, // 7.57
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x00B0, // 7.57
        ActionRequestGroundTargeted = 0x034E, // 7.57
        ChatHandler = 0x02E7, // 7.57
        ClientCountdownInitiate = 0x01B1, // 7.57
        ClientTrigger = 0x0368, // 7.57
        InventoryModifyHandler = 0x011B, // 7.57
        LogoutHandler = 0x0076, // 7.57
        MarketBoardPurchaseHandler = 0x0102, // 7.57
        MarketBoardRequestItemListingInfo = 0x0248, // 7.57
        SetSearchInfoHandler = 0x02DD, // 7.57
        UpdatePositionHandler = 0x0327, // 7.57
        UpdatePositionInstance = 0x0233, // 7.57
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