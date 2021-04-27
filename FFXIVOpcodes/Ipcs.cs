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

        PlayerSetup = 0x034D, // updated 5.5 hotfix
        UpdateHpMpTp = 0x0301, // updated 5.5 hotfix
        PlayerStats = 0x01F6, // updated 5.5 hotfix
        ActorControl = 0x02DB, // updated 5.5 hotfix
        ActorControlSelf = 0x023E, // updated 5.5 hotfix
        ActorControlTarget = 0x0368, // updated 5.5 hotfix
        Playtime = 0x03C2, // updated 5.5 hotfix
        UpdateSearchInfo = 0x0291, // updated 5.5 hotfix
        ExamineSearchInfo = 0x02CD, // updated 5.5 hotfix
        Examine = 0x0252,// updated 5.5 hotfix
        MarketBoardSearchResult = 0x0285,// updated 5.5 hotfix
        MarketBoardItemListingCount = 0x0311,// updated 5.5 hotfix
        MarketBoardItemListingHistory = 0x031D,// updated 5.5 hotfix
        MarketBoardItemListing = 0x024D,// updated 5.5 hotfix
        MarketBoardPurchase = 0x00C0,// updated 5.5 hotfix
        ActorMove = 0x026D,// updated 5.5 hotfix
        ResultDialog = 0x014A,// updated 5.5 hotfix
        RetainerInformation = 0x01CF,// updated 5.5 hotfix
        NpcSpawn = 0x0203,// updated 5.5 hotfix
        PlayerSpawn = 0x036F,// updated 5.5 hotfix
        ContainerInfo = 0x0117,// updated 5.5 hotfix
        ItemInfo = 0x0130,// updated 5.5 hotfix
        UpdateClassInfo = 0x03D3,// updated 5.5 hotfix
        ActorCast = 0x02AD,// updated 5.5 hotfix
        CurrencyCrystalInfo = 0x02F1,// updated 5.5 hotfix
        InitZone = 0x0085,// updated 5.5 hotfix
        EffectResult = 0x0334,// updated 5.5 hotfix
        EventStart = 0x01AF,// updated 5.5 hotfix
        EventFinish = 0x02EE,// updated 5.5 hotfix
        SomeDirectorUnk4 = 0x0352,// updated 5.5 hotfix
        UpdateInventorySlot = 0x0233,// updated 5.5 hotfix
        InventoryActionAck = 0x00AE,// updated 5.5 hotfix
        InventoryTransaction = 0x02C5,// updated 5.5 hotfix
        InventoryTransactionFinish = 0x02EC,// updated 5.5 hotfix
        CFPreferredRole = 0x03BB, // updated 5.5 hotfix
        CFNotify = 0x018F, // updated 5.5 hotfix
        PrepareZoning = 0x0251, // updated 5.5 hotfix
        PlaceFieldMarker = 0x01EA, // updated 5.5 hotfix
        PlaceFieldMarkerPreset = 0x0337, // updated 5.5 hotfix
        ObjectSpawn = 0x0191, // updated 5.5 hotfix
        Effect = 0x03E7, // updated 5.5 hotfix
        StatusEffectList = 0x019A, // updated 5.5 hotfix
        ActorGauge = 0x018D, // updated 5.5 hotfix
        FreeCompanyInfo = 0x01C3, // updated 5.5 hotfix
        FreeCompanyDialog = 0x0212, // updated 5.5 hotfix

        ActorSetPos = 0x01ED, // updated 5.5 hotfix

        DesynthResult = 0x0200, // updated 5.5 hotfix
        EventPlay = 0x32B, // Updated 5.5 hotfix
        EventPlay4 = 0xEE,  // Updated 5.5 hotfix
        EventPlay8 = 0xE4,  // Updated 5.5 hotfix
        EventPlay16 = 0x1CD, // Updated 5.5 hotfix
        EventPlay32 = 0x3B0, // Updated 5.5 hotfix
        EventPlay64 = 0x65,  // Updated 5.5 hotfix
        EventPlay128 = 0x137, // Updated 5.5 hotfix
        EventPlay255 = 0x21A, // Updated 5.5 hotfix

        WeatherChange = 0x023D, // updated 5.5 hotfix

        Logout = 0x03DB, // updated 5.5 hotfix

        //HousingWardInfo = 0x0199, // updated 5.5 hotfix

        AirshipExplorationResult = 0x014D, // updated 5.5 hotfix
        AirshipStatus = 0x01AE, // updated 5.5 hotfix
        AirshipStatusList = 0x00C9, // updated 5.5 hotfix
        AirshipTimers = 0x03D2, // updated 5.5 hotfix
        SubmarineExplorationResult = 0x0082, // updated 5.5 hotfix
        SubmarineProgressionStatus = 0x012B, // updated 5.5 hotfix
        SubmarineStatusList = 0x026C, // updated 5.5 hotfix
        SubmarineTimers = 0x0288, // updated 5.5 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01A8, // updated 5.5 hotfix
        ClientTrigger = 0x00EB, // updated 5.5 hotfix
        ChatHandler = 0x03DE, // updated 5.5 hotfix
        SetSearchInfoHandler = 0x00CF, // updated 5.5 hotfix
        MarketBoardPurchaseHandler = 0x00DF, // updated 5.5 hotfix
        InventoryModifyHandler = 0x016A, // updated 5.5 hotfix  (Base offset: 0x02ED)
        UpdatePositionInstance = 0x026D, // updated 5.5 hotfix

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

        SocialReqSendHandler = 0x00AE, // updated 5.5 hotfix
        //CreateCrossWorldLS = 0x018F, // updated 5.5 hotfix

        SocialListHandler = 0x038F, // updated 5.5 hotfix
        ReqSearchInfoHandler = 0x0209, // updated 5.5 hotfix
        //ReqExamineSearchCommentHandler = 0x02A4, // updated 5.5 hotfix

        //ReqRemovePlayerFromBlacklist = 0x00F4, // updated 5.5 hotfix
        BlackListHandler = 0x0350, // updated 5.5 hotfix
        //PlayerSearchHandler = 0x02EF, // updated 5.5 hotfix

        LinkshellListHandler = 0x02C1, // updated 5.5 hotfix

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
