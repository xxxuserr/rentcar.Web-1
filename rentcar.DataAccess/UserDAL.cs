using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar.DataAccess
{
    public class UserDAL
    {
        private UserDBEntities objUserDbEntities;
        public UserDAL()
        {
            objUserDbEntities = new UserDBEntities();
        }
        public CustomBO AddUser(UserBO objUserBo)
        {
            CustomBO objCustomBo = new CustomBO();
            User objUser = new User()
            {
                UserName = objUserBo.UserName,
                UserEmail = objUserBo.UserEmail,
                UserPasscode = objUserBo.Password,
            };
            objUserDbEntities.Users.Add(objUser);
            int returnValue = objUserDbEntities.SaveChanges();
            if (returnValue > 0) 
            {
                objCustomBo.CustomMessage = "Data Successfully Added.";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBo.CustomMessage = "There is some problem.";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            return objCustomBo;

        }
    }
}
