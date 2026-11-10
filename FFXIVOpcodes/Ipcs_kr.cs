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
        Init = 0x0092, // 7.58
        Logout = 0x00C7, // 7.58
        CFCancel = 0x0067, // 7.58
        CFDutyInfo = 0x00CF, // 7.58
        CFNotify = 0x03BF, // 7.58
        CFPreferredRole = 0x0332, // 7.58
        PartyFinderList = 0x0219, // 7.58
        CFRegistered = 0x02F0, // 7.58
        Playtime = 0x00F6, // 7.58
        RSVData = 0x0252, // 7.58
        RSFData = 0x0387, // 7.58
        SocialMessage = 0x01E8, // 7.58
        SocialMessage2 = 0x033F, // 7.58
        SocialList = 0x0103, // 7.58
        SocialRequestResponse = 0x038C, // 7.58
        ExamineSearchInfo = 0x03A2, // 7.58
        UpdateSearchInfo = 0x0193, // 7.58
        InitSearchInfo = 0x021C, // 7.58
        ServerNoticeShort = 0x0288, // 7.58
        ServerNotice = 0x02FB, // 7.58
        SetOnlineStatus = 0x0280, // 7.58
        LogMessage = 0x0221, // 7.58
        Countdown = 0x025C, // 7.58
        CountdownCancel = 0x0089, // 7.58
        PartyMessage = 0x0145, // 7.58
        PlayerAddedToBlacklist = 0x0391, // 7.58
        PlayerRemovedFromBlacklist = 0x02A4, // 7.58
        BlackList = 0x008E, // 7.58
        MarketBoardItemListingCount = 0x0265, // 7.58
        MarketBoardItemListing = 0x00B5, // 7.58
        PlayerRetainerInfo = 0x021B, // 7.58
        MarketBoardPurchase = 0x0107, // 7.58
        MarketBoardSale = 0x02B7, // 7.58
        MarketBoardItemListingHistory = 0x01EB, // 7.58
        RetainerSaleHistory = 0x0205, // 7.58
        RetainerState = 0x0298, // 7.58
        MarketBoardSearchResult = 0x03BA, // 7.58
        FreeCompanyInfo = 0x00CA, // 7.58
        ExamineFreeCompanyInfo = 0x03AD, // 7.58
        FreeCompanyDialog = 0x0235, // 7.58
        StatusEffectList = 0x015D, // 7.58
        StatusEffectListEureka = 0x01C4, // 7.58
        StatusEffectListBozja = 0x00A4, // 7.58
        StatusEffectListOccult = 0x0178, // 7.58
        StatusEffectListDouble = 0x0320, // 7.58
        EffectResult = 0x0293, // 7.58
        EffectResult4 = 0x0355, // 7.58
        EffectResult8 = 0x02C9, // 7.58
        EffectResult16 = 0x037B, // 7.58
        EffectResultBasic = 0x024A, // 7.58
        EffectResultBasic4 = 0x033B, // 7.58
        EffectResultBasic8 = 0x01AF, // 7.58
        EffectResultBasic16 = 0x025F, // 7.58
        EffectResultBasic32 = 0x0077, // 7.58
        EffectResultBasic64 = 0x01A6, // 7.58
        ActorControl = 0x02DF, // 7.58
        ActorControlSelf = 0x00A9, // 7.58
        ActorControlTarget = 0x0100, // 7.58
        UpdateHpMpTp = 0x03AC, // 7.58
        Effect = 0x0190, // 7.58
        AoeEffect8 = 0x0233, // 7.58
        AoeEffect16 = 0x0119, // 7.58
        AoeEffect24 = 0x039C, // 7.58
        AoeEffect32 = 0x00DD, // 7.58
        StatusEffectListPlayer = 0x035D, // 7.58
        StatusEffectListPlayerDouble = 0x02F8, // 7.58
        UpdateRecastTimes = 0x010D, // 7.58
        UpdateDutyRecastTimes = 0x038F, // 7.58
        UpdateDutyRecastTimes5 = 0x03B3, // 7.58
        UpdateAllianceNormal = 0x0308, // 7.58
        UpdateAllianceSmall = 0x00FD, // 7.58
        UpdatePartyMemberPositions = 0x03B2, // 7.58
        UpdateAllianceNormalMemberPositions = 0x02BE, // 7.58
        UpdateAllianceSmallMemberPositions = 0x030B, // 7.58
        GCAffiliation = 0x038D, // 7.58
        GatheringLog = 0x0249, // 7.58
        CraftingLog = 0x01A3, // 7.58
        PlayerSpawn = 0x02FC, // 7.58
        NpcSpawn = 0x0176, // 7.58
        BossSpawn = 0x02FD, // 7.58
        DespawnCharacter = 0x01BA, // 7.58
        ActorMove = 0x00AE, // 7.58
        ActorSetPos = 0x03A6, // 7.58
        ActorCast = 0x0160, // 7.58
        InitZone = 0x00AB, // 7.58
        UpdateHate = 0x02DA, // 7.58
        UpdateHater = 0x03D2, // 7.58
        ObjectSpawn = 0x00DB, // 7.58
        ObjectDespawn = 0x010B, // 7.58
        UpdateClassInfo = 0x01CC, // 7.58
        UpdateClassInfoEureka = 0x0136, // 7.58
        UpdateClassInfoBozja = 0x01F5, // 7.58
        UpdateClassInfoOccult = 0x007E, // 7.58
        PlayerSetup = 0x01AE, // 7.58
        PlayerStats = 0x018E, // 7.58
        FirstAttack = 0x02E3, // 7.58
        PlayerStateFlags = 0x007A, // 7.58
        PlayerClassInfo = 0x012D, // 7.58
        PlayerBlueMageActions = 0x02B9, // 7.58
        ModelEquip = 0x0172, // 7.58
        Examine = 0x0289, // 7.58
        RetainerSummary = 0x0251, // 7.58
        RetainerInformation = 0x01F6, // 7.58
        ItemMarketBoardSummary = 0x027C, // 7.58
        ItemMarketBoardInfo = 0x02FA, // 7.58
        ItemInfo = 0x03DA, // 7.58
        ContainerInfo = 0x0198, // 7.58
        InventoryTransactionFinish = 0x03B0, // 7.58
        InventoryTransaction = 0x033D, // 7.58
        CurrencyCrystalInfo = 0x02EC, // 7.58
        InventoryActionAck = 0x02C1, // 7.58
        UpdateInventorySlot = 0x013B, // 7.58
        EventPlay = 0x020B, // 7.58
        EventPlay4 = 0x0108, // 7.58
        EventPlay8 = 0x0231, // 7.58
        EventPlay16 = 0x006D, // 7.58
        EventPlay32 = 0x0072, // 7.58
        EventPlay64 = 0x0344, // 7.58
        EventPlay128 = 0x02BF, // 7.58
        EventPlay255 = 0x01E5, // 7.58
        EventStart = 0x039F, // 7.58
        EventFinish = 0x00B6, // 7.58
        ResultDialog = 0x025B, // 7.58
        DesynthResult = 0x00A5, // 7.58
        MiniCactpotInit = 0x03B1, // 7.58
        EnvironmentControl = 0x0097, // 7.58
        EnvironmentControl4 = 0x0247, // 7.58
        EnvironmentControl8 = 0x0165, // 7.58
        EnvironmentControl12 = 0x018A, // 7.58
        SystemLogMessage = 0x01DE, // 7.58
        SystemLogMessage2 = 0x01D2, // 7.58
        SystemLogMessage4 = 0x038B, // 7.58
        SystemLogMessage8 = 0x0271, // 7.58
        SystemLogMessage16 = 0x012F, // 7.58
        BattleTalk2 = 0x00EC, // 7.58
        BattleTalk4 = 0x016C, // 7.58
        BattleTalk8 = 0x0230, // 7.58
        MapUpdate = 0x0339, // 7.58
        MapUpdate4 = 0x0129, // 7.58
        MapUpdate8 = 0x0148, // 7.58
        MapUpdate16 = 0x00FA, // 7.58
        MapUpdate32 = 0x00F7, // 7.58
        MapUpdate64 = 0x0380, // 7.58
        MapUpdate128 = 0x033C, // 7.58
        BalloonTalk2 = 0x006B, // 7.58
        BalloonTalk4 = 0x0319, // 7.58
        BalloonTalk8 = 0x026C, // 7.58
        WeatherChange = 0x03C0, // 7.58
        PlayerTitleList = 0x009F, // 7.58
        NpcYell = 0x0345, // 7.58
        HousingWardInfo = 0x0270, // 7.58
        AirshipTimers = 0x014F, // 7.58
        PlaceFieldMarkerPreset = 0x0177, // 7.58
        PlaceFieldMarker = 0x00E9, // 7.58
        AirshipStatusList = 0x02F6, // 7.58
        AirshipStatus = 0x01EA, // 7.58
        AirshipExplorationResult = 0x00D3, // 7.58
        SubmarineStatusList = 0x00F2, // 7.58
        SubmarineProgressionStatus = 0x0199, // 7.58
        SubmarineExplorationResult = 0x0295, // 7.58
        SubmarineTimers = 0x0260, // 7.58
        PrepareZoning = 0x02B0, // 7.58
        ActorGauge = 0x0323, // 7.58
        FashionReport = 0x016D, // 7.58
        CEDirector = 0x026E, // 7.58
        IslandWorkshopDemandResearch = 0x034F, // 7.58
        IslandWorkshopSupplyDemand = 0x0325, // 7.58
        IslandWorkshopGranaryResult = 0x02AA, // 7.58
        IslandWorkshopFavors = 0x013C, // 7.58
        FishCaught = 0x0127, // 7.58
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0372, // 7.58
        ActionRequestGroundTargeted = 0x026F, // 7.58
        ChatHandler = 0x01BB, // 7.58
        ClientCountdownInitiate = 0x02E5, // 7.58
        ClientTrigger = 0x0235, // 7.58
        InventoryModifyHandler = 0x013E, // 7.58
        LogoutHandler = 0x0104, // 7.58
        MarketBoardPurchaseHandler = 0x0276, // 7.58
        MarketBoardRequestItemListingInfo = 0x03C7, // 7.58
        SetSearchInfoHandler = 0x0285, // 7.58
        UpdatePositionHandler = 0x022B, // 7.58
        UpdatePositionInstance = 0x03AA, // 7.58
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
