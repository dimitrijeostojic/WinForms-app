using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class DeleteFlightSO : SystemOperationBase
    {
        private Flight flight;
        public DeleteFlightSO(Flight flight)
        {
            this.flight = flight;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Delete(flight);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
