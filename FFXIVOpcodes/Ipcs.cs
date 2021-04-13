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

        PlayerSetup = 0x010B, //updated 5.5
        UpdateHpMpTp = 0x00EF, //updated 5.5
        PlayerStats = 0x0205, //updated 5.5
        ActorControl = 0x03B5, //updated 5.5
        ActorControlSelf = 0x03C0, //updated 5.5
        ActorControlTarget = 0x0202, //updated 5.5
        Playtime = 0x00BB, //updated 5.5
        UpdateSearchInfo = 0x033F, //updated 5.5
        ExamineSearchInfo = 0x01F9, //updated 5.5
        Examine = 0x018F, //updated 5.5
        MarketBoardSearchResult = 0x014A, //updated 5.5
        MarketBoardItemListingCount = 0x031A, //updated 5.5
        MarketBoardItemListingHistory = 0x008B, //updated 5.5
        MarketBoardItemListing = 0x02FF, //updated 5.5
        MarketBoardPurchase = 0x0208, //updated 5.5
        ActorMove = 0x03AE, //updated 5.5
        ResultDialog = 0x0311, //updated 5.5
        RetainerInformation = 0x0352, //updated 5.5
        NpcSpawn = 0x03C1, //updated 5.5
        PlayerSpawn = 0x02EF, //updated 5.5
        ActorFreeSpawn = 0x00C2, //updated 5.5
        ContainerInfo = 0x0366, //updated 5.5
        ItemInfo = 0x006E, //updated 5.5
        UpdateClassInfo = 0x010D, //updated 5.5
        ActorCast = 0x00B6, //updated 5.5
        CurrencyCrystalInfo = 0x0075, //updated 5.5
        InitZone = 0x03D7, //updated 5.5
        EffectResult = 0x0143, //updated 5.5
        EventStart = 0x01AB, //updated 5.5
        EventPlay = 0x015B, //updated 5.5
        EventFinish = 0x0299, //updated 5.5
        SomeDirectorUnk4 = 0x0226, //updated 5.5
        EventPlay4 = 0x007E, //updated 5.5
        UpdateInventorySlot = 0x0397, //updated 5.5
        InventoryActionAck = 0x0288, //updated 5.5
        InventoryTransaction = 0x037F, //updated 5.5
        InventoryTransactionFinish = 0x010E, //updated 5.5
        CFPreferredRole = 0x015C, //updated 5.5
        CFNotify = 0x0174, //updated 5.5
        PrepareZoning = 0x00D2, //updated 5.5
        PlaceFieldMarker = 0x02DB, //updated 5.5
        PlaceFieldMarkerPreset = 0x03A4, //updated 5.5
        ObjectSpawn = 0x0358, //updated 5.5
        Effect = 0x0204, //updated 5.5
        StatusEffectList = 0x0343, //updated 5.5
        ActorGauge = 0x03A7, //updated 5.5
        FreeCompanyInfo = 0x034B, //updated 5.5

        ActorSetPos = 0x0328, // updated 5.5

        DesynthResult = 0x0209, // updated 5.5
        EventPlay8 = 0x124, // Updated 5.5
        EventPlay16 = 0x200, // Updated 5.5
        EventPlay32 = 0x2CE, // Updated 5.5
        EventPlay64 = 0x1FA, // Updated 5.5
        EventPlay128e = 0x308, // Updated 5.5
        EventPlay255 = 0x236, // Updated 5.5

        //EventPlay8 = 0x318, // updated 5.45 hotfix
        //EventPlay16 = 0x20D, // updated 5.45 hotfix
        //EventPlay32 = 0x3B5, // updated 5.45 hotfix
        //EventPlay64 = 0x39E, // updated 5.45 hotfix
        //EventPlay128 = 0x2F4, // updated 5.45 hotfix
        //EventPlay255 = 0x9D, // updated 5.45 hotfix

        //WeatherChange = 0x0167, // updated 5.45 hotfix

        Logout = 0x028C, // updated 5.5

        //HousingWardInfo = 0x015E, // updated 5.45 hotfix

        //AirshipExplorationResult = 0x0131, // updated 5.45 hotfix
        //AirshipStatus = 0x0253, // updated 5.45 hotfix
        //AirshipStatusList = 0x0391, // updated 5.45 hotfix
        //AirshipTimers = 0x0206, // updated 5.45 hotfix
        //SubmarineExplorationResult = 0x00EB, // updated 5.45 hotfix
        //SubmarineProgressionStatus = 0x0333, // updated 5.45 hotfix
        //SubmarineStatusList = 0x01F2, // updated 5.45 hotfix
        //SubmarineTimers = 0x013B, // updated 5.45 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x008C, //updated 5.5
        ClientTrigger = 0x01A0, //updated 5.5
        ChatHandler = 0x03E5, //updated 5.5
        SetSearchInfoHandler = 0x00F4, //updated 5.5
        MarketBoardPurchaseHandler = 0x013B, //updated 5.5
        InventoryModifyHandler = 0x018A, //updated 5.5 (Base offset: 0x0191)
        UpdatePositionInstance = 0x03AE, //updated 5.5

        //PingHandler = 0x0183, // updated 5.45 hotfix
        //InitHandler = 0x01EA, // updated 5.45 hotfix

        //FinishLoadingHandler = 0x023F, // updated 5.45 hotfix

        //CFCommenceHandler = 0x01A0, // updated 5.45 hotfix

        //CFRegisterDuty = 0x033C, // updated 5.45 hotfix
        //CFRegisterRoulette = 0x0121, // updated 5.45 hotfix
        //PlayTimeHandler = 0x0096, // updated 5.45 hotfix
        //LogoutHandler = 0x0312, // updated 5.45 hotfix
        //CancelLogout = 0x0307, // updated 5.45 hotfix

        //CFDutyInfoHandler = 0x01A0, // updated 5.45 hotfix

        SocialReqSendHandler = 0x0288, // updated 5.45 hotfix
        //CreateCrossWorldLS = 0x0174, // updated 5.45 hotfix

        SocialListHandler = 0x02B0, // updated 5.45 hotfix
        ReqSearchInfoHandler = 0x03AC, // updated 5.45 hotfix
        //ReqExamineSearchCommentHandler = 0x0335, // updated 5.45 hotfix

        //ReqRemovePlayerFromBlacklist = 0x0112, // updated 5.45 hotfix
        BlackListHandler = 0x02CD, // updated 5.45 hotfix
        //PlayerSearchHandler = 0x03E0, // updated 5.45 hotfix

        LinkshellListHandler = 0x0258, // updated 5.45 hotfix

        //MarketBoardRequestItemListingInfo = 0x00A4, // updated 5.45 hotfix
        //MarketBoardRequestItemListings = 0x01A0, // updated 5.45 hotfix
        //MarketBoardSearch = 0x02B8, // updated 5.45 hotfix

        //ReqExamineFcInfo = 0x02A2, // updated 5.45 hotfix

        //FcInfoReqHandler = 0x00DD, // updated 5.45 hotfix

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0173, // updated 5.45 hotfix

        //ReqJoinNoviceNetwork = 0x03C6, // updated 5.45 hotfix

        //ReqCountdownInitiate = 0x0121, // updated 5.45 hotfix
        //ReqCountdownCancel = 0x009E, // updated 5.45 hotfix

        //ZoneLineHandler = 0x00BA, // updated 5.45 hotfix
        //DiscoveryHandler = 0x0288, // updated 5.45 hotfix


        //PlaceFieldMarker = 0x0392, // updated 5.45 hotfix
        //PlaceFieldMarkerPreset = 0x01D3, // updated 5.45 hotfix
        //SkillHandler = 0x0388, // updated 5.45 hotfix
        //GMCommand1 = 0x01E0, // updated 5.45 hotfix
        //GMCommand2 = 0x0114, // updated 5.45 hotfix
        //AoESkillHandler = 0x03A0, // updated 5.45 hotfix

        //InventoryEquipRecommendedItems = 0x0186, // updated 5.45 hotfix

        //ReqPlaceHousingItem = 0x0360, // updated 5.45 hotfix
        //BuildPresetHandler = 0x01D7, // updated 5.45 hotfix

        //TalkEventHandler = 0x00C2, // updated 5.45 hotfix
        //EmoteEventHandler = 0x03D5, // updated 5.45 hotfix
        //WithinRangeEventHandler = 0x0171, // updated 5.45 hotfix
        //OutOfRangeEventHandler = 0x019B, // updated 5.45 hotfix
        //EnterTeriEventHandler = 0x027F, // updated 5.45 hotfix

        //ReturnEventHandler = 0x02AD, // updated 5.45 hotfix
        //TradeReturnEventHandler = 0x00A7, // updated 5.45 hotfix

        //LinkshellEventHandler = 0x0221, // updated 5.45 hotfix
        //LinkshellEventHandler1 = 0x0221, // updated 5.45 hotfix

        //ReqEquipDisplayFlagsChange = 0x03B0, // updated 5.45 hotfix

        //LandRenameHandler = 0x0187, // updated 5.45 hotfix
        //HousingUpdateHouseGreeting = 0x0367, // updated 5.45 hotfix
        //HousingUpdateObjectPosition = 0x0265, // updated 5.45 hotfix

        //SetSharedEstateSettings = 0x0146, // updated 5.45 hotfix

        //PerformNoteHandler = 0x036E, // updated 5.45 hotfix
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
