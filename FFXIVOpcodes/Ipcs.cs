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
        PlayerSetup = 0x00C5,// Updated 6.01
        UpdateHpMpTp = 0x02B1,// Updated 6.01
        PlayerStats = 0x024B,// Updated 6.01
        ActorControl = 0x01FB,// Updated 6.01
        ActorControlSelf = 0x02C2,// Updated 6.01
        ActorControlTarget = 0x0143,// Updated 6.01
        Playtime = 0x03B6,// Updated 6.01
        UpdateSearchInfo = 0x00F1,// Updated 6.01
        ExamineSearchInfo = 0x02A0,// Updated 6.01
        Examine = 0x00A9,// Updated 6.01
        MarketBoardSearchResult = 0x01E4,// Updated 6.01
        MarketBoardItemListingCount = 0x010F,// Updated 6.01
        MarketBoardItemListingHistory = 0x01B7,// Updated 6.01
        MarketBoardItemListing = 0x01D7,// Updated 6.01
        MarketBoardPurchase = 0x03D0,// Updated 6.01
        ActorMove = 0x0189,// Updated 6.01
        ResultDialog = 0x0330,// Updated 6.01
        RetainerInformation = 0x03A9,// Updated 6.01
        NpcSpawn = 0x039E,// Updated 6.01
        ItemMarketBoardInfo = 0x016B,// Updated 6.01
        PlayerSpawn = 0x00F7,// Updated 6.01
        ContainerInfo = 0x0358,// Updated 6.01
        ItemInfo = 0x0363,// Updated 6.01
        UpdateClassInfo = 0x01B9,// Updated 6.01
        ActorCast = 0x02F2,// Updated 6.01
        CurrencyCrystalInfo = 0x0107,// Updated 6.01
        InitZone = 0x0309,// Updated 6.01
        EffectResult = 0x011C,// Updated 6.01
        EventStart = 0x0200,// Updated 6.01
        EventFinish = 0x01A6,// Updated 6.01
        SomeDirectorUnk4 = 0x0159,// Updated 6.01
        UpdateInventorySlot = 0x0131,// Updated 6.01
        DesynthResult = 0x014D,// Updated 6.01
        InventoryActionAck = 0x0260,// Updated 6.01
        InventoryTransaction = 0x03E2,// Updated 6.01
        InventoryTransactionFinish = 0x014F,// Updated 6.01
        CFNotify = 0x039B,// Updated 6.01
        PrepareZoning = 0x02AC,// Updated 6.01
        ActorSetPos = 0x011F,// Updated 6.01
        PlaceFieldMarker = 0x01CD,// Updated 6.01
        PlaceFieldMarkerPreset = 0x0076,// Updated 6.01
        ObjectSpawn = 0x0269,// Updated 6.01
        StatusEffectList = 0x02D2,// Updated 6.01
        ActorGauge = 0x0208,// Updated 6.01
        FreeCompanyInfo = 0x0122,// Updated 6.01
        FreeCompanyDialog = 0x01EF,// Updated 6.01
        AirshipTimers = 0x0202,// Updated 6.01
        SubmarineTimers = 0x006C,// Updated 6.01
        AirshipStatusList = 0x02F6,// Updated 6.01
        AirshipStatus = 0x0375,// Updated 6.01
        AirshipExplorationResult = 0x03C8,// Updated 6.01
        SubmarineProgressionStatus = 0x009C,// Updated 6.01
        SubmarineStatusList = 0x010E,// Updated 6.01
        SubmarineExplorationResult = 0x03BF,// Updated 6.01

        EventPlay = 0x396, // Updated for 6.01
        EventPlay4 = 0xA6,  // Updated for 6.01
        EventPlay8 = 0x1AE, // Updated for 6.01
        EventPlay16 = 0x175, // Updated for 6.01
        EventPlay32 = 0x24A, // Updated for 6.01
        EventPlay64 = 0x3AB, // Updated for 6.01
        EventPlay128 = 0x34E, // Updated for 6.01
        EventPlay255 = 0x109, // Updated for 6.01

        WeatherChange = 0x01FD, // Updated 6.0

        Logout = 0x02EC, // updated 6.0 hotfix

        //HousingWardInfo = 0x012A, // updated 5.58 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03CA,// Updated 6.01
        ClientTrigger = 0x0204,// Updated 6.01
        ChatHandler = 0x02F8,// Updated 6.01
        SetSearchInfoHandler = 0x01A1,// Updated 6.01
        MarketBoardPurchaseHandler = 0x00FD,// Updated 6.01
        InventoryModifyHandler = 0x0097,// Updated 6.01 (Base offset: 0x009E)
        UpdatePositionInstance = 0x038D,// Updated 6.01

        //PingHandler = 0x02CD, // updated 5.58 hotfix
        //InitHandler = 0x01AA, // updated 5.58 hotfix

        //FinishLoadingHandler = 0x02DA, // updated 5.58 hotfix

        //CFCommenceHandler = 0x0092, // updated 5.58 hotfix

        //CFRegisterDuty = 0x03C7, // updated 5.58 hotfix
        //CFRegisterRoulette = 0x00C2, // updated 5.58 hotfix
        //PlayTimeHandler = 0x00B0, // updated 5.58 hotfix
        //LogoutHandler = 0x0178, // updated 5.58 hotfix
        //CancelLogout = 0x01F9, // updated 5.58 hotfix

        //CFDutyInfoHandler = 0x0092, // updated 5.58 hotfix

        //SocialReqSendHandler = 0x023A, // updated 5.58 hotfix
        //CreateCrossWorldLS = 0x0336, // updated 5.58 hotfix

        //SocialListHandler = 0x0187, // updated 5.58 hotfix
        //ReqSearchInfoHandler = 0x022C, // updated 5.58 hotfix
        //ReqExamineSearchCommentHandler = 0x0315, // updated 5.58 hotfix

        //ReqRemovePlayerFromBlacklist = 0x0145, // updated 5.58 hotfix
        //BlackListHandler = 0x0161, // updated 5.58 hotfix
        //PlayerSearchHandler = 0x02FF, // updated 5.58 hotfix

        //LinkshellListHandler = 0x023B, // updated 5.58 hotfix

        //MarketBoardRequestItemListingInfo = 0x0189, // updated 5.58 hotfix
        //MarketBoardRequestItemListings = 0x0092, // updated 5.58 hotfix
        //MarketBoardSearch = 0x02F9, // updated 5.58 hotfix

        //ReqExamineFcInfo = 0x0136, // updated 5.58 hotfix

        //FcInfoReqHandler = 0x0234, // updated 5.58 hotfix

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0306, // updated 5.58 hotfix

        //ReqJoinNoviceNetwork = 0x01D5, // updated 5.58 hotfix

        //ReqCountdownInitiate = 0x00C2, // updated 5.58 hotfix
        //ReqCountdownCancel = 0x00E6, // updated 5.58 hotfix

        //ZoneLineHandler = 0x03CC, // updated 5.58 hotfix
        //DiscoveryHandler = 0x023A, // updated 5.58 hotfix


        //PlaceFieldMarker = 0x02AF, // updated 5.58 hotfix
        //PlaceFieldMarkerPreset = 0x018E, // updated 5.58 hotfix
        //SkillHandler = 0x0244, // updated 5.58 hotfix
        //GMCommand1 = 0x018A, // updated 5.58 hotfix
        //GMCommand2 = 0x02FD, // updated 5.58 hotfix
        //AoESkillHandler = 0x01F1, // updated 5.58 hotfix

        //InventoryEquipRecommendedItems = 0x0109, // updated 5.58 hotfix

        //ReqPlaceHousingItem = 0x0352, // updated 5.58 hotfix
        //BuildPresetHandler = 0x024E, // updated 5.58 hotfix

        //TalkEventHandler = 0x0305, // updated 5.58 hotfix
        //EmoteEventHandler = 0x03A7, // updated 5.58 hotfix
        //WithinRangeEventHandler = 0x02EE, // updated 5.58 hotfix
        //OutOfRangeEventHandler = 0x00EE, // updated 5.58 hotfix
        //EnterTeriEventHandler = 0x0389, // updated 5.58 hotfix

        //ReturnEventHandler = 0x03B4, // updated 5.58 hotfix
        //TradeReturnEventHandler = 0x0216, // updated 5.58 hotfix

        //LinkshellEventHandler = 0x0239, // updated 5.58 hotfix
        //LinkshellEventHandler1 = 0x0239, // updated 5.58 hotfix

        //ReqEquipDisplayFlagsChange = 0x01F6, // updated 5.58 hotfix

        //LandRenameHandler = 0x018C, // updated 5.58 hotfix
        //HousingUpdateHouseGreeting = 0x02F4, // updated 5.58 hotfix
        //HousingUpdateObjectPosition = 0x02CB, // updated 5.58 hotfix

        //SetSharedEstateSettings = 0x0179, // updated 5.58 hotfix

        //PerformNoteHandler = 0x016E, // updated 5.58 hotfix
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
