// File:    RoomsController.cs
// Author:  ANA
// Created: Tuesday, April 5, 2022 5:55:23 PM
// Purpose: Definition of Class RoomsController

using System;

namespace Model
{
   public class RoomsController
   {
      public bool Create(Rooms room)
      {
         throw new NotImplementedException();
      }
      
      public bool Update(int roomID, String name, RoomsType roomType)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Rooms roomID)
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
      
      public RoomService roomService;
   
   }
}