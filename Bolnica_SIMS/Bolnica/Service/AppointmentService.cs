// File:    AppointmentService.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:12:02 PM
// Purpose: Definition of Class AppointmentService

using System;
using System.Collections.Generic;
using Model;
using Bolnica.View;
using Repository;
using Model;
using Bolnica.Serialization;

namespace Service
{
   public class AppointmentService
   {
        // private List<Appointment> allAppointments;
        public static List<Appointment> allAppointments = new List<Appointment>();

        public static List<Appointment> apointments = new List<Appointment>();

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

        public static bool Create2(Appointment appointment)
        {
            
            bool ret = false;
            apointments.Add(appointment);
            Serializer<Appointment> ser = new Serializer<Appointment>();
            ser.toCSV("C:\\Users\\user\\Desktop\\PROJEKATJEBENI\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\appointments.txt", apointments);

            //PatientView.Appointments.Add(appointment);

            if (apointments.Contains(appointment))
            {
                ret = true;
            }
            return ret;
        }

        public void Read(String appointmentID)
      {
         throw new NotImplementedException();
      }

        public bool Update(String appointmentID, DateTime date, DateTime time)
        {
            Appointment appointment = GetAppointmentID(appointmentID);

            if (!appointment.Date.Equals(date))
                appointment.Date = date;

            if (!appointment.TimeStart.Equals(time))
                appointment.TimeStart = time;

            Delete(appointmentID);
            Create(appointment);


            return true;
        }

        public static void UpdateAppointment(Appointment appointment)
        {
            //Patient p = GetPatientByJMBG(patient.Jmbg);

            DeleteAppointment(appointment.AppID);
            Create2(appointment);

        }
        public static bool DeleteAppointment(String id)
        {
            Appointment a = GetAppID(id);
            return apointments.Remove(a);
        }

        public bool Update2(String appointmentID, DateTime date) //DateTime time
        {
            Appointment appointment = GetAppointmentID(appointmentID);

            if (!appointment.Date.Equals(date))
                appointment.Date = date;

            //  if (!appointment.TimeStart.Equals(time))
            //  appointment.TimeStart = time;

            Delete(appointmentID);
            Create(appointment);


            return true;
        }


        public static bool Delete(String appointmentID)
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

        public static List<Appointment> GetAll2()
        {
            Serializer<Appointment> ser = new Serializer<Appointment>();
            apointments = ser.fromCSV("C:\\Users\\user\\Desktop\\PROJEKATJEBENI\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\appointments.txt");
            return apointments;
        }
        public static Appointment GetAppID(String appointmentID)
        {
            foreach (Appointment appointment in apointments)
            {
                if (appointment.AppID.Equals(appointmentID))
                    return appointment;
            }
            return null;
        }

        public static Appointment GetAppointmentID(String appointmentID)
        {
            foreach (Appointment appointment in allAppointments)
            {
                if (appointment.AppointmentID.Equals(appointmentID))
                    return appointment;
            }
            return null;
        }

       // public AppointmentRepository appointmentRepository;

    }
}