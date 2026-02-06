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
        PlayerSetup = 0x0141, // updated 7.41h
        UpdateHpMpTp = 0x015D, // updated 7.41h
        UpdateClassInfo = 0x0157, // updated 7.41h
        PlayerStats = 0x00BE, // updated 7.41h
        ActorControl = 0x01EC, // updated 7.41h
        ActorControlSelf = 0x0162, // updated 7.41h
        ActorControlTarget = 0x0223, // updated 7.41h
        Playtime = 0x02DE, // updated 7.41h
        UpdateSearchInfo = 0x0254, // updated 7.41h
        ExamineSearchInfo = 0x0067, // updated 7.41h
        Examine = 0x018D, // updated 7.41h
        ActorCast = 0x03AD, // updated 7.41h
        CurrencyCrystalInfo = 0x0331, // updated 7.41h
        InitZone = 0x02C0, // updated 7.41h
        WeatherChange = 0x00A7, // updated 7.41h
        PlayerSpawn = 0x0221, // updated 7.41h
        ActorSetPos = 0x00B2, // updated 7.41h
        PrepareZoning = 0x0140, // updated 7.41h
        ContainerInfo = 0x007E, // updated 7.41h
        ItemInfo = 0x0211, // updated 7.41h
        PlaceFieldMarker = 0x0216, // updated 7.41h
        PlaceFieldMarkerPreset = 0x019C, // updated 7.41h
        EffectResult = 0x00F4, // updated 7.41h
        EventStart = 0x0391, // updated 7.41h
        EventFinish = 0x01B9, // updated 7.41h
        DesynthResult = 0x0307, // updated 7.41h
        FreeCompanyInfo = 0x00EB, // updated 7.41h
        FreeCompanyDialog = 0x0373, // updated 7.41h
        MarketBoardSearchResult = 0x02D7, // updated 7.41h
        MarketBoardItemListingCount = 0x0390, // updated 7.41h
        MarketBoardItemListingHistory = 0x0073, // updated 7.41h
        MarketBoardItemListing = 0x016E, // updated 7.41h
        MarketBoardPurchase = 0x0153, // updated 7.41h
        UpdateInventorySlot = 0x01F4, // updated 7.41h
        InventoryActionAck = 0x026E, // updated 7.41h
        InventoryTransaction = 0x0240, // updated 7.41h
        InventoryTransactionFinish = 0x01E6, // updated 7.41h
        ResultDialog = 0x0271, // updated 7.41h
        RetainerInformation = 0x037A, // updated 7.41h
        NpcSpawn = 0x0197, // updated 7.41h
        ItemMarketBoardInfo = 0x0084, // updated 7.41h
        ObjectSpawn = 0x009D, // updated 7.41h
        EffectResultBasic = 0x0133, // updated 7.41h
        Effect = 0x01CC, // updated 7.41h
        StatusEffectList = 0x0366, // updated 7.41h
        StatusEffectList2 = 0x0298, // updated 7.41h
        StatusEffectList3 = 0x024E, // updated 7.41h
        ActorGauge = 0x02AF, // updated 7.41h
        CFNotify = 0x0215, // updated 7.41h
        SystemLogMessage = 0x0266, // updated 7.41h
        AirshipTimers = 0x0345, // updated 7.41h
        SubmarineTimers = 0x02E4, // updated 7.41h
        AirshipStatusList = 0x035D, // updated 7.41h
        AirshipStatus = 0x02BA, // updated 7.41h
        AirshipExplorationResult = 0x01C6, // updated 7.41h
        SubmarineProgressionStatus = 0x03C9, // updated 7.41h
        SubmarineStatusList = 0x00BC, // updated 7.41h
        SubmarineExplorationResult = 0x010B, // updated 7.41h

        CraftingLog = 0x01BD, // updated 7.41h
        GatheringLog = 0x017E, // updated 7.41h

        ActorMove = 0x0192, // updated 7.41h

        EventPlay = 0x0226, // updated 7.41h
        EventPlay4 = 0x0178, // updated 7.41h
        EventPlay8 = 0x030D, // updated 7.41h
        EventPlay16 = 0x021C, // updated 7.41h
        EventPlay32 = 0x0276, // updated 7.41h
        EventPlay64 = 0x00FE, // updated 7.41h
        EventPlay128 = 0x012D, // updated 7.41h
        EventPlay255 = 0x01E3, // updated 7.41h

        EnvironmentControl = 0x031C, // updated 7.41h
        IslandWorkshopSupplyDemand = 0x013B, // updated 7.41h
        Logout = 0x038A, // updated 7.41h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x012F, // updated 7.41h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x035C, // updated 7.41h
        MarketBoardPurchaseHandler = 0x0201, // updated 7.41h
        InventoryModifyHandler = 0x01FF, // updated 7.41h
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