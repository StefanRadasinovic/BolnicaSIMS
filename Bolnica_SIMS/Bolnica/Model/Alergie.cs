using Bolnica.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Alergie : Serializable
    {
        private String name;

        public Alergie(string name)
        {
            this.name = name;
        }
        public Alergie() { }
        public string Name { get => name; set => name = value; }

        public string[] toCSV()
        {
            string[] csvValues =
           {
                Name
            };
            return csvValues;
        }

        public void fromCSV(string[] values)
        {
            Name = values[0];
        }
    }
}
