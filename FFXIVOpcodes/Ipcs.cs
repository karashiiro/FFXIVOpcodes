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
        Init = 0x0257, // 7.55h2
        Logout = 0x00AB, // 7.55h2
        CFCancel = 0x02C6, // 7.55h2
        CFDutyInfo = 0x017C, // 7.55h2
        CFNotify = 0x0197, // 7.55h2
        CFPreferredRole = 0x0110, // 7.55h2
        PartyFinderList = 0x006B, // 7.55h2
        CFRegistered = 0x03BB, // 7.55h2
        Playtime = 0x013F, // 7.55h2
        RSVData = 0x0111, // 7.55h2
        RSFData = 0x01FE, // 7.55h2
        SocialMessage = 0x0396, // 7.55h2
        SocialMessage2 = 0x01DF, // 7.55h2
        SocialList = 0x0293, // 7.55h2
        SocialRequestResponse = 0x025A, // 7.55h2
        ExamineSearchInfo = 0x0328, // 7.55h2
        UpdateSearchInfo = 0x0341, // 7.55h2
        InitSearchInfo = 0x03D6, // 7.55h2
        ServerNoticeShort = 0x02BD, // 7.55h2
        ServerNotice = 0x00D6, // 7.55h2
        SetOnlineStatus = 0x01E2, // 7.55h2
        LogMessage = 0x0076, // 7.55h2
        Countdown = 0x0078, // 7.55h2
        CountdownCancel = 0x0274, // 7.55h2
        PartyMessage = 0x0241, // 7.55h2
        PlayerAddedToBlacklist = 0x0389, // 7.55h2
        PlayerRemovedFromBlacklist = 0x01A3, // 7.55h2
        BlackList = 0x02E2, // 7.55h2
        MarketBoardItemListingCount = 0x022F, // 7.55h2
        MarketBoardItemListing = 0x0190, // 7.55h2
        PlayerRetainerInfo = 0x02EB, // 7.55h2
        MarketBoardPurchase = 0x011C, // 7.55h2
        MarketBoardSale = 0x0283, // 7.55h2
        MarketBoardItemListingHistory = 0x017B, // 7.55h2
        RetainerSaleHistory = 0x031D, // 7.55h2
        RetainerState = 0x03B7, // 7.55h2
        MarketBoardSearchResult = 0x021A, // 7.55h2
        FreeCompanyInfo = 0x0093, // 7.55h2
        ExamineFreeCompanyInfo = 0x010F, // 7.55h2
        FreeCompanyDialog = 0x0225, // 7.55h2
        StatusEffectList = 0x02EC, // 7.55h2
        StatusEffectListEureka = 0x02F6, // 7.55h2
        StatusEffectListBozja = 0x023B, // 7.55h2
        StatusEffectListOccult = 0x0398, // 7.55h2
        StatusEffectListDouble = 0x01B1, // 7.55h2
        EffectResult = 0x038F, // 7.55h2
        EffectResult4 = 0x0084, // 7.55h2
        EffectResult8 = 0x02F3, // 7.55h2
        EffectResult16 = 0x022B, // 7.55h2
        EffectResultBasic = 0x039D, // 7.55h2
        EffectResultBasic4 = 0x00A5, // 7.55h2
        EffectResultBasic8 = 0x02B9, // 7.55h2
        EffectResultBasic16 = 0x009C, // 7.55h2
        EffectResultBasic32 = 0x024A, // 7.55h2
        EffectResultBasic64 = 0x0258, // 7.55h2
        ActorControl = 0x0096, // 7.55h2
        ActorControlSelf = 0x037C, // 7.55h2
        ActorControlTarget = 0x00EC, // 7.55h2
        UpdateHpMpTp = 0x02B2, // 7.55h2
        Effect = 0x0371, // 7.55h2
        AoeEffect8 = 0x03C8, // 7.55h2
        AoeEffect16 = 0x01AF, // 7.55h2
        AoeEffect24 = 0x035A, // 7.55h2
        AoeEffect32 = 0x03D5, // 7.55h2
        StatusEffectListPlayer = 0x0263, // 7.55h2
        StatusEffectListPlayerDouble = 0x00C3, // 7.55h2
        UpdateRecastTimes = 0x0125, // 7.55h2
        UpdateDutyRecastTimes = 0x032C, // 7.55h2
        UpdateDutyRecastTimes5 = 0x008B, // 7.55h2
        UpdateAllianceNormal = 0x03A9, // 7.55h2
        UpdateAllianceSmall = 0x00A7, // 7.55h2
        UpdatePartyMemberPositions = 0x00EF, // 7.55h2
        UpdateAllianceNormalMemberPositions = 0x00C4, // 7.55h2
        UpdateAllianceSmallMemberPositions = 0x0275, // 7.55h2
        GCAffiliation = 0x0306, // 7.55h2
        GatheringLog = 0x00F7, // 7.55h2
        CraftingLog = 0x0337, // 7.55h2
        PlayerSpawn = 0x032D, // 7.55h2
        NpcSpawn = 0x00E9, // 7.55h2
        BossSpawn = 0x021C, // 7.55h2
        DespawnCharacter = 0x0262, // 7.55h2
        ActorMove = 0x023C, // 7.55h2
        ActorSetPos = 0x012D, // 7.55h2
        ActorCast = 0x0136, // 7.55h2
        InitZone = 0x0161, // 7.55h2
        UpdateHate = 0x03BA, // 7.55h2
        UpdateHater = 0x0243, // 7.55h2
        ObjectSpawn = 0x00F5, // 7.55h2
        ObjectDespawn = 0x0130, // 7.55h2
        UpdateClassInfo = 0x033D, // 7.55h2
        UpdateClassInfoEureka = 0x006D, // 7.55h2
        UpdateClassInfoBozja = 0x033A, // 7.55h2
        UpdateClassInfoOccult = 0x0085, // 7.55h2
        PlayerSetup = 0x00A6, // 7.55h2
        PlayerStats = 0x010A, // 7.55h2
        FirstAttack = 0x01F6, // 7.55h2
        PlayerStateFlags = 0x01E7, // 7.55h2
        PlayerClassInfo = 0x0372, // 7.55h2
        PlayerBlueMageActions = 0x01D3, // 7.55h2
        ModelEquip = 0x0173, // 7.55h2
        Examine = 0x0097, // 7.55h2
        RetainerSummary = 0x01D1, // 7.55h2
        RetainerInformation = 0x02C5, // 7.55h2
        ItemMarketBoardSummary = 0x02A3, // 7.55h2
        ItemMarketBoardInfo = 0x0378, // 7.55h2
        ItemInfo = 0x0204, // 7.55h2
        ContainerInfo = 0x0228, // 7.55h2
        InventoryTransactionFinish = 0x00FF, // 7.55h2
        InventoryTransaction = 0x0104, // 7.55h2
        CurrencyCrystalInfo = 0x034F, // 7.55h2
        InventoryActionAck = 0x020E, // 7.55h2
        UpdateInventorySlot = 0x0349, // 7.55h2
        EventPlay = 0x01A5, // 7.55h2
        EventPlay4 = 0x02BA, // 7.55h2
        EventPlay8 = 0x0235, // 7.55h2
        EventPlay16 = 0x021B, // 7.55h2
        EventPlay32 = 0x03C3, // 7.55h2
        EventPlay64 = 0x03C2, // 7.55h2
        EventPlay128 = 0x01F0, // 7.55h2
        EventPlay255 = 0x02D0, // 7.55h2
        EventStart = 0x0278, // 7.55h2
        EventFinish = 0x0174, // 7.55h2
        ResultDialog = 0x03E7, // 7.55h2
        DesynthResult = 0x019F, // 7.55h2
        MiniCactpotInit = 0x02C7, // 7.55h2
        EnvironmentControl = 0x0087, // 7.55h2
        EnvironmentControl4 = 0x01EB, // 7.55h2
        EnvironmentControl8 = 0x0279, // 7.55h2
        EnvironmentControl12 = 0x016B, // 7.55h2
        SystemLogMessage = 0x0324, // 7.55h2
        SystemLogMessage2 = 0x0238, // 7.55h2
        SystemLogMessage4 = 0x0088, // 7.55h2
        SystemLogMessage8 = 0x013B, // 7.55h2
        SystemLogMessage16 = 0x019C, // 7.55h2
        BattleTalk2 = 0x03E1, // 7.55h2
        BattleTalk4 = 0x03E6, // 7.55h2
        BattleTalk8 = 0x03C7, // 7.55h2
        MapUpdate = 0x00DF, // 7.55h2
        MapUpdate4 = 0x00E0, // 7.55h2
        MapUpdate8 = 0x02CB, // 7.55h2
        MapUpdate16 = 0x03AB, // 7.55h2
        MapUpdate32 = 0x0070, // 7.55h2
        MapUpdate64 = 0x011A, // 7.55h2
        MapUpdate128 = 0x01C6, // 7.55h2
        BalloonTalk2 = 0x03C0, // 7.55h2
        BalloonTalk4 = 0x0129, // 7.55h2
        BalloonTalk8 = 0x024F, // 7.55h2
        WeatherChange = 0x00DE, // 7.55h2
        PlayerTitleList = 0x02E4, // 7.55h2
        NpcYell = 0x0368, // 7.55h2
        HousingWardInfo = 0x01F5, // 7.55h2
        AirshipTimers = 0x012E, // 7.55h2
        PlaceFieldMarkerPreset = 0x0103, // 7.55h2
        PlaceFieldMarker = 0x00AA, // 7.55h2
        AirshipStatusList = 0x02DE, // 7.55h2
        AirshipStatus = 0x00A3, // 7.55h2
        AirshipExplorationResult = 0x0250, // 7.55h2
        SubmarineStatusList = 0x01A2, // 7.55h2
        SubmarineProgressionStatus = 0x03B0, // 7.55h2
        SubmarineExplorationResult = 0x0376, // 7.55h2
        SubmarineTimers = 0x03AF, // 7.55h2
        PrepareZoning = 0x025B, // 7.55h2
        ActorGauge = 0x0300, // 7.55h2
        FashionReport = 0x03B6, // 7.55h2
        CEDirector = 0x027D, // 7.55h2
        IslandWorkshopDemandResearch = 0x034C, // 7.55h2
        IslandWorkshopSupplyDemand = 0x01C5, // 7.55h2
        IslandWorkshopGranaryResult = 0x01BC, // 7.55h2
        IslandWorkshopFavors = 0x01C4, // 7.55h2
        FishCaught = 0x02FF, // 7.55h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x01F3, // 7.55h2
        ActionRequestGroundTargeted = 0x03B5, // 7.55h2
        ChatHandler = 0x015F, // 7.55h2
        ClientCountdownInitiate = 0x0106, // 7.55h2
        ClientTrigger = 0x0225, // 7.55h2
        InventoryModifyHandler = 0x01AA, // 7.55h2
        LogoutHandler = 0x0253, // 7.55h2
        MarketBoardPurchaseHandler = 0x0390, // 7.55h2
        MarketBoardRequestItemListingInfo = 0x035B, // 7.55h2
        SetSearchInfoHandler = 0x0348, // 7.55h2
        UpdatePositionHandler = 0x0351, // 7.55h2
        UpdatePositionInstance = 0x032E, // 7.55h2
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