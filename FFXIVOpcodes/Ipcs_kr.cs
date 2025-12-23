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
        ActorCast = 0x0309, // 7.35
        ActorControl = 0x0181, // 7.35
        ActorControlSelf = 0x010A, // 7.35
        ActorControlTarget = 0x0132, // 7.35
        ActorGauge = 0x0164, // 7.35
        ActorMove = 0x00B8, // 7.35
        ActorSetPos = 0x00C8, // 7.35
        AirshipExplorationResult = 0x02EF, // 7.35
        AirshipStatus = 0x00AF, // 7.35
        AirshipStatusList = 0x03D1, // 7.35
        AirshipTimers = 0x0167, // 7.35
        AoeEffect16 = 0x0149, // 7.35
        AoeEffect24 = 0x02EC, // 7.35
        AoeEffect32 = 0x011A, // 7.35
        AoeEffect8 = 0x035C, // 7.35
        ApplyIDScramble = 0x00B3, // 7.35
        BalloonTalk2 = 0x02AF, // 7.35
        BalloonTalk4 = 0x0334, // 7.35
        BalloonTalk8 = 0x00EB, // 7.35
        BattleTalk2 = 0x016C, // 7.35
        BattleTalk4 = 0x0233, // 7.35
        BattleTalk8 = 0x0388, // 7.35
        BlackList = 0x02BC, // 7.35
        CEDirector = 0x0154, // 7.35
        CFCancel = 0x0205, // 7.35
        CFDutyInfo = 0x030F, // 7.35
        CFNotify = 0x0161, // 7.35
        CFPreferredRole = 0x0186, // 7.35
        CFRegistered = 0x03BC, // 7.35
        Chat = 0x0134, // 7.35
        ContainerInfo = 0x01F8, // 7.35
        Countdown = 0x036B, // 7.35
        CountdownCancel = 0x030E, // 7.35
        CraftingCalculations = 0x010C, // 7.35
        CrossWorldLinkshellList = 0x0256, // 7.35
        CrossWorldLinkshellMember = 0x0241, // 7.35
        CurrencyCrystalInfo = 0x0316, // 7.35
        DespawnCharacter = 0x00BA, // 7.35
        DesynthResult = 0x016E, // 7.35
        Effect = 0x0349, // 7.35
        EffectResult = 0x009C, // 7.35
        EffectResult16 = 0x0367, // 7.35
        EffectResult4 = 0x018F, // 7.35
        EffectResult8 = 0x032B, // 7.35
        EffectResultBasic = 0x0171, // 7.35
        EffectResultBasic16 = 0x01F2, // 7.35
        EffectResultBasic32 = 0x0198, // 7.35
        EffectResultBasic4 = 0x013B, // 7.35
        EffectResultBasic64 = 0x02D6, // 7.35
        EffectResultBasic8 = 0x02C7, // 7.35
        EnvironmentControl = 0x0342, // 7.35
        EnvironmentControl12 = 0x02A6, // 7.35
        EnvironmentControl4 = 0x029D, // 7.35
        EnvironmentControl8 = 0x0120, // 7.35
        EventFinish = 0x0378, // 7.35
        EventPlay = 0x03D6, // 7.35
        EventPlay128 = 0x0098, // 7.35
        EventPlay16 = 0x0084, // 7.35
        EventPlay255 = 0x01D5, // 7.35
        EventPlay32 = 0x025B, // 7.35
        EventPlay4 = 0x0234, // 7.35
        EventPlay64 = 0x01AE, // 7.35
        EventPlay8 = 0x0310, // 7.35
        EventStart = 0x00EE, // 7.35
        Examine = 0x01C2, // 7.35
        ExamineFreeCompanyInfo = 0x03C2, // 7.35
        ExamineSearchInfo = 0x0145, // 7.35
        FashionReport = 0x025C, // 7.35
        FellowshipList = 0x0169, // 7.35
        FellowshipSearchList = 0x0374, // 7.35
        FirstAttack = 0x0121, // 7.35
        FreeCompanyDialog = 0x0166, // 7.35
        FreeCompanyInfo = 0x01DB, // 7.35
        HousingObjectDye = 0x0099, // 7.35
        HousingObjectMove = 0x009B, // 7.35
        HousingWardInfo = 0x0237, // 7.35
        Init = 0x00ED, // 7.35
        InitZone = 0x009D, // 7.35
        InventoryActionAck = 0x016D, // 7.35
        InventoryTransaction = 0x02A8, // 7.35
        InventoryTransactionFinish = 0x039C, // 7.35
        IslandWorkshopDemandResearch = 0x03AA, // 7.35
        IslandWorkshopFavors = 0x009F, // 7.35
        IslandWorkshopSupplyDemand = 0x0182, // 7.35
        ItemInfo = 0x008F, // 7.35
        ItemMarketBoardInfo = 0x027B, // 7.35
        ItemMarketBoardSummary = 0x03D8, // 7.35
        LogMessage = 0x0394, // 7.35
        Logout = 0x0363, // 7.35
        MapUpdate = 0x037E, // 7.35
        MapUpdate128 = 0x0257, // 7.35
        MapUpdate16 = 0x01B6, // 7.35
        MapUpdate32 = 0x00F0, // 7.35
        MapUpdate4 = 0x021F, // 7.35
        MapUpdate64 = 0x011B, // 7.35
        MapUpdate8 = 0x0071, // 7.35
        MarketBoardItemListing = 0x03A5, // 7.35
        MarketBoardItemListingCount = 0x0275, // 7.35
        MarketBoardItemListingHistory = 0x02B4, // 7.35
        MarketBoardPurchase = 0x0340, // 7.35
        MarketBoardSale = 0x019B, // 7.35
        MarketBoardSearchResult = 0x0312, // 7.35
        MiniCactpotInit = 0x00FF, // 7.35
        ModelEquip = 0x0365, // 7.35
        Mount = 0x00F4, // 7.35
        NpcSpawn = 0x03C7, // 7.35
        NpcSpawn2 = 0x0314, // 7.35
        NpcYell = 0x0329, // 7.35
        ObjectDespawn = 0x0255, // 7.35
        ObjectSpawn = 0x03E1, // 7.35
        PartyMessage = 0x032C, // 7.35
        Ping = 0x01E3, // 7.35
        PlaceFieldMarker = 0x03A3, // 7.35
        PlaceFieldMarkerPreset = 0x00C9, // 7.35
        PlayerAddedToBlacklist = 0x01D2, // 7.35
        PlayerBlueMageActions = 0x021E, // 7.35
        PlayerClassInfo = 0x03E7, // 7.35
        PlayerRemovedFromBlacklist = 0x037C, // 7.35
        PlayerRetainerInfo = 0x03A6, // 7.35
        PlayerSetup = 0x00CE, // 7.35
        PlayerSpawn = 0x0068, // 7.35
        PlayerStateFlags = 0x0327, // 7.35
        PlayerStats = 0x0153, // 7.35
        PlayerUpdateLook = 0x00FE, // 7.35
        Playtime = 0x02FF, // 7.35
        PrepareZoning = 0x01D4, // 7.35
        ResultDialog = 0x013A, // 7.35
        RetainerInformation = 0x00D6, // 7.35
        RetainerSaleHistory = 0x0251, // 7.35
        RetainerState = 0x024B, // 7.35
        RetainerSummary = 0x036F, // 7.35
        RSFData = 0x0384, // 7.35
        RSVData = 0x03A7, // 7.35
        ServerNotice = 0x020F, // 7.35
        ServerNoticeShort = 0x035A, // 7.35
        SetOnlineStatus = 0x00F6, // 7.35
        SocialList = 0x033B, // 7.35
        SocialMessage = 0x02D2, // 7.35
        SocialMessage2 = 0x00B9, // 7.35
        SocialRequestResponse = 0x0101, // 7.35
        StatusEffectList = 0x00D1, // 7.35
        StatusEffectListBozja = 0x01E8, // 7.35
        StatusEffectListDouble = 0x01A0, // 7.35
        StatusEffectListEureka = 0x00CF, // 7.35
        StatusEffectListForay3 = 0x0281, // 7.35
        StatusEffectListPlayer = 0x01D6, // 7.35
        StatusEffectListPlayerDouble = 0x01CD, // 7.35
        SubmarineExplorationResult = 0x02B0, // 7.35
        SubmarineProgressionStatus = 0x0328, // 7.35
        SubmarineStatusList = 0x0391, // 7.35
        SubmarineTimers = 0x00C4, // 7.35
        SystemLogMessage = 0x0209, // 7.35
        SystemLogMessage16 = 0x00F2, // 7.35
        SystemLogMessage2 = 0x0246, // 7.35
        SystemLogMessage4 = 0x014E, // 7.35
        SystemLogMessage8 = 0x0116, // 7.35
        UpdateAllianceNormal = 0x00A6, // 7.35
        UpdateAllianceNormalMemberPositions = 0x035E, // 7.35
        UpdateAllianceSmall = 0x0208, // 7.35
        UpdateAllianceSmallMemberPositions = 0x01FD, // 7.35
        UpdateClassInfo = 0x0189, // 7.35
        UpdateClassInfoBozja = 0x0330, // 7.35
        UpdateClassInfoEureka = 0x01F5, // 7.35
        UpdateClassInfoForay3 = 0x01EF, // 7.35
        UpdateDutyRecastTimes = 0x02D7, // 7.35
        UpdateDutyRecastTimes5 = 0x037A, // 7.35
        UpdateHate = 0x0252, // 7.35
        UpdateHater = 0x026D, // 7.35
        UpdateHpMpTp = 0x01E6, // 7.35
        UpdateInventorySlot = 0x00DF, // 7.35
        UpdateParty = 0x02BA, // 7.35
        UpdatePartyMemberPositions = 0x033A, // 7.35
        UpdateRecastTimes = 0x038D, // 7.35
        UpdateSearchInfo = 0x0207, // 7.35
        WeatherChange = 0x0382, // 7.35
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0166, // 7.35
        ActionRequestGroundTargeted = 0x031B, // 7.35
        ChatHandler = 0x034A, // 7.35
        ClientCountdownInitiate = 0x0279, // 7.35
        ClientTrigger = 0x01DB, // 7.35
        InventoryModifyHandler = 0x0073, // 7.35
        LogoutHandler = 0x0203, // 7.35
        MarketBoardPurchaseHandler = 0x00B4, // 7.35
        SetSearchInfoHandler = 0x0223, // 7.35
        UpdatePositionHandler = 0x02AC, // 7.35
        UpdatePositionInstance = 0x01BA, // 7.35
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
