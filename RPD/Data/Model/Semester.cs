using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    public class Semester
    {
        public int ZET { get; set; }
        public int Itogo { get; set; } // № семестр | Итого
        public int Ik { get; set; } // № семестр | ИК
        public int Katt { get; set; } // № семестр | КаТТ
        public int Kattex { get; set; } // № семестр | КаТТ Экзамен
        public int Ke { get; set; } // № семестр | КЕ
        public int Lekc { get; set; } // № семестр | Лекции
        public int LekcInter { get; set; } // № семестр | Интеракт лекции
        public int Lab { get; set; } // № семестр | Лаборот
        public int LabInter { get; set; } // № семестр | Интеракт лаборот
        public int Practice { get; set; } // № семестр | Практик
        public int PractInter { get; set; } // № семестр | Интеракт практика
        public int Elect { get; set; } // № семестр | Электи
        public int SR { get; set; } // № семестр | СР
        public int HoursCont { get; set; } // № семестр | Контакт часы
        public int HoursContElect { get; set; } // № семестр | Элект контакт час  
        public int InterHousInSem { get; set; } // № семестр | Количество интер часов 

        /* public void _InterHousInSem()
        {
            for (int zx = 0; zx <= LabInter.Length - 1; zx++)
            {
                int Jeff = PractInter[zx] + LekcInter[zx] + LabInter[zx];
                InterHousInSem[zx] = Jeff;
            }
        } */


        /* ФОРМА КОНТРОЛЯ */
        private String control;
        public String Control
        {
            get
            {
                return control;
            }

            set
            {
                switch (value)
                {
                    case "экзамен":
                        control = "Экзамен";
                        break;
                    case "зачет":
                        control = "Зачет";
                        break;
                    case "зачетсоц":
                        control = "Зачет с оценкой";
                        break;
                }
            }
        }
        public bool KR { get; set; } // Форм. контр | Курс раб
    }
}
