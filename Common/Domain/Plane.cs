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
    public class Plane : IEntity
    {
        public int PlaneID { get; set; }
        public string PlaneName { get; set; }
        public int Capacity { get; set; }


        public string TableName => "Plane";
        public string Values => $"'{PlaneName}',{Capacity}";
        public object ID => "PlaneID";



        public string SelectValues => "*";
        public string JoinCondition => "";

        public string UpdateValues => "";

        public string WhereValues => "";
        public object Where => "";
        public string WhereF => "";
        public string WhereT => "";
        public string WhereD => "";


        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> planes = new List<IEntity>();
            while (reader.Read())
            {
                Plane p = new Plane()
                {
                    PlaneID = (int)reader["PlaneID"],
                    PlaneName = (string)reader["PlaneName"],
                    Capacity = (int)reader["Capacity"]
                };
                planes.Add(p);
            }
            return planes;
        }

        public override string ToString()
        {
            return PlaneName;
        }
    }
}
