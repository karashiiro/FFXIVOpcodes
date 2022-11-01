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
        // Server Zone
        PlayerSetup = 0x02C9, // Updated 6.25
        UpdateHpMpTp = 0x0129, // Updated 6.25
        UpdateClassInfo = 0x01F7, // Updated 6.25
        PlayerStats = 0x01C3, // Updated 6.25
        ActorControl = 0x039E, // Updated 6.25
        ActorControlSelf = 0x03CE, // Updated 6.25
        ActorControlTarget = 0x03C6, // Updated 6.25
        Playtime = 0x020C, // Updated 6.25
        UpdateSearchInfo = 0x01A4, // Updated 6.25
        ExamineSearchInfo = 0x036A, // Updated 6.25
        Examine = 0x00D8, // Updated 6.25
        ActorCast = 0x02EC, // Updated 6.25
        CurrencyCrystalInfo = 0x0223, // Updated 6.25
        InitZone = 0x0144, // Updated 6.25
        WeatherChange = 0x0352, // Updated 6.25
        ActorMove = 0x0275, // Updated 6.25
        PlayerSpawn = 0x017E, // Updated 6.25
        ActorSetPos = 0x028F, // Updated 6.25
        PrepareZoning = 0x01AC, // Updated 6.25
        ContainerInfo = 0x0087, // Updated 6.25
        ItemInfo = 0x0298, // Updated 6.25
        PlaceFieldMarker = 0x03E5, // Updated 6.25
        PlaceFieldMarkerPreset = 0x02E2, // Updated 6.25
        EffectResult = 0x02CA, // Updated 6.25
        EventStart = 0x01C9, // Updated 6.25
        EventFinish = 0x030B, // Updated 6.25
        DesynthResult = 0x01AD, // Updated 6.25
        FreeCompanyInfo = 0x036B, // Updated 6.25
        FreeCompanyDialog = 0x03D7, // Updated 6.25
        MarketBoardSearchResult = 0x0340, // Updated 6.25
        MarketBoardItemListingCount = 0x02F7, // Updated 6.25
        MarketBoardItemListingHistory = 0x03B6, // Updated 6.25
        MarketBoardItemListing = 0x03A7, // Updated 6.25
        MarketBoardPurchase = 0x0343, // Updated 6.25
        UpdateInventorySlot = 0x037A, // Updated 6.25
        InventoryActionAck = 0x0358, // Updated 6.25
        InventoryTransaction = 0x030D, // Updated 6.25
        InventoryTransactionFinish = 0x035D, // Updated 6.25
        ResultDialog = 0x013F, // Updated 6.25
        RetainerInformation = 0x02DB, // Updated 6.25
        NpcSpawn = 0x029D, // Updated 6.25
        ItemMarketBoardInfo = 0x03BF, // Updated 6.25
        ObjectSpawn = 0x02D9, // Updated 6.25
        EffectResultBasic = 0x1070, // Updated 6.25
        Effect = 0x03C4, // Updated 6.25
        StatusEffectList = 0x0274, // Updated 6.25
        ActorGauge = 0x0344, // Updated 6.25
        CFNotify = 0x0236, // Updated 6.25
        SystemLogMessage = 0x012B, // Updated 6.25
        AirshipTimers = 0x02F4, // Updated 6.25
        SubmarineTimers = 0x0104, // Updated 6.25
        AirshipStatusList = 0x00C0, // Updated 6.25
        AirshipStatus = 0x02A2, // Updated 6.25
        AirshipExplorationResult = 0x0389, // Updated 6.25
        SubmarineProgressionStatus = 0x01F3, // Updated 6.25
        SubmarineStatusList = 0x0151, // Updated 6.25
        SubmarineExplorationResult = 0x0084, // Updated 6.25

        EventPlay = 0x162, // Updated for 6.25
        EventPlay4 = 0x232, // Updated for 6.25
        EventPlay8 = 0xe3, // Updated for 6.25
        EventPlay16 = 0x29e, // Updated for 6.25
        EventPlay32 = 0x241, // Updated for 6.25
        EventPlay64 = 0x3a1, // Updated for 6.25
        EventPlay128 = 0x38c, // Updated for 6.25
        EventPlay255 = 0x257, // Updated for 6.25

        EnvironmentControl = 0x193, // Updated for 6.28
        IslandWorkshopSupplyDemand = 0x01E2, // Updated 6.25
        Logout = 0x02C5 // Updated 6.25
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x025B, // Updated 6.25
        ClientTrigger = 0x0169, // Updated 6.25
        ChatHandler = 0x0332, // Updated 6.25
        SetSearchInfoHandler = 0x010B, // Updated 6.25
        MarketBoardPurchaseHandler = 0x008D, // Updated 6.25
        InventoryModifyHandler = 0x00E2, // Updated 6.25 (Base offset: 0x00E9)
        UpdatePositionInstance = 0x0214, // Updated 6.25

        //PingHandler = 0x02B9, // updated 6.08
        //InitHandler = 0x01A9, // updated 6.08

        //FinishLoadingHandler = 0x02BF, // updated 6.08

        //CFCommenceHandler = 0x0099, // updated 6.08

        //CFRegisterDuty = 0x03B6, // updated 6.08
        //CFRegisterRoulette = 0x02F0, // updated 6.08
        //PlayTimeHandler = 0x00BD, // updated 6.08
        //LogoutHandler = 0x0185, // updated 6.08
        //CancelLogout = 0x0151, // updated 6.08

        //CFDutyInfoHandler = 0x0099, // updated 6.08

        //SocialReqSendHandler = 0x0259, // updated 6.08
        //CreateCrossWorldLS = 0x034B, // updated 6.08

        //SocialListHandler = 0x0203, // updated 6.08
        //ReqSearchInfoHandler = 0x02ED, // updated 6.08
        //ReqExamineSearchCommentHandler = 0x0312, // updated 6.08

        //ReqRemovePlayerFromBlacklist = 0x01C4, // updated 6.08
        //BlackListHandler = 0x0167, // updated 6.08
        //PlayerSearchHandler = 0x02EA, // updated 6.08

        //LinkshellListHandler = 0x0241, // updated 6.08

        //MarketBoardRequestItemListingInfo = 0x0370, // updated 6.08
        //MarketBoardRequestItemListings = 0x0099, // updated 6.08
        //MarketBoardSearch = 0x02E7, // updated 6.08

        //ReqExamineFcInfo = 0x016A, // updated 6.08

        //FcInfoReqHandler = 0x0230, // updated 6.08

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0345, // updated 6.08

        //ReqJoinNoviceNetwork = 0x01D4, // updated 6.08

        //ReqCountdownInitiate = 0x02F0, // updated 6.08
        //ReqCountdownCancel = 0x0103, // updated 6.08

        //ZoneLineHandler = 0x0126, // updated 6.08
        //DiscoveryHandler = 0x0259, // updated 6.08


        //PlaceFieldMarker = 0x009C, // updated 6.08
        //PlaceFieldMarkerPreset = 0x036F, // updated 6.08
        //SkillHandler = 0x024E, // updated 6.08
        //GMCommand1 = 0x00D8, // updated 6.08
        //GMCommand2 = 0x03B0, // updated 6.08
        //AoESkillHandler = 0x0249, // updated 6.08

        //InventoryEquipRecommendedItems = 0x0079, // updated 6.08

        //ReqPlaceHousingItem = 0x0318, // updated 6.08
        //BuildPresetHandler = 0x028A, // updated 6.08

        //TalkEventHandler = 0x0300, // updated 6.08
        //EmoteEventHandler = 0x00A5, // updated 6.08
        //WithinRangeEventHandler = 0x02E4, // updated 6.08
        //OutOfRangeEventHandler = 0x0189, // updated 6.08
        //EnterTeriEventHandler = 0x0381, // updated 6.08

        //ReturnEventHandler = 0x02BA, // updated 6.08
        //TradeReturnEventHandler = 0x0211, // updated 6.08

        //LinkshellEventHandler = 0x023D, // updated 6.08
        //LinkshellEventHandler1 = 0x023D, // updated 6.08

        //ReqEquipDisplayFlagsChange = 0x0066, // updated 6.08

        //LandRenameHandler = 0x03A4, // updated 6.08
        //HousingUpdateHouseGreeting = 0x02E6, // updated 6.08
        //HousingUpdateObjectPosition = 0x02B8, // updated 6.08

        //SetSharedEstateSettings = 0x0081, // updated 6.08

        //PerformNoteHandler = 0x017A, // updated 6.08
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
