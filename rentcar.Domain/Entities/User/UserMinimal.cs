using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rentcar.Domain.Enums;

namespace rentcar.Domain.Entities.User
{
     public class UserMinimal
     {
          public int Id { get; set; }
          public string Username { get; set; }
          public string Email { get; set; }
          public DateTime LastLogin { get; set; }
          public string LasIp { get; set; }
          public URole Level { get; set; }
     }
}
