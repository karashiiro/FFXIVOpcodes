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
        PlayerSetup = 0x0077, // updated 7.25h3
        UpdateHpMpTp = 0x02B7, // updated 7.25h3
        UpdateClassInfo = 0x0295, // updated 7.25h3
        PlayerStats = 0x013A, // updated 7.25h3
        ActorControl = 0x03E7, // updated 7.25h3
        ActorControlSelf = 0x016F, // updated 7.25h3
        ActorControlTarget = 0x018D, // updated 7.25h3
        Playtime = 0x01D0, // updated 7.25h3
        UpdateSearchInfo = 0x019F, // updated 7.25h3
        ExamineSearchInfo = 0x0370, // updated 7.25h3
        Examine = 0x00D0, // updated 7.25h3
        ActorCast = 0x0113, // updated 7.25h3
        CurrencyCrystalInfo = 0x0289, // updated 7.25h3
        InitZone = 0x0332, // updated 7.25h3
        WeatherChange = 0x0347, // updated 7.25h3
        PlayerSpawn = 0x01D5, // updated 7.25h3
        ActorSetPos = 0x0149, // updated 7.25h3
        PrepareZoning = 0x02FC, // updated 7.25h3
        ContainerInfo = 0x0189, // updated 7.25h3
        ItemInfo = 0x01E7, // updated 7.25h3
        PlaceFieldMarker = 0x022D, // updated 7.25h3
        PlaceFieldMarkerPreset = 0x0365, // updated 7.25h3
        EffectResult = 0x01AF, // updated 7.25h3
        EventStart = 0x01C7, // updated 7.25h3
        EventFinish = 0x00A6, // updated 7.25h3
        DesynthResult = 0x0275, // updated 7.25h3
        FreeCompanyInfo = 0x037C, // updated 7.25h3
        FreeCompanyDialog = 0x00BC, // updated 7.25h3
        MarketBoardSearchResult = 0x01ED, // updated 7.25h3
        MarketBoardItemListingCount = 0x039F, // updated 7.25h3
        MarketBoardItemListingHistory = 0x03C1, // updated 7.25h3
        MarketBoardItemListing = 0x00AC, // updated 7.25h3
        MarketBoardPurchase = 0x01B9, // updated 7.25h3
        UpdateInventorySlot = 0x01B3, // updated 7.25h3
        InventoryActionAck = 0x024D, // updated 7.25h3
        InventoryTransaction = 0x0353, // updated 7.25h3
        InventoryTransactionFinish = 0x0356, // updated 7.25h3
        ResultDialog = 0x02BD, // updated 7.25h3
        RetainerInformation = 0x01D1, // updated 7.25h3
        NpcSpawn = 0x0099, // updated 7.25h3
        ItemMarketBoardInfo = 0x006B, // updated 7.25h3
        ObjectSpawn = 0x01A9, // updated 7.25h3
        EffectResultBasic = 0x0081, // updated 7.25h3
        Effect = 0x0125, // updated 7.25h3
        StatusEffectList = 0x0209, // updated 7.25h3
        StatusEffectList2 = 0x023E, // updated 7.25h3
        StatusEffectList3 = 0x037E, // updated 7.25h3
        ActorGauge = 0x01A8, // updated 7.25h3
        CFNotify = 0x02DA, // updated 7.25h3
        SystemLogMessage = 0x01C8, // updated 7.25h3
        AirshipTimers = 0x0337, // updated 7.25h3
        SubmarineTimers = 0x010E, // updated 7.25h3
        AirshipStatusList = 0x0282, // updated 7.25h3
        AirshipStatus = 0x0218, // updated 7.25h3
        AirshipExplorationResult = 0x03E6, // updated 7.25h3
        SubmarineProgressionStatus = 0x0268, // updated 7.25h3
        SubmarineStatusList = 0x0157, // updated 7.25h3
        SubmarineExplorationResult = 0x01FD, // updated 7.25h3

        CraftingLog = 0x00D2, // updated 7.25h3
        GatheringLog = 0x0165, // updated 7.25h3

        ActorMove = 0x02BB, // updated 7.25h3

        EventPlay = 0x0206, // updated 7.25h3
        EventPlay4 = 0x0161, // updated 7.25h3
        EventPlay8 = 0x03BE, // updated 7.25h3
        EventPlay16 = 0x00D7, // updated 7.25h3
        EventPlay32 = 0x01AC, // updated 7.25h3
        EventPlay64 = 0x00AB, // updated 7.25h3
        EventPlay128 = 0x02F5, // updated 7.25h3
        EventPlay255 = 0x0115, // updated 7.25h3

        EnvironmentControl = 0x0305, // updated 7.25h3
        IslandWorkshopSupplyDemand = 0x01A2, // updated 7.25h3
        Logout = 0x03BD, // updated 7.25h3
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0320, // updated 7.25h3
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x02DD, // updated 7.25h3
        MarketBoardPurchaseHandler = 0x02F2, // updated 7.25h3
        InventoryModifyHandler = 0x008A, // updated 7.25h3
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