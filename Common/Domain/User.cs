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
    public class User : IEntity
    {
        public string JMBG { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }



        public string TableName => "User";
        public string Values => $"'{JMBG}','{FirstName}', '{LastName}', '{Username}', '{Password}', {(IsAdmin ? 1 : 0)}";
        public string UpdateValues => $"FirstName='{FirstName}', LastName='{LastName}',Username='{Username}', Password='{Password}'";
        public string WhereValues => $"Jmbg = '{JMBG}'";
        public object ID => "JMBG";



        public string SelectValues => "*";
        public string JoinCondition => "";
        public string WhereF => $"'{JMBG}'";
        public string WhereT => "";
        public string WhereD => "";

        public object Where => "Jmbg";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> users = new List<IEntity>();

            while (reader.Read())
            {
                User user = new User()
                {
                    JMBG = (string)reader["JMBG"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],
                    IsAdmin = (bool)reader["IsAdmin"]
                };
                users.Add(user);
            }
            return users;
        }

        public override string ToString()
        {
            return JMBG;
        }
    }
}
