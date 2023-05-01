using rentcar.BusinessObjects;
using rentcar.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar.BusinessLogic
{
    public class ReservationBL
    {
        public CustomBO AddReservation(ReservationBO objReservationBo)
        {
            return new ReservationDAL().AddReservation(objReservationBo);
        }
    }
}
