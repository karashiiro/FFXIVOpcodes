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
        PlayerSetup = 0x037D, // updated 7.3
        UpdateHpMpTp = 0x00EB, // updated 7.3
        UpdateClassInfo = 0x02D2, // updated 7.3
        PlayerStats = 0x007C, // updated 7.3
        ActorControl = 0x00E4, // updated 7.3
        ActorControlSelf = 0x0276, // updated 7.3
        ActorControlTarget = 0x039B, // updated 7.3
        Playtime = 0x01F7, // updated 7.3
        UpdateSearchInfo = 0x00A0, // updated 7.3
        ExamineSearchInfo = 0x0159, // updated 7.3
        Examine = 0x01F6, // updated 7.3
        ActorCast = 0x01BD, // updated 7.3
        CurrencyCrystalInfo = 0x0261, // updated 7.3
        InitZone = 0x016C, // updated 7.3
        WeatherChange = 0x030B, // updated 7.3
        PlayerSpawn = 0x01D0, // updated 7.3
        ActorSetPos = 0x01F8, // updated 7.3
        PrepareZoning = 0x010E, // updated 7.3
        ContainerInfo = 0x0104, // updated 7.3
        ItemInfo = 0x0283, // updated 7.3
        PlaceFieldMarker = 0x0317, // updated 7.3
        PlaceFieldMarkerPreset = 0x0388, // updated 7.3
        EffectResult = 0x02F2, // updated 7.3
        EventStart = 0x0095, // updated 7.3
        EventFinish = 0x0101, // updated 7.3
        DesynthResult = 0x03DF, // updated 7.3
        FreeCompanyInfo = 0x033C, // updated 7.3
        FreeCompanyDialog = 0x0113, // updated 7.3
        MarketBoardSearchResult = 0x03A2, // updated 7.3
        MarketBoardItemListingCount = 0x0303, // updated 7.3
        MarketBoardItemListingHistory = 0x02BC, // updated 7.3
        MarketBoardItemListing = 0x0381, // updated 7.3
        MarketBoardPurchase = 0x01AE, // updated 7.3
        UpdateInventorySlot = 0x00C4, // updated 7.3
        InventoryActionAck = 0x00D0, // updated 7.3
        InventoryTransaction = 0x0222, // updated 7.3
        InventoryTransactionFinish = 0x02B8, // updated 7.3
        ResultDialog = 0x033B, // updated 7.3
        RetainerInformation = 0x0185, // updated 7.3
        NpcSpawn = 0x022D, // updated 7.3
        ItemMarketBoardInfo = 0x0335, // updated 7.3
        ObjectSpawn = 0x00C5, // updated 7.3
        EffectResultBasic = 0x00C2, // updated 7.3
        Effect = 0x0301, // updated 7.3
        StatusEffectList = 0x0397, // updated 7.3
        StatusEffectList2 = 0x02C9, // updated 7.3
        StatusEffectList3 = 0x0292, // updated 7.3
        ActorGauge = 0x0287, // updated 7.3
        CFNotify = 0x01C4, // updated 7.3
        SystemLogMessage = 0x037A, // updated 7.3
        AirshipTimers = 0x0139, // updated 7.3
        SubmarineTimers = 0x03D1, // updated 7.3
        AirshipStatusList = 0x0393, // updated 7.3
        AirshipStatus = 0x01D2, // updated 7.3
        AirshipExplorationResult = 0x0085, // updated 7.3
        SubmarineProgressionStatus = 0x02F6, // updated 7.3
        SubmarineStatusList = 0x02F1, // updated 7.3
        SubmarineExplorationResult = 0x01AD, // updated 7.3

        CraftingLog = 0x0177, // updated 7.3
        GatheringLog = 0x032C, // updated 7.3

        ActorMove = 0x02E4, // updated 7.3

        EventPlay = 0x0191, // updated 7.3
        EventPlay4 = 0x00B3, // updated 7.3
        EventPlay8 = 0x01F9, // updated 7.3
        EventPlay16 = 0x01E4, // updated 7.3
        EventPlay32 = 0x0378, // updated 7.3
        EventPlay64 = 0x016E, // updated 7.3
        EventPlay128 = 0x01A3, // updated 7.3
        EventPlay255 = 0x020F, // updated 7.3

        EnvironmentControl = 0x00BE, // updated 7.3
        IslandWorkshopSupplyDemand = 0x0138, // updated 7.3
        Logout = 0x0156, // updated 7.3
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0206, // updated 7.3
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0160, // updated 7.3
        MarketBoardPurchaseHandler = 0x0244, // updated 7.3
        InventoryModifyHandler = 0x03BD, // updated 7.3
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