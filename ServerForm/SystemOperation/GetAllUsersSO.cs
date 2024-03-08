using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class GetAllUsersSO : SystemOperationBase
    {
        private User user;
        public List<User> Result { get; set; }
        public GetAllUsersSO(User user)
        {
            this.user=user;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(user).Cast<User>().ToList();
        }
    }
}
