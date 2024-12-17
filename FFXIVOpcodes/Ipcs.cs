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
        PlayerSetup = 0x01F0, // updated 7.15
        UpdateHpMpTp = 0x00AC, // updated 7.15
        UpdateClassInfo = 0x013B, // updated 7.15
        PlayerStats = 0x022C, // updated 7.15
        ActorControl = 0x03A3, // updated 7.15
        ActorControlSelf = 0x008A, // updated 7.15
        ActorControlTarget = 0x02E7, // updated 7.15
        Playtime = 0x009D, // updated 7.15
        UpdateSearchInfo = 0x00A7, // updated 7.15
        ExamineSearchInfo = 0x019A, // updated 7.15
        Examine = 0x020A, // updated 7.15
        ActorCast = 0x00C5, // updated 7.15
        CurrencyCrystalInfo = 0x038B, // updated 7.15
        InitZone = 0x036D, // updated 7.15
        WeatherChange = 0x03CE, // updated 7.15
        PlayerSpawn = 0x0171, // updated 7.15
        ActorSetPos = 0x0337, // updated 7.15
        PrepareZoning = 0x0237, // updated 7.15
        ContainerInfo = 0x0270, // updated 7.15
        ItemInfo = 0x038D, // updated 7.15
        PlaceFieldMarker = 0x0173, // updated 7.15
        PlaceFieldMarkerPreset = 0x00C8, // updated 7.15
        EffectResult = 0x02B2, // updated 7.15
        EventStart = 0x01C7, // updated 7.15
        EventFinish = 0x0316, // updated 7.15
        DesynthResult = 0x0134, // updated 7.15
        FreeCompanyInfo = 0x0359, // updated 7.15
        FreeCompanyDialog = 0x0249, // updated 7.15
        MarketBoardSearchResult = 0x0285, // updated 7.15
        MarketBoardItemListingCount = 0x034C, // updated 7.15
        MarketBoardItemListingHistory = 0x0294, // updated 7.15
        MarketBoardItemListing = 0x02A1, // updated 7.15
        MarketBoardPurchase = 0x032F, // updated 7.15
        UpdateInventorySlot = 0x01F8, // updated 7.15
        InventoryActionAck = 0x03C5, // updated 7.15
        InventoryTransaction = 0x00AF, // updated 7.15
        InventoryTransactionFinish = 0x034D, // updated 7.15
        ResultDialog = 0x02BD, // updated 7.15
        RetainerInformation = 0x0228, // updated 7.15
        NpcSpawn = 0x037A, // updated 7.15
        ItemMarketBoardInfo = 0x01FD, // updated 7.15
        ObjectSpawn = 0x02CE, // updated 7.15
        EffectResultBasic = 0x0185, // updated 7.15
        Effect = 0x0395, // updated 7.15
        StatusEffectList = 0x008E, // updated 7.15
        StatusEffectList2 = 0x0127, // updated 7.15
        StatusEffectList3 = 0x00B3, // updated 7.15
        ActorGauge = 0x00F9, // updated 7.15
        CFNotify = 0x0289, // updated 7.15
        SystemLogMessage = 0x023F, // updated 7.15
        AirshipTimers = 0x01FF, // updated 7.15
        SubmarineTimers = 0x0314, // updated 7.15
        AirshipStatusList = 0x00C2, // updated 7.15
        AirshipStatus = 0x013A, // updated 7.15
        AirshipExplorationResult = 0x0100, // updated 7.15
        SubmarineProgressionStatus = 0x0258, // updated 7.15
        SubmarineStatusList = 0x03E4, // updated 7.15
        SubmarineExplorationResult = 0x0069, // updated 7.15

        CraftingLog = 0x01B4, // updated 7.15
        GatheringLog = 0x0128, // updated 7.15

        ActorMove = 0x0233, // updated 7.15

        EventPlay = 0x02F9, // updated 7.15
        EventPlay4 = 0x02C8, // updated 7.15
        EventPlay8 = 0x03E2, // updated 7.15
        EventPlay16 = 0x020D, // updated 7.15
        EventPlay32 = 0x0323, // updated 7.15
        EventPlay64 = 0x02A5, // updated 7.15
        EventPlay128 = 0x026C, // updated 7.15
        EventPlay255 = 0x0206, // updated 7.15

        EnvironmentControl = 0x02FA, // updated 7.15
        IslandWorkshopSupplyDemand = 0x0070, // updated 7.15
        Logout = 0x0065, // updated 7.15
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0312, // updated 7.15
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0133, // updated 7.15
        MarketBoardPurchaseHandler = 0x0229, // updated 7.15
        InventoryModifyHandler = 0x0257, // updated 7.15
        //UpdatePositionInstance = 0x03CE, // updated 7.0h
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