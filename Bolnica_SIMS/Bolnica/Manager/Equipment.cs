using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class Equipment
    {
        private String id;
        private EquipmentType equipmentType;
        private String RoomID;
        private List<RequestEquipmentcs> request=new List<RequestEquipmentcs>();

        public Equipment(string id, EquipmentType equipmentType, string roomID)
        {
            this.id = id;
            this.equipmentType = equipmentType;
            RoomID = roomID;
        }

        public string Id { get => id; set => id = value; }
        public EquipmentType EquipmentType { get => equipmentType; set => equipmentType = value; }
        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public List<RequestEquipmentcs> Request { get => request; set => request = value; }




        /* public Equipment(string id, EquipmentType equipmentType, string roomID)
         {
             this.id = id;
             this.equipmentType = equipmentType;
             this.roomID = roomID;
         }

          public string Id { get => id; set => id = value; }
          public EquipmentType EquipmentType { get => equipmentType; set => equipmentType = value; }
          public string RoomID { get => roomID; set => roomID = value; }
          public List<RequestEquipmentcs> Request { get => request; set => request = value; }*/




    }
}
