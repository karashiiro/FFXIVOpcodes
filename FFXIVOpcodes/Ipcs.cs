namespace FFXIVOpcodes.Global
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
        // Server Zone
        PlayerSetup = 0x027F, // updated 6.35
        UpdateHpMpTp = 0x0394, // updated 6.35
        UpdateClassInfo = 0x020A, // updated 6.35
        PlayerStats = 0x00EE, // updated 6.35
        ActorControl = 0x01BB, // updated 6.35
        ActorControlSelf = 0x0228, // updated 6.35
        ActorControlTarget = 0x019D, // updated 6.35
        Playtime = 0x0301, // updated 6.35
        UpdateSearchInfo = 0x02B8, // updated 6.35
        ExamineSearchInfo = 0x00F9, // updated 6.35
        Examine = 0x03DC, // updated 6.35
        ActorCast = 0x0291, // updated 6.35
        CurrencyCrystalInfo = 0x0304, // updated 6.35
        InitZone = 0x037D, // updated 6.35
        WeatherChange = 0x0371, // updated 6.35
        PlayerSpawn = 0x0100, // updated 6.35
        ActorSetPos = 0x02E5, // updated 6.35
        PrepareZoning = 0x0099, // updated 6.35
        ContainerInfo = 0x01AD, // updated 6.35
        ItemInfo = 0x0220, // updated 6.35
        PlaceFieldMarker = 0x0160, // updated 6.35
        PlaceFieldMarkerPreset = 0x0090, // updated 6.35
        EffectResult = 0x037B, // updated 6.35
        EventStart = 0x008F, // updated 6.35
        EventFinish = 0x039A, // updated 6.35
        DesynthResult = 0x01DA, // updated 6.35
        FreeCompanyInfo = 0x0177, // updated 6.35
        FreeCompanyDialog = 0x00AC, // updated 6.35
        MarketBoardSearchResult = 0x031E, // updated 6.35
        MarketBoardItemListingCount = 0x032E, // updated 6.35
        MarketBoardItemListingHistory = 0x03B1, // updated 6.35
        MarketBoardItemListing = 0x03CB, // updated 6.35
        MarketBoardPurchase = 0x0243, // updated 6.35
        UpdateInventorySlot = 0x020D, // updated 6.35
        InventoryActionAck = 0x0256, // updated 6.35
        InventoryTransaction = 0x029F, // updated 6.35
        InventoryTransactionFinish = 0x035B, // updated 6.35
        ResultDialog = 0x0125, // updated 6.35
        RetainerInformation = 0x0168, // updated 6.35
        NpcSpawn = 0x01C0, // updated 6.35
        ItemMarketBoardInfo = 0x0130, // updated 6.35
        ObjectSpawn = 0x01F4, // updated 6.35
        EffectResultBasic = 0x01FB, // updated 6.35
        Effect = 0x00D4, // updated 6.35
        StatusEffectList = 0x02D4, // updated 6.35
        StatusEffectList2 = 0x03DE, // updated 6.35
        StatusEffectList3 = 0x0123, // updated 6.35
        ActorGauge = 0x0376, // updated 6.35
        CFNotify = 0x03C6, // updated 6.35
        SystemLogMessage = 0x00F7, // updated 6.35
        AirshipTimers = 0x01E5, // updated 6.35
        SubmarineTimers = 0x00A5, // updated 6.35
        AirshipStatusList = 0x0335, // updated 6.35
        AirshipStatus = 0x02F3, // updated 6.35
        AirshipExplorationResult = 0x028F, // updated 6.35
        SubmarineProgressionStatus = 0x0292, // updated 6.35
        SubmarineStatusList = 0x0076, // updated 6.35
        SubmarineExplorationResult = 0x0196, // updated 6.35

        ActorMove = 0x00B4, // updated 6.35

        EventPlay = 0x017F, // updated 6.35
        EventPlay4 = 0x00CA, // updated 6.35
        EventPlay8 = 0x0175, // updated 6.35
        EventPlay16 = 0x026A, // updated 6.35
        EventPlay32 = 0x0074, // updated 6.35
        EventPlay64 = 0x0255, // updated 6.35
        EventPlay128 = 0x0330, // updated 6.35
        EventPlay255 = 0x00DD, // updated 6.35

        EnvironmentControl = 0x0126, // updated 6.35
        IslandWorkshopSupplyDemand = 0x01B2, // updated 6.35
        Logout = 0x0181, // updated 6.35
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x02C3, // updated 6.35
        ClientTrigger = 0x0342, // updated 6.35
        ChatHandler = 0x02B0, // updated 6.35
        MarketBoardPurchaseHandler = 0x033B, // updated 6.35
        InventoryModifyHandler = 0x00E4, // updated 6.35 (Base offset: 0x00EB)
        UpdatePositionInstance = 0x0391, // updated 6.31h
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //Tell = 0x0064, // updated for sb
        //TellErrNotFound = 0x0066,

        //FreeCompanyEvent = 0x012C, // added 5.0
    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        //TellReq = 0x0064,
    };
}
