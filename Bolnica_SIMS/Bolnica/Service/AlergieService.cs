using System;
using System.Collections.Generic;
using System.Text;
using Bolnica.Serialization;
using Model;

namespace Bolnica.Service
{
    class AlergieService
    {
        private static List<Alergie> alergies = new List<Alergie>();

        public static bool CreateAlergie(Alergie alergie)
        {
            bool ret = false;
            alergies.Add(alergie);

            Serializer<Alergie> ser = new Serializer<Alergie>();
            ser.toCSV("C:\\Users\\user\\Desktop\\PROJEKATJEBENI\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\alergies.txt", alergies);
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

        public static bool DeleteAlergie(string name)
        {
            Alergie a = GetAlergieByName(name);
            return alergies.Remove(a);
        }

        public static List<Alergie> GetAll()
        {
            Serializer<Alergie> ser = new Serializer<Alergie>();
            alergies = ser.fromCSV("C:\\Users\\user\\Desktop\\PROJEKATJEBENI\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\alergies.txt");
            return alergies;
        }

        public static Alergie GetAlergieByName(string name)
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
