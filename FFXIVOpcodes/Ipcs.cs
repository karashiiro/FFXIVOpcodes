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
        PlayerSetup = 0x0261, // updated 6.08
        UpdateHpMpTp = 0x02C9, // updated 6.08
        PlayerStats = 0x02C7, // updated 6.08
        ActorControl = 0x022F, // updated 6.08
        ActorControlSelf = 0x006B, // updated 6.08
        ActorControlTarget = 0x0191, // updated 6.08
        Playtime = 0x00CE, // updated 6.08
        UpdateSearchInfo = 0x03D1, // updated 6.08
        ExamineSearchInfo = 0x0297, // updated 6.08
        Examine = 0x03E2, // updated 6.08
        MarketBoardSearchResult = 0x00B2, // updated 6.08
        MarketBoardItemListingCount = 0x026A, // updated 6.08
        MarketBoardItemListingHistory = 0x013A, // updated 6.08
        MarketBoardItemListing = 0x01E2, // updated 6.08
        MarketBoardPurchase = 0x00A3, // updated 6.08
        ActorMove = 0x0370, // updated 6.08
        ResultDialog = 0x027C, // updated 6.08
        RetainerInformation = 0x023B, // updated 6.08
        NpcSpawn = 0x032C, // updated 6.08
        ItemMarketBoardInfo = 0x0114, // updated 6.08
        PlayerSpawn = 0x0226, // updated 6.08
        ContainerInfo = 0x037A, // updated 6.08
        ItemInfo = 0x02A9, // updated 6.08
        UpdateClassInfo = 0x00FE, // updated 6.08
        ActorCast = 0x0104, // updated 6.08
        CurrencyCrystalInfo = 0x02BE, // updated 6.08
        InitZone = 0x01EB, // updated 6.08
        EffectResult = 0x00DE, // updated 6.08
        EventStart = 0x00AE, // updated 6.08
        EventFinish = 0x0210, // updated 6.08
        SomeDirectorUnk4 = 0x00EF, // updated 6.08
        UpdateInventorySlot = 0x0375, // updated 6.08
        DesynthResult = 0x0143, // updated 6.08
        InventoryActionAck = 0x008A, // updated 6.08
        InventoryTransaction = 0x0382, // updated 6.08
        InventoryTransactionFinish = 0x0299, // updated 6.08
        CFPreferredRole = 0x02DA, // updated 6.08
        CFNotify = 0x01C5, // updated 6.08
        PrepareZoning = 0x039A, // updated 6.08
        ActorSetPos = 0x0395, // updated 6.08
        PlaceFieldMarker = 0x0067, // updated 6.08
        PlaceFieldMarkerPreset = 0x01FE, // updated 6.08
        ObjectSpawn = 0x03A3, // updated 6.08
        
        StatusEffectList = 0x00BC, // updated 6.08
        StatusEffectList2 = 0x01FF, // updated 6.08
        StatusEffectList3 = 0x02AF, // updated 6.08
        
        ActorGauge = 0x03B5, // updated 6.08
        FreeCompanyInfo = 0x01A2, // updated 6.08
        FreeCompanyDialog = 0x0288, // updated 6.08
        AirshipTimers = 0x0225, // updated 6.08
        SubmarineTimers = 0x034A, // updated 6.08
        AirshipStatusList = 0x01F5, // updated 6.08
        AirshipStatus = 0x023E, // updated 6.08
        AirshipExplorationResult = 0x0212, // updated 6.08
        SubmarineProgressionStatus = 0x0092, // updated 6.08
        SubmarineStatusList = 0x019D, // updated 6.08
        SubmarineExplorationResult = 0x00C9, // updated 6.08

        EffectResultBasic = 0x02D9, // updated 6.08

        ActionEffect = 0x03C7, // updated 6.08
        ActionEffect8 = 0x0149, // updated 6.08
        ActionEffect16 = 0x00C1, // updated 6.08
        ActionEffect24 = 0x0213, // updated 6.08
        ActionEffect32 = 0x038B, // updated 6.08

        EventPlay = 0x113, // Updated for 6.08
        EventPlay4 = 0x302, // Updated for 6.08
        EventPlay8 = 0x78, // Updated for 6.08
        EventPlay16 = 0x223, // Updated for 6.08
        EventPlay32 = 0x2F2, // Updated for 6.08
        EventPlay64 = 0x3BC, // Updated for 6.08
        EventPlay128 = 0x33E, // Updated for 6.08
        EventPlay255 = 0x79, // Updated for 6.08

        WeatherChange = 0x017D, // updated 6.08

        Logout = 0x03B2, // updated 6.08

        ObjectDespawn = 0x0082, // updated 6.08
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0147, // updated 6.08
        ClientTrigger = 0x02F1, // updated 6.08
        ChatHandler = 0x01C8, // updated 6.08
        SetSearchInfoHandler = 0x02BB, // updated 6.08
        MarketBoardPurchaseHandler = 0x0282, // updated 6.08
        InventoryModifyHandler = 0x0154, // updated 6.08 (Base offset: 0x015B)
        UpdatePositionInstance = 0x0209, // updated 6.08

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
