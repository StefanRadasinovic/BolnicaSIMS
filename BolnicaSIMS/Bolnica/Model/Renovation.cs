using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bolnica.Model
{
    internal class Renovation
    {

        String RoomID;
        System.DateTime Time;

        public Renovation() { 
         
        }

        public Renovation(string roomID, DateTime date)
        {
            RoomID1 = roomID;
            this.Time1 = Time1;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public DateTime Time1 { get => Time; set => Time = value; }

    }
}
