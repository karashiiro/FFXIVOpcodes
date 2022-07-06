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
        PlayerSetup = 0x03CF, // updated 6.18
        UpdateHpMpTp = 0x020F, // updated 6.18
        UpdateClassInfo = 0x0336, // updated 6.18
        PlayerStats = 0x02AE, // updated 6.18
        ActorControl = 0x036E, // updated 6.18
        ActorControlSelf = 0x02F0, // updated 6.18
        ActorControlTarget = 0x01FD, // updated 6.18
        Playtime = 0x036F, // updated 6.18
        UpdateSearchInfo = 0x00EA, // updated 6.18
        ExamineSearchInfo = 0x013E, // updated 6.18
        ActorCast = 0x03C2, // updated 6.18
        CurrencyCrystalInfo = 0x01D4, // updated 6.18
        InitZone = 0x035D, // updated 6.18
        WeatherChange = 0x00DE, // updated 6.18
        ActorMove = 0x0188, // updated 6.18
        PlayerSpawn = 0x01D7, // updated 6.18
        ActorSetPos = 0x02C4, // updated 6.18
        HousingWardInfo = 0x014A, // updated 6.18
        PrepareZoning = 0x0346, // updated 6.18
        ContainerInfo = 0x01F4, // updated 6.18
        ItemInfo = 0x03D7, // updated 6.18
        PlaceFieldMarker = 0x01C1, // updated 6.18
        PlaceFieldMarkerPreset = 0x024F, // updated 6.18
        EffectResult = 0x0095, // updated 6.18
        EventStart = 0x022D, // updated 6.18
        EventPlay = 0x0348, // updated 6.18
        EventFinish = 0x0069, // updated 6.18
        //EventPlay4 = 0x01AF, // updated 6.15
        DesynthResult = 0x02B1, // updated 6.18
        FreeCompanyInfo = 0x02E0, // updated 6.18
        FreeCompanyDialog = 0x0284, // updated 6.18
        MarketBoardSearchResult = 0x0304, // updated 6.18
        MarketBoardItemListingCount = 0x03B2, // updated 6.18
        MarketBoardItemListingHistory = 0x0189, // updated 6.18
        MarketBoardItemListing = 0x00E6, // updated 6.18
        MarketBoardPurchase = 0x0103, // updated 6.18
        UpdateInventorySlot = 0x035C, // updated 6.18
        InventoryActionAck = 0x03B9, // updated 6.18
        InventoryTransaction = 0x0160, // updated 6.18
        InventoryTransactionFinish = 0x00CF, // updated 6.18
        ResultDialog = 0x0251, // updated 6.18
        RetainerInformation = 0x0182, // updated 6.18
        NpcSpawn = 0x0086, // updated 6.18
        ItemMarketBoardInfo = 0x034C, // updated 6.18
        ObjectSpawn = 0x0117, // updated 6.18
        EventPlay32 = 0x02EF, // updated 6.18
        EffectResultBasic = 0x1002, // updated 6.18
        Effect = 0x00EE, // updated 6.18
        StatusEffectList = 0x00E9, // updated 6.18
        ActorGauge = 0x01E9, // updated 6.18
        CFPreferredRole = 0x01FC, // updated 6.18
        CFNotify = 0x027F, // updated 6.18
        AoeEffect8 = 0x03AA, // updated 6.18
        AoeEffect16 = 0x02BA, // updated 6.18
        AoeEffect24 = 0x0211, // updated 6.18
        SystemLogMessage = 0x0246, // updated 6.18
        AirshipTimers = 0x026D, // updated 6.18
        SubmarineTimers = 0x0138, // updated 6.18
        EventPlay8 = 0x0108, // updated 6.18
        AirshipStatusList = 0x02D1, // updated 6.18
        AirshipStatus = 0x01C3, // updated 6.18
        AirshipExplorationResult = 0x031B, // updated 6.18
        SubmarineProgressionStatus = 0x01DF, // updated 6.18
        SubmarineStatusList = 0x0111, // updated 6.18
        SubmarineExplorationResult = 0x0285, // updated 6.18

        Logout = 0x00F4, // updated 6.18
        EnvironmentControl = 0x027B, // updated 6.18
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0375, // updated 6.18
        ClientTrigger = 0x02AB, // updated 6.18
        ChatHandler = 0x00A1, // updated 6.18
        SetSearchInfoHandler = 0x022F, // updated 6.18
        MarketBoardPurchaseHandler = 0x0361, // updated 6.18
        InventoryModifyHandler = 0x0224, // updated 6.18 (Base offset: 0x022B)
        UpdatePositionInstance = 0x0355, // updated 6.18

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
