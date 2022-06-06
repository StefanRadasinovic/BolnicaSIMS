using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Model
{
    public class Therapy
    {

        public String TherapyID { get; set; }
        public String AnamnesisID { get; set; }
        public String TherapyStart { get; set; }
        public String TherapyEnd { get; set; }
        public String Amount { get; set; }
       // public String Time { get; set; }
        public String Medication { get; set; }  
        
        public String DoctorName { get; set; }  


        public Medication RecommendedMedication { get; set; }

        public Therapy() { }

        public Therapy( string therapyID, string medication, string amount, string therapyStart, string therapyEnd )
        {
            TherapyID = therapyID;
            Medication = medication;
            Amount = amount;
            TherapyStart = therapyStart;
            TherapyEnd = therapyEnd;
         
           

        }

    }
}
