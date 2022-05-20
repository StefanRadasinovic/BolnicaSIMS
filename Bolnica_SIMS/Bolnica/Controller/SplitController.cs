using Bolnica.Manager;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    public class SplitController
    {


        SplitService splitService = new SplitService();

        public void Delete(String RoomID)
        {
            splitService.Delete(RoomID);
        }

        public void Create(Split s)
        {
            splitService.Create(s);


        }

        public List<Split> ReadAll()
        {
            return splitService.ReadAll();
        }
    }
}
