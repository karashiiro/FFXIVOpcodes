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
        PlayerSetup = 0x00D7, // updated 7.41
        UpdateHpMpTp = 0x00EA, // updated 7.41
        UpdateClassInfo = 0x02BB, // updated 7.41
        PlayerStats = 0x02F0, // updated 7.41
        ActorControl = 0x02C8, // updated 7.41
        ActorControlSelf = 0x02B3, // updated 7.41
        ActorControlTarget = 0x00E0, // updated 7.41
        Playtime = 0x0190, // updated 7.41
        UpdateSearchInfo = 0x01BC, // updated 7.41
        ExamineSearchInfo = 0x0153, // updated 7.41
        Examine = 0x00A6, // updated 7.41
        ActorCast = 0x01A1, // updated 7.41
        CurrencyCrystalInfo = 0x0262, // updated 7.41
        InitZone = 0x01A4, // updated 7.41
        WeatherChange = 0x0092, // updated 7.41
        PlayerSpawn = 0x013E, // updated 7.41
        ActorSetPos = 0x0202, // updated 7.41
        PrepareZoning = 0x0333, // updated 7.41
        ContainerInfo = 0x020D, // updated 7.41
        ItemInfo = 0x0094, // updated 7.41
        PlaceFieldMarker = 0x0386, // updated 7.41
        PlaceFieldMarkerPreset = 0x020A, // updated 7.41
        EffectResult = 0x0114, // updated 7.41
        EventStart = 0x02F8, // updated 7.41
        EventFinish = 0x0068, // updated 7.41
        DesynthResult = 0x01E5, // updated 7.41
        FreeCompanyInfo = 0x031B, // updated 7.41
        FreeCompanyDialog = 0x0096, // updated 7.41
        MarketBoardSearchResult = 0x0193, // updated 7.41
        MarketBoardItemListingCount = 0x0210, // updated 7.41
        MarketBoardItemListingHistory = 0x0377, // updated 7.41
        MarketBoardItemListing = 0x0069, // updated 7.41
        MarketBoardPurchase = 0x007A, // updated 7.41
        UpdateInventorySlot = 0x02CD, // updated 7.41
        InventoryActionAck = 0x039B, // updated 7.41
        InventoryTransaction = 0x01A9, // updated 7.41
        InventoryTransactionFinish = 0x034D, // updated 7.41
        ResultDialog = 0x033D, // updated 7.41
        RetainerInformation = 0x03D4, // updated 7.41
        NpcSpawn = 0x02E8, // updated 7.41
        ItemMarketBoardInfo = 0x008D, // updated 7.41
        ObjectSpawn = 0x011C, // updated 7.41
        EffectResultBasic = 0x01AB, // updated 7.41
        Effect = 0x01E7, // updated 7.41
        StatusEffectList = 0x031E, // updated 7.41
        StatusEffectList2 = 0x01FE, // updated 7.41
        StatusEffectList3 = 0x00EB, // updated 7.41
        ActorGauge = 0x01CC, // updated 7.41
        CFNotify = 0x024F, // updated 7.41
        SystemLogMessage = 0x035A, // updated 7.41
        AirshipTimers = 0x03C6, // updated 7.41
        SubmarineTimers = 0x0267, // updated 7.41
        AirshipStatusList = 0x0228, // updated 7.41
        AirshipStatus = 0x0176, // updated 7.41
        AirshipExplorationResult = 0x0115, // updated 7.41
        SubmarineProgressionStatus = 0x0093, // updated 7.41
        SubmarineStatusList = 0x028C, // updated 7.41
        SubmarineExplorationResult = 0x026D, // updated 7.41

        CraftingLog = 0x0216, // updated 7.41
        GatheringLog = 0x037C, // updated 7.41

        ActorMove = 0x013B, // updated 7.41

        EventPlay = 0x0352, // updated 7.41
        EventPlay4 = 0x019B, // updated 7.41
        EventPlay8 = 0x01CE, // updated 7.41
        EventPlay16 = 0x025A, // updated 7.41
        EventPlay32 = 0x0081, // updated 7.41
        EventPlay64 = 0x00C2, // updated 7.41
        EventPlay128 = 0x01C3, // updated 7.41
        EventPlay255 = 0x0337, // updated 7.41

        EnvironmentControl = 0x00B6, // updated 7.41
        IslandWorkshopSupplyDemand = 0x0160, // updated 7.41
        Logout = 0x02B6, // updated 7.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03A8, // updated 7.41
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x006D, // updated 7.41
        MarketBoardPurchaseHandler = 0x0374, // updated 7.41
        InventoryModifyHandler = 0x0233, // updated 7.41
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