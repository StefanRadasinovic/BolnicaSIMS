// File:    RoomRepository.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 7:27:15 PM
// Purpose: Definition of Class RoomRepository

using System;

namespace Model
{
   public class RoomRepository
   {
      private String path;
      
      public bool CreateRoom(Rooms rooms)
      {
         throw new NotImplementedException();
      }
      
      public bool UpdateRoom(int roomID, String name, RoomsType roomType)
      {
         throw new NotImplementedException();
      }
      
      public bool DeleteRoom(int roomID)
      {
         throw new NotImplementedException();
      }
      
      public List<Rooms> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public Rooms GetRoomID(int roomID)
      {
         throw new NotImplementedException();
      }
   
   }
}