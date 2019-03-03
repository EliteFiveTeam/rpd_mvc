using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class Knowledge
    {
        public string Knowledge_before{ get; set; }// 'Знания до
        public string Knowledge_after{ get; set; }// 'Знания после
        public string Skills_before { get; set; }// 'Умения до
        public string Skills_after { get; set; }//'Знания после
        public string Own_before { get; set; }// 'Знания до
        public string Own_after { get; set; }// 'Знания после
    }
}
