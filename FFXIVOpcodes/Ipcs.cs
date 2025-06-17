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
        PlayerSetup = 0x031D, // updated 7.25h
        UpdateHpMpTp = 0x0242, // updated 7.25h
        UpdateClassInfo = 0x0256, // updated 7.25h
        PlayerStats = 0x035D, // updated 7.25h
        ActorControl = 0x028C, // updated 7.25h
        ActorControlSelf = 0x0272, // updated 7.25h
        ActorControlTarget = 0x0208, // updated 7.25h
        Playtime = 0x02C1, // updated 7.25h
        UpdateSearchInfo = 0x03B9, // updated 7.25h
        ExamineSearchInfo = 0x0147, // updated 7.25h
        Examine = 0x0083, // updated 7.25h
        ActorCast = 0x0214, // updated 7.25h
        CurrencyCrystalInfo = 0x0085, // updated 7.25h
        InitZone = 0x00CE, // updated 7.25h
        WeatherChange = 0x0353, // updated 7.25h
        PlayerSpawn = 0x0266, // updated 7.25h
        ActorSetPos = 0x0128, // updated 7.25h
        PrepareZoning = 0x02E9, // updated 7.25h
        ContainerInfo = 0x02AE, // updated 7.25h
        ItemInfo = 0x01F3, // updated 7.25h
        PlaceFieldMarker = 0x025D, // updated 7.25h
        PlaceFieldMarkerPreset = 0x0245, // updated 7.25h
        EffectResult = 0x015B, // updated 7.25h
        EventStart = 0x03A2, // updated 7.25h
        EventFinish = 0x01A4, // updated 7.25h
        DesynthResult = 0x01C7, // updated 7.25h
        FreeCompanyInfo = 0x02D9, // updated 7.25h
        FreeCompanyDialog = 0x01B9, // updated 7.25h
        MarketBoardSearchResult = 0x0159, // updated 7.25h
        MarketBoardItemListingCount = 0x0268, // updated 7.25h
        MarketBoardItemListingHistory = 0x0297, // updated 7.25h
        MarketBoardItemListing = 0x0241, // updated 7.25h
        MarketBoardPurchase = 0x023B, // updated 7.25h
        UpdateInventorySlot = 0x025E, // updated 7.25h
        InventoryActionAck = 0x02A5, // updated 7.25h
        InventoryTransaction = 0x02D1, // updated 7.25h
        InventoryTransactionFinish = 0x02D3, // updated 7.25h
        ResultDialog = 0x03C3, // updated 7.25h
        RetainerInformation = 0x0084, // updated 7.25h
        NpcSpawn = 0x03BF, // updated 7.25h
        ItemMarketBoardInfo = 0x02F3, // updated 7.25h
        ObjectSpawn = 0x0279, // updated 7.25h
        EffectResultBasic = 0x02BF, // updated 7.25h
        Effect = 0x01E1, // updated 7.25h
        StatusEffectList = 0x0086, // updated 7.25h
        StatusEffectList2 = 0x008C, // updated 7.25h
        StatusEffectList3 = 0x024B, // updated 7.25h
        ActorGauge = 0x0310, // updated 7.25h
        CFNotify = 0x03BE, // updated 7.25h
        SystemLogMessage = 0x0106, // updated 7.25h
        AirshipTimers = 0x0255, // updated 7.25h
        SubmarineTimers = 0x0201, // updated 7.25h
        AirshipStatusList = 0x0309, // updated 7.25h
        AirshipStatus = 0x02C8, // updated 7.25h
        AirshipExplorationResult = 0x03BD, // updated 7.25h
        SubmarineProgressionStatus = 0x02B6, // updated 7.25h
        SubmarineStatusList = 0x00B4, // updated 7.25h
        SubmarineExplorationResult = 0x019F, // updated 7.25h

        CraftingLog = 0x01CA, // updated 7.25h
        GatheringLog = 0x00D4, // updated 7.25h

        ActorMove = 0x00B8, // updated 7.25h

        EventPlay = 0x0335, // updated 7.25h
        EventPlay4 = 0x0341, // updated 7.25h
        EventPlay8 = 0x00F6, // updated 7.25h
        EventPlay16 = 0x023D, // updated 7.25h
        EventPlay32 = 0x0307, // updated 7.25h
        EventPlay64 = 0x013B, // updated 7.25h
        EventPlay128 = 0x01EB, // updated 7.25h
        EventPlay255 = 0x03B0, // updated 7.25h

        EnvironmentControl = 0x01D8, // updated 7.25h
        IslandWorkshopSupplyDemand = 0x00A4, // updated 7.25h
        Logout = 0x0145, // updated 7.25h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03AC, // updated 7.25h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x008E, // updated 7.25h
        MarketBoardPurchaseHandler = 0x01A1, // updated 7.25h
        InventoryModifyHandler = 0x01C4, // updated 7.25h
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