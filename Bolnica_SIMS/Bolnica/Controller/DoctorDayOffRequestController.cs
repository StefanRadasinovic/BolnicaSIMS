using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Controller
{
    public class DoctorDayOffRequestController
    {
        public static bool Create(DaysOffRequest operation)
        {
            return DoctorDayOffRequestService.Create(operation);
        }
    }
}
