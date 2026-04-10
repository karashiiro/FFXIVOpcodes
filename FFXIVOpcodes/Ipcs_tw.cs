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
        PlayerSetup = 0x0208, // updated 7.05h
        UpdateHpMpTp = 0x0328, // updated 7.05h
        UpdateClassInfo = 0x0349, // updated 7.05h
        PlayerStats = 0x03A3, // updated 7.05h
        ActorControl = 0x023D, // updated 7.05h
        ActorControlSelf = 0x0117, // updated 7.05h
        ActorControlTarget = 0x0198, // updated 7.05h
        Playtime = 0x00FD, // updated 7.05h
        UpdateSearchInfo = 0x014E, // updated 7.05h
        ExamineSearchInfo = 0x033D, // updated 7.05h
        Examine = 0x034A, // updated 7.05h
        ActorCast = 0x0333, // updated 7.05h
        CurrencyCrystalInfo = 0x02A0, // updated 7.05h
        InitZone = 0x036F, // updated 7.05h
        WeatherChange = 0x02B2, // updated 7.05h
        PlayerSpawn = 0x03B2, // updated 7.05h
        ActorSetPos = 0x0355, // updated 7.05h
        PrepareZoning = 0x03B4, // updated 7.05h
        ContainerInfo = 0x027F, // updated 7.05h
        ItemInfo = 0x02F6, // updated 7.05h
        PlaceFieldMarker = 0x02FD, // updated 7.05h
        PlaceFieldMarkerPreset = 0x039C, // updated 7.05h
        EffectResult = 0x033F, // updated 7.05h
        EventStart = 0x03D1, // updated 7.05h
        EventFinish = 0x01DB, // updated 7.05h
        DesynthResult = 0x02BE, // updated 7.05h
        FreeCompanyInfo = 0x035C, // updated 7.05h
        FreeCompanyDialog = 0x00A8, // updated 7.05h
        MarketBoardSearchResult = 0x0213, // updated 7.05h
        MarketBoardItemListingCount = 0x016C, // updated 7.05h
        MarketBoardItemListingHistory = 0x022D, // updated 7.05h
        MarketBoardItemListing = 0x00E9, // updated 7.05h
        MarketBoardPurchase = 0x0373, // updated 7.05h
        UpdateInventorySlot = 0x01A1, // updated 7.05h
        InventoryActionAck = 0x03A5, // updated 7.05h
        InventoryTransaction = 0x0245, // updated 7.05h
        InventoryTransactionFinish = 0x014D, // updated 7.05h
        ResultDialog = 0x0212, // updated 7.05h
        RetainerInformation = 0x01CC, // updated 7.05h
        NpcSpawn = 0x01D8, // updated 7.05h
        ItemMarketBoardInfo = 0x0374, // updated 7.05h
        ObjectSpawn = 0x01B1, // updated 7.05h
        EffectResultBasic = 0x00AF, // updated 7.05h
        Effect = 0x00C8, // updated 7.05h
        StatusEffectList = 0x0154, // updated 7.05h
        StatusEffectList2 = 0x013F, // updated 7.05h
        StatusEffectList3 = 0x02E6, // updated 7.05h
        ActorGauge = 0x02FE, // updated 7.05h
        CFNotify = 0x00D8, // updated 7.05h
        SystemLogMessage = 0x024E, // updated 7.05h
        AirshipTimers = 0x026D, // updated 7.05h
        SubmarineTimers = 0x020C, // updated 7.05h
        AirshipStatusList = 0x03BD, // updated 7.05h
        AirshipStatus = 0x02AA, // updated 7.05h
        AirshipExplorationResult = 0x0390, // updated 7.05h
        SubmarineProgressionStatus = 0x01DE, // updated 7.05h
        SubmarineStatusList = 0x016B, // updated 7.05h
        SubmarineExplorationResult = 0x01E8, // updated 7.05h

        CraftingLog = 0x028B, // updated 7.05h
        GatheringLog = 0x0380, // updated 7.05h

        ActorMove = 0x0163, // updated 7.05h

        EventPlay = 0x00CA, // updated 7.05h
        EventPlay4 = 0x023E, // updated 7.05h
        EventPlay8 = 0x0169, // updated 7.05h
        EventPlay16 = 0x034E, // updated 7.05h
        EventPlay32 = 0x0104, // updated 7.05h
        EventPlay64 = 0x0153, // updated 7.05h
        EventPlay128 = 0x0280, // updated 7.05h
        EventPlay255 = 0x0331, // updated 7.05h

        EnvironmentControl = 0x0339, // updated 7.05h
        IslandWorkshopSupplyDemand = 0x03D3, // updated 7.05h
        Logout = 0x027C, // updated 7.05h
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01F2, // updated 7.05h
        SetSearchInfoHandler = 0x03A9, // updated 7.05h
        MarketBoardPurchaseHandler = 0x0270, // updated 7.05h
        InventoryModifyHandler = 0x013A, // updated 7.05h
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}