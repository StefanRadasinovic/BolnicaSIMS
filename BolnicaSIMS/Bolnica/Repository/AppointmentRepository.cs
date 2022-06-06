// File:    AppointmentRepository.cs
// Author:  User
// Created: Thursday, April 7, 2022 2:32:12 PM
// Purpose: Definition of Class AppointmentRepository

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model;

namespace Repository
{
   public class AppointmentRepository
   {
      private String path;

        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
       .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

      public List<Appointment> Appointments = new List<Appointment>();
      
      public List<Appointment> Read()
      {
            return Appointments;
      }

        public void Serialize()
        {
            AllToCSV(Appointments);
        }

        public void AllToCSV(IEnumerable<Appointment> renovations)
        {
            
            foreach (Appointment appo in Appointments)
            {
                AppendLineToFile(ToCSV(appo));
            }
        }
        public String ToCSV(Appointment appo)    //serialization
        {
            return string.Join("^", appo.AppointmentID, appo.Date, appo.Time);
        }

        public List<Appointment> Deserialize()
        {
            return (List<Appointment>)File.ReadAllLines(projectPath + "\\CSVFiles\\").Select(FromCSV);

        }


        public void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\CSVFiles\\", line + Environment.NewLine);
        }

        public Appointment FromCSV(String eqFormat)     //deserialization
        {
            var tokens = eqFormat.Split("^".ToCharArray());
            //return new Rooms(Convert.ToInt32(tokens[0]),Convert.ToString(tokens[1]), (RoomsType)Enum.Parse(typeof(RoomsType), tokens[1]), Convert.ToSingle(tokens[2]), Convert.ToInt32(tokens[3]), Convert.ToInt32(tokens[4]));
            return new Appointment(Convert.ToString(tokens[0]), Convert.ToDateTime(tokens[2]), Convert.ToString(tokens[3]));
        }

        public List<Appointment> GetAll()
      {
            return Appointments;
      }
      
      
   
   }
}