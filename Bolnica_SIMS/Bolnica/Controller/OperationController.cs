// File:    OperationController.cs
// Author:  User
// Created: Wednesday, April 13, 2022 1:18:00 PM
// Purpose: Definition of Class OperationController

using System;
using System.Collections.Generic;

namespace Model
{
   public class OperationController
   {
        public static bool Create(Model.Operation operation)
        {
            return Model.OperationService.Create(operation);
        }

        public static bool Update(Model.Operation operation)
        {
            return Model.OperationService.Update(operation);
        }

        public bool Delete(int operationID)
        {
            return Model.OperationService.Delete(operationID);
        }

        public Model.Operation GetOperation(int operationID)
        {
            return Model.OperationService.GetOperation(operationID);
        }

        public List<Operation> GetByDoctor(int doctorID)
        {
            return Model.OperationService.GetByDoctor(doctorID);
        }

        public List<Operation> GetByPatient(int patientID)
        {
            return Model.OperationService.GetByPatient(patientID);
        }

        public OperationService operationService;
    }
}