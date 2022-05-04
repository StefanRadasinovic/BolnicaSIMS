

using System;
namespace Model
{
   public class Appointment : RoomsID        //////OVO TI JE NOVA VERZIJA !!!!!!!
   {

        private Patient p;
        private DateTime? date;
        private string time;

        public DateTime Date { get; set; }
      public DateTime TimeStart { get; set; }
      public DateTime TimeEnd { get; set; }
      public String AppointmentID { get; set; }
        public String RoomID { get; set; }


        public Patient Patient { get; set; }
        

        //public String RoomNumber;



        public Appointment(string appointmentID, Patient p, DateTime? date, string time)
        {
            AppointmentID = appointmentID;
            this.p = p;
            this.Date = date.Value;
            this.time = time;
        }

        public Appointment(string appointmentID, DateTime? date, string time)
        {
            AppointmentID = appointmentID;
            this.Date = date.Value;
            this.time = time;
        }


    }
}