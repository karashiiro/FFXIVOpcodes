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
        PlayerSetup = 0x0218,// updated 6.40
        UpdateHpMpTp = 0x021A,// updated 6.40
        UpdateClassInfo = 0x0380,// updated 6.40
        PlayerStats = 0x01A3,// updated 6.40
        ActorControl = 0x0381,// updated 6.40
        ActorControlSelf = 0x014F,// updated 6.40
        ActorControlTarget = 0x0131,// updated 6.40
        Playtime = 0x0181,// updated 6.40
        UpdateSearchInfo = 0x0339,// updated 6.40
        ExamineSearchInfo = 0x02B0,// updated 6.40
        Examine = 0x364, // updated 6.40
        ActorCast = 0x031C,// updated 6.40
        CurrencyCrystalInfo = 0x02BE,// updated 6.40
        InitZone = 0x0347,// updated 6.40
        WeatherChange = 0x01D2,// updated 6.40
        PlayerSpawn = 0x02CF,// updated 6.40
        ActorSetPos = 0x00EA,// updated 6.40
        PrepareZoning = 0x017A,// updated 6.40
        ContainerInfo = 0x0122,// updated 6.40
        ItemInfo = 0x0128,// updated 6.40
        PlaceFieldMarker = 0x03B5,// updated 6.40
        PlaceFieldMarkerPreset = 0x00D8,// updated 6.40
        EffectResult = 0x03B4,// updated 6.40
        EventStart = 0x01A2,// updated 6.40
        EventFinish = 0x02B2,// updated 6.40
        DesynthResult = 0x01BA,// updated 6.40
        FreeCompanyInfo = 0x01CE,// updated 6.40
        FreeCompanyDialog = 0x02A1,// updated 6.40
        MarketBoardSearchResult = 0x0197,// updated 6.40
        MarketBoardItemListingCount = 0x01A4,// updated 6.40
        MarketBoardItemListingHistory = 0x02B4,// updated 6.40
        MarketBoardItemListing = 0x00A7,// updated 6.40
        MarketBoardPurchase = 0x0120,// updated 6.40
        UpdateInventorySlot = 0x0119,// updated 6.40
        InventoryActionAck = 0x019C,// updated 6.40
        InventoryTransaction = 0x02E9,// updated 6.40
        InventoryTransactionFinish = 0x02D9,// updated 6.40
        ResultDialog = 0x01CB,// updated 6.40
        RetainerInformation = 0x039C,// updated 6.40
        NpcSpawn = 0x01C4,// updated 6.40
        ItemMarketBoardInfo = 0x03C4,// updated 6.40
        ObjectSpawn = 0x0184,// updated 6.40
        EffectResultBasic = 0x0295,// updated 6.40
        Effect = 0x03C9,// updated 6.40
        StatusEffectList = 0x013F,// updated 6.40
        StatusEffectList2 = 0x149, // updated 6.40
        StatusEffectList3 = 0xe7, // updated 6.40
        ActorGauge = 0x0164,// updated 6.40
        CFNotify = 0x03E0,// updated 6.40
        SystemLogMessage = 0x019B,// updated 6.40
        AirshipTimers = 0x0132,// updated 6.40
        SubmarineTimers = 0x02B7,// updated 6.40
        AirshipStatusList = 0x02CB,// updated 6.40
        AirshipStatus = 0x01EB,// updated 6.40
        AirshipExplorationResult = 0x02C4,// updated 6.40
        SubmarineProgressionStatus = 0x0385,// updated 6.40
        SubmarineStatusList = 0x0081,// updated 6.40
        SubmarineExplorationResult = 0x02C9,// updated 6.40

        ActorMove = 0x2a9, // updated 6.40

        EventPlay = 0xfb, // updated 6.40
        EventPlay4 = 0x307, // updated 6.40
        EventPlay8 = 0x252, // updated 6.40
        EventPlay16 = 0x214, // updated 6.40
        EventPlay32 = 0x6c, // updated 6.40
        EventPlay64 = 0x223, // updated 6.40
        EventPlay128 = 0x340, // updated 6.40
        EventPlay255 = 0x3dc, // updated 6.40

        EnvironmentControl = 0x108, // updated 6.40
        IslandWorkshopSupplyDemand = 0x169, // updated 6.40
        Logout = 0x18a, // updated 6.40
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0179,// updated 6.40
        ClientTrigger = 0x01BC,// updated 6.40
        ChatHandler = 0x00D3,// updated 6.40
        SetSearchInfoHandler = 0x03B6,// updated 6.40
        MarketBoardPurchaseHandler = 0x0256,// updated 6.40
        InventoryModifyHandler = 0x02DB,// updated 6.40 (Base offset: 0x02E2)
        UpdatePositionInstance = 0x00E5,// updated 6.40
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
