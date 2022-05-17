using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Alergie
    {
        private String name;

        public Alergie(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
