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
        PlayerSetup = 0x0158, // updated 7.1
        UpdateHpMpTp = 0x0382, // updated 7.1
        UpdateClassInfo = 0x028B, // updated 7.1
        PlayerStats = 0x007C, // updated 7.1
        ActorControl = 0x0191, // updated 7.1
        ActorControlSelf = 0x03C3, // updated 7.1
        ActorControlTarget = 0x00A7, // updated 7.1
        Playtime = 0x0071, // updated 7.1
        UpdateSearchInfo = 0x034C, // updated 7.1
        ExamineSearchInfo = 0x0072, // updated 7.1
        Examine = 0x0067, // updated 7.1
        ActorCast = 0x023B, // updated 7.1
        CurrencyCrystalInfo = 0x007F, // updated 7.1
        InitZone = 0x0227, // updated 7.1
        WeatherChange = 0x0108, // updated 7.1
        PlayerSpawn = 0x01C5, // updated 7.1
        ActorSetPos = 0x02F0, // updated 7.1
        PrepareZoning = 0x0192, // updated 7.1
        ContainerInfo = 0x0076, // updated 7.1
        ItemInfo = 0x0301, // updated 7.1
        PlaceFieldMarker = 0x02BE, // updated 7.1
        PlaceFieldMarkerPreset = 0x00BD, // updated 7.1
        EffectResult = 0x03C8, // updated 7.1
        EventStart = 0x026E, // updated 7.1
        EventFinish = 0x0291, // updated 7.1
        DesynthResult = 0x02CC, // updated 7.1
        FreeCompanyInfo = 0x01D9, // updated 7.1
        FreeCompanyDialog = 0x01B9, // updated 7.1
        MarketBoardSearchResult = 0x026C, // updated 7.1
        MarketBoardItemListingCount = 0x02F9, // updated 7.1
        MarketBoardItemListingHistory = 0x0157, // updated 7.1
        MarketBoardItemListing = 0x01B2, // updated 7.1
        MarketBoardPurchase = 0x02EE, // updated 7.1
        UpdateInventorySlot = 0x03C0, // updated 7.1
        InventoryActionAck = 0x021B, // updated 7.1
        InventoryTransaction = 0x01CD, // updated 7.1
        InventoryTransactionFinish = 0x01DD, // updated 7.1
        ResultDialog = 0x02A7, // updated 7.1
        RetainerInformation = 0x039B, // updated 7.1
        NpcSpawn = 0x027D, // updated 7.1
        ItemMarketBoardInfo = 0x019A, // updated 7.1
        ObjectSpawn = 0x0252, // updated 7.1
        EffectResultBasic = 0x02D4, // updated 7.1
        Effect = 0x01F9, // updated 7.1
        StatusEffectList = 0x0317, // updated 7.1
        StatusEffectList2 = 0x0285, // updated 7.1
        StatusEffectList3 = 0x01CC, // updated 7.1
        ActorGauge = 0x02D5, // updated 7.1
        CFNotify = 0x01C9, // updated 7.1
        SystemLogMessage = 0x01F0, // updated 7.1
        AirshipTimers = 0x0081, // updated 7.1
        SubmarineTimers = 0x01BF, // updated 7.1
        AirshipStatusList = 0x0159, // updated 7.1
        AirshipStatus = 0x0286, // updated 7.1
        AirshipExplorationResult = 0x0323, // updated 7.1
        SubmarineProgressionStatus = 0x0196, // updated 7.1
        SubmarineStatusList = 0x02C8, // updated 7.1
        SubmarineExplorationResult = 0x03B1, // updated 7.1

        CraftingLog = 0x031F, // updated 7.1
        GatheringLog = 0x00CB, // updated 7.1

        ActorMove = 0x0263, // updated 7.1

        EventPlay = 0x0207, // updated 7.1
        EventPlay4 = 0x0257, // updated 7.1
        EventPlay8 = 0x00D4, // updated 7.1
        EventPlay16 = 0x0266, // updated 7.1
        EventPlay32 = 0x02BA, // updated 7.1
        EventPlay64 = 0x0126, // updated 7.1
        EventPlay128 = 0x026D, // updated 7.1
        EventPlay255 = 0x00C5, // updated 7.1

        EnvironmentControl = 0x038C, // updated 7.1
        IslandWorkshopSupplyDemand = 0x0069, // updated 7.1
        Logout = 0x0224, // updated 7.1
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x0397, // updated 7.1
        SetSearchInfoHandler = 0x00D3, // updated 7.1
        MarketBoardPurchaseHandler = 0x02DA, // updated 7.1
        InventoryModifyHandler = 0x02F7, // updated 7.1
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}