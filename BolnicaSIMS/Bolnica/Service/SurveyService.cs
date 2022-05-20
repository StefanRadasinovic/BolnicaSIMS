using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Bolnica.Model;
using Model;

namespace Service
{
    public class SurveyService
    {
       
        public static String allSurveyFile = "allSurvey.xml";

        public static List<Question> questionsAboutOperation = new List<Question>();
        public static List<Question> questionsAboutBolnica = new List<Question>();
        public static List<Survey> filledSurvey = new List<Survey>();




        public static void initializationQuestionsAboutOperation()
        {
            questionsAboutOperation.Add(new Question(Mark.pet, "Doctor apperance"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Doctor professionalism"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Waiting time"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Room hygiene"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Staff friendliness"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Operation satisfaction"));
            questionsAboutOperation.Add(new Question(Mark.pet, "Overall Doctor evaluation"));
        }

        public static void initializationQuestionsAboutBolnica()
        {
            questionsAboutBolnica.Add(new Question(Mark.pet, "Appearance of Bolnica"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Bolnica hygiene"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Bolnica location"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Parking lots"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Bolnica application"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Bolnica staff evaluation"));
            questionsAboutBolnica.Add(new Question(Mark.pet, "Overall Bolnica evaluation"));
        }



        public static List<Question> GetAllQuestionsAboutOperation()
        {
            return questionsAboutOperation;
        }


        public static List<Question> GetAllQuestionsAboutBolnica()
        {
            return questionsAboutBolnica;
        }
        public static List<Survey> GetAllSurveys()
        {
            return filledSurvey;
        }

        /*************************/

        public static void AddSurvey(Survey survey)
        {
            filledSurvey.Add(survey);
        }
/*
        public static bool FreeSurveyAboutBolnica(Patient patient)
        {
            DateTime newSurvey = FindLastSurveyDateAboutBolnica(patient).AddMonths(3);
            if (DateTime.Compare(DateTime.Now.Date, newSurvey.Date) >= 0)
                return true;

            return false;
        }
*/
        /*
        public static DateTime FindLastSurveyDateAboutBolnica(Patient patient)
        {
            List<Survey> patientSurvey = new List<Survey>();
            foreach (Survey survey in filledSurvey)
            {
                if (survey.Patient.Username.Equals(patient.Username) && survey.Operation == null)         ///OVDE TREBA IZMENITI NAKON STO SE NAPRAVI POCETNI EKRAN SA
                                                                                                                    //SIFROM 
                {
                    patientSurvey.Add(survey);
                }
            }
            if (patientSurvey.Count == 0)
            {
                return DateTime.Now.Date.AddMonths(-3);
            }
        

            return SortOperationDates(patientSurvey)[0].RatedBolnicu;
        }
        */

        public static List<Survey> SortOperationDates(List<Survey> unsortedDates)
        {
            return unsortedDates.OrderByDescending(user => user.RatedBolnicu).ToList();
        }


        public static List<Survey> LoadSurvey()
        {
            if (!File.Exists(allSurveyFile) || File.ReadAllText(allSurveyFile).Trim().Equals(""))
            {
                return filledSurvey;
            }
            else
            {
                FileStream fileStream = File.OpenRead(allSurveyFile);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Survey>));
                filledSurvey = (List<Survey>)xmlSerializer.Deserialize(fileStream);
                fileStream.Close();
                return filledSurvey;
            }







        }
        public static void ReadSurvey()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Survey>));
            TextWriter tw = new StreamWriter(allSurveyFile);
            xmlSerializer.Serialize(tw, filledSurvey);
            tw.Close();

        }
    }

 }
