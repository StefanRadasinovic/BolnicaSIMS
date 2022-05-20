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

            /* roomRepository.GetRooms(room.RoomID1);
             roomRepository.ReadAll().Remove(room);
             roomRepository.ReadAll().Add(room);*/

            roomRepository.Serialize();


        }

        public void DeleteRoom(String roomID)
        {
            Rooms r = null;
            foreach (Rooms r1 in roomRepository.ReadAll())
            {
                if (r1.RoomID1 == roomID)
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


        public bool SplitRooms(Rooms room, string roomID)
        {
            try
            {
                foreach (Rooms r in roomRepository.ReadAll())
                    if (r.RoomID1 == roomID)
                    {
                        r.RoomSize1 -= room.RoomSize1;
                        roomRepository.ReadAll().Add(room);
                    }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MergeRooms(Rooms room, string roomID)
        {
            try
            {
                foreach (Rooms r in roomRepository.ReadAll())
                    if (r.RoomID1 == roomID)
                    {
                        r.RoomSize1 += room.RoomSize1;
                    }
                foreach (Rooms r in roomRepository.ReadAll())
                    if (r.RoomID1 == roomID)
                    {
                        roomRepository.ReadAll().Remove(room);
                    }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public RoomRepository roomRepository = new RoomRepository();

    }


}