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
        public static Appointment Create(Appointment appointment)
        {


            return AppointmentService.Create(appointment);

        }

        public void Read(String appointmentID)
        {
            throw new NotImplementedException();
        }

        public bool Update(String appointmentID)
        {
            throw new NotImplementedException();
        }


        public static bool Update2(String appointmentID, DateTime date)
        {
            AppointmentService appointmentService = new AppointmentService();
            if (appointmentService.Update2(appointmentID, date))
                return true;
            else return false;
        }



        public bool Delete(String appointmentID)
        {
            AppointmentService newappointmentService = new AppointmentService();
            if (AppointmentService.Delete(appointmentID))
                return true;
            else return false;

        }

        public List<Appointment> GetAll()
        {
            return AppointmentService.GetAll();
        }

        public Appointment GetAppointmentID(String appointmentID)
        {
            throw new NotImplementedException();
        }

        public AppointmentService appointmentService;

    }


}
