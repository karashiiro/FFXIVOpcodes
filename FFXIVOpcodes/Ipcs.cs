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
        PlayerSetup = 0x01AB, // updated 6.58
        UpdateHpMpTp = 0x024C, // updated 6.58
        UpdateClassInfo = 0x02A1, // updated 6.58
        PlayerStats = 0x012E, // updated 6.58
        ActorControl = 0x02C9, // updated 6.58
        ActorControlSelf = 0x0340, // updated 6.58
        ActorControlTarget = 0x0169, // updated 6.58
        Playtime = 0x0245, // updated 6.58
        UpdateSearchInfo = 0x02FB, // updated 6.58
        ExamineSearchInfo = 0x01D3, // updated 6.58
        Examine = 0x0308, // updated 6.58
        ActorCast = 0x0165, // updated 6.58
        CurrencyCrystalInfo = 0x03A8, // updated 6.58
        InitZone = 0x02D7, // updated 6.58
        WeatherChange = 0x00B2, // updated 6.58
        PlayerSpawn = 0x0285, // updated 6.58
        ActorSetPos = 0x0079, // updated 6.58
        PrepareZoning = 0x038E, // updated 6.58
        ContainerInfo = 0x0293, // updated 6.58
        ItemInfo = 0x03AE, // updated 6.58
        PlaceFieldMarker = 0x01DB, // updated 6.58
        PlaceFieldMarkerPreset = 0x00E3, // updated 6.58
        EffectResult = 0x032E, // updated 6.58
        EventStart = 0x03D6, // updated 6.58
        EventFinish = 0x03C7, // updated 6.58
        DesynthResult = 0x0249, // updated 6.58
        FreeCompanyInfo = 0x02AE, // updated 6.58
        FreeCompanyDialog = 0x02A6, // updated 6.58
        MarketBoardSearchResult = 0x0153, // updated 6.58
        MarketBoardItemListingCount = 0x00FB, // updated 6.58
        MarketBoardItemListingHistory = 0x00C5, // updated 6.58
        MarketBoardItemListing = 0x0077, // updated 6.58
        MarketBoardPurchase = 0x030B, // updated 6.58
        UpdateInventorySlot = 0x026A, // updated 6.58
        InventoryActionAck = 0x030D, // updated 6.58
        InventoryTransaction = 0x00E2, // updated 6.58
        InventoryTransactionFinish = 0x022D, // updated 6.58
        ResultDialog = 0x03E6, // updated 6.58
        RetainerInformation = 0x02DE, // updated 6.58
        NpcSpawn = 0x03CE, // updated 6.58
        ItemMarketBoardInfo = 0x008F, // updated 6.58
        ObjectSpawn = 0x00C0, // updated 6.58
        EffectResultBasic = 0x026D, // updated 6.58
        Effect = 0x00D3, // updated 6.58
        StatusEffectList = 0x033E, // updated 6.58
        StatusEffectList2 = 0x01AC, // updated 6.58
        StatusEffectList3 = 0x010E, // updated 6.58
        ActorGauge = 0x007B, // updated 6.58
        CFNotify = 0x0147, // updated 6.58
        SystemLogMessage = 0x0255, // updated 6.58
        AirshipTimers = 0x019B, // updated 6.58
        SubmarineTimers = 0x0136, // updated 6.58
        AirshipStatusList = 0x01AE, // updated 6.58
        AirshipStatus = 0x03C5, // updated 6.58
        AirshipExplorationResult = 0x0105, // updated 6.58
        SubmarineProgressionStatus = 0x01C1, // updated 6.58
        SubmarineStatusList = 0x02F3, // updated 6.58
        SubmarineExplorationResult = 0x01A4, // updated 6.58

        ActorMove = 0x01A0, // updated 6.58

        EventPlay = 0x0335, // updated 6.58
        EventPlay4 = 0x037D, // updated 6.58
        EventPlay8 = 0x0203, // updated 6.58
        EventPlay16 = 0x00EC, // updated 6.58
        EventPlay32 = 0x0144, // updated 6.58
        EventPlay64 = 0x03E4, // updated 6.58
        EventPlay128 = 0x0232, // updated 6.58
        EventPlay255 = 0x03A3, // updated 6.58

        EnvironmentControl = 0x02D8, // updated 6.58
        IslandWorkshopSupplyDemand = 0x0078, // updated 6.58
        Logout = 0x02D5, // updated 6.58
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0163, // updated 6.58
        ClientTrigger = 0x0103, // updated 6.58
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x009C, // updated 6.58
        MarketBoardPurchaseHandler = 0x037B, // updated 6.58
        InventoryModifyHandler = 0x039B, // updated 6.58
        UpdatePositionInstance = 0x034C, // updated 6.58
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