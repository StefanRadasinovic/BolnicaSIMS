// File:    PatientRepository.cs
// Author:  user
// Created: Saturday, April 9, 2022 9:37:50 AM
// Purpose: Definition of Class PatientRepository

using System;

namespace Model
{
   public class PatientRepository
   {
      private String path;
      
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
   
   }
}