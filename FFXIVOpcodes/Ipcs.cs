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
        PlayerSetup = 0x016D, // updated 7.45h
        UpdateHpMpTp = 0x0141, // updated 7.45h
        UpdateClassInfo = 0x0264, // updated 7.45h
        PlayerStats = 0x02AF, // updated 7.45h
        ActorControl = 0x00E7, // updated 7.45h
        ActorControlSelf = 0x0217, // updated 7.45h
        ActorControlTarget = 0x0171, // updated 7.45h
        Playtime = 0x0213, // updated 7.45h
        UpdateSearchInfo = 0x03CF, // updated 7.45h
        ExamineSearchInfo = 0x01A3, // updated 7.45h
        Examine = 0x036C, // updated 7.45h
        ActorCast = 0x0260, // updated 7.45h
        CurrencyCrystalInfo = 0x0199, // updated 7.45h
        InitZone = 0x0246, // updated 7.45h
        WeatherChange = 0x0122, // updated 7.45h
        PlayerSpawn = 0x03CA, // updated 7.45h
        ActorSetPos = 0x01C8, // updated 7.45h
        PrepareZoning = 0x008E, // updated 7.45h
        ContainerInfo = 0x0356, // updated 7.45h
        ItemInfo = 0x01A8, // updated 7.45h
        PlaceFieldMarker = 0x011C, // updated 7.45h
        PlaceFieldMarkerPreset = 0x01EB, // updated 7.45h
        EffectResult = 0x0284, // updated 7.45h
        EventStart = 0x00BC, // updated 7.45h
        EventFinish = 0x023C, // updated 7.45h
        DesynthResult = 0x014A, // updated 7.45h
        FreeCompanyInfo = 0x02DA, // updated 7.45h
        FreeCompanyDialog = 0x0101, // updated 7.45h
        MarketBoardSearchResult = 0x00A8, // updated 7.45h
        MarketBoardItemListingCount = 0x00A5, // updated 7.45h
        MarketBoardItemListingHistory = 0x02EF, // updated 7.45h
        MarketBoardItemListing = 0x01C2, // updated 7.45h
        MarketBoardPurchase = 0x00DA, // updated 7.45h
        UpdateInventorySlot = 0x037E, // updated 7.45h
        InventoryActionAck = 0x0205, // updated 7.45h
        InventoryTransaction = 0x011A, // updated 7.45h
        InventoryTransactionFinish = 0x01C0, // updated 7.45h
        ResultDialog = 0x03D1, // updated 7.45h
        RetainerInformation = 0x01FA, // updated 7.45h
        NpcSpawn = 0x03C3, // updated 7.45h
        ItemMarketBoardInfo = 0x031A, // updated 7.45h
        ObjectSpawn = 0x00BB, // updated 7.45h
        EffectResultBasic = 0x0139, // updated 7.45h
        Effect = 0x00B6, // updated 7.45h
        StatusEffectList = 0x01DF, // updated 7.45h
        StatusEffectList2 = 0x0203, // updated 7.45h
        StatusEffectList3 = 0x01B0, // updated 7.45h
        ActorGauge = 0x006A, // updated 7.45h
        CFNotify = 0x0285, // updated 7.45h
        SystemLogMessage = 0x0331, // updated 7.45h
        AirshipTimers = 0x00CC, // updated 7.45h
        SubmarineTimers = 0x0074, // updated 7.45h
        AirshipStatusList = 0x02DE, // updated 7.45h
        AirshipStatus = 0x034D, // updated 7.45h
        AirshipExplorationResult = 0x034C, // updated 7.45h
        SubmarineProgressionStatus = 0x02B8, // updated 7.45h
        SubmarineStatusList = 0x01F0, // updated 7.45h
        SubmarineExplorationResult = 0x0167, // updated 7.45h

        CraftingLog = 0x0235, // updated 7.45h
        GatheringLog = 0x01CA, // updated 7.45h

        ActorMove = 0x0362, // updated 7.45h

        EventPlay = 0x02B4, // updated 7.45h
        EventPlay4 = 0x012C, // updated 7.45h
        EventPlay8 = 0x00F8, // updated 7.45h
        EventPlay16 = 0x035E, // updated 7.45h
        EventPlay32 = 0x01B6, // updated 7.45h
        EventPlay64 = 0x0098, // updated 7.45h
        EventPlay128 = 0x0337, // updated 7.45h
        EventPlay255 = 0x022A, // updated 7.45h

        EnvironmentControl = 0x0386, // updated 7.45h
        IslandWorkshopSupplyDemand = 0x02AD, // updated 7.45h
        Logout = 0x02D3, // updated 7.45h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x031B, // updated 7.45h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x017F, // updated 7.45h
        MarketBoardPurchaseHandler = 0x0378, // updated 7.45h
        InventoryModifyHandler = 0x03C9, // updated 7.45h
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