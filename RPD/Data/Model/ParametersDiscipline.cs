using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    class ParametersDiscipline
    {
        public String Purpose { get; set; }// As String 'Цель дисциплины
        public String Tasks { get; set; }// As String ' Задачи
        public String Dis_before { get; set; }// As String ' предшествующие дисциплины
        public String Dis_after { get; set; }// As String ' последующие дисциплины
        public List<Themes> themes;
        public int CountThemes { get; set; }// ' Колво тем в дисциплине
        public int CountQuestForEx { get; set; }
        public ParametersDiscipline() 
        {
            
        }
    }
}
