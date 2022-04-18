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
        PlayerSetup = 0x01D2,// Updated 6.1
        UpdateHpMpTp = 0x0094,// Updated 6.1
        UpdateClassInfo = 0x0327,// Updated 6.1
        PlayerStats = 0x01CE,// Updated 6.1
        ActorControl = 0x02E7,// Updated 6.1
        ActorControlSelf = 0x028F,// Updated 6.1
        ActorControlTarget = 0x0399,// Updated 6.1
        Playtime = 0x03BC,// Updated 6.1
        UpdateSearchInfo = 0x03CA,// Updated 6.1
        ExamineSearchInfo = 0x02ED,// Updated 6.1
        ActorCast = 0x006F,// Updated 6.1
        CurrencyCrystalInfo = 0x02BF,// Updated 6.1
        InitZone = 0x01E7,// Updated 6.1
        ActorMove = 0x0366,// Updated 6.1
        PlayerSpawn = 0x02BC,// Updated 6.1
        ActorSetPos = 0x023A,// Updated 6.1
        PrepareZoning = 0x02C9,// Updated 6.1
        ContainerInfo = 0x01FC,// Updated 6.1
        ItemInfo = 0x0309,// Updated 6.1
        PlaceFieldMarker = 0x015D,// Updated 6.1
        PlaceFieldMarkerPreset = 0x0075,// Updated 6.1
        EffectResult = 0x030B,// Updated 6.1
        EventStart = 0x008D,// Updated 6.1
        EventFinish = 0x02CA,// Updated 6.1
        SomeDirectorUnk4 = 0x0191,// Updated 6.1
        DesynthResult = 0x0354,// Updated 6.1
        FreeCompanyInfo = 0x0079,// Updated 6.1
        FreeCompanyDialog = 0x016C,// Updated 6.1
        MarketBoardSearchResult = 0x0067,// Updated 6.1
        MarketBoardItemListingCount = 0x0167,// Updated 6.1
        MarketBoardItemListingHistory = 0x019E,// Updated 6.1
        MarketBoardItemListing = 0x0069,// Updated 6.1
        MarketBoardPurchase = 0x03AF,// Updated 6.1
        UpdateInventorySlot = 0x00AB,// Updated 6.1
        InventoryActionAck = 0x02C2,// Updated 6.1
        InventoryTransaction = 0x00D7,// Updated 6.1
        InventoryTransactionFinish = 0x00D3,// Updated 6.1
        ResultDialog = 0x0349,// Updated 6.1
        RetainerInformation = 0x0101,// Updated 6.1
        NpcSpawn = 0x012F,// Updated 6.1
        ItemMarketBoardInfo = 0x00C9,// Updated 6.1
        ObjectSpawn = 0x011D,// Updated 6.1
        Effect = 0x021B,// Updated 6.1
        StatusEffectList = 0x031D,// Updated 6.1
        ActorGauge = 0x01BE,// Updated 6.1
        CFNotify = 0x01A3,// Updated 6.1
        // SystemLogMessage = 0x0191,// Updated 6.1
        AirshipTimers = 0x03B4,// Updated 6.1
        AirshipStatusList = 0x02A8,// Updated 6.1
        AirshipStatus = 0x010C,// Updated 6.1
        AirshipExplorationResult = 0x0320,// Updated 6.1

        SubmarineTimers = 0x0172,// Updated 6.1
        SubmarineStatusList = 0x02D0,// Updated 6.1
        SubmarineProgressionStatus = 0x204,// Updated 6.1
        SubmarineExplorationResult = 0x014D,// Updated 6.1

        EventPlay = 0xF3, // Updated for 6.1
        EventPlay4 = 0x2DB, // Updated for 6.1
        EventPlay8 = 0x17B, // Updated for 6.1
        EventPlay16 = 0x369, // Updated for 6.1
        EventPlay32 = 0x131, // Updated for 6.1
        EventPlay64 = 0x256, // Updated for 6.1
        EventPlay128 = 0x337, // Updated for 6.1
        EventPlay255 = 0x17F, // Updated for 6.1

        // WeatherChange = 0x2C9, // Updated for 6.1

        Logout = 0x0295, // updated 6.1 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03E7,// Updated 6.1
        ClientTrigger = 0x028E,// Updated 6.1
        ChatHandler = 0x0251,// Updated 6.1
        SetSearchInfoHandler = 0x024F,// Updated 6.1
        MarketBoardPurchaseHandler = 0x0245,// Updated 6.1
        InventoryModifyHandler = 0x030A,// Updated 6.1 (Base offset: 0x0311)
        UpdatePositionInstance = 0x0225,// Updated 6.1

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
