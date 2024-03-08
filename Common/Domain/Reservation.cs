using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Reservation : IEntity
    {
        public Flight Flight_id { get; set; }
        public User Jmbg { get; set; }
        public int NumOfSeats { get; set; }



        public string TableName => "Reservation";
        public string Values => $"{Flight_id},'{Jmbg}',{NumOfSeats}";




        public string SelectValues => "r.Flight_id as FlightID,a.AirportName as DepartureAirportID,a1.AirportName as ArrivalAirportID,f.DepartureDate as DepartureDate,a.AirportID as DepAirportID, a1.AirportID as ArrAirportID,r.Jmbg as Jmbg, r.NumOfSeats as NumOfSeats";
        public string JoinCondition => "r join Flight f on(r.Flight_id=f.Flight_id) join Airport a ON (f.DepartureAirportID=a.AirportID) join Airport a1 ON(f.ArrivalAirportID=a1.AirportID)";
        public string UpdateValues => $"NumOfSeats={NumOfSeats}";
        public string WhereValues => $"Flight_id={Flight_id} and Jmbg={Jmbg}";
        public string WhereF => "";
        public string WhereT => "";
        public string WhereD => "";
        public object ID => "r.Flight_id";

        public object Where => "Jmbg";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> reservations = new List<IEntity>();
            while (reader.Read())
            {
                Reservation reservation = new Reservation()
                {
                    Flight_id = new Flight()
                    {
                        FlightID = (int)reader["FlightID"],
                        DepartureAirportID = new Airport
                        {
                            AirportID = (int)reader["DepAirportID"],
                            AirportName = (string)reader["DepartureAirportID"]
                        },
                        ArrivalAirportID = new Airport
                        {
                            AirportID = (int)reader["ArrAirportID"],
                            AirportName = (string)reader["ArrivalAirportID"]
                        },
                    },
                    Jmbg = new User()
                    {
                        JMBG = (string)reader["Jmbg"]
                    },
                    NumOfSeats = (int)reader["NumOfSeats"]
                };

                reservations.Add(reservation);
            }
            return reservations;
        }
    }
}
