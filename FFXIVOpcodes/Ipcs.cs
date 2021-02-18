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
        PlayerSetup = 0x01E9, // updated 5.45 hotfix
        UpdateHpMpTp = 0x019B, // updated 5.45 hotfix
        PlayerStats = 0x01CC, // updated 5.45 hotfix
        ClientTrigger = 0x0146, // updated 5.45 hotfix
        ActorControl = 0x00C2, // updated 5.45 hotfix
        ActorControlSelf = 0x03D5, // updated 5.45 hotfix
        ActorControlTarget = 0x0171, // updated 5.45 hotfix
        Playtime = 0x0302, // updated 5.45 hotfix
        UpdateSearchInfo = 0x0310, // updated 5.45 hotfix
        ExamineSearchInfo = 0x035F, // updated 5.45 hotfix
        Examine = 0x0261, // updated 5.45 hotfix
        MarketBoardSearchResult = 0x01D6, // updated 5.45 hotfix
        MarketBoardItemListingCount = 0x00C0, // updated 5.45 hotfix
        MarketBoardItemListingHistory = 0x01C3, // updated 5.45 hotfix
        MarketBoardItemListing = 0x016B, // updated 5.45 hotfix
        ActorMove = 0x006B, // updated 5.45 hotfix
        ResultDialog = 0x0296, // updated 5.45 hotfix
        RetainerInformation = 0x026B, // updated 5.45 hotfix
        NpcSpawn = 0x02C9, // updated 5.45 hotfix
        PlayerSpawn = 0x01AB, // updated 5.45 hotfix
        ActorFreeSpawn = 0x0185, // updated 5.45 hotfix
        ItemInfo = 0x0175, // updated 5.45 hotfix
        UpdateClassInfo = 0x0179, // updated 5.45 hotfix
        ActorCast = 0x034C, // updated 5.45 hotfix
        CurrencyCrystalInfo = 0x0363, // updated 5.45 hotfix
        InitZone = 0x0233, // updated 5.45 hotfix
        EffectResult = 0x01D7, // updated 5.45 hotfix
        EventStart = 0x02DE, // updated 5.45 hotfix
        EventFinish = 0x01A3, // updated 5.45 hotfix
        SomeDirectorUnk4 = 0x0071, // updated 5.45 hotfix
        UpdateInventorySlot = 0x017D, // updated 5.45 hotfix
        InventoryActionAck = 0x02FA, // updated 5.45 hotfix
        InventoryTransaction = 0x02EE, // updated 5.45 hotfix
        InventoryTransactionFinish = 0x00BD, // updated 5.45 hotfix
        CFPreferredRole = 0x012E, // updated 5.45 hotfix
        CFNotify = 0x026E, // updated 5.45 hotfix
        UpdatePositionInstance = 0x034E, // updated 5.45 hotfix
        PrepareZoning = 0x01EE, // updated 5.45 hotfix
        ActorSetPos = 0x00C6, // updated 5.45 hotfix
        PlaceFieldMarker = 0x0392, // updated 5.45 hotfix
        PlaceFieldMarkerPreset = 0x01D3, // updated 5.45 hotfix
        ObjectSpawn = 0x0336, // updated 5.45 hotfix
        Effect = 0x027F, // updated 5.45 hotfix
        //AddStatusEffect = 0x01D7, // updated 5.45 hotfix
        StatusEffectList = 0x0243, // updated 5.45 hotfix
        ActorGauge = 0x018E, // updated 5.45 hotfix
        DesynthResult = 0x0323, // updated 5.45 hotfix

        EventPlay = 0x276, // updated 5.45 hotfix
        EventPlay4 = 0x28D, // updated 5.45 hotfix
        EventPlay8 = 0x318, // updated 5.45 hotfix
        EventPlay16 = 0x20D, // updated 5.45 hotfix
        EventPlay32 = 0x3B5, // updated 5.45 hotfix
        EventPlay64 = 0x39E, // updated 5.45 hotfix
        EventPlay128 = 0x2F4, // updated 5.45 hotfix
        EventPlay255 = 0x9D, // updated 5.45 hotfix

        WeatherChange = 0x02A2, // updated 5.45 hotfix

        Logout = 0x12A, // updated 5.45 hotfix

        //HousingWardInfo = 0x015E, // updated 5.45 hotfix

        AirshipExplorationResult = 0x0131, // updated 5.45 hotfix
        AirshipStatus = 0x0253, // updated 5.45 hotfix
        AirshipStatusList = 0x0391, // updated 5.45 hotfix
        AirshipTimers = 0x0206, // updated 5.45 hotfix
        SubmarineExplorationResult = 0x00EB, // updated 5.45 hotfix
        SubmarineProgressionStatus = 0x0333, // updated 5.45 hotfix
        SubmarineStatusList = 0x01F2, // updated 5.45 hotfix
        SubmarineTimers = 0x013B, // updated 5.45 hotfix

        FreeCompanyInfo = 0x03D0, // updated 5.45 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        PingHandler = 0x0183, // updated 5.45 hotfix
        InitHandler = 0x01EA, // updated 5.45 hotfix

        FinishLoadingHandler = 0x023F, // updated 5.45 hotfix

        //CFCommenceHandler = 0x01A0, // updated 5.45 hotfix

        //CFRegisterDuty = 0x0398, // updated 5.45 hotfix
        //CFRegisterRoulette = 0x0288, // updated 5.45 hotfix
        //PlayTimeHandler = 0x018E, // updated 5.45 hotfix
        LogoutHandler = 0x0312, // updated 5.45 hotfix
        //CancelLogout = 0x02B1, // updated 5.45 hotfix

        //CFDutyInfoHandler = 0x01A0, // updated 5.45 hotfix

        SocialReqSendHandler = 0x0288, // updated 5.45 hotfix
        //CreateCrossWorldLS = 0x0174, // updated 5.45 hotfix

        ChatHandler = 0x00A4, // updated 5.45 hotfix

        SocialListHandler = 0x02B0, // updated 5.45 hotfix
        SetSearchInfoHandler = 0x0111, // updated 5.45 hotfix
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

        ZoneLineHandler = 0x00BA, // updated 5.45 hotfix
        ClientTrigger = 0x0124, // updated 5.45 hotfix
        //DiscoveryHandler = 0x0288, // updated 5.45 hotfix


        PlaceFieldMarker = 0x0392, // updated 5.45 hotfix
        PlaceFieldMarkerPreset = 0x01D3, // updated 5.45 hotfix
        SkillHandler = 0x0388, // updated 5.45 hotfix
        GMCommand1 = 0x01E0, // updated 5.45 hotfix
        GMCommand2 = 0x0114, // updated 5.45 hotfix
        //AoESkillHandler = 0x030B, // updated 5.45 hotfix

        
        UpdatePositionHandler = 0x031A, // updated 5.45 hotfix

        InventoryModifyHandler = 0x0110, // updated 5.45 hotfix (Base offset: 0x0117)

        //InventoryEquipRecommendedItems = 0x0398, // updated 5.45 hotfix

        //ReqPlaceHousingItem = 0x01C6, // updated 5.45 hotfix
        //BuildPresetHandler = 0x01D8, // updated 5.45 hotfix

        TalkEventHandler = 0x00C2, // updated 5.45 hotfix
        EmoteEventHandler = 0x03D5, // updated 5.45 hotfix
        WithinRangeEventHandler = 0x0171, // updated 5.45 hotfix
        OutOfRangeEventHandler = 0x019B, // updated 5.45 hotfix
        EnterTeriEventHandler = 0x027F, // updated 5.45 hotfix

        ReturnEventHandler = 0x02AD, // updated 5.45 hotfix
        TradeReturnEventHandler = 0x00A7, // updated 5.45 hotfix

        //LinkshellEventHandler = 0x0221, // updated 5.45 hotfix
        //LinkshellEventHandler1 = 0x0221, // updated 5.45 hotfix

        ReqEquipDisplayFlagsChange = 0x03B0, // updated 5.45 hotfix

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x0136, // updated 5.45 hotfix
        //HousingUpdateObjectPosition = 0x0151, // updated 5.45 hotfix

        //SetSharedEstateSettings = 0x035D, // updated 5.45 hotfix

        UpdatePositionInstance = 0x034E, // updated 5.45 hotfix

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
