// File:    RoomsController.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 5:55:23 PM
// Purpose: Definition of Class RoomsController

using Bolnica.Manager;
using System;
using System.Collections.Generic;

namespace Model
{
    public class RoomsController
    {
        public static List<Rooms> rooms = new List<Rooms>();

        private RoomService roomService = new RoomService();
             
        public void Create(Rooms room)
        {
            roomService.CreateRoom(room);

        }

    public void Update(Rooms room)
        {
            roomService.UpdateRoom(room);

        }

        public void Delete(String roomID)
        {
            roomService.DeleteRoom(roomID);
        }

        public List<Rooms> GetAll()
        {
            return roomService.ReadAll();
        }

       public  Rooms GetRoomID(String roomID)
        {
            return roomService.GetRoomID(roomID);
        }

        

    }
}