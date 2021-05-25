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

        PlayerSetup = 0x03A3, // updated 5.55
        UpdateHpMpTp = 0x01E8, // updated 5.55
        PlayerStats = 0x00B3, // updated 5.55
        ActorControl = 0x030F, // updated 5.55
        ActorControlSelf = 0x0200, // updated 5.55
        ActorControlTarget = 0x0387, // updated 5.55
        Playtime = 0x03E2, // updated 5.55
        UpdateSearchInfo = 0x0296, // updated 5.55
        ExamineSearchInfo = 0x0116, // updated 5.55
        Examine = 0x0278, // updated 5.55
        MarketBoardSearchResult = 0x00AD, // updated 5.55
        MarketBoardItemListingCount = 0x03E6, // updated 5.55
        MarketBoardItemListingHistory = 0x02F9, // updated 5.55
        MarketBoardItemListing = 0x02E5, // updated 5.55
        MarketBoardPurchase = 0x0350, // updated 5.55
        ActorMove = 0x0122, // updated 5.55
        ResultDialog = 0x00B6, // updated 5.55
        RetainerInformation = 0x01C6, // updated 5.55
        NpcSpawn = 0x00E0, // updated 5.55
        PlayerSpawn = 0x008B, // updated 5.55
        ActorFreeSpawn = 0x0233, // updated 5.55
        ContainerInfo = 0x0068, // updated 5.55
        ItemInfo = 0x00E6, // updated 5.55
        UpdateClassInfo = 0x013E, // updated 5.55
        ActorCast = 0x0228, // updated 5.55
        CurrencyCrystalInfo = 0x00F7, // updated 5.55
        InitZone = 0x02D1, // updated 5.55
        EffectResult = 0x0093, // updated 5.55
        EventStart = 0x01FC, // updated 5.55
        EventFinish = 0x0067, // updated 5.55
        SomeDirectorUnk4 = 0x0139, // updated 5.55
        DesynthResult = 0x01AE, // updated 5.55
        UpdateInventorySlot = 0x034B, // updated 5.55
        InventoryActionAck = 0x007A, // updated 5.55
        InventoryTransaction = 0x00A2, // updated 5.55
        InventoryTransactionFinish = 0x03AE, // updated 5.55
        CFPreferredRole = 0x01C2, // updated 5.55
        CFNotify = 0x039A, // updated 5.55
        PrepareZoning = 0x021B, // updated 5.55
        ActorSetPos = 0x0271, // updated 5.55
        PlaceFieldMarker = 0x02FE, // updated 5.55
        PlaceFieldMarkerPreset = 0x00E4, // updated 5.55
        ObjectSpawn = 0x0207, // updated 5.55
        Effect = 0x0128, // updated 5.55
        StatusEffectList = 0x0117, // updated 5.55
        ActorGauge = 0x0138, // updated 5.55
        FreeCompanyInfo = 0x0066, // updated 5.55
        FreeCompanyDialog = 0x013D, // updated 5.55

        EventPlay = 0x183, // updated 5.55
        EventPlay4 = 0x38B, // updated 5.55
        EventPlay8 = 0x32D, // updated 5.55
        EventPlay16 = 0x346, // updated 5.55
        EventPlay32 = 0x3A0, // updated 5.55
        EventPlay64 = 0x18D, // updated 5.55
        EventPlay128 = 0x290, // updated 5.55
        EventPlay255 = 0x29C, // updated 5.55

        //WeatherChange = 0x023D, // updated 5.5 hotfix

        Logout = 0x01F9, // updated 5.55

        //HousingWardInfo = 0x0199, // updated 5.5 hotfix

        AirshipExplorationResult = 0x00C8, // updated 5.55
        AirshipStatus = 0x0309, // updated 5.55
        AirshipStatusList = 0x020F, // updated 5.55
        AirshipTimers = 0x014D, // updated 5.55
        SubmarineExplorationResult = 0x0368, // updated 5.55
        SubmarineProgressionStatus = 0x0242, // updated 5.55
        SubmarineStatusList = 0x028B, // updated 5.55
        SubmarineTimers = 0x02B0, // updated 5.55
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0113, // updated 5.55
        ClientTrigger = 0x02CC, // updated 5.55
        ChatHandler = 0x0245, // updated 5.55
        SetSearchInfoHandler = 0x0089, // updated 5.55
        MarketBoardPurchaseHandler = 0x03A4, // updated 5.55
        InventoryModifyHandler = 0x0214, // updated 5.55 (Base offset: 0x021B)
        UpdatePositionInstance = 0x0122, // updated 5.55

        //PingHandler = 0x015E, // updated 5.5 hotfix
        //InitHandler = 0x01D3, // updated 5.5 hotfix

        //FinishLoadingHandler = 0x01AB, // updated 5.5 hotfix

        //CFCommenceHandler = 0x00EB, // updated 5.5 hotfix

        //CFRegisterDuty = 0x0341, // updated 5.5 hotfix
        //CFRegisterRoulette = 0x0097, // updated 5.5 hotfix
        //PlayTimeHandler = 0x031B, // updated 5.5 hotfix
        //LogoutHandler = 0x030D, // updated 5.5 hotfix
        //CancelLogout = 0x022F, // updated 5.5 hotfix

        //CFDutyInfoHandler = 0x00EB, // updated 5.5 hotfix

        //SocialReqSendHandler = 0x00AE, // updated 5.5 hotfix
        //CreateCrossWorldLS = 0x018F, // updated 5.5 hotfix

        //SocialListHandler = 0x038F, // updated 5.5 hotfix
        //ReqSearchInfoHandler = 0x0209, // updated 5.5 hotfix
        //ReqExamineSearchCommentHandler = 0x02A4, // updated 5.5 hotfix

        //ReqRemovePlayerFromBlacklist = 0x00F4, // updated 5.5 hotfix
        //BlackListHandler = 0x0350, // updated 5.5 hotfix
        //PlayerSearchHandler = 0x02EF, // updated 5.5 hotfix

        //LinkshellListHandler = 0x02C1, // updated 5.5 hotfix

        //MarketBoardRequestItemListingInfo = 0x00C3, // updated 5.5 hotfix
        //MarketBoardRequestItemListings = 0x00EB, // updated 5.5 hotfix
        //MarketBoardSearch = 0x02B2, // updated 5.5 hotfix

        //ReqExamineFcInfo = 0x0259, // updated 5.5 hotfix

        //FcInfoReqHandler = 0x00B9, // updated 5.5 hotfix

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0247, // updated 5.5 hotfix

        //ReqJoinNoviceNetwork = 0x03B5, // updated 5.5 hotfix

        //ReqCountdownInitiate = 0x0097, // updated 5.5 hotfix
        //ReqCountdownCancel = 0x0164, // updated 5.5 hotfix

        //ZoneLineHandler = 0x02E4, // updated 5.5 hotfix
        //DiscoveryHandler = 0x00AE, // updated 5.5 hotfix


        //PlaceFieldMarker = 0x0390, // updated 5.5 hotfix
        //PlaceFieldMarkerPreset = 0x0140, // updated 5.5 hotfix
        //SkillHandler = 0x0129, // updated 5.5 hotfix
        //GMCommand1 = 0x01CE, // updated 5.5 hotfix
        //GMCommand2 = 0x0371, // updated 5.5 hotfix
        //AoESkillHandler = 0x037A, // updated 5.5 hotfix

        //InventoryEquipRecommendedItems = 0x00F3, // updated 5.5 hotfix

        //ReqPlaceHousingItem = 0x0367, // updated 5.5 hotfix
        //BuildPresetHandler = 0x01C6, // updated 5.5 hotfix

        //TalkEventHandler = 0x0322, // updated 5.5 hotfix
        //EmoteEventHandler = 0x03BD, // updated 5.5 hotfix
        //WithinRangeEventHandler = 0x014F, // updated 5.5 hotfix
        //OutOfRangeEventHandler = 0x02DA, // updated 5.5 hotfix
        //EnterTeriEventHandler = 0x02B0, // updated 5.5 hotfix

        //ReturnEventHandler = 0x02A7, // updated 5.5 hotfix
        //TradeReturnEventHandler = 0x0197, // updated 5.5 hotfix

        //LinkshellEventHandler = 0x021E, // updated 5.5 hotfix
        //LinkshellEventHandler1 = 0x021E, // updated 5.5 hotfix

        //ReqEquipDisplayFlagsChange = 0x00D0, // updated 5.5 hotfix

        //LandRenameHandler = 0x0165, // updated 5.5 hotfix
        //HousingUpdateHouseGreeting = 0x0372, // updated 5.5 hotfix
        //HousingUpdateObjectPosition = 0x02A6, // updated 5.5 hotfix

        //SetSharedEstateSettings = 0x0189, // updated 5.5 hotfix

        //PerformNoteHandler = 0x0339, // updated 5.5 hotfix
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
