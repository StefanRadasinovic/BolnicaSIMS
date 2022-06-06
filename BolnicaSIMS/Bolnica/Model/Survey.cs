using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Bolnica.Model
{
    public class Survey
    {
        private string v1;
        private DateTime dateTime;
        private string v2;

        public Patient Patient { get; set; }
        public DateTime RatedBolnicu { get; set; }
        public Operation Operation { get; set; }
        public List<Question> QuestionSurvey { get; set; }
        public String MoreComments { get; set; }


        public Survey() { }



        public Survey(Patient patient, DateTime ratedBolnicu, Operation operation, List<Question> questionSurvey, string moreComments)
        {
            Patient = patient;
            RatedBolnicu = ratedBolnicu;
            Operation = operation;
            QuestionSurvey = questionSurvey;
            MoreComments = moreComments;
        }

        public Survey(string v1, DateTime dateTime, string v2)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
        }
    }
}
