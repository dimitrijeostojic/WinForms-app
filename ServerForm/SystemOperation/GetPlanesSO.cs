using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetPlanesSO : SystemOperationBase
    {
        private Plane plane;

        public List<Plane> Result { get; private set; }

        public GetPlanesSO()
        {
            plane = new Plane();
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(plane).Cast<Plane>().ToList();
        }
    }
}
