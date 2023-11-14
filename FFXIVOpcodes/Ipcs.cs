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
        PlayerSetup = 0x023D, // updated 6.51h
        UpdateHpMpTp = 0x00B2, // updated 6.51h
        UpdateClassInfo = 0x01D7, // updated 6.51h
        PlayerStats = 0x01B0, // updated 6.51h
        ActorControl = 0x03B6, // updated 6.51h
        ActorControlSelf = 0x00E2, // updated 6.51h
        ActorControlTarget = 0x0341, // updated 6.51h
        Playtime = 0x00F0, // updated 6.51h
        UpdateSearchInfo = 0x01CB, // updated 6.51h
        ExamineSearchInfo = 0x03E3, // updated 6.51h
        Examine = 0x01D1, // updated 6.51h
        ActorCast = 0x0107, // updated 6.51h
        CurrencyCrystalInfo = 0x0375, // updated 6.51h
        InitZone = 0x0180, // updated 6.51h
        WeatherChange = 0x02DC, // updated 6.51h
        PlayerSpawn = 0x007E, // updated 6.51h
        ActorSetPos = 0x00A8, // updated 6.51h
        PrepareZoning = 0x03B9, // updated 6.51h
        ContainerInfo = 0x0069, // updated 6.51h
        ItemInfo = 0x0270, // updated 6.51h
        PlaceFieldMarker = 0x0254, // updated 6.51h
        PlaceFieldMarkerPreset = 0x0072, // updated 6.51h
        EffectResult = 0x031E, // updated 6.51h
        EventStart = 0x03C0, // updated 6.51h
        EventFinish = 0x034D, // updated 6.51h
        DesynthResult = 0x00C1, // updated 6.51h
        FreeCompanyInfo = 0x0182, // updated 6.51h
        FreeCompanyDialog = 0x015B, // updated 6.51h
        MarketBoardSearchResult = 0x015E, // updated 6.51h
        MarketBoardItemListingCount = 0x02A5, // updated 6.51h
        MarketBoardItemListingHistory = 0x00E7, // updated 6.51h
        MarketBoardItemListing = 0x025A, // updated 6.51h
        MarketBoardPurchase = 0x0106, // updated 6.51h
        UpdateInventorySlot = 0x025C, // updated 6.51h
        InventoryActionAck = 0x0258, // updated 6.51h
        InventoryTransaction = 0x021B, // updated 6.51h
        InventoryTransactionFinish = 0x03BD, // updated 6.51h
        ResultDialog = 0x0352, // updated 6.51h
        RetainerInformation = 0x01EB, // updated 6.51h
        NpcSpawn = 0x023B, // updated 6.51h
        ItemMarketBoardInfo = 0x0256, // updated 6.51h
        ObjectSpawn = 0x0391, // updated 6.51h
        EffectResultBasic = 0x0301, // updated 6.51h
        Effect = 0x019F, // updated 6.51h
        StatusEffectList = 0x0131, // updated 6.51h
        StatusEffectList2 = 0x03BF, // updated 6.51h
        StatusEffectList3 = 0x01CC, // updated 6.51h
        ActorGauge = 0x02B4, // updated 6.51h
        CFNotify = 0x0318, // updated 6.51h
        SystemLogMessage = 0x032A, // updated 6.51h
        AirshipTimers = 0x0200, // updated 6.51h
        SubmarineTimers = 0x006F, // updated 6.51h
        AirshipStatusList = 0x019A, // updated 6.51h
        AirshipStatus = 0x010F, // updated 6.51h
        AirshipExplorationResult = 0x02BC, // updated 6.51h
        SubmarineProgressionStatus = 0x03B0, // updated 6.51h
        SubmarineStatusList = 0x0300, // updated 6.51h
        SubmarineExplorationResult = 0x00CF, // updated 6.51h

        ActorMove = 0x0223, // updated 6.51h

        EventPlay = 0x0331, // updated 6.51h
        EventPlay4 = 0x012C, // updated 6.51h
        EventPlay8 = 0x0217, // updated 6.51h
        EventPlay16 = 0x02E5, // updated 6.51h
        EventPlay32 = 0x0198, // updated 6.51h
        EventPlay64 = 0x013C, // updated 6.51h
        EventPlay128 = 0x0373, // updated 6.51h
        EventPlay255 = 0x02CD, // updated 6.51h

        EnvironmentControl = 0x0245, // updated 6.51h
        IslandWorkshopSupplyDemand = 0x0229, // updated 6.51h
        Logout = 0x0261, // updated 6.51h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0214, // updated 6.51h
        ClientTrigger = 0x011A, // updated 6.51h
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x00E6, // updated 6.51h
        MarketBoardPurchaseHandler = 0x012A, // updated 6.51h
        InventoryModifyHandler = 0x026F, // updated 6.51h
        UpdatePositionInstance = 0x0390, // updated 6.51h
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