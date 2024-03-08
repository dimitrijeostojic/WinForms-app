using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetAllReservationsSO : SystemOperationBase
    {
        public List<Reservation> Result { get; set; }
        private User user;
        private Reservation reservation;

        public GetAllReservationsSO(object argument)
        {
            user = (User)argument;
            reservation = new Reservation();
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllWithWhere(user, reservation).Cast<Reservation>().ToList<Reservation>();
        }
    }
}
