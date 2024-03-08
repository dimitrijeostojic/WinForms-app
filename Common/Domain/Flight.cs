using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Flight : IEntity
    {
        public int FlightID { get; set; }
        public Airport DepartureAirportID { get; set; }
        public Airport ArrivalAirportID { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public Plane Plane { get; set; }
        public double TicketPrice { get; set; }
        public string CreatedBy { get; set; }




        public string TableName => "Flight";
        public string Values => $"{DepartureAirportID.AirportID},{ArrivalAirportID.AirportID},'{DepartureDate}','{ArrivalDate}','{DepartureTime}','{ArrivalTime}',{Plane.PlaneID},{TicketPrice},'{CreatedBy}'";
        public string UpdateValues => $"DepartureAirportID={DepartureAirportID.AirportID}, ArrivalAirportID={ArrivalAirportID.AirportID}, DepartureDate='{DepartureDate}',ArrivalDate='{ArrivalDate}', DepartureTime='{DepartureTime}', ArrivalTime='{ArrivalTime}',Plane={Plane.PlaneID}, TicketPrice={TicketPrice}, CreatedBy='{CreatedBy}'";
        public string WhereValues => $"Flight_id={FlightID}";
        string IEntity.SelectValues => "f.Flight_id as Flight_id,a.AirportName as DepartureAirportID,a1.AirportName as ArrivalAirportID,f.DepartureDate as DepartureDate,f.ArrivalDate as ArrivalDate,f.DepartureTime as DepartureTime,f.ArrivalTime as ArrivalTime,f.TicketPrice as TicketPrice,p.PlaneName as PlaneName, f.CreatedBy as CreatedBy, p.PlaneID as PlaneID,a.AirportID as DepAirportID, a1.AirportID as ArrAirportID";
        string IEntity.JoinCondition => "f join Plane p ON(f.Plane=p.PlaneID) join Airport a ON (f.DepartureAirportID=a.AirportID) join Airport a1 ON(f.ArrivalAirportID=a1.AirportID)";



        public string WhereF => "a.AirportName";
        public string WhereT => "a1.AirportName";
        public string WhereD => "f.DepartureDate";
        public object Where => "f.CreatedBy";
        public object ID => "flight_id";



        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> flights = new List<IEntity>();
            while (reader.Read())
            {
                Flight flight = new Flight()
                {
                    FlightID = (int)reader["Flight_id"],
                    DepartureDate = (string)reader["DepartureDate"],
                    ArrivalDate = (string)reader["ArrivalDate"],
                    DepartureTime = (string)reader["DepartureTime"],
                    ArrivalTime = (string)reader["ArrivalTime"],
                    TicketPrice = (double)reader["TicketPrice"],
                    Plane = new Plane()
                    {
                        PlaneID = (int)reader["PlaneID"],
                        PlaneName = (string)reader["PlaneName"]
                    },
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
                    CreatedBy = (string)reader["CreatedBy"]
                };
                flights.Add(flight);
            }
            return flights;
        }

        public override string ToString()
        {
            return FlightID.ToString();
        }
    }
}
