using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class UpdateAllReservationsSO : SystemOperationBase
    {
        private List<Reservation> reservations;

        public UpdateAllReservationsSO(object argument)
        {
            reservations = (List<Reservation>)argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                foreach (var reservation in reservations)
                {
                    broker.Update(reservation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
