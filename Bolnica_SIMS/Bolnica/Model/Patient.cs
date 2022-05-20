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


        private List<String> drugs;
        private List<String> alergies;
        private List<Appointment> appointments;

        private string text { get; set; }



        public Patient(string text)
        {
            this.text = text;
        }

    }
}