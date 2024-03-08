using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class SaveUserSO : SystemOperationBase
    {
        private readonly User user;

        public SaveUserSO(User user)
        {
            this.user = user;
        }


        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Create(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
