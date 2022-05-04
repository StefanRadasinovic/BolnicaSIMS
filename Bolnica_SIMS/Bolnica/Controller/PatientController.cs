// File:    PatientController.cs
// Author:  user
// Created: Saturday, April 9, 2022 9:37:49 AM
// Purpose: Definition of Class PatientController

using System;
using System.Collections.Generic;

namespace Model
{
   public class PatientController
   {
      public bool RegisterPatient(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void UpdatePatient(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public bool DeletePatient(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public Patient GetPatientByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public PatientService patientService;
   
   }
}