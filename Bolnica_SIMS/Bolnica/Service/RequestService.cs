using Bolnica.Manager;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Service
{
    internal class RequestService
    {

        public void Delete(String eqID)
        {
            RequestEquipmentcs r = null;
            foreach (RequestEquipmentcs r1 in requestRepository.ReadAll())
            {
                if (r1.EqID == eqID)
                {
                    r = r1;

                }

            }

            if (r != null)
            {
                requestRepository.ReadAll().Remove(r);
            }
        }

        public void Create(RequestEquipmentcs r)
        {
            requestRepository.ReadAll().Add(r);
            requestRepository.Serialize();


        }

       /* public void CheckTime(DateTime date)
        {
            RequestEquipmentcs r = null;
            foreach (RequestEquipmentcs r1 in requestRepository.ReadAll())
            {
                if (r1.DateMove == date)
                {
                    r = r1;
                  
                }
              

            }

            if (r != null)
            {
                requestRepository.ReadAll().Add(r);
            }
        }*/


        public List<RequestEquipmentcs> ReadAll()
        {
            return requestRepository.ReadAll();
        }

        private RequestRepository requestRepository = new RequestRepository();
       
         }
    }
