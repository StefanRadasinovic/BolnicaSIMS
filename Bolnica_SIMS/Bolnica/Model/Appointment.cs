// File:    Appointment.cs
// Author:  User
// Created: Thursday, March 31, 2022 7:46:23 PM
// Purpose: Definition of Class Appointment

using Bolnica.Serialization;
using System;

namespace Model
{
   public class Appointment : Serializable
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
        private bool isEmergency;


        private DateTime? date;
        private string time;
        private string Time;

        public DateTime Date { get; set; }
      public DateTime TimeStart { get; set; }
      public DateTime TimeEnd { get; set; }
      public String AppointmentID { get; set; }
        public String roomID { get; set; }
        public string Tiime { get => tiime; set => tiime = value; }
        public int PatientJMBG { get => patientJMBG; set => patientJMBG = value; }
        public string PatientNAME { get => patientNAME; set => patientNAME = value; }
        public string DoctorID { get => doctorID; set => doctorID = value; }
        public string Datee { get => datee; set => datee = value; }
        public string AppID { get => appID; set => appID = value; }
        public bool IsEmergency { get => isEmergency; set => isEmergency = value; }


        //public String RoomNumber;






        public Appointment(string appointmentID, DateTime? date, string time)
        {
            AppointmentID = appointmentID;
            this.Date = date.Value;
            this.Time = time;
        }
        public Appointment() { }

        public Appointment(string appointmentID, string time, int patientJMBG, string patientNAME, string doctorID, string datee, bool emergency)
        {
            this.AppID = appointmentID;
            this.Tiime = time;
            this.PatientJMBG = patientJMBG;
            this.PatientNAME = patientNAME;
            this.DoctorID = doctorID;
            this.Datee = datee;
            this.isEmergency = emergency;
        }

        public string[] toCSV()
        {
            string[] csvValues =
           {
                AppID,
                PatientJMBG.ToString(),
                PatientNAME,
                DoctorID,
                Datee,
                Tiime,
                isEmergency.ToString()
            };
            return csvValues;
        }

        public void fromCSV(string[] values)
        {
            AppID = values[0];
            PatientJMBG = int.Parse(values[1]);
            PatientNAME = values[2];
            DoctorID = values[3];
            Datee = values[4];
            Tiime = values[5];
            isEmergency = Convert.ToBoolean(values[6]);
        }

        //public Appointment()

    }
}