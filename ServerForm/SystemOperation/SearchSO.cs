using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    internal class SearchSO : SystemOperationBase
    {
        private string input;
        private User user;
        private string searchType;
        private Flight flight;

        public SearchSO(object argument, object user, string searchType)
        {
            input = (string)argument;
            this.user = (User)user;
            this.searchType = searchType;
            flight = new Flight();
        }

        public List<object> Result { get; set; }



        protected override void ExecuteConcreteOperation()
        {
            string whereCondition;

            switch (searchType)
            {
                case "From":
                    whereCondition = flight.WhereF;
                    break;
                case "To":
                    whereCondition = flight.WhereT;
                    break;
                case "Jmbg":
                    whereCondition = "jmbg";
                    break;
                case "Date":
                    whereCondition = flight.WhereD;
                    break;
                case "flightId":
                    whereCondition = "r.Flight_id";
                        break;
                default:
                    throw new ArgumentException("Nevažeći tip pretrage.");
            }
            if (whereCondition == "jmbg")
            {
                Result = broker.SearchEntities(new User(), user, input, whereCondition).Cast<object>().ToList();
            }
            else if (whereCondition == "r.Flight_id")
            {
                Result = broker.SearchEntities(new Reservation(), user, input, whereCondition).Cast<object>().ToList();
            }
            else
            {
                Result = broker.SearchEntities(flight, user, input, whereCondition).Cast<object>().ToList();
            }
        }
    }
}
