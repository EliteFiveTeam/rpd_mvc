using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class EducationalProfile
    {
        public String NameProfile { get; set; }
        public String YearProfile { get; set; }

        public EducationalProfile(String nameProfile, String yearProfile)
        {
           NameProfile = nameProfile;
           YearProfile = yearProfile;
        }

        public String GetFullName()
        {
            return NameProfile + " " + YearProfile;
        }
    }
}
