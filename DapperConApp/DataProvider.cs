using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace DapperConApp
{
    public class DataProvider : DataManager
    {
        public override int CountSeats(int actionId, int eventId, int memberId, int statusId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ActionId", actionId);
            parameters.Add("@EventId", eventId);
            parameters.Add("@MemberId", memberId);
            parameters.Add("@StatusId", statusId);
            int returnValue = 0;
            using (var cn = OpenConnection())
            {
                returnValue = cn.ExecuteScalar<int>("Seats_CountSeats", parameters, commandType: CommandType.StoredProcedure);
            }
            return returnValue;
        }

        public override Seat GetSeatBySeatId(int seatId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SeatId", seatId);

            using (var cn = OpenConnection())
            {
                Seat seat = cn.Query<Seat>("Seats_GetSeatBySeatId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return seat;
            }
        }

        public override IEnumerable<Seat> GetSeats(int memberId, int eventId, int statusId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MemberId", memberId);
            parameters.Add("@EventId", eventId);
            parameters.Add("@StatusId", statusId);

            //var RS = conx.Execute("UserlogincheckMVC", parameters, null, null, commandType: CommandType.StoredProcedure);
            //int result = parameters.Get<int>("@RESULT");

            using (var cn = OpenConnection())
            {
                IEnumerable<Seat> seats = cn.Query<Seat>("Seats_GetSeats", parameters, commandType: CommandType.StoredProcedure);
                return seats;
            }
        }

        public override int CountSeats(int actionId, int eventId, int memberId, int statusId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ActionId", actionId);
            parameters.Add("@EventId", eventId);
            parameters.Add("@MemberId", memberId);
            parameters.Add("@StatusId", statusId);
            int returnValue = 0;
            using (var cn = OpenConnection())
            {
                returnValue = cn.ExecuteScalar<int>("Seats_CountSeats", parameters, commandType: CommandType.StoredProcedure);
            }
            return returnValue;
        }

        public override Seat GetSingleSeat(int seatId)
        {
            const string sql = @"SELECT * FROM Seats WHERE Id=@SeatId";

            using (var cn = OpenConnection())
            {
                return cn.Query<Seat>(sql, new { SeatId = seatId }).FirstOrDefault();
            }
        }
    }
}