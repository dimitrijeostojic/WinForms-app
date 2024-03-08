using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string SelectValues { get; }
        string JoinCondition { get; }
        string UpdateValues { get; }
        string WhereValues { get; }
        string WhereF { get; }
        string WhereT { get; }
        string WhereD { get; }
        object ID { get; }
        object Where { get; }

        List<IEntity> GetReaderList(SqlDataReader reader);

    }
}
