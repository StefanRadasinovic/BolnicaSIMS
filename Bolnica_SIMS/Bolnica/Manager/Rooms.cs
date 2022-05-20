// File:    Rooms.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 5:55:22 PM
// Purpose: Definition of Class Rooms

using System;

namespace Model
{
    public class Rooms
    {

        private String RoomID;
        private int floor;
        private String roomName;
        private RoomsType roomsType;
        private int RoomSize;

        public Rooms()
        {
        }

        public Rooms(string roomID, int floor, string roomName, RoomsType roomsType)
        {
            RoomID = roomID;
            this.floor = floor;
            this.roomName = roomName;
            this.roomsType = roomsType;
            //this.RoomSize = roomSize;
        }

        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public int Floor { get => floor; set => floor = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public RoomsType RoomsType { get => roomsType; set => roomsType = value; }
        public int RoomSize1 { get => RoomSize; set => RoomSize = value; }
    }



}