using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Airport : IEntity
    {
        public int AirportID { get; set; }
        public string AirportName { get; set; }


        public string TableName => "Airport";
        public string Values => $"'{AirportName}'";
        public object ID => "AirportID";


        public string SelectValues => "*";
        public string JoinCondition => "";
        public string UpdateValues => "";
        public string WhereValues => "";
        public string WhereF => "";
        public string WhereT => "";
        public string WhereD => "";
        public object Where => "";


        public override string ToString()
        {
            return $"{AirportName}";
        }

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            List<IEntity> airports = new List<IEntity>();
            while (reader.Read())
            {
                Airport airport = new Airport
                {
                    AirportID = (int)reader["AirportID"],
                    AirportName = (string)reader["AirportName"]
                };
                airports.Add(airport);
            }
            return airports;
        }
    }
}
