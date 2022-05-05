using System;
using System.Collections.Generic;
using System.Text;
using Model;

//SERVICE - PROBLEM SA PATIENT (NE VIDI GA KAO TIP, VEC KAO NAMESPACE)
namespace Service
{
    class PatientService
    {
        private static List<Patient> patients = new List<Patient>();

        public static bool RegisterPatient(Patient patient)
        {
            bool ret = false;
            patients.Add(patient);
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
