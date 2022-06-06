using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Model
{
    public  class Medication
    {

        public String MedicationID { get; set; }
        public String MedicationName { get; set; }
        public String Strength { get; set; }

        public Medication()
        {
        }



        public Medication( string medicationId, string medicationName, string strength)
        {
            MedicationID = medicationId;    
            MedicationName = medicationName;
            Strength = strength;
        }




    }
}
