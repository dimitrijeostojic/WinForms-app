using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    internal class FindUserByIDSO : SystemOperationBase
    {
        private User user;
        private string argument;
        public List<User> Result1 { get; set; }
        public User Result { get; set; }
        public FindUserByIDSO(object argument)
        {
            user = new User();
            this.argument = (string)argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result1 = broker.GetByID(user, argument).Cast<User>().ToList<User>();
            Result = Result1[0];
        }
    }
}
