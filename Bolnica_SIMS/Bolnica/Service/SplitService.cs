using Bolnica.Manager;
using Bolnica.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Service
{
    public class SplitService
    {
        SplitRepository splitRepository = new SplitRepository();
        Rooms r= new Rooms();

        public void Delete(String RoomID)
        {
            Split s = null;
            foreach (Split s1 in splitRepository.ReadAll())
            {
                if (s1.RoomID1 == RoomID)
                {
                    s = s1;
                   
                }

            }

            if (s != null)
            {
                splitRepository.ReadAll().Remove(s);
            }
        }

        public void Create(Split s)
        {
            splitRepository.ReadAll().Add(s);
            splitRepository.Serialize();



        }

        public List<Split> ReadAll()
        {
            return splitRepository.ReadAll();
        }
    }
}
