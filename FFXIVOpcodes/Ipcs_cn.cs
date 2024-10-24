// Generated by https://github.com/zhyupe/ffxiv-opcode-worker

namespace FFXIVOpcodes.CN
{
    public enum ServerLobbyIpcType : ushort
    {

    };

    public enum ClientLobbyIpcType : ushort
    {

    };

    public enum ServerZoneIpcType : ushort
    {
        ActorCast = 0x0247,
        ActorControl = 0x0311,
        ActorControlSelf = 0x01A9,
        ActorControlTarget = 0x030E,
        ActorGauge = 0x024C,
        ActorMove = 0x02BB,
        ActorSetPos = 0x0232,
        AirshipExplorationResult = 0x0156,
        AirshipStatus = 0x00BD,
        AirshipStatusList = 0x033A,
        AirshipTimers = 0x018B,
        AoeEffect16 = 0x02BE,
        AoeEffect24 = 0x00C5,
        AoeEffect32 = 0x0372,
        AoeEffect8 = 0x0301,
        BossStatusEffectList = 0x0103,
        CEDirector = 0x02C9,
        CFNotify = 0x00BF,
        CFPreferredRole = 0x023C,
        ContainerInfo = 0x00D4,
        Countdown = 0x0146,
        CountdownCancel = 0x00B2,
        CurrencyCrystalInfo = 0x01db,
        DesynthResult = 0x035e,
        Effect = 0x029E,
        EffectResult = 0x0179,
        EnvironmentControl = 0x0191,
        EventFinish = 0x02D0,
        EventPlay = 0x039a,
        EventPlay32 = 0x03cf,
        EventPlay4 = 0x01a2,
        EventStart = 0x01E5,
        Examine = 0x02DD,
        ExamineSearchInfo = 0x0184,
        FateInfo = 0x00A3,
        FreeCompanyDialog = 0x01F8,
        FreeCompanyInfo = 0x016C,
        HousingWardInfo = 0x024A,
        InitZone = 0x025D,
        InventoryActionAck = 0x03AC,
        InventoryTransaction = 0x0356,
        InventoryTransactionFinish = 0x027A,
        IslandWorkshopSupplyDemand = 0x03BB,
        ItemInfo = 0x0110,
        ItemMarketBoardInfo = 0x0074,
        Logout = 0x00E0,
        MarketBoardItemListing = 0x0171,
        MarketBoardItemListingCount = 0x03c6,
        MarketBoardItemListingHistory = 0x0382,
        MarketBoardPurchase = 0x00C6,
        MarketBoardSearchResult = 0x0335,
        MiniCactpotInit = 0x0089,
        NpcSpawn = 0x021A,
        NpcSpawn2 = 0x024B,
        NpcYell = 0x00E4,
        ObjectSpawn = 0x012B,
        PlaceFieldMarker = 0x0374,
        PlaceFieldMarkerPreset = 0x0213,
        PlayerSetup = 0x0212,
        PlayerSpawn = 0x0134,
        PlayerStats = 0x03E6,
        Playtime = 0x0298,
        PrepareZoning = 0x0313,
        RetainerInformation = 0x0260,
        RSV = 0x016D,
        StatusEffectList = 0x0080,
        StatusEffectList2 = 0x01F1,
        StatusEffectList3 = 0x00A4,
        SubmarineExplorationResult = 0x00EB,
        SubmarineProgressionStatus = 0x0079,
        SubmarineStatusList = 0x031C,
        SubmarineTimers = 0x0371,
        SystemLogMessage = 0x0087,
        UpdateClassInfo = 0x038e,
        UpdateHpMpTp = 0x00DE,
        UpdateInventorySlot = 0x03A8,
        UpdateSearchInfo = 0x03A3,
        WeatherChange = 0x018a,
    };

    public enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00C7,
        ClientTrigger = 0x01F8,
        InventoryModifyHandler = 0x0201,
        MarketBoardPurchaseHandler = 0x016D,
        MarketBoardRequestItemListingInfo = 0x0142,
        SetSearchInfoHandler = 0x03CA,
        UpdatePositionHandler = 0x02F0,
        UpdatePositionInstance = 0x021A,
    };

    public enum ServerChatIpcType : ushort
    {

    };

    public enum ClientChatIpcType : ushort
    {

    };
}
