using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    class Competences
    {
        public String Name { get; set; }
        public List<string> PreDiscipline { get; set; } // Дисц ДО
        public List<string> AfterDiscipline { get; set; } // Дисц ПОСЛЕ
    }
}
