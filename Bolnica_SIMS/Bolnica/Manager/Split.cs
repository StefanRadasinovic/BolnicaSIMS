using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class Split
    {

        String RoomID;
        System.DateTime Time;
        String RoomID2;

        public Split()
        {

        }

        public Split(string roomID, DateTime time, string roomID2)
        {
            RoomID = roomID;
            Time = time;
            RoomID2 = roomID2;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public DateTime Time1 { get => Time; set => Time = value; }
        public string RoomID21 { get => RoomID2; set => RoomID2 = value; }
    }
}
