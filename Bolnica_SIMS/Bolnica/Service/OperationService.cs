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
      private List<Operation> operations;
      
      public bool Create(Operation operation)
      {
         throw new NotImplementedException();
      }
      
      public bool Update(Operation operation)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(String operationID)
      {
         throw new NotImplementedException();
      }
      
      public Operation GetOperation(String operationID)
      {
         throw new NotImplementedException();
      }
      
      public List<Operation> GetByDoctor(int doctorID)
      {
         throw new NotImplementedException();
      }
      
      public List<Operation> GetByPatient()
      {
         throw new NotImplementedException();
      }
      
      public List<Operation> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public OperationRepository operationRepository;
   
   }
}