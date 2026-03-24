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
        PlayerSetup = 0x008E, // updated 7.45h2
        UpdateHpMpTp = 0x0264, // updated 7.45h2
        UpdateClassInfo = 0x00A1, // updated 7.45h2
        PlayerStats = 0x02AA, // updated 7.45h2
        ActorControl = 0x0311, // updated 7.45h2
        ActorControlSelf = 0x03C9, // updated 7.45h2
        ActorControlTarget = 0x0171, // updated 7.45h2
        Playtime = 0x016D, // updated 7.45h2
        UpdateSearchInfo = 0x017F, // updated 7.45h2
        ExamineSearchInfo = 0x01D3, // updated 7.45h2
        Examine = 0x0271, // updated 7.45h2
        ActorCast = 0x03B9, // updated 7.45h2
        CurrencyCrystalInfo = 0x02CF, // updated 7.45h2
        InitZone = 0x02F2, // updated 7.45h2
        WeatherChange = 0x0302, // updated 7.45h2
        PlayerSpawn = 0x0109, // updated 7.45h2
        ActorSetPos = 0x0085, // updated 7.45h2
        PrepareZoning = 0x01A0, // updated 7.45h2
        ContainerInfo = 0x027D, // updated 7.45h2
        ItemInfo = 0x0159, // updated 7.45h2
        PlaceFieldMarker = 0x0101, // updated 7.45h2
        PlaceFieldMarkerPreset = 0x023C, // updated 7.45h2
        EffectResult = 0x0186, // updated 7.45h2
        EventStart = 0x0181, // updated 7.45h2
        EventFinish = 0x01BF, // updated 7.45h2
        DesynthResult = 0x0276, // updated 7.45h2
        FreeCompanyInfo = 0x01AA, // updated 7.45h2
        FreeCompanyDialog = 0x03DE, // updated 7.45h2
        MarketBoardSearchResult = 0x0172, // updated 7.45h2
        MarketBoardItemListingCount = 0x006F, // updated 7.45h2
        MarketBoardItemListingHistory = 0x00F2, // updated 7.45h2
        MarketBoardItemListing = 0x022D, // updated 7.45h2
        MarketBoardPurchase = 0x0305, // updated 7.45h2
        UpdateInventorySlot = 0x02E0, // updated 7.45h2
        InventoryActionAck = 0x00AD, // updated 7.45h2
        InventoryTransaction = 0x02BB, // updated 7.45h2
        InventoryTransactionFinish = 0x02FD, // updated 7.45h2
        ResultDialog = 0x025F, // updated 7.45h2
        RetainerInformation = 0x0286, // updated 7.45h2
        NpcSpawn = 0x0328, // updated 7.45h2
        ItemMarketBoardInfo = 0x028A, // updated 7.45h2
        ObjectSpawn = 0x026E, // updated 7.45h2
        EffectResultBasic = 0x027C, // updated 7.45h2
        Effect = 0x02A4, // updated 7.45h2
        StatusEffectList = 0x0234, // updated 7.45h2
        StatusEffectList2 = 0x038C, // updated 7.45h2
        StatusEffectList3 = 0x0388, // updated 7.45h2
        ActorGauge = 0x03D8, // updated 7.45h2
        CFNotify = 0x01B4, // updated 7.45h2
        SystemLogMessage = 0x00D4, // updated 7.45h2
        AirshipTimers = 0x00C3, // updated 7.45h2
        SubmarineTimers = 0x007F, // updated 7.45h2
        AirshipStatusList = 0x02A7, // updated 7.45h2
        AirshipStatus = 0x0075, // updated 7.45h2
        AirshipExplorationResult = 0x02ED, // updated 7.45h2
        SubmarineProgressionStatus = 0x0236, // updated 7.45h2
        SubmarineStatusList = 0x02A5, // updated 7.45h2
        SubmarineExplorationResult = 0x028C, // updated 7.45h2

        CraftingLog = 0x0142, // updated 7.45h2
        GatheringLog = 0x0387, // updated 7.45h2

        ActorMove = 0x02B0, // updated 7.45h2

        EventPlay = 0x02FE, // updated 7.45h2
        EventPlay4 = 0x024C, // updated 7.45h2
        EventPlay8 = 0x0294, // updated 7.45h2
        EventPlay16 = 0x0340, // updated 7.45h2
        EventPlay32 = 0x0073, // updated 7.45h2
        EventPlay64 = 0x03C8, // updated 7.45h2
        EventPlay128 = 0x0331, // updated 7.45h2
        EventPlay255 = 0x016C, // updated 7.45h2

        EnvironmentControl = 0x02EA, // updated 7.45h2
        IslandWorkshopSupplyDemand = 0x009B, // updated 7.45h2
        Logout = 0x031E, // updated 7.45h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x010E, // updated 7.45h2
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x027A, // updated 7.45h2
        MarketBoardPurchaseHandler = 0x01D1, // updated 7.45h2
        InventoryModifyHandler = 0x0249, // updated 7.45h2
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