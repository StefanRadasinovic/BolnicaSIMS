// File:    RoomsID.cs
// Author:  User
// Created: Tuesday, April 5, 2022 5:55:22 PM
// Purpose: Definition of Class RoomsID

using System;

namespace Model
{
    public class RoomsID
    {
        public String RoomID { get; set; }

        public RoomsID(string roomID)
        {
            RoomID = roomID;
        }
    }  
}