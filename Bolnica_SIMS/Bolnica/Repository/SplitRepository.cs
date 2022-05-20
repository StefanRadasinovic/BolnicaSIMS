using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bolnica.Repository
{
    public class SplitRepository
    {

        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public SplitRepository()
        {
            //splits = (List<Split>)Deserialize();
        }
        public Split GetMerge(String id)
        {
            foreach (Split s in splits)
                if (s.RoomID1 == id)
                    return s;
            return null;
        }

        public List<Split> ReadAll()
        {
            return splits;
        }
        public void Serialize()
        {
            AllToCSV(splits);
        }
        public IEnumerable<Split> Deserialize()
        {
            return (List<Split>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\splits.csv").Select(FromCSV).ToList();

        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\splits.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<Split> splits)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\splits.csv", string.Empty);
            foreach (Split s in splits)
            {
                AppendLineToFile(ToCSV(s));
            }
        }

        private String ToCSV(Split splits)    //serialization
        {
            return string.Join("_", splits.RoomID1, splits.Time1, splits.RoomID21);
        }

        private Split FromCSV(String splitFormat)     //deserialization
        {
            var tokens = splitFormat.Split("_".ToCharArray());
            return new Split(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[1]), Convert.ToString(tokens[2]));
        }

        public static List<Split> splits = new List<Split>();
    }
}

