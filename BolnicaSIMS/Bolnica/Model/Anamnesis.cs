using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Model
{
    public class Anamnesis
    {


        public String AnamnesisID { get; set; }
        public String DoctorID { get; set; }

        public String PatientID { get; set; }
        public String Date { get; set; }

        public String Diagnosis { get; set; }
        
        public List<Therapy> Therapies { get; set; } = new List<Therapy>();


    }
}
