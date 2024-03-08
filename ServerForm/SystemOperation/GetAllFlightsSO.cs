using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetAllFlightsSO : SystemOperationBase
    {
        public List<Flight> Result { get; set; }
        private Flight flight;
        public GetAllFlightsSO()
        {
            flight=new Flight();
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(flight).Cast<Flight>().ToList();
        }
    }
}
