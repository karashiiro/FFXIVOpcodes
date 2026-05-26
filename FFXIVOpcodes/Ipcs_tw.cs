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
        PlayerSetup = 0x03AD, // updated 7.11
        UpdateHpMpTp = 0x0334, // updated 7.11
        UpdateClassInfo = 0x0110, // updated 7.11
        PlayerStats = 0x00DE, // updated 7.11
        ActorControl = 0x0070, // updated 7.11
        ActorControlSelf = 0x0115, // updated 7.11
        ActorControlTarget = 0x0149, // updated 7.11
        Playtime = 0x00EA, // updated 7.11
        UpdateSearchInfo = 0x02ED, // updated 7.11
        ExamineSearchInfo = 0x0175, // updated 7.11
        Examine = 0x0211, // updated 7.11
        ActorCast = 0x02D4, // updated 7.11
        CurrencyCrystalInfo = 0x01AD, // updated 7.11
        InitZone = 0x01BA, // updated 7.11
        WeatherChange = 0x024D, // updated 7.11
        PlayerSpawn = 0x02F7, // updated 7.11
        ActorSetPos = 0x0122, // updated 7.11
        PrepareZoning = 0x0235, // updated 7.11
        ContainerInfo = 0x036C, // updated 7.11
        ItemInfo = 0x011B, // updated 7.11
        PlaceFieldMarker = 0x02CC, // updated 7.11
        PlaceFieldMarkerPreset = 0x01CD, // updated 7.11
        EffectResult = 0x0116, // updated 7.11
        EventStart = 0x0195, // updated 7.11
        EventFinish = 0x0128, // updated 7.11
        DesynthResult = 0x0297, // updated 7.11
        FreeCompanyInfo = 0x00FA, // updated 7.11
        FreeCompanyDialog = 0x01D5, // updated 7.11
        MarketBoardSearchResult = 0x032A, // updated 7.11
        MarketBoardItemListingCount = 0x0208, // updated 7.11
        MarketBoardItemListingHistory = 0x0337, // updated 7.11
        MarketBoardItemListing = 0x0135, // updated 7.11
        MarketBoardPurchase = 0x021A, // updated 7.11
        UpdateInventorySlot = 0x006C, // updated 7.11
        InventoryActionAck = 0x00B0, // updated 7.11
        InventoryTransaction = 0x02B7, // updated 7.11
        InventoryTransactionFinish = 0x03A5, // updated 7.11
        ResultDialog = 0x00A3, // updated 7.11
        RetainerInformation = 0x02EF, // updated 7.11
        NpcSpawn = 0x0397, // updated 7.11
        ItemMarketBoardInfo = 0x01ED, // updated 7.11
        ObjectSpawn = 0x00B7, // updated 7.11
        EffectResultBasic = 0x0160, // updated 7.11
        Effect = 0x01D4, // updated 7.11
        StatusEffectList = 0x00A7, // updated 7.11
        StatusEffectList2 = 0x02C4, // updated 7.11
        StatusEffectList3 = 0x00BC, // updated 7.11
        ActorGauge = 0x014C, // updated 7.11
        CFNotify = 0x01E6, // updated 7.11
        SystemLogMessage = 0x015F, // updated 7.11
        AirshipTimers = 0x022A, // updated 7.11
        SubmarineTimers = 0x00B9, // updated 7.11
        AirshipStatusList = 0x03D2, // updated 7.11
        AirshipStatus = 0x0286, // updated 7.11
        AirshipExplorationResult = 0x019A, // updated 7.11
        SubmarineProgressionStatus = 0x0348, // updated 7.11
        SubmarineStatusList = 0x027F, // updated 7.11
        SubmarineExplorationResult = 0x038E, // updated 7.11

        CraftingLog = 0x00E4, // updated 7.11
        GatheringLog = 0x0383, // updated 7.11

        ActorMove = 0x0279, // updated 7.11

        EventPlay = 0x00B5, // updated 7.11
        EventPlay4 = 0x02BF, // updated 7.11
        EventPlay8 = 0x0228, // updated 7.11
        EventPlay16 = 0x0133, // updated 7.11
        EventPlay32 = 0x026E, // updated 7.11
        EventPlay64 = 0x0293, // updated 7.11
        EventPlay128 = 0x0217, // updated 7.11
        EventPlay255 = 0x0295, // updated 7.11

        EnvironmentControl = 0x032C, // updated 7.11
        IslandWorkshopSupplyDemand = 0x0313, // updated 7.11
        Logout = 0x031B, // updated 7.11
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0336, // updated 7.11
        SetSearchInfoHandler = 0x03AC, // updated 7.11
        MarketBoardPurchaseHandler = 0x013F, // updated 7.11
        InventoryModifyHandler = 0x0346, // updated 7.11
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}