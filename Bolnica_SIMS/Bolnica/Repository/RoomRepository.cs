// File:    RoomRepository.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 7:27:15 PM
// Purpose: Definition of Class RoomRepository

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Model
{
    public class RoomRepository
    {

        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
         .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public RoomRepository()
        {
            rooms = (List<Rooms>)Deserialize();
        }
        public Rooms GetRooms(String id)
        {
            foreach (Rooms r in rooms)
                if (r.RoomID1 == id)
                    return r;
            return null;
        }

        public List<Rooms> ReadAll()
        {
            return rooms;
        }
        public void Serialize()
        {
            AllToCSV(rooms);
        }
        public IEnumerable<Rooms> Deserialize()
        {
            return (List<Rooms>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\rooms.csv").Select(FromCSV).ToList();

        }


        private void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\rooms.csv", line + Environment.NewLine);
        }


        private void AllToCSV(IEnumerable<Rooms> rooms)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\rooms.csv", string.Empty);
            foreach (Rooms r in rooms)
            {
                AppendLineToFile(ToCSV(r));
            }
        }

        private String ToCSV(Rooms rooms)    //serialization
        {
            return string.Join("_", rooms.RoomID1, rooms.Floor, rooms.RoomName, rooms.RoomsType);
        }

        private Rooms FromCSV(String roomFormat)     //deserialization
        {
            var tokens = roomFormat.Split("_".ToCharArray());
            return new Rooms(Convert.ToString(tokens[0]), Convert.ToInt32(tokens[1]), Convert.ToString(tokens[2]), (RoomsType)Enum.Parse(typeof(RoomsType), tokens[3]));
        }

        public List<Rooms> rooms = new List<Rooms>();



    }
}