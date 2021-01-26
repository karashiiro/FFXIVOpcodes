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
        ActorCast = 0x03B8, // updated v5.3
        ActorControl = 0x013D, // updated v5.3
        ActorControlSelf = 0x025F, // updated v5.3
        ActorControlTarget = 0x0085, // updated v5.3
        ActorFreeSpawn = 0x0315, // updated v5.3
        ActorGauge = 0x014B, // updated v5.3
        ActorMove = 0x02E6, // updated v5.3
        ActorSetPos = 0x0164, // updated v5.3
        //AddStatusEffect = 0x0156, // updated v5.3
        AoeEffect16 = 0x03A7, // updated v5.3
        AoeEffect24 = 0x016B, // updated v5.3
        AoeEffect32 = 0x0231, // updated v5.3
        AoeEffect8 = 0x0167, // updated v5.3
        //BossStatusEffectList = 0x0292, // updated 5.25
        CFNotify = 0x022C, // updated v5.3
        CFPreferredRole = 0x02B9, // updated v5.3
        //CraftEfficiencyCalculations = 0x018F, // updated v5.3
        CurrencyCrystalInfo = 0x0335, // updated v5.3
        DesynthResult = 0x010A, // updated v5.3
        Effect = 0x0266, // updated v5.3
        EffectResult = 0x0156, // updated v5.3
        EventFinish = 0x0147, // updated v5.3
        EventPlay = 0x03B3, // updated v5.3
        EventPlay4 = 0x0071, // updated v5.3
        EventPlay32 = 0x0154, // updated v5.3
        EventStart = 0x008B, // updated v5.3
        Examine = 0x017B, // updated v5.3
        ExamineSearchInfo = 0x01E5, // updated v5.3
        InitZone = 0x0078, // updated v5.3
        InventoryActionAck = 0x01D6, // updated v5.3
        InventoryTransaction = 0x019A, // updated v5.3
        InventoryTransactionFinish = 0x039F, // updated v5.3
        ItemInfo = 0x00A6, // updated v5.3
        Logout = 0x283, // updated v5.3
        MarketBoardItemListing = 0x032C, // updated v5.3
        MarketBoardItemListingCount = 0x0074, // updated v5.3
        MarketBoardItemListingHistory = 0x0102, // updated v5.3
        MarketBoardSearchResult = 0x00AF, // updated v5.3
        MarketTaxRates = 0x02A6, // updated v5.3
        MiniCactpotInit = 0x0316, // updated v5.3
        NpcSpawn = 0x02B2, // updated v5.3
        ObjectSpawn = 0x019C, // updated v5.3
        PlaceFieldMarker = 0x0086, // updated v5.3
        PlaceFieldMarkerPreset = 0x00E9, // updated v5.3
        PlayerSetup = 0x039E, // updated v5.3
        PlayerSpawn = 0x038A, // updated v5.3
        PlayerStats = 0x0230, // updated v5.3
        Playtime = 0x0212, // updated v5.3
        PrepareZoning = 0x0166, // updated v5.3
        RetainerInformation = 0x01F8, // updated v5.3
        ServerNotice = 0x01B8, // updated v5.3
        SomeDirectorUnk4 = 0x023E, // updated v5.3
        StatusEffectList = 0x0314, // updated v5.3
        UpdateClassInfo = 0x00B3, // updated v5.3
        UpdateHpMpTp = 0x02A3, // updated v5.3
        UpdateInventorySlot = 0x0250, // updated v5.3
        UpdateSearchInfo = 0x0364, // updated v5.3
        WeatherChange = 0x03D7, // updated v5.3
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00BF, // updated v5.3
        ClientTrigger = 0x033A, // updated v5.3
        InventoryModifyHandler = 0x019A, // updated v5.3 (Base offset: 0x01A1)
        SetSearchInfoHandler = 0x0303, // updated v5.3
        UpdatePositionHandler = 0x017D, // updated v5.3
        UpdatePositionInstance = 0x0067, // updated v5.3
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