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
        PlayerSetup = 0x02F3,// Updated 6.2
        UpdateHpMpTp = 0x00C7,// Updated 6.2
        UpdateClassInfo = 0x03BB,// Updated 6.2
        PlayerStats = 0x0313,// Updated 6.2
        ActorControl = 0x02B4,// Updated 6.2
        ActorControlSelf = 0x01AE,// Updated 6.2
        ActorControlTarget = 0x00AC,// Updated 6.2
        Playtime = 0x01E9,// Updated 6.2
        UpdateSearchInfo = 0x0217,// Updated 6.2
        ExamineSearchInfo = 0x03BE,// Updated 6.2
        Examine = 0x01E3,// Updated 6.2
        ActorCast = 0x03CC,// Updated 6.2
        CurrencyCrystalInfo = 0x00C5,// Updated 6.2
        ActorMove = 0x010B,// Updated 6.2
        PlayerSpawn = 0x0176,// Updated 6.2
        PrepareZoning = 0x01E7,// Updated 6.2
        ContainerInfo = 0x0283,// Updated 6.2
        ItemInfo = 0x03A5,// Updated 6.2
        PlaceFieldMarker = 0x0184,// Updated 6.2
        PlaceFieldMarkerPreset = 0x039C,// Updated 6.2
        EffectResult = 0x01A8,// Updated 6.2
        EventStart = 0x022F,// Updated 6.2
        EventFinish = 0x0171,// Updated 6.2
        DesynthResult = 0x03CE,// Updated 6.2
        FreeCompanyInfo = 0x02A8,// Updated 6.2
        FreeCompanyDialog = 0x00B6,// Updated 6.2
        MarketBoardSearchResult = 0x034E,// Updated 6.2
        MarketBoardItemListingCount = 0x0241,// Updated 6.2
        MarketBoardItemListingHistory = 0x00E2,// Updated 6.2
        MarketBoardItemListing = 0x0086,// Updated 6.2
        MarketBoardPurchase = 0x0065,// Updated 6.2
        UpdateInventorySlot = 0x0210,// Updated 6.2
        InventoryActionAck = 0x01DF,// Updated 6.2
        InventoryTransaction = 0x00D1,// Updated 6.2
        InventoryTransactionFinish = 0x0286,// Updated 6.2
        ResultDialog = 0x033C,// Updated 6.2
        RetainerInformation = 0x00FE,// Updated 6.2
        NpcSpawn = 0x01EF,// Updated 6.2
        ItemMarketBoardInfo = 0x0252,// Updated 6.2
        ObjectSpawn = 0x03AC,// Updated 6.2
        EffectResultBasic = 0x01E6,// Updated 6.2
        Effect = 0x0350,// Updated 6.2
        StatusEffectList = 0x008D,// Updated 6.2
        ActorGauge = 0x0394,// Updated 6.2
        SystemLogMessage = 0x029F,// Updated 6.2
        AirshipTimers = 0x019B,// Updated 6.2
        SubmarineTimers = 0x0328,// Updated 6.2
        AirshipStatusList = 0x01C6,// Updated 6.2
        AirshipStatus = 0x02F8,// Updated 6.2
        AirshipExplorationResult = 0x0089,// Updated 6.2
        SubmarineProgressionStatus = 0x0275,// Updated 6.2
        SubmarineStatusList = 0x02A9,// Updated 6.2
        SubmarineExplorationResult = 0x03AA,// Updated 6.2

        EventPlay = 0x0066, // Updated 6.2
        EventPlay4 = 0x0233, // Updated 6.2
        EventPlay8 = 0x01f8, // Updated 6.2
        EventPlay16 = 0x00fa, // Updated 6.2
        EventPlay32 = 0x035b, // Updated 6.2
        EventPlay64 = 0x00aa, // Updated 6.2
        EventPlay128 = 0x0213, // Updated 6.2
        EventPlay255 = 0x0298, // Updated 6.2
        EnvironmentControl = 0x195, // Updated 6.2
        Logout = 0x00C9 // Updated 6.2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02C5,// Updated 6.2
        ClientTrigger = 0x01D0,// Updated 6.2
        ChatHandler = 0x028E,// Updated 6.2
        SetSearchInfoHandler = 0x01C1,// Updated 6.2
        MarketBoardPurchaseHandler = 0x0164,// Updated 6.2
        InventoryModifyHandler = 0x017B,// Updated 6.2 (Base offset: 0x0182)
        UpdatePositionInstance = 0x024B,// Updated 6.2

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
