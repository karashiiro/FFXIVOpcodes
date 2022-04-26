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
        PlayerSetup = 0x0312, // Updated 6.11
        UpdateHpMpTp = 0x028B, // Updated 6.11
        UpdateClassInfo = 0x00D4, // Updated 6.11
        PlayerStats = 0x0370, // Updated 6.11
        ActorControl = 0x016F, // Updated 6.11
        ActorControlSelf = 0x03AE, // Updated 6.11
        ActorControlTarget = 0x01B2, // Updated 6.11
        Playtime = 0x009D, // Updated 6.11
        UpdateSearchInfo = 0x0334, // Updated 6.11
        ExamineSearchInfo = 0x022B, // Updated 6.11
        ActorCast = 0x0163, // Updated 6.11
        CurrencyCrystalInfo = 0x01E2, // Updated 6.11
        InitZone = 0x01F5, // Updated 6.11
        ActorMove = 0x0397, // Updated 6.11
        PlayerSpawn = 0x018F, // Updated 6.11
        ActorSetPos = 0x0317, // Updated 6.11
        PrepareZoning = 0x01CF, // Updated 6.11
        ContainerInfo = 0x035D, // Updated 6.11
        ItemInfo = 0x00E1, // Updated 6.11
        PlaceFieldMarker = 0x028F, // Updated 6.11
        PlaceFieldMarkerPreset = 0x0068, // Updated 6.11
        EffectResult = 0x0309, // Updated 6.11
        EffectResultBasic = 0x00A8, // updated 6.11
        EventStart = 0x0217, // Updated 6.11
        EventFinish = 0x0096, // Updated 6.11
        SomeDirectorUnk4 = 0x01AD, // Updated 6.11
        DesynthResult = 0x035A, // Updated 6.11
        FreeCompanyInfo = 0x0084, // Updated 6.11
        FreeCompanyDialog = 0x03B8, // Updated 6.11
        MarketBoardSearchResult = 0x0389, // Updated 6.11
        MarketBoardItemListingCount = 0x01AC, // Updated 6.11
        MarketBoardItemListingHistory = 0x02E5, // Updated 6.11
        MarketBoardItemListing = 0x03AC, // Updated 6.11
        MarketBoardPurchase = 0x03BA, // Updated 6.11
        UpdateInventorySlot = 0x0322, // Updated 6.11
        InventoryActionAck = 0x0190, // Updated 6.11
        InventoryTransaction = 0x009B, // Updated 6.11
        InventoryTransactionFinish = 0x00B8, // Updated 6.11
        ResultDialog = 0x0361, // Updated 6.11
        RetainerInformation = 0x029B, // Updated 6.11
        NpcSpawn = 0x02B1, // Updated 6.11
        NpcSpawn2 = 0x0083, // updated 6.11
        ItemMarketBoardInfo = 0x01CC, // Updated 6.11
        ObjectSpawn = 0x02D3, // Updated 6.11
        Effect = 0x0398, // Updated 6.11
        StatusEffectList = 0x00D2, // Updated 6.11
        StatusEffectList2 = 0x0182, // updated 6.11
        StatusEffectList3 = 0x0299, // updated 6.11
        ActorGauge = 0x02A7, // Updated 6.11
        CFNotify = 0x0188, // Updated 6.11
        AoeEffect8 = 0x0359, // Updated 6.11
        AoeEffect16 = 0x0260, // Updated 6.11
        AoeEffect24 = 0x0209, // updated 6.11
        AoeEffect32 = 0x039F, // updated 6.11
        //SystemLogMessage = 0x01AD, // Updated 6.11
        AirshipTimers = 0x024B, // Updated 6.11
        SubmarineTimers = 0x0254, // Updated 6.11
        AirshipStatusList = 0x01B4, // Updated 6.11
        AirshipStatus = 0x011B, // Updated 6.11
        AirshipExplorationResult = 0x0328, // Updated 6.11
        SubmarineProgressionStatus = 0x00C7, // Updated 6.11
        SubmarineStatusList = 0x0236, // Updated 6.11
        SubmarineExplorationResult = 0x00B9, // Updated 6.11

        EventPlay = 0x313,    // Updated for 6.11
        EventPlay4 = 0x36D,   // Updated for 6.11
        EventPlay8 = 0x364,   // Updated for 6.11
        EventPlay16 = 0x9E,   // Updated for 6.11
        EventPlay32 = 0x3C8,  // Updated for 6.11
        EventPlay64 = 0x16B,  // Updated for 6.11
        EventPlay128 = 0x2FB, // Updated for 6.11
        EventPlay255 = 0xD8,  // Updated for 6.11

        Logout = 0x0109, // updated 6.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0187, // Updated 6.11
        ClientTrigger = 0x0283, // Updated 6.11
        ChatHandler = 0x0133, // Updated 6.11
        SetSearchInfoHandler = 0x01F0, // Updated 6.11
        MarketBoardPurchaseHandler = 0x037C, // Updated 6.11
        InventoryModifyHandler = 0x0350, // Updated 6.11 (Base offset: 0x0357)
        UpdatePositionInstance = 0x031E, // Updated 6.11

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
