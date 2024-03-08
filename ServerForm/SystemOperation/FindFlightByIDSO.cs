using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class FindFlightByIDSO : SystemOperationBase
    {
        private Flight flight;
        private int argument;
        public List<Flight> Result1 { get; set; }
        public Flight Result { get; set; }
        public FindFlightByIDSO(object argument)
        {
            flight = new Flight();
            this.argument = (int)argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result1 = broker.GetByID(flight, argument).Cast<Flight>().ToList<Flight>();
            Result = Result1[0];
        }
    }
}
