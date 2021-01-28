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
        //Ping = 0x38b, // updated 5.41
        //Init = 0xce, // updated 5.41

        //ActorFreeSpawn = 0x00ED, // updated 5.41
        InitZone = 0x0381, // updated 5.41

        EffectResult = 0x011F, // updated 5.41
        ActorControl = 0x0278, // updated 5.41
        ActorControlSelf = 0x03A3, // updated 5.41
        ActorControlTarget = 0x00BA, // updated 5.41

        /*!
         * @brief Used when resting
         */
        UpdateHpMpTp = 0x00ED, // updated 5.41

        ///////////////////////////////////////////////////

        //ChatBanned = 0x006B,
        Playtime = 0x0142, // updated 5.41
        Logout = 0x202, // updated 5.41
        CFNotify = 0x01D2, // updated 5.41
                           //CFMemberStatus = 0x0079,
                           //CFDutyInfo = 0x007A,
                           //CFPlayerInNeed = 0x007F,
                           //CFPreferredRole = 0xd1, // updated 5.41

        //SocialRequestError = 0x00AD,

        //CFRegistered = 0x100, // updated 5.41
        //SocialRequestResponse = 0xbc, // updated 5.41
        //CancelAllianceForming = 0x260, // updated 5.41

        //LogMessage = 0x00D0,

        //Chat = 0x2c2, // updated 5.41

        //WorldVisitList = 0x00FE, // added 4.5

        //SocialList = 0x81, // updated 5.41

        UpdateSearchInfo = 0x0164, // updated 5.41
        ExamineSearchInfo = 0x01D8, // updated 5.41
                                    //InitSearchInfo = 0x2f9, // updated 5.41
                                    //ExamineSearchComment = 0x11b, // updated 5.41

        //ServerNoticeShort = 0x12d, // updated 5.41
        //ServerNotice = 0x20b, // updated 5.41
        //SetOnlineStatus = 0x3c7, // updated 5.41

        //CountdownInitiate = 0x379, // updated 5.41
        //CountdownCancel = 0x1ba, // updated 5.41

        //PlayerAddedToBlacklist = 0x342, // updated 5.41
        //PlayerRemovedFromBlacklist = 0x36e, // updated 5.41
        //BlackList = 0x81, // updated 5.41

        //LinkshellList = 0x116, // updated 5.41

        //MailDeleteRequest = 0x129, // updated 5.41

        // 12D - 137 - constant gap between 4.5x -> 5.0
        //ReqMoogleMailList = 0xa4, // updated 5.41
        //ReqMoogleMailLetter = 0x212, // updated 5.41
        //MailLetterNotification = 0x31e, // updated 5.41

        MarketBoardSearchResult = 0x02E6, // updated 5.41
        MarketBoardItemListingCount = 0x023D, // updated 5.41
        MarketBoardItemListingHistory = 0x031D, // updated 5.41
        MarketBoardItemListing = 0x02B3, // updated 5.41

        ResultDialog = 0x0136, // updated 5.41
        DesynthResult = 0x0262, // updated 5.41

        //CharaFreeCompanyTag = 0x8f, // updated 5.41
        //FreeCompanyBoardMsg = 0x100, // updated 5.41
        //FreeCompanyInfo = 0x91, // updated 5.41
        //ExamineFreeCompanyInfo = 0x292, // updated 5.41

        //FreeCompanyUpdateShortMessage = 0x0157, // added 5.0

        StatusEffectList = 0x014C, // updated 5.41
                                   //EurekaStatusEffectList = 0x21f, // updated 5.41
                                   //BossStatusEffectList = 0x21c, // updated 5.41
                                   //EurekaStatusEffectList = 0x210, // updated 5.41
                                   //BossStatusEffectList= 0x2db, // updated 5.41
        Effect = 0x013F, // updated 5.41
                         //AoeEffect8 = 0xfa, // updated 5.41
                         //AoeEffect16 = 0xf4, // updated 5.41
                         //AoeEffect24 = 0xe8, // updated 5.41
                         //AoeEffect32 = 0x22b, // updated 5.41
                         //PersistantEffect = 0x32d, // updated 5.41

        //GCAffiliation = 0x21c, // updated 5.41

        PlayerSpawn = 0x0283, // updated 5.41
        NpcSpawn = 0x0251, // updated 5.41
                           //NpcSpawn2 = 0x186, // updated 5.41

        ActorMove = 0x031A, // updated 5.41
        ActorSetPos = 0x0159, // updated 5.41

        ActorCast = 0x0244, // updated 5.41
                            //SomeCustomiseChangePacketProbably = 0x00CD, // added 5.18

        //PartyList = 0xae, // updated 5.41
        //HateRank = 0x67, // updated 5.41
        //HateList = 0x149, // updated 5.41
        ObjectSpawn = 0x01EA, // updated 5.41
                              //ObjectDespawn = 0x3b4, // updated 5.41
        UpdateClassInfo = 0x03B3, // updated 5.41
                                  //SilentSetClassJob = 0x3b7, // updated 5.41
        PlayerSetup = 0x03A0, // updated 5.41
        PlayerStats = 0x01AA, // updated 5.41
        //ActorOwner = 0x1dc, // updated 5.41
        //PlayerStateFlags = 0x125, // updated 5.41
        //PlayerClassInfo = 0x2cc, // updated 5.41
        //CharaVisualEffect = 0xc2, // updated 5.41

        //ModelEquip = 0xb3, // updated 5.41
        Examine = 0x021B, // updated 5.41
        //CharaNameReq = 0x242, // updated 5.41

        // nb: see #565 on github
        //UpdateRetainerItemSalePrice = 0x248, // updated 5.41
        //RetainerSaleHistory = 0x1eb, // updated 5.41
        RetainerInformation = 0x02E3, // updated 5.41

        //SetLevelSync = 0x1186, // not updated for 4.4, not sure what it is anymore

        ItemInfo = 0x0360, // updated 5.41
        //ContainerInfo = 0x34f, // updated 5.41
        InventoryTransaction = 0x0387, // updated 5.41
        InventoryTransactionFinish = 0x00CA, // updated 5.41
        CurrencyCrystalInfo = 0x0284, // updated 5.41

        InventoryActionAck = 0x029F, // updated 5.41
        UpdateInventorySlot = 0x02AE, // updated 5.41

        //HuntingLogEntry = 0xc1, // updated 5.41

        EventPlay = 0x346, // Updated for 5.41
        EventPlay4 = 0x274, // Updated for 5.41
        EventPlay8 = 0x138, // Updated for 5.41
        EventPlay16 = 0x3AA, // Updated for 5.41
        EventPlay32 = 0x1E7, // Updated for 5.41
        EventPlay64 = 0x234, // Updated for 5.41
        EventPlay128 = 0xFD,  // Updated for 5.41
        EventPlay255 = 0x2E1, // Updated for 5.41

        EventStart = 0x0135, // updated 5.41
        EventFinish = 0x018E, // updated 5.41

        //EventLinkshell = 0x1169,

        //QuestActiveList = 0x2d3, // updated 5.41
        //QuestUpdate = 0x17f, // updated 5.41
        //QuestCompleteList = 0x352, // updated 5.41

        //QuestFinish = 0x1db, // updated 5.41
        //MSQTrackerComplete = 0x250, // updated 5.41
        //MSQTrackerProgress = 0xF1CD, // updated 4.5 ? this actually looks like the two opcodes have been combined, see #474

        //QuestMessage = 0x111, // updated 5.41

        //QuestTracker = 0x2ae, // updated 5.41

        Mount = 0x260, // updated 5.41

        //DirectorVars = 0x336, // updated 5.41
        //SomeDirectorUnk1 = 0xc4, // updated 5.41
        //SomeDirectorUnk2 = 0xf5, // updated 5.41
        SomeDirectorUnk4 = 0x0112, // updated 5.41
        //SomeDirectorUnk8 = 0x286, // updated 5.41
        //SomeDirectorUnk16 = 0x1f5, // updated 5.41
        //DirectorPopUp = 0x227, // updated 5.41
        //DirectorPopUp4 = 0x235, // updated 5.41
        //DirectorPopUp8 = 0xc7, // updated 5.41

        //CFAvailableContents = 0xF1FD, // updated 4.2

        WeatherChange = 0x027E, // updated 5.41
        //PlayerTitleList = 0x3a0, // updated 5.41
        //Discovery = 0x26a, // updated 5.41

        //EorzeaTimeOffset = 0x21c, // updated 5.41

        //EquipDisplayFlags = 0x1f4, // updated 5.41

        //MiniCactpotInit = 0x0286, // added 5.31

        /// Housing //////////////////////////////////////

        //LandSetInitialize = 0x115, // updated 5.41
        //LandUpdate = 0x14b, // updated 5.41
        //YardObjectSpawn = 0x20c, // updated 5.41
        //HousingIndoorInitialize = 0x36b, // updated 5.41
        //LandPriceUpdate = 0x235, // updated 5.41
        //LandInfoSign = 0x193, // updated 5.41
        //LandRename = 0x198, // updated 5.41
        //HousingEstateGreeting = 0x342, // updated 5.41
        //HousingUpdateLandFlagsSlot = 0x109, // updated 5.41
        //HousingLandFlags = 0x12b, // updated 5.41
        //HousingShowEstateGuestAccess = 0xc2, // updated 5.41

        //HousingObjectInitialize = 0x266, // updated 5.41
        //HousingInternalObjectSpawn = 0x24c, // updated 5.41

        HousingWardInfo = 0x27b, // updated 5.41
                                 //HousingObjectMove = 0x221, // updated 5.41

        //SharedEstateSettingsResponse = 0x390, // updated 5.41

        //LandUpdateHouseName = 0x193, // updated 5.41

        //LandSetMap = 0x3d8, // updated 5.41

        //////////////////////////////////////////////////

        //DuelChallenge = 0x0277, // 4.2; this is responsible for opening the ui
        //PerformNote = 0x27d, // updated 5.41

        PrepareZoning = 0x016A, // updated 5.41
        ActorGauge = 0x007F, // updated 5.41

        // daily quest info -> without them sent,  login will take longer...
        //DailyQuests = 0xec, // updated 5.41
        //DailyQuestRepeatFlags = 0x3c6, // updated 5.41

        /// Doman Mahjong //////////////////////////////////////
        //MahjongOpenGui = 0x02A4, // only available in mahjong instance
        //MahjongNextRound = 0x02BD, // initial hands(baipai), # of riichi(wat), winds, honba, score and stuff
        //MahjongPlayerAction = 0x02BE, // tsumo(as in drawing a tile) called chi/pon/kan/riichi
        //MahjongEndRoundTsumo = 0x02BF, // called tsumo
        //MahjongEndRoundRon = 0x2C0, // called ron or double ron (waiting for action must be flagged from discard packet to call)
        //MahjongTileDiscard = 0x02C1, // giri (discarding a tile.) chi(1)/pon(2)/kan(4)/ron(8) flags etc..
        //MahjongPlayersInfo = 0x02C2, // actor id, name, rating and stuff..
        // 2C3 and 2C4 are currently unknown
        //MahjongEndRoundDraw = 0x02C5, // self explanatory
        //MahjongEndGame = 0x02C6, // finished oorasu(all-last) round; shows a result screen.

        AirshipExplorationResult = 0x0320, // updated 5.41
        AirshipStatus = 0x007D, // added 5.41
        AirshipStatusList = 0x035C, // updated 5.41
        AirshipTimers = 0x01D6, // added 5.41
        SubmarineExplorationResult = 0x02BB, // updated 5.41
        SubmarineProgressionStatus = 0x03B4, // added 5.41
        SubmarineStatusList = 0x02F0, // updated 5.41
        SubmarineTimers = 0x03DA, // added 5.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        //PingHandler = 0x38b, // updated 5.41
        //InitHandler = 0xce, // updated 5.41

        //FinishLoadingHandler = 0x7e, // updated 5.41

        //CFCommenceHandler = 0x18a, // updated 5.41

        //CFRegisterDuty = 0x80, // updated 5.41
        //CFRegisterRoulette = 0x2fb, // updated 5.41
        //PlayTimeHandler = 0x110, // updated 5.41
        //LogoutHandler = 0x8c, // updated 5.41
        //CancelLogout = 0x1c2, // updated 5.41

        //CFDutyInfoHandler = 0x18a, // updated 5.41

        //SocialReqSendHandler = 0x82, // updated 5.41
        //CreateCrossWorldLS = 0x8e, // updated 5.41

        ChatHandler = 0x011B, // updated 5.41

        //SocialListHandler = 0x17f, // updated 5.41
        SetSearchInfoHandler = 0x00B2, // updated 5.41
        //ReqSearchInfoHandler = 0x17f, // updated 5.41
        //ReqExamineSearchCommentHandler = 0x273, // updated 5.41

        //ReqRemovePlayerFromBlacklist = 0xad, // updated 5.41
        //BlackListHandler = 0x26d, // updated 5.41
        //PlayerSearchHandler = 0x144, // updated 5.41

        //LinkshellListHandler = 0x20d, // updated 5.41

        //MarketBoardRequestItemListingInfo = 0x11b, // updated 5.41
        //MarketBoardRequestItemListings = 0x18a, // updated 5.41
        //MarketBoardSearch = 0x11f, // updated 5.41

        //ReqExamineFcInfo = 0x1c8, // updated 5.41

        //FcInfoReqHandler = 0x10f, // updated 5.41

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x2b0, // updated 5.41

        //ReqJoinNoviceNetwork = 0x22f, // updated 5.41

        //ReqCountdownInitiate = 0x131, // updated 5.41
        //ReqCountdownCancel = 0x8f, // updated 5.41

        //ZoneLineHandler = 0x235, // updated 5.41
        ClientTrigger = 0x0065, // updated 5.41
                                //DiscoveryHandler = 0x10b, // updated 5.41

        PlaceFieldMarker = 0x01C4, // updated 5.41
        PlaceFieldMarkerPreset = 0x0245, // updated 5.41
        //SkillHandler = 0x1fb, // updated 5.41
        //GMCommand1 = 0x26f, // updated 5.41
        //GMCommand2 = 0x115, // updated 5.41
        //AoESkillHandler = 0x2ea, // updated 5.41

        UpdatePositionHandler = 0x0109, // updated 5.41

        InventoryModifyHandler = 0x0191, // updated 5.41 (Base offset: 0x0198)

        //InventoryEquipRecommendedItems = 0x1dc, // updated 5.41

        //ReqPlaceHousingItem = 0x1ce, // updated 5.41
        //BuildPresetHandler = 0x161, // updated 5.41

        //TalkEventHandler = 0x270, // updated 5.41
        //EmoteEventHandler = 0x306, // updated 5.41
        //WithinRangeEventHandler = 0x31a, // updated 5.41
        //OutOfRangeEventHandler = 0x1cb, // updated 5.41
        //EnterTeriEventHandler = 0xc7, // updated 5.41

        //ReturnEventHandler = 0xbc, // updated 5.41
        //TradeReturnEventHandler = 0x1f6, // updated 5.41

        //LinkshellEventHandler = 0x90, // updated 5.41
        //LinkshellEventHandler1 = 0x90, // updated 5.41

        //ReqEquipDisplayFlagsChange = 0x71, // updated 5.41

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x12b, // updated 5.41
        //HousingUpdateObjectPosition = 0x349, // updated 5.41

        //SetSharedEstateSettings = 0x178, // updated 5.41

        UpdatePositionInstance = 0x02D9, // updated 5.41

        //PerformNoteHandler = 0x308, // updated 5.41
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
