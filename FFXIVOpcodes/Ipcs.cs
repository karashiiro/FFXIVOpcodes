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
        PlayerSetup = 0x02C5, // updated 6.45
        UpdateHpMpTp = 0x02FA, // updated 6.45
        UpdateClassInfo = 0x03A5, // updated 6.45
        PlayerStats = 0x030C, // updated 6.45
        ActorControl = 0x0088, // updated 6.45
        ActorControlSelf = 0x02F7, // updated 6.45
        ActorControlTarget = 0x00A1, // updated 6.45
        Playtime = 0x02E5, // updated 6.45
        UpdateSearchInfo = 0x02CE, // updated 6.45
        ExamineSearchInfo = 0x006B, // updated 6.45
        Examine = 0x00ED, // updated 6.45
        ActorCast = 0x0330, // updated 6.45
        CurrencyCrystalInfo = 0x026A, // updated 6.45
        InitZone = 0x00D8, // updated 6.45
        WeatherChange = 0x00F0, // updated 6.45
        PlayerSpawn = 0x02D3, // updated 6.45
        ActorSetPos = 0x0196, // updated 6.45
        PrepareZoning = 0x03A8, // updated 6.45
        ContainerInfo = 0x0343, // updated 6.45
        ItemInfo = 0x0333, // updated 6.45
        PlaceFieldMarker = 0x0172, // updated 6.45
        PlaceFieldMarkerPreset = 0x00D3, // updated 6.45
        EffectResult = 0x00D2, // updated 6.45
        EventStart = 0x0133, // updated 6.45
        EventFinish = 0x0125, // updated 6.45
        DesynthResult = 0x01DF, // updated 6.45
        FreeCompanyInfo = 0x0231, // updated 6.45
        FreeCompanyDialog = 0x023E, // updated 6.45
        MarketBoardSearchResult = 0x02FD, // updated 6.45
        MarketBoardItemListingCount = 0x026B, // updated 6.45
        MarketBoardItemListingHistory = 0x03CB, // updated 6.45
        MarketBoardItemListing = 0x00EB, // updated 6.45
        MarketBoardPurchase = 0x017B, // updated 6.45
        UpdateInventorySlot = 0x013F, // updated 6.45
        InventoryActionAck = 0x00BD, // updated 6.45
        InventoryTransaction = 0x01D2, // updated 6.45
        InventoryTransactionFinish = 0x02EE, // updated 6.45
        ResultDialog = 0x00C2, // updated 6.45
        RetainerInformation = 0x02F8, // updated 6.45
        NpcSpawn = 0x0179, // updated 6.45
        ItemMarketBoardInfo = 0x0143, // updated 6.45
        ObjectSpawn = 0x0240, // updated 6.45
        EffectResultBasic = 0x034F, // updated 6.45
        Effect = 0x01E1, // updated 6.45
        StatusEffectList = 0x03CE, // updated 6.45
        StatusEffectList2 = 0x02B7, // updated 6.45
        StatusEffectList3 = 0x00EE, // updated 6.45
        ActorGauge = 0x0080, // updated 6.45
        CFNotify = 0x0126, // updated 6.45
        SystemLogMessage = 0x0100, // updated 6.45
        AirshipTimers = 0x0075, // updated 6.45
        SubmarineTimers = 0x00CD, // updated 6.45
        AirshipStatusList = 0x0391, // updated 6.45
        AirshipStatus = 0x007B, // updated 6.45
        AirshipExplorationResult = 0x0304, // updated 6.45
        SubmarineProgressionStatus = 0x022D, // updated 6.45
        SubmarineStatusList = 0x01BC, // updated 6.45
        SubmarineExplorationResult = 0x034A, // updated 6.45

        ActorMove = 0x01F1, // updated 6.45

        EventPlay = 0x014A, // updated 6.45
        EventPlay4 = 0x01A5, // updated 6.45
        EventPlay8 = 0x03B7, // updated 6.45
        EventPlay16 = 0x03C4, // updated 6.45
        EventPlay32 = 0x0108, // updated 6.45
        EventPlay64 = 0x03E4, // updated 6.45
        EventPlay128 = 0x0320, // updated 6.45
        EventPlay255 = 0x0151, // updated 6.45

        EnvironmentControl = 0x029F, // updated 6.45
        IslandWorkshopSupplyDemand = 0x01F4, // updated 6.45
        Logout = 0x0132, // updated 6.45
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x00A5, // updated 6.45
        ClientTrigger = 0x00DF, // updated 6.45
        ChatHandler = 0x031F, // updated 6.45
        SetSearchInfoHandler = 0x0129, // updated 6.45
        MarketBoardPurchaseHandler = 0x0066, // updated 6.45
        InventoryModifyHandler = 0x0140, // updated 6.45
        UpdatePositionInstance = 0x0095, // updated 6.45
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
