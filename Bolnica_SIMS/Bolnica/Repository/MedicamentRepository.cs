using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bolnica.Repository
{
    internal class MedicamentRepository
    {
        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public MedicamentRepository()
        {
           medicaments = (List<Medicament>)Deserialize();
        }
        public Medicament GetMedicament(String id)
        {
            foreach (Medicament m in medicaments)
                if (m.MedicamentID1 == id)
                    return m;
            return null;
        }

        public List<Medicament> ReadAll()
        {
            return medicaments;
        }
        public void Serialize()
        {
            AllToCSV(medicaments);
        }
        public IEnumerable<Medicament> Deserialize()
        {
            return (List<Medicament>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\medicaments.csv").Select(FromCSV).ToList();

        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\medicaments.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<Medicament> medicaments)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\medicaments.csv", string.Empty);
            foreach (Medicament m in medicaments)
            {
                AppendLineToFile(ToCSV(m));
            }
        }

        private String ToCSV(Medicament medicament)    //serialization
        {
            return string.Join("_",medicament.MedicamentID1, medicament.MedicamentName1,medicament.MedicamentType1, medicament.Substances1, medicament.MedicamentsCategoria1);
        }

        private Medicament FromCSV(String medicamentFormat)     //deserialization
        {
            var tokens = medicamentFormat.Split("_".ToCharArray());
            // return new Medicament(Convert.ToString(tokens[0]), Convert.ToString(tokens[1]), (MedicamentsType)Enum.Parse(typeof(MedicamentsType), tokens[2]), Convert.ToString(tokens[3]), (MedicamentCategoria)Enum.Parse(typeof(MedicamentCategoria), tokens[4]));
            return new Medicament(Convert.ToString(tokens[0]), Convert.ToString(tokens[1]), (MedicamentsType)Enum.Parse(typeof(MedicamentsType), tokens[2]), Convert.ToString(tokens[3]), (MedicamentCategoria)Enum.Parse(typeof(MedicamentCategoria), tokens[4]));
        }

        public static List<Medicament> medicaments = new List<Medicament>();

    }
}
