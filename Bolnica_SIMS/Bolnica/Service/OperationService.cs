// File:    OperationService.cs
// Author:  User
// Created: Wednesday, April 13, 2022 1:18:00 PM
// Purpose: Definition of Class OperationService

using System;
using System.Collections.Generic;

namespace Model
{
   public class OperationService
   {
        private static List<Operation> operations = new List<Operation>();

        public static bool Create(Model.Operation operation)
        {
            if (operation != null)
            {
                foreach (Operation op in operations)
                {
                    if (op.OperationID.Equals(operation.OperationID))
                    {
                        return false;
                    }
                }
                operations.Add(operation);
                return true;
            }
            else
                return false;
        }
        public static bool Update(Model.Operation operation)
        {
            if (operation != null)
            {
                Operation op = GetOperation(operation.OperationID);
                if (op != null)
                {
                    op.DoctorID = operation.DoctorID;
                    op.RoomID = operation.RoomID;
                    op.TimeStart = operation.TimeStart;
                    op.TimeEnd = operation.TimeEnd;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public static bool Delete(int operationID)
        {
            Operation op = GetOperation(operationID);
            return operations.Remove(op);
            /* if (op != null)
             {
                 operations.Remove(op);
                 return true;
             }
             else
                 return false;
            */
        }

        public static Model.Operation GetOperation(int operationID)
        {
            foreach (Operation op in operations)
            {
                if (op.OperationID.Equals(operationID))
                {
                    return op;
                }
            }
            return null;
        }

        public static List<Operation> GetAll()
        {
            return operations;
        }

        public static List<Operation> GetByDoctor(int doctorID)
        {
            List<Operation> docsOps = new List<Operation>();
            foreach (Operation op in operations)
            {
                if (op.DoctorID.Equals(doctorID))
                {
                    docsOps.Add(op);
                }
                else
                    continue;
            }
            return docsOps;
        }

        public static List<Operation> GetByPatient(int patientID)
        {
            List<Operation> patiOps = new List<Operation>();
            foreach (Operation op in operations)
            {
                if (op.PatientID.Equals(patientID))
                {
                    patiOps.Add(op);
                }
                else
                    continue;
            }
            return patiOps;

        }

        public OperationRepository operationRepository;

    }
}