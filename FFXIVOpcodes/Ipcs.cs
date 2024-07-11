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
        PlayerSetup = 0x00D7, // updated 7.0h
        UpdateHpMpTp = 0x02E6, // updated 7.0h
        UpdateClassInfo = 0x0172, // updated 7.0h
        PlayerStats = 0x0286, // updated 7.0h
        ActorControl = 0x02E3, // updated 7.0h
        ActorControlSelf = 0x0193, // updated 7.0h
        ActorControlTarget = 0x034A, // updated 7.0h
        Playtime = 0x00A4, // updated 7.0h
        UpdateSearchInfo = 0x01CC, // updated 7.0h
        ExamineSearchInfo = 0x022A, // updated 7.0h
        Examine = 0x0102, // updated 7.0h
        ActorCast = 0x03B1, // updated 7.0h
        CurrencyCrystalInfo = 0x025C, // updated 7.0h
        InitZone = 0x0364, // updated 7.0h
        WeatherChange = 0x01CE, // updated 7.0h
        PlayerSpawn = 0x0197, // updated 7.0h
        ActorSetPos = 0x0294, // updated 7.0h
        PrepareZoning = 0x00D9, // updated 7.0h
        ContainerInfo = 0x02B9, // updated 7.0h
        ItemInfo = 0x02D7, // updated 7.0h
        PlaceFieldMarker = 0x028D, // updated 7.0h
        PlaceFieldMarkerPreset = 0x0374, // updated 7.0h
        EffectResult = 0x008F, // updated 7.0h
        EventStart = 0x00A8, // updated 7.0h
        EventFinish = 0x019C, // updated 7.0h
        DesynthResult = 0x02FC, // updated 7.0h
        FreeCompanyInfo = 0x01C5, // updated 7.0h
        FreeCompanyDialog = 0x0324, // updated 7.0h
        MarketBoardSearchResult = 0x0321, // updated 7.0h
        MarketBoardItemListingCount = 0x018E, // updated 7.0h
        MarketBoardItemListingHistory = 0x01D7, // updated 7.0h
        MarketBoardItemListing = 0x02DD, // updated 7.0h
        MarketBoardPurchase = 0x0130, // updated 7.0h
        UpdateInventorySlot = 0x02C7, // updated 7.0h
        InventoryActionAck = 0x0381, // updated 7.0h
        InventoryTransaction = 0x02ED, // updated 7.0h
        InventoryTransactionFinish = 0x00C3, // updated 7.0h
        ResultDialog = 0x02D9, // updated 7.0h
        RetainerInformation = 0x02AC, // updated 7.0h
        NpcSpawn = 0x03CE, // updated 7.0h
        ItemMarketBoardInfo = 0x035E, // updated 7.0h
        ObjectSpawn = 0x013F, // updated 7.0h
        EffectResultBasic = 0x0131, // updated 7.0h
        Effect = 0x032B, // updated 7.0h
        StatusEffectList = 0x0380, // updated 7.0h
        StatusEffectList2 = 0x03D0, // updated 7.0h
        StatusEffectList3 = 0x0302, // updated 7.0h
        ActorGauge = 0x01E5, // updated 7.0h
        CFNotify = 0x0153, // updated 7.0h
        SystemLogMessage = 0x0084, // updated 7.0h
        AirshipTimers = 0x02E2, // updated 7.0h
        SubmarineTimers = 0x00D6, // updated 7.0h
        AirshipStatusList = 0x03B9, // updated 7.0h
        AirshipStatus = 0x036C, // updated 7.0h
        AirshipExplorationResult = 0x027A, // updated 7.0h
        SubmarineProgressionStatus = 0x0318, // updated 7.0h
        SubmarineStatusList = 0x008B, // updated 7.0h
        SubmarineExplorationResult = 0x0086, // updated 7.0h

        CraftingLog = 0x00B2, // updated 7.0h
        GatheringLog = 0x033A, // updated 7.0h

        ActorMove = 0x015F, // updated 7.0h

        EventPlay = 0x034D, // updated 7.0h
        EventPlay4 = 0x0224, // updated 7.0h
        EventPlay8 = 0x03DE, // updated 7.0h
        EventPlay16 = 0x02D1, // updated 7.0h
        EventPlay32 = 0x01CA, // updated 7.0h
        EventPlay64 = 0x014F, // updated 7.0h
        EventPlay128 = 0x0245, // updated 7.0h
        EventPlay255 = 0x02B8, // updated 7.0h

        EnvironmentControl = 0x0151, // updated 7.0h
        IslandWorkshopSupplyDemand = 0x0139, // updated 7.0h
        Logout = 0x03A5, // updated 7.0h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0165, // updated 7.0h
        ClientTrigger = 0x0318, // updated 7.0
        SetSearchInfoHandler = 0x03AE, // updated 7.0h
        MarketBoardPurchaseHandler = 0x00C4, // updated 7.0h
        InventoryModifyHandler = 0x0156, // updated 7.0h
        UpdatePositionInstance = 0x0300, // updated 7.0
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