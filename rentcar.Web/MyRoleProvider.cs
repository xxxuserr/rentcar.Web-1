using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using rentcar.DataAccess;

namespace rentcar.Web
{
    public class MyRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            using (var context = new UserDBEntities())
            {
                foreach (var username in usernames)
                {
                    var user = context.Users.FirstOrDefault(u => u.UserName == username);

                    if (user != null)
                    {
                        var roleName = "User"; // Replace with the desired default role name
                        var role = context.Roles.SingleOrDefault(r => r.Role1 == roleName);

                        if (role != null && !user.Roles.Contains(role))
                        {
                            user.Roles.Add(role);
                        }
                    }
                }

                context.SaveChanges();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var context = new UserDBEntities())
            {
                var res = (from user in context.Users
                           join role in context.Roles on user.UserId equals role.UserId
                           where user.UserName == username
                           select role.Role1).ToArray();
                return res;
            }
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}