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
        PlayerSetup = 0x03C4, // updated 7.18
        UpdateHpMpTp = 0x0308, // updated 7.18
        UpdateClassInfo = 0x00F1, // updated 7.18
        PlayerStats = 0x02B2, // updated 7.18
        ActorControl = 0x034A, // updated 7.18
        ActorControlSelf = 0x01CD, // updated 7.18
        ActorControlTarget = 0x015C, // updated 7.18
        Playtime = 0x0144, // updated 7.18
        UpdateSearchInfo = 0x00A2, // updated 7.18
        ExamineSearchInfo = 0x0312, // updated 7.18
        Examine = 0x00CD, // updated 7.18
        ActorCast = 0x0357, // updated 7.18
        CurrencyCrystalInfo = 0x013E, // updated 7.18
        InitZone = 0x011F, // updated 7.18
        WeatherChange = 0x021D, // updated 7.18
        PlayerSpawn = 0x02FC, // updated 7.18
        ActorSetPos = 0x035B, // updated 7.18
        PrepareZoning = 0x02DF, // updated 7.18
        ContainerInfo = 0x0115, // updated 7.18
        ItemInfo = 0x01D7, // updated 7.18
        PlaceFieldMarker = 0x0078, // updated 7.18
        PlaceFieldMarkerPreset = 0x018B, // updated 7.18
        EffectResult = 0x03CA, // updated 7.18
        EventStart = 0x00A5, // updated 7.18
        EventFinish = 0x0248, // updated 7.18
        DesynthResult = 0x021B, // updated 7.18
        FreeCompanyInfo = 0x01F3, // updated 7.18
        FreeCompanyDialog = 0x039F, // updated 7.18
        MarketBoardSearchResult = 0x02EE, // updated 7.18
        MarketBoardItemListingCount = 0x014B, // updated 7.18
        MarketBoardItemListingHistory = 0x02E7, // updated 7.18
        MarketBoardItemListing = 0x0288, // updated 7.18
        MarketBoardPurchase = 0x0249, // updated 7.18
        UpdateInventorySlot = 0x0145, // updated 7.18
        InventoryActionAck = 0x0328, // updated 7.18
        InventoryTransaction = 0x038E, // updated 7.18
        InventoryTransactionFinish = 0x034E, // updated 7.18
        ResultDialog = 0x00D7, // updated 7.18
        RetainerInformation = 0x0370, // updated 7.18
        NpcSpawn = 0x0329, // updated 7.18
        ItemMarketBoardInfo = 0x026F, // updated 7.18
        ObjectSpawn = 0x00DF, // updated 7.18
        EffectResultBasic = 0x03A9, // updated 7.18
        Effect = 0x0208, // updated 7.18
        StatusEffectList = 0x02CC, // updated 7.18
        StatusEffectList2 = 0x0367, // updated 7.18
        StatusEffectList3 = 0x01F4, // updated 7.18
        ActorGauge = 0x0334, // updated 7.18
        CFNotify = 0x0081, // updated 7.18
        SystemLogMessage = 0x0092, // updated 7.18
        AirshipTimers = 0x03E1, // updated 7.18
        SubmarineTimers = 0x0283, // updated 7.18
        AirshipStatusList = 0x0339, // updated 7.18
        AirshipStatus = 0x009D, // updated 7.18
        AirshipExplorationResult = 0x0136, // updated 7.18
        SubmarineProgressionStatus = 0x01FF, // updated 7.18
        SubmarineStatusList = 0x02D5, // updated 7.18
        SubmarineExplorationResult = 0x0247, // updated 7.18

        CraftingLog = 0x030E, // updated 7.18
        GatheringLog = 0x00EB, // updated 7.18

        ActorMove = 0x0071, // updated 7.18

        EventPlay = 0x006C, // updated 7.18
        EventPlay4 = 0x02CF, // updated 7.18
        EventPlay8 = 0x0300, // updated 7.18
        EventPlay16 = 0x0194, // updated 7.18
        EventPlay32 = 0x0303, // updated 7.18
        EventPlay64 = 0x017E, // updated 7.18
        EventPlay128 = 0x03C2, // updated 7.18
        EventPlay255 = 0x01EA, // updated 7.18

        EnvironmentControl = 0x03A7, // updated 7.18
        IslandWorkshopSupplyDemand = 0x0073, // updated 7.18
        Logout = 0x0169, // updated 7.18
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0110, // updated 7.18
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x02A6, // updated 7.18
        MarketBoardPurchaseHandler = 0x0295, // updated 7.18
        InventoryModifyHandler = 0x0224, // updated 7.18
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