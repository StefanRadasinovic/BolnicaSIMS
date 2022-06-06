// File:    User.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:38:13 PM
// Purpose: Definition of Class User

using System;
using Bolnica.Serialization;

public enum Role
{
    UPRAVNIK,
    DOKTOR,
    SEKRETAR,
    PACIJENT
}


namespace Model
{
    public class User : Serializable
    {
        private String name;
        private String surname;
        private int jmbg;
        private String birthDate;
        private String phoneNum;
        private String email;
        private String username;
        private String password;
        private Role role;

        public Adress adress;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Jmbg { get => jmbg; set => jmbg = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }

        public int Abuse { get; set; }
        public bool Blocked { get; set; }

        public string[] toCSV()
        {
            return null;
        }

        public void fromCSV(string[] values)
        {
            Name = values[0];
            Surname = values[1];
            Jmbg = Convert.ToInt32(values[2]);
            BirthDate = values[3];
            PhoneNum = values[4];
            Email = values[5];
            Username = values[6];
            Password = values[7];
            Role = (Role)Enum.Parse(typeof(Role), values[8]);
        }
    }


}