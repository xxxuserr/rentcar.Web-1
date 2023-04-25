using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rentcar.Domain.Entities.User;

namespace rentcar.BusinessLogic.DBModel
{
     class UserContext : DbContext
     {
          public UserContext() :
              base("name=rentcar") // connection string name define in your web.config
          {
          }

          public virtual DbSet<UDbTable> Users { get; set; }
     }
}
