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
        ActorCast = 0x0310, // updated 5.25
        ActorControl = 0x03B6, // updated 5.25
        ActorControlSelf = 0x0200, // updated 5.25
        ActorControlTarget = 0x01DE, // updated 5.25
        ActorFreeSpawn = 0x03E0, // updated 5.25
        ActorGauge = 0x02F9, // updated 5.25
        ActorMove = 0x0117, // updated 5.25
        ActorSetPos = 0x01DA, // updated 5.25
        EffectResult = 0x0280, // updated 5.25
        AoeEffect16 = 0x0173, // updated 5.25
        AoeEffect24 = 0x02A1, // updated 5.25
        AoeEffect32 = 0x0129, // updated 5.25
        AoeEffect8 = 0x0305, // updated 5.25
        BossStatusEffectList = 0x0292, // updated 5.25
        CFNotify = 0x0242, // updated 5.25
        CFPreferredRole = 0x02F1, // updated 5.25
        // CraftEfficiencyCalculations = 0x00F5, // updated 5.25
        CurrencyCrystalInfo = 0x00E6, // updated 5.25
        Effect = 0x0198, // updated 5.25
        EventFinish = 0x02C2, // updated 5.25
        EventPlay = 0x011E, // updated 5.25
        EventPlay4 = 0x02F3, // updated 5.25
        EventPlay32 = 0x0157, // updated 5.25
        EventStart = 0x0272, // updated 5.25
        Examine = 0x01E4, // updated 5.25
        ExamineSearchInfo = 0x01A2, // updated 5.25
        InitZone = 0x00BA, // updated 5.25
        InventoryActionAck = 0x0344, // updated 5.25
        InventoryTransaction = 0x02A3, // updated 5.25
        InventoryTransactionFinish = 0x013F, // updated 5.25
        ItemInfo = 0x0228, // updated 5.25
        MarketBoardItemListing = 0x0191, // updated 5.25
        MarketBoardItemListingCount = 0x00F0, // updated 5.25
        MarketBoardItemListingHistory = 0x01C3, // updated 5.25
        MarketBoardSearchResult = 0x0277, // updated 5.25
        MarketTaxRates = 0x03E4, // updated 5.25
        MiniCactpotInit = 0x0114, // updated 5.25
        NpcSpawn = 0x023E, // updated 5.25
        ObjectSpawn = 0x01F2, // updated 5.25
        PlaceFieldMarker = 0x03E2, // updated 5.25
        PlaceFieldMarkerPreset = 0x031B, // updated 5.25
        PlayerSetup = 0x0269, // updated 5.25
        PlayerSpawn = 0x019B, // updated 5.25
        PlayerStats = 0x007D, // updated 5.25
        Playtime = 0x02EB, // updated 5.25
        RetainerInformation = 0x0078, // updated 5.25
        ServerNotice = 0x02A9, // updated 5.25
        SomeDirectorUnk4 = 0x02DA, // updated 5.25
        StatusEffectList = 0x013D, // updated 5.25
        UpdateClassInfo = 0x024E, // updated 5.25
        UpdateHpMpTp = 0x03BE, // updated 5.25
        UpdateInventorySlot = 0x00A3, // updated 5.25
        UpdateSearchInfo = 0x00B2, // updated 5.25
        WeatherChange = 0x025B, // updated 5.25
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x01E6, // updated 5.25
        ClientTrigger = 0x01E5, // updated 5.25
        InventoryModifyHandler = 0x0393, // updated 5.25 (Base offset: 0x039A)
        SetSearchInfoHandler = 0x01C5, // updated 5.25
        UpdatePositionHandler = 0x015F, // updated 5.25
        UpdatePositionInstance = 0x0117, // updated 5.25
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