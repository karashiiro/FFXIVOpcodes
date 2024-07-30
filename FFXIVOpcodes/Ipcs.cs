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
        PlayerSetup = 0x02A7, // updated 7.05
        UpdateHpMpTp = 0x0200, // updated 7.05
        UpdateClassInfo = 0x0147, // updated 7.05
        PlayerStats = 0x020C, // updated 7.05
        ActorControl = 0x03C7, // updated 7.05
        ActorControlSelf = 0x022F, // updated 7.05
        ActorControlTarget = 0x00F6, // updated 7.05
        Playtime = 0x0113, // updated 7.05
        UpdateSearchInfo = 0x032F, // updated 7.05
        ExamineSearchInfo = 0x0360, // updated 7.05
        Examine = 0x006A, // updated 7.05
        ActorCast = 0x016D, // updated 7.05
        CurrencyCrystalInfo = 0x0352, // updated 7.05
        InitZone = 0x0173, // updated 7.05
        WeatherChange = 0x01EF, // updated 7.05
        PlayerSpawn = 0x0165, // updated 7.05
        ActorSetPos = 0x0137, // updated 7.05
        PrepareZoning = 0x0169, // updated 7.05
        ContainerInfo = 0x009B, // updated 7.05
        ItemInfo = 0x02D0, // updated 7.05
        PlaceFieldMarker = 0x0163, // updated 7.05
        PlaceFieldMarkerPreset = 0x0397, // updated 7.05
        EffectResult = 0x011F, // updated 7.05
        EventStart = 0x00BF, // updated 7.05
        EventFinish = 0x010D, // updated 7.05
        DesynthResult = 0x037B, // updated 7.05
        FreeCompanyInfo = 0x0325, // updated 7.05
        FreeCompanyDialog = 0x006D, // updated 7.05
        MarketBoardSearchResult = 0x0384, // updated 7.05
        MarketBoardItemListingCount = 0x0233, // updated 7.05
        MarketBoardItemListingHistory = 0x02BF, // updated 7.05
        MarketBoardItemListing = 0x03A3, // updated 7.05
        MarketBoardPurchase = 0x03DD, // updated 7.05
        UpdateInventorySlot = 0x02D3, // updated 7.05
        InventoryActionAck = 0x030F, // updated 7.05
        InventoryTransaction = 0x0197, // updated 7.05
        InventoryTransactionFinish = 0x01D8, // updated 7.05
        ResultDialog = 0x0177, // updated 7.05
        RetainerInformation = 0x0357, // updated 7.05
        NpcSpawn = 0x0359, // updated 7.05
        ItemMarketBoardInfo = 0x0309, // updated 7.05
        ObjectSpawn = 0x0119, // updated 7.05
        EffectResultBasic = 0x0149, // updated 7.05
        Effect = 0x01A6, // updated 7.05
        StatusEffectList = 0x0180, // updated 7.05
        StatusEffectList2 = 0x03DB, // updated 7.05
        StatusEffectList3 = 0x037D, // updated 7.05
        ActorGauge = 0x02A5, // updated 7.05
        CFNotify = 0x01E5, // updated 7.05
        SystemLogMessage = 0x0214, // updated 7.05
        AirshipTimers = 0x0164, // updated 7.05
        SubmarineTimers = 0x0363, // updated 7.05
        AirshipStatusList = 0x02B8, // updated 7.05
        AirshipStatus = 0x02AD, // updated 7.05
        AirshipExplorationResult = 0x0220, // updated 7.05
        SubmarineProgressionStatus = 0x0135, // updated 7.05
        SubmarineStatusList = 0x03BA, // updated 7.05
        SubmarineExplorationResult = 0x0122, // updated 7.05

        CraftingLog = 0x02D6, // updated 7.05
        GatheringLog = 0x0276, // updated 7.05

        ActorMove = 0x0372, // updated 7.05

        EventPlay = 0x026F, // updated 7.05
        EventPlay4 = 0x027B, // updated 7.05
        EventPlay8 = 0x0393, // updated 7.05
        EventPlay16 = 0x0141, // updated 7.05
        EventPlay32 = 0x02EB, // updated 7.05
        EventPlay64 = 0x00A2, // updated 7.05
        EventPlay128 = 0x018E, // updated 7.05
        EventPlay255 = 0x0294, // updated 7.05

        EnvironmentControl = 0x03D3, // updated 7.05
        IslandWorkshopSupplyDemand = 0x02B5, // updated 7.05
        Logout = 0x01B1, // updated 7.05
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x032C, // updated 7.05
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x026E, // updated 7.05
        MarketBoardPurchaseHandler = 0x0347, // updated 7.05
        InventoryModifyHandler = 0x0103, // updated 7.05
        UpdatePositionInstance = 0x03CE, // updated 7.0h
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