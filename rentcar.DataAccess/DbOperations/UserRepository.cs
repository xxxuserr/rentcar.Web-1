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
        public int CreateUser(UserBO model)
        {
            using (var context = new UserDBEntities())
            {
                User emp = new User()
                {
                    UserName = model.UserName,
                    UserEmail = model.UserEmail,
                    UserPasscode = model.Password,

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
        public bool DeleteUser(int id)
        {
            using(var context = new UserDBEntities())
            {
                var user = context.Users.FirstOrDefault(x => x.UserId == id);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public List<ReservationBO> GetReservations()
        {
            using (var context = new UserDBEntities())
            {
                var result = context.Reservations
                    .Select(x => new ReservationBO()
                    {
                        RId = x.RId,
                        RUserName = x.RUserName,
                        RUserEmail = x.RUserEmail,
                        RUserMark = x.RUserMark,
                        RUserModel = x.RUserModel,
                        RPickUpDateTime = x.RPickUpDateTime,
                        RDropOffDateTime = x.RDropOffDateTime,
                    }).ToList();
                return result;
            }
        }
        public bool DeleteReservation(int id)
        {
            using (var context = new UserDBEntities())
            {
                var reservation = context.Reservations.FirstOrDefault(x => x.RId == id);
                if (reservation != null)
                {
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
    }
}
