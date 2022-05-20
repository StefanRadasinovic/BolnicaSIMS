using Bolnica.Manager;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    public class NoValidationController
    {
        NoValidationService noValidationService = new NoValidationService();

        public void Create(NoValidation medicament)
        {
            noValidationService.Create(medicament);

        }

        public void Delete(string MedicamentID)
        {
            noValidationService.Delete(MedicamentID);
        }

        public void Update(NoValidation medicament)
        {
            noValidationService.Update(medicament);
        }

        public List<NoValidation> GetAll()
        {
            return noValidationService.GetAll();
        }

        public NoValidation GetMedicamenID(String MedicamentID)
        {
            return noValidationService.GetMedicamenID(MedicamentID);
        }

        public void AddSubstances(String substances)
        {
            noValidationService.AddSubstances(substances);
        }

    }
}
