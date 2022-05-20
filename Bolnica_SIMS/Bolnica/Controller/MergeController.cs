using Bolnica.Manager;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    public class MergeController
    {
        MergeService mergeService = new MergeService();
        public void Delete(String RoomID)
        {
            mergeService.Delete(RoomID);
        }

        public void Create(Merge r)
        {
            mergeService.Create(r);


        }

        public List<Merge> ReadAll()
        {
            return mergeService.ReadAll();
        }

    }
}
