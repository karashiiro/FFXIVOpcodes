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
        PlayerSetup = 0x03DD, // updated 6.05
        UpdateHpMpTp = 0x00F4, // updated 6.05
        PlayerStats = 0x018C, // updated 6.05
        ActorControl = 0x02CF, // updated 6.05
        ActorControlSelf = 0x0096, // updated 6.05
        ActorControlTarget = 0x0272, // updated 6.05
        Playtime = 0x039F, // updated 6.05
        UpdateSearchInfo = 0x01E3, // updated 6.05
        ExamineSearchInfo = 0x0222, // updated 6.05
        Examine = 0x02AB, // updated 6.05
        MarketBoardSearchResult = 0x0213, // updated 6.05
        MarketBoardItemListingCount = 0x02A3, // updated 6.05
        MarketBoardItemListingHistory = 0x02DB, // updated 6.05
        MarketBoardItemListing = 0x01F2, // updated 6.05
        MarketBoardPurchase = 0x03DB, // updated 6.05
        ActorMove = 0x00DB, // updated 6.05
        ResultDialog = 0x03D0, // updated 6.05
        RetainerInformation = 0x0318, // updated 6.05
        NpcSpawn = 0x01D2, // updated 6.05
        ItemMarketBoardInfo = 0x029A, // updated 6.05
        PlayerSpawn = 0x0338, // updated 6.05
        ContainerInfo = 0x0130, // updated 6.05
        ItemInfo = 0x0280, // updated 6.05
        UpdateClassInfo = 0x0202, // updated 6.05
        ActorCast = 0x0307, // updated 6.05
        CurrencyCrystalInfo = 0x0126, // updated 6.05
        InitZone = 0x0137, // updated 6.05
        EffectResult = 0x01DF, // updated 6.05
        EventStart = 0x01D6, // updated 6.05
        EventFinish = 0x0206, // updated 6.05
        SomeDirectorUnk4 = 0x027A, // updated 6.05
        UpdateInventorySlot = 0x027E, // updated 6.05
        DesynthResult = 0x0273, // updated 6.05
        InventoryActionAck = 0x02EA, // updated 6.05
        InventoryTransaction = 0x02BC, // updated 6.05
        InventoryTransactionFinish = 0x0269, // updated 6.05
        CFNotify = 0x0183, // updated 6.05
        PrepareZoning = 0x01DD, // updated 6.05
        ActorSetPos = 0x0081, // updated 6.05
        PlaceFieldMarker = 0x00FD, // updated 6.05
        PlaceFieldMarkerPreset = 0x0067, // updated 6.05
        ObjectSpawn = 0x01FD, // updated 6.05
        StatusEffectList = 0x0188, // updated 6.05
        StatusEffectList2 = 0x0293, // updated 6.05
        StatusEffectList3 = 0x0353, // updated 6.05
        ActorGauge = 0x022D, // updated 6.05
        FreeCompanyInfo = 0x013D, // updated 6.05
        FreeCompanyDialog = 0x0261, // updated 6.05
        AirshipTimers = 0x01C7, // updated 6.05
        SubmarineTimers = 0x0211, // updated 6.05
        AirshipStatusList = 0x0182, // updated 6.05
        AirshipStatus = 0x01AD, // updated 6.05
        AirshipExplorationResult = 0x02BB, // updated 6.05
        SubmarineProgressionStatus = 0x0121, // updated 6.05
        SubmarineStatusList = 0x03A9, // updated 6.05
        SubmarineExplorationResult = 0x0128, // updated 6.05

        EffectResultBasic = 0x0330, // updated 6.05

        ActionEffect = 0x033E, // updated 6.05
        ActionEffect8 = 0x01F4, // updated 6.05
        ActionEffect16 = 0x01FA, // updated 6.05
        ActionEffect24 = 0x0300, // updated 6.05
        ActionEffect32 = 0x03CD, // updated 6.05

        EventPlay = 0x13F, // updated 6.05
        EventPlay4 = 0x212, // updated 6.05
        EventPlay8 = 0x10B, // updated 6.05
        EventPlay16 = 0xD0, // updated 6.05
        EventPlay32 = 0xC5, // updated 6.05
        EventPlay64 = 0xC6, // updated 6.05
        EventPlay128 = 0x32C, // updated 6.05
        EventPlay255 = 0x295, // updated 6.05

        WeatherChange = 0x028A, // updated 6.05

        Logout = 0x008A, // updated 6.05
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x021B, // Updated 6.05
        ClientTrigger = 0x00E7, // Updated 6.05
        ChatHandler = 0x0276, // Updated 6.05
        SetSearchInfoHandler = 0x031A, // Updated 6.05
        MarketBoardPurchaseHandler = 0x0387, // Updated 6.05
        InventoryModifyHandler = 0x01B9, // Updated 6.05 (Base offset: 0x01C0)
        UpdatePositionInstance = 0x00A3, // Updated 6.05

        //PingHandler = 0x02C6, // updated 6.05
        //InitHandler = 0x006C, // updated 6.05

        //FinishLoadingHandler = 0x02C9, // updated 6.05

        //CFCommenceHandler = 0x0099, // updated 6.05

        //CFRegisterDuty = 0x0391, // updated 6.05
        //CFRegisterRoulette = 0x00F1, // updated 6.05
        //PlayTimeHandler = 0x00C0, // updated 6.05
        //LogoutHandler = 0x0189, // updated 6.05
        //CancelLogout = 0x00C4, // updated 6.05

        //CFDutyInfoHandler = 0x0099, // updated 6.05

        //SocialReqSendHandler = 0x02C3, // updated 6.05
        //CreateCrossWorldLS = 0x035E, // updated 6.05

        //SocialListHandler = 0x01B3, // updated 6.05
        //ReqSearchInfoHandler = 0x02C5, // updated 6.05
        //ReqExamineSearchCommentHandler = 0x0316, // updated 6.05

        //ReqRemovePlayerFromBlacklist = 0x01E0, // updated 6.05
        //BlackListHandler = 0x0161, // updated 6.05
        //PlayerSearchHandler = 0x02FD, // updated 6.05

        //LinkshellListHandler = 0x023F, // updated 6.05

        //MarketBoardRequestItemListingInfo = 0x00DB, // updated 6.05
        //MarketBoardRequestItemListings = 0x0099, // updated 6.05
        //MarketBoardSearch = 0x02F8, // updated 6.05

        //ReqExamineFcInfo = 0x0152, // updated 6.05

        //FcInfoReqHandler = 0x0231, // updated 6.05

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0389, // updated 6.05

        //ReqJoinNoviceNetwork = 0x01DA, // updated 6.05

        //ReqCountdownInitiate = 0x00F1, // updated 6.05
        //ReqCountdownCancel = 0x00F2, // updated 6.05

        //ZoneLineHandler = 0x01F8, // updated 6.05
        //DiscoveryHandler = 0x02C3, // updated 6.05


        //PlaceFieldMarker = 0x03B9, // updated 6.05
        //PlaceFieldMarkerPreset = 0x0242, // updated 6.05
        //SkillHandler = 0x0259, // updated 6.05
        //GMCommand1 = 0x0089, // updated 6.05
        //GMCommand2 = 0x034C, // updated 6.05
        //AoESkillHandler = 0x020E, // updated 6.05

        //InventoryEquipRecommendedItems = 0x00C6, // updated 6.05

        //ReqPlaceHousingItem = 0x02AF, // updated 6.05
        //BuildPresetHandler = 0x0238, // updated 6.05

        //TalkEventHandler = 0x0309, // updated 6.05
        //EmoteEventHandler = 0x015B, // updated 6.05
        //WithinRangeEventHandler = 0x02F1, // updated 6.05
        //OutOfRangeEventHandler = 0x01A0, // updated 6.05
        //EnterTeriEventHandler = 0x039B, // updated 6.05

        //ReturnEventHandler = 0x02DA, // updated 6.05
        //TradeReturnEventHandler = 0x0219, // updated 6.05

        //LinkshellEventHandler = 0x023A, // updated 6.05
        //LinkshellEventHandler1 = 0x023A, // updated 6.05

        //ReqEquipDisplayFlagsChange = 0x0158, // updated 6.05

        //LandRenameHandler = 0x029D, // updated 6.05
        //HousingUpdateHouseGreeting = 0x02F6, // updated 6.05
        //HousingUpdateObjectPosition = 0x02C4, // updated 6.05

        //SetSharedEstateSettings = 0x015A, // updated 6.05

        //PerformNoteHandler = 0x0175, // updated 6.05
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