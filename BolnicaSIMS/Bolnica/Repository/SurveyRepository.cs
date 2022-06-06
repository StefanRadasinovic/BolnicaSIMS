using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Bolnica.Model;

namespace Bolnica.Repository
{
    public  class SurveyRepository
    {

        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
       .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public List<Survey> Surveys = new List<Survey>();


        public List<Survey> Read()
        {
            return Surveys;
        }

        public void Serialize()
        {
            AllToCSV(Surveys);
        }

        public void AllToCSV(IEnumerable<Survey> renovations)
        {

            foreach (Survey survey in Surveys)
            {
                AppendLineToFile(ToCSV(survey));
            }
        }
        public String ToCSV(Survey survey)    //serialization
        {
            return string.Join("^", survey.Patient, survey.RatedBolnicu, survey.Operation);
        }

        public List<Survey> Deserialize()
        {
            return (List<Survey>)File.ReadAllLines(projectPath + "\\CSVFiles\\surveys.csv").Select(FromCSV);

        }


        public void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\CSVFiles\\", line + Environment.NewLine);
        }

        public Survey FromCSV(String eqFormat)     //deserialization
        {
            var tokens = eqFormat.Split("^".ToCharArray());
            //return new Rooms(Convert.ToInt32(tokens[0]),Convert.ToString(tokens[1]), (RoomsType)Enum.Parse(typeof(RoomsType), tokens[1]), Convert.ToSingle(tokens[2]), Convert.ToInt32(tokens[3]), Convert.ToInt32(tokens[4]));
            return new Survey(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[2]), Convert.ToString(tokens[3]));
        }

        public List<Survey> GetAll()
        {
            return Surveys;
        }

        









    }
}
