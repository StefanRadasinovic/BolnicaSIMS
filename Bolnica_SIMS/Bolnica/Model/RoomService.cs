// File:    RoomService.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 8:47:54 PM
// Purpose: Definition of Class RoomService

using System;

namespace Model
{
   public class RoomService
   {
      private List<Room> rooms;
      
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
      
      public RoomRepository roomRepository;
   
   }
}