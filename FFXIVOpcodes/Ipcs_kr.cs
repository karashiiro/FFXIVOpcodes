namespace FFXIVOpcodes.KR
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
        ActorCast = 0x02EB, // 7.2
        ActorControl = 0x0258, // 7.2
        ActorControlSelf = 0x01F3, // 7.2
        ActorControlTarget = 0x0319, // 7.2
        ActorGauge = 0x0272, // 7.2
        ActorMove = 0x0133, // 7.2
        ActorSetPos = 0x006C, // 7.2
        AirshipExplorationResult = 0x01E8, // 7.2
        AirshipStatus = 0x0341, // 7.2
        AirshipStatusList = 0x02F9, // 7.2
        AirshipTimers = 0x0225, // 7.2
        AoeEffect16 = 0x0394, // 7.2
        AoeEffect24 = 0x00F3, // 7.2
        AoeEffect32 = 0x032F, // 7.2
        AoeEffect8 = 0x0185, // 7.2
        ApplyIDScramble = 0x00BB, // 7.2
        CEDirector = 0x00E7, // 7.2
        CFDutyInfo = 0x0203, // 7.2
        CFNotify = 0x0195, // 7.2
        CFPreferredRole = 0x0223, // 7.2
        CFRegistered = 0x009A, // 7.2
        ContainerInfo = 0x0295, // 7.2
        Countdown = 0x037D, // 7.2
        CountdownCancel = 0x02BA, // 7.2
        CurrencyCrystalInfo = 0x0211, // 7.2
        DespawnCharacter = 0x01EB, // 7.2
        DesynthResult = 0x0322, // 7.2
        Effect = 0x00CC, // 7.2
        EffectResult = 0x01F1, // 7.2
        EffectResult16 = 0x026C, // 7.2
        EffectResult4 = 0x0130, // 7.2
        EffectResult8 = 0x0321, // 7.2
        EffectResultBasic = 0x00AE, // 7.2
        EffectResultBasic16 = 0x00DA, // 7.2
        EffectResultBasic32 = 0x03DC, // 7.2
        EffectResultBasic4 = 0x01FC, // 7.2
        EffectResultBasic64 = 0x0220, // 7.2
        EffectResultBasic8 = 0x02C6, // 7.2
        EnvironmentControl = 0x03BC, // 7.2
        EnvironmentControl12 = 0x02E1, // 7.2
        EnvironmentControl4 = 0x0096, // 7.2
        EnvironmentControl8 = 0x027B, // 7.2
        EventFinish = 0x028E, // 7.2
        EventPlay = 0x0384, // 7.2
        EventPlay128 = 0x01B8, // 7.2
        EventPlay16 = 0x0144, // 7.2
        EventPlay255 = 0x0328, // 7.2
        EventPlay32 = 0x0079, // 7.2
        EventPlay4 = 0x014E, // 7.2
        EventPlay64 = 0x03D9, // 7.2
        EventPlay8 = 0x0292, // 7.2
        EventStart = 0x02A8, // 7.2
        Examine = 0x0080, // 7.2
        ExamineSearchInfo = 0x00EF, // 7.2
        FellowshipList = 0x0259, // 7.2
        FirstAttack = 0x02E4, // 7.2
        FreeCompanyDialog = 0x02DA, // 7.2
        FreeCompanyInfo = 0x0359, // 7.2
        HousingWardInfo = 0x03B4, // 7.2
        Init = 0x0217, // 7.2
        InitSearchInfo = 0x0085, // 7.2
        InitZone = 0x03CE, // 7.2
        InventoryActionAck = 0x025A, // 7.2
        InventoryTransaction = 0x00B0, // 7.2
        InventoryTransactionFinish = 0x033C, // 7.2
        IslandWorkshopDemandResearch = 0x0120, // 7.2
        IslandWorkshopFavors = 0x01DD, // 7.2
        IslandWorkshopSupplyDemand = 0x0390, // 7.2
        ItemInfo = 0x024E, // 7.2
        ItemMarketBoardInfo = 0x01E4, // 7.2
        ItemMarketBoardSummary = 0x0387, // 7.2
        LogMessage = 0x00BC, // 7.2
        Logout = 0x008F, // 7.2
        MarketBoardItemListing = 0x0316, // 7.2
        MarketBoardItemListingCount = 0x034F, // 7.2
        MarketBoardItemListingHistory = 0x00C9, // 7.2
        MarketBoardPurchase = 0x00BE, // 7.2
        MarketBoardSale = 0x0287, // 7.2
        MarketBoardSearchResult = 0x01CA, // 7.2
        MiniCactpotInit = 0x0293, // 7.2
        ModelEquip = 0x0149, // 7.2
        Mount = 0x0181, // 7.2
        NpcSpawn = 0x01A7, // 7.2
        NpcSpawn2 = 0x00CF, // 7.2
        ObjectDespawn = 0x006F, // 7.2
        ObjectSpawn = 0x006A, // 7.2
        Ping = 0x0251, // 7.2
        PlaceFieldMarker = 0x031A, // 7.2
        PlaceFieldMarkerPreset = 0x01DA, // 7.2
        PlayerBlueMageActions = 0x02BC, // 7.2
        PlayerClassInfo = 0x01D4, // 7.2
        PlayerRetainerInfo = 0x02B9, // 7.2
        PlayerSetup = 0x0103, // 7.2
        PlayerSpawn = 0x01BC, // 7.2
        PlayerStateFlags = 0x02D3, // 7.2
        PlayerStats = 0x030E, // 7.2
        PlayerUpdateLook = 0x019F, // 7.2
        Playtime = 0x0294, // 7.2
        PrepareZoning = 0x030A, // 7.2
        ResultDialog = 0x021E, // 7.2
        RetainerInformation = 0x02CD, // 7.2
        RetainerSaleHistory = 0x0160, // 7.2
        RetainerState = 0x00EC, // 7.2
        RetainerSummary = 0x00DD, // 7.2
        RSFData = 0x01E9, // 7.2
        RSVData = 0x0304, // 7.2
        ServerNotice = 0x0281, // 7.2
        ServerNoticeShort = 0x0082, // 7.2
        SetOnlineStatus = 0x0240, // 7.2
        SocialList = 0x031D, // 7.2
        SocialMessage = 0x00AD, // 7.2
        SocialMessage2 = 0x03DE, // 7.2
        SocialRequestResponse = 0x02F4, // 7.2
        StatusEffectList = 0x0128, // 7.2
        StatusEffectListBozja = 0x0069, // 7.2
        StatusEffectListDouble = 0x01A9, // 7.2
        StatusEffectListEureka = 0x03D5, // 7.2
        StatusEffectListForay3 = 0x00D9, // 7.2
        StatusEffectListPlayer = 0x01B2, // 7.2
        StatusEffectListPlayerDouble = 0x01FE, // 7.2
        SubmarineExplorationResult = 0x0303, // 7.2
        SubmarineProgressionStatus = 0x02FF, // 7.2
        SubmarineStatusList = 0x01D0, // 7.2
        SubmarineTimers = 0x0108, // 7.2
        SystemLogMessage = 0x01F7, // 7.2
        SystemLogMessage144 = 0x0250, // 7.2
        SystemLogMessage32 = 0x00A8, // 7.2
        SystemLogMessage48 = 0x03DB, // 7.2
        SystemLogMessage80 = 0x03AF, // 7.2
        UpdateAllianceNormal = 0x0072, // 7.2
        UpdateAllianceNormalMemberPositions = 0x0355, // 7.2
        UpdateAllianceSmall = 0x01F5, // 7.2
        UpdateAllianceSmallMemberPositions = 0x02BB, // 7.2
        UpdateClassInfo = 0x0308, // 7.2
        UpdateClassInfoBozja = 0x01D2, // 7.2
        UpdateClassInfoEureka = 0x02C1, // 7.2
        UpdateClassInfoForay3 = 0x00A6, // 7.2
        UpdateDutyRecastTimes = 0x038C, // 7.2
        UpdateDutyRecastTimes5 = 0x02E7, // 7.2
        UpdateHate = 0x0312, // 7.2
        UpdateHater = 0x0296, // 7.2
        UpdateHpMpTp = 0x02B0, // 7.2
        UpdateInventorySlot = 0x01B6, // 7.2
        UpdateParty = 0x0228, // 7.2
        UpdatePartyMemberPositions = 0x0368, // 7.2
        UpdateRecastTimes = 0x0261, // 7.2
        UpdateSearchInfo = 0x023F, // 7.2
        WeatherChange = 0x029D, // 7.2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x01C6, // 7.2
        ActionRequestGroundTargeted = 0x037B, // 7.2
        ChatHandler = 0x0148, // 7.2
        ClientCountdownInitiate = 0x01FA, // 7.2
        ClientTrigger = 0x0146, // 7.2
        InventoryModifyHandler = 0x02BF, // 7.2
        LogoutHandler = 0x025F, // 7.2
        MarketBoardPurchaseHandler = 0x02FA, // 7.2
        SetSearchInfoHandler = 0x006D, // 7.2
        UpdatePositionHandler = 0x0100, // 7.2
        UpdatePositionInstance = 0x0137, // 7.2
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {

    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {

    };
}
