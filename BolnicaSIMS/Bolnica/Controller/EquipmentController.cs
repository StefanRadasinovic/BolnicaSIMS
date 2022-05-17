using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class EquipmentController
    {


        public void Delete(String RoomID)
        {
            equipmentService.Delete(RoomID);
        }

        public void Create(Equipment e)
        {
            equipmentService.Create(e);


        }

        public List<Equipment> ReadAll()
        {
            return equipmentService.ReadAll();
        }

        public bool MoveEq(RequestEquipmentcs requestEquipmentcs,string id) {
            equipmentService.MoveEquipment(requestEquipmentcs,id);
            return true;
        }


        private EquipmentService equipmentService = new EquipmentService();
    }
}
