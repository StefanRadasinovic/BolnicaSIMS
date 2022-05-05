using Bolnica.Manager;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    internal class RequestController
    {
        public void Delete(String eqID)
        {
            requestService.Delete(eqID);
        }

        public void Create(RequestEquipmentcs requestEquipmentcs)
        {
            requestService.Create(requestEquipmentcs);


        }

        public List<RequestEquipmentcs> ReadAll()
        {
            return requestService.ReadAll();
        }

        /*  public bool MoveEq(RequestEquipmentcs requestEquipmentcs, string id)
          {
              equipmentService.MoveEquipment(requestEquipmentcs, id);
              return true;
          }*/


        private RequestService requestService = new RequestService();
    }

}
