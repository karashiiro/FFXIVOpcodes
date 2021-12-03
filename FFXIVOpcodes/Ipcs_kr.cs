namespace FFXIVOpcodes.KR
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
        // ActorFreeSpawn = 0x01F9, // v5.41
        // AddStatusEffect = 0x0119, // updated v5.4
        // BossStatusEffectList = 0x0292, // updated 5.25
        ActorCast = 0x0221, // 5.57
        ActorControl = 0x01CC, // 5.57
        ActorControlSelf = 0x00D6, // 5.57
        ActorControlTarget = 0x0126, // 5.57
        ActorGauge = 0x02FC, // 5.57
        ActorMove = 0x03AE, // 5.57
        ActorSetPos = 0x02A0, // 5.57
        AirshipExplorationResult = 0x033C, // 5.57
        AirshipStatus = 0x0117, // 5.57
        AirshipStatusList = 0x016B, // 5.57
        AirshipTimers = 0x028F, // 5.57
        AoeEffect16 = 0x00C4, // 5.57
        AoeEffect24 = 0x00AA, // 5.57
        AoeEffect32 = 0x022D, // 5.57
        AoeEffect8 = 0x021D, // 5.57
        CFNotify = 0x020F, // 5.57
        CFPreferredRole = 0x019E, // 5.57
        ContainerInfo = 0x03B8, // 5.57
        CurrencyCrystalInfo = 0x034C, // 5.57
        DesynthResult = 0x020D, // 5.57
        Effect = 0x03CE, // 5.57
        EffectResult = 0x015B, // 5.57
        EventFinish = 0x01E2, // 5.57
        EventPlay = 0x013D, // 5.57
        EventPlay32 = 0x009B, // 5.57
        EventPlay4 = 0x0369, // 5.57
        EventStart = 0x039A, // 5.57
        Examine = 0x02B0, // 5.57
        ExamineFreeCompanyInfo = 0x02AB, // 5.57
        ExamineSearchInfo = 0x025B, // 5.57
        FreeCompanyDialog = 0x019D, // 5.57
        FreeCompanyInfo = 0x0078, // 5.57
        HousingWardInfo = 0x02B5, // 5.57
        InitZone = 0x01F6, // 5.57
        InventoryActionAck = 0x037E, // 5.57
        InventoryTransaction = 0x0157, // 5.57
        InventoryTransactionFinish = 0x02F4, // 5.57
        ItemInfo = 0x00D7, // 5.57
        ItemMarketBoardInfo = 0x030E, // 5.57
        Logout = 0x0278, // 5.57
        MarketBoardItemListing = 0x00C0, // 5.57
        MarketBoardItemListingCount = 0x017D, // 5.57
        MarketBoardItemListingHistory = 0x024C, // 5.57
        MarketBoardPurchase = 0x01B8, // 5.57
        MarketBoardSearchResult = 0x02A5, // 5.57
        MiniCactpotInit = 0x0146, // 5.57
        NpcSpawn = 0x02EB, // 5.57
        ObjectSpawn = 0x0250, // 5.57
        PlaceFieldMarker = 0x02D6, // 5.57
        PlaceFieldMarkerPreset = 0x027F, // 5.57
        PlayerSetup = 0x018A, // 5.57
        PlayerSpawn = 0x010F, // 5.57
        PlayerStats = 0x03E4, // 5.57
        Playtime = 0x03DF, // 5.57
        PrepareZoning = 0x0311, // 5.57
        ResultDialog = 0x0206, // 5.57
        RetainerInformation = 0x03B3, // 5.57
        SomeDirectorUnk4 = 0x00FA, // 5.57
        StatusEffectList = 0x0332, // 5.57
        StatusEffectList2 = 0x0305, // 5.57
        SubmarineExplorationResult = 0x0381, // 5.57
        SubmarineProgressionStatus = 0x026F, // 5.57
        SubmarineStatusList = 0x0389, // 5.57
        SubmarineTimers = 0x032D, // 5.57
        UpdateClassInfo = 0x0183, // 5.57
        UpdateHpMpTp = 0x01EF, // 5.57
        UpdateInventorySlot = 0x02EC, // 5.57
        UpdateSearchInfo = 0x02E8, // 5.57
        WeatherChange = 0x031A, // 5.57
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00EA, // 5.57
        ClientTrigger = 0x0193, // 5.57
        InventoryModifyHandler = 0x007C, // 5.57 (Base offset: 0x0083)
        LogoutHandler = 0x0257, // 5.57
        MarketBoardPurchaseHandler = 0x01FE, // 5.57
        SetSearchInfoHandler = 0x0090, // 5.57
        UpdatePositionHandler = 0x00E5, // 5.57
        UpdatePositionInstance = 0x03AE, // 5.57
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {

    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {

    };
}
