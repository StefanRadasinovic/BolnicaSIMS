using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    public class EquipmentService
    {

        public void Delete(String RoomID)
        {
            Equipment e = null;
            foreach (Equipment e1 in equipmentRepository.ReadAll())
            {
                if (e1.RoomID == RoomID)
                {
                    e = e1;

                }

            }

            if (e != null)
            {
                equipmentRepository.ReadAll().Remove(e);
            }
        }

        public void Create(Equipment e)
        {
            equipmentRepository.ReadAll().Add(e);
            equipmentRepository.Serialize();

            //za validaciju u try catch--gleda da li bi program kresovao ako da izmbaci kec

        }

        public List<Equipment> ReadAll()
        {
            return equipmentRepository.ReadAll();
        }

        public bool MoveEquipment(RequestEquipmentcs requestEquipmentcs,string id) {
            equipmentRepository.Read(id).Request.Add(requestEquipmentcs);               
             return true;
        
        }




        private EquipmentRepository equipmentRepository = new EquipmentRepository();
    }
}
