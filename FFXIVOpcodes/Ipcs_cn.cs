namespace FFXIVOpcodes.CN
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
        ActorCast = 0x012E, // updated 5.11
        ActorControl = 0x00C1, // updated 5.11
        ActorControlSelf = 0x011F, // updated 5.11
        ActorControlTarget = 0x010B, // updated 5.11
        ActorMove = 0x035E, // updated 5.11
        ActorSetPos = 0x00E5, // updated 5.11
        AoeEffect16 = 0x0233, // updated 5.11
        AoeEffect24 = 0x03d8, // updated 5.11
        AoeEffect32 = 0x03c7, // updated 5.11
        AoeEffect8 = 0x0211, // updated 5.11
        CFNotifyPop = 0x0377, // updated 5.11
        CFPreferredRole = 0x0194, // updated 5.11
        Chat = 0x00bb, // updated 5.11
        ContainerInfo = 0x038D, // updated 5.11
        CurrencyCrystalInfo = 0x0207, // updated 5.11
        Effect = 0x01c8, // updated 5.11
        EventFinish = 0x03E7, // updated 5.11
        EventPlay4 = 0x00D5, // updated 5.11
        EventPlay = 0x00FA, // updated 5.11
        EventStart = 0x0118, // updated 5.11
        Examine = 0x0252, // updated 5.11
        ExamineSearchInfo = 0x0243, // updated 5.11
        InitZone = 0x035D, // updated 5.11
        InventoryTransaction = 0x0244, // updated 5.11
        ItemInfo = 0x026B, // updated 5.11
        MarketBoardItemListing = 0x039B, // updated 5.11
        MarketBoardItemListingCount = 0x00A2, // updated 5.11
        MarketBoardItemListingHistory = 0x0370, // updated 5.11
        MarketBoardSearchResult = 0x00C2, // updated 5.11
        MarketTaxRates = 0x0205, // updated 5.11
        NpcSpawn2 = 0x0225, // updated 5.11
        NpcSpawn = 0x0111, // updated 5.11
        PlayerSetup = 0x0216, // updated 5.11
        PlayerSpawn = 0x022F, // updated 5.11
        PlayerStats = 0x031E, // updated 5.11
        Playtime = 0x013C, // updated 5.11
        RetainerInformation = 0x02f0, // updated 5.11
        SomeDirectorUnk4 = 0x016E, // updated 5.11
        StatusEffectList = 0x018b, // updated 5.11
        UpdateClassInfo = 0x02E5, // updated 5.11
        UpdateHpMpTp = 0x0084, // updated 5.11
        UpdateInventorySlot = 0x011E, // updated 5.11
        UpdateSearchInfo = 0x01D6, // updated 5.11
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x00A7, // updated 5.11
        ClientTrigger = 0x01DE, // updated 5.11
        SetSearchInfoHandler = 0x01A9, // updated 5.11
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
