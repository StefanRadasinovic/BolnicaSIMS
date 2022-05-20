using Bolnica.Manager;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Service
{
    public class NoValidationService
    {

        NotValidationRepository noValidationRepository = new NotValidationRepository();
        List<NoValidation> medicaments = new List<NoValidation>();
        List<String> listOfSubstances = new List<String>();

        public void Create(NoValidation medicament)
        {

            noValidationRepository.ReadAll().Add(medicament);
            noValidationRepository.Serialize();

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
            NoValidation m = null;
            foreach (NoValidation m1 in noValidationRepository.ReadAll())
            {

                if (m1.MedicamentID1 == medicamentID)
                {
                    m = m1;

                }

            }
            if (m != null)
            {
                noValidationRepository.ReadAll().Remove(m);


            }

            noValidationRepository.Serialize();



        }

        public void Update(NoValidation medicament)
        {
            noValidationRepository.GetMedicament(medicament.MedicamentID1);
            Delete(medicament.MedicamentID1);
            Create(medicament);
            noValidationRepository.Serialize();

        }

        public List<NoValidation> GetAll()
        {
            return noValidationRepository.ReadAll();
        }


        public NoValidation GetMedicamenID(String MedicamentID)
        {
            return noValidationRepository.GetMedicament(MedicamentID);
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
            noValidationRepository.Serialize();


            // }
        }




    }
}
