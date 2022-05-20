using System;

namespace Bolnica.Model
{
    public class Renovation
    {

        String roomID;
        System.DateTime time;

        public Renovation()
        {

        }

        public Renovation(string roomID, DateTime date)
        {
            roomID = RoomID;
            this.time = Time;
        }

        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime Time { get => time; set => time = value; }

    }
}
