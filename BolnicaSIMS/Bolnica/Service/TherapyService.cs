using System;
using System.Collections.Generic;
using System.Text;
using Bolnica.Model;
using Bolnica.View;

namespace Bolnica.Service
{
    public class TherapyService
    {


        public static List<Therapy> allTherapys = new List<Therapy>();
        
                public static Therapy  Create(Therapy therapy)

                {
                    
                    allTherapys.Add(therapy);
               //     TherapyView.Therapys.Add(therapy);
                    if (allTherapys.Contains(therapy))
                    {
                        return therapy;
                    }
                    else
                    {
                        return null;
                    }




                }
        

       

      
        public Therapy GetTherapyID(String therapyID)
        {
            foreach (Therapy therapy in allTherapys)
            {
                if (therapy.TherapyID.Equals(therapyID))
                    return therapy;
            }
            return null;
        }

        public void Save( Therapy newTherapy)
        {
            allTherapys.Add(newTherapy);
        }

        public static List<Therapy> GetAll()
        {
            return allTherapys;
        }
    }
}
