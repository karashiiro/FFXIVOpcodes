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
        PlayerSetup = 0x035F, // updated 6.58h2
        UpdateHpMpTp = 0x007D, // updated 6.58h2
        UpdateClassInfo = 0x0172, // updated 6.58h2
        PlayerStats = 0x034F, // updated 6.58h2
        ActorControl = 0x0148, // updated 6.58h2
        ActorControlSelf = 0x025D, // updated 6.58h2
        ActorControlTarget = 0x032C, // updated 6.58h2
        Playtime = 0x03DE, // updated 6.58h2
        UpdateSearchInfo = 0x00CF, // updated 6.58h2
        ExamineSearchInfo = 0x014A, // updated 6.58h2
        Examine = 0x02C0, // updated 6.58h2
        ActorCast = 0x01BB, // updated 6.58h2
        CurrencyCrystalInfo = 0x02DE, // updated 6.58h2
        InitZone = 0x02D1, // updated 6.58h2
        WeatherChange = 0x021D, // updated 6.58h2
        PlayerSpawn = 0x039C, // updated 6.58h2
        ActorSetPos = 0x029D, // updated 6.58h2
        PrepareZoning = 0x0124, // updated 6.58h2
        ContainerInfo = 0x0069, // updated 6.58h2
        ItemInfo = 0x02F0, // updated 6.58h2
        PlaceFieldMarker = 0x02E4, // updated 6.58h2
        PlaceFieldMarkerPreset = 0x030A, // updated 6.58h2
        EffectResult = 0x0336, // updated 6.58h2
        EventStart = 0x0146, // updated 6.58h2
        EventFinish = 0x0339, // updated 6.58h2
        DesynthResult = 0x007F, // updated 6.58h2
        FreeCompanyInfo = 0x02D5, // updated 6.58h2
        FreeCompanyDialog = 0x029F, // updated 6.58h2
        MarketBoardSearchResult = 0x0161, // updated 6.58h2
        MarketBoardItemListingCount = 0x0286, // updated 6.58h2
        MarketBoardItemListingHistory = 0x0229, // updated 6.58h2
        MarketBoardItemListing = 0x03E3, // updated 6.58h2
        MarketBoardPurchase = 0x0143, // updated 6.58h2
        UpdateInventorySlot = 0x034D, // updated 6.58h2
        InventoryActionAck = 0x00DD, // updated 6.58h2
        InventoryTransaction = 0x02BD, // updated 6.58h2
        InventoryTransactionFinish = 0x009C, // updated 6.58h2
        ResultDialog = 0x0362, // updated 6.58h2
        RetainerInformation = 0x00ED, // updated 6.58h2
        NpcSpawn = 0x00A7, // updated 6.58h2
        ItemMarketBoardInfo = 0x01BC, // updated 6.58h2
        ObjectSpawn = 0x03B8, // updated 6.58h2
        EffectResultBasic = 0x023A, // updated 6.58h2
        Effect = 0x037D, // updated 6.58h2
        StatusEffectList = 0x0383, // updated 6.58h2
        StatusEffectList2 = 0x0369, // updated 6.58h2
        StatusEffectList3 = 0x0163, // updated 6.58h2
        ActorGauge = 0x03B3, // updated 6.58h2
        CFNotify = 0x0279, // updated 6.58h2
        SystemLogMessage = 0x03A9, // updated 6.58h2
        AirshipTimers = 0x0123, // updated 6.58h2
        SubmarineTimers = 0x0185, // updated 6.58h2
        AirshipStatusList = 0x023B, // updated 6.58h2
        AirshipStatus = 0x0291, // updated 6.58h2
        AirshipExplorationResult = 0x01BD, // updated 6.58h2
        SubmarineProgressionStatus = 0x02DD, // updated 6.58h2
        SubmarineStatusList = 0x03E2, // updated 6.58h2
        SubmarineExplorationResult = 0x02AA, // updated 6.58h2

        ActorMove = 0x011C, // updated 6.58h2

        EventPlay = 0x0155, // updated 6.58h2
        EventPlay4 = 0x00D0, // updated 6.58h2
        EventPlay8 = 0x022B, // updated 6.58h2
        EventPlay16 = 0x00D2, // updated 6.58h2
        EventPlay32 = 0x02CF, // updated 6.58h2
        EventPlay64 = 0x01D4, // updated 6.58h2
        EventPlay128 = 0x039F, // updated 6.58h2
        EventPlay255 = 0x0073, // updated 6.58h2

        EnvironmentControl = 0x02FC, // updated 6.58h2
        IslandWorkshopSupplyDemand = 0x013C, // updated 6.58h2
        Logout = 0x0378, // updated 6.58h2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0256, // updated 6.58h2
        ClientTrigger = 0x035C, // updated 6.58h2
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x01A0, // updated 6.58h2
        MarketBoardPurchaseHandler = 0x0322, // updated 6.58h2
        InventoryModifyHandler = 0x023E, // updated 6.58h2
        UpdatePositionInstance = 0x0227, // updated 6.58h2
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