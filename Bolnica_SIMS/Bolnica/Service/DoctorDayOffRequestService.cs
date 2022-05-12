using Bolnica.Model;
using Bolnica.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Service
{
    public class DoctorDayOffRequestService
    {
        private const string FileName = "C:\\Users\\Branislav\\Desktop\\FAKS\\SIMS\\Projekat konacan\\BolnicaSIMS\\Bolnica_SIMS\\Bolnica\\Resources\\daysOffRequests.txt";
        private static List<DaysOffRequest> operations = new List<DaysOffRequest>();

        public static bool Create(DaysOffRequest request)
        {
            if (request != null)
            {
                operations.Add(request);
                Serializer<DaysOffRequest> ser = new Serializer<DaysOffRequest>();
                ser.toCSV(FileName, operations);
                return true;
            }
            else
                return false;
        }
    }
}
