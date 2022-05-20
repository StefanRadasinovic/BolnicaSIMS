using Bolnica.Manager;
using Bolnica.Service;
using System;
using System.Collections.Generic;

namespace Bolnica.Controller
{
    internal class MedicamentController
    {
        MedicamentService medicamentService = new MedicamentService();

        public void Create(Medicament medicament)
        {
            medicamentService.Create(medicament);

        }

        public void Delete(string MedicamentID)
        {
            medicamentService.Delete(MedicamentID);
        }

        public void Update(Medicament medicament)
        {
            medicamentService.Update(medicament);
        }

        public List<Medicament> GetAll()
        {
            return medicamentService.GetAll();
        }

        public Medicament GetMedicamenID(String MedicamentID)
        {
            return medicamentService.GetMedicamenID(MedicamentID);
        }

        public void AddSubstances(String substances)
        {
            medicamentService.AddSubstances(substances);
        }
    }
}
