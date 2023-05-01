using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;

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
        public CustomBO Login(LoginBO credentials)
        {
            UserDBEntities entity = new UserDBEntities();
            CustomBO objCustomBo = new CustomBO();
            bool userExists = entity.Users.Any(x => x.UserEmail == credentials.UserEmail && x.UserPasscode == credentials.Password);
            User u = entity.Users.FirstOrDefault(x => x.UserEmail == credentials.UserEmail && x.UserPasscode == credentials.Password);
            if (userExists)
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                objCustomBo.CustomMessage = "Data Successfully Added.";
                int returnValue = 0;
                objCustomBo.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBo.CustomMessage = "There is some problem.";
                int returnValue = 0;
                objCustomBo.CustomMessageNumber = returnValue;
            }
            return objCustomBo;
        }
        
    }
}

