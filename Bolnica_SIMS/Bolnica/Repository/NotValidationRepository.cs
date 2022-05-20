using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bolnica.Repository
{
    internal class NotValidationRepository
    {
        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
       .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public NotValidationRepository()
        {
            medicaments = (List<NoValidation>)Deserialize();
        }
        public NoValidation GetMedicament(String id)
        {
            foreach (NoValidation n in medicaments)
                if (n.MedicamentID1 == id)
                    return n;
            return null;
        }

        public List<NoValidation> ReadAll()
        {
            return medicaments;
        }
        public void Serialize()
        {
            AllToCSV(medicaments);
        }
        public IEnumerable<NoValidation> Deserialize()
        {
            //return (List<NoValidation>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\novalidation.csv").Select(FromCSV).ToList();
            return (List<NoValidation>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\novalidation.csv").Select(FromCSV).ToList();
        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\novalidation.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<NoValidation> medicaments)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\novalidation.csv", string.Empty);
            foreach (NoValidation m in medicaments)
            {
                AppendLineToFile(ToCSV(m));
            }
        }

        private String ToCSV(NoValidation medicament)    //serialization
        {
            return string.Join("_", medicament.MedicamentID1, medicament.MedicamentName1, medicament.MedicamentType1, medicament.Substances1, medicament.MedicamentsCategoria1);
        }

        private NoValidation FromCSV(String medicamentFormat)     //deserialization
        {
            var tokens = medicamentFormat.Split("_".ToCharArray());
            // return new Medicament(Convert.ToString(tokens[0]), Convert.ToString(tokens[1]), (MedicamentsType)Enum.Parse(typeof(MedicamentsType), tokens[2]), Convert.ToString(tokens[3]), (MedicamentCategoria)Enum.Parse(typeof(MedicamentCategoria), tokens[4]));
            return new NoValidation(Convert.ToString(tokens[0]), Convert.ToString(tokens[1]), (MedicamentsType)Enum.Parse(typeof(MedicamentsType), tokens[2]), Convert.ToString(tokens[3]), (MedicamentCategoria)Enum.Parse(typeof(MedicamentCategoria), tokens[4]));
        }

        public static List<NoValidation> medicaments = new List<NoValidation>();
    }
}
