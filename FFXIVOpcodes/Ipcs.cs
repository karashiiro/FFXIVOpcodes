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
        PlayerSetup = 0x0296,// updated 5.58
        UpdateHpMpTp = 0x039B,// updated 5.58
        PlayerStats = 0x00D5,// updated 5.58
        ActorControl = 0x0264,// updated 5.58
        ActorControlSelf = 0x0314,// updated 5.58
        ActorControlTarget = 0x00FC,// updated 5.58
        Playtime = 0x02BE,// updated 5.58
        UpdateSearchInfo = 0x0219,// updated 5.58
        ExamineSearchInfo = 0x031F,// updated 5.58
        Examine = 0x00D3,// updated 5.58
        MarketBoardSearchResult = 0x0355,// updated 5.58
        MarketBoardItemListingCount = 0x0275,// updated 5.58
        MarketBoardItemListingHistory = 0x0112,// updated 5.58
        MarketBoardItemListing = 0x00F5,// updated 5.58
        MarketBoardPurchase = 0x00CD,// updated 5.58
        ActorMove = 0x023D,// updated 5.58
        ResultDialog = 0x00DF,// updated 5.58
        RetainerInformation = 0x0069,// updated 5.58
        NpcSpawn = 0x014B,// updated 5.58
        PlayerSpawn = 0x0249,// updated 5.58
        ContainerInfo = 0x0208,// updated 5.58
        ItemInfo = 0x00A7,// updated 5.58
        UpdateClassInfo = 0x0198,// updated 5.58
        ActorCast = 0x02A7,// updated 5.58
        CurrencyCrystalInfo = 0x0394,// updated 5.58
        InitZone = 0x0100,// updated 5.58
        EffectResult = 0x0151,// updated 5.58
        EventStart = 0x01CC,// updated 5.58
        EventFinish = 0x0180,// updated 5.58
        SomeDirectorUnk4 = 0x01BD,// updated 5.58
        UpdateInventorySlot = 0x0200,// updated 5.58
        DesynthResult = 0x038F,// updated 5.58
        InventoryActionAck = 0x0305,// updated 5.58
        InventoryTransaction = 0x03AC,// updated 5.58
        InventoryTransactionFinish = 0x01A3,// updated 5.58
        CFNotify = 0x01AC,// updated 5.58
        PrepareZoning = 0x0171,// updated 5.58
        ActorSetPos = 0x0280,// updated 5.58
        PlaceFieldMarker = 0x011A,// updated 5.58
        PlaceFieldMarkerPreset = 0x03B0,// updated 5.58
        ObjectSpawn = 0x0104,// updated 5.58
        Effect = 0x0102,// updated 5.58
        StatusEffectList = 0x01C5,// updated 5.58
        ActorGauge = 0x0335,// updated 5.58
        FreeCompanyInfo = 0x0346,// updated 5.58
        FreeCompanyDialog = 0x0328,// updated 5.58

        EventPlay = 0x1EF, // Updated for 5.58
        EventPlay4 = 0x21C, // Updated for 5.58
        EventPlay8 = 0x337, // Updated for 5.58
        EventPlay16 = 0x319, // Updated for 5.58
        EventPlay32 = 0x1E2, // Updated for 5.58
        EventPlay64 = 0x2FD, // Updated for 5.58
        EventPlay128 = 0x26E, // Updated for 5.58
        EventPlay255 = 0x39E, // Updated for 5.58

        WeatherChange = 0x01B1, // updated 5.58

        Logout = 0x0297, // updated 5.58

        HousingWardInfo = 0x00A4, // updated 5.58

        AirshipExplorationResult = 0x036C, // updated 5.58
        AirshipStatus = 0x021F, // updated 5.58
        AirshipStatusList = 0x0073, // updated 5.58
        AirshipTimers = 0x0250, // updated 5.58

        SubmarineProgressionStatus = 0x03C0, // updated 5.58
        SubmarineStatusList = 0x0338, // updated 5.58
        SubmarineExplorationResult = 0x01D0, // updated 5.58
        SubmarineTimers = 0x0292, // updated 5.58
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0212,// updated 5.58
        ClientTrigger = 0x008B,// updated 5.58
        ChatHandler = 0x02F4,// updated 5.58
        SetSearchInfoHandler = 0x010A,// updated 5.58
        MarketBoardPurchaseHandler = 0x00BD,// updated 5.58
        InventoryModifyHandler = 0x014A,// updated 5.58 (Base offset: 0x0151)
        UpdatePositionInstance = 0x01A3,// updated 5.58

        //PingHandler = 0x016D, // updated 5.55 hotfix
        //InitHandler = 0x01F6, // updated 5.55 hotfix

        //FinishLoadingHandler = 0x01CC, // updated 5.55 hotfix

        //CFCommenceHandler = 0x0097, // updated 5.55 hotfix

        //CFRegisterDuty = 0x03BF, // updated 5.55 hotfix
        //CFRegisterRoulette = 0x00B1, // updated 5.55 hotfix
        //PlayTimeHandler = 0x0264, // updated 5.55 hotfix
        //LogoutHandler = 0x03D7, // updated 5.55 hotfix
        //CancelLogout = 0x0303, // updated 5.55 hotfix

        //CFDutyInfoHandler = 0x0097, // updated 5.55 hotfix

        //SocialReqSendHandler = 0x0279, // updated 5.55 hotfix
        //CreateCrossWorldLS = 0x01A9, // updated 5.55 hotfix

        //SocialListHandler = 0x0380, // updated 5.55 hotfix
        //ReqSearchInfoHandler = 0x023E, // updated 5.55 hotfix
        //ReqExamineSearchCommentHandler = 0x02F1, // updated 5.55 hotfix

        //ReqRemovePlayerFromBlacklist = 0x00F2, // updated 5.55 hotfix
        //BlackListHandler = 0x013F, // updated 5.55 hotfix
        //PlayerSearchHandler = 0x02F5, // updated 5.55 hotfix

        //LinkshellListHandler = 0x0244, // updated 5.55 hotfix

        //MarketBoardRequestItemListingInfo = 0x00D0, // updated 5.55 hotfix
        //MarketBoardRequestItemListings = 0x0097, // updated 5.55 hotfix
        //MarketBoardSearch = 0x02CC, // updated 5.55 hotfix

        //ReqExamineFcInfo = 0x0129, // updated 5.55 hotfix

        //FcInfoReqHandler = 0x0243, // updated 5.55 hotfix

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x036E, // updated 5.55 hotfix

        //ReqJoinNoviceNetwork = 0x0296, // updated 5.55 hotfix

        //ReqCountdownInitiate = 0x00B1, // updated 5.55 hotfix
        //ReqCountdownCancel = 0x0173, // updated 5.55 hotfix

        //ZoneLineHandler = 0x03CB, // updated 5.55 hotfix
        //DiscoveryHandler = 0x0279, // updated 5.55 hotfix


        //PlaceFieldMarker = 0x02A1, // updated 5.55 hotfix
        //PlaceFieldMarkerPreset = 0x0310, // updated 5.55 hotfix
        //SkillHandler = 0x032A, // updated 5.55 hotfix
        //GMCommand1 = 0x01EB, // updated 5.55 hotfix
        //GMCommand2 = 0x02F4, // updated 5.55 hotfix
        //AoESkillHandler = 0x0355, // updated 5.55 hotfix

        //InventoryEquipRecommendedItems = 0x00EC, // updated 5.55 hotfix

        //ReqPlaceHousingItem = 0x0344, // updated 5.55 hotfix
        //BuildPresetHandler = 0x01FE, // updated 5.55 hotfix

        //TalkEventHandler = 0x0187, // updated 5.55 hotfix
        //EmoteEventHandler = 0x03AA, // updated 5.55 hotfix
        //WithinRangeEventHandler = 0x01C0, // updated 5.55 hotfix
        //OutOfRangeEventHandler = 0x00EF, // updated 5.55 hotfix
        //EnterTeriEventHandler = 0x037A, // updated 5.55 hotfix

        //ReturnEventHandler = 0x03B5, // updated 5.55 hotfix
        //TradeReturnEventHandler = 0x01A4, // updated 5.55 hotfix

        //LinkshellEventHandler = 0x01A6, // updated 5.55 hotfix
        //LinkshellEventHandler1 = 0x01A6, // updated 5.55 hotfix

        //ReqEquipDisplayFlagsChange = 0x0273, // updated 5.55 hotfix

        //LandRenameHandler = 0x0175, // updated 5.55 hotfix
        //HousingUpdateHouseGreeting = 0x036A, // updated 5.55 hotfix
        //HousingUpdateObjectPosition = 0x02B9, // updated 5.55 hotfix

        //SetSharedEstateSettings = 0x02BE, // updated 5.55 hotfix

        //PerformNoteHandler = 0x0149, // updated 5.55 hotfix
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
