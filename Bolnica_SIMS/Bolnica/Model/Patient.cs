// File:    Patient.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:41:39 PM
// Purpose: Definition of Class Patient

using System;
using System.Collections.Generic;

namespace Model
{
   public class Patient : User
   {
      private List<String> Drugs;
      private List<String> Alergies;
      private List<Appointment> Appointments;
   
   }
}