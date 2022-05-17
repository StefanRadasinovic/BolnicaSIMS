using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class RequestEquipmentcs
    {
        private String RoomID;
        private Equipment equipment;
        private DateTime dateMove;

        public RequestEquipmentcs() { }

        public RequestEquipmentcs(string roomID, Equipment equipment, DateTime dateMove)
        {
            RoomID = roomID;
            this.equipment = equipment;
            this.dateMove = dateMove;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public Equipment Equipment { get => equipment; set => equipment = value; }
        public DateTime DateMove { get => dateMove; set => dateMove = value; }
    }
}
