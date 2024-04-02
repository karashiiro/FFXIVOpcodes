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
        PlayerSetup = 0x0216, // updated 6.58h
        UpdateHpMpTp = 0x0151, // updated 6.58h
        UpdateClassInfo = 0x00D2, // updated 6.58h
        PlayerStats = 0x0172, // updated 6.58h
        ActorControl = 0x0333, // updated 6.58h
        ActorControlSelf = 0x0111, // updated 6.58h
        ActorControlTarget = 0x006E, // updated 6.58h
        Playtime = 0x031D, // updated 6.58h
        UpdateSearchInfo = 0x0114, // updated 6.58h
        ExamineSearchInfo = 0x0365, // updated 6.58h
        Examine = 0x02BF, // updated 6.58h
        ActorCast = 0x0391, // updated 6.58h
        CurrencyCrystalInfo = 0x0075, // updated 6.58h
        InitZone = 0x031B, // updated 6.58h
        WeatherChange = 0x01FD, // updated 6.58h
        PlayerSpawn = 0x00F6, // updated 6.58h
        ActorSetPos = 0x0191, // updated 6.58h
        PrepareZoning = 0x03A7, // updated 6.58h
        ContainerInfo = 0x01F5, // updated 6.58h
        ItemInfo = 0x0344, // updated 6.58h
        PlaceFieldMarker = 0x029F, // updated 6.58h
        PlaceFieldMarkerPreset = 0x01F7, // updated 6.58h
        EffectResult = 0x018D, // updated 6.58h
        EventStart = 0x0092, // updated 6.58h
        EventFinish = 0x0231, // updated 6.58h
        DesynthResult = 0x0247, // updated 6.58h
        FreeCompanyInfo = 0x009A, // updated 6.58h
        FreeCompanyDialog = 0x02AE, // updated 6.58h
        MarketBoardSearchResult = 0x02FA, // updated 6.58h
        MarketBoardItemListingCount = 0x02ED, // updated 6.58h
        MarketBoardItemListingHistory = 0x0109, // updated 6.58h
        MarketBoardItemListing = 0x03E5, // updated 6.58h
        MarketBoardPurchase = 0x0211, // updated 6.58h
        UpdateInventorySlot = 0x035E, // updated 6.58h
        InventoryActionAck = 0x00AD, // updated 6.58h
        InventoryTransaction = 0x0201, // updated 6.58h
        InventoryTransactionFinish = 0x00B4, // updated 6.58h
        ResultDialog = 0x01E0, // updated 6.58h
        RetainerInformation = 0x00DB, // updated 6.58h
        NpcSpawn = 0x02BD, // updated 6.58h
        ItemMarketBoardInfo = 0x0167, // updated 6.58h
        ObjectSpawn = 0x0314, // updated 6.58h
        EffectResultBasic = 0x017A, // updated 6.58h
        Effect = 0x01CA, // updated 6.58h
        StatusEffectList = 0x00F1, // updated 6.58h
        StatusEffectList2 = 0x022F, // updated 6.58h
        StatusEffectList3 = 0x0089, // updated 6.58h
        ActorGauge = 0x0353, // updated 6.58h
        CFNotify = 0x0225, // updated 6.58h
        SystemLogMessage = 0x01E7, // updated 6.58h
        AirshipTimers = 0x027A, // updated 6.58h
        SubmarineTimers = 0x020C, // updated 6.58h
        AirshipStatusList = 0x0354, // updated 6.58h
        AirshipStatus = 0x03C0, // updated 6.58h
        AirshipExplorationResult = 0x01B0, // updated 6.58h
        SubmarineProgressionStatus = 0x01B9, // updated 6.58h
        SubmarineStatusList = 0x0244, // updated 6.58h
        SubmarineExplorationResult = 0x0319, // updated 6.58h

        ActorMove = 0x03B5, // updated 6.58h

        EventPlay = 0x012A, // updated 6.58h
        EventPlay4 = 0x0317, // updated 6.58h
        EventPlay8 = 0x033A, // updated 6.58h
        EventPlay16 = 0x0080, // updated 6.58h
        EventPlay32 = 0x0138, // updated 6.58h
        EventPlay64 = 0x00AA, // updated 6.58h
        EventPlay128 = 0x02B6, // updated 6.58h
        EventPlay255 = 0x02DB, // updated 6.58h

        EnvironmentControl = 0x0118, // updated 6.58h
        IslandWorkshopSupplyDemand = 0x0316, // updated 6.58h
        Logout = 0x029C, // updated 6.58h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x021A, // updated 6.58h
        ClientTrigger = 0x0081, // updated 6.58h
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x00B5, // updated 6.58h
        MarketBoardPurchaseHandler = 0x01CC, // updated 6.58h
        InventoryModifyHandler = 0x012D, // updated 6.58h
        UpdatePositionInstance = 0x00D9, // updated 6.58h
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