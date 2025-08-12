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
        ActorCast = 0x00A4, // 7.21
        ActorControl = 0x01FE, // 7.21
        ActorControlSelf = 0x0311, // 7.21
        ActorControlTarget = 0x0217, // 7.21
        ActorGauge = 0x00AC, // 7.21
        ActorMove = 0x0268, // 7.21
        ActorSetPos = 0x0390, // 7.21
        AirshipExplorationResult = 0x03AF, // 7.21
        AirshipStatus = 0x00B9, // 7.21
        AirshipStatusList = 0x0101, // 7.21
        AirshipTimers = 0x0156, // 7.21
        AoeEffect16 = 0x0270, // 7.21
        AoeEffect24 = 0x025B, // 7.21
        AoeEffect32 = 0x00DF, // 7.21
        AoeEffect8 = 0x03CE, // 7.21
        ApplyIDScramble = 0x023B, // 7.21
        BalloonTalk2 = 0x0292, // 7.21
        BalloonTalk4 = 0x01F9, // 7.21
        BalloonTalk8 = 0x034D, // 7.21
        BattleTalk2 = 0x01F6, // 7.21
        BattleTalk4 = 0x0089, // 7.21
        BattleTalk8 = 0x0374, // 7.21
        CEDirector = 0x0347, // 7.21
        CFCancel = 0x02C5, // 7.21
        CFDutyInfo = 0x0184, // 7.21
        CFNotify = 0x01FC, // 7.21
        CFPreferredRole = 0x01D1, // 7.21
        CFRegistered = 0x0123, // 7.21
        Chat = 0x0245, // 7.21
        ContainerInfo = 0x00BE, // 7.21
        Countdown = 0x008E, // 7.21
        CountdownCancel = 0x01E8, // 7.21
        CraftingCalculations = 0x028A, // 7.21
        CrossWorldLinkshellList = 0x01C2, // 7.21
        CurrencyCrystalInfo = 0x0238, // 7.21
        DespawnCharacter = 0x027E, // 7.21
        DesynthResult = 0x0219, // 7.21
        Discovery = 0x02FD, // 7.21
        Effect = 0x0088, // 7.21
        EffectResult = 0x00BD, // 7.21
        EffectResult16 = 0x02BF, // 7.21
        EffectResult4 = 0x03B0, // 7.21
        EffectResult8 = 0x0276, // 7.21
        EffectResultBasic = 0x03E5, // 7.21
        EffectResultBasic16 = 0x0144, // 7.21
        EffectResultBasic32 = 0x0265, // 7.21
        EffectResultBasic4 = 0x00DA, // 7.21
        EffectResultBasic64 = 0x02EA, // 7.21
        EffectResultBasic8 = 0x013C, // 7.21
        EnvironmentControl = 0x0367, // 7.21
        EnvironmentControl12 = 0x00E2, // 7.21
        EnvironmentControl4 = 0x0108, // 7.21
        EnvironmentControl8 = 0x02D5, // 7.21
        EorzeaTimeOffset = 0x01C9, // 7.21
        EquipDisplayFlags = 0x0369, // 7.21
        EventFinish = 0x01F7, // 7.21
        EventPlay = 0x01DC, // 7.21
        EventPlay128 = 0x034A, // 7.21
        EventPlay16 = 0x021D, // 7.21
        EventPlay255 = 0x0230, // 7.21
        EventPlay32 = 0x01D9, // 7.21
        EventPlay4 = 0x01B9, // 7.21
        EventPlay64 = 0x0323, // 7.21
        EventPlay8 = 0x01A6, // 7.21
        EventStart = 0x0319, // 7.21
        Examine = 0x006D, // 7.21
        ExamineSearchComment = 0x0069, // 7.21
        ExamineSearchInfo = 0x0397, // 7.21
        FateInfo = 0x00EA, // 7.21
        FellowshipList = 0x0185, // 7.21
        FirstAttack = 0x02DD, // 7.21
        FreeCompanyDialog = 0x02A8, // 7.21
        FreeCompanyInfo = 0x007C, // 7.21
        HousingWardInfo = 0x019B, // 7.21
        Init = 0x01A9, // 7.21
        InitSearchInfo = 0x00E8, // 7.21
        InitZone = 0x022B, // 7.21
        InventoryActionAck = 0x03C9, // 7.21
        InventoryTransaction = 0x01D4, // 7.21
        InventoryTransactionFinish = 0x00FE, // 7.21
        IslandWorkshopDemandResearch = 0x019F, // 7.21
        IslandWorkshopFavors = 0x00BF, // 7.21
        IslandWorkshopSupplyDemand = 0x02FB, // 7.21
        ItemInfo = 0x02A2, // 7.21
        ItemMarketBoardInfo = 0x0111, // 7.21
        ItemMarketBoardSummary = 0x02B5, // 7.21
        LogMessage = 0x0187, // 7.21
        Logout = 0x0110, // 7.21
        MapUpdate = 0x03D7, // 7.21
        MapUpdate128 = 0x0277, // 7.21
        MapUpdate16 = 0x0242, // 7.21
        MapUpdate32 = 0x014A, // 7.21
        MapUpdate4 = 0x0302, // 7.21
        MapUpdate64 = 0x00E3, // 7.21
        MapUpdate8 = 0x0195, // 7.21
        MarketBoardItemListing = 0x0361, // 7.21
        MarketBoardItemListingCount = 0x0143, // 7.21
        MarketBoardItemListingHistory = 0x00B2, // 7.21
        MarketBoardPurchase = 0x02C9, // 7.21
        MarketBoardSale = 0x0253, // 7.21
        MarketBoardSearchResult = 0x03E7, // 7.21
        MiniCactpotInit = 0x034E, // 7.21
        ModelEquip = 0x011E, // 7.21
        Mount = 0x00A5, // 7.21
        NpcSpawn = 0x027A, // 7.21
        NpcSpawn2 = 0x037F, // 7.21
        NpcYell = 0x0155, // 7.21
        ObjectDespawn = 0x0136, // 7.21
        ObjectSpawn = 0x01AF, // 7.21
        Ping = 0x02A0, // 7.21
        PlaceFieldMarker = 0x03C4, // 7.21
        PlaceFieldMarkerPreset = 0x0273, // 7.21
        PlayerBlueMageActions = 0x0359, // 7.21
        PlayerClassInfo = 0x00BA, // 7.21
        PlayerRetainerInfo = 0x0297, // 7.21
        PlayerSetup = 0x0321, // 7.21
        PlayerSpawn = 0x01E5, // 7.21
        PlayerStateFlags = 0x00D0, // 7.21
        PlayerStats = 0x018F, // 7.21
        PlayerTitleList = 0x0378, // 7.21
        PlayerUpdateLook = 0x0300, // 7.21
        Playtime = 0x024E, // 7.21
        PrepareZoning = 0x020F, // 7.21
        ResultDialog = 0x01C0, // 7.21
        RetainerInformation = 0x030F, // 7.21
        RetainerSaleHistory = 0x0336, // 7.21
        RetainerState = 0x036C, // 7.21
        RetainerSummary = 0x00EF, // 7.21
        RSFData = 0x0283, // 7.21
        RSVData = 0x01A2, // 7.21
        ServerNotice = 0x01E4, // 7.21
        ServerNoticeShort = 0x02D2, // 7.21
        SetOnlineStatus = 0x02A5, // 7.21
        SocialList = 0x03D2, // 7.21
        SocialMessage = 0x0206, // 7.21
        SocialMessage2 = 0x0188, // 7.21
        SocialRequestResponse = 0x03CB, // 7.21
        StatusEffectList = 0x02BE, // 7.21
        StatusEffectListBozja = 0x025C, // 7.21
        StatusEffectListDouble = 0x03BA, // 7.21
        StatusEffectListEureka = 0x0109, // 7.21
        StatusEffectListForay3 = 0x00F5, // 7.21
        StatusEffectListPlayer = 0x0087, // 7.21
        StatusEffectListPlayerDouble = 0x00C3, // 7.21
        SubmarineExplorationResult = 0x0251, // 7.21
        SubmarineProgressionStatus = 0x01B8, // 7.21
        SubmarineStatusList = 0x0285, // 7.21
        SubmarineTimers = 0x015C, // 7.21
        SystemLogMessage = 0x02CB, // 7.21
        SystemLogMessage144 = 0x00A2, // 7.21
        SystemLogMessage32 = 0x0346, // 7.21
        SystemLogMessage48 = 0x0258, // 7.21
        SystemLogMessage80 = 0x0098, // 7.21
        UpdateAllianceNormal = 0x032A, // 7.21
        UpdateAllianceNormalMemberPositions = 0x017F, // 7.21
        UpdateAllianceSmall = 0x0382, // 7.21
        UpdateAllianceSmallMemberPositions = 0x0159, // 7.21
        UpdateClassInfo = 0x0377, // 7.21
        UpdateClassInfoBozja = 0x03CD, // 7.21
        UpdateClassInfoEureka = 0x02C8, // 7.21
        UpdateClassInfoForay3 = 0x00FC, // 7.21
        UpdateDutyRecastTimes = 0x039D, // 7.21
        UpdateDutyRecastTimes5 = 0x0102, // 7.21
        UpdateHate = 0x024A, // 7.21
        UpdateHater = 0x02F3, // 7.21
        UpdateHpMpTp = 0x00C9, // 7.21
        UpdateInventorySlot = 0x0211, // 7.21
        UpdateParty = 0x03E3, // 7.21
        UpdatePartyMemberPositions = 0x00D1, // 7.21
        UpdateRecastTimes = 0x0065, // 7.21
        UpdateSearchInfo = 0x022F, // 7.21
        WeatherChange = 0x0295, // 7.21
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x015E, // 7.21
        ActionRequestGroundTargeted = 0x039E, // 7.21
        ChatHandler = 0x03B8,// 7.21
        ClientCountdownInitiate = 0x00DE, // 7.21
        ClientTrigger = 0x039C,// 7.21
        InventoryModifyHandler = 0x010E,// 7.21
        LogoutHandler = 0x02C5, // 7.21
        MarketBoardPurchaseHandler = 0x02A9,// 7.21
        SetSearchInfoHandler = 0x024F,// 7.21
        UpdatePositionHandler = 0x01BF,// 7.21
        UpdatePositionInstance = 0x0223,// 7.21
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
