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
        PlayerSetup = 0x0342, // Updated 6.2 hotfix
        UpdateHpMpTp = 0x0102, // Updated 6.2 hotfix
        UpdateClassInfo = 0x00C7, // Updated 6.2 hotfix
        PlayerStats = 0x026B, // Updated 6.2 hotfix
        ActorControl = 0x02A7, // Updated 6.2 hotfix
        ActorControlSelf = 0x023C, // Updated 6.2 hotfix
        ActorControlTarget = 0x0118, // Updated 6.2 hotfix
        Playtime = 0x0122, // Updated 6.2 hotfix
        UpdateSearchInfo = 0x0171, // Updated 6.2 hotfix
        ExamineSearchInfo = 0x01CF, // Updated 6.2 hotfix
        Examine = 0x03E0, // Updated 6.2 hotfix
        ActorCast = 0x026C, // Updated 6.2 hotfix
        CurrencyCrystalInfo = 0x018A, // Updated 6.2 hotfix
        InitZone = 0x00E1, // Updated 6.2 hotfix
        PlayerSpawn = 0x0334, // Updated 6.2 hotfix
        ActorSetPos = 0x01BA, // Updated 6.2 hotfix
        PrepareZoning = 0x00A0, // Updated 6.2 hotfix
        ContainerInfo = 0x02D9, // Updated 6.2 hotfix
        ItemInfo = 0x02ED, // Updated 6.2 hotfix
        PlaceFieldMarker = 0x039A, // Updated 6.2 hotfix
        PlaceFieldMarkerPreset = 0x01F4, // Updated 6.2 hotfix
        EffectResult = 0x0263, // Updated 6.2 hotfix
        EventStart = 0x0181, // Updated 6.2 hotfix
        EventFinish = 0x03BC, // Updated 6.2 hotfix
        DesynthResult = 0x02AA, // Updated 6.2 hotfix
        FreeCompanyInfo = 0x00BF, // Updated 6.2 hotfix
        FreeCompanyDialog = 0x0392, // Updated 6.2 hotfix
        MarketBoardSearchResult = 0x02A2, // Updated 6.2 hotfix
        MarketBoardItemListingCount = 0x02A1, // Updated 6.2 hotfix
        MarketBoardItemListingHistory = 0x0194, // Updated 6.2 hotfix
        MarketBoardItemListing = 0x0201, // Updated 6.2 hotfix
        MarketBoardPurchase = 0x015E, // Updated 6.2 hotfix
        UpdateInventorySlot = 0x01FB, // Updated 6.2 hotfix
        InventoryActionAck = 0x02C8, // Updated 6.2 hotfix
        InventoryTransaction = 0x017D, // Updated 6.2 hotfix
        InventoryTransactionFinish = 0x00B0, // Updated 6.2 hotfix
        ResultDialog = 0x02D2, // Updated 6.2 hotfix
        RetainerInformation = 0x01D9, // Updated 6.2 hotfix
        NpcSpawn = 0x019B, // Updated 6.2 hotfix
        ItemMarketBoardInfo = 0x00E8, // Updated 6.2 hotfix
        ObjectSpawn = 0x02F7, // Updated 6.2 hotfix
        EffectResultBasic = 0x1070, // Updated 6.2 hotfix
        Effect = 0x0094, // Updated 6.2 hotfix
        StatusEffectList = 0x0265, // Updated 6.2 hotfix
        ActorGauge = 0x02AB, // Updated 6.2 hotfix
        CFNotify = 0x018C, // Updated 6.2 hotfix
        SystemLogMessage = 0x01DB, // Updated 6.2 hotfix
        AirshipTimers = 0x00EF, // Updated 6.2 hotfix
        SubmarineTimers = 0x031B, // Updated 6.2 hotfix
        AirshipStatusList = 0x036B, // Updated 6.2 hotfix
        AirshipStatus = 0x0168, // Updated 6.2 hotfix
        AirshipExplorationResult = 0x02C3, // Updated 6.2 hotfix
        SubmarineProgressionStatus = 0x037E, // Updated 6.2 hotfix
        SubmarineStatusList = 0x030D, // Updated 6.2 hotfix
        SubmarineExplorationResult = 0x00D1, // Updated 6.2 hotfix


        EventPlay = 0x2fd, // Updated for 6.2 Hotfix
        EventPlay4 = 0x380, // Updated for 6.2 Hotfix
        EventPlay8 = 0x107, // Updated for 6.2 Hotfix
        EventPlay16 = 0x2a4, // Updated for 6.2 Hotfix
        EventPlay32 = 0xc1, // Updated for 6.2 Hotfix
        EventPlay64 = 0x2fb, // Updated for 6.2 Hotfix
        EventPlay128 = 0x129, // Updated for 6.2 Hotfix
        EventPlay255 = 0x2cd, // Updated for 6.2 Hotfix
        EnvironmentControl = 0x24A, // Updated for 6.2 Hotfix
        Logout = 0x0230 // Updated 6.2 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x009C, // Updated 6.2 hotfix
        ClientTrigger = 0x03D8, // Updated 6.2 hotfix
        ChatHandler = 0x0069, // Updated 6.2 hotfix
        SetSearchInfoHandler = 0x02D7, // Updated 6.2 hotfix
        MarketBoardPurchaseHandler = 0x01BD, // Updated 6.2 hotfix
        InventoryModifyHandler = 0x019D, // Updated 6.2 hotfix (Base offset: 0x01A4)
        UpdatePositionInstance = 0x0124, // Updated 6.2 hotfix

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
