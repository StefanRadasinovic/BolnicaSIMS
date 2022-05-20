// File:    AppointmentService.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:12:02 PM
// Purpose: Definition of Class AppointmentService

using System;
using System.Collections.Generic;
using Model;
using Bolnica.View;
using Repository;

namespace Service
{
   public class AppointmentService
   {

        public static int MAX_NUM = 5;
        // private List<Appointment> allAppointments;
        public static List<Appointment> allAppointments = new List<Appointment>();

        public static Appointment Create(Appointment appointment)
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

        public bool Update(String appointmentID, DateTime date, String time)
        {
            Appointment appointment = GetAppointmentID(appointmentID);

            if (!appointment.Date.Equals(date))
                appointment.Date = date;

            if (!appointment.Time.Equals(time))
                appointment.Time = time;

            Delete(appointmentID);
            Create(appointment);


            return true;
        }
        
        public static bool CheckPatientAccount(Patient patient)
        {
            int num = patient.Abuse + 1;
            patient.Abuse = num;
            if (patient.Abuse > MAX_NUM)
            {
                patient.Blocked = true;
                return true;
            }
            return false;

        }
        


        public bool Delete(String appointmentID)
        {
            Appointment appointment = GetAppointmentID(appointmentID);
            allAppointments.Remove(appointment);
            PatientView.Appointments.Remove(appointment);

            if (appointment == null)
                return false;
            else
                return true;
        }

        public static List<Appointment> GetAll()
        {
            return allAppointments;
        }

        public Appointment GetAppointmentID(String appointmentID)
        {
            foreach (Appointment appointment in allAppointments)
            {
                if (appointment.AppointmentID.Equals(appointmentID))
                    return appointment;
            }
            return null;
        }

        public AppointmentRepository appointmentRepository;

    }
}