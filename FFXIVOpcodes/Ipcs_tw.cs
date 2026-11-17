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
        PlayerSetup = 0x01E3, // updated 7.3
        UpdateHpMpTp = 0x024D, // updated 7.3
        UpdateClassInfo = 0x007E, // updated 7.3
        PlayerStats = 0x0151, // updated 7.3
        ActorControl = 0x0399, // updated 7.3
        ActorControlSelf = 0x020A, // updated 7.3
        ActorControlTarget = 0x0317, // updated 7.3
        Playtime = 0x0111, // updated 7.3
        UpdateSearchInfo = 0x0286, // updated 7.3
        ExamineSearchInfo = 0x0291, // updated 7.3
        Examine = 0x02EA, // updated 7.3
        ActorCast = 0x00A6, // updated 7.3
        CurrencyCrystalInfo = 0x012A, // updated 7.3
        InitZone = 0x0394, // updated 7.3
        WeatherChange = 0x00E9, // updated 7.3
        PlayerSpawn = 0x009F, // updated 7.3
        ActorSetPos = 0x03A9, // updated 7.3
        PrepareZoning = 0x01DA, // updated 7.3
        ContainerInfo = 0x0067, // updated 7.3
        ItemInfo = 0x01A0, // updated 7.3
        PlaceFieldMarker = 0x03C9, // updated 7.3
        PlaceFieldMarkerPreset = 0x024A, // updated 7.3
        EffectResult = 0x03E2, // updated 7.3
        EventStart = 0x02D1, // updated 7.3
        EventFinish = 0x00B1, // updated 7.3
        DesynthResult = 0x00A8, // updated 7.3
        FreeCompanyInfo = 0x0077, // updated 7.3
        FreeCompanyDialog = 0x01D9, // updated 7.3
        MarketBoardSearchResult = 0x03E1, // updated 7.3
        MarketBoardItemListingCount = 0x039B, // updated 7.3
        MarketBoardItemListingHistory = 0x01ED, // updated 7.3
        MarketBoardItemListing = 0x016A, // updated 7.3
        MarketBoardPurchase = 0x0092, // updated 7.3
        UpdateInventorySlot = 0x0343, // updated 7.3
        InventoryActionAck = 0x0344, // updated 7.3
        InventoryTransaction = 0x0254, // updated 7.3
        InventoryTransactionFinish = 0x01D0, // updated 7.3
        ResultDialog = 0x02F0, // updated 7.3
        RetainerInformation = 0x02B5, // updated 7.3
        NpcSpawn = 0x00C6, // updated 7.3
        ItemMarketBoardInfo = 0x017D, // updated 7.3
        ObjectSpawn = 0x0312, // updated 7.3
        EffectResultBasic = 0x0118, // updated 7.3
        Effect = 0x0368, // updated 7.3
        StatusEffectList = 0x0353, // updated 7.3
        StatusEffectList2 = 0x0295, // updated 7.3
        StatusEffectList3 = 0x0181, // updated 7.3
        ActorGauge = 0x03DB, // updated 7.3
        CFNotify = 0x0184, // updated 7.3
        SystemLogMessage = 0x01E8, // updated 7.3
        AirshipTimers = 0x0128, // updated 7.3
        SubmarineTimers = 0x007F, // updated 7.3
        AirshipStatusList = 0x00EA, // updated 7.3
        AirshipStatus = 0x0194, // updated 7.3
        AirshipExplorationResult = 0x029F, // updated 7.3
        SubmarineProgressionStatus = 0x011A, // updated 7.3
        SubmarineStatusList = 0x03D1, // updated 7.3
        SubmarineExplorationResult = 0x02C8, // updated 7.3

        CraftingLog = 0x006D, // updated 7.3
        GatheringLog = 0x03A8, // updated 7.3

        ActorMove = 0x00DE, // updated 7.3

        EventPlay = 0x01F6, // updated 7.3
        EventPlay4 = 0x00DD, // updated 7.3
        EventPlay8 = 0x0287, // updated 7.3
        EventPlay16 = 0x024C, // updated 7.3
        EventPlay32 = 0x02FC, // updated 7.3
        EventPlay64 = 0x015D, // updated 7.3
        EventPlay128 = 0x0272, // updated 7.3
        EventPlay255 = 0x03B2, // updated 7.3

        EnvironmentControl = 0x006A, // updated 7.3
        IslandWorkshopSupplyDemand = 0x0179, // updated 7.3
        Logout = 0x0226, // updated 7.3
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x038F, // updated 7.3
        SetSearchInfoHandler = 0x00BC, // updated 7.3
        MarketBoardPurchaseHandler = 0x0220, // updated 7.3
        InventoryModifyHandler = 0x0163, // updated 7.3
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}