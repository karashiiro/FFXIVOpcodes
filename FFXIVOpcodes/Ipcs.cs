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
        PlayerSetup = 0x00C9, // updated 7.05h
        UpdateHpMpTp = 0x0262, // updated 7.05h
        UpdateClassInfo = 0x013D, // updated 7.05h
        PlayerStats = 0x0270, // updated 7.05h
        ActorControl = 0x01F2, // updated 7.05h
        ActorControlSelf = 0x0205, // updated 7.05h
        ActorControlTarget = 0x0294, // updated 7.05h
        Playtime = 0x03E4, // updated 7.05h
        UpdateSearchInfo = 0x030D, // updated 7.05h
        ExamineSearchInfo = 0x02BA, // updated 7.05h
        Examine = 0x0273, // updated 7.05h
        ActorCast = 0x00F6, // updated 7.05h
        CurrencyCrystalInfo = 0x0288, // updated 7.05h
        InitZone = 0x01E8, // updated 7.05h
        WeatherChange = 0x00B9, // updated 7.05h
        PlayerSpawn = 0x02C4, // updated 7.05h
        ActorSetPos = 0x032B, // updated 7.05h
        PrepareZoning = 0x02A4, // updated 7.05h
        ContainerInfo = 0x00F8, // updated 7.05h
        ItemInfo = 0x0258, // updated 7.05h
        PlaceFieldMarker = 0x03B6, // updated 7.05h
        PlaceFieldMarkerPreset = 0x02E9, // updated 7.05h
        EffectResult = 0x03DC, // updated 7.05h
        EventStart = 0x01BA, // updated 7.05h
        EventFinish = 0x0070, // updated 7.05h
        DesynthResult = 0x00FE, // updated 7.05h
        FreeCompanyInfo = 0x0093, // updated 7.05h
        FreeCompanyDialog = 0x0066, // updated 7.05h
        MarketBoardSearchResult = 0x019F, // updated 7.05h
        MarketBoardItemListingCount = 0x03BD, // updated 7.05h
        MarketBoardItemListingHistory = 0x0351, // updated 7.05h
        MarketBoardItemListing = 0x030C, // updated 7.05h
        MarketBoardPurchase = 0x02E5, // updated 7.05h
        UpdateInventorySlot = 0x00E4, // updated 7.05h
        InventoryActionAck = 0x0145, // updated 7.05h
        InventoryTransaction = 0x01E6, // updated 7.05h
        InventoryTransactionFinish = 0x0234, // updated 7.05h
        ResultDialog = 0x03C5, // updated 7.05h
        RetainerInformation = 0x0390, // updated 7.05h
        NpcSpawn = 0x0313, // updated 7.05h
        ItemMarketBoardInfo = 0x0329, // updated 7.05h
        ObjectSpawn = 0x029C, // updated 7.05h
        EffectResultBasic = 0x038E, // updated 7.05h
        Effect = 0x016F, // updated 7.05h
        StatusEffectList = 0x015F, // updated 7.05h
        StatusEffectList2 = 0x00B3, // updated 7.05h
        StatusEffectList3 = 0x018A, // updated 7.05h
        ActorGauge = 0x00A7, // updated 7.05h
        CFNotify = 0x0182, // updated 7.05h
        SystemLogMessage = 0x03E2, // updated 7.05h
        AirshipTimers = 0x03D5, // updated 7.05h
        SubmarineTimers = 0x0349, // updated 7.05h
        AirshipStatusList = 0x02F4, // updated 7.05h
        AirshipStatus = 0x01F6, // updated 7.05h
        AirshipExplorationResult = 0x0277, // updated 7.05h
        SubmarineProgressionStatus = 0x0204, // updated 7.05h
        SubmarineStatusList = 0x006E, // updated 7.05h
        SubmarineExplorationResult = 0x00F0, // updated 7.05h

        CraftingLog = 0x010B, // updated 7.05h
        GatheringLog = 0x023A, // updated 7.05h

        ActorMove = 0x01AA, // updated 7.05h

        EventPlay = 0x0301, // updated 7.05h
        EventPlay4 = 0x024F, // updated 7.05h
        EventPlay8 = 0x0327, // updated 7.05h
        EventPlay16 = 0x00E9, // updated 7.05h
        EventPlay32 = 0x0109, // updated 7.05h
        EventPlay64 = 0x00CF, // updated 7.05h
        EventPlay128 = 0x024D, // updated 7.05h
        EventPlay255 = 0x00D8, // updated 7.05h

        EnvironmentControl = 0x03B5, // updated 7.05h
        IslandWorkshopSupplyDemand = 0x02D5, // updated 7.05h
        Logout = 0x0353, // updated 7.05h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x00D7, // updated 7.05h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x020A, // updated 7.05h
        MarketBoardPurchaseHandler = 0x02A9, // updated 7.05h
        InventoryModifyHandler = 0x03C9, // updated 7.05h
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