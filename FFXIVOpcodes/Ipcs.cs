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
        PlayerSetup = 0x0095, // updated 6.51
        UpdateHpMpTp = 0x0353, // updated 6.51
        UpdateClassInfo = 0x02EA, // updated 6.51
        PlayerStats = 0x0087, // updated 6.51
        ActorControl = 0x0342, // updated 6.51
        ActorControlSelf = 0x00E4, // updated 6.51
        ActorControlTarget = 0x01D7, // updated 6.51
        Playtime = 0x027B, // updated 6.51
        UpdateSearchInfo = 0x0110, // updated 6.51
        ExamineSearchInfo = 0x0150, // updated 6.51
        Examine = 0x0153, // updated 6.51
        ActorCast = 0x02D2, // updated 6.51
        CurrencyCrystalInfo = 0x01E1, // updated 6.51
        InitZone = 0x0243, // updated 6.51
        WeatherChange = 0x0397, // updated 6.51
        PlayerSpawn = 0x0167, // updated 6.51
        ActorSetPos = 0x028F, // updated 6.51
        PrepareZoning = 0x02C3, // updated 6.51
        ContainerInfo = 0x019D, // updated 6.51
        ItemInfo = 0x008A, // updated 6.51
        PlaceFieldMarker = 0x02A1, // updated 6.51
        PlaceFieldMarkerPreset = 0x02ED, // updated 6.51
        EffectResult = 0x01FC, // updated 6.51
        EventStart = 0x00CD, // updated 6.51
        EventFinish = 0x01BE, // updated 6.51
        DesynthResult = 0x030F, // updated 6.51
        FreeCompanyInfo = 0x01F6, // updated 6.51
        FreeCompanyDialog = 0x0093, // updated 6.51
        MarketBoardSearchResult = 0x016E, // updated 6.51
        MarketBoardItemListingCount = 0x02B6, // updated 6.51
        MarketBoardItemListingHistory = 0x0253, // updated 6.51
        MarketBoardItemListing = 0x0376, // updated 6.51
        MarketBoardPurchase = 0x02AF, // updated 6.51
        UpdateInventorySlot = 0x0295, // updated 6.51
        InventoryActionAck = 0x02CD, // updated 6.51
        InventoryTransaction = 0x02FD, // updated 6.51
        InventoryTransactionFinish = 0x02D5, // updated 6.51
        ResultDialog = 0x03E2, // updated 6.51
        RetainerInformation = 0x00B3, // updated 6.51
        NpcSpawn = 0x02BB, // updated 6.51
        ItemMarketBoardInfo = 0x0088, // updated 6.51
        ObjectSpawn = 0x00DD, // updated 6.51
        EffectResultBasic = 0x033E, // updated 6.51
        Effect = 0x00C0, // updated 6.51
        StatusEffectList = 0x0163, // updated 6.51
        StatusEffectList2 = 0x03B0, // updated 6.51
        StatusEffectList3 = 0x02D0, // updated 6.51
        ActorGauge = 0x036C, // updated 6.51
        CFNotify = 0x030D, // updated 6.51
        SystemLogMessage = 0x03D7, // updated 6.51
        AirshipTimers = 0x00AB, // updated 6.51
        SubmarineTimers = 0x03C2, // updated 6.51
        AirshipStatusList = 0x01CD, // updated 6.51
        AirshipStatus = 0x025F, // updated 6.51
        AirshipExplorationResult = 0x01FD, // updated 6.51
        SubmarineProgressionStatus = 0x027C, // updated 6.51
        SubmarineStatusList = 0x01A2, // updated 6.51
        SubmarineExplorationResult = 0x02F7, // updated 6.51

        ActorMove = 0x02F9, // updated 6.51

        EventPlay = 0x022E, // updated 6.51
        EventPlay4 = 0x034A, // updated 6.51
        EventPlay8 = 0x02E8, // updated 6.51
        EventPlay16 = 0x00DB, // updated 6.51
        EventPlay32 = 0x00A5, // updated 6.51
        EventPlay64 = 0x0147, // updated 6.51
        EventPlay128 = 0x0197, // updated 6.51
        EventPlay255 = 0x00A6, // updated 6.51

        EnvironmentControl = 0x014B, // updated 6.51
        IslandWorkshopSupplyDemand = 0x0127, // updated 6.51
        Logout = 0x0066, // updated 6.51
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0374, // updated 6.51
        ClientTrigger = 0x008F, // updated 6.51
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x02AE, // updated 6.51
        MarketBoardPurchaseHandler = 0x01BF, // updated 6.51
        InventoryModifyHandler = 0x039E, // updated 6.51 (Base offset: 0x03A5)
        UpdatePositionInstance = 0x02D7, // updated 6.51
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