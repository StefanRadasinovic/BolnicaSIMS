// File:    AppointmentController.cs
// Author:  User
// Created: Thursday, April 7, 2022 1:37:56 PM
// Purpose: Definition of Class AppointmentController

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
    public class AppointmentController
    {
        AppointmentService appointmentService1 = new AppointmentService();  

        public static Appointment Create(Appointment appointment)
        {


            return AppointmentService.Create(appointment);

        }
        
        public List<Appointment> Read()
        {
            return appointmentService1.Read();
        }

        public bool Update(String appointmentID, DateTime date, String? time)
        {
            AppointmentService appointmentService = new AppointmentService();
            if (appointmentService.Update(appointmentID, date, time))
                return true;
            else return false;
        }


       



        public bool Delete(String appointmentID)
        {
            AppointmentService newappointmentService = new AppointmentService();
            if (newappointmentService.Delete(appointmentID))
                return true;
            else return false;

        }

        public List<Appointment> GetAll()
        {
            return AppointmentService.GetAll();
        }

        public Appointment GetAppointmentID(String appointmentID)
        {
            return appointmentService1.GetAppointmentID(appointmentID);
        }

       

    }


}
