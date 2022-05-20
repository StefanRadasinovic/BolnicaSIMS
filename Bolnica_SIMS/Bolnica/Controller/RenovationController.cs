using Bolnica.Manager;
using Bolnica.Model;
using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
    internal class RenovationController
    {

        RenovationService renovationService = new RenovationService();

        public void Delete(String RoomID)
        {
            renovationService.Delete(RoomID);
        }

        public void Create(Renovation renovation)
        {
            renovationService.Create(renovation);


        }

        public List<Renovation> ReadAll()
        {
            return renovationService.ReadAll();
        }


    }

}
