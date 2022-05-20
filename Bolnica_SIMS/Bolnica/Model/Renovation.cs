using System;

namespace Bolnica.Model
{
    public class Renovation
    {

        String RoomID;
        System.DateTime Time;

        public Renovation()
        {

        }

        public Renovation(string roomID, DateTime date)
        {
            RoomID = roomID;
            this.Time = Time1;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public DateTime Time1 { get => Time; set => Time = value; }

    }
}
