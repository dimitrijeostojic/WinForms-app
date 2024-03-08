using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class DeleteReservationSO : SystemOperationBase
    {
        private Reservation reservation;
        public DeleteReservationSO(object argument)
        {
            reservation = (Reservation)argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Delete(reservation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
