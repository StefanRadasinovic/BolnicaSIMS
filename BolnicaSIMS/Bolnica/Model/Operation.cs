// File:    Operation.cs
// Author:  User
// Created: Wednesday, April 13, 2022 1:18:00 PM
// Purpose: Definition of Class Operation

using Bolnica.Serialization;
using System;

namespace Model
{
   public class Operation : Serializable
   {

        private int operationID;
        private int doctorID;
        private string timeStart;
        private string timeEnd;
        private int roomID;
        private int patientID;

        public Boolean Held { get; set; } = false; /// da li je uopste doslo do operacije 
        
        public bool RatedSurvey { get; set; } /// za ocenjivanje ankete

        public Boolean Blocked { get; set; } /// da li je korisnik blokiran ZA ANTRITROL
        

        public int Abuse { get; set; } // ISTO ZA ANTITROL
        public String AppointmentID { get; set; }

        public Appointment Appointment { get; set; }


        //public String RoomNumber;


        public Operation() { }



        public Operation(string appointmentID, Appointment appointment)
        {
            this.AppointmentID = appointmentID;
            this.Appointment = appointment;
            RatedSurvey = false;
        }



        public Operation(int operationID, int doctorID, string timeStart, string timeEnd, int roomID, int patientID)
        {
            this.operationID = operationID;
            this.doctorID = doctorID;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.roomID = roomID;
            this.patientID = patientID;
        }

        

        public int OperationID { get => operationID; set => operationID = value; }
        public int DoctorID { get => doctorID; set => doctorID = value; }
        public string TimeStart { get => timeStart; set => timeStart = value; }
        public string TimeEnd { get => timeEnd; set => timeEnd = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int PatientID { get => patientID; set => patientID = value; }

        public void fromCSV(string[] values)
        {
            OperationID = int.Parse(values[0]);
            DoctorID = int.Parse(values[1]);
            TimeStart = values[2];
            TimeEnd = values[3];
            RoomID = int.Parse(values[4]);
            PatientID = int.Parse(values[5]);
        }

        public string[] toCSV()
        {
            string[] csvValues =
           {
                OperationID.ToString(),
                DoctorID.ToString(),
                TimeStart,
                TimeEnd,
                RoomID.ToString(),
                PatientID.ToString()
            };
            return csvValues;
        }
    }
}