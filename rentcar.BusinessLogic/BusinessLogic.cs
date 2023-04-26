using rentcar.BusinessLogic.Interfaces;

namespace rentcar.BusinessLogic
{
     public class BusinessLogic
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
     }
}
