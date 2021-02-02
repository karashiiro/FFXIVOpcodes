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
        PlayerSetup = 0x035C, //updated 5.45
        UpdateHpMpTp = 0x01DB, //updated 5.45
        PlayerStats = 0x036F, //updated 5.45
        ClientTrigger = 0x034F, //updated 5.45
        ActorControl = 0x00F0, //updated 5.45
        ActorControlSelf = 0x0350, //updated 5.45
        ActorControlTarget = 0x029A, //updated 5.45
        Playtime = 0x033A, //updated 5.45
        SetSearchInfoHandler = 0x01EF, //updated 5.45
        UpdateSearchInfo = 0x012F, //updated 5.45
        ExamineSearchInfo = 0x02CB, //updated 5.45
        Examine = 0x0348, //updated 5.45
        MarketBoardSearchResult = 0x01CC, //updated 5.45
        MarketBoardItemListingCount = 0x0271, //updated 5.45
        MarketBoardItemListingHistory = 0x02A4, //updated 5.45
        MarketBoardItemListing = 0x0273, //updated 5.45
        ActorMove = 0x03A9, //updated 5.45
        ResultDialog = 0x00E5, //updated 5.45
        RetainerInformation = 0x0101, //updated 5.45
        NpcSpawn = 0x03C4, //updated 5.45
        PlayerSpawn = 0x0083, //updated 5.45
        //ActorFreeSpawn = 0x01DB, //updated 5.45
        ItemInfo = 0x0158, //updated 5.45
        UpdateClassInfo = 0x02F4, //updated 5.45
        ActorCast = 0x02B2, //updated 5.45
        CurrencyCrystalInfo = 0x01F4, //updated 5.45
        InitZone = 0x01C6, //updated 5.45
        EffectResult = 0x031C, //updated 5.45
        EventStart = 0x026C, //updated 5.45
        EventFinish = 0x02B1, //updated 5.45
        SomeDirectorUnk4 = 0x0391, //updated 5.45
        UpdateInventorySlot = 0x032A, //updated 5.45
        InventoryActionAck = 0x0205, //updated 5.45
        InventoryTransaction = 0x01CE, //updated 5.45
        InventoryTransactionFinish = 0x036D, //updated 5.45
        CFPreferredRole = 0x020C, //updated 5.45
        CFNotify = 0x014C, //updated 5.45
        PrepareZoning = 0x00AB, //updated 5.45
        ActorSetPos = 0x0283, //updated 5.45
        ObjectSpawn = 0x03C8, //updated 5.45
        Effect = 0x021F, //updated 5.45
        AddStatusEffect = 0x026B, //updated 5.45
        StatusEffectList = 0x00C2, //updated 5.45
        ActorGauge = 0x0278, //updated 5.45
        DesynthResult = 0x034B, //updated 5.45

        EventPlay = 0x1D2, // Updated for 5.45
        EventPlay4 = 0x2CF, // Updated for 5.45
        EventPlay8 = 0x3B2, // Updated for 5.45
        EventPlay16 = 0x1AE, // Updated for 5.45
        EventPlay32 = 0x11D, // Updated for 5.45
        EventPlay64 = 0x262, // Updated for 5.45
        EventPlay128 = 0x318, // Updated for 5.45
        EventPlay255 = 0x37F, // Updated for 5.45

        WeatherChange = 0x0240, // updated 5.45

        Logout = 0x0249, // updated 5.45

        //HousingWardInfo = 0x0331, // updated 5.41

        AirshipExplorationResult = 0x035E, // updated 5.45
        AirshipStatus = 0x0306, // updated 5.45
        AirshipStatusList = 0x00FA, // updated 5.45
        AirshipTimers = 0x00A6, // updated 5.45
        SubmarineExplorationResult = 0x0225, // updated 5.45
        SubmarineProgressionStatus = 0x0086, // updated 5.45
        SubmarineStatusList = 0x03BB, // updated 5.45
        SubmarineTimers = 0x02ED, // updated 5.45

        FreeCompanyInfo = 0x01BA, // updated 5.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        //PingHandler = 0x0324, // updated 5.45
        //InitHandler = 0x00B8, // updated 5.45

        //FinishLoadingHandler = 0x019D, // updated 5.45

        //CFCommenceHandler = 0x0184, // updated 5.45

        //CFRegisterDuty = 0x00ED, // updated 5.45
        //CFRegisterRoulette = 0x0102, // updated 5.45
        //PlayTimeHandler = 0x0278, // updated 5.45
        //LogoutHandler = 0x0072, // updated 5.45
        //CancelLogout = 0x0251, // updated 5.45

        //CFDutyInfoHandler = 0x0184, // updated 5.45

        //SocialReqSendHandler = 0x0264, // updated 5.45
        //CreateCrossWorldLS = 0x00C5, // updated 5.45

        ChatHandler = 0x02F2, // updated 5.45

        //SocialListHandler = 0x02AE, // updated 5.45
        SetSearchInfoHandler = 0x019B, // updated 5.45
        //ReqSearchInfoHandler = 0x02AE, // updated 5.45
        //ReqExamineSearchCommentHandler = 0x0308, // updated 5.45

        //ReqRemovePlayerFromBlacklist = 0x00CC, // updated 5.45
        //BlackListHandler = 0x00AE, // updated 5.45
        //PlayerSearchHandler = 0x0387, // updated 5.45

        //LinkshellListHandler = 0x00E6, // updated 5.45

        //MarketBoardRequestItemListingInfo = 0x02F2, // updated 5.45
        //MarketBoardRequestItemListings = 0x0184, // updated 5.45
        //MarketBoardSearch = 0x031C, // updated 5.45

        //ReqExamineFcInfo = 0x0240, // updated 5.45

        //FcInfoReqHandler = 0x0145, // updated 5.45

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0392, // updated 5.45

        //ReqJoinNoviceNetwork = 0x0245, // updated 5.45

        //ReqCountdownInitiate = 0x0113, // updated 5.45
        //ReqCountdownCancel = 0x0078, // updated 5.45

        //ZoneLineHandler = 0x0327, // updated 5.45
        ClientTrigger = 0x01E7, // updated 5.45
        //DiscoveryHandler = 0x0102, // updated 5.45


        PlaceFieldMarker = 0x03BC, //updated 5.45
        PlaceFieldMarkerPreset = 0x0162, //updated 5.45
        //SkillHandler = 0x03AE, // updated 5.45
        //GMCommand1 = 0x00B0, // updated 5.45
        //GMCommand2 = 0x0264, // updated 5.45
        //AoESkillHandler = 0x02AC, // updated 5.45


        UpdatePositionHandler = 0x01B3, //updated 5.45

        InventoryModifyHandler = 0x0088, //updated 5.45 (Base offset: 0x008F)

        //InventoryEquipRecommendedItems = 0x00ED, // updated 5.45

        //ReqPlaceHousingItem = 0x0210, // updated 5.45
        //BuildPresetHandler = 0x01F0, // updated 5.45

        //TalkEventHandler = 0x022F, // updated 5.45
        //EmoteEventHandler = 0x0291, // updated 5.45
        //WithinRangeEventHandler = 0x0261, // updated 5.45
        //OutOfRangeEventHandler = 0x0341, // updated 5.45
        //EnterTeriEventHandler = 0x0374, // updated 5.45

        //ReturnEventHandler = 0x0175, // updated 5.45
        //TradeReturnEventHandler = 0x00B4, // updated 5.45

        //LinkshellEventHandler = 0x0286, // updated 5.45
        //LinkshellEventHandler1 = 0x0286, // updated 5.45

        //ReqEquipDisplayFlagsChange = 0x0194, // updated 5.45

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x01A1, // updated 5.45
        //HousingUpdateObjectPosition = 0x03A2, // updated 5.45

        //SetSharedEstateSettings = 0x0243, // updated 5.45

        UpdatePositionInstance = 0x0338, //updated 5.45

        //PerformNoteHandler = 0x03B8, // updated 5.45
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
