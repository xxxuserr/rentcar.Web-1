using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rentcar.DataAccess;

namespace rentcar.BusinessLogic
{
    public class UserBL
    {
        public CustomBO AddUser(UserBO objUserBo)
        {
            return new UserDAL().AddUser(objUserBo);
        }
        public CustomBO Login(LoginBO objUserBo)
        {
            return new UserDAL().Login(objUserBo);
        }
    }
}
