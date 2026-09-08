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
        Init = 0x03D8, // 7.56
        Logout = 0x02F5, // 7.56
        CFCancel = 0x031B, // 7.56
        CFDutyInfo = 0x02FC, // 7.56
        CFNotify = 0x0080, // 7.56
        CFPreferredRole = 0x02F3, // 7.56
        PartyFinderList = 0x0267, // 7.56
        CFRegistered = 0x034E, // 7.56
        Playtime = 0x0172, // 7.56
        RSVData = 0x0333, // 7.56
        RSFData = 0x0339, // 7.56
        SocialMessage = 0x0395, // 7.56
        SocialMessage2 = 0x02A6, // 7.56
        SocialList = 0x0120, // 7.56
        SocialRequestResponse = 0x0308, // 7.56
        ExamineSearchInfo = 0x0071, // 7.56
        UpdateSearchInfo = 0x02E6, // 7.56
        InitSearchInfo = 0x03B9, // 7.56
        ServerNoticeShort = 0x0167, // 7.56
        ServerNotice = 0x037A, // 7.56
        SetOnlineStatus = 0x0291, // 7.56
        LogMessage = 0x0137, // 7.56
        Countdown = 0x021E, // 7.56
        CountdownCancel = 0x011E, // 7.56
        PartyMessage = 0x039E, // 7.56
        PlayerAddedToBlacklist = 0x02BD, // 7.56
        PlayerRemovedFromBlacklist = 0x0369, // 7.56
        BlackList = 0x013D, // 7.56
        MarketBoardItemListingCount = 0x0324, // 7.56
        MarketBoardItemListing = 0x027B, // 7.56
        PlayerRetainerInfo = 0x0361, // 7.56
        MarketBoardPurchase = 0x0088, // 7.56
        MarketBoardSale = 0x03AB, // 7.56
        MarketBoardItemListingHistory = 0x02FE, // 7.56
        RetainerSaleHistory = 0x01DC, // 7.56
        RetainerState = 0x03E0, // 7.56
        MarketBoardSearchResult = 0x0111, // 7.56
        FreeCompanyInfo = 0x0310, // 7.56
        ExamineFreeCompanyInfo = 0x01B6, // 7.56
        FreeCompanyDialog = 0x0129, // 7.56
        StatusEffectList = 0x0248, // 7.56
        StatusEffectListEureka = 0x018D, // 7.56
        StatusEffectListBozja = 0x00B5, // 7.56
        StatusEffectListOccult = 0x0162, // 7.56
        StatusEffectListDouble = 0x02E1, // 7.56
        EffectResult = 0x01B0, // 7.56
        EffectResult4 = 0x02F9, // 7.56
        EffectResult8 = 0x0381, // 7.56
        EffectResult16 = 0x01EC, // 7.56
        EffectResultBasic = 0x02F4, // 7.56
        EffectResultBasic4 = 0x00BF, // 7.56
        EffectResultBasic8 = 0x00D7, // 7.56
        EffectResultBasic16 = 0x02B1, // 7.56
        EffectResultBasic32 = 0x02AD, // 7.56
        EffectResultBasic64 = 0x0148, // 7.56
        ActorControl = 0x038C, // 7.56
        ActorControlSelf = 0x0258, // 7.56
        ActorControlTarget = 0x024F, // 7.56
        UpdateHpMpTp = 0x0390, // 7.56
        Effect = 0x02EC, // 7.56
        AoeEffect8 = 0x00FD, // 7.56
        AoeEffect16 = 0x0357, // 7.56
        AoeEffect24 = 0x00B4, // 7.56
        AoeEffect32 = 0x014E, // 7.56
        StatusEffectListPlayer = 0x020D, // 7.56
        StatusEffectListPlayerDouble = 0x024A, // 7.56
        UpdateRecastTimes = 0x014A, // 7.56
        UpdateDutyRecastTimes = 0x02BA, // 7.56
        UpdateDutyRecastTimes5 = 0x01C3, // 7.56
        UpdateAllianceNormal = 0x00D8, // 7.56
        UpdateAllianceSmall = 0x015B, // 7.56
        UpdatePartyMemberPositions = 0x032C, // 7.56
        UpdateAllianceNormalMemberPositions = 0x03CF, // 7.56
        UpdateAllianceSmallMemberPositions = 0x0075, // 7.56
        GCAffiliation = 0x00CC, // 7.56
        GatheringLog = 0x01D9, // 7.56
        CraftingLog = 0x0098, // 7.56
        PlayerSpawn = 0x03B2, // 7.56
        NpcSpawn = 0x01C4, // 7.56
        BossSpawn = 0x026A, // 7.56
        DespawnCharacter = 0x03A3, // 7.56
        ActorMove = 0x0334, // 7.56
        ActorSetPos = 0x03A2, // 7.56
        ActorCast = 0x010A, // 7.56
        InitZone = 0x03A1, // 7.56
        UpdateHate = 0x010E, // 7.56
        UpdateHater = 0x02DA, // 7.56
        ObjectSpawn = 0x030D, // 7.56
        ObjectDespawn = 0x006F, // 7.56
        UpdateClassInfo = 0x020B, // 7.56
        UpdateClassInfoEureka = 0x01E9, // 7.56
        UpdateClassInfoBozja = 0x0152, // 7.56
        UpdateClassInfoOccult = 0x00E2, // 7.56
        PlayerSetup = 0x01DD, // 7.56
        PlayerStats = 0x031D, // 7.56
        FirstAttack = 0x0234, // 7.56
        PlayerStateFlags = 0x03D4, // 7.56
        PlayerClassInfo = 0x02C3, // 7.56
        PlayerBlueMageActions = 0x034F, // 7.56
        ModelEquip = 0x0374, // 7.56
        Examine = 0x0069, // 7.56
        RetainerSummary = 0x015A, // 7.56
        RetainerInformation = 0x00A2, // 7.56
        ItemMarketBoardSummary = 0x033A, // 7.56
        ItemMarketBoardInfo = 0x03B3, // 7.56
        ItemInfo = 0x0073, // 7.56
        ContainerInfo = 0x03E1, // 7.56
        InventoryTransactionFinish = 0x0183, // 7.56
        InventoryTransaction = 0x024E, // 7.56
        CurrencyCrystalInfo = 0x0068, // 7.56
        InventoryActionAck = 0x032A, // 7.56
        UpdateInventorySlot = 0x02D8, // 7.56
        EventPlay = 0x01F1, // 7.56
        EventPlay4 = 0x0089, // 7.56
        EventPlay8 = 0x0338, // 7.56
        EventPlay16 = 0x0368, // 7.56
        EventPlay32 = 0x0221, // 7.56
        EventPlay64 = 0x0216, // 7.56
        EventPlay128 = 0x037F, // 7.56
        EventPlay255 = 0x02CB, // 7.56
        EventStart = 0x00F2, // 7.56
        EventFinish = 0x0372, // 7.56
        ResultDialog = 0x03E6, // 7.56
        DesynthResult = 0x0278, // 7.56
        MiniCactpotInit = 0x0335, // 7.56
        EnvironmentControl = 0x00B1, // 7.56
        EnvironmentControl4 = 0x0243, // 7.56
        EnvironmentControl8 = 0x0085, // 7.56
        EnvironmentControl12 = 0x00D2, // 7.56
        SystemLogMessage = 0x03BE, // 7.56
        SystemLogMessage2 = 0x0284, // 7.56
        SystemLogMessage4 = 0x0262, // 7.56
        SystemLogMessage8 = 0x0281, // 7.56
        SystemLogMessage16 = 0x024B, // 7.56
        BattleTalk2 = 0x0155, // 7.56
        BattleTalk4 = 0x020C, // 7.56
        BattleTalk8 = 0x01F5, // 7.56
        MapUpdate = 0x029D, // 7.56
        MapUpdate4 = 0x0331, // 7.56
        MapUpdate8 = 0x0194, // 7.56
        MapUpdate16 = 0x0391, // 7.56
        MapUpdate32 = 0x0185, // 7.56
        MapUpdate64 = 0x006E, // 7.56
        MapUpdate128 = 0x024C, // 7.56
        BalloonTalk2 = 0x01AF, // 7.56
        BalloonTalk4 = 0x0307, // 7.56
        BalloonTalk8 = 0x0151, // 7.56
        WeatherChange = 0x03C4, // 7.56
        PlayerTitleList = 0x0379, // 7.56
        NpcYell = 0x00CA, // 7.56
        HousingWardInfo = 0x0250, // 7.56
        AirshipTimers = 0x02F8, // 7.56
        PlaceFieldMarkerPreset = 0x008D, // 7.56
        PlaceFieldMarker = 0x00E9, // 7.56
        AirshipStatusList = 0x00BC, // 7.56
        AirshipStatus = 0x0285, // 7.56
        AirshipExplorationResult = 0x01C1, // 7.56
        SubmarineStatusList = 0x01A9, // 7.56
        SubmarineProgressionStatus = 0x0275, // 7.56
        SubmarineExplorationResult = 0x0082, // 7.56
        SubmarineTimers = 0x0222, // 7.56
        PrepareZoning = 0x0318, // 7.56
        ActorGauge = 0x028B, // 7.56
        FashionReport = 0x00D0, // 7.56
        CEDirector = 0x0393, // 7.56
        IslandWorkshopDemandResearch = 0x0340, // 7.56
        IslandWorkshopSupplyDemand = 0x0370, // 7.56
        IslandWorkshopGranaryResult = 0x00E4, // 7.56
        IslandWorkshopFavors = 0x02EB, // 7.56
        FishCaught = 0x019D, // 7.56
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x032B, // 7.56
        ActionRequestGroundTargeted = 0x00D4, // 7.56
        ChatHandler = 0x019F, // 7.56
        ClientCountdownInitiate = 0x033F, // 7.56
        ClientTrigger = 0x0129, // 7.56
        InventoryModifyHandler = 0x00FE, // 7.56
        LogoutHandler = 0x017E, // 7.56
        MarketBoardPurchaseHandler = 0x036C, // 7.56
        MarketBoardRequestItemListingInfo = 0x025D, // 7.56
        SetSearchInfoHandler = 0x00C3, // 7.56
        UpdatePositionHandler = 0x03BC, // 7.56
        UpdatePositionInstance = 0x011F, // 7.56
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