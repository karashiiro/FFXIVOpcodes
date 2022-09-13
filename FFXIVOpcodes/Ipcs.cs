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
        PlayerSetup = 0x0294,// Updated 6.21
        UpdateHpMpTp = 0x0193,// Updated 6.21
        UpdateClassInfo = 0x0134,// Updated 6.21
        PlayerStats = 0x0347,// Updated 6.21
        ActorControl = 0x0335,// Updated 6.21
        ActorControlSelf = 0x02ED,// Updated 6.21
        ActorControlTarget = 0x0212,// Updated 6.21
        Playtime = 0x01C7,// Updated 6.21
        UpdateSearchInfo = 0x0239,// Updated 6.21
        ExamineSearchInfo = 0x0119,// Updated 6.21
        Examine = 0x03B6,// Updated 6.21
        ActorCast = 0x02E8,// Updated 6.21
        CurrencyCrystalInfo = 0x0302,// Updated 6.21
        InitZone = 0x036A,// Updated 6.21
        WeatherChange = 0x0162,// Updated 6.21
        ActorMove = 0x039F,// Updated 6.21
        PlayerSpawn = 0x029D,// Updated 6.21
        ActorSetPos = 0x00C6,// Updated 6.21
        PrepareZoning = 0x0121,// Updated 6.21
        ContainerInfo = 0x02F7,// Updated 6.21
        ItemInfo = 0x02CE,// Updated 6.21
        PlaceFieldMarker = 0x03A0,// Updated 6.21
        PlaceFieldMarkerPreset = 0x0125,// Updated 6.21
        EffectResult = 0x012F,// Updated 6.21
        EventStart = 0x0138,// Updated 6.21
        EventFinish = 0x00F1,// Updated 6.21
        DesynthResult = 0x00AA,// Updated 6.21
        FreeCompanyInfo = 0x0260,// Updated 6.21
        FreeCompanyDialog = 0x0096,// Updated 6.21
        MarketBoardSearchResult = 0x013B,// Updated 6.21
        MarketBoardItemListingCount = 0x037B,// Updated 6.21
        MarketBoardItemListingHistory = 0x0376,// Updated 6.21
        MarketBoardItemListing = 0x0159,// Updated 6.21
        MarketBoardPurchase = 0x01D9,// Updated 6.21
        UpdateInventorySlot = 0x022E,// Updated 6.21
        InventoryActionAck = 0x0104,// Updated 6.21
        InventoryTransaction = 0x03D4,// Updated 6.21
        InventoryTransactionFinish = 0x0299,// Updated 6.21
        ResultDialog = 0x01A8,// Updated 6.21
        RetainerInformation = 0x0380,// Updated 6.21
        NpcSpawn = 0x02E4,// Updated 6.21
        ItemMarketBoardInfo = 0x014C,// Updated 6.21
        ObjectSpawn = 0x0281,// Updated 6.21
        EffectResultBasic = 0x1070,// Updated 6.21
        Effect = 0x01CD,// Updated 6.21
        StatusEffectList = 0x00FA,// Updated 6.21
        ActorGauge = 0x021C,// Updated 6.21
        CFNotify = 0x00C9,// Updated 6.21
        SystemLogMessage = 0x03A1,// Updated 6.21
        AirshipTimers = 0x0195,// Updated 6.21
        SubmarineTimers = 0x00ED,// Updated 6.21
        AirshipStatusList = 0x0224,// Updated 6.21
        AirshipStatus = 0x0317,// Updated 6.21
        AirshipExplorationResult = 0x01E6,// Updated 6.21
        SubmarineProgressionStatus = 0x0377,// Updated 6.21
        SubmarineStatusList = 0x010D,// Updated 6.21
        SubmarineExplorationResult = 0x01AA,// Updated 6.21


        EventPlay = 0x2db, // Updated for 6.21
        EventPlay4 = 0x103, // Updated for 6.21
        EventPlay8 = 0x68, // Updated for 6.21
        EventPlay16 = 0x106, // Updated for 6.21
        EventPlay32 = 0x2f9, // Updated for 6.21
        EventPlay64 = 0xc4, // Updated for 6.21
        EventPlay128 = 0x218, // Updated for 6.21
        EventPlay255 = 0xec, // Updated for 6.21
        // EnvironmentControl = 0x195, // Updated 6.2
        IslandWorkshopSupplyDemand = 0x01BF, // Updated 6.21
        Logout = 0x02BF // Updated 6.21
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x034C,// Updated 6.21
        ClientTrigger = 0x0094,// Updated 6.21
        ChatHandler = 0x0248,// Updated 6.21
        SetSearchInfoHandler = 0x01CA,// Updated 6.21
        MarketBoardPurchaseHandler = 0x032B,// Updated 6.21
        InventoryModifyHandler = 0x014B,// Updated 6.21 (Base offset: 0x0152)
        UpdatePositionInstance = 0x0105,// Updated 6.21

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
