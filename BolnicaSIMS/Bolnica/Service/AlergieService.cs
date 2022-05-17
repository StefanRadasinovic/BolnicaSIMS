using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Bolnica.Service
{
    class AlergieService
    {
        private static List<Alergie> alergies = new List<Alergie>();

        public bool CreateAlergie(Alergie alergie)
        {
            bool ret = false;
            alergies.Add(alergie);
            //PatientView.Appointments.Add(appointment);

            if (alergies.Contains(alergie))
            {
                ret = true;
            }
            return ret;
        }

        public void UpdateAlergie(Alergie alergie)
        {
            DeleteAlergie(alergie.Name);
            CreateAlergie(alergie);
        }

        public bool DeleteAlergie(string name)
        {
            Alergie a = GetAlergieByName(name);
            return alergies.Remove(a);
        }

        public List<Alergie> GetAll()
        {
            return alergies;
        }

        public Alergie GetAlergieByName(string name)
        {
            foreach (Alergie a in alergies)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }

        public PatientRepository patientRepository;
    }
}
