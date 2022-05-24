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
        PlayerSetup = 0x03CB, // updated 6.11a
        UpdateHpMpTp = 0x0231, // updated 6.11a
        UpdateClassInfo = 0x02D1, // updated 6.11a
        PlayerStats = 0x036E, // updated 6.11a
        ActorControl = 0x024B, // updated 6.11a
        ActorControlSelf = 0x0334, // updated 6.11a
        ActorControlTarget = 0x0370, // updated 6.11a
        Playtime = 0x039D, // updated 6.11a
        UpdateSearchInfo = 0x0251, // updated 6.11a
        ExamineSearchInfo = 0x0236, // updated 6.11a
        ActorCast = 0x03DF, // updated 6.11a
        CurrencyCrystalInfo = 0x00D8, // updated 6.11a
        InitZone = 0x0086, // updated 6.11a
        ActorMove = 0x0132, // updated 6.11a
        PlayerSpawn = 0x0336, // updated 6.11a
        ActorSetPos = 0x01D9, // updated 6.11a
        PrepareZoning = 0x02A0, // updated 6.11a
        ContainerInfo = 0x0288, // updated 6.11a
        ItemInfo = 0x038D, // updated 6.11a
        PlaceFieldMarker = 0x0137, // updated 6.11a
        PlaceFieldMarkerPreset = 0x015E, // updated 6.11a
        EffectResult = 0x012A, // updated 6.11a
        EventStart = 0x0156, // updated 6.11a
        EventFinish = 0x026B, // updated 6.11a
        SomeDirectorUnk4 = 0x01D4, // updated 6.11a
        DesynthResult = 0x030D, // updated 6.11a
        FreeCompanyInfo = 0x010C, // updated 6.11a
        FreeCompanyDialog = 0x039E, // updated 6.11a
        MarketBoardSearchResult = 0x01DE, // updated 6.11a
        MarketBoardItemListingCount = 0x03B7, // updated 6.11a
        MarketBoardItemListingHistory = 0x00E1, // updated 6.11a
        MarketBoardItemListing = 0x039A, // updated 6.11a
        MarketBoardPurchase = 0x0180, // updated 6.11a
        UpdateInventorySlot = 0x021E, // updated 6.11a
        InventoryActionAck = 0x014B, // updated 6.11a
        InventoryTransaction = 0x028F, // updated 6.11a
        InventoryTransactionFinish = 0x0397, // updated 6.11a
        ResultDialog = 0x027A, // updated 6.11a
        RetainerInformation = 0x035A, // updated 6.11a
        NpcSpawn = 0x026D, // updated 6.11a
        ItemMarketBoardInfo = 0x00BE, // updated 6.11a
        ObjectSpawn = 0x0305, // updated 6.11a
        Effect = 0x00B5, // updated 6.11a
        StatusEffectList = 0x032E, // updated 6.11a
        ActorGauge = 0x01C2, // updated 6.11a
        CFNotify = 0x01D2, // updated 6.11a
        AoeEffect8 = 0x014F, // updated 6.11a
        AirshipTimers = 0x0356, // updated 6.11a
        SubmarineTimers = 0x00DE, // updated 6.11a
        AirshipStatusList = 0x03A1, // updated 6.11a
        AirshipStatus = 0x01B3, // updated 6.11a
        AirshipExplorationResult = 0x0188, // updated 6.11a
        SubmarineProgressionStatus = 0x01BC, // updated 6.11a
        SubmarineStatusList = 0x03AC, // updated 6.11a
        SubmarineExplorationResult = 0x01B1, // updated 6.11a

        EventPlay = 0x85,
        EventPlay4 = 0x2F4,
        EventPlay8 = 0x176,
        EventPlay16 = 0x2D4,
        EventPlay32 = 0x2FF,
        EventPlay64 = 0x289,
        EventPlay128 = 0x3A5,
        EventPlay255 = 0xD9,

        Logout = 0x0094, // updated 6.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x00B8, // updated 6.11a
        ClientTrigger = 0x0309, // updated 6.11a
        ChatHandler = 0x01E9, // updated 6.11a
        SetSearchInfoHandler = 0x00E3, // updated 6.11a
        MarketBoardPurchaseHandler = 0x0386, // updated 6.11a
        InventoryModifyHandler = 0x02BE, // updated 6.11a (Base offset: 0x02C5)
        UpdatePositionInstance = 0x0351, // updated 6.11a

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
