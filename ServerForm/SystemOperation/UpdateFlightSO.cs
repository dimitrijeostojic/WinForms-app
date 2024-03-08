using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class UpdateFlightSO : SystemOperationBase
    {
        private Flight flight;
        public bool Result { get; set; }
        public UpdateFlightSO(Flight flight)
        {
            this.flight = flight;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Update(flight);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
