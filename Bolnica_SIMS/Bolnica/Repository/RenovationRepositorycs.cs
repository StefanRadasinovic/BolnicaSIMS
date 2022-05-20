using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bolnica.Model
{

    internal class RenovationRepository
    {

        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
         .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public RenovationRepository()
        {
            renovation = (List<Renovation>)Deserialize();
        }
        public Renovation Read(String id)
        {
            foreach (Renovation renovation in renovation)
                if (renovation.RoomID == id)
                    return renovation;
            return null;
        }

        public List<Renovation> ReadAll()
        {
            return renovation;
        }
        public void Serialize()
        {
            AllToCSV(renovation);
        }
        public IEnumerable<Renovation> Deserialize()
        {
            return (List<Renovation>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\renovations.csv").Select(FromCSV).ToList();

        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\renovations.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<Renovation> renovations)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\renovations.csv", string.Empty);
            foreach (Renovation renovation in renovations)
            {
                AppendLineToFile(ToCSV(renovation));
            }
        }

        private String ToCSV(Renovation renovation)    //serialization
        {
            return string.Join("_", renovation.RoomID, renovation.Time);
        }

        private Renovation FromCSV(String renovationFormat)     //deserialization
        {
            var tokens = renovationFormat.Split("_".ToCharArray());
            //  return new Renovation(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[1]));
            //parsiranje datuma
            return new Renovation(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[1]));
        }

        public List<Renovation> renovation = new List<Renovation>();



    }
}
