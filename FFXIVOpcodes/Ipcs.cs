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
        PlayerSetup = 0x01E4,// updated 5.57
        UpdateHpMpTp = 0x03BE,// updated 5.57
        PlayerStats = 0x00E8,// updated 5.57
        ActorControl = 0x0164,// updated 5.57
        ActorControlSelf = 0x0356,// updated 5.57
        ActorControlTarget = 0x0281,// updated 5.57
        Playtime = 0x0134,// updated 5.57
        UpdateSearchInfo = 0x0299,// updated 5.57
        ExamineSearchInfo = 0x031B,// updated 5.57
        Examine = 0x02B4,// updated 5.57
        MarketBoardSearchResult = 0x02C4,// updated 5.57
        MarketBoardItemListingCount = 0x0075,// updated 5.57
        MarketBoardItemListingHistory = 0x03C5,// updated 5.57
        MarketBoardItemListing = 0x00A7,// updated 5.57
        MarketBoardPurchase = 0x014C,// updated 5.57
        ActorMove = 0x0233,// updated 5.57
        ResultDialog = 0x01AB,// updated 5.57
        RetainerInformation = 0x024B,// updated 5.57
        NpcSpawn = 0x01CE,// updated 5.57
        PlayerSpawn = 0x018D,// updated 5.57
        ContainerInfo = 0x0362,// updated 5.57
        ItemInfo = 0x023E,// updated 5.57
        UpdateClassInfo = 0x00DB,// updated 5.57
        ActorCast = 0x02CC,// updated 5.57
        CurrencyCrystalInfo = 0x03D1,// updated 5.57
        InitZone = 0x01E5,// updated 5.57
        EffectResult = 0x03CF,// updated 5.57
        EventStart = 0x00FB,// updated 5.57
        EventFinish = 0x02CB,// updated 5.57
        SomeDirectorUnk4 = 0x0318,// updated 5.57
        UpdateInventorySlot = 0x01F5,// updated 5.57
        DesynthResult = 0x0218,// updated 5.57
        InventoryActionAck = 0x02AD,// updated 5.57
        InventoryTransaction = 0x0241,// updated 5.57
        InventoryTransactionFinish = 0x0243,// updated 5.57
        CFPreferredRole = 0x0108,// updated 5.57
        CFNotify = 0x0172,// updated 5.57
        PrepareZoning = 0x0250,// updated 5.57
        ActorSetPos = 0x01A3,// updated 5.57
        PlaceFieldMarker = 0x0236,// updated 5.57
        PlaceFieldMarkerPreset = 0x02C5,// updated 5.57
        ObjectSpawn = 0x0254,// updated 5.57
        Effect = 0x008F,// updated 5.57
        StatusEffectList = 0x0192,// updated 5.57
        ActorGauge = 0x0377,// updated 5.57
        FreeCompanyInfo = 0x01A9,// updated 5.57
        FreeCompanyDialog = 0x039B,// updated 5.57

        EventPlay = 0x36A, // updated 5.57
        EventPlay4 = 0x397, // updated 5.57
        EventPlay8 = 0xA6,  // updated 5.57
        EventPlay16 = 0x23D, // updated 5.57
        EventPlay32 = 0x204, // updated 5.57
        EventPlay64 = 0xEF,  // updated 5.57
        EventPlay128 = 0x29C, // updated 5.57
        EventPlay255 = 0x21B, // updated 5.57

        WeatherChange = 0x0157, // updated 5.57

        Logout = 0x0360, // updated 5.57

        //HousingWardInfo = 0x03E7, // updated 5.57

        AirshipExplorationResult = 0x007C, // updated 5.55 hotfix
        AirshipStatus = 0x00AB, // updated 5.55 hotfix
        AirshipStatusList = 0x027B, // updated 5.55 hotfix
        AirshipTimers = 0x02A5, // updated 5.55 hotfix
        SubmarineProgressionStatus = 0x0368,// updated 5.57
        SubmarineStatusList = 0x0345,// updated 5.57
        SubmarineExplorationResult = 0x027A,// updated 5.57
        SubmarineTimers = 0x037A, // updated 5.55 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0077,// updated 5.57
        ClientTrigger = 0x02DC,// updated 5.57
        ChatHandler = 0x00E1,// updated 5.57
        SetSearchInfoHandler = 0x01D3,// updated 5.57
        MarketBoardPurchaseHandler = 0x01F3,// updated 5.57
        InventoryModifyHandler = 0x00C0,// updated 5.57 (Base offset: 0x00C7)
        UpdatePositionInstance = 0x0233,// updated 5.57

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
