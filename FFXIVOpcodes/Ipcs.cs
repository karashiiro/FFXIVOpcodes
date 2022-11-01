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
        // Server Zone
        PlayerSetup = 0x0178, // Updated 6.28
        UpdateHpMpTp = 0x02DC, // Updated 6.28
        UpdateClassInfo = 0x03CC, // Updated 6.28
        PlayerStats = 0x0313, // Updated 6.28
        ActorControl = 0x02D3, // Updated 6.28
        ActorControlSelf = 0x029B, // Updated 6.28
        ActorControlTarget = 0x0253, // Updated 6.28
        Playtime = 0x031A, // Updated 6.28
        UpdateSearchInfo = 0x025A, // Updated 6.28
        ExamineSearchInfo = 0x021C, // Updated 6.28
        Examine = 0x027C, // Updated 6.28
        ActorCast = 0x0398, // Updated 6.28
        CurrencyCrystalInfo = 0x0108, // Updated 6.28
        InitZone = 0x03E5, // Updated 6.28
        WeatherChange = 0x00F9, // Updated 6.28
        ActorMove = 0x00C2, // Updated 6.28
        PlayerSpawn = 0x02C2, // Updated 6.28
        ActorSetPos = 0x022E, // Updated 6.28
        PrepareZoning = 0x0281, // Updated 6.28
        ContainerInfo = 0x03A9, // Updated 6.28
        ItemInfo = 0x014D, // Updated 6.28
        PlaceFieldMarker = 0x006F, // Updated 6.28
        PlaceFieldMarkerPreset = 0x010F, // Updated 6.28
        EffectResult = 0x034B, // Updated 6.28
        EventStart = 0x00DA, // Updated 6.28
        EventFinish = 0x0162, // Updated 6.28
        DesynthResult = 0x00A5, // Updated 6.28
        FreeCompanyInfo = 0x0276, // Updated 6.28
        FreeCompanyDialog = 0x0168, // Updated 6.28
        MarketBoardSearchResult = 0x0214, // Updated 6.28
        MarketBoardItemListingCount = 0x0241, // Updated 6.28
        MarketBoardItemListingHistory = 0x00BC, // Updated 6.28
        MarketBoardItemListing = 0x0066, // Updated 6.28
        MarketBoardPurchase = 0x00B7, // Updated 6.28
        UpdateInventorySlot = 0x008A, // Updated 6.28
        InventoryActionAck = 0x0291, // Updated 6.28
        InventoryTransaction = 0x0381, // Updated 6.28
        InventoryTransactionFinish = 0x02E4, // Updated 6.28
        ResultDialog = 0x033A, // Updated 6.28
        RetainerInformation = 0x027D, // Updated 6.28
        NpcSpawn = 0x03CD, // Updated 6.28
        ItemMarketBoardInfo = 0x0091, // Updated 6.28
        ObjectSpawn = 0x00BE, // Updated 6.28
        EffectResultBasic = 0x1070, // Updated 6.28
        Effect = 0x0130, // Updated 6.28
        StatusEffectList = 0x0090, // Updated 6.28
        ActorGauge = 0x011E, // Updated 6.28
        CFNotify = 0x03D5, // Updated 6.28
        SystemLogMessage = 0x01F1, // Updated 6.28
        AirshipTimers = 0x0221, // Updated 6.28
        SubmarineTimers = 0x008C, // Updated 6.28
        AirshipStatusList = 0x0277, // Updated 6.28
        AirshipStatus = 0x0394, // Updated 6.28
        AirshipExplorationResult = 0x02D2, // Updated 6.28
        SubmarineProgressionStatus = 0x013D, // Updated 6.28
        SubmarineStatusList = 0x0296, // Updated 6.28
        SubmarineExplorationResult = 0x015C, // Updated 6.28

        EventPlay = 0xc9, // Updated for 6.28
        EventPlay4 = 0x321, // Updated for 6.28
        EventPlay8 = 0x9b, // Updated for 6.28
        EventPlay16 = 0x1c2, // Updated for 6.28
        EventPlay32 = 0x28d, // Updated for 6.28
        EventPlay64 = 0x6b, // Updated for 6.28
        EventPlay128 = 0x200, // Updated for 6.28
        EventPlay255 = 0x314, // Updated for 6.28

        EnvironmentControl = 0x193, // Updated for 6.28
        IslandWorkshopSupplyDemand = 0x0147, // Updated 6.28
        Logout = 0x03C2 // Updated 6.28
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x00A8, // Updated 6.28
        ClientTrigger = 0x013E, // Updated 6.28
        ChatHandler = 0x0348, // Updated 6.28
        SetSearchInfoHandler = 0x02AE, // Updated 6.28
        MarketBoardPurchaseHandler = 0x01CD, // Updated 6.28
        InventoryModifyHandler = 0x0353, // Updated 6.28 (Base offset: 0x035A)
        UpdatePositionInstance = 0x00AC, // Updated 6.28

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
