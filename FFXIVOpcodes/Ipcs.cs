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
        PlayerSetup = 0x0287, // updated 6.31h
        UpdateHpMpTp = 0x0119, // updated 6.31h
        UpdateClassInfo = 0x02C5, // updated 6.31h
        PlayerStats = 0x02B6, // updated 6.31h
        ActorControl = 0x01A4, // updated 6.31h
        ActorControlSelf = 0x0203, // updated 6.31h
        ActorControlTarget = 0x007E, // updated 6.31h
        Playtime = 0x026C, // updated 6.31h
        UpdateSearchInfo = 0x00C8, // updated 6.31h
        ExamineSearchInfo = 0x0156, // updated 6.31h
        Examine = 0x0246, // updated 6.31h
        ActorCast = 0x0185, // updated 6.31h
        CurrencyCrystalInfo = 0x0385, // updated 6.31h
        InitZone = 0x0118, // updated 6.31h
        WeatherChange = 0x0148, // updated 6.31h
        PlayerSpawn = 0x00F9, // updated 6.31h
        ActorSetPos = 0x0099, // updated 6.31h
        PrepareZoning = 0x027C, // updated 6.31h
        ContainerInfo = 0x0093, // updated 6.31h
        ItemInfo = 0x01C2, // updated 6.31h
        PlaceFieldMarker = 0x03CD, // updated 6.31h
        PlaceFieldMarkerPreset = 0x0180, // updated 6.31h
        EffectResult = 0x0214, // updated 6.31h
        EventStart = 0x0092, // updated 6.31h
        EventFinish = 0x008C, // updated 6.31h
        DesynthResult = 0x016A, // updated 6.31h
        FreeCompanyInfo = 0x029C, // updated 6.31h
        FreeCompanyDialog = 0x0285, // updated 6.31h
        MarketBoardSearchResult = 0x0115, // updated 6.31h
        MarketBoardItemListingCount = 0x031A, // updated 6.31h
        MarketBoardItemListingHistory = 0x0176, // updated 6.31h
        MarketBoardItemListing = 0x01ED, // updated 6.31h
        MarketBoardPurchase = 0x030B, // updated 6.31h
        UpdateInventorySlot = 0x00C2, // updated 6.31h
        InventoryActionAck = 0x00D0, // updated 6.31h
        InventoryTransaction = 0x006E, // updated 6.31h
        InventoryTransactionFinish = 0x0290, // updated 6.31h
        ResultDialog = 0x0394, // updated 6.31h
        RetainerInformation = 0x0139, // updated 6.31h
        NpcSpawn = 0x03D5, // updated 6.31h
        ItemMarketBoardInfo = 0x023F, // updated 6.31h
        ObjectSpawn = 0x0277, // updated 6.31h
        EffectResultBasic = 0x0205, // updated 6.31h
        Effect = 0x0100, // updated 6.31h
        StatusEffectList = 0x0305, // updated 6.31h
        StatusEffectList2 = 0x0197, // updated 6.31h
        StatusEffectList3 = 0x02A7, // updated 6.31h
        ActorGauge = 0x0238, // updated 6.31h
        CFNotify = 0x02A1, // updated 6.31h
        SystemLogMessage = 0x01A6, // updated 6.31h
        AirshipTimers = 0x00DA, // updated 6.31h
        SubmarineTimers = 0x0263, // updated 6.31h
        AirshipStatusList = 0x039D, // updated 6.31h
        AirshipStatus = 0x02F1, // updated 6.31h
        AirshipExplorationResult = 0x03C4, // updated 6.31h
        SubmarineProgressionStatus = 0x025A, // updated 6.31h
        SubmarineStatusList = 0x00AC, // updated 6.31h
        SubmarineExplorationResult = 0x0194, // updated 6.31h

        ActorMove = 0x0155, // updated 6.31h
        ActionEffect8 = 0x02B9, // updated 6.31h
        ActionEffect16 = 0x0390, // updated 6.31h
        ActionEffect24 = 0x022A, // updated 6.31h
        ActionEffect32 = 0x0120, // updated 6.31h

        EventPlay = 0x03B8, // updated 6.31h
        EventPlay4 = 0x01EC, // updated 6.31h
        EventPlay8 = 0x0333, // updated 6.31h
        EventPlay16 = 0x03AE, // updated 6.31h
        EventPlay32 = 0x0160, // updated 6.31h
        EventPlay64 = 0x02F2, // updated 6.31h
        EventPlay128 = 0x008B, // updated 6.31h
        EventPlay255 = 0x010B, // updated 6.31h

        EnvironmentControl = 0x00EF, // updated 6.31h
        IslandWorkshopSupplyDemand = 0x0190, // updated 6.31h
        Logout = 0x0072, // updated 6.31h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01F7, // updated 6.31h
        ClientTrigger = 0x0244, // updated 6.31h
        ChatHandler = 0x00F1, // updated 6.31h
        SetSearchInfoHandler = 0x0368, // updated 6.31h
        MarketBoardPurchaseHandler = 0x02C3, // updated 6.31h
        InventoryModifyHandler = 0x01A2, // updated 6.31h (Base offset: 0x01A9)
        UpdatePositionInstance = 0x03BD, // updated 6.31h

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

        //ReqCountdownInitiate = 0x03E1, // updated 6.31h
        //ReqCountdownCancel = 0x023A, // updated 6.31h

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
