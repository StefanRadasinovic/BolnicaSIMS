// File:    Patient.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:41:39 PM
// Purpose: Definition of Class Patient

using System;

namespace Model
{
   public class Patient : User
   {
      private List<String> drugs;
      private List<String> alergies;
      private List<Appointments> appointments;
   
   }
}