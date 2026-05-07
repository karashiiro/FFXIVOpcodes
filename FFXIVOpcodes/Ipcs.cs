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
        // Server Zone
        Init = 0x025F, // 7.5h
        Logout = 0x01B8, // 7.5h
        CFCancel = 0x00CE, // 7.5h
        CFDutyInfo = 0x01DE, // 7.5h
        CFNotify = 0x007E, // 7.5h
        CFPreferredRole = 0x00B3, // 7.5h
        PartyFinderList = 0x00FD, // 7.5h
        CFRegistered = 0x032E, // 7.5h
        Playtime = 0x0199, // 7.5h
        RSVData = 0x01BB, // 7.5h
        RSFData = 0x03A2, // 7.5h
        SocialMessage = 0x00A2, // 7.5h
        SocialMessage2 = 0x012C, // 7.5h
        SocialList = 0x02F0, // 7.5h
        SocialRequestResponse = 0x00E8, // 7.5h
        ExamineSearchInfo = 0x0290, // 7.5h
        UpdateSearchInfo = 0x00C5, // 7.5h
        InitSearchInfo = 0x0339, // 7.5h
        ServerNoticeShort = 0x00BF, // 7.5h
        ServerNotice = 0x0370, // 7.5h
        SetOnlineStatus = 0x0130, // 7.5h
        LogMessage = 0x01C7, // 7.5h
        Countdown = 0x033F, // 7.5h
        CountdownCancel = 0x0300, // 7.5h
        PartyMessage = 0x02B9, // 7.5h
        PlayerAddedToBlacklist = 0x031C, // 7.5h
        PlayerRemovedFromBlacklist = 0x02FA, // 7.5h
        BlackList = 0x02BE, // 7.5h
        MarketBoardItemListingCount = 0x02E8, // 7.5h
        MarketBoardItemListing = 0x032D, // 7.5h
        PlayerRetainerInfo = 0x0126, // 7.5h
        MarketBoardPurchase = 0x02C6, // 7.5h
        MarketBoardSale = 0x022C, // 7.5h
        MarketBoardItemListingHistory = 0x01CC, // 7.5h
        RetainerSaleHistory = 0x00B9, // 7.5h
        RetainerState = 0x0281, // 7.5h
        MarketBoardSearchResult = 0x02CD, // 7.5h
        FreeCompanyInfo = 0x0364, // 7.5h
        ExamineFreeCompanyInfo = 0x0091, // 7.5h
        FreeCompanyDialog = 0x0292, // 7.5h
        StatusEffectList = 0x0065, // 7.5h
        StatusEffectListEureka = 0x03D5, // 7.5h
        StatusEffectListBozja = 0x01AA, // 7.5h
        StatusEffectListOccult = 0x0142, // 7.5h
        StatusEffectListDouble = 0x03AC, // 7.5h
        EffectResult = 0x00C2, // 7.5h
        EffectResult4 = 0x0280, // 7.5h
        EffectResult8 = 0x02A5, // 7.5h
        EffectResult16 = 0x00D4, // 7.5h
        EffectResultBasic = 0x03E3, // 7.5h
        EffectResultBasic4 = 0x026A, // 7.5h
        EffectResultBasic8 = 0x01F1, // 7.5h
        EffectResultBasic16 = 0x03B1, // 7.5h
        EffectResultBasic32 = 0x01FE, // 7.5h
        EffectResultBasic64 = 0x02F4, // 7.5h
        ActorControl = 0x0343, // 7.5h
        ActorControlSelf = 0x020E, // 7.5h
        ActorControlTarget = 0x03DB, // 7.5h
        UpdateHpMpTp = 0x0288, // 7.5h
        Effect = 0x01FF, // 7.5h
        AoeEffect8 = 0x0283, // 7.5h
        AoeEffect16 = 0x0309, // 7.5h
        AoeEffect24 = 0x0115, // 7.5h
        AoeEffect32 = 0x029A, // 7.5h
        StatusEffectListPlayer = 0x0249, // 7.5h
        StatusEffectListPlayerDouble = 0x00E7, // 7.5h
        UpdateRecastTimes = 0x0131, // 7.5h
        UpdateDutyRecastTimes = 0x02EC, // 7.5h
        UpdateDutyRecastTimes5 = 0x02C8, // 7.5h
        UpdateAllianceNormal = 0x01B5, // 7.5h
        UpdateAllianceSmall = 0x024A, // 7.5h
        UpdatePartyMemberPositions = 0x0391, // 7.5h
        UpdateAllianceNormalMemberPositions = 0x006B, // 7.5h
        UpdateAllianceSmallMemberPositions = 0x026C, // 7.5h
        GCAffiliation = 0x01C6, // 7.5h
        GatheringLog = 0x0305, // 7.5h
        CraftingLog = 0x0073, // 7.5h
        PlayerSpawn = 0x02AA, // 7.5h
        NpcSpawn = 0x00F6, // 7.5h
        BossSpawn = 0x00A1, // 7.5h
        DespawnCharacter = 0x00F7, // 7.5h
        ActorMove = 0x0095, // 7.5h
        ActorSetPos = 0x01C0, // 7.5h
        ActorCast = 0x025C, // 7.5h
        InitZone = 0x0237, // 7.5h
        UpdateHate = 0x0297, // 7.5h
        UpdateHater = 0x0069, // 7.5h
        ObjectSpawn = 0x006E, // 7.5h
        ObjectDespawn = 0x0377, // 7.5h
        UpdateClassInfo = 0x027A, // 7.5h
        UpdateClassInfoEureka = 0x0265, // 7.5h
        UpdateClassInfoBozja = 0x0389, // 7.5h
        UpdateClassInfoOccult = 0x0240, // 7.5h
        PlayerSetup = 0x01D6, // 7.5h
        PlayerStats = 0x00FB, // 7.5h
        FirstAttack = 0x0384, // 7.5h
        PlayerStateFlags = 0x02CF, // 7.5h
        PlayerClassInfo = 0x0188, // 7.5h
        PlayerBlueMageActions = 0x016E, // 7.5h
        ModelEquip = 0x00B6, // 7.5h
        Examine = 0x02C4, // 7.5h
        RetainerSummary = 0x02BB, // 7.5h
        RetainerInformation = 0x0307, // 7.5h
        ItemMarketBoardSummary = 0x030F, // 7.5h
        ItemMarketBoardInfo = 0x01CF, // 7.5h
        ItemInfo = 0x01A0, // 7.5h
        ContainerInfo = 0x031A, // 7.5h
        InventoryTransactionFinish = 0x01F7, // 7.5h
        InventoryTransaction = 0x0318, // 7.5h
        CurrencyCrystalInfo = 0x014B, // 7.5h
        InventoryActionAck = 0x0217, // 7.5h
        UpdateInventorySlot = 0x0111, // 7.5h
        EventPlay = 0x010F, // 7.5h
        EventPlay4 = 0x0264, // 7.5h
        EventPlay8 = 0x0202, // 7.5h
        EventPlay16 = 0x0395, // 7.5h
        EventPlay32 = 0x0181, // 7.5h
        EventPlay64 = 0x020A, // 7.5h
        EventPlay128 = 0x02E7, // 7.5h
        EventPlay255 = 0x02C1, // 7.5h
        EventStart = 0x034C, // 7.5h
        EventFinish = 0x03A7, // 7.5h
        ResultDialog = 0x03C6, // 7.5h
        DesynthResult = 0x0277, // 7.5h
        MiniCactpotInit = 0x00D6, // 7.5h
        EnvironmentControl = 0x0338, // 7.5h
        EnvironmentControl4 = 0x03A6, // 7.5h
        EnvironmentControl8 = 0x0360, // 7.5h
        EnvironmentControl12 = 0x02D8, // 7.5h
        SystemLogMessage = 0x013F, // 7.5h
        SystemLogMessage2 = 0x0289, // 7.5h
        SystemLogMessage4 = 0x0315, // 7.5h
        SystemLogMessage8 = 0x020B, // 7.5h
        SystemLogMessage16 = 0x03DC, // 7.5h
        BattleTalk2 = 0x028C, // 7.5h
        BattleTalk4 = 0x036B, // 7.5h
        BattleTalk8 = 0x01AB, // 7.5h
        MapUpdate = 0x0123, // 7.5h
        MapUpdate4 = 0x02B8, // 7.5h
        MapUpdate8 = 0x0348, // 7.5h
        MapUpdate16 = 0x0170, // 7.5h
        MapUpdate32 = 0x03B4, // 7.5h
        MapUpdate64 = 0x033C, // 7.5h
        MapUpdate128 = 0x0324, // 7.5h
        BalloonTalk2 = 0x0308, // 7.5h
        BalloonTalk4 = 0x0068, // 7.5h
        BalloonTalk8 = 0x01E0, // 7.5h
        WeatherChange = 0x03BB, // 7.5h
        PlayerTitleList = 0x0239, // 7.5h
        NpcYell = 0x02A7, // 7.5h
        HousingWardInfo = 0x036E, // 7.5h
        AirshipTimers = 0x021A, // 7.5h
        PlaceFieldMarkerPreset = 0x0347, // 7.5h
        PlaceFieldMarker = 0x01A5, // 7.5h
        AirshipStatusList = 0x0186, // 7.5h
        AirshipStatus = 0x021F, // 7.5h
        AirshipExplorationResult = 0x01EA, // 7.5h
        SubmarineStatusList = 0x0247, // 7.5h
        SubmarineProgressionStatus = 0x0279, // 7.5h
        SubmarineExplorationResult = 0x00F5, // 7.5h
        SubmarineTimers = 0x0163, // 7.5h
        PrepareZoning = 0x017C, // 7.5h
        ActorGauge = 0x0210, // 7.5h
        CEDirector = 0x016C, // 7.5h
        IslandWorkshopDemandResearch = 0x00A6, // 7.5h
        IslandWorkshopSupplyDemand = 0x029C, // 7.5h
        IslandWorkshopGranaryResult = 0x00D1, // 7.5h
        IslandWorkshopFavors = 0x02B3, // 7.5h
        FishCaught = 0x00B2, // 7.5h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02FF, // 7.5h
        ActionRequestGroundTargeted = 0x0132, // 7.5h
        ChatHandler = 0x0128, // 7.5h
        ClientCountdownInitiate = 0x00DA, // 7.5h
        ClientTrigger = 0x0292, // 7.5h
        InventoryModifyHandler = 0x028F, // 7.5h
        LogoutHandler = 0x00E3, // 7.5h
        MarketBoardPurchaseHandler = 0x0201, // 7.5h
        SetSearchInfoHandler = 0x00B4, // 7.5h
        UpdatePositionHandler = 0x007C, // 7.5h
        UpdatePositionInstance = 0x02F9, // 7.5h
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