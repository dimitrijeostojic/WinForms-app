using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class SaveFlightSO : SystemOperationBase
    {
        private Flight flight;

        public SaveFlightSO(Flight flight)
        {
            this.flight = flight;
        }
        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Create(flight);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
