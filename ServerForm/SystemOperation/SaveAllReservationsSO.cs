using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    internal class SaveAllReservationsSO : SystemOperationBase
    {

        private List<Reservation> reservationsToSave;

        public SaveAllReservationsSO(object argument)
        {
            reservationsToSave = (List<Reservation>)argument;
        }

        protected override void ExecuteConcreteOperation()
        {

            try
            {
                // Iteriranje kroz sve rezervacije u listi
                foreach (var reservation in reservationsToSave)
                {
                    // Čuvanje svake rezervacije unutar iste transakcije
                    broker.Create(reservation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
