// File:    Operation.cs
// Author:  User
// Created: Wednesday, April 13, 2022 1:18:00 PM
// Purpose: Definition of Class Operation

using System;

namespace Model
{
   public class Operation
   {
        private int operationID;
        private int doctorID;
        private string timeStart;
        private string timeEnd;
        private int roomID;
        private int patientID;

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

    }
}