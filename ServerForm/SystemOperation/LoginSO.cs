using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        private readonly User user;
        public User Result { get; set; }

        public LoginSO(User user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            List<User> users = broker.GetAll(user).Cast<User>().ToList();
            foreach (User u in users)
            {
                if (u.Username == this.user.Username && PasswordHasher.VerifyPassword(this.user.Password, u.Password))
                {
                    Result = u;
                }
            }
            
        }
    }
}
