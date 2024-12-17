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
        ActorCast = 0x0181, // 7.0
        ActorControl = 0x0384, // 7.0
        ActorControlSelf = 0x028C, // 7.0
        ActorControlTarget = 0x02EF, // 7.0
        ActorGauge = 0x01BF, // 7.0
        ActorMove = 0x029E, // 7.0
        ActorSetPos = 0x0072, // 7.0
        AirshipExplorationResult = 0x0250, // 7.0
        AirshipStatus = 0x03B5, // 7.0
        AirshipStatusList = 0x01D3, // 7.0
        AirshipTimers = 0x01DD, // 7.0
        AoeEffect16 = 0x0086, // 7.0
        AoeEffect24 = 0x0178, // 7.0
        AoeEffect32 = 0x0282, // 7.0
        AoeEffect8 = 0x019B, // 7.0
        CEDirector = 0x0379, // 7.0
        CFNotify = 0x02ED, // 7.0
        CFPreferredRole = 0x03C0, // 7.0
        ContainerInfo = 0x01A8, // 7.0
        CurrencyCrystalInfo = 0x0334, // 7.0
        DespawnCharacter = 0x00DA, // 7.0
        DesynthResult = 0x03C7, // 7.0
        Effect = 0x037C, // 7.0
        EffectResult = 0x01F0, // 7.0
        EffectResult16 = 0x00D7, // 7.0
        EffectResult32 = 0x03C2, // 7.0
        EffectResult4 = 0x0172, // 7.0
        EffectResult8 = 0x02C1, // 7.0
        EffectResultBasic = 0x01B9, // 7.0
        EffectResultBasic16 = 0x03BC, // 7.0
        EffectResultBasic32 = 0x0275, // 7.0
        EffectResultBasic4 = 0x01FA, // 7.0
        EffectResultBasic64 = 0x009B, // 7.0
        EffectResultBasic8 = 0x00BC, // 7.0
        EnvironmentControl = 0x02B0, // 7.0
        EventFinish = 0x0144, // 7.0
        EventPlay = 0x02FD, // 7.0
        EventPlay128 = 0x0248, // 7.0
        EventPlay16 = 0x008D, // 7.0
        EventPlay255 = 0x0100, // 7.0
        EventPlay32 = 0x01B6, // 7.0
        EventPlay4 = 0x03A8, // 7.0
        EventPlay64 = 0x01DB, // 7.0
        EventPlay8 = 0x03CB, // 7.0
        EventStart = 0x02E2, // 7.0
        ExamineFreeCompanyInfo = 0x02DB, // 7.0
        ExamineSearchInfo = 0x010C, // 7.0
        FirstAttack = 0x01DF, // 7.0
        FreeCompanyDialog = 0x0150, // 7.0
        FreeCompanyInfo = 0x02F0, // 7.0
        HousingWardInfo = 0x0323, // 7.0
        InitZone = 0x012E, // 7.0
        InventoryActionAck = 0x03C8, // 7.0
        InventoryTransaction = 0x0147, // 7.0
        InventoryTransactionFinish = 0x021B, // 7.0
        IslandWorkshopSupplyDemand = 0x02AD, // 7.0
        ItemInfo = 0x00A9, // 7.0
        ItemMarketBoardInfo = 0x0243, // 7.0
        Logout = 0x026B, // 7.0
        MarketBoardItemListing = 0x03D6, // 7.0
        MarketBoardItemListingCount = 0x029D, // 7.0
        MarketBoardItemListingHistory = 0x01B0, // 7.0
        MarketBoardPurchase = 0x0382, // 7.0
        MarketBoardSearchResult = 0x0324, // 7.0
        MiniCactpotInit = 0x0219, // 7.0
        NpcSpawn = 0x032D, // 7.0
        NpcSpawn2 = 0x02BF, // 7.0
        ObjectSpawn = 0x0077, // 7.0
        PlaceFieldMarker = 0x028D, // 7.0
        PlaceFieldMarkerPreset = 0x01CE, // 7.0
        PlayerSetup = 0x014D, // 7.0
        PlayerSpawn = 0x0287, // 7.0
        PlayerStats = 0x0122, // 7.0
        Playtime = 0x010E, // 7.0
        PrepareZoning = 0x01CB, // 7.0
        RetainerInformation = 0x00C6, // 7.0
        SocialList = 0x0232, // 7.0
        StatusEffectList = 0x0279, // 7.0
        StatusEffectListBozja = 0x0359, // 7.0
        StatusEffectListDouble = 0x03AB, // 7.0
        StatusEffectListEureka = 0x026E, // 7.0
        StatusEffectListPlayer = 0x03AE, // 7.0
        StatusEffectListPlayerDouble = 0x03CE, // 7.0
        SubmarineExplorationResult = 0x00A0, // 7.0
        SubmarineProgressionStatus = 0x0240, // 7.0
        SubmarineStatusList = 0x02D3, // 7.0
        SubmarineTimers = 0x0228, // 7.0
        SystemLogMessage = 0x0253, // 7.0
        SystemLogMessage16 = 0x00C7, // 7.0
        SystemLogMessage2 = 0x00B1, // 7.0
        SystemLogMessage4 = 0x01A2, // 7.0
        SystemLogMessage8 = 0x0227, // 7.0
        UpdateClassInfo = 0x02DD, // 7.0
        UpdateClassInfoBozja = 0x0397, // 7.0
        UpdateClassInfoEureka = 0x02E5, // 7.0
        UpdateHpMpTp = 0x03DA, // 7.0
        UpdateInventorySlot = 0x0186, // 7.0
        UpdateSearchInfo = 0x0175, // 7.0
        WeatherChange = 0x0268, // 7.0
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x03AA, // 7.0
        ActionRequestGroundTargeted = 0x01EF, // 7.0
        ChatHandler = 0x0247, // 7.0
        ClientCountdownInitiate = 0x020D, // 7.0
        ClientTrigger = 0x0150, // 7.0
        InventoryModifyHandler = 0x0158, // 7.0
        LogoutHandler = 0x0190, // 7.0
        MarketBoardPurchaseHandler = 0x010D, // 7.0
        SetSearchInfoHandler = 0x0293, // 7.0
        UpdatePositionHandler = 0x03D4, // 7.0
        UpdatePositionInstance = 0x032D, // 7.0
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
