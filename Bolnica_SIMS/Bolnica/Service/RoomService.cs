// File:    RoomService.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 8:47:54 PM
// Purpose: Definition of Class RoomService

using System;
using System.Collections.Generic;

namespace Model
{
   public class RoomService
   {
      
      
      public void CreateRoom(Rooms room)
      {
            roomRepository.ReadAll().Add(room);
            roomRepository.Serialize();
         
      }
      
      public void UpdateRoom(Rooms room)
      {
            roomRepository.GetRooms(room.RoomID1);
            DeleteRoom(room.RoomID1);
            CreateRoom(room);
            roomRepository.Serialize();

        }

        public void DeleteRoom(String roomID)
      {
            Rooms r = null;
            foreach (Rooms r1 in roomRepository.ReadAll())
            {
                if (r1.RoomID1==roomID)
                {
                    r = r1;

                }

            }

            if (r != null)
            {
                roomRepository.ReadAll().Remove(r);
            }
            roomRepository.Serialize();
        }
      
      public List<Rooms> ReadAll()
      {
            return roomRepository.ReadAll();
      }
      
      public Rooms GetRoomID(string roomID)
      {
            return roomRepository.GetRooms(roomID);
      }

        public RoomRepository roomRepository = new RoomRepository();
   
   }

   
}