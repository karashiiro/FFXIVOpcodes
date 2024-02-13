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
        PlayerSetup = 0x025F, // updated 6.57
        UpdateHpMpTp = 0x0398, // updated 6.57
        UpdateClassInfo = 0x00EA, // updated 6.57
        PlayerStats = 0x02B4, // updated 6.57
        ActorControl = 0x02CD, // updated 6.57
        ActorControlSelf = 0x032D, // updated 6.57
        ActorControlTarget = 0x03CD, // updated 6.57
        Playtime = 0x03AA, // updated 6.57
        UpdateSearchInfo = 0x023E, // updated 6.57
        ExamineSearchInfo = 0x019A, // updated 6.57
        Examine = 0x035E, // updated 6.57
        ActorCast = 0x01A5, // updated 6.57
        CurrencyCrystalInfo = 0x0186, // updated 6.57
        InitZone = 0x0230, // updated 6.57
        WeatherChange = 0x007F, // updated 6.57
        PlayerSpawn = 0x00DD, // updated 6.57
        ActorSetPos = 0x00AE, // updated 6.57
        PrepareZoning = 0x0333, // updated 6.57
        ContainerInfo = 0x0351, // updated 6.57
        ItemInfo = 0x032A, // updated 6.57
        PlaceFieldMarker = 0x021B, // updated 6.57
        PlaceFieldMarkerPreset = 0x0133, // updated 6.57
        EffectResult = 0x0382, // updated 6.57
        EventStart = 0x02C5, // updated 6.57
        EventFinish = 0x010B, // updated 6.57
        DesynthResult = 0x03C7, // updated 6.57
        FreeCompanyInfo = 0x0162, // updated 6.57
        FreeCompanyDialog = 0x0284, // updated 6.57
        MarketBoardSearchResult = 0x0305, // updated 6.57
        MarketBoardItemListingCount = 0x01FE, // updated 6.57
        MarketBoardItemListingHistory = 0x014A, // updated 6.57
        MarketBoardItemListing = 0x0237, // updated 6.57
        MarketBoardPurchase = 0x0176, // updated 6.57
        UpdateInventorySlot = 0x0224, // updated 6.57
        InventoryActionAck = 0x020A, // updated 6.57
        InventoryTransaction = 0x00C4, // updated 6.57
        InventoryTransactionFinish = 0x030D, // updated 6.57
        ResultDialog = 0x00A9, // updated 6.57
        RetainerInformation = 0x033E, // updated 6.57
        NpcSpawn = 0x027C, // updated 6.57
        ItemMarketBoardInfo = 0x0254, // updated 6.57
        ObjectSpawn = 0x0292, // updated 6.57
        EffectResultBasic = 0x01FB, // updated 6.57
        Effect = 0x013C, // updated 6.57
        StatusEffectList = 0x0289, // updated 6.57
        StatusEffectList2 = 0x036E, // updated 6.57
        StatusEffectList3 = 0x02E5, // updated 6.57
        ActorGauge = 0x01AF, // updated 6.57
        CFNotify = 0x022C, // updated 6.57
        SystemLogMessage = 0x0139, // updated 6.57
        AirshipTimers = 0x0172, // updated 6.57
        SubmarineTimers = 0x031D, // updated 6.57
        AirshipStatusList = 0x0205, // updated 6.57
        AirshipStatus = 0x01D7, // updated 6.57
        AirshipExplorationResult = 0x011E, // updated 6.57
        SubmarineProgressionStatus = 0x03C8, // updated 6.57
        SubmarineStatusList = 0x0124, // updated 6.57
        SubmarineExplorationResult = 0x0077, // updated 6.57

        ActorMove = 0x034D, // updated 6.57

        EventPlay = 0x01A7, // updated 6.57
        EventPlay4 = 0x03BB, // updated 6.57
        EventPlay8 = 0x0325, // updated 6.57
        EventPlay16 = 0x0241, // updated 6.57
        EventPlay32 = 0x031F, // updated 6.57
        EventPlay64 = 0x037E, // updated 6.57
        EventPlay128 = 0x0316, // updated 6.57
        EventPlay255 = 0x03A8, // updated 6.57

        EnvironmentControl = 0x008D, // updated 6.57
        IslandWorkshopSupplyDemand = 0x0166, // updated 6.57
        Logout = 0x01B3, // updated 6.57
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        UpdatePositionHandler = 0x01A1, // updated 6.57
        ClientTrigger = 0x02CC, // updated 6.57
        //ChatHandler = 0x01C1, // updated 6.5
        SetSearchInfoHandler = 0x02B1, // updated 6.57
        MarketBoardPurchaseHandler = 0x0277, // updated 6.57
        InventoryModifyHandler = 0x0229, // updated 6.57
        UpdatePositionInstance = 0x0260, // updated 6.57
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