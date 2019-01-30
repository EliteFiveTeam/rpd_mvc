using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class ProfileEducational
    {
        public String Name { get; set; }
        public String Year { get; set; }
        public String Direction { get; set; } 
        public string Standart { get; set; }
        public List<string> Activities;

        public ProfileEducational()
        {
        }

        public ProfileEducational(String nameProfile, String yearProfile)
        {
           Name = nameProfile;
           Year = yearProfile;
        }

        public String GetFullName()
        {
            return Name + " " + Year;
        }
    }
}
