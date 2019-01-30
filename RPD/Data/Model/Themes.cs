using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class Themes
    {
        public String Name{ get; set; }// ' Название темы
        public String Contents { get; set; } // ' Содержание темы
        public String Result { get; set; }// As String ' Результат темы
        public String Competences { get; set; }// As String ' Компетенции, развиваемые темой
        public String FormStudies { get; set; }// As String ' Формы занятий
       
    }
}
