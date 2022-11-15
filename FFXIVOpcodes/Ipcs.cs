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
        PlayerSetup = 0x0091, // Updated 6.28 hotfix
        UpdateHpMpTp = 0x02A2, // Updated 6.28 hotfix
        UpdateClassInfo = 0x02B7, // Updated 6.28 hotfix
        PlayerStats = 0x0086, // Updated 6.28 hotfix
        ActorControl = 0x0197, // Updated 6.28 hotfix
        ActorControlSelf = 0x0238, // Updated 6.28 hotfix
        ActorControlTarget = 0x028B, // Updated 6.28 hotfix
        Playtime = 0x00E5, // Updated 6.28 hotfix
        UpdateSearchInfo = 0x02B6, // Updated 6.28 hotfix
        ExamineSearchInfo = 0x010F, // Updated 6.28 hotfix
        Examine = 0x0141, // Updated 6.28 hotfix
        ActorCast = 0x02AD, // Updated 6.28 hotfix
        CurrencyCrystalInfo = 0x023F, // Updated 6.28 hotfix
        InitZone = 0x00F0, // Updated 6.28 hotfix
        WeatherChange = 0x031B, // Updated 6.28 hotfix
        ActorMove = 0x0384, // Updated 6.28 hotfix
        PlayerSpawn = 0x00DD, // Updated 6.28 hotfix
        ActorSetPos = 0x0329, // Updated 6.28 hotfix
        PrepareZoning = 0x02DB, // Updated 6.28 hotfix
        ContainerInfo = 0x00D9, // Updated 6.28 hotfix
        ItemInfo = 0x03E3, // Updated 6.28 hotfix
        PlaceFieldMarker = 0x01D8, // Updated 6.28 hotfix
        PlaceFieldMarkerPreset = 0x0332, // Updated 6.28 hotfix
        EffectResult = 0x01F0, // Updated 6.28 hotfix
        EventStart = 0x0179, // Updated 6.28 hotfix
        EventFinish = 0x0175, // Updated 6.28 hotfix
        DesynthResult = 0x0111, // Updated 6.28 hotfix
        FreeCompanyInfo = 0x0273, // Updated 6.28 hotfix
        FreeCompanyDialog = 0x03E0, // Updated 6.28 hotfix
        MarketBoardSearchResult = 0x02E1, // Updated 6.28 hotfix
        MarketBoardItemListingCount = 0x03C3, // Updated 6.28 hotfix
        MarketBoardItemListingHistory = 0x036C, // Updated 6.28 hotfix
        MarketBoardItemListing = 0x0270, // Updated 6.28 hotfix
        MarketBoardPurchase = 0x02E0, // Updated 6.28 hotfix
        UpdateInventorySlot = 0x0308, // Updated 6.28 hotfix
        InventoryActionAck = 0x0230, // Updated 6.28 hotfix
        InventoryTransaction = 0x02E2, // Updated 6.28 hotfix
        InventoryTransactionFinish = 0x0109, // Updated 6.28 hotfix
        ResultDialog = 0x028F, // Updated 6.28 hotfix
        RetainerInformation = 0x024F, // Updated 6.28 hotfix
        NpcSpawn = 0x0359, // Updated 6.28 hotfix
        ItemMarketBoardInfo = 0x03DA, // Updated 6.28 hotfix
        ObjectSpawn = 0x0265, // Updated 6.28 hotfix
        EffectResultBasic = 0x1070, // Updated 6.28 hotfix
        Effect = 0x0395, // Updated 6.28 hotfix
        StatusEffectList = 0x019B, // Updated 6.28 hotfix
        ActorGauge = 0x0382, // Updated 6.28 hotfix
        CFNotify = 0x0173, // Updated 6.28 hotfix
        SystemLogMessage = 0x0325, // Updated 6.28 hotfix
        AirshipTimers = 0x02DE, // Updated 6.28 hotfix
        SubmarineTimers = 0x02A3, // Updated 6.28 hotfix
        AirshipStatusList = 0x01F2, // Updated 6.28 hotfix
        AirshipStatus = 0x032A, // Updated 6.28 hotfix
        AirshipExplorationResult = 0x010D, // Updated 6.28 hotfix
        SubmarineProgressionStatus = 0x02C1, // Updated 6.28 hotfix
        SubmarineStatusList = 0x009B, // Updated 6.28 hotfix
        SubmarineExplorationResult = 0x0107, // Updated 6.28 hotfix


        EventPlay = 0x38c, // Updated for 6.28a
        EventPlay4 = 0x274, // Updated for 6.28a
        EventPlay8 = 0x2d9, // Updated for 6.28a
        EventPlay16 = 0x1ab, // Updated for 6.28a
        EventPlay32 = 0x203, // Updated for 6.28a
        EventPlay64 = 0x38d, // Updated for 6.28a
        EventPlay128 = 0x35f, // Updated for 6.28a
        EventPlay255 = 0x11d, // Updated for 6.28a

        EnvironmentControl = 0x10C, // Updated for 6.28 hotfix
        IslandWorkshopSupplyDemand = 0x01FB, // Updated 6.28 hotfix
        Logout = 0x00DF // Updated 6.28 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        // Client Zone
        UpdatePositionHandler = 0x0392, // Updated 6.28 hotfix
        ClientTrigger = 0x0221, // Updated 6.28 hotfix
        ChatHandler = 0x0316, // Updated 6.28 hotfix
        SetSearchInfoHandler = 0x01A7, // Updated 6.28 hotfix
        MarketBoardPurchaseHandler = 0x0336, // Updated 6.28 hotfix
        InventoryModifyHandler = 0x01E1, // Updated 6.28 hotfix (Base offset: 0x01E8)
        UpdatePositionInstance = 0x02F8, // Updated 6.28 hotfix

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
