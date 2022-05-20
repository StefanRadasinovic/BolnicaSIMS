// File:    AppointmentService.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:12:02 PM
// Purpose: Definition of Class AppointmentService

using Bolnica.Patient;
using System;
using System.Collections.Generic;

namespace Model
{
    public class AppointmentService
    {
        //  private List<Appointment> allAppointments;
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



        ///OVAJ TI JE PRIVREMENI AL RADI  
        public bool Update2(String appointmentID, DateTime date)
        {
            Appointment appointment = GetAppointmentID(appointmentID);

            if (!appointment.Date.Equals(date))
                appointment.Date = date;

            // if (!appointment.TimeStart.Equals(time))
            //   appointment.TimeStart = time;

            Delete(appointmentID);
            Create(appointment);


            return true;
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