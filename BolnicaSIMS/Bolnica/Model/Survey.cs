using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Bolnica.Model
{
    public class Survey
    {
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
    }
}
