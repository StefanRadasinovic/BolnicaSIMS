// File:    WpfViewModel.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 8:25:13 PM
// Purpose: Definition of Class WpfViewModel

using System;
using Controller;

namespace Model
{
   public class WpfViewModel
   {
      public PatientController patientController;
      public RoomsController roomsController;
      public AppointmentController appointmentController;
      public OperationController operationController;
   
   }
}