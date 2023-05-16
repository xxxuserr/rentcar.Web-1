using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar.DataAccess.DbOperations
{
    public class UserRepository
    {
        public int CreateUser(UserBO objUserBo)
        {
            using (var context = new UserDBEntities())
            {
                User emp = new User()
                {
                    UserName = objUserBo.UserName,
                    UserEmail = objUserBo.UserEmail,

                };
                context.Users.Add(emp);
                context.SaveChanges();
                return emp.UserId;
               
                
            }
        }
        public List<UserBO> GetUsers()
        {
            using (var context = new UserDBEntities()) 
            {
                var result = context.Users
                    .Select(x => new UserBO()
                    {
                        UserId = x.UserId,
                        UserName = x.UserName,
                        UserEmail = x.UserEmail,
                    }).ToList();
                return result;
            }
        }
    }
}
