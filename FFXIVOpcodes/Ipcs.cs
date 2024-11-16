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
        PlayerSetup = 0x0226, // updated 7.1
        UpdateHpMpTp = 0x02F9, // updated 7.1
        UpdateClassInfo = 0x0135, // updated 7.1
        PlayerStats = 0x0191, // updated 7.1
        ActorControl = 0x0212, // updated 7.1
        ActorControlSelf = 0x00AF, // updated 7.1
        ActorControlTarget = 0x028A, // updated 7.1
        Playtime = 0x02CB, // updated 7.1
        UpdateSearchInfo = 0x03B4, // updated 7.1
        ExamineSearchInfo = 0x0391, // updated 7.1
        Examine = 0x03AE, // updated 7.1
        ActorCast = 0x0160, // updated 7.1
        CurrencyCrystalInfo = 0x0257, // updated 7.1
        InitZone = 0x016C, // updated 7.1
        WeatherChange = 0x02E0, // updated 7.1
        PlayerSpawn = 0x0171, // updated 7.1
        ActorSetPos = 0x038C, // updated 7.1
        PrepareZoning = 0x02A3, // updated 7.1
        ContainerInfo = 0x02ED, // updated 7.1
        ItemInfo = 0x0310, // updated 7.1
        PlaceFieldMarker = 0x02AA, // updated 7.1
        PlaceFieldMarkerPreset = 0x0076, // updated 7.1
        EffectResult = 0x0179, // updated 7.1
        EventStart = 0x037F, // updated 7.1
        EventFinish = 0x02FE, // updated 7.1
        DesynthResult = 0x02C9, // updated 7.1
        FreeCompanyInfo = 0x0378, // updated 7.1
        FreeCompanyDialog = 0x03CC, // updated 7.1
        MarketBoardSearchResult = 0x01B8, // updated 7.1
        MarketBoardItemListingCount = 0x02D2, // updated 7.1
        MarketBoardItemListingHistory = 0x03D7, // updated 7.1
        MarketBoardItemListing = 0x00F2, // updated 7.1
        MarketBoardPurchase = 0x0219, // updated 7.1
        UpdateInventorySlot = 0x026D, // updated 7.1
        InventoryActionAck = 0x035E, // updated 7.1
        InventoryTransaction = 0x02FC, // updated 7.1
        InventoryTransactionFinish = 0x01C0, // updated 7.1
        ResultDialog = 0x030F, // updated 7.1
        RetainerInformation = 0x0194, // updated 7.1
        NpcSpawn = 0x039A, // updated 7.1
        ItemMarketBoardInfo = 0x024B, // updated 7.1
        ObjectSpawn = 0x009C, // updated 7.1
        EffectResultBasic = 0x018D, // updated 7.1
        Effect = 0x02E2, // updated 7.1
        StatusEffectList = 0x0373, // updated 7.1
        StatusEffectList2 = 0x0347, // updated 7.1
        StatusEffectList3 = 0x022C, // updated 7.1
        ActorGauge = 0x02F0, // updated 7.1
        CFNotify = 0x01C4, // updated 7.1
        SystemLogMessage = 0x0336, // updated 7.1
        AirshipTimers = 0x01E5, // updated 7.1
        SubmarineTimers = 0x00F3, // updated 7.1
        AirshipStatusList = 0x02C3, // updated 7.1
        AirshipStatus = 0x00E8, // updated 7.1
        AirshipExplorationResult = 0x0132, // updated 7.1
        SubmarineProgressionStatus = 0x00F9, // updated 7.1
        SubmarineStatusList = 0x034C, // updated 7.1
        SubmarineExplorationResult = 0x032B, // updated 7.1

        CraftingLog = 0x02E3, // updated 7.1
        GatheringLog = 0x02B7, // updated 7.1

        ActorMove = 0x03AA, // updated 7.1

        EventPlay = 0x03CA, // updated 7.1
        EventPlay4 = 0x0183, // updated 7.1
        EventPlay8 = 0x0237, // updated 7.1
        EventPlay16 = 0x0150, // updated 7.1
        EventPlay32 = 0x00FF, // updated 7.1
        EventPlay64 = 0x0328, // updated 7.1
        EventPlay128 = 0x01ED, // updated 7.1
        EventPlay255 = 0x0337, // updated 7.1

        EnvironmentControl = 0x010E, // updated 7.1
        IslandWorkshopSupplyDemand = 0x016A, // updated 7.1
        Logout = 0x03D3, // updated 7.1
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03DC, // updated 7.1
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x03BD, // updated 7.1
        MarketBoardPurchaseHandler = 0x02B1, // updated 7.1
        InventoryModifyHandler = 0x0188, // updated 7.1
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