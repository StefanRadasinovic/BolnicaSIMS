using Bolnica.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolnica.Model
{
    public class DaysOffRequest : Serializable
    {
        String doctor;
        String pocetak;
        String kraj;

        public DaysOffRequest()
        {
        }

        public DaysOffRequest(string doctor, string pocetak, string kraj)
        {
            this.doctor = doctor;
            this.pocetak = pocetak;
            this.kraj = kraj;
        }

        public string Doctor { get => doctor; set => doctor = value; }
        public string Pocetak { get => pocetak; set => pocetak = value; }
        public string Kraj { get => kraj; set => kraj = value; }

        public void fromCSV(string[] values)
        {
            Doctor = values[0];
            Pocetak = values[1];
            Kraj = values[2];
        }

        public string[] toCSV()
        {
            string[] csvValues =
       {
                Doctor,
                Pocetak,
                Kraj
            };
            return csvValues;
        }
    }
}
