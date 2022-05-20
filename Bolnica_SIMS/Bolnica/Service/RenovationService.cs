using Bolnica.Model;
using System;
using System.Collections.Generic;

namespace Bolnica.Manager
{
        internal class RenovationService
        {

        public void Delete(String RoomID)
        {
            Renovation renovations = null;
            foreach (Renovation renovation in renovationRepository.ReadAll())
            {
                if (renovation.RoomID == RoomID)
                {
                    renovations = renovation;

                }

            }

            if (renovations != null)
            {
                renovationRepository.ReadAll().Remove(renovations);
            }
        }

        public void Create(Renovation renovation)
        {
            renovationRepository.ReadAll().Add(renovation);
            renovationRepository.Serialize();


        }

        public List<Renovation> ReadAll()
        {
            return renovationRepository.ReadAll();
        }

        private RenovationRepository renovationRepository = new RenovationRepository();

    }
}
