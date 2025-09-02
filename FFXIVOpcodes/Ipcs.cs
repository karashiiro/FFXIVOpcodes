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
        PlayerSetup = 0x0220, // updated 7.31
        UpdateHpMpTp = 0x00CE, // updated 7.31
        UpdateClassInfo = 0x0250, // updated 7.31
        PlayerStats = 0x027B, // updated 7.31
        ActorControl = 0x0202, // updated 7.31
        ActorControlSelf = 0x015B, // updated 7.31
        ActorControlTarget = 0x035C, // updated 7.31
        Playtime = 0x0271, // updated 7.31
        UpdateSearchInfo = 0x0187, // updated 7.31
        ExamineSearchInfo = 0x01FF, // updated 7.31
        Examine = 0x02A5, // updated 7.31
        ActorCast = 0x038A, // updated 7.31
        CurrencyCrystalInfo = 0x02D1, // updated 7.31
        InitZone = 0x02D0, // updated 7.31
        WeatherChange = 0x029C, // updated 7.31
        PlayerSpawn = 0x01B3, // updated 7.31
        ActorSetPos = 0x012F, // updated 7.31
        PrepareZoning = 0x02C8, // updated 7.31
        ContainerInfo = 0x017B, // updated 7.31
        ItemInfo = 0x01DD, // updated 7.31
        PlaceFieldMarker = 0x0366, // updated 7.31
        PlaceFieldMarkerPreset = 0x0115, // updated 7.31
        EffectResult = 0x0105, // updated 7.31
        EventStart = 0x019D, // updated 7.31
        EventFinish = 0x031E, // updated 7.31
        DesynthResult = 0x0277, // updated 7.31
        FreeCompanyInfo = 0x0310, // updated 7.31
        FreeCompanyDialog = 0x0095, // updated 7.31
        MarketBoardSearchResult = 0x02A8, // updated 7.31
        MarketBoardItemListingCount = 0x00E6, // updated 7.31
        MarketBoardItemListingHistory = 0x03A9, // updated 7.31
        MarketBoardItemListing = 0x021A, // updated 7.31
        MarketBoardPurchase = 0x023A, // updated 7.31
        UpdateInventorySlot = 0x021B, // updated 7.31
        InventoryActionAck = 0x00F6, // updated 7.31
        InventoryTransaction = 0x028E, // updated 7.31
        InventoryTransactionFinish = 0x020D, // updated 7.31
        ResultDialog = 0x0252, // updated 7.31
        RetainerInformation = 0x00A8, // updated 7.31
        NpcSpawn = 0x018D, // updated 7.31
        ItemMarketBoardInfo = 0x011B, // updated 7.31
        ObjectSpawn = 0x015C, // updated 7.31
        EffectResultBasic = 0x01A9, // updated 7.31
        Effect = 0x0219, // updated 7.31
        StatusEffectList = 0x00BA, // updated 7.31
        StatusEffectList2 = 0x02C4, // updated 7.31
        StatusEffectList3 = 0x03D2, // updated 7.31
        ActorGauge = 0x024F, // updated 7.31
        CFNotify = 0x0124, // updated 7.31
        SystemLogMessage = 0x02D7, // updated 7.31
        AirshipTimers = 0x00B5, // updated 7.31
        SubmarineTimers = 0x00C9, // updated 7.31
        AirshipStatusList = 0x0296, // updated 7.31
        AirshipStatus = 0x026D, // updated 7.31
        AirshipExplorationResult = 0x02B3, // updated 7.31
        SubmarineProgressionStatus = 0x0283, // updated 7.31
        SubmarineStatusList = 0x0152, // updated 7.31
        SubmarineExplorationResult = 0x0243, // updated 7.31

        CraftingLog = 0x02F8, // updated 7.31
        GatheringLog = 0x01F5, // updated 7.31

        ActorMove = 0x011C, // updated 7.31

        EventPlay = 0x034E, // updated 7.31
        EventPlay4 = 0x0281, // updated 7.31
        EventPlay8 = 0x029F, // updated 7.31
        EventPlay16 = 0x0222, // updated 7.31
        EventPlay32 = 0x0358, // updated 7.31
        EventPlay64 = 0x0141, // updated 7.31
        EventPlay128 = 0x00DF, // updated 7.31
        EventPlay255 = 0x00DC, // updated 7.31

        EnvironmentControl = 0x0325, // updated 7.31
        IslandWorkshopSupplyDemand = 0x038C, // updated 7.31
        Logout = 0x01A8, // updated 7.31
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02EC, // updated 7.31
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x00F2, // updated 7.31
        MarketBoardPurchaseHandler = 0x00EF, // updated 7.31
        InventoryModifyHandler = 0x0108, // updated 7.31
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