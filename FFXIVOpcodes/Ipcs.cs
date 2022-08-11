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
        PlayerSetup = 0x0304, // Updated 6.18 hotfix
        UpdateHpMpTp = 0x00E7, // Updated 6.18 hotfix
        UpdateClassInfo = 0x03D5, // Updated 6.18 hotfix
        PlayerStats = 0x0310, // Updated 6.18 hotfix
        ActorControl = 0x00CB, // Updated 6.18 hotfix
        ActorControlSelf = 0x03CD, // Updated 6.18 hotfix
        ActorControlTarget = 0x0174, // Updated 6.18 hotfix
        Playtime = 0x01E5, // Updated 6.18 hotfix
        UpdateSearchInfo = 0x0205, // Updated 6.18 hotfix
        ExamineSearchInfo = 0x019C, // Updated 6.18 hotfix
        ActorCast = 0x0077, // Updated 6.18 hotfix
        CurrencyCrystalInfo = 0x0140, // Updated 6.18 hotfix
        InitZone = 0x010F, // Updated 6.18 hotfix
        WeatherChange = 0x03BF, // Updated 6.18 hotfix
        ActorMove = 0x0227, // Updated 6.18 hotfix
        PlayerSpawn = 0x020C, // Updated 6.18 hotfix
        ActorSetPos = 0x0240, // Updated 6.18 hotfix
        PrepareZoning = 0x02F7, // Updated 6.18 hotfix
        ContainerInfo = 0x0323, // Updated 6.18 hotfix
        ItemInfo = 0x01A0, // Updated 6.18 hotfix
        PlaceFieldMarker = 0x01AF, // Updated 6.18 hotfix
        PlaceFieldMarkerPreset = 0x0314, // Updated 6.18 hotfix
        EffectResult = 0x021E, // Updated 6.18 hotfix
        EventStart = 0x02C3, // Updated 6.18 hotfix
        EventFinish = 0x03AA, // Updated 6.18 hotfix
        DesynthResult = 0x03BD, // Updated 6.18 hotfix
        FreeCompanyInfo = 0x011C, // Updated 6.18 hotfix
        FreeCompanyDialog = 0x0367, // Updated 6.18 hotfix
        MarketBoardSearchResult = 0x025D, // Updated 6.18 hotfix
        MarketBoardItemListingCount = 0x033C, // Updated 6.18 hotfix
        MarketBoardItemListingHistory = 0x02ED, // Updated 6.18 hotfix
        MarketBoardItemListing = 0x0371, // Updated 6.18 hotfix
        MarketBoardPurchase = 0x010D, // Updated 6.18 hotfix
        UpdateInventorySlot = 0x02DE, // Updated 6.18 hotfix
        InventoryActionAck = 0x013E, // Updated 6.18 hotfix
        InventoryTransaction = 0x03C3, // Updated 6.18 hotfix
        InventoryTransactionFinish = 0x0180, // Updated 6.18 hotfix
        ResultDialog = 0x0325, // Updated 6.18 hotfix
        RetainerInformation = 0x0289, // Updated 6.18 hotfix
        NpcSpawn = 0x01A4, // Updated 6.18 hotfix
        ItemMarketBoardInfo = 0x00A2, // Updated 6.18 hotfix
        ObjectSpawn = 0x0313, // Updated 6.18 hotfix
        EffectResultBasic = 0x1078, // Updated 6.18 hotfix
        Effect = 0x0353, // Updated 6.18 hotfix
        AoeEffect08 = 0x02e0,
        AoeEffect16 = 0x014D,
        AoeEffect24 = 0x0065,
        AoeEffect32 = 0x012D,
        StatusEffectList = 0x01D0, // Updated 6.18 hotfix
        ActorGauge = 0x03A3, // Updated 6.18 hotfix
        CFPreferredRole = 0x037D, // Updated 6.18 hotfix
        CFNotify = 0x0147, // Updated 6.18 hotfix
        SystemLogMessage = 0x008F, // Updated 6.18 hotfix
        AirshipTimers = 0x02D6, // Updated 6.18 hotfix
        SubmarineTimers = 0x01F0, // Updated 6.18 hotfix
        AirshipStatusList = 0x0355, // Updated 6.18 hotfix
        AirshipStatus = 0x0145, // Updated 6.18 hotfix
        AirshipExplorationResult = 0x024A, // Updated 6.18 hotfix
        SubmarineProgressionStatus = 0x013C, // Updated 6.18 hotfix
        SubmarineStatusList = 0x010C, // Updated 6.18 hotfix
        SubmarineExplorationResult = 0x007C, // Updated 6.18 hotfix

        EventPlay = 0xB6, // Updated for 6.18 hotfix
        EventPlay4 = 0xEF, // Updated for 6.18 hotfix
        EventPlay8 = 0x2BE, // Updated for 6.18 hotfix
        EventPlay16 = 0x268, // Updated for 6.18 hotfix
        EventPlay32 = 0x1EC, // Updated for 6.18 hotfix
        EventPlay64 = 0x2B4, // Updated for 6.18 hotfix
        EventPlay128 = 0x1DA, // Updated for 6.18 hotfix
        EventPlay255 = 0x35C, // Updated for 6.18 hotfix
        EnvironmentControl = 0x7B, // updated 6.18 hotfix

        Logout = 0x03B1 // Updated 6.18 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02D9, // Updated 6.18 hotfix
        ClientTrigger = 0x036A, // Updated 6.18 hotfix
        ChatHandler = 0x011E, // Updated 6.18 hotfix
        SetSearchInfoHandler = 0x0212, // Updated 6.18 hotfix
        MarketBoardPurchaseHandler = 0x00EB, // Updated 6.18 hotfix
        InventoryModifyHandler = 0x0095, // Updated 6.18 hotfix (Base offset: 0x009C)
        UpdatePositionInstance = 0x0131, // Updated 6.18 hotfix

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
