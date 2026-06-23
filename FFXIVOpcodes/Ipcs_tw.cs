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
        PlayerSetup = 0x0094, // updated 7.15
        UpdateHpMpTp = 0x03B5, // updated 7.15
        UpdateClassInfo = 0x00E4, // updated 7.15
        PlayerStats = 0x0391, // updated 7.15
        ActorControl = 0x02A8, // updated 7.15
        ActorControlSelf = 0x0297, // updated 7.15
        ActorControlTarget = 0x015C, // updated 7.15
        Playtime = 0x0309, // updated 7.15
        UpdateSearchInfo = 0x0383, // updated 7.15
        ExamineSearchInfo = 0x0350, // updated 7.15
        Examine = 0x0222, // updated 7.15
        ActorCast = 0x0186, // updated 7.15
        CurrencyCrystalInfo = 0x02B2, // updated 7.15
        InitZone = 0x0131, // updated 7.15
        WeatherChange = 0x025B, // updated 7.15
        PlayerSpawn = 0x007B, // updated 7.15
        ActorSetPos = 0x009C, // updated 7.15
        PrepareZoning = 0x02BA, // updated 7.15
        ContainerInfo = 0x017B, // updated 7.15
        ItemInfo = 0x0164, // updated 7.15
        PlaceFieldMarker = 0x02AF, // updated 7.15
        PlaceFieldMarkerPreset = 0x0154, // updated 7.15
        EffectResult = 0x0252, // updated 7.15
        EventStart = 0x02A3, // updated 7.15
        EventFinish = 0x03E6, // updated 7.15
        DesynthResult = 0x02F0, // updated 7.15
        FreeCompanyInfo = 0x035A, // updated 7.15
        FreeCompanyDialog = 0x017D, // updated 7.15
        MarketBoardSearchResult = 0x011C, // updated 7.15
        MarketBoardItemListingCount = 0x0183, // updated 7.15
        MarketBoardItemListingHistory = 0x00B4, // updated 7.15
        MarketBoardItemListing = 0x0293, // updated 7.15
        MarketBoardPurchase = 0x0274, // updated 7.15
        UpdateInventorySlot = 0x00AA, // updated 7.15
        InventoryActionAck = 0x0396, // updated 7.15
        InventoryTransaction = 0x02F2, // updated 7.15
        InventoryTransactionFinish = 0x006F, // updated 7.15
        ResultDialog = 0x00D9, // updated 7.15
        RetainerInformation = 0x03A7, // updated 7.15
        NpcSpawn = 0x0102, // updated 7.15
        ItemMarketBoardInfo = 0x0083, // updated 7.15
        ObjectSpawn = 0x00FC, // updated 7.15
        EffectResultBasic = 0x021D, // updated 7.15
        Effect = 0x0233, // updated 7.15
        StatusEffectList = 0x00A3, // updated 7.15
        StatusEffectList2 = 0x00B7, // updated 7.15
        StatusEffectList3 = 0x00A8, // updated 7.15
        ActorGauge = 0x0239, // updated 7.15
        CFNotify = 0x01B0, // updated 7.15
        SystemLogMessage = 0x03AB, // updated 7.15
        AirshipTimers = 0x02F4, // updated 7.15
        SubmarineTimers = 0x01CD, // updated 7.15
        AirshipStatusList = 0x0338, // updated 7.15
        AirshipStatus = 0x00E8, // updated 7.15
        AirshipExplorationResult = 0x01F1, // updated 7.15
        SubmarineProgressionStatus = 0x020E, // updated 7.15
        SubmarineStatusList = 0x02EC, // updated 7.15
        SubmarineExplorationResult = 0x020C, // updated 7.15

        CraftingLog = 0x02F6, // updated 7.15
        GatheringLog = 0x03D4, // updated 7.15

        ActorMove = 0x036E, // updated 7.15

        EventPlay = 0x032C, // updated 7.15
        EventPlay4 = 0x0336, // updated 7.15
        EventPlay8 = 0x02CB, // updated 7.15
        EventPlay16 = 0x0223, // updated 7.15
        EventPlay32 = 0x03B1, // updated 7.15
        EventPlay64 = 0x025E, // updated 7.15
        EventPlay128 = 0x008E, // updated 7.15
        EventPlay255 = 0x02D0, // updated 7.15

        EnvironmentControl = 0x01BD, // updated 7.15
        IslandWorkshopSupplyDemand = 0x03E1, // updated 7.15
        Logout = 0x010C, // updated 7.15
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x033E, // updated 7.15
        SetSearchInfoHandler = 0x0258, // updated 7.15
        MarketBoardPurchaseHandler = 0x02E6, // updated 7.15
        InventoryModifyHandler = 0x0354, // updated 7.15
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}