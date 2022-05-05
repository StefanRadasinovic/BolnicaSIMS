using Bolnica.Manager;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bolnica.Repository
{
    internal class RequestRepository
    {
        private static string projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
       .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        public RequestRepository()
        {
            requestEquipmentcs1 = (List<RequestEquipmentcs>)Deserialize();
        }
        public RequestEquipmentcs Read(String id)
        {
            foreach (RequestEquipmentcs request
                in requestEquipmentcs1)
                if (request.EqID == id)
                    return request;
            return null;
        }

        public List<RequestEquipmentcs> ReadAll()
        {
            return requestEquipmentcs1;
        }
        public void Serialize()
        {
            AllToCSV(requestEquipmentcs1);
        }
        public IEnumerable<RequestEquipmentcs> Deserialize()
        {
            return (List<RequestEquipmentcs>)File.ReadAllLines(projectPath + "\\Resources\\CSVFiles\\requestEq.csv").Select(FromCSV).ToList();

        }


        public void AppendLineToFile(string line)
        {
            File.AppendAllText(projectPath + "\\Resources\\CSVFiles\\requestEq.csv", line + Environment.NewLine);
        }


        public void AllToCSV(IEnumerable<RequestEquipmentcs> requestEquipmentcs)
        {
            File.WriteAllText(projectPath + "\\Resources\\CSVFiles\\requestEq.csv", string.Empty);
            foreach (RequestEquipmentcs request in requestEquipmentcs)
            {
                AppendLineToFile(ToCSV(request));
            }
        }

        public String ToCSV(RequestEquipmentcs requestEquipmentcs)    //serialization
        {
            return string.Join("_", requestEquipmentcs.EqID, requestEquipmentcs.RoomType, requestEquipmentcs.DateMove);
        }

        public RequestEquipmentcs FromCSV(String eqFormat)     //deserialization
        {
            var tokens = eqFormat.Split("_".ToCharArray());
            //return new Rooms(Convert.ToInt32(tokens[0]),Convert.ToString(tokens[1]), (RoomsType)Enum.Parse(typeof(RoomsType), tokens[1]), Convert.ToSingle(tokens[2]), Convert.ToInt32(tokens[3]), Convert.ToInt32(tokens[4]));
            return new RequestEquipmentcs(Convert.ToString(tokens[0]), (RoomsType)Enum.Parse(typeof(RoomsType), tokens[1]), Convert.ToDateTime(tokens[2]));
        }

        public List<RequestEquipmentcs> requestEquipmentcs1 = new List<RequestEquipmentcs>();
    }
}
