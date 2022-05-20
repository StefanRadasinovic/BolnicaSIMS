using System;
using System.Collections.Generic;
using System.Text;
using Bolnica.Serialization;
using Model;

namespace Bolnica.Service
{
     class UserService
    {


        private static List<User> users = new List<User>();
        public static User getbyUserPass(String username, String password)
        {
            Serializer<User> ser = new Serializer<User>();
            // users = ser.fromCSV("C:\\Users\\user\\Desktop\\PROJEKATJEBENI\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\users.txt");
            users = ser.fromCSV("C:\\Users\\User\\BolnicaSIMS\\BolnicaSIMS\\Bolnica\\Resources\\users.txt");
            User u1 = null;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    u1 = users[i];
                }


            }
            return u1;
        }


       






    }
}
