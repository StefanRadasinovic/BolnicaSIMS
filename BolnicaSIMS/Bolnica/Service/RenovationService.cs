using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Manager
{
    internal class RenovationService
    {

        public void Delete(String RoomID)
        {
            Renovation r = null;
            foreach (Renovation r1 in renovationRepository.ReadAll()) {
                if (r1.RoomID1 == RoomID) {
                    r = r1;

                }

            }

            if (r != null) {
                renovationRepository.ReadAll().Remove(r);
            }
        }

        public void Create(Renovation r) {
            renovationRepository.ReadAll().Add(r);
            renovationRepository.Serialize();


        }

        public List<Renovation> ReadAll() {
            return renovationRepository.ReadAll();
        }

        private RenovationRepository renovationRepository = new RenovationRepository();

    }
}
