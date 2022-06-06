using System;
using System.Collections.Generic;
using System.Text;
using Bolnica.Model;
using Service;

namespace Bolnica.Controller
{
    public  class SurveyController
    {
        SurveyService surveyService = new SurveyService();

      public static List<Survey>surveys = new List<Survey>();   
        public static List<Question> question = new List<Question> { new Question() };

        public static List<Question> GetAllQuestionsAboutOperation()
        {
            return question;


        }


        public static List<Question> GetAllQuestionsAboutBolnica()
        {
            return question;
        }
        public static List<Survey> GetAllSurveys()
        {
            return surveys;
        }

        /*************************/

        public static void AddSurvey(Survey survey)
        {
            surveys.Add(survey);
        }


    }
}
