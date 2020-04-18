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
        ActorCast = 0x032C, // updated 5.15
        ActorControl = 0x0366, // updated 5.15
        ActorControlSelf = 0x0179, // updated 5.15
        // ActorControlTarget
        ActorGauge = 0x0350, // updated 5.15
        ActorMove = 0x039e, // updated 5.15
        ActorSetPos = 0x0261, // updated 5.15
        AddStatusEffect = 0x0237, // updated 5.15
        AoeEffect16 = 0x0139, // updated 5.15
        AoeEffect24 = 0x038b, // updated 5.15
        AoeEffect32 = 0x00ff, // updated 5.15
        AoeEffect8 = 0x01B1, // updated 5.15
        BossStatusEffectList = 0x00b4, // updated 5.15
        CFNotify = 0x016D, // updated 5.15
        CFPreferredRole = 0x00A4, // updated 5.15
        Chat = 0x0078, // updated 5.15
        ContainerInfo = 0x028A, // updated 5.15
        CurrencyCrystalInfo = 0x0131, // updated 5.15
        Effect = 0x023E, // updated 5.15
        EventFinish = 0x01B9, // updated 5.15
        EventPlay = 0x0216, // updated 5.15
        EventPlay4 = 0x0214, // updated 5.15
        EventStart = 0x010E, // updated 5.15
        Examine = 0x00BD, // updated 5.15
        ExamineSearchInfo = 0x0236, // updated 5.15
        InitZone = 0x0345, // updated 5.15
        InventoryTransaction = 0x0202, // updated 5.15
        ItemInfo = 0x0268, // updated 5.15
        MarketBoardItemListing = 0x03CB, // updated 5.15
        MarketBoardItemListingCount = 0x00BE, // updated 5.15
        MarketBoardItemListingHistory = 0x02B4, // updated 5.15
        MarketBoardSearchResult = 0x0251, // updated 5.15
        MarketTaxRates = 0x03AC, // updated 5.15
        NpcSpawn = 0x0184, // updated 5.15
        NpcSpawn2 = 0x0128, // updated 5.15
        PlayerSetup = 0x0376, // updated 5.15
        PlayerSpawn = 0x029D, // updated 5.15
        PlayerStats = 0x0285, // updated 5.15
        Playtime = 0x0105, // updated 5.15
        RetainerInformation = 0x011e, // updated 5.15
        SomeDirectorUnk4 = 0x02BE, // updated 5.15
        StatusEffectList = 0x0399, // updated 5.15
        UpdateClassInfo = 0x03C5, // updated 5.15
        UpdateHpMpTp = 0x034A, // updated 5.15
        UpdateInventorySlot = 0x013C, // updated 5.15
        UpdateSearchInfo = 0x0311, // updated 5.15
    };
    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x02C5, // updated 5.15
        ClientTrigger = 0x025F, // updated 5.15
        InventoryModifyHandler = 0x038f, // updated 5.15
        SetSearchInfoHandler = 0x023B, // updated 5.15
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