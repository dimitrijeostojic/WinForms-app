using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Request
    {
        public Operations Operacija { get; set; }
        public object Argument { get; set; }
        public object User { get; set; }
        public string SearchType { get; set; }
    }
}
