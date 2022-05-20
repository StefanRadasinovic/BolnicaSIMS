using Bolnica.Manager;
using Bolnica.Repository;
using System;
using System.Collections.Generic;

namespace Bolnica.Service
{
    internal class MedicamentService
    {
        MedicamentRepository medicamentRepository = new MedicamentRepository();
        List<Medicament> medicaments = new List<Medicament>();
        List<String> listOfSubstances = new List<String>();

        public void Create(Medicament medicament)
        {

            medicamentRepository.ReadAll().Add(medicament);
            medicamentRepository.Serialize();

        }

      /*  public void DeleteRoom(String roomID)
        {
            Rooms r = null;
            foreach (Rooms r1 in roomRepository.ReadAll())
            {
                if (r1.RoomID1 == roomID)
                {
                    r = r1;

                }

            }

            if (r != null)
            {
                roomRepository.ReadAll().Remove(r);
            }
            roomRepository.Serialize();
        }
      */
        public void Delete(String medicamentID)
        {
            Medicament m = null;
            foreach (Medicament m1 in medicamentRepository.ReadAll())
            {

                if (m1.MedicamentID1 == medicamentID)
                {
                    m = m1;
                   
                }
                
            }
                if (m != null)
                {
                    medicamentRepository.ReadAll().Remove(m);
                
                  
                }

            medicamentRepository.Serialize();
            
           

        }

        public void Update(Medicament medicament)
        {
            medicamentRepository.GetMedicament(medicament.MedicamentID1);
            Delete(medicament.MedicamentID1);
            Create(medicament);
            medicamentRepository.Serialize();

        }

        public List<Medicament> GetAll()
        {
            return medicamentRepository.ReadAll();
        }


        public Medicament GetMedicamenID(String MedicamentID)
        {
            return medicamentRepository.GetMedicament(MedicamentID);
        }


     
        public void AddSubstances(String substances)
        {

            /* foreach (Medicament m in medicaments) {
                 if (m.Substances1 == substances) 
                     {
                         substances = m.Substances1;
                     }
                 if (m.Substances1 != substances) 
                 {
                     listOfSubstances.Add(substances);
                 }*/



            listOfSubstances.Add(substances);
            medicamentRepository.Serialize();


            // }
        }



    }
}
