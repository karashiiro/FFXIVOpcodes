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
        PlayerSetup = 0x0373, // updated 6.3a
        UpdateHpMpTp = 0x010D, // updated 6.3a
        UpdateClassInfo = 0x00BD, // updated 6.3a
        PlayerStats = 0x0272, // updated 6.3a
        ActorControl = 0x0363, // updated 6.3a
        ActorControlSelf = 0x0267, // updated 6.3a
        ActorControlTarget = 0x01EC, // updated 6.3a
        Playtime = 0x0171, // updated 6.3a
        UpdateSearchInfo = 0x0226, // updated 6.3a
        ExamineSearchInfo = 0x033E, // updated 6.3a
        Examine = 0x0121, // updated 6.3a
        ActorCast = 0x0207, // updated 6.3a
        CurrencyCrystalInfo = 0x037B, // updated 6.3a
        InitZone = 0x0094, // updated 6.3a
        WeatherChange = 0x0163, // updated 6.3a
        PlayerSpawn = 0x0187, // updated 6.3a
        ActorSetPos = 0x0186, // updated 6.3a
        PrepareZoning = 0x01D7, // updated 6.3a
        ContainerInfo = 0x03C3, // updated 6.3a
        ItemInfo = 0x0335, // updated 6.3a
        PlaceFieldMarker = 0x0175, // updated 6.3a
        PlaceFieldMarkerPreset = 0x0223, // updated 6.3a
        EffectResult = 0x036C, // updated 6.3a
        EventStart = 0x01C5, // updated 6.3a
        EventFinish = 0x00B6, // updated 6.3a
        DesynthResult = 0x0089, // updated 6.3a
        FreeCompanyInfo = 0x0068, // updated 6.3a
        FreeCompanyDialog = 0x0184, // updated 6.3a
        MarketBoardSearchResult = 0x0233, // updated 6.3a
        MarketBoardItemListingCount = 0x03BF, // updated 6.3a
        MarketBoardItemListingHistory = 0x0296, // updated 6.3a
        MarketBoardItemListing = 0x0155, // updated 6.3a
        MarketBoardPurchase = 0x0312, // updated 6.3a
        UpdateInventorySlot = 0x03E7, // updated 6.3a
        InventoryActionAck = 0x034A, // updated 6.3a
        InventoryTransaction = 0x00D3, // updated 6.3a
        InventoryTransactionFinish = 0x0317, // updated 6.3a
        ResultDialog = 0x02AC, // updated 6.3a
        RetainerInformation = 0x00B0, // updated 6.3a
        NpcSpawn = 0x0391, // updated 6.3a
        ItemMarketBoardInfo = 0x0308, // updated 6.3a
        ObjectSpawn = 0x011A, // updated 6.3a
        EffectResultBasic = 0x02E9, // updated 6.3a
        Effect = 0x03C1, // updated 6.3a
        StatusEffectList = 0x02A4, // updated 6.3a
        ActorGauge = 0x00A9, // updated 6.3a
        CFNotify = 0x03A0, // updated 6.3a
        SystemLogMessage = 0x0174, // updated 6.3a
        AirshipTimers = 0x00AD, // updated 6.3a
        SubmarineTimers = 0x009D, // updated 6.3a
        AirshipStatusList = 0x0234, // updated 6.3a
        AirshipStatus = 0x028B, // updated 6.3a
        AirshipExplorationResult = 0x01E4, // updated 6.3a
        SubmarineProgressionStatus = 0x030C, // updated 6.3a
        SubmarineStatusList = 0x0283, // updated 6.3a
        SubmarineExplorationResult = 0x0154, // updated 6.3a


        EventPlay = 0x01F5, // updated 6.3a
        EventPlay4 = 0x0357, // updated 6.3a
        EventPlay8 = 0x0269, // updated 6.3a
        EventPlay16 = 0x0278, // updated 6.3a
        EventPlay32 = 0x036B, // updated 6.3a
        EventPlay64 = 0x0288, // updated 6.3a
        EventPlay128 = 0x0073, // updated 6.3a
        EventPlay255 = 0x023A, // updated 6.3a

        EnvironmentControl = 0x02D9, // updated 6.3a
        IslandWorkshopSupplyDemand = 0x0080, // updated 6.3a
        Logout = 0x0243, // updated 6.3a
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        // Client Zone
        UpdatePositionHandler = 0x00EE, // updated 6.3a
        ClientTrigger = 0x0165, // updated 6.3a
        ChatHandler = 0x0206, // updated 6.3a
        SetSearchInfoHandler = 0x035C, // updated 6.3a
        MarketBoardPurchaseHandler = 0x018C, // updated 6.3a
        InventoryModifyHandler = 0x01D3, // updated 6.3a (Base offset: 0x01DA)
        UpdatePositionInstance = 0x00E8, // updated 6.3a

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

        //ReqCountdownInitiate = 0x01FF, // updated 6.3a
        //ReqCountdownCancel = 0x0140, // updated 6.3a

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
