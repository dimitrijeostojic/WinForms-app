using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetMyFlightsSO : SystemOperationBase
    {
        private User user;
        private Flight flight;
        public List<Flight> Result { get; set; }

        public GetMyFlightsSO(User user)
        {
            this.user = user;
            flight=new Flight();
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllWithWhere(user,flight).Cast<Flight>().ToList();
        }
    }
}
