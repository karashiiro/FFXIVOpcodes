namespace FFXIVOpcodes.TW
{
    enum ServerLobbyIpcType : ushort
    {

    };

    enum ClientLobbyIpcType : ushort
    {

    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Zone Connection IPC Codes
    /**
    * Server IPC Zone Type Codes.
    */
    enum ServerZoneIpcType : ushort
    {
        PlayerSetup = 0x030A, // updated 7.2
        UpdateHpMpTp = 0x00D4, // updated 7.2
        UpdateClassInfo = 0x0255, // updated 7.2
        PlayerStats = 0x01EE, // updated 7.2
        ActorControl = 0x015A, // updated 7.2
        ActorControlSelf = 0x01F6, // updated 7.2
        ActorControlTarget = 0x033A, // updated 7.2
        Playtime = 0x013F, // updated 7.2
        UpdateSearchInfo = 0x0169, // updated 7.2
        ExamineSearchInfo = 0x0065, // updated 7.2
        Examine = 0x021E, // updated 7.2
        ActorCast = 0x035C, // updated 7.2
        CurrencyCrystalInfo = 0x0086, // updated 7.2
        InitZone = 0x0369, // updated 7.2
        WeatherChange = 0x0186, // updated 7.2
        PlayerSpawn = 0x01E7, // updated 7.2
        ActorSetPos = 0x0266, // updated 7.2
        PrepareZoning = 0x038C, // updated 7.2
        ContainerInfo = 0x0308, // updated 7.2
        ItemInfo = 0x01EB, // updated 7.2
        PlaceFieldMarker = 0x00D8, // updated 7.2
        PlaceFieldMarkerPreset = 0x02C3, // updated 7.2
        EffectResult = 0x0365, // updated 7.2
        EventStart = 0x03DC, // updated 7.2
        EventFinish = 0x0078, // updated 7.2
        DesynthResult = 0x0118, // updated 7.2
        FreeCompanyInfo = 0x03DB, // updated 7.2
        FreeCompanyDialog = 0x025D, // updated 7.2
        MarketBoardSearchResult = 0x02A3, // updated 7.2
        MarketBoardItemListingCount = 0x0270, // updated 7.2
        MarketBoardItemListingHistory = 0x0261, // updated 7.2
        MarketBoardItemListing = 0x01E0, // updated 7.2
        MarketBoardPurchase = 0x0239, // updated 7.2
        UpdateInventorySlot = 0x01BB, // updated 7.2
        InventoryActionAck = 0x0296, // updated 7.2
        InventoryTransaction = 0x024D, // updated 7.2
        InventoryTransactionFinish = 0x00D7, // updated 7.2
        ResultDialog = 0x0109, // updated 7.2
        RetainerInformation = 0x009E, // updated 7.2
        NpcSpawn = 0x02D2, // updated 7.2
        ItemMarketBoardInfo = 0x03E2, // updated 7.2
        ObjectSpawn = 0x0306, // updated 7.2
        EffectResultBasic = 0x006A, // updated 7.2
        Effect = 0x025E, // updated 7.2
        StatusEffectList = 0x026F, // updated 7.2
        StatusEffectList2 = 0x0135, // updated 7.2
        StatusEffectList3 = 0x0123, // updated 7.2
        ActorGauge = 0x03C5, // updated 7.2
        CFNotify = 0x00B8, // updated 7.2
        SystemLogMessage = 0x0125, // updated 7.2
        AirshipTimers = 0x0140, // updated 7.2
        SubmarineTimers = 0x03DF, // updated 7.2
        AirshipStatusList = 0x00BB, // updated 7.2
        AirshipStatus = 0x03C0, // updated 7.2
        AirshipExplorationResult = 0x0119, // updated 7.2
        SubmarineProgressionStatus = 0x00C0, // updated 7.2
        SubmarineStatusList = 0x00FC, // updated 7.2
        SubmarineExplorationResult = 0x01AF, // updated 7.2

        CraftingLog = 0x013B, // updated 7.2
        GatheringLog = 0x024B, // updated 7.2

        ActorMove = 0x00AF, // updated 7.2

        EventPlay = 0x03A7, // updated 7.2
        EventPlay4 = 0x02CA, // updated 7.2
        EventPlay8 = 0x024F, // updated 7.2
        EventPlay16 = 0x016E, // updated 7.2
        EventPlay32 = 0x0289, // updated 7.2
        EventPlay64 = 0x03E5, // updated 7.2
        EventPlay128 = 0x017B, // updated 7.2
        EventPlay255 = 0x0388, // updated 7.2

        EnvironmentControl = 0x03C1, // updated 7.2
        IslandWorkshopSupplyDemand = 0x0100, // updated 7.2
        Logout = 0x0183, // updated 7.2
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x029E, // updated 7.2
        SetSearchInfoHandler = 0x00BD, // updated 7.2
        MarketBoardPurchaseHandler = 0x02B2, // updated 7.2
        InventoryModifyHandler = 0x00B1, // updated 7.2
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}