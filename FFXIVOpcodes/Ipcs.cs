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
        PlayerSetup = 0x020E, // updated 6.48
        UpdateHpMpTp = 0x01FB, // updated 6.48
        UpdateClassInfo = 0x03E3, // updated 6.48
        PlayerStats = 0x02F3, // updated 6.48
        ActorControl = 0x00D4, // updated 6.48
        ActorControlSelf = 0x03C1, // updated 6.48
        ActorControlTarget = 0x00EF, // updated 6.48
        Playtime = 0x0313, // updated 6.48
        UpdateSearchInfo = 0x0115, // updated 6.48
        ExamineSearchInfo = 0x0357, // updated 6.48
        Examine = 0x0200, // updated 6.48
        ActorCast = 0x00C8, // updated 6.48
        CurrencyCrystalInfo = 0x0389, // updated 6.48
        InitZone = 0x0071, // updated 6.48
        WeatherChange = 0x021C, // updated 6.48
        PlayerSpawn = 0x010E, // updated 6.48
        ActorSetPos = 0x032C, // updated 6.48
        PrepareZoning = 0x0188, // updated 6.48
        ContainerInfo = 0x0208, // updated 6.48
        ItemInfo = 0x03A4, // updated 6.48
        PlaceFieldMarker = 0x0194, // updated 6.48
        PlaceFieldMarkerPreset = 0x0221, // updated 6.48
        EffectResult = 0x02A3, // updated 6.48
        EventStart = 0x02BE, // updated 6.48
        EventFinish = 0x0289, // updated 6.48
        DesynthResult = 0x0296, // updated 6.48
        FreeCompanyInfo = 0x030F, // updated 6.48
        FreeCompanyDialog = 0x01B4, // updated 6.48
        MarketBoardSearchResult = 0x03D6, // updated 6.48
        MarketBoardItemListingCount = 0x0306, // updated 6.48
        MarketBoardItemListingHistory = 0x02F4, // updated 6.48
        MarketBoardItemListing = 0x01DB, // updated 6.48
        MarketBoardPurchase = 0x01F0, // updated 6.48
        UpdateInventorySlot = 0x00A4, // updated 6.48
        InventoryActionAck = 0x0134, // updated 6.48
        InventoryTransaction = 0x03DB, // updated 6.48
        InventoryTransactionFinish = 0x0298, // updated 6.48
        ResultDialog = 0x021F, // updated 6.48
        RetainerInformation = 0x02FE, // updated 6.48
        NpcSpawn = 0x0091, // updated 6.48
        ItemMarketBoardInfo = 0x011B, // updated 6.48
        ObjectSpawn = 0x0190, // updated 6.48
        EffectResultBasic = 0x00FA, // updated 6.48
        Effect = 0x0354, // updated 6.48
        StatusEffectList = 0x01DD, // updated 6.48
        StatusEffectList2 = 0x0166, // updated 6.48
        StatusEffectList3 = 0x031F, // updated 6.48
        ActorGauge = 0x02A4, // updated 6.48
        CFNotify = 0x0069, // updated 6.48
        SystemLogMessage = 0x03C8, // updated 6.48
        AirshipTimers = 0x034F, // updated 6.48
        SubmarineTimers = 0x03AF, // updated 6.48
        AirshipStatusList = 0x02E4, // updated 6.48
        AirshipStatus = 0x016B, // updated 6.48
        AirshipExplorationResult = 0x0359, // updated 6.48
        SubmarineProgressionStatus = 0x0152, // updated 6.48
        SubmarineStatusList = 0x00C4, // updated 6.48
        SubmarineExplorationResult = 0x0376, // updated 6.48

        ActorMove = 0x01AA, // updated 6.48

        EventPlay = 0x02DB, // updated 6.48
        EventPlay4 = 0x00E8, // updated 6.48
        EventPlay8 = 0x00FE, // updated 6.48
        EventPlay16 = 0x008F, // updated 6.48
        EventPlay32 = 0x0374, // updated 6.48
        EventPlay64 = 0x027F, // updated 6.48
        EventPlay128 = 0x0365, // updated 6.48
        EventPlay255 = 0x00DB, // updated 6.48

        EnvironmentControl = 0x0137, // updated 6.48
        IslandWorkshopSupplyDemand = 0x00F9, // updated 6.48
        Logout = 0x0116, // updated 6.48
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03B5, // updated 6.48
        ClientTrigger = 0x0186, // updated 6.48
        ChatHandler = 0x01DF, // updated 6.48
        SetSearchInfoHandler = 0x0230, // updated 6.48
        MarketBoardPurchaseHandler = 0x015B, // updated 6.48
        InventoryModifyHandler = 0x02DA, // updated 6.48
        UpdatePositionInstance = 0x00A5, // updated 6.48
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
