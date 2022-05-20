using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bolnica.Repository
{
    internal class MergeRepository
    {
        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public MergeRepository()
        {
            //merges = (List<Merge>)Deserialize();
        }
        public Merge GetMerge(String id)
        {
            foreach (Merge m in merges)
                if (m.RoomID1 == id)
                    return m;
            return null;
        }

        public List<Merge> ReadAll()
        {
            return merges;
        }
        public void Serialize()
        {
            AllToCSV(merges);
        }
        public IEnumerable<Merge> Deserialize()
        {
            return (List<Merge>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\merges.csv").Select(FromCSV).ToList();

        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\merges.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<Merge> merges)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\merges.csv", string.Empty);
            foreach (Merge r in merges)
            {
                AppendLineToFile(ToCSV(r));
            }
        }

        private String ToCSV(Merge merges)    //serialization
        {
            return string.Join("_", merges.RoomID1, merges.Time1, merges.RoomID21);
        }

        private Merge FromCSV(String mergeFormat)     //deserialization
        {
            var tokens = mergeFormat.Split("_".ToCharArray());
            return new Merge(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[1]), Convert.ToString(tokens[2]));
        }

        public static List<Merge> merges = new List<Merge>();
    }
}
