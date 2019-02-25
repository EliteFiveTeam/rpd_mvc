using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class Discipline
    {
        public String Name { get; set; }
        public String Index { get; set; } // Индекс предмета 
        public int Fact { get; set; } // Факт по ЗЕТ  *36 = кол во часов
        public int AtPlan { get; set; } // По плану 
        public int ContactHours { get; set; } // Контакт часы 
        public int Aud { get; set; } // Ауд.
        public int SR { get; set; } // СР
        public int IK { get; set; } // ИК
        public int KaTT { get; set; } // KaTT
        public int KE { get; set; } // КЭ
        public int KattEx { get; set; } // Каттэкз
        public int Contr { get; set; } // Контроль
        public int ElectHours { get; set; } // Элект часы
        public int InterHours { get; set; } // Интер часы
        public int StartDis; // Начало дисциплины
        public int EndDis; // Конец дисциплины
        public string Kafedra; // Наименование кафедры
        public Dictionary<int, Semester> semesters;
        public List<Competences> competences;

        public Discipline()
        {
            semesters = new Dictionary<int, Semester>
            {
                {1, new Semester()},
                {2, new Semester()},
                {3, new Semester()},
                {4, new Semester()},
                {5, new Semester()},
                {6, new Semester()},
                {7, new Semester()},
                {8, new Semester()},
                {9, new Semester()},
                {10, new Semester()},
            };
            
        }

        public Discipline(String name)
        {
            Name = name;
        }
    }
}
