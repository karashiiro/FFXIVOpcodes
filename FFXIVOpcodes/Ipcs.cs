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

        PlayerSetup = 0x01E7,// updated 5.55 hotfix
        UpdateHpMpTp = 0x0077,// updated 5.55 hotfix
        PlayerStats = 0x012E,// updated 5.55 hotfix
        ActorControl = 0x01C8,// updated 5.55 hotfix
        ActorControlSelf = 0x035A,// updated 5.55 hotfix
        ActorControlTarget = 0x0338,// updated 5.55 hotfix
        Playtime = 0x0348,// updated 5.55 hotfix
        UpdateSearchInfo = 0x03DF,// updated 5.55 hotfix
        ExamineSearchInfo = 0x022A,// updated 5.55 hotfix
        Examine = 0x027C,// updated 5.55 hotfix
        MarketBoardSearchResult = 0x039D,// updated 5.55 hotfix
        MarketBoardItemListingCount = 0x0277,// updated 5.55 hotfix
        MarketBoardItemListingHistory = 0x0320,// updated 5.55 hotfix
        MarketBoardItemListing = 0x026B,// updated 5.55 hotfix
        MarketBoardPurchase = 0x013F,// updated 5.55 hotfix
        ActorMove = 0x009D, // updated 5.55 hotfix
        ResultDialog = 0x025D,// updated 5.55 hotfix
        RetainerInformation = 0x02DE,// updated 5.55 hotfix
        NpcSpawn = 0x00F1,// updated 5.55 hotfix
        PlayerSpawn = 0x02C1,// updated 5.55 hotfix
        ActorFreeSpawn = 0x01C5, // updated 5.55 hotfix
        ContainerInfo = 0x00CF,// updated 5.55 hotfix
        ItemInfo = 0x02D3,// updated 5.55 hotfix
        UpdateClassInfo = 0x0065,// updated 5.55 hotfix
        ActorCast = 0x00A9,// updated 5.55 hotfix
        CurrencyCrystalInfo = 0x0166,// updated 5.55 hotfix
        InitZone = 0x021C,// updated 5.55 hotfix
        EffectResult = 0x01E9,// updated 5.55 hotfix
        EventStart = 0x0145,// updated 5.55 hotfix
        EventFinish = 0x0174,// updated 5.55 hotfix
        SomeDirectorUnk4 = 0x0101,// updated 5.55 hotfix
        UpdateInventorySlot = 0x0073,// updated 5.55 hotfix
        DesynthResult = 0x0323,// updated 5.55 hotfix
        InventoryActionAck = 0x027D,// updated 5.55 hotfix
        InventoryTransaction = 0x02FA,// updated 5.55 hotfix
        InventoryTransactionFinish = 0x02EE,// updated 5.55 hotfix
        CFPreferredRole = 0x02B6, // updated 5.55 hotfix
        CFNotify = 0x00DC,// updated 5.55 hotfix
        PrepareZoning = 0x00A4, // updated 5.55 hotfix
        ActorSetPos = 0x0266, // updated 5.55 hotfix
        PlaceFieldMarker = 0x02E2, // updated 5.55 hotfix
        PlaceFieldMarkerPreset = 0x010C, // updated 5.55 hotfix
        ObjectSpawn = 0x00FE, // updated 5.55 hotfix
        Effect = 0x0283, // updated 5.55 hotfix
        StatusEffectList = 0x018A, // updated 5.55 hotfix
        ActorGauge = 0x03B1, // updated 5.55 hotfix
        FreeCompanyInfo = 0x0332, // updated 5.55 hotfix
        FreeCompanyDialog = 0x01C2, // updated 5.55 hotfix

        EventPlay = 0x369, // Updated for 5.55 hotfix
        EventPlay4 = 0x247, // Updated for 5.55 hotfix
        EventPlay8 = 0x227, // Updated for 5.55 hotfix
        EventPlay16 = 0xC5, // Updated for 5.55 hotfix
        EventPlay32 = 0x184, // Updated for 5.55 hotfix
        EventPlay64 = 0x11A, // Updated for 5.55 hotfix
        EventPlay128 = 0x1B3, // Updated for 5.55 hotfix
        EventPlay255 = 0x240, // Updated for 5.55 hotfix

        WeatherChange = 0x0386, // updated 5.55 hotfix

        Logout = 0x0292, // updated 5.55 hotfix

        //HousingWardInfo = 0x0146, // updated 5.55 hotfix

        AirshipExplorationResult = 0x007C, // updated 5.55 hotfix
        AirshipStatus = 0x00AB, // updated 5.55 hotfix
        AirshipStatusList = 0x027B, // updated 5.55 hotfix
        AirshipTimers = 0x02A5, // updated 5.55 hotfix
        SubmarineProgressionStatus = 0x03BB, // updated 5.55 hotfix
        SubmarineStatusList = 0x0072, // updated 5.55 hotfix
        SubmarineExplorationResult = 0x0099, // updated 5.55 hotfix
        SubmarineTimers = 0x037A, // updated 5.55 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x024B,// updated 5.55 hotfix
        ClientTrigger = 0x0337,// updated 5.55 hotfix
        ChatHandler = 0x01B8,// updated 5.55 hotfix
        SetSearchInfoHandler = 0x009C,// updated 5.55 hotfix
        MarketBoardPurchaseHandler = 0x0346,// updated 5.55 hotfix
        InventoryModifyHandler = 0x01D7,// updated 5.55 hotfix (Base offset: 0x01DE)
        UpdatePositionInstance = 0x009D,// updated 5.55 hotfix

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
