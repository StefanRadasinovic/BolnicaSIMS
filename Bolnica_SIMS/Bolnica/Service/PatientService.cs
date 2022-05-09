using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Bolnica.Serialization;

//SERVICE - PROBLEM SA PATIENT (NE VIDI GA KAO TIP, VEC KAO NAMESPACE)
namespace Service
{
    class PatientService
    {
        private static List<Patient> patients = new List<Patient>();
        private String fileName = "C:\\Users\\Branislav\\Desktop\\FAKS\\SIMS\\Projekat konacan\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\patients.txt";

        public bool RegisterPatient(Patient patient)
        {
            //C:\Users\user\Desktop\PROJEKATJEBENI\BolnicaSIMS\Bolnica_SIMS\Bolnica\Resources
            bool ret = false;
            patients.Add(patient);
            Serializer<Patient> ser = new Serializer<Patient>();
            ser.toCSV(fileName, patients);

            //PatientView.Appointments.Add(appointment);

            if (patients.Contains(patient))
            {
                ret = true;
            }
            return ret;
        }

        public void UpdatePatient(Patient patient)
        {
            //Patient p = GetPatientByJMBG(patient.Jmbg);

            DeletePatient(patient.Jmbg);
            RegisterPatient(patient);

        }

        public bool DeletePatient(int jmbg)
        {
            Patient p = GetPatientByJMBG(jmbg);
            return patients.Remove(p);
        }

        public List<Patient> GetAll()
        {
            Serializer<Patient> ser = new Serializer<Patient>();
            patients = ser.fromCSV(fileName);
            return patients;
        }

        public Patient GetPatientByJMBG(int jmbg)
        {
            foreach (Patient p in patients)
            {
                if (p.Jmbg == jmbg)
                {
                    return p;
                }
            }
            return null;
        }

        public PatientRepository patientRepository;

    }
}
