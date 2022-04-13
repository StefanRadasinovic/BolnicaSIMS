// File:    AppointmentService.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:12:02 PM
// Purpose: Definition of Class AppointmentService

using System;

namespace Model
{
   public class AppointmentService
   {
      private List<Appointment> allAppointments;
      
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
      
      public AppointmentRepository appointmentRepository;
   
   }
}