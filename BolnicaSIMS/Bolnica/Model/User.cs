// File:    User.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:38:13 PM
// Purpose: Definition of Class User

using System;

namespace Model
{
   public class User
   {
      private String name;
      private String surname;
      private int jmbg;
      private String birthDate;
      private String phoneNum;
      private String email;
      private String username;
      private String password;
      
      public Adress adress;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Jmbg { get => jmbg; set => jmbg = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }
}