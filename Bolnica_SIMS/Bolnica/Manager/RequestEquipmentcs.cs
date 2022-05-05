using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class RequestEquipmentcs
    {
        private String eqID;
        private RoomsType roomType;
        private DateTime dateMove;

        public RequestEquipmentcs(string eqID, RoomsType roomType, DateTime dateMove)
        {
            this.eqID = eqID;
            this.roomType = roomType;
            this.dateMove = dateMove;
        }

        public string EqID { get => eqID; set => eqID = value; }
        public RoomsType RoomType { get => roomType; set => roomType = value; }
        public DateTime DateMove { get => dateMove; set => dateMove = value; }

        // public RequestEquipmentcs() { }

        /*public RequestEquipmentcs(string roomID, Equipment equipment, DateTime dateMove)
        {
            RoomID = roomID;
            this.equipment = equipment;
            this.dateMove = dateMove;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public Equipment Equipment { get => equipment; set => equipment = value; }
        public DateTime DateMove { get => dateMove; set => dateMove = value; }*/


    }
}
