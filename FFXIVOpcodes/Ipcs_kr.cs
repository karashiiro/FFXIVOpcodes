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
        ActorCast = 0x012C,// updated v5.35
        ActorControl = 0x017A,// updated v5.35
        ActorControlSelf = 0x007C,// updated v5.35
        ActorControlTarget = 0x0268,// updated v5.35
        ActorFreeSpawn = 0x010D,// updated v5.35
        ActorGauge = 0x0116,// updated v5.35
        ActorMove = 0x02F0,// updated v5.35
        ActorSetPos = 0x0306,// updated v5.35
        //AddStatusEffect = 0x0204,// updated v5.35
        AirshipExplorationResult = 0x032D, // updated v5.35
        AirshipStatus = 0x013F,// updated v5.35
        AirshipStatusList = 0x0130,// updated v5.35
        AirshipTimers = 0x017C,// updated v5.35
        AoeEffect16 = 0x02D1,// updated v5.35
        AoeEffect24 = 0x01A4,// updated v5.35
        AoeEffect32 = 0x016E,// updated v5.35
        AoeEffect8 = 0x0199,// updated v5.35
        //BossStatusEffectList = 0x0292, // updated 5.25
        CFNotify = 0x0088,// updated v5.35
        CFPreferredRole = 0x00EF,// updated v5.35
        CurrencyCrystalInfo = 0x0069,// updated v5.35
        DesynthResult = 0x00D4, // updated v5.35
        Effect = 0x02D0,// updated v5.35
        EffectResult = 0x0204,// updated v5.35
        EventFinish = 0x02EC,// updated v5.35
        EventPlay = 0x0121,// updated v5.35
        EventPlay32 = 0x02C3, // updated v5.35
        EventPlay4 = 0x034C,// updated v5.35
        EventStart = 0x028D,// updated v5.35
        Examine = 0x02F5,// updated v5.35
        ExamineFreeCompanyInfo = 0x0340, // updated v5.35
        ExamineSearchInfo = 0x039F,// updated v5.35
        FreeCompanyInfo = 0x01D3,// updated v5.35
        InitZone = 0x03BF,// updated v5.35
        InventoryActionAck = 0x02A5,// updated v5.35
        InventoryTransaction = 0x01E9,// updated v5.35
        InventoryTransactionFinish = 0x0157,// updated v5.35
        ItemInfo = 0x0287,// updated v5.35
        Logout = 0x011B, // updated v5.35
        MarketBoardItemListing = 0x0229,// updated v5.35
        MarketBoardItemListingCount = 0x03DE,// updated v5.35
        MarketBoardItemListingHistory = 0x0343,// updated v5.35
        MarketBoardPurchase = 0x03A8,// updated v5.35
        MarketBoardSearchResult = 0x018D,// updated v5.35
        MiniCactpotInit = 0x03CF,// updated v5.35
        NpcSpawn = 0x02FC,// updated v5.35
        ObjectSpawn = 0x01D8,// updated v5.35
        PlaceFieldMarker = 0x012F,// updated v5.35
        PlaceFieldMarkerPreset = 0x01F6,// updated v5.35
        PlayerSetup = 0x0304,// updated v5.35
        PlayerSpawn = 0x0171,// updated v5.35
        PlayerStats = 0x03DD,// updated v5.35
        Playtime = 0x00F0,// updated v5.35
        PrepareZoning = 0x01A0,// updated v5.35
        ResultDialog = 0x0236,// updated v5.35
        RetainerInformation = 0x023A,// updated v5.35
        SomeDirectorUnk4 = 0x0169,// updated v5.35
        StatusEffectList = 0x034B,// updated v5.35
        SubmarineExplorationResult = 0x030A, // updated v5.35
        SubmarineProgressionStatus = 0x03A0,// updated v5.35
        SubmarineStatusList = 0x03C6,// updated v5.35
        SubmarineTimers = 0x035D,// updated v5.35
        UpdateClassInfo = 0x0108,// updated v5.35
        UpdateHpMpTp = 0x0203,// updated v5.35
        UpdateInventorySlot = 0x026F,// updated v5.35
        UpdateSearchInfo = 0x0107,// updated v5.35
        WeatherChange = 0x0261, // updated v5.35
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00D9,// updated v5.35
        ClientTrigger = 0x03CB,// updated v5.35
        InventoryModifyHandler = 0x0086,// updated v5.35 (Base offset: 0x008D)
        LogoutHandler = 0x00B8, // updated v5.35
        MarketBoardPurchaseHandler = 0x00D1,// updated v5.35
        SetSearchInfoHandler = 0x01E1,// updated v5.35
        UpdatePositionHandler = 0x01F0,// updated v5.35
        UpdatePositionInstance = 0x01BE,// updated v5.35
    };
    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //    Tell = 0x0064, // updated for sb
        TellErrNotFound = 0x0066,
        FreeCompanyEvent = 0x012C, // added 5.0
    };
    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        TellReq = 0x0064,
    };
}
