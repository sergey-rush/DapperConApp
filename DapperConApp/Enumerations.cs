namespace DapperConApp
{


    public enum ItemStatus
    {
         None = 0,
        OnSale = 1,
         Locked = 2,
         Reserved = 3,
         Sold = 4,
         Removed = 5,
         Returned = 6,
         Cancelled = 7,
         OnRetail = 8,
        OnStock = 9,
        Deleted = 10,
        Printed = 11,
         OnOrderCreating = 12,
         BookingChanged = 13,
        ToBePrinted = 14,
         Valid = 15,
        MoveRow = 16,
         MoveSeat = 17
    }

    public enum TokenType
    {
        None = 0,
        Cashier = 1,
        Widget = 2,
        Partner = 3
    }

    public enum ReportType
    {
        None = 0,
        Summary = 1,
        Provider = 2,
        Action = 3,
        Event = 4,
        Blank = 5,
        EventSaleInvoice = 6,
        Cashiers = 7,
        CashierDaily = 8
    }

    public enum ActionType
    {
        
        Circus = 1,
        
        Cinema = 2,
       
        None = 0,
    }

    public enum ApiMethod
    {
        None = 0,
        Login = 1,
        Stage = 2,
        Providers = 3,
        Actions = 4,
        Action = 5,
        Events = 6,
        Event = 7,
        SeatStats = 8,
        SeatingMap = 9,
        MapSeatPoints = 10,
        Seat = 11,
        Print = 12,
        Orders = 13,
        Tickets = 14,
        Customer = 15,
        Blanks = 16,
        Create = 17,
        Update = 18,
        Confirm = 19,
        Cancel = 20,
        Lock = 21,
        Release = 22,
        Log = 23,
        Message = 24,
        Printed = 25,
        Annul = 26,
        Move = 26,
        Seats = 27,
        Reports = 28,
        Report = 29
    }

    public enum YandexMethod
    {
        None = 0,
        CheckOrder = 1,
        Aviso = 2
    }

    public enum PaymentType
    {
        
        Card = 1,
        
        Cash = 2,
        
        NonCash = 3
    }

    public enum MailStatus
    {
        None = 0,
        Sent = 1
    }

    /// <summary>
    /// Message formats
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// The body is composed of html content
        /// </summary>
        Html,
        /// <summary>
        /// The body is pure text
        /// </summary>
        Text
    }

    public enum AttachmentEncoding
    {
        Base64,
        UUEncode
    }

    /// <summary>
    /// Message priority
    /// </summary>
    public enum MessagePriority
    {
        Normal,
        High,
        Low
    }

    public enum PaymentResult
    {
        None = 0,
        PaymentSuccess = 1,
        PaymentFaied = 2
    }
}