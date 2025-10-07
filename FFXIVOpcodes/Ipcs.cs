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
        PlayerSetup = 0x02EE, // updated 7.35
        UpdateHpMpTp = 0x01B7, // updated 7.35
        UpdateClassInfo = 0x0277, // updated 7.35
        PlayerStats = 0x03CC, // updated 7.35
        ActorControl = 0x031B, // updated 7.35
        ActorControlSelf = 0x00F1, // updated 7.35
        ActorControlTarget = 0x02C5, // updated 7.35
        Playtime = 0x0229, // updated 7.35
        UpdateSearchInfo = 0x0372, // updated 7.35
        ExamineSearchInfo = 0x021B, // updated 7.35
        Examine = 0x0221, // updated 7.35
        ActorCast = 0x020F, // updated 7.35
        CurrencyCrystalInfo = 0x02AF, // updated 7.35
        InitZone = 0x0173, // updated 7.35
        WeatherChange = 0x009A, // updated 7.35
        PlayerSpawn = 0x00FA, // updated 7.35
        ActorSetPos = 0x021D, // updated 7.35
        PrepareZoning = 0x01D7, // updated 7.35
        ContainerInfo = 0x0370, // updated 7.35
        ItemInfo = 0x03A7, // updated 7.35
        PlaceFieldMarker = 0x03E3, // updated 7.35
        PlaceFieldMarkerPreset = 0x033B, // updated 7.35
        EffectResult = 0x00CB, // updated 7.35
        EventStart = 0x01E4, // updated 7.35
        EventFinish = 0x0356, // updated 7.35
        DesynthResult = 0x01C6, // updated 7.35
        FreeCompanyInfo = 0x02EB, // updated 7.35
        FreeCompanyDialog = 0x01F2, // updated 7.35
        MarketBoardSearchResult = 0x030C, // updated 7.35
        MarketBoardItemListingCount = 0x02A4, // updated 7.35
        MarketBoardItemListingHistory = 0x0144, // updated 7.35
        MarketBoardItemListing = 0x0098, // updated 7.35
        MarketBoardPurchase = 0x02EA, // updated 7.35
        UpdateInventorySlot = 0x0212, // updated 7.35
        InventoryActionAck = 0x0093, // updated 7.35
        InventoryTransaction = 0x0089, // updated 7.35
        InventoryTransactionFinish = 0x019B, // updated 7.35
        ResultDialog = 0x007E, // updated 7.35
        RetainerInformation = 0x03B4, // updated 7.35
        NpcSpawn = 0x023F, // updated 7.35
        ItemMarketBoardInfo = 0x0099, // updated 7.35
        ObjectSpawn = 0x010F, // updated 7.35
        EffectResultBasic = 0x037E, // updated 7.35
        Effect = 0x01DA, // updated 7.35
        StatusEffectList = 0x0068, // updated 7.35
        StatusEffectList2 = 0x03BE, // updated 7.35
        StatusEffectList3 = 0x02F8, // updated 7.35
        ActorGauge = 0x017A, // updated 7.35
        CFNotify = 0x02D8, // updated 7.35
        SystemLogMessage = 0x027C, // updated 7.35
        AirshipTimers = 0x02B4, // updated 7.35
        SubmarineTimers = 0x0346, // updated 7.35
        AirshipStatusList = 0x0172, // updated 7.35
        AirshipStatus = 0x02FE, // updated 7.35
        AirshipExplorationResult = 0x00C2, // updated 7.35
        SubmarineProgressionStatus = 0x00D1, // updated 7.35
        SubmarineStatusList = 0x0217, // updated 7.35
        SubmarineExplorationResult = 0x0219, // updated 7.35

        CraftingLog = 0x00A1, // updated 7.35
        GatheringLog = 0x017D, // updated 7.35

        ActorMove = 0x015F, // updated 7.35

        EventPlay = 0x00D7, // updated 7.35
        EventPlay4 = 0x00CA, // updated 7.35
        EventPlay8 = 0x03AF, // updated 7.35
        EventPlay16 = 0x0156, // updated 7.35
        EventPlay32 = 0x0095, // updated 7.35
        EventPlay64 = 0x0283, // updated 7.35
        EventPlay128 = 0x0141, // updated 7.35
        EventPlay255 = 0x0268, // updated 7.35

        EnvironmentControl = 0x0256, // updated 7.35
        IslandWorkshopSupplyDemand = 0x0319, // updated 7.35
        Logout = 0x03DA, // updated 7.35
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0188, // updated 7.35
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x020D, // updated 7.35
        MarketBoardPurchaseHandler = 0x039B, // updated 7.35
        InventoryModifyHandler = 0x0248, // updated 7.35
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