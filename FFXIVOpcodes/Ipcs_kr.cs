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
        ActorCast = 0x0162, // 7.3
        ActorControl = 0x038B, // 7.3
        ActorControlSelf = 0x034F, // 7.3
        ActorControlTarget = 0x0127, // 7.3
        ActorGauge = 0x034B, // 7.3
        ActorMove = 0x0208, // 7.3
        ActorSetPos = 0x0332, // 7.3
        AirshipExplorationResult = 0x01D2, // 7.3
        AirshipStatus = 0x01BE, // 7.3
        AirshipStatusList = 0x0166, // 7.3
        AirshipTimers = 0x02C1, // 7.3
        AoeEffect16 = 0x0273, // 7.3
        AoeEffect24 = 0x024C, // 7.3
        AoeEffect32 = 0x00B3, // 7.3
        AoeEffect8 = 0x012B, // 7.3
        ApplyIDScramble = 0x01A8, // 7.3
        BalloonTalk2 = 0x023B, // 7.3
        BalloonTalk4 = 0x006E, // 7.3
        BalloonTalk8 = 0x00B8, // 7.3
        BattleTalk2 = 0x00E3, // 7.3
        BattleTalk4 = 0x021A, // 7.3
        BattleTalk8 = 0x0067, // 7.3
        BlackList = 0x02B6, // 7.3
        CEDirector = 0x00D7, // 7.3
        CFCancel = 0x0160, // 7.3
        CFDutyInfo = 0x024D, // 7.3
        CFNotify = 0x031D, // 7.3
        CFPreferredRole = 0x0165, // 7.3
        CFRegistered = 0x02ED, // 7.3
        Chat = 0x029A, // 7.3
        ContainerInfo = 0x008C, // 7.3
        Countdown = 0x02E9, // 7.3
        CountdownCancel = 0x00F3, // 7.3
        CraftingCalculations = 0x00C4, // 7.3
        CrossWorldLinkshellList = 0x02A9, // 7.3
        CrossWorldLinkshellMember = 0x00D3, // 7.3
        CurrencyCrystalInfo = 0x03D2, // 7.3
        DespawnCharacter = 0x0290, // 7.3
        DesynthResult = 0x016E, // 7.3
        Effect = 0x00C6, // 7.3
        EffectResult = 0x0357, // 7.3
        EffectResult16 = 0x02B7, // 7.3
        EffectResult4 = 0x01C8, // 7.3
        EffectResult8 = 0x011C, // 7.3
        EffectResultBasic = 0x02F1, // 7.3
        EffectResultBasic16 = 0x03CF, // 7.3
        EffectResultBasic32 = 0x03C1, // 7.3
        EffectResultBasic4 = 0x00BA, // 7.3
        EffectResultBasic64 = 0x00DF, // 7.3
        EffectResultBasic8 = 0x0080, // 7.3
        EnvironmentControl = 0x0361, // 7.3
        EnvironmentControl12 = 0x017E, // 7.3
        EnvironmentControl4 = 0x0094, // 7.3
        EnvironmentControl8 = 0x0185, // 7.3
        EventFinish = 0x0089, // 7.3
        EventPlay = 0x0121, // 7.3
        EventPlay128 = 0x032F, // 7.3
        EventPlay16 = 0x0119, // 7.3
        EventPlay255 = 0x0323, // 7.3
        EventPlay32 = 0x01F4, // 7.3
        EventPlay4 = 0x0203, // 7.3
        EventPlay64 = 0x0349, // 7.3
        EventPlay8 = 0x0150, // 7.3
        EventStart = 0x00BE, // 7.3
        Examine = 0x0235, // 7.3
        ExamineFreeCompanyInfo = 0x02B0, // 7.3
        ExamineSearchInfo = 0x01E2, // 7.3
        FellowshipList = 0x00BC, // 7.3
        FellowshipSearchList = 0x00FD, // 7.3
        FirstAttack = 0x0212, // 7.3
        FreeCompanyDialog = 0x014E, // 7.3
        FreeCompanyInfo = 0x0107, // 7.3
        HousingObjectDye = 0x0097, // 7.3
        HousingObjectMove = 0x0340, // 7.3
        HousingWardInfo = 0x0192, // 7.3
        Init = 0x01D4, // 7.3
        InitZone = 0x01DC, // 7.3
        InventoryActionAck = 0x0175, // 7.3
        InventoryTransaction = 0x0362, // 7.3
        InventoryTransactionFinish = 0x0219, // 7.3
        IslandWorkshopDemandResearch = 0x0376, // 7.3
        IslandWorkshopFavors = 0x00ED, // 7.3
        IslandWorkshopSupplyDemand = 0x023A, // 7.3
        ItemInfo = 0x0106, // 7.3
        ItemMarketBoardInfo = 0x009B, // 7.3
        ItemMarketBoardSummary = 0x027B, // 7.3
        LogMessage = 0x0223, // 7.3
        Logout = 0x0274, // 7.3
        MapUpdate = 0x02A7, // 7.3
        MapUpdate128 = 0x0201, // 7.3
        MapUpdate16 = 0x01F7, // 7.3
        MapUpdate32 = 0x0267, // 7.3
        MapUpdate4 = 0x01AD, // 7.3
        MapUpdate64 = 0x02FE, // 7.3
        MapUpdate8 = 0x0140, // 7.3
        MarketBoardItemListing = 0x03DB, // 7.3
        MarketBoardItemListingCount = 0x02A4, // 7.3
        MarketBoardItemListingHistory = 0x014D, // 7.3
        MarketBoardPurchase = 0x017A, // 7.3
        MarketBoardSale = 0x008D, // 7.3
        MarketBoardSearchResult = 0x00D0, // 7.3
        MiniCactpotInit = 0x01F9, // 7.3
        ModelEquip = 0x0103, // 7.3
        Mount = 0x01DB, // 7.3
        NpcSpawn = 0x014C, // 7.3
        NpcSpawn2 = 0x0142, // 7.3
        NpcYell = 0x0226, // 7.3
        ObjectDespawn = 0x00F0, // 7.3
        ObjectSpawn = 0x0216, // 7.3
        PartyMessage = 0x00FB, // 7.3
        Ping = 0x0285, // 7.3
        PlaceFieldMarker = 0x03A1, // 7.3
        PlaceFieldMarkerPreset = 0x0102, // 7.3
        PlayerAddedToBlacklist = 0x0090, // 7.3
        PlayerBlueMageActions = 0x0112, // 7.3
        PlayerClassInfo = 0x0365, // 7.3
        PlayerRemovedFromBlacklist = 0x0199, // 7.3
        PlayerRetainerInfo = 0x00EC, // 7.3
        PlayerSetup = 0x03BF, // 7.3
        PlayerSpawn = 0x0301, // 7.3
        PlayerStateFlags = 0x025E, // 7.3
        PlayerStats = 0x0387, // 7.3
        PlayerUpdateLook = 0x00C5, // 7.3
        Playtime = 0x01B4, // 7.3
        PrepareZoning = 0x0293, // 7.3
        RetainerInformation = 0x02F4, // 7.3
        RetainerSaleHistory = 0x0232, // 7.3
        RetainerState = 0x00C1, // 7.3
        RetainerSummary = 0x0151, // 7.3
        RSFData = 0x0138, // 7.3
        RSVData = 0x00AE, // 7.3
        ServerNotice = 0x012C, // 7.3
        ServerNoticeShort = 0x00E4, // 7.3
        SetOnlineStatus = 0x0096, // 7.3
        SocialList = 0x0239, // 7.3
        SocialMessage = 0x03E4, // 7.3
        SocialMessage2 = 0x0115, // 7.3
        SocialRequestResponse = 0x0149, // 7.3
        StatusEffectList = 0x021C, // 7.3
        StatusEffectListBozja = 0x019B, // 7.3
        StatusEffectListDouble = 0x00D4, // 7.3
        StatusEffectListEureka = 0x0343, // 7.3
        StatusEffectListForay3 = 0x0196, // 7.3
        StatusEffectListPlayer = 0x01F5, // 7.3
        StatusEffectListPlayerDouble = 0x0120, // 7.3
        SubmarineExplorationResult = 0x0100, // 7.3
        SubmarineProgressionStatus = 0x01EB, // 7.3
        SubmarineStatusList = 0x030B, // 7.3
        SubmarineTimers = 0x013C, // 7.3
        SystemLogMessage = 0x016D, // 7.3
        SystemLogMessage16 = 0x01D8, // 7.3
        SystemLogMessage2 = 0x015D, // 7.3
        SystemLogMessage4 = 0x028C, // 7.3
        SystemLogMessage8 = 0x02D8, // 7.3
        UpdateAllianceNormal = 0x02D9, // 7.3
        UpdateAllianceNormalMemberPositions = 0x029C, // 7.3
        UpdateAllianceSmall = 0x03B3, // 7.3
        UpdateAllianceSmallMemberPositions = 0x00C9, // 7.3
        UpdateClassInfo = 0x0218, // 7.3
        UpdateClassInfoBozja = 0x00AA, // 7.3
        UpdateClassInfoEureka = 0x0076, // 7.3
        UpdateClassInfoForay3 = 0x03BC, // 7.3
        UpdateDutyRecastTimes = 0x00A8, // 7.3
        UpdateDutyRecastTimes5 = 0x036C, // 7.3
        UpdateHate = 0x0339, // 7.3
        UpdateHater = 0x01AF, // 7.3
        UpdateHpMpTp = 0x01B6, // 7.3
        UpdateInventorySlot = 0x02C8, // 7.3
        UpdateParty = 0x035A, // 7.3
        UpdatePartyMemberPositions = 0x039E, // 7.3
        UpdateRecastTimes = 0x0178, // 7.3
        UpdateSearchInfo = 0x02AB, // 7.3
        WeatherChange = 0x0268, // 7.3
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x014E, // 7.3
        ActionRequestGroundTargeted = 0x0085, // 7.3
        ChatHandler = 0x0399, // 7.3
        ClientCountdownInitiate = 0x0256, // 7.3
        ClientTrigger = 0x0107, // 7.3
        InventoryModifyHandler = 0x02BA, // 7.3
        LogoutHandler = 0x0305, // 7.3
        MarketBoardPurchaseHandler = 0x00EF, // 7.3
        SetSearchInfoHandler = 0x00E1, // 7.3
        UpdatePositionHandler = 0x0370, // 7.3
        UpdatePositionInstance = 0x01EE, // 7.3
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
