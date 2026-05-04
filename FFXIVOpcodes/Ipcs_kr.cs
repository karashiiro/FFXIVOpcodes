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
        Init = 0x029C, // 7.5
        Logout = 0x0334, // 7.5
        CFCancel = 0x01C7, // 7.5
        CFDutyInfo = 0x0104, // 7.5
        CFNotify = 0x025F, // 7.5
        CFPreferredRole = 0x0280, // 7.5
        PartyFinderList = 0x01B7, // 7.5
        CFRegistered = 0x02EA, // 7.5
        Playtime = 0x025C, // 7.5
        RSVData = 0x030B, // 7.5
        RSFData = 0x0223, // 7.5
        SocialMessage = 0x031F, // 7.5
        SocialMessage2 = 0x0131, // 7.5
        SocialList = 0x028A, // 7.5
        SocialRequestResponse = 0x01FB, // 7.5
        ExamineSearchInfo = 0x0113, // 7.5
        UpdateSearchInfo = 0x00F2, // 7.5
        InitSearchInfo = 0x00AB, // 7.5
        ServerNoticeShort = 0x0310, // 7.5
        ServerNotice = 0x00A2, // 7.5
        SetOnlineStatus = 0x0369, // 7.5
        LogMessage = 0x01E4, // 7.5
        Countdown = 0x02E2, // 7.5
        CountdownCancel = 0x0193, // 7.5
        PartyMessage = 0x0125, // 7.5
        PlayerAddedToBlacklist = 0x0209, // 7.5
        PlayerRemovedFromBlacklist = 0x0152, // 7.5
        BlackList = 0x0093, // 7.5
        MarketBoardItemListingCount = 0x0342, // 7.5
        MarketBoardItemListing = 0x036F, // 7.5
        PlayerRetainerInfo = 0x0081, // 7.5
        MarketBoardPurchase = 0x01F7, // 7.5
        MarketBoardSale = 0x03C2, // 7.5
        MarketBoardItemListingHistory = 0x020A, // 7.5
        RetainerSaleHistory = 0x0366, // 7.5
        RetainerState = 0x015B, // 7.5
        MarketBoardSearchResult = 0x00E3, // 7.5
        FreeCompanyInfo = 0x00BE, // 7.5
        ExamineFreeCompanyInfo = 0x01B2, // 7.5
        FreeCompanyDialog = 0x00B9, // 7.5
        StatusEffectList = 0x0117, // 7.5
        StatusEffectListEureka = 0x010E, // 7.5
        StatusEffectListBozja = 0x03DC, // 7.5
        StatusEffectListOccult = 0x012B, // 7.5
        StatusEffectListDouble = 0x0232, // 7.5
        EffectResult = 0x00EA, // 7.5
        EffectResult4 = 0x0088, // 7.5
        EffectResult8 = 0x00F4, // 7.5
        EffectResult16 = 0x0157, // 7.5
        EffectResultBasic = 0x01C3, // 7.5
        EffectResultBasic4 = 0x00D2, // 7.5
        EffectResultBasic8 = 0x009B, // 7.5
        EffectResultBasic16 = 0x02C9, // 7.5
        EffectResultBasic32 = 0x038F, // 7.5
        EffectResultBasic64 = 0x03B7, // 7.5
        ActorControl = 0x0328, // 7.5
        ActorControlSelf = 0x03E7, // 7.5
        ActorControlTarget = 0x03AA, // 7.5
        UpdateHpMpTp = 0x03BD, // 7.5
        Effect = 0x039A, // 7.5
        AoeEffect8 = 0x01F2, // 7.5
        AoeEffect16 = 0x0240, // 7.5
        AoeEffect24 = 0x01CA, // 7.5
        AoeEffect32 = 0x03C8, // 7.5
        StatusEffectListPlayer = 0x0336, // 7.5
        StatusEffectListPlayerDouble = 0x03A9, // 7.5
        UpdateRecastTimes = 0x02FE, // 7.5
        UpdateDutyRecastTimes = 0x02EE, // 7.5
        UpdateDutyRecastTimes5 = 0x02D3, // 7.5
        UpdateAllianceNormal = 0x0350, // 7.5
        UpdateAllianceSmall = 0x0173, // 7.5
        UpdatePartyMemberPositions = 0x02AD, // 7.5
        UpdateAllianceNormalMemberPositions = 0x01F3, // 7.5
        UpdateAllianceSmallMemberPositions = 0x00DD, // 7.5
        GCAffiliation = 0x0161, // 7.5
        GatheringLog = 0x0204, // 7.5
        CraftingLog = 0x026C, // 7.5
        PlayerSpawn = 0x0343, // 7.5
        NpcSpawn = 0x02AE, // 7.5
        NpcSpawn2 = 0x0249, // 7.5
        DespawnCharacter = 0x0251, // 7.5
        ActorMove = 0x00D3, // 7.5
        ActorSetPos = 0x0154, // 7.5
        ActorCast = 0x0345, // 7.5
        InitZone = 0x0098, // 7.5
        UpdateHate = 0x010C, // 7.5
        UpdateHater = 0x0265, // 7.5
        ObjectSpawn = 0x0245, // 7.5
        ObjectDespawn = 0x0260, // 7.5
        UpdateClassInfo = 0x022C, // 7.5
        UpdateClassInfoEureka = 0x02C0, // 7.5
        UpdateClassInfoBozja = 0x03B4, // 7.5
        UpdateClassInfoOccult = 0x02E3, // 7.5
        PlayerSetup = 0x0354, // 7.5
        PlayerStats = 0x0072, // 7.5
        FirstAttack = 0x0114, // 7.5
        PlayerStateFlags = 0x0203, // 7.5
        PlayerClassInfo = 0x035F, // 7.5
        PlayerBlueMageActions = 0x015C, // 7.5
        ModelEquip = 0x009E, // 7.5
        Examine = 0x0100, // 7.5
        RetainerSummary = 0x0371, // 7.5
        RetainerInformation = 0x02ED, // 7.5
        ItemMarketBoardSummary = 0x025A, // 7.5
        ItemMarketBoardInfo = 0x02C2, // 7.5
        ItemInfo = 0x013B, // 7.5
        ContainerInfo = 0x01DC, // 7.5
        InventoryTransactionFinish = 0x0205, // 7.5
        InventoryTransaction = 0x03DF, // 7.5
        CurrencyCrystalInfo = 0x0103, // 7.5
        InventoryActionAck = 0x030A, // 7.5
        UpdateInventorySlot = 0x00BC, // 7.5
        EventPlay = 0x03B9, // 7.5
        EventPlay4 = 0x0175, // 7.5
        EventPlay8 = 0x0230, // 7.5
        EventPlay16 = 0x034E, // 7.5
        EventPlay32 = 0x0296, // 7.5
        EventPlay64 = 0x00C3, // 7.5
        EventPlay128 = 0x00C2, // 7.5
        EventPlay255 = 0x00B2, // 7.5
        EventStart = 0x02C1, // 7.5
        EventFinish = 0x020F, // 7.5
        ResultDialog = 0x023F, // 7.5
        DesynthResult = 0x0227, // 7.5
        MiniCactpotInit = 0x026D, // 7.5
        EnvironmentControl = 0x01FF, // 7.5
        EnvironmentControl4 = 0x02CC, // 7.5
        EnvironmentControl8 = 0x0138, // 7.5
        EnvironmentControl12 = 0x02C7, // 7.5
        SystemLogMessage = 0x01E2, // 7.5
        SystemLogMessage2 = 0x02D1, // 7.5
        SystemLogMessage4 = 0x02DF, // 7.5
        SystemLogMessage8 = 0x03C9, // 7.5
        SystemLogMessage16 = 0x0394, // 7.5
        BattleTalk2 = 0x03CB, // 7.5
        BattleTalk4 = 0x010B, // 7.5
        BattleTalk8 = 0x01BE, // 7.5
        MapUpdate = 0x0299, // 7.5
        MapUpdate4 = 0x01DA, // 7.5
        MapUpdate8 = 0x03A0, // 7.5
        MapUpdate16 = 0x008C, // 7.5
        MapUpdate32 = 0x00C1, // 7.5
        MapUpdate64 = 0x0390, // 7.5
        MapUpdate128 = 0x0333, // 7.5
        BalloonTalk2 = 0x0194, // 7.5
        BalloonTalk4 = 0x0387, // 7.5
        BalloonTalk8 = 0x02A3, // 7.5
        WeatherChange = 0x0120, // 7.5
        PlayerTitleList = 0x02BA, // 7.5
        NpcYell = 0x0388, // 7.5
        HousingWardInfo = 0x00EF, // 7.5
        AirshipTimers = 0x008F, // 7.5
        PlaceFieldMarkerPreset = 0x0235, // 7.5
        PlaceFieldMarker = 0x02D7, // 7.5
        AirshipStatusList = 0x0338, // 7.5
        AirshipStatus = 0x0191, // 7.5
        AirshipExplorationResult = 0x014B, // 7.5
        SubmarineStatusList = 0x030C, // 7.5
        SubmarineProgressionStatus = 0x0294, // 7.5
        SubmarineExplorationResult = 0x03B8, // 7.5
        SubmarineTimers = 0x019C, // 7.5
        PrepareZoning = 0x032C, // 7.5
        ActorGauge = 0x0322, // 7.5
        CEDirector = 0x02F1, // 7.5
        IslandWorkshopDemandResearch = 0x01F8, // 7.5
        IslandWorkshopSupplyDemand = 0x01D1, // 7.5
        IslandWorkshopGranaryResult = 0x0166, // 7.5
        IslandWorkshopFavors = 0x0167, // 7.5
        FishCaught = 0x0323, // 7.5
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02FA, // 7.5
        ActionRequestGroundTargeted = 0x01CD, // 7.5
        ChatHandler = 0x01EE, // 7.5
        ClientCountdownInitiate = 0x03A4, // 7.5
        ClientTrigger = 0x00B9, // 7.5
        InventoryModifyHandler = 0x02D5, // 7.5
        LogoutHandler = 0x03A3, // 7.5
        MarketBoardPurchaseHandler = 0x0244, // 7.5
        SetSearchInfoHandler = 0x02B7, // 7.5
        UpdatePositionHandler = 0x012C, // 7.5
        UpdatePositionInstance = 0x023A, // 7.5
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
