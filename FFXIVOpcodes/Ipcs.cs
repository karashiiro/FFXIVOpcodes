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
        PlayerSetup = 0x0141, // updated 7.31h
        UpdateHpMpTp = 0x02EE, // updated 7.31h
        UpdateClassInfo = 0x00B9, // updated 7.31h
        PlayerStats = 0x0074, // updated 7.31h
        ActorControl = 0x03D1, // updated 7.31h
        ActorControlSelf = 0x0120, // updated 7.31h
        ActorControlTarget = 0x0133, // updated 7.31h
        Playtime = 0x03A8, // updated 7.31h
        UpdateSearchInfo = 0x0135, // updated 7.31h
        ExamineSearchInfo = 0x03C7, // updated 7.31h
        Examine = 0x01F5, // updated 7.31h
        ActorCast = 0x00CC, // updated 7.31h
        CurrencyCrystalInfo = 0x02B8, // updated 7.31h
        InitZone = 0x0309, // updated 7.31h
        WeatherChange = 0x021A, // updated 7.31h
        PlayerSpawn = 0x021E, // updated 7.31h
        ActorSetPos = 0x03BB, // updated 7.31h
        PrepareZoning = 0x01C2, // updated 7.31h
        ContainerInfo = 0x0091, // updated 7.31h
        ItemInfo = 0x01EF, // updated 7.31h
        PlaceFieldMarker = 0x0265, // updated 7.31h
        PlaceFieldMarkerPreset = 0x008C, // updated 7.31h
        EffectResult = 0x0191, // updated 7.31h
        EventStart = 0x00FB, // updated 7.31h
        EventFinish = 0x008A, // updated 7.31h
        DesynthResult = 0x024D, // updated 7.31h
        FreeCompanyInfo = 0x018C, // updated 7.31h
        FreeCompanyDialog = 0x0293, // updated 7.31h
        MarketBoardSearchResult = 0x00D3, // updated 7.31h
        MarketBoardItemListingCount = 0x02C7, // updated 7.31h
        MarketBoardItemListingHistory = 0x029B, // updated 7.31h
        MarketBoardItemListing = 0x00D8, // updated 7.31h
        MarketBoardPurchase = 0x031A, // updated 7.31h
        UpdateInventorySlot = 0x03E5, // updated 7.31h
        InventoryActionAck = 0x02AA, // updated 7.31h
        InventoryTransaction = 0x0156, // updated 7.31h
        InventoryTransactionFinish = 0x01A7, // updated 7.31h
        ResultDialog = 0x029F, // updated 7.31h
        RetainerInformation = 0x029E, // updated 7.31h
        NpcSpawn = 0x00E0, // updated 7.31h
        ItemMarketBoardInfo = 0x038C, // updated 7.31h
        ObjectSpawn = 0x031F, // updated 7.31h
        EffectResultBasic = 0x0331, // updated 7.31h
        Effect = 0x0338, // updated 7.31h
        StatusEffectList = 0x012C, // updated 7.31h
        StatusEffectList2 = 0x0348, // updated 7.31h
        StatusEffectList3 = 0x0307, // updated 7.31h
        ActorGauge = 0x0243, // updated 7.31h
        CFNotify = 0x00C2, // updated 7.31h
        SystemLogMessage = 0x0356, // updated 7.31h
        AirshipTimers = 0x023C, // updated 7.31h
        SubmarineTimers = 0x02EC, // updated 7.31h
        AirshipStatusList = 0x01D0, // updated 7.31h
        AirshipStatus = 0x0297, // updated 7.31h
        AirshipExplorationResult = 0x03CA, // updated 7.31h
        SubmarineProgressionStatus = 0x0294, // updated 7.31h
        SubmarineStatusList = 0x0306, // updated 7.31h
        SubmarineExplorationResult = 0x01E1, // updated 7.31h

        CraftingLog = 0x00F7, // updated 7.31h
        GatheringLog = 0x02CF, // updated 7.31h

        ActorMove = 0x02F3, // updated 7.31h

        EventPlay = 0x01ED, // updated 7.31h
        EventPlay4 = 0x0090, // updated 7.31h
        EventPlay8 = 0x00AE, // updated 7.31h
        EventPlay16 = 0x0088, // updated 7.31h
        EventPlay32 = 0x0246, // updated 7.31h
        EventPlay64 = 0x00E8, // updated 7.31h
        EventPlay128 = 0x0248, // updated 7.31h
        EventPlay255 = 0x00FA, // updated 7.31h

        EnvironmentControl = 0x026B, // updated 7.31h
        IslandWorkshopSupplyDemand = 0x006E, // updated 7.31h
        Logout = 0x01A3, // updated 7.31h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x039A, // updated 7.31h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x01D6, // updated 7.31h
        MarketBoardPurchaseHandler = 0x01FC, // updated 7.31h
        InventoryModifyHandler = 0x028B, // updated 7.31h
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