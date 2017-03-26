using System;
using System.Xml.Serialization;

namespace DapperConApp
{
    public class Seat
    {
        [XmlIgnore]
        public int SeatsCount { get; set; }
        
        [XmlIgnore]
        public int ActionsCount { get; set; }
        
        [XmlIgnore]
        public int EventsCount { get; set; }
        
        [XmlIgnore]
        public decimal SeatsPrice { get; set; }
        
        [XmlIgnore]
        public int OrderId { get; set; }
        
        [XmlIgnore]
        public decimal AveragePrice { get; set; }
        
        [XmlIgnore]
        public int MemberId { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// Identifier of a seat.  
        /// </summary>
        
        [XmlIgnore]
        public int SeatId { get; set; }
        
        public int ActionId { get; set; }
        public decimal Price { get; set; }
        
        public ItemStatus Status { get; set; }
        
        [XmlIgnore]
        public DateTime SoldDate { get; set; }
        
        [XmlIgnore]
        public int ProviderId { get; set; }
        
        [XmlIgnore]
        public string CityName { get; set; }

        
        [XmlIgnore]
        public string ProviderName { get; set; }

        
        [XmlIgnore]
        public string ActionName { get; set; }

        
        [XmlIgnore]
        public DateTime CreatedDate { get; set; }
        
        [XmlIgnore]
        public string Month { get; set; }
        
        private string _description = string.Empty;
        
        [XmlIgnore]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _name = string.Empty;
        
        [XmlIgnore]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _barCode = string.Empty;
        /// <summary>
        /// Local system barcode of 12 symbols
        /// </summary>
        
        public string BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }
        /// <summary>
        /// Identifier of an event. EventId is a foreign key for EventDates table 
        /// </summary>
        
        public int EventId { get; set; }

        
        
        public DateTime ActionDate { get; set; }

        private string _rowNum = string.Empty;

        public string RowNum
        {
            get { return _rowNum; }
            set { _rowNum = value; }
        }

        private string _seatNum = string.Empty;

        public string SeatNum
        {
            get { return _seatNum; }
            set { _seatNum = value; }
        }

        private string _sideName = string.Empty;

        public string SideName
        {
            get { return _sideName; }
            set { _sideName = value; }
        }

        private string _sectorName = string.Empty;

        public string SectorName
        {
            get { return _sectorName; }
            set { _sectorName = value; }
        }

        private string _extBarCode = string.Empty;
        /// <summary>
        /// External system barcode of 12 symbols
        /// </summary>
        public string ExtBarCode
        {
            get { return _extBarCode; }
            set { _extBarCode = value; }
        }

        private DateTime _reserveDate= DateTime.MinValue;
        /// <summary>
        /// The UTC date and time a seat is reserved up to
        /// </summary>
        public DateTime ReserveDate
        {
            get { return _reserveDate; }
            set { _reserveDate = value; }
        }
        
        public int BlankId { get; set; }
        
        
        [XmlIgnore]
        public Int64 AliasId { get; set; }
        
        [XmlIgnore]
        public int TrackId { get; set; }

        
        [XmlIgnore]
        public int MinNum { get; set; }
        
        [XmlIgnore]
        public int MaxNum { get; set; }

        
        [XmlIgnore]
        public string SeatRange
        {
            get
            {
                if (MinNum == MaxNum)
                    return MinNum.ToString();

                return MinNum + " - " + MaxNum;
            }
        }

        
        [XmlIgnore]
        public Double PriceAsDouble
        {
            get { return (Double)(Price); }
        }

        
        [XmlIgnore]
        public Double TotalPriceAsDouble
        {
            get { return (Double)(TotalPrice); }
        }
        
        [XmlIgnore]
        public decimal TotalPrice { get; set; }

    }
}