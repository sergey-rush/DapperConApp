using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DapperConApp
{
    public abstract class DataManager : DataAccess
    {
        private static DataManager _instance;

        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
        }

        public abstract Seat GetSeatBySeatId(int seatId);
        public abstract IEnumerable<Seat> GetSeats(int memberId, int eventId, int statusId);
        public abstract Seat GetSingleSeat(int seatId);

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                
            }
            catch (Exception ex)
            {
                if (connection != null)
                    connection.Dispose();
                throw new Exception("DataManager.OpenConnection", ex);
            }
            return connection;
        }
    }
}