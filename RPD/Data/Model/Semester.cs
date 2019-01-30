using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPD.Data.Model
{
    class Semester
    {
        /* Хранение данных в семестрах */
        public int[] ZET; // № семестр | ЗЕТ
        public void _ZET(int Var, int Val)
        {
            ZET[Var - 1] = Val;
        }
        public int[] Itogo; // № семестр | Итого
        public void _Itogo(int Var, int Val)
        {
            Itogo[Var - 1] = Val;
        }
        public int[] ik; // № семестр | ИК
        public void _ik(int Var, int Val)
        {
            ik[Var - 1] = Val;
        }
        public int[] katt; // № семестр | КаТТ
        public void _katt(int Var, int Val)
        {
            katt[Var - 1] = Val;
        }
        public int[] kattex; // № семестр | КаТТ Экзамен
        public void _kattex(int Var, int Val)
        {
            kattex[Var - 1] = Val;
        }
        public int[] ke; // № семестр | КЕ
        public void _ke(int Var, int Val)
        {
            ke[Var - 1] = Val;
        }
        public int[] Lekc; // № семестр | Лекции
        public void _Lekc(int Var, int Val)
        {
            Lekc[Var - 1] = Val;
        }
        public int[] LekcInter; // № семестр | Интеракт лекции
        public void _LekcInter(int Var, int Val)
        {
            LekcInter[Var - 1] = Val;
        }
        public int[] Lab; // № семестр | Лаборот
        public void _Lab(int Var, int Val)
        {
            Lab[Var - 1] = Val;
        }
        public int[] LabInter; // № семестр | Интеракт лаборот
        public void _LabInter(int Var, int Val)
        {
            LabInter[Var - 1] = Val;
        }
        public int[] Practice; // № семестр | Практика
        public void _Practice(int Var, int Val)
        {
            Practice[Var - 1] = Val;
        }
        public int[] PractInter; // № семестр | Интеракт практика
        public void _PractInter(int Var, int Val)
        {
            PractInter[Var - 1] = Val;
        }
        public int[] Elect; // № семестр | Электив
        public void _Elect(int Var, int Val)
        {
            Elect[Var - 1] = Val;
        }
        public int[] _SR; // № семестр | СР
        public void _SR1(int Var, int Val)
        {
            //SR = SR + Val; // общее количество часов СР когда семестров больше одного
            _SR[Var - 1] = Val;
        }
        public int[] HoursCont; // № семестр | Контакт часы
        public void _HoursCont(int Var, int Val)
        {
            HoursCont[Var - 1] = Val;
        }
        public int[] HoursContElect; // № семестр | Элект контакт часы
        public void _HoursContElect(int Var, int Val)
        {
            HoursContElect[Var - 1] = Val;
        }
        public int[] InterHousInSem; // № семестр | Количество интер часов 
        public void _InterHousInSem()
        {
            for (int zx = 0; zx <= LabInter.Length - 1; zx++)
            {
                int Jeff = PractInter[zx] + LekcInter[zx] + LabInter[zx];
                InterHousInSem[zx] = Jeff;
            }
        }
        /* ФОРМА КОНТРОЛЯ */
        public bool[] Examen; // Форм. контр | Экзамен
        public bool[] Zachet; // Форм. контр | Зачет
        public bool[] Dif_Zachet; // Форм. контр | Диф зачет
        public int KR; // Форм. контр | Курс раб

        public void _Examen(int Var)
        {

            Examen[Var - 1] = true;
        } // add to array
        public void _Zachet(int Var)
        {

            Zachet[Var - 1] = true;
        } // add to array
        public void _Dif_Zachet(int Var)
        {

            Dif_Zachet[Var - 1] = true;
        } // add to array
    }
}
