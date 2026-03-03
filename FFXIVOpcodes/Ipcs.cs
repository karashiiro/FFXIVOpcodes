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
        PlayerSetup = 0x00E5, // updated 7.45
        UpdateHpMpTp = 0x00C8, // updated 7.45
        UpdateClassInfo = 0x022F, // updated 7.45
        PlayerStats = 0x02B0, // updated 7.45
        ActorControl = 0x0114, // updated 7.45
        ActorControlSelf = 0x014E, // updated 7.45
        ActorControlTarget = 0x0186, // updated 7.45
        Playtime = 0x0067, // updated 7.45
        UpdateSearchInfo = 0x033D, // updated 7.45
        ExamineSearchInfo = 0x03D3, // updated 7.45
        Examine = 0x010A, // updated 7.45
        ActorCast = 0x03E0, // updated 7.45
        CurrencyCrystalInfo = 0x03C6, // updated 7.45
        InitZone = 0x009D, // updated 7.45
        WeatherChange = 0x0310, // updated 7.45
        PlayerSpawn = 0x01A4, // updated 7.45
        ActorSetPos = 0x01F9, // updated 7.45
        PrepareZoning = 0x00E9, // updated 7.45
        ContainerInfo = 0x0151, // updated 7.45
        ItemInfo = 0x0328, // updated 7.45
        PlaceFieldMarker = 0x0087, // updated 7.45
        PlaceFieldMarkerPreset = 0x03C3, // updated 7.45
        EffectResult = 0x0301, // updated 7.45
        EventStart = 0x0085, // updated 7.45
        EventFinish = 0x0398, // updated 7.45
        DesynthResult = 0x0081, // updated 7.45
        FreeCompanyInfo = 0x0344, // updated 7.45
        FreeCompanyDialog = 0x039F, // updated 7.45
        MarketBoardSearchResult = 0x02AA, // updated 7.45
        MarketBoardItemListingCount = 0x00F8, // updated 7.45
        MarketBoardItemListingHistory = 0x00A5, // updated 7.45
        MarketBoardItemListing = 0x0333, // updated 7.45
        MarketBoardPurchase = 0x01A2, // updated 7.45
        UpdateInventorySlot = 0x00E4, // updated 7.45
        InventoryActionAck = 0x019B, // updated 7.45
        InventoryTransaction = 0x01C7, // updated 7.45
        InventoryTransactionFinish = 0x0111, // updated 7.45
        ResultDialog = 0x012F, // updated 7.45
        RetainerInformation = 0x0069, // updated 7.45
        NpcSpawn = 0x0304, // updated 7.45
        ItemMarketBoardInfo = 0x0120, // updated 7.45
        ObjectSpawn = 0x01CD, // updated 7.45
        EffectResultBasic = 0x0094, // updated 7.45
        Effect = 0x02FA, // updated 7.45
        StatusEffectList = 0x006F, // updated 7.45
        StatusEffectList2 = 0x00C7, // updated 7.45
        StatusEffectList3 = 0x0330, // updated 7.45
        ActorGauge = 0x0355, // updated 7.45
        CFNotify = 0x037E, // updated 7.45
        SystemLogMessage = 0x03CC, // updated 7.45
        AirshipTimers = 0x0388, // updated 7.45
        SubmarineTimers = 0x01AD, // updated 7.45
        AirshipStatusList = 0x03BD, // updated 7.45
        AirshipStatus = 0x0307, // updated 7.45
        AirshipExplorationResult = 0x0248, // updated 7.45
        SubmarineProgressionStatus = 0x02A2, // updated 7.45
        SubmarineStatusList = 0x01E4, // updated 7.45
        SubmarineExplorationResult = 0x01CE, // updated 7.45

        CraftingLog = 0x03A6, // updated 7.45
        GatheringLog = 0x01CA, // updated 7.45

        ActorMove = 0x0314, // updated 7.45

        EventPlay = 0x0091, // updated 7.45
        EventPlay4 = 0x013F, // updated 7.45
        EventPlay8 = 0x00FB, // updated 7.45
        EventPlay16 = 0x0173, // updated 7.45
        EventPlay32 = 0x02E2, // updated 7.45
        EventPlay64 = 0x00B5, // updated 7.45
        EventPlay128 = 0x03E1, // updated 7.45
        EventPlay255 = 0x0226, // updated 7.45

        EnvironmentControl = 0x01D8, // updated 7.45
        IslandWorkshopSupplyDemand = 0x0396, // updated 7.45
        Logout = 0x025E, // updated 7.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x035B, // updated 7.45
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x009C, // updated 7.45
        MarketBoardPurchaseHandler = 0x03A2, // updated 7.45
        InventoryModifyHandler = 0x03B8, // updated 7.45
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