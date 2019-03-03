using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    class Literature
    {
        public string LiteraBasicNoNum { get; set; }
        public string LiteraAdditionalNoNum { get; set; }

        public List<String> LiteraBasic;
        public List<String> LiteraAdditional;

        public Literature()
        {
            LiteraBasic = new List<String>();
            LiteraAdditional = new List<String>();
        }
        public Literature(string LiteraBasicNoNum, string LiteraAdditionalNoNum) 
        {
            this.LiteraBasicNoNum = LiteraBasicNoNum;
            this.LiteraAdditionalNoNum = LiteraAdditionalNoNum;
            LiteraBasic = new List<String>();
            LiteraAdditional = new List<String>();
        }
    }
}
