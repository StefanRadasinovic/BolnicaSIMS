// File:    AppointmentRepository.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:32:12 PM
// Purpose: Definition of Class AppointmentRepository

using System;

namespace Model
{
   public class AppointmentRepository
   {
      private String path;
      
      public Appointment Create(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void Read(String appointmentID)
      {
         throw new NotImplementedException();
      }
      
      public bool Update(String appointmentID)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(String appointmentID)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public Appointment GetAppointmentID(String appointmentID)
      {
         throw new NotImplementedException();
      }
   
   }
}