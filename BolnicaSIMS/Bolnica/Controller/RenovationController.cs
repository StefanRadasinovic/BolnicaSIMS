using Bolnica.Manager;
using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    internal class RenovationController
    {

        RenovationService renovationService= new RenovationService();

        public void Delete(String RoomID)
        {
            renovationService.Delete(RoomID);
        }

        public void Create(Renovation r)
        {
            renovationService.Create(r);


        }

        public List<Renovation> ReadAll()
        {
            return renovationService.ReadAll();
        }

        
    }
    
}
