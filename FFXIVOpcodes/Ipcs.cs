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
        PlayerSetup = 0x0090, // updated 7.4
        UpdateHpMpTp = 0x01E0, // updated 7.4
        UpdateClassInfo = 0x00AC, // updated 7.4
        PlayerStats = 0x0160, // updated 7.4
        ActorControl = 0x013C, // updated 7.4
        ActorControlSelf = 0x01D8, // updated 7.4
        ActorControlTarget = 0x0210, // updated 7.4
        Playtime = 0x01C4, // updated 7.4
        UpdateSearchInfo = 0x027A, // updated 7.4
        ExamineSearchInfo = 0x032A, // updated 7.4
        Examine = 0x006A, // updated 7.4
        ActorCast = 0x01A9, // updated 7.4
        CurrencyCrystalInfo = 0x022D, // updated 7.4
        InitZone = 0x0175, // updated 7.4
        WeatherChange = 0x00B6, // updated 7.4
        PlayerSpawn = 0x0107, // updated 7.4
        ActorSetPos = 0x0349, // updated 7.4
        PrepareZoning = 0x01AD, // updated 7.4
        ContainerInfo = 0x0250, // updated 7.4
        ItemInfo = 0x0215, // updated 7.4
        PlaceFieldMarker = 0x00CC, // updated 7.4
        PlaceFieldMarkerPreset = 0x0335, // updated 7.4
        EffectResult = 0x011C, // updated 7.4
        EventStart = 0x021C, // updated 7.4
        EventFinish = 0x017F, // updated 7.4
        DesynthResult = 0x01BB, // updated 7.4
        FreeCompanyInfo = 0x0322, // updated 7.4
        FreeCompanyDialog = 0x029E, // updated 7.4
        MarketBoardSearchResult = 0x03D1, // updated 7.4
        MarketBoardItemListingCount = 0x0067, // updated 7.4
        MarketBoardItemListingHistory = 0x039F, // updated 7.4
        MarketBoardItemListing = 0x00F8, // updated 7.4
        MarketBoardPurchase = 0x0272, // updated 7.4
        UpdateInventorySlot = 0x01DC, // updated 7.4
        InventoryActionAck = 0x02A6, // updated 7.4
        InventoryTransaction = 0x02DC, // updated 7.4
        InventoryTransactionFinish = 0x01C6, // updated 7.4
        ResultDialog = 0x0129, // updated 7.4
        RetainerInformation = 0x0122, // updated 7.4
        NpcSpawn = 0x02FC, // updated 7.4
        ItemMarketBoardInfo = 0x03E1, // updated 7.4
        ObjectSpawn = 0x0278, // updated 7.4
        EffectResultBasic = 0x0344, // updated 7.4
        Effect = 0x01C3, // updated 7.4
        StatusEffectList = 0x02C4, // updated 7.4
        StatusEffectList2 = 0x0177, // updated 7.4
        StatusEffectList3 = 0x00D8, // updated 7.4
        ActorGauge = 0x00FD, // updated 7.4
        CFNotify = 0x029D, // updated 7.4
        SystemLogMessage = 0x0244, // updated 7.4
        AirshipTimers = 0x01A3, // updated 7.4
        SubmarineTimers = 0x01C0, // updated 7.4
        AirshipStatusList = 0x013A, // updated 7.4
        AirshipStatus = 0x007A, // updated 7.4
        AirshipExplorationResult = 0x0147, // updated 7.4
        SubmarineProgressionStatus = 0x034B, // updated 7.4
        SubmarineStatusList = 0x020B, // updated 7.4
        SubmarineExplorationResult = 0x0251, // updated 7.4

        CraftingLog = 0x025C, // updated 7.4
        GatheringLog = 0x01F1, // updated 7.4

        ActorMove = 0x012C, // updated 7.4

        EventPlay = 0x01B8, // updated 7.4
        EventPlay4 = 0x02E0, // updated 7.4
        EventPlay8 = 0x0103, // updated 7.4
        EventPlay16 = 0x02E1, // updated 7.4
        EventPlay32 = 0x02F6, // updated 7.4
        EventPlay64 = 0x033F, // updated 7.4
        EventPlay128 = 0x00D9, // updated 7.4
        EventPlay255 = 0x0373, // updated 7.4

        EnvironmentControl = 0x016C, // updated 7.4
        IslandWorkshopSupplyDemand = 0x01F5, // updated 7.4
        Logout = 0x0185, // updated 7.4
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x03BA, // updated 7.4
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0084, // updated 7.4
        MarketBoardPurchaseHandler = 0x03A2, // updated 7.4
        InventoryModifyHandler = 0x0179, // updated 7.4
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