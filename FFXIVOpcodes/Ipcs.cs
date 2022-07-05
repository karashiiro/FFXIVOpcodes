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
        PlayerSetup = 0x00CB, // updated 6.15
        UpdateHpMpTp = 0x02E1, // updated 6.15
        UpdateClassInfo = 0x038B, // updated 6.15
        PlayerStats = 0x0366, // updated 6.15
        ActorControl = 0x0286, // updated 6.15
        ActorControlSelf = 0x0308, // updated 6.15
        ActorControlTarget = 0x0070, // updated 6.15
        Playtime = 0x016B, // updated 6.15
        UpdateSearchInfo = 0x0176, // updated 6.15
        ExamineSearchInfo = 0x01CC, // updated 6.15
        ActorCast = 0x0347, // updated 6.15
        CurrencyCrystalInfo = 0x0222, // updated 6.15
        InitZone = 0x0184, // updated 6.15
        WeatherChange = 0x006C, // updated 6.15
        ActorMove = 0x01F1, // updated 6.15
        PlayerSpawn = 0x02DD, // updated 6.15
        ActorSetPos = 0x03C8, // updated 6.15
        HousingWardInfo = 0x0382, // updated 6.15
        PrepareZoning = 0x01D0, // updated 6.15
        ContainerInfo = 0x0102, // updated 6.15
        ItemInfo = 0x0359, // updated 6.15
        PlaceFieldMarker = 0x02FE, // updated 6.15
        PlaceFieldMarkerPreset = 0x03AC, // updated 6.15
        EffectResult = 0x024A, // updated 6.15
        EventStart = 0x01CB, // updated 6.15
        EventPlay = 0x0072, // updated 6.15
        EventFinish = 0x02F8, // updated 6.15
        EventPlay4 = 0x01AF, // updated 6.15
        FreeCompanyInfo = 0x02FC, // updated 6.15
        FreeCompanyDialog = 0x0300, // updated 6.15
        MarketBoardSearchResult = 0x01DC, // updated 6.15
        MarketBoardItemListingCount = 0x008B, // updated 6.15
        MarketBoardItemListingHistory = 0x02FD, // updated 6.15
        MarketBoardItemListing = 0x0129, // updated 6.15
        MarketBoardPurchase = 0x022F, // updated 6.15
        UpdateInventorySlot = 0x0236, // updated 6.15
        InventoryActionAck = 0x0232, // updated 6.15
        InventoryTransaction = 0x034B, // updated 6.15
        InventoryTransactionFinish = 0x027F, // updated 6.15
        ResultDialog = 0x0094, // updated 6.15
        RetainerInformation = 0x01B5, // updated 6.15
        NpcSpawn = 0x0331, // updated 6.15
        ItemMarketBoardInfo = 0x0195, // updated 6.15
        ObjectSpawn = 0x01B7, // updated 6.15
        EventPlay32 = 0x034F, // updated 6.15
        EffectResultBasic = 0x1002, // updated 6.15
        Effect = 0x014C, // updated 6.15
        StatusEffectList = 0x03B9, // updated 6.15
        ActorGauge = 0x01FC, // updated 6.15
        CFPreferredRole = 0x02DE, // updated 6.15
        CFNotify = 0x00A7, // updated 6.15
        AoeEffect8 = 0x00F4, // updated 6.15
        AoeEffect16 = 0x02B0, // updated 6.15
        AoeEffect24 = 0x02F9, // updated 6.15
        SystemLogMessage = 0x0107, // updated 6.15
        AirshipTimers = 0x031D, // updated 6.15
        SubmarineTimers = 0x0237, // updated 6.15
        EventPlay8 = 0x035D, // updated 6.15
        AirshipStatusList = 0x021F, // updated 6.15
        AirshipStatus = 0x01B0, // updated 6.15
        AirshipExplorationResult = 0x025B, // updated 6.15
        SubmarineProgressionStatus = 0x02C8, // updated 6.15
        SubmarineStatusList = 0x0391, // updated 6.15
        SubmarineExplorationResult = 0x0207, // updated 6.15
        
        Logout = 0x0160, // updated 6.15
        EnvironmentControl = 0x027B,// updated 6.18
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0157, // updated 6.15
        ClientTrigger = 0x02E7, // updated 6.15
        ChatHandler = 0x010A, // updated 6.15
        SetSearchInfoHandler = 0x0084, // updated 6.15
        MarketBoardPurchaseHandler = 0x008B, // updated 6.15
        InventoryModifyHandler = 0x0362, // updated 6.15 (Base offset: 0x0369)
        UpdatePositionInstance = 0x0108, // updated 6.15

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
