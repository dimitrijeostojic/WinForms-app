using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    internal class FindReservationByIDSO : SystemOperationBase
    {
        public List<Reservation> Result1 { get; set; }
        public Reservation Result { get; set; }
        private Reservation reservation;



        public FindReservationByIDSO(object argument)
        {
            reservation = (Reservation)argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result1 = broker.GetByID(new Reservation(), reservation.Flight_id).Cast<Reservation>().ToList<Reservation>();
            Result = Result1[0];
        }
    }
}

