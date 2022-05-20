// File:    Appointment.cs
// Author:  User
// Created: Thursday, March 31, 2022 7:46:23 PM
// Purpose: Definition of Class Appointment

using System;

namespace Model
{
    public class Appointment //: RoomsID
    {
        /* public Appointment(string roomID) : base(roomID)
         {
         }
        */

        public DateTime Date { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public String AppointmentID { get; set; }
        public String RoomID { get; set; }


        //public String RoomNumber;

    }
}