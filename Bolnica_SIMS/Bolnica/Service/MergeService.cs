using Bolnica.Manager;
using Bolnica.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Service
{

    //dodati validacije

    public class MergeService
    {
        MergeRepository mergeRepository = new MergeRepository();
       // public Rooms = new Rooms();

        public void Delete(String RoomID)
        {
            Merge m = null;
            foreach (Merge m1 in mergeRepository.ReadAll())
            {
                if (m1.RoomID1 == RoomID)
                {
                    m = m1;
                    

                }

            }

            if (m!= null)
            {
                mergeRepository.ReadAll().Remove(m);
            }
        }

        public void Create(Merge m)
        {
            mergeRepository.ReadAll().Add(m);
            mergeRepository.Serialize();


        }

        public List<Merge> ReadAll()
        {
            return mergeRepository.ReadAll();
        }
    }
}
