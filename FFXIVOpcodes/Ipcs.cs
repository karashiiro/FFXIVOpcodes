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
        PlayerSetup = 0x026F, // updated 7.35h
        UpdateHpMpTp = 0x03D1, // updated 7.35h
        UpdateClassInfo = 0x02CC, // updated 7.35h
        PlayerStats = 0x03AD, // updated 7.35h
        ActorControl = 0x00A1, // updated 7.35h
        ActorControlSelf = 0x03BD, // updated 7.35h
        ActorControlTarget = 0x01DD, // updated 7.35h
        Playtime = 0x00A4, // updated 7.35h
        UpdateSearchInfo = 0x00BB, // updated 7.35h
        ExamineSearchInfo = 0x01BA, // updated 7.35h
        Examine = 0x0349, // updated 7.35h
        ActorCast = 0x0355, // updated 7.35h
        CurrencyCrystalInfo = 0x0121, // updated 7.35h
        InitZone = 0x03A3, // updated 7.35h
        WeatherChange = 0x00E0, // updated 7.35h
        PlayerSpawn = 0x00E3, // updated 7.35h
        ActorSetPos = 0x034D, // updated 7.35h
        PrepareZoning = 0x02FA, // updated 7.35h
        ContainerInfo = 0x017C, // updated 7.35h
        ItemInfo = 0x00F6, // updated 7.35h
        PlaceFieldMarker = 0x00C0, // updated 7.35h
        PlaceFieldMarkerPreset = 0x0105, // updated 7.35h
        EffectResult = 0x0185, // updated 7.35h
        EventStart = 0x0107, // updated 7.35h
        EventFinish = 0x028A, // updated 7.35h
        DesynthResult = 0x032B, // updated 7.35h
        FreeCompanyInfo = 0x023B, // updated 7.35h
        FreeCompanyDialog = 0x0280, // updated 7.35h
        MarketBoardSearchResult = 0x025F, // updated 7.35h
        MarketBoardItemListingCount = 0x011E, // updated 7.35h
        MarketBoardItemListingHistory = 0x03C1, // updated 7.35h
        MarketBoardItemListing = 0x027D, // updated 7.35h
        MarketBoardPurchase = 0x025C, // updated 7.35h
        UpdateInventorySlot = 0x037B, // updated 7.35h
        InventoryActionAck = 0x02C3, // updated 7.35h
        InventoryTransaction = 0x00EB, // updated 7.35h
        InventoryTransactionFinish = 0x02A1, // updated 7.35h
        ResultDialog = 0x031D, // updated 7.35h
        RetainerInformation = 0x01B9, // updated 7.35h
        NpcSpawn = 0x02EA, // updated 7.35h
        ItemMarketBoardInfo = 0x01B2, // updated 7.35h
        ObjectSpawn = 0x01C0, // updated 7.35h
        EffectResultBasic = 0x02D9, // updated 7.35h
        Effect = 0x00F2, // updated 7.35h
        StatusEffectList = 0x03D4, // updated 7.35h
        StatusEffectList2 = 0x01BD, // updated 7.35h
        StatusEffectList3 = 0x038D, // updated 7.35h
        ActorGauge = 0x0301, // updated 7.35h
        CFNotify = 0x0387, // updated 7.35h
        SystemLogMessage = 0x039F, // updated 7.35h
        AirshipTimers = 0x02EE, // updated 7.35h
        SubmarineTimers = 0x01AD, // updated 7.35h
        AirshipStatusList = 0x0103, // updated 7.35h
        AirshipStatus = 0x0323, // updated 7.35h
        AirshipExplorationResult = 0x0239, // updated 7.35h
        SubmarineProgressionStatus = 0x0067, // updated 7.35h
        SubmarineStatusList = 0x026E, // updated 7.35h
        SubmarineExplorationResult = 0x006A, // updated 7.35h

        CraftingLog = 0x015B, // updated 7.35h
        GatheringLog = 0x0173, // updated 7.35h

        ActorMove = 0x013E, // updated 7.35h

        EventPlay = 0x0083, // updated 7.35h
        EventPlay4 = 0x0115, // updated 7.35h
        EventPlay8 = 0x02ED, // updated 7.35h
        EventPlay16 = 0x0262, // updated 7.35h
        EventPlay32 = 0x0371, // updated 7.35h
        EventPlay64 = 0x0380, // updated 7.35h
        EventPlay128 = 0x02D4, // updated 7.35h
        EventPlay255 = 0x0098, // updated 7.35h

        EnvironmentControl = 0x0226, // updated 7.35h
        IslandWorkshopSupplyDemand = 0x0325, // updated 7.35h
        Logout = 0x0360, // updated 7.35h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02F6, // updated 7.35h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0233, // updated 7.35h
        MarketBoardPurchaseHandler = 0x02E3, // updated 7.35h
        InventoryModifyHandler = 0x016B, // updated 7.35h
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