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
        PlayerSetup = 0x03DE, // updated 7.20h
        UpdateHpMpTp = 0x00A2, // updated 7.20h
        UpdateClassInfo = 0x0279, // updated 7.20h
        PlayerStats = 0x0134, // updated 7.20h
        ActorControl = 0x026F, // updated 7.20h
        ActorControlSelf = 0x00B2, // updated 7.20h
        ActorControlTarget = 0x037E, // updated 7.20h
        Playtime = 0x018A, // updated 7.20h
        UpdateSearchInfo = 0x0288, // updated 7.20h
        ExamineSearchInfo = 0x03B0, // updated 7.20h
        Examine = 0x00A1, // updated 7.20h
        ActorCast = 0x007B, // updated 7.20h
        CurrencyCrystalInfo = 0x010D, // updated 7.20h
        InitZone = 0x027C, // updated 7.20h
        WeatherChange = 0x0384, // updated 7.20h
        PlayerSpawn = 0x03A4, // updated 7.20h
        ActorSetPos = 0x00C5, // updated 7.20h
        PrepareZoning = 0x00BE, // updated 7.20h
        ContainerInfo = 0x0193, // updated 7.20h
        ItemInfo = 0x00C3, // updated 7.20h
        PlaceFieldMarker = 0x0246, // updated 7.20h
        PlaceFieldMarkerPreset = 0x01AA, // updated 7.20h
        EffectResult = 0x01FC, // updated 7.20h
        EventStart = 0x0262, // updated 7.20h
        EventFinish = 0x0277, // updated 7.20h
        DesynthResult = 0x00AF, // updated 7.20h
        FreeCompanyInfo = 0x0088, // updated 7.20h
        FreeCompanyDialog = 0x0370, // updated 7.20h
        MarketBoardSearchResult = 0x032D, // updated 7.20h
        MarketBoardItemListingCount = 0x01F2, // updated 7.20h
        MarketBoardItemListingHistory = 0x01A1, // updated 7.20h
        MarketBoardItemListing = 0x0099, // updated 7.20h
        MarketBoardPurchase = 0x03D7, // updated 7.20h
        UpdateInventorySlot = 0x017B, // updated 7.20h
        InventoryActionAck = 0x039F, // updated 7.20h
        InventoryTransaction = 0x01F6, // updated 7.20h
        InventoryTransactionFinish = 0x01DF, // updated 7.20h
        ResultDialog = 0x0185, // updated 7.20h
        RetainerInformation = 0x0362, // updated 7.20h
        NpcSpawn = 0x035C, // updated 7.20h
        ItemMarketBoardInfo = 0x0294, // updated 7.20h
        ObjectSpawn = 0x00A6, // updated 7.20h
        EffectResultBasic = 0x027D, // updated 7.20h
        Effect = 0x01BF, // updated 7.20h
        StatusEffectList = 0x01A8, // updated 7.20h
        StatusEffectList2 = 0x0285, // updated 7.20h
        StatusEffectList3 = 0x03C2, // updated 7.20h
        ActorGauge = 0x01C9, // updated 7.20h
        CFNotify = 0x00A9, // updated 7.20h
        SystemLogMessage = 0x0382, // updated 7.20h
        AirshipTimers = 0x00CE, // updated 7.20h
        SubmarineTimers = 0x01E9, // updated 7.20h
        AirshipStatusList = 0x01AF, // updated 7.20h
        AirshipStatus = 0x016A, // updated 7.20h
        AirshipExplorationResult = 0x034D, // updated 7.20h
        SubmarineProgressionStatus = 0x03C3, // updated 7.20h
        SubmarineStatusList = 0x0065, // updated 7.20h
        SubmarineExplorationResult = 0x02F5, // updated 7.20h

        CraftingLog = 0x0121, // updated 7.20h
        GatheringLog = 0x01D2, // updated 7.20h

        ActorMove = 0x0191, // updated 7.20h

        EventPlay = 0x0093, // updated 7.20h
        EventPlay4 = 0x0137, // updated 7.20h
        EventPlay8 = 0x01A6, // updated 7.20h
        EventPlay16 = 0x02C7, // updated 7.20h
        EventPlay32 = 0x0236, // updated 7.20h
        EventPlay64 = 0x0342, // updated 7.20h
        EventPlay128 = 0x017E, // updated 7.20h
        EventPlay255 = 0x03E5, // updated 7.20h

        EnvironmentControl = 0x029E, // updated 7.20h
        IslandWorkshopSupplyDemand = 0x00F1, // updated 7.20h
        Logout = 0x0128, // updated 7.20h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02A3, // updated 7.20h
        //ClientTrigger = 0x0324, // updated 7.0h
        SetSearchInfoHandler = 0x0195, // updated 7.20h
        MarketBoardPurchaseHandler = 0x02B5, // updated 7.20h
        InventoryModifyHandler = 0x0234, // updated 7.20h
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