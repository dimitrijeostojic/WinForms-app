using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetAllDestinationsSO : SystemOperationBase
    {
        private Airport airport;
        public List<Airport> Result { get; set; }

        public GetAllDestinationsSO()
        {
            airport=new Airport();
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(airport).Cast<Airport>().ToList();
        }
    }
}
