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
        PlayerSetup = 0x039A, // updated 7.38
        UpdateHpMpTp = 0x02DB, // updated 7.38
        UpdateClassInfo = 0x0204, // updated 7.38
        PlayerStats = 0x02C4, // updated 7.38
        ActorControl = 0x0113, // updated 7.38
        ActorControlSelf = 0x0254, // updated 7.38
        ActorControlTarget = 0x0293, // updated 7.38
        Playtime = 0x0377, // updated 7.38
        UpdateSearchInfo = 0x016E, // updated 7.38
        ExamineSearchInfo = 0x0332, // updated 7.38
        Examine = 0x0338, // updated 7.38
        ActorCast = 0x032D, // updated 7.38
        CurrencyCrystalInfo = 0x03C1, // updated 7.38
        InitZone = 0x02B1, // updated 7.38
        WeatherChange = 0x02F8, // updated 7.38
        PlayerSpawn = 0x0270, // updated 7.38
        ActorSetPos = 0x00DE, // updated 7.38
        PrepareZoning = 0x00D5, // updated 7.38
        ContainerInfo = 0x021E, // updated 7.38
        ItemInfo = 0x01E7, // updated 7.38
        PlaceFieldMarker = 0x0276, // updated 7.38
        PlaceFieldMarkerPreset = 0x0382, // updated 7.38
        EffectResult = 0x00D0, // updated 7.38
        EventStart = 0x0343, // updated 7.38
        EventFinish = 0x03CE, // updated 7.38
        DesynthResult = 0x02D9, // updated 7.38
        FreeCompanyInfo = 0x0215, // updated 7.38
        FreeCompanyDialog = 0x0324, // updated 7.38
        MarketBoardSearchResult = 0x0378, // updated 7.38
        MarketBoardItemListingCount = 0x0104, // updated 7.38
        MarketBoardItemListingHistory = 0x01FB, // updated 7.38
        MarketBoardItemListing = 0x0241, // updated 7.38
        MarketBoardPurchase = 0x02F2, // updated 7.38
        UpdateInventorySlot = 0x00CE, // updated 7.38
        InventoryActionAck = 0x02CC, // updated 7.38
        InventoryTransaction = 0x0117, // updated 7.38
        InventoryTransactionFinish = 0x00EC, // updated 7.38
        ResultDialog = 0x037F, // updated 7.38
        RetainerInformation = 0x0137, // updated 7.38
        NpcSpawn = 0x02C9, // updated 7.38
        ItemMarketBoardInfo = 0x0388, // updated 7.38
        ObjectSpawn = 0x02B9, // updated 7.38
        EffectResultBasic = 0x02DE, // updated 7.38
        Effect = 0x02AB, // updated 7.38
        StatusEffectList = 0x00B0, // updated 7.38
        StatusEffectList2 = 0x024F, // updated 7.38
        StatusEffectList3 = 0x010A, // updated 7.38
        ActorGauge = 0x0365, // updated 7.38
        CFNotify = 0x00FC, // updated 7.38
        SystemLogMessage = 0x01FA, // updated 7.38
        AirshipTimers = 0x02F4, // updated 7.38
        SubmarineTimers = 0x0229, // updated 7.38
        AirshipStatusList = 0x0179, // updated 7.38
        AirshipStatus = 0x03CD, // updated 7.38
        AirshipExplorationResult = 0x032E, // updated 7.38
        SubmarineProgressionStatus = 0x01C7, // updated 7.38
        SubmarineStatusList = 0x018E, // updated 7.38
        SubmarineExplorationResult = 0x00AC, // updated 7.38

        CraftingLog = 0x011A, // updated 7.38
        GatheringLog = 0x024B, // updated 7.38

        ActorMove = 0x035D, // updated 7.38

        EventPlay = 0x01B1, // updated 7.38
        EventPlay4 = 0x0330, // updated 7.38
        EventPlay8 = 0x0251, // updated 7.38
        EventPlay16 = 0x017C, // updated 7.38
        EventPlay32 = 0x02C7, // updated 7.38
        EventPlay64 = 0x035C, // updated 7.38
        EventPlay128 = 0x033C, // updated 7.38
        EventPlay255 = 0x026E, // updated 7.38

        EnvironmentControl = 0x033D, // updated 7.38
        IslandWorkshopSupplyDemand = 0x03A0, // updated 7.38
        Logout = 0x0312, // updated 7.38
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0069, // updated 7.38
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x01D7, // updated 7.38
        MarketBoardPurchaseHandler = 0x01BE, // updated 7.38
        InventoryModifyHandler = 0x0224, // updated 7.38
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