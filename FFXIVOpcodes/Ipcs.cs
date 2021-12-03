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
        PlayerSetup = 0x008B, // updated 6.0
        UpdateHpMpTp = 0x0296,// updated 6.0
        PlayerStats = 0x038D,// updated 6.0
        ActorControl = 0x017E,// updated 6.0
        ActorControlSelf = 0x02E6,// updated 6.0
        ActorControlTarget = 0x0168,// updated 6.0
        Playtime = 0x03C3,// updated 6.0
        Examine = 0x011B,// updated 6.0
        MarketBoardSearchResult = 0x0201,// updated 6.0
        MarketBoardItemListingCount = 0x023C,// updated 6.0
        MarketBoardItemListingHistory = 0x0192,// updated 6.0
        MarketBoardItemListing = 0x0323,// updated 6.0
        MarketBoardPurchase = 0x009D,// updated 6.0
        ActorMove = 0x0235,// updated 6.0
        ResultDialog = 0x00AF,// updated 6.0
        RetainerInformation = 0x0129,// updated 6.0
        NpcSpawn = 0x032E,// updated 6.0
        ItemMarketBoardInfo = 0x008A,// updated 6.0
        PlayerSpawn = 0x0133,// updated 6.0
        ContainerInfo = 0x00EE,// updated 6.0
        ItemInfo = 0x0173,// updated 6.0
        UpdateClassInfo = 0x03A5,// updated 6.0
        ActorCast = 0x0108,// updated 6.0
        CurrencyCrystalInfo = 0x0258,// updated 6.0
        InitZone = 0x02C4,// updated 6.0
        EffectResult = 0x0196,// updated 6.0
        EventStart = 0x0334,// updated 6.0
        EventFinish = 0x01B8,// updated 6.0
        SomeDirectorUnk4 = 0x0164,// updated 6.0
        UpdateInventorySlot = 0x02B6,// updated 6.0
        DesynthResult = 0x02D5,// updated 6.0
        InventoryActionAck = 0x00FC,// updated 6.0
        InventoryTransaction = 0x008F,// updated 6.0
        InventoryTransactionFinish = 0x039B,// updated 6.0
        CFNotify = 0x0317,// updated 6.0
        PrepareZoning = 0x0090,// updated 6.0
        ActorSetPos = 0x0199,// updated 6.0
        PlaceFieldMarker = 0x037D,// updated 6.0
        PlaceFieldMarkerPreset = 0x01CF,// updated 6.0
        ObjectSpawn = 0x0319,// updated 6.0
        Effect = 0x035A,// updated 6.0
        StatusEffectList = 0x02C5,// updated 6.0
        ActorGauge = 0x0283,// updated 6.0
        FreeCompanyInfo = 0x031C,// updated 6.0
        FreeCompanyDialog = 0x036E,// updated 6.0
        AirshipTimers = 0x00ED,// updated 6.0
        SubmarineTimers = 0x00F5,// updated 6.0
        AirshipStatusList = 0x023F,// updated 6.0
        AirshipStatus = 0x01E3,// updated 6.0
        AirshipExplorationResult = 0x00B4,// updated 6.0
        SubmarineProgressionStatus = 0x030B,// updated 6.0
        SubmarineStatusList = 0x02F4,// updated 6.0
        SubmarineExplorationResult = 0x0183,// updated 6.0

        EventPlay = 0x00A5, // Updated 6.0
        EventPlay4 = 0x022E, // Updated 6.0
        EventPlay8 = 0x18B, // Updated 6.0
        EventPlay16 = 0x1F4, // Updated 6.0
        EventPlay32 = 0x65, // Updated 6.0
        EventPlay64 = 0x3A8, // Updated 6.0
        EventPlay128 = 0x16E, // Updated 6.0
        EventPlay255 = 0x366, // Updated 6.0

        WeatherChange = 0x01FD, // Updated 6.0

        Logout = 0x02EC, // updated 6.0 hotfix

        //HousingWardInfo = 0x012A, // updated 5.58 hotfix
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0346,// updated 6.0
        ClientTrigger = 0x03AC,// updated 6.0
        ChatHandler = 0x01CC,// updated 6.0
        SetSearchInfoHandler = 0x03B1,// updated 6.0
        MarketBoardPurchaseHandler = 0x00DC,// updated 6.0
        InventoryModifyHandler = 0x00A3,// updated 6.0 (Base offset: 0x00AA)
        UpdatePositionInstance = 0x0163,// updated 6.0

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
