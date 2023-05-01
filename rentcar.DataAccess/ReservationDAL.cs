using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar.DataAccess
{
    public class ReservationDAL
    {
        private UserDBEntities objReservationDbEntities;
        public ReservationDAL()
        {
            objReservationDbEntities = new UserDBEntities();
        }
        public CustomBO AddReservation(ReservationBO objReservationBo)
        {
            CustomBO objCustomBo = new CustomBO();
            Reservation objReservation = new Reservation()
            {
                RUserName = objReservationBo.RUserName,
                RUserEmail = objReservationBo.RUserEmail,
                RUserMark = objReservationBo.RUserMark,
                RUserModel = objReservationBo.RUserModel,
                RPickUpDateTime = objReservationBo.RPickUpDateTime,
                RDropOffDateTime = objReservationBo.RDropOffDateTime,

            };
            objReservationDbEntities.Reservations.Add(objReservation);
            int returnValue = objReservationDbEntities.SaveChanges();
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
