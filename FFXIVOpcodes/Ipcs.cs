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
        PlayerSetup = 0x025D, // updated 7.16
        UpdateHpMpTp = 0x0348, // updated 7.16
        UpdateClassInfo = 0x02E9, // updated 7.16
        PlayerStats = 0x008F, // updated 7.16
        ActorControl = 0x020B, // updated 7.16
        ActorControlSelf = 0x02D7, // updated 7.16
        ActorControlTarget = 0x00CB, // updated 7.16
        Playtime = 0x00E0, // updated 7.16
        UpdateSearchInfo = 0x0152, // updated 7.16
        ExamineSearchInfo = 0x02B4, // updated 7.16
        Examine = 0x00C6, // updated 7.16
        ActorCast = 0x0178, // updated 7.16
        CurrencyCrystalInfo = 0x03D8, // updated 7.16
        InitZone = 0x033E, // updated 7.16
        WeatherChange = 0x0358, // updated 7.16
        PlayerSpawn = 0x02AC, // updated 7.16
        ActorSetPos = 0x02B8, // updated 7.16
        PrepareZoning = 0x03DD, // updated 7.16
        ContainerInfo = 0x032D, // updated 7.16
        ItemInfo = 0x00FD, // updated 7.16
        PlaceFieldMarker = 0x02A3, // updated 7.16
        PlaceFieldMarkerPreset = 0x010B, // updated 7.16
        EffectResult = 0x03D7, // updated 7.16
        EventStart = 0x0154, // updated 7.16
        EventFinish = 0x038D, // updated 7.16
        DesynthResult = 0x006D, // updated 7.16
        FreeCompanyInfo = 0x0361, // updated 7.16
        FreeCompanyDialog = 0x0136, // updated 7.16
        MarketBoardSearchResult = 0x0356, // updated 7.16
        MarketBoardItemListingCount = 0x0271, // updated 7.16
        MarketBoardItemListingHistory = 0x035D, // updated 7.16
        MarketBoardItemListing = 0x02BE, // updated 7.16
        MarketBoardPurchase = 0x01C9, // updated 7.16
        UpdateInventorySlot = 0x0341, // updated 7.16
        InventoryActionAck = 0x03D4, // updated 7.16
        InventoryTransaction = 0x011E, // updated 7.16
        InventoryTransactionFinish = 0x02D5, // updated 7.16
        ResultDialog = 0x0326, // updated 7.16
        RetainerInformation = 0x00FE, // updated 7.16
        NpcSpawn = 0x02D6, // updated 7.16
        ItemMarketBoardInfo = 0x00CA, // updated 7.16
        ObjectSpawn = 0x01F5, // updated 7.16
        EffectResultBasic = 0x00A5, // updated 7.16
        Effect = 0x006F, // updated 7.16
        StatusEffectList = 0x011B, // updated 7.16
        StatusEffectList2 = 0x01EE, // updated 7.16
        StatusEffectList3 = 0x015D, // updated 7.16
        ActorGauge = 0x00CF, // updated 7.16
        CFNotify = 0x027D, // updated 7.16
        SystemLogMessage = 0x03A0, // updated 7.16
        AirshipTimers = 0x025C, // updated 7.16
        SubmarineTimers = 0x0371, // updated 7.16
        AirshipStatusList = 0x02E4, // updated 7.16
        AirshipStatus = 0x0140, // updated 7.16
        AirshipExplorationResult = 0x036D, // updated 7.16
        SubmarineProgressionStatus = 0x03AF, // updated 7.16
        SubmarineStatusList = 0x0365, // updated 7.16
        SubmarineExplorationResult = 0x0287, // updated 7.16

        CraftingLog = 0x01E5, // updated 7.16
        GatheringLog = 0x00BB, // updated 7.16

        ActorMove = 0x014E, // updated 7.16

        EventPlay = 0x024F, // updated 7.16
        EventPlay4 = 0x0335, // updated 7.16
        EventPlay8 = 0x0077, // updated 7.16
        EventPlay16 = 0x01A7, // updated 7.16
        EventPlay32 = 0x016D, // updated 7.16
        EventPlay64 = 0x0122, // updated 7.16
        EventPlay128 = 0x0248, // updated 7.16
        EventPlay255 = 0x01B1, // updated 7.16

        EnvironmentControl = 0x00F3, // updated 7.16
        IslandWorkshopSupplyDemand = 0x013E, // updated 7.16
        Logout = 0x0322, // updated 7.16
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02C3, // updated 7.16
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x03A6, // updated 7.16
        MarketBoardPurchaseHandler = 0x0174, // updated 7.16
        InventoryModifyHandler = 0x00B2, // updated 7.16
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