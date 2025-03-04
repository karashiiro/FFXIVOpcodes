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
        PlayerSetup = 0x006B, // updated 7.18h
        UpdateHpMpTp = 0x00A8, // updated 7.18h
        UpdateClassInfo = 0x006A, // updated 7.18h
        PlayerStats = 0x01FA, // updated 7.18h
        ActorControl = 0x038E, // updated 7.18h
        ActorControlSelf = 0x018C, // updated 7.18h
        ActorControlTarget = 0x0115, // updated 7.18h
        Playtime = 0x00E4, // updated 7.18h
        UpdateSearchInfo = 0x019B, // updated 7.18h
        ExamineSearchInfo = 0x00D3, // updated 7.18h
        Examine = 0x02F4, // updated 7.18h
        ActorCast = 0x03CE, // updated 7.18h
        CurrencyCrystalInfo = 0x018F, // updated 7.18h
        InitZone = 0x0311, // updated 7.18h
        WeatherChange = 0x0110, // updated 7.18h
        PlayerSpawn = 0x01AB, // updated 7.18h
        ActorSetPos = 0x0223, // updated 7.18h
        PrepareZoning = 0x0209, // updated 7.18h
        ContainerInfo = 0x02EA, // updated 7.18h
        ItemInfo = 0x03AA, // updated 7.18h
        PlaceFieldMarker = 0x00CB, // updated 7.18h
        PlaceFieldMarkerPreset = 0x0175, // updated 7.18h
        EffectResult = 0x038F, // updated 7.18h
        EventStart = 0x01B4, // updated 7.18h
        EventFinish = 0x034A, // updated 7.18h
        DesynthResult = 0x01A7, // updated 7.18h
        FreeCompanyInfo = 0x0205, // updated 7.18h
        FreeCompanyDialog = 0x0165, // updated 7.18h
        MarketBoardSearchResult = 0x03CF, // updated 7.18h
        MarketBoardItemListingCount = 0x03CB, // updated 7.18h
        MarketBoardItemListingHistory = 0x0302, // updated 7.18h
        MarketBoardItemListing = 0x00B6, // updated 7.18h
        MarketBoardPurchase = 0x00A7, // updated 7.18h
        UpdateInventorySlot = 0x0101, // updated 7.18h
        InventoryActionAck = 0x02F0, // updated 7.18h
        InventoryTransaction = 0x0327, // updated 7.18h
        InventoryTransactionFinish = 0x0145, // updated 7.18h
        ResultDialog = 0x022C, // updated 7.18h
        RetainerInformation = 0x0346, // updated 7.18h
        NpcSpawn = 0x0100, // updated 7.18h
        ItemMarketBoardInfo = 0x01B2, // updated 7.18h
        ObjectSpawn = 0x0127, // updated 7.18h
        EffectResultBasic = 0x029E, // updated 7.18h
        Effect = 0x0071, // updated 7.18h
        StatusEffectList = 0x00BB, // updated 7.18h
        StatusEffectList2 = 0x0171, // updated 7.18h
        StatusEffectList3 = 0x0079, // updated 7.18h
        ActorGauge = 0x0163, // updated 7.18h
        CFNotify = 0x0312, // updated 7.18h
        SystemLogMessage = 0x018D, // updated 7.18h
        AirshipTimers = 0x030E, // updated 7.18h
        SubmarineTimers = 0x0114, // updated 7.18h
        AirshipStatusList = 0x0347, // updated 7.18h
        AirshipStatus = 0x0138, // updated 7.18h
        AirshipExplorationResult = 0x0102, // updated 7.18h
        SubmarineProgressionStatus = 0x028B, // updated 7.18h
        SubmarineStatusList = 0x0232, // updated 7.18h
        SubmarineExplorationResult = 0x02E3, // updated 7.18h

        CraftingLog = 0x006E, // updated 7.18h
        GatheringLog = 0x036A, // updated 7.18h

        ActorMove = 0x031C, // updated 7.18h

        EventPlay = 0x0085, // updated 7.18h
        EventPlay4 = 0x028D, // updated 7.18h
        EventPlay8 = 0x02D7, // updated 7.18h
        EventPlay16 = 0x02D1, // updated 7.18h
        EventPlay32 = 0x021B, // updated 7.18h
        EventPlay64 = 0x0300, // updated 7.18h
        EventPlay128 = 0x00C4, // updated 7.18h
        EventPlay255 = 0x0275, // updated 7.18h

        EnvironmentControl = 0x03C0, // updated 7.18h
        IslandWorkshopSupplyDemand = 0x0307, // updated 7.18h
        Logout = 0x0369, // updated 7.18h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0249, // updated 7.18h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x03B2, // updated 7.18h
        MarketBoardPurchaseHandler = 0x0231, // updated 7.18h
        InventoryModifyHandler = 0x00DC, // updated 7.18h
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