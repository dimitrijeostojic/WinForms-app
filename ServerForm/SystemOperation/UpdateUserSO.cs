using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForm.SystemOperation
{
    public class UpdateUserSO : SystemOperationBase
    {
        private User user;
        public bool Result { get; set; }
        public UpdateUserSO(User user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Update(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
