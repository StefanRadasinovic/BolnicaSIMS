// File:    AppointmentService.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:12:02 PM
// Purpose: Definition of Class AppointmentService

using System;
using System.Collections.Generic;
using Bolnica.Patient;

namespace Model
{
   public class AppointmentService
   {
        //  private List<Appointment> allAppointments;
        public static List<Appointment> allAppointments = new List<Appointment>();

        public Appointment Create(Appointment appointment)
      {
            allAppointments.Add(appointment);
            PatientView.Appointments.Add(appointment);

            if (allAppointments.Contains(appointment))
            {
                return appointment;
            }
            else
            {
                return null;
            }
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
      
      public static List<Appointment> GetAll()
      {
            return allAppointments;
        }
      
      public Appointment GetAppointmentID(String appointmentID)
      {
         throw new NotImplementedException();
      }
      
      public AppointmentRepository appointmentRepository;
   
   }
}