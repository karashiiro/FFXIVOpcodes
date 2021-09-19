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
        PlayerSetup = 0x01D5, // updated 5.58 hotfix
        UpdateHpMpTp = 0x01A7, // updated 5.58 hotfix
        PlayerStats = 0x0295, // updated 5.58 hotfix
        ActorControl = 0x00B0, // updated 5.58 hotfix
        ActorControlSelf = 0x02B6, // updated 5.58 hotfix
        ActorControlTarget = 0x03C5, // updated 5.58 hotfix
        Playtime = 0x0179, // updated 5.58 hotfix
        UpdateSearchInfo = 0x03E5, // updated 5.58 hotfix
        ExamineSearchInfo = 0x0133, // updated 5.58 hotfix
        Examine = 0x0365, // updated 5.58 hotfix
        MarketBoardSearchResult = 0x01F1, // updated 5.58 hotfix
        MarketBoardItemListingCount = 0x0068, // updated 5.58 hotfix
        MarketBoardItemListingHistory = 0x01BA, // updated 5.58 hotfix
        MarketBoardItemListing = 0x0076, // updated 5.58 hotfix
        MarketBoardPurchase = 0x00C6, // updated 5.58 hotfix
        ActorMove = 0x00F8, // updated 5.58 hotfix
        ResultDialog = 0x0273, // updated 5.58 hotfix
        RetainerInformation = 0x022F, // updated 5.58 hotfix
        ItemMarketBoardInfo = 0x0364, // updated 5.58 hotfix
        NpcSpawn = 0x00D2, // updated 5.58 hotfix
        PlayerSpawn = 0x01D8, // updated 5.58 hotfix
        ContainerInfo = 0x025C, // updated 5.58 hotfix
        ItemInfo = 0x01CC, // updated 5.58 hotfix
        UpdateClassInfo = 0x0084, // updated 5.58 hotfix
        ActorCast = 0x015D, // updated 5.58 hotfix
        CurrencyCrystalInfo = 0x0345, // updated 5.58 hotfix
        InitZone = 0x0320, // updated 5.58 hotfix
        EffectResult = 0x0387, // updated 5.58 hotfix
        EventStart = 0x02DA, // updated 5.58 hotfix
        EventFinish = 0x0235, // updated 5.58 hotfix
        SomeDirectorUnk4 = 0x03DD, // updated 5.58 hotfix
        UpdateInventorySlot = 0x02F7, // updated 5.58 hotfix
        DesynthResult = 0x0238, // updated 5.58 hotfix
        InventoryActionAck = 0x03B8, // updated 5.58 hotfix
        InventoryTransaction = 0x027F, // updated 5.58 hotfix
        InventoryTransactionFinish = 0x0176, // updated 5.58 hotfix
        CFNotify = 0x0327, // updated 5.58 hotfix
        PrepareZoning = 0x02AB, // updated 5.58 hotfix
        ActorSetPos = 0x0299, // updated 5.58 hotfix
        PlaceFieldMarker = 0x0371, // updated 5.58 hotfix
        PlaceFieldMarkerPreset = 0x026D, // updated 5.58 hotfix
        ObjectSpawn = 0x0125, // updated 5.58 hotfix
        Effect = 0x03CA, // updated 5.58 hotfix
        StatusEffectList = 0x0074, // updated 5.58 hotfix
        ActorGauge = 0x01C1, // updated 5.58 hotfix
        FreeCompanyInfo = 0x01F7, // updated 5.58 hotfix
        FreeCompanyDialog = 0x008D, // updated 5.58 hotfix

        EventPlay = 0x16B, // Updated 5.58 hotfix
        EventPlay4 = 0x10A, // Updated 5.58 hotfix
        EventPlay8 = 0x337, // Updated 5.58 hotfix
        EventPlay16 = 0x269, // Updated 5.58 hotfix
        EventPlay32 = 0x23E, // Updated 5.58 hotfix
        EventPlay64 = 0xDE, // Updated 5.58 hotfix
        EventPlay128 = 0x2D0, // Updated 5.58 hotfix
        EventPlay255 = 0x362, // Updated 5.58 hotfix

        WeatherChange = 0x0323, // updated 5.58 hotfix

        Logout = 0x0214, // updated 5.58 hotfix

        HousingWardInfo = 0x012A, // updated 5.58 hotfix

        AirshipExplorationResult = 0x0203, // updated 5.58 hotfix
        AirshipStatus = 0x030C, // updated 5.58 hotfix
        AirshipStatusList = 0x02FE, // updated 5.58 hotfix
        AirshipTimers = 0x0166, // updated 5.58 hotfix

        SubmarineProgressionStatus = 0x0357, // updated 5.58 hotfix
        SubmarineStatusList = 0x01EF, // updated 5.58 hotfix
        SubmarineExplorationResult = 0x00AA, // updated 5.58 hotfix
        SubmarineTimers = 0x0247, // updated 5.58 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01AF, // updated 5.58 hotfix
        ClientTrigger = 0x03DB, // updated 5.58 hotfix
        ChatHandler = 0x03B0, // updated 5.58 hotfix
        SetSearchInfoHandler = 0x01D4, // updated 5.58 hotfix
        MarketBoardPurchaseHandler = 0x01FC, // updated 5.58 hotfix
        InventoryModifyHandler = 0x029E, // updated 5.58 hotfix (Base offset: 0x02A5)
        UpdatePositionInstance = 0x00F8, // updated 5.58 hotfix

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
