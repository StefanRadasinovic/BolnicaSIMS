// File:    Patient.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:41:39 PM
// Purpose: Definition of Class Patient

using Bolnica.Serialization;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Patient : User, Serializable
   {
        //private List<String> drugs;
        //private List<String> alergies;
        //private List<String> appointments;

        public int Abuse { get; set; }
        public bool Blocked { get; set; }



        public Patient(String name, String surname, int jmbg, String date, String phone, String email, String username, String pass)
        {
            Name = name;
            Surname = surname;
            Jmbg = jmbg;
            BirthDate = date;
            PhoneNum = phone;
            Email = email;
            Username = username;
            Password = pass;

            Abuse = 0;
            Blocked = false;

            //drugs = new List<String>();
            //alergies = new List<String>();
            //appointments = new List<String>();
        }
        public Patient() { }
        public void fromCSV(string[] values)
        {

            Name = values[0];
            Surname = values[1];
            Jmbg = int.Parse(values[2]);
            BirthDate = values[3];
            PhoneNum = values[4];
            Email = values[5];
            Username = values[6];
            Password = values[7];
        }

        public string[] toCSV()
        {
            string[] csvValues =
           {
                Name,
                Surname,
                Jmbg.ToString(),
                BirthDate,
                PhoneNum,
                Email,
                Username,
                Password
            };
            return csvValues;
        }

        //public List<string> Drugs { get => drugs; set => drugs = value; }
        // public List<string> Alergies { get => alergies; set => alergies = value; }
        //public List<String> Appointments { get => appointments; set => appointments = value; }

    }
}