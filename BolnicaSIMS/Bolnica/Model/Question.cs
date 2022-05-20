using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Model
{
    public  class Question
    {

        public String QuestionText { get; set; }    
        
        public Mark Mark { get; set; }  

        public Question()
        {

        }

       

        public Question(Mark mark, string questionText)
        {
            Mark = mark;
            QuestionText = questionText;
        }

    }
}
