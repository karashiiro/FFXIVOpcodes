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
        PlayerSetup = 0x1DB, // Updated 6.08 hotfix
        UpdateHpMpTp = 0x0240, // Updated 6.08 hotfix
        PlayerStats = 0x015F, // Updated 6.08 hotfix
        ActorControl = 0x0202, // Updated 6.08 hotfix
        ActorControlSelf = 0x0301, // Updated 6.08 hotfix
        ActorControlTarget = 0x0333, // Updated 6.08 hotfix
        Playtime = 0x01A0, // Updated 6.08 hotfix
        UpdateSearchInfo = 0x0231, // Updated 6.08 hotfix
        ExamineSearchInfo = 0x0293, // Updated 6.08 hotfix
        Examine = 0x03AE, // Updated 6.08 hotfix
        MarketBoardSearchResult = 0x023A, // Updated 6.08 hotfix
        MarketBoardItemListingCount = 0x0370, // Updated 6.08 hotfix
        MarketBoardItemListingHistory = 0x0103, // Updated 6.08 hotfix
        MarketBoardItemListing = 0x014B, // Updated 6.08 hotfix
        MarketBoardPurchase = 0x02F3, // Updated 6.08 hotfix
        ActorMove = 0x03CB, // Updated 6.08 hotfix
        ResultDialog = 0x00DA, // Updated 6.08 hotfix
        RetainerInformation = 0x01A4, // Updated 6.08 hotfix
        NpcSpawn = 0x032F, // Updated 6.08 hotfix
        ItemMarketBoardInfo = 0x014E, // Updated 6.08 hotfix
        PlayerSpawn = 0x03DC, // Updated 6.08 hotfix
        ContainerInfo = 0x03C9, // Updated 6.08 hotfix
        ItemInfo = 0x00EC, // Updated 6.08 hotfix
        UpdateClassInfo = 0x02F8, // Updated 6.08 hotfix
        ActorCast = 0x01F4, // Updated 6.08 hotfix
        CurrencyCrystalInfo = 0x019F, // Updated 6.08 hotfix
        InitZone = 0x017F, // Updated 6.08 hotfix
        EffectResult = 0x021A, // Updated 6.08 hotfix
        EventStart = 0x036E, // Updated 6.08 hotfix
        EventFinish = 0x0085, // Updated 6.08 hotfix
        SomeDirectorUnk4 = 0x030B, // Updated 6.08 hotfix
        UpdateInventorySlot = 0x01C5, // Updated 6.08 hotfix
        DesynthResult = 0x00B2, // Updated 6.08 hotfix
        InventoryActionAck = 0x0172, // Updated 6.08 hotfix
        InventoryTransaction = 0x0134, // Updated 6.08 hotfix
        InventoryTransactionFinish = 0x0291, // Updated 6.08 hotfix
        CFNotify = 0x016E, // Updated 6.08 hotfix
        PrepareZoning = 0x01CB, // Updated 6.08 hotfix
        ActorSetPos = 0x033C, // Updated 6.08 hotfix
        PlaceFieldMarker = 0x03BA, // Updated 6.08 hotfix
        PlaceFieldMarkerPreset = 0x0074, // Updated 6.08 hotfix
        ObjectSpawn = 0x006A, // Updated 6.08 hotfix
        Effect = 0x035E, // Updated 6.08 hotfix
        StatusEffectList = 0x0275, // Updated 6.08 hotfix
        ActorGauge = 0x0374, // Updated 6.08 hotfix
        FreeCompanyInfo = 0x01EA, // Updated 6.08 hotfix
        FreeCompanyDialog = 0x030D, // Updated 6.08 hotfix
        AirshipTimers = 0x0142, // Updated 6.08 hotfix
        SubmarineTimers = 0x02B1, // Updated 6.08 hotfix
        AirshipStatusList = 0x011D, // Updated 6.08 hotfix
        AirshipStatus = 0x03AD, // Updated 6.08 hotfix
        AirshipExplorationResult = 0x006F, // Updated 6.08 hotfix
        SubmarineProgressionStatus = 0x03CA, // Updated 6.08 hotfix
        SubmarineStatusList = 0x00D7, // Updated 6.08 hotfix
        SubmarineExplorationResult = 0x0210, // Updated 6.08 hotfix

        EventPlay = 0x27A, // Updated for 6.08 hotfix
        EventPlay4 = 0x12E, // Updated for 6.08 hotfix
        EventPlay8 = 0x2E6, // Updated for 6.08 hotfix
        EventPlay16 = 0x21E, // Updated for 6.08 hotfix
        EventPlay32 = 0x1F9, // Updated for 6.08 hotfix
        EventPlay64 = 0x360, // Updated for 6.08 hotfix
        EventPlay128 = 0x33B, // Updated for 6.08 hotfix
        EventPlay255 = 0x34D, // Updated for 6.08 hotfix

        // WeatherChange = 0x017D, // updated 6.08

        Logout = 0x0181, // updated 6.08 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0274, // Updated 6.08 hotfix
        ClientTrigger = 0x01F8, // Updated 6.08 hotfix
        ChatHandler = 0x026D, // Updated 6.08 hotfix
        SetSearchInfoHandler = 0x01BB, // Updated 6.08 hotfix
        MarketBoardPurchaseHandler = 0x0156, // Updated 6.08 hotfix
        InventoryModifyHandler = 0x03E3, // Updated 6.08 hotfix (Base offset: 0x03EA)
        UpdatePositionInstance = 0x0169, // Updated 6.08 hotfix

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
