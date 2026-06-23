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
        Init = 0x0067, // 7.51h2
        Logout = 0x02F8, // 7.51h2
        CFCancel = 0x0149, // 7.51h2
        CFDutyInfo = 0x01C5, // 7.51h2
        CFNotify = 0x024B, // 7.51h2
        CFPreferredRole = 0x01D2, // 7.51h2
        PartyFinderList = 0x02F0, // 7.51h2
        CFRegistered = 0x0302, // 7.51h2
        Playtime = 0x03B9, // 7.51h2
        RSVData = 0x02A0, // 7.51h2
        RSFData = 0x01A9, // 7.51h2
        SocialMessage = 0x01CA, // 7.51h2
        SocialMessage2 = 0x02FD, // 7.51h2
        SocialList = 0x03A5, // 7.51h2
        SocialRequestResponse = 0x00B4, // 7.51h2
        ExamineSearchInfo = 0x0298, // 7.51h2
        UpdateSearchInfo = 0x02FE, // 7.51h2
        InitSearchInfo = 0x018F, // 7.51h2
        ServerNoticeShort = 0x015F, // 7.51h2
        ServerNotice = 0x0140, // 7.51h2
        SetOnlineStatus = 0x036B, // 7.51h2
        LogMessage = 0x010F, // 7.51h2
        Countdown = 0x0325, // 7.51h2
        CountdownCancel = 0x030B, // 7.51h2
        PartyMessage = 0x0184, // 7.51h2
        PlayerAddedToBlacklist = 0x0385, // 7.51h2
        PlayerRemovedFromBlacklist = 0x0340, // 7.51h2
        BlackList = 0x01EC, // 7.51h2
        MarketBoardItemListingCount = 0x0227, // 7.51h2
        MarketBoardItemListing = 0x00ED, // 7.51h2
        PlayerRetainerInfo = 0x02BB, // 7.51h2
        MarketBoardPurchase = 0x0297, // 7.51h2
        MarketBoardSale = 0x0104, // 7.51h2
        MarketBoardItemListingHistory = 0x0353, // 7.51h2
        RetainerSaleHistory = 0x00C5, // 7.51h2
        RetainerState = 0x0331, // 7.51h2
        MarketBoardSearchResult = 0x02CF, // 7.51h2
        FreeCompanyInfo = 0x00FF, // 7.51h2
        ExamineFreeCompanyInfo = 0x025B, // 7.51h2
        FreeCompanyDialog = 0x037C, // 7.51h2
        StatusEffectList = 0x0132, // 7.51h2
        StatusEffectListEureka = 0x0228, // 7.51h2
        StatusEffectListBozja = 0x0078, // 7.51h2
        StatusEffectListOccult = 0x035F, // 7.51h2
        StatusEffectListDouble = 0x0157, // 7.51h2
        EffectResult = 0x02EF, // 7.51h2
        EffectResult4 = 0x0259, // 7.51h2
        EffectResult8 = 0x026E, // 7.51h2
        EffectResult16 = 0x038C, // 7.51h2
        EffectResultBasic = 0x02FC, // 7.51h2
        EffectResultBasic4 = 0x03BC, // 7.51h2
        EffectResultBasic8 = 0x0158, // 7.51h2
        EffectResultBasic16 = 0x0129, // 7.51h2
        EffectResultBasic32 = 0x02C2, // 7.51h2
        EffectResultBasic64 = 0x03C9, // 7.51h2
        ActorControl = 0x019F, // 7.51h2
        ActorControlSelf = 0x0164, // 7.51h2
        ActorControlTarget = 0x02D1, // 7.51h2
        UpdateHpMpTp = 0x0156, // 7.51h2
        Effect = 0x037D, // 7.51h2
        AoeEffect8 = 0x0350, // 7.51h2
        AoeEffect16 = 0x027E, // 7.51h2
        AoeEffect24 = 0x01A4, // 7.51h2
        AoeEffect32 = 0x02A2, // 7.51h2
        StatusEffectListPlayer = 0x028B, // 7.51h2
        StatusEffectListPlayerDouble = 0x0239, // 7.51h2
        UpdateRecastTimes = 0x0344, // 7.51h2
        UpdateDutyRecastTimes = 0x0135, // 7.51h2
        UpdateDutyRecastTimes5 = 0x0287, // 7.51h2
        UpdateAllianceNormal = 0x01C6, // 7.51h2
        UpdateAllianceSmall = 0x023C, // 7.51h2
        UpdatePartyMemberPositions = 0x00E0, // 7.51h2
        UpdateAllianceNormalMemberPositions = 0x036C, // 7.51h2
        UpdateAllianceSmallMemberPositions = 0x0172, // 7.51h2
        GCAffiliation = 0x00EF, // 7.51h2
        GatheringLog = 0x02E5, // 7.51h2
        CraftingLog = 0x0341, // 7.51h2
        PlayerSpawn = 0x02E0, // 7.51h2
        NpcSpawn = 0x0378, // 7.51h2
        BossSpawn = 0x0188, // 7.51h2
        DespawnCharacter = 0x00BE, // 7.51h2
        ActorMove = 0x01CE, // 7.51h2
        ActorSetPos = 0x033E, // 7.51h2
        ActorCast = 0x01C9, // 7.51h2
        InitZone = 0x0337, // 7.51h2
        UpdateHate = 0x00C9, // 7.51h2
        UpdateHater = 0x01BA, // 7.51h2
        ObjectSpawn = 0x0362, // 7.51h2
        ObjectDespawn = 0x01E4, // 7.51h2
        UpdateClassInfo = 0x0394, // 7.51h2
        UpdateClassInfoEureka = 0x00B2, // 7.51h2
        UpdateClassInfoBozja = 0x0086, // 7.51h2
        UpdateClassInfoOccult = 0x038D, // 7.51h2
        PlayerSetup = 0x0110, // 7.51h2
        PlayerStats = 0x024E, // 7.51h2
        FirstAttack = 0x0351, // 7.51h2
        PlayerStateFlags = 0x00F4, // 7.51h2
        PlayerClassInfo = 0x018B, // 7.51h2
        PlayerBlueMageActions = 0x00A4, // 7.51h2
        ModelEquip = 0x0333, // 7.51h2
        Examine = 0x032C, // 7.51h2
        RetainerSummary = 0x00DD, // 7.51h2
        RetainerInformation = 0x0339, // 7.51h2
        ItemMarketBoardSummary = 0x0308, // 7.51h2
        ItemMarketBoardInfo = 0x00B9, // 7.51h2
        ItemInfo = 0x017C, // 7.51h2
        ContainerInfo = 0x0309, // 7.51h2
        InventoryTransactionFinish = 0x0161, // 7.51h2
        InventoryTransaction = 0x02A3, // 7.51h2
        CurrencyCrystalInfo = 0x013B, // 7.51h2
        InventoryActionAck = 0x0219, // 7.51h2
        UpdateInventorySlot = 0x0123, // 7.51h2
        EventPlay = 0x013E, // 7.51h2
        EventPlay4 = 0x01EB, // 7.51h2
        EventPlay8 = 0x02B5, // 7.51h2
        EventPlay16 = 0x0248, // 7.51h2
        EventPlay32 = 0x008A, // 7.51h2
        EventPlay64 = 0x01F2, // 7.51h2
        EventPlay128 = 0x02AC, // 7.51h2
        EventPlay255 = 0x016E, // 7.51h2
        EventStart = 0x0202, // 7.51h2
        EventFinish = 0x0072, // 7.51h2
        ResultDialog = 0x0249, // 7.51h2
        DesynthResult = 0x0107, // 7.51h2
        MiniCactpotInit = 0x03A6, // 7.51h2
        EnvironmentControl = 0x0080, // 7.51h2
        EnvironmentControl4 = 0x0196, // 7.51h2
        EnvironmentControl8 = 0x018D, // 7.51h2
        EnvironmentControl12 = 0x03D0, // 7.51h2
        SystemLogMessage = 0x020C, // 7.51h2
        SystemLogMessage2 = 0x0373, // 7.51h2
        SystemLogMessage4 = 0x024D, // 7.51h2
        SystemLogMessage8 = 0x0314, // 7.51h2
        SystemLogMessage16 = 0x037F, // 7.51h2
        BattleTalk2 = 0x014C, // 7.51h2
        BattleTalk4 = 0x01B4, // 7.51h2
        BattleTalk8 = 0x0379, // 7.51h2
        MapUpdate = 0x0068, // 7.51h2
        MapUpdate4 = 0x0254, // 7.51h2
        MapUpdate8 = 0x014F, // 7.51h2
        MapUpdate16 = 0x033B, // 7.51h2
        MapUpdate32 = 0x01D6, // 7.51h2
        MapUpdate64 = 0x00D4, // 7.51h2
        MapUpdate128 = 0x0343, // 7.51h2
        BalloonTalk2 = 0x0382, // 7.51h2
        BalloonTalk4 = 0x026D, // 7.51h2
        BalloonTalk8 = 0x00E5, // 7.51h2
        WeatherChange = 0x01AD, // 7.51h2
        PlayerTitleList = 0x006C, // 7.51h2
        NpcYell = 0x01B6, // 7.51h2
        HousingWardInfo = 0x0389, // 7.51h2
        AirshipTimers = 0x03C5, // 7.51h2
        PlaceFieldMarkerPreset = 0x0180, // 7.51h2
        PlaceFieldMarker = 0x0120, // 7.51h2
        AirshipStatusList = 0x0198, // 7.51h2
        AirshipStatus = 0x0291, // 7.51h2
        AirshipExplorationResult = 0x0093, // 7.51h2
        SubmarineStatusList = 0x035A, // 7.51h2
        SubmarineProgressionStatus = 0x02BA, // 7.51h2
        SubmarineExplorationResult = 0x006A, // 7.51h2
        SubmarineTimers = 0x0066, // 7.51h2
        PrepareZoning = 0x0225, // 7.51h2
        ActorGauge = 0x03A0, // 7.51h2
        CEDirector = 0x0377, // 7.51h2
        IslandWorkshopDemandResearch = 0x02DF, // 7.51h2
        IslandWorkshopSupplyDemand = 0x0295, // 7.51h2
        IslandWorkshopGranaryResult = 0x039F, // 7.51h2
        IslandWorkshopFavors = 0x00CA, // 7.51h2
        FishCaught = 0x0189, // 7.51h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02BC, // 7.51h2
        ActionRequestGroundTargeted = 0x01EA, // 7.51h2
        ChatHandler = 0x012C, // 7.51h2
        ClientCountdownInitiate = 0x0162, // 7.51h2
        ClientTrigger = 0x037C, // 7.51h2
        InventoryModifyHandler = 0x006D, // 7.51h2
        LogoutHandler = 0x007A, // 7.51h2
        MarketBoardPurchaseHandler = 0x010C, // 7.51h2
        SetSearchInfoHandler = 0x0190, // 7.51h2
        UpdatePositionHandler = 0x02C6, // 7.51h2
        UpdatePositionInstance = 0x02B1, // 7.51h2
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
