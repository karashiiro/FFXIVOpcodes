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
        PlayerSetup = 0x00C6, // updated 7.05h2
        UpdateHpMpTp = 0x01A8, // updated 7.05h2
        UpdateClassInfo = 0x0279, // updated 7.05h2
        PlayerStats = 0x0339, // updated 7.05h2
        ActorControl = 0x0178, // updated 7.05h2
        ActorControlSelf = 0x02A7, // updated 7.05h2
        ActorControlTarget = 0x01E9, // updated 7.05h2
        Playtime = 0x00A3, // updated 7.05h2
        UpdateSearchInfo = 0x033C, // updated 7.05h2
        ExamineSearchInfo = 0x023C, // updated 7.05h2
        Examine = 0x0326, // updated 7.05h2
        ActorCast = 0x020F, // updated 7.05h2
        CurrencyCrystalInfo = 0x02B6, // updated 7.05h2
        InitZone = 0x01F1, // updated 7.05h2
        WeatherChange = 0x0315, // updated 7.05h2
        PlayerSpawn = 0x024F, // updated 7.05h2
        ActorSetPos = 0x01C6, // updated 7.05h2
        PrepareZoning = 0x0316, // updated 7.05h2
        ContainerInfo = 0x03D4, // updated 7.05h2
        ItemInfo = 0x0236, // updated 7.05h2
        PlaceFieldMarker = 0x01E6, // updated 7.05h2
        PlaceFieldMarkerPreset = 0x0226, // updated 7.05h2
        EffectResult = 0x0328, // updated 7.05h2
        EventStart = 0x0097, // updated 7.05h2
        EventFinish = 0x02A5, // updated 7.05h2
        DesynthResult = 0x02D6, // updated 7.05h2
        FreeCompanyInfo = 0x03AF, // updated 7.05h2
        FreeCompanyDialog = 0x0261, // updated 7.05h2
        MarketBoardSearchResult = 0x00F5, // updated 7.05h2
        MarketBoardItemListingCount = 0x00A0, // updated 7.05h2
        MarketBoardItemListingHistory = 0x0102, // updated 7.05h2
        MarketBoardItemListing = 0x01C3, // updated 7.05h2
        MarketBoardPurchase = 0x0238, // updated 7.05h2
        UpdateInventorySlot = 0x02BE, // updated 7.05h2
        InventoryActionAck = 0x00DB, // updated 7.05h2
        InventoryTransaction = 0x00E8, // updated 7.05h2
        InventoryTransactionFinish = 0x035B, // updated 7.05h2
        ResultDialog = 0x02B1, // updated 7.05h2
        RetainerInformation = 0x035C, // updated 7.05h2
        NpcSpawn = 0x0186, // updated 7.05h2
        ItemMarketBoardInfo = 0x0345, // updated 7.05h2
        ObjectSpawn = 0x03AE, // updated 7.05h2
        EffectResultBasic = 0x036A, // updated 7.05h2
        Effect = 0x00BE, // updated 7.05h2
        StatusEffectList = 0x03A9, // updated 7.05h2
        StatusEffectList2 = 0x02BC, // updated 7.05h2
        StatusEffectList3 = 0x0231, // updated 7.05h2
        ActorGauge = 0x029B, // updated 7.05h2
        CFNotify = 0x014F, // updated 7.05h2
        SystemLogMessage = 0x00A7, // updated 7.05h2
        AirshipTimers = 0x0371, // updated 7.05h2
        SubmarineTimers = 0x00F8, // updated 7.05h2
        AirshipStatusList = 0x00F2, // updated 7.05h2
        AirshipStatus = 0x01DB, // updated 7.05h2
        AirshipExplorationResult = 0x0100, // updated 7.05h2
        SubmarineProgressionStatus = 0x0101, // updated 7.05h2
        SubmarineStatusList = 0x01EB, // updated 7.05h2
        SubmarineExplorationResult = 0x0224, // updated 7.05h2

        CraftingLog = 0x03D1, // updated 7.05h2
        GatheringLog = 0x00BD, // updated 7.05h2

        ActorMove = 0x0119, // updated 7.05h2

        EventPlay = 0x026D, // updated 7.05h2
        EventPlay4 = 0x0154, // updated 7.05h2
        EventPlay8 = 0x039E, // updated 7.05h2
        EventPlay16 = 0x0307, // updated 7.05h2
        EventPlay32 = 0x0263, // updated 7.05h2
        EventPlay64 = 0x03A7, // updated 7.05h2
        EventPlay128 = 0x0196, // updated 7.05h2
        EventPlay255 = 0x013D, // updated 7.05h2

        EnvironmentControl = 0x0394, // updated 7.05h2
        IslandWorkshopSupplyDemand = 0x00DE, // updated 7.05h2
        Logout = 0x01A9, // updated 7.05h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x007F, // updated 7.05h2
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x010E, // updated 7.05h2
        MarketBoardPurchaseHandler = 0x02B7, // updated 7.05h2
        InventoryModifyHandler = 0x0299, // updated 7.05h2
        UpdatePositionInstance = 0x03CE, // updated 7.0h
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