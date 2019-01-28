using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class Discipline
    {
        public String Name { get; set; }

        public Discipline(String name)
        {
            Name = name;
        }
    }
}
