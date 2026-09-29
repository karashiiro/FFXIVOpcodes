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
        PlayerSetup = 0x02DE, // updated 7.25
        UpdateHpMpTp = 0x038F, // updated 7.25
        UpdateClassInfo = 0x0132, // updated 7.25
        PlayerStats = 0x00FF, // updated 7.25
        ActorControl = 0x0325, // updated 7.25
        ActorControlSelf = 0x0111, // updated 7.25
        ActorControlTarget = 0x025A, // updated 7.25
        Playtime = 0x00A1, // updated 7.25
        UpdateSearchInfo = 0x0141, // updated 7.25
        ExamineSearchInfo = 0x0181, // updated 7.25
        Examine = 0x02CD, // updated 7.25
        ActorCast = 0x035D, // updated 7.25
        CurrencyCrystalInfo = 0x01EB, // updated 7.25
        InitZone = 0x00EB, // updated 7.25
        WeatherChange = 0x01A6, // updated 7.25
        PlayerSpawn = 0x037C, // updated 7.25
        ActorSetPos = 0x0279, // updated 7.25
        PrepareZoning = 0x0380, // updated 7.25
        ContainerInfo = 0x0093, // updated 7.25
        ItemInfo = 0x0178, // updated 7.25
        PlaceFieldMarker = 0x0338, // updated 7.25
        PlaceFieldMarkerPreset = 0x01C9, // updated 7.25
        EffectResult = 0x0311, // updated 7.25
        EventStart = 0x0168, // updated 7.25
        EventFinish = 0x015B, // updated 7.25
        DesynthResult = 0x010E, // updated 7.25
        FreeCompanyInfo = 0x030F, // updated 7.25
        FreeCompanyDialog = 0x0295, // updated 7.25
        MarketBoardSearchResult = 0x018F, // updated 7.25
        MarketBoardItemListingCount = 0x0176, // updated 7.25
        MarketBoardItemListingHistory = 0x036D, // updated 7.25
        MarketBoardItemListing = 0x0113, // updated 7.25
        MarketBoardPurchase = 0x0110, // updated 7.25
        UpdateInventorySlot = 0x00AC, // updated 7.25
        InventoryActionAck = 0x0248, // updated 7.25
        InventoryTransaction = 0x0069, // updated 7.25
        InventoryTransactionFinish = 0x0348, // updated 7.25
        ResultDialog = 0x014A, // updated 7.25
        RetainerInformation = 0x00CC, // updated 7.25
        NpcSpawn = 0x0374, // updated 7.25
        ItemMarketBoardInfo = 0x006C, // updated 7.25
        ObjectSpawn = 0x034A, // updated 7.25
        EffectResultBasic = 0x0162, // updated 7.25
        Effect = 0x01BE, // updated 7.25
        StatusEffectList = 0x0300, // updated 7.25
        StatusEffectList2 = 0x019D, // updated 7.25
        StatusEffectList3 = 0x016E, // updated 7.25
        ActorGauge = 0x00FD, // updated 7.25
        CFNotify = 0x0187, // updated 7.25
        SystemLogMessage = 0x02CF, // updated 7.25
        AirshipTimers = 0x036B, // updated 7.25
        SubmarineTimers = 0x01A7, // updated 7.25
        AirshipStatusList = 0x0329, // updated 7.25
        AirshipStatus = 0x00BF, // updated 7.25
        AirshipExplorationResult = 0x006E, // updated 7.25
        SubmarineProgressionStatus = 0x03CE, // updated 7.25
        SubmarineStatusList = 0x0206, // updated 7.25
        SubmarineExplorationResult = 0x00A9, // updated 7.25

        CraftingLog = 0x01AA, // updated 7.25
        GatheringLog = 0x0242, // updated 7.25

        ActorMove = 0x0229, // updated 7.25

        EventPlay = 0x01BB, // updated 7.25
        EventPlay4 = 0x0265, // updated 7.25
        EventPlay8 = 0x0148, // updated 7.25
        EventPlay16 = 0x0369, // updated 7.25
        EventPlay32 = 0x03B7, // updated 7.25
        EventPlay64 = 0x0122, // updated 7.25
        EventPlay128 = 0x02BB, // updated 7.25
        EventPlay255 = 0x0188, // updated 7.25

        EnvironmentControl = 0x0251, // updated 7.25
        IslandWorkshopSupplyDemand = 0x0172, // updated 7.25
        Logout = 0x0232, // updated 7.25
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0264, // updated 7.25
        SetSearchInfoHandler = 0x007E, // updated 7.25
        MarketBoardPurchaseHandler = 0x0342, // updated 7.25
        InventoryModifyHandler = 0x0297, // updated 7.25
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}