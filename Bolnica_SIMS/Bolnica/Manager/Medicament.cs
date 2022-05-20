using System;
using System.Collections.Generic;
using System.Linq;


namespace Bolnica.Manager
{
    public class Medicament
    {
        private String MedicamentID;
        private String MedicamentName;
        private MedicamentsType MedicamentType;
        private String Substances;
        private MedicamentCategoria MedicamentsCategoria;
        private List<String> listOfSubstances;

        public Medicament()
        {
        }

        public Medicament(string medicamentID, string medicamentName, MedicamentsType medicamentType, string substances, MedicamentCategoria medicamentsCategoria)
        {
            MedicamentID = medicamentID;
            MedicamentName = medicamentName;
            MedicamentType = medicamentType;
            Substances = substances;
            MedicamentsCategoria = medicamentsCategoria;
            // this.listOfSubstances = listOfSubstances;
        }

        public string MedicamentID1 { get => MedicamentID; set => MedicamentID = value; }
        public string MedicamentName1 { get => MedicamentName; set => MedicamentName = value; }
        public MedicamentsType MedicamentType1 { get => MedicamentType; set => MedicamentType = value; }
       
        public MedicamentCategoria MedicamentsCategoria1 { get => MedicamentsCategoria; set => MedicamentsCategoria = value; }
        public List<String> ListOfSubstances { get => listOfSubstances; set => listOfSubstances = value; }
        public string Substances1 { get => Substances; set => Substances = value; }

        public List<String> listOfSubstancess()
        {
            return Substances.Split(" ".ToCharArray()).ToList();
        }
    }

}
