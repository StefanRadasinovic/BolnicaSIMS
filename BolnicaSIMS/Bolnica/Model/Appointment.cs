// File:    Appointment.cs
// Author:  User
// Created: Thursday, March 31, 2022 7:46:23 PM
// Purpose: Definition of Class Appointment

using System;

namespace Model
{
   public class Appointment //: RoomsID
   {
      //    public Appointment(string roomID) : base(roomID)
       //    {
       //    }

        
        private Patient p;
        private string tiime;
        string appID;
        private int patientJMBG;
        private string patientNAME;
        private string doctorID;
        private string datee;
        private DateTime? date;
        private string? time;
        private string v;
        private string v1;
        private int v2;

        public DateTime Date { get; set; }
      public DateTime TimeStart { get; set; }
      public String? Time { get; set; }  
      public DateTime TimeEnd { get; set; }
      public String AppointmentID { get; set; }
        public String roomID { get; set; }
        public string Tiime { get => tiime; set => tiime = value; }
        public int PatientJMBG { get => patientJMBG; set => patientJMBG = value; }
        public string PatientNAME { get => patientNAME; set => patientNAME = value; }
        public string DoctorID { get => doctorID; set => doctorID = value; }
        public string Datee { get => datee; set => datee = value; }
        public string AppID { get => appID; set => appID = value; }


        public  Patient Patient { get; set; }

        public Boolean Held { get; set; } = false;
        public bool RatedSurvey { get; set; }

        public Boolean Blocked { get; set; } 

        public int Abuse { get; set; }

        public Operation Operation { get; set; }


        //public String RoomNumber;


        



        public Appointment(string appointmentID, Operation operation)
        {
            this.AppointmentID = appointmentID;
            this.Operation = operation;
            RatedSurvey = false;
        }


        public Appointment(string appointmentID, DateTime? date, string? time)
        {
            this.AppointmentID = appointmentID;
            this.Date = date.Value;
            this.Time = time;
        }

        public Appointment(string appointmentID, string time, int patientJMBG, string patientNAME, string doctorID, string datee)
        {
            this.AppID = appointmentID;
            this.Tiime = time;
            this.PatientJMBG = patientJMBG;
            this.PatientNAME = patientNAME;
            this.DoctorID = doctorID;
            this.Datee = datee;
        }

        public Appointment(string v, string v1, int v2)
        {
            this.v = v;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}