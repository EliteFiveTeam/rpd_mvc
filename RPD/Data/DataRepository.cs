using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPD.Data.Model;
using System.Data.OleDb;

namespace RPD.Data
{
    class DataRepository
    {
        private static DataRepository instance;
        private DatabaseHelper db; 

        public static DataRepository getInstance()
        {
            if (instance == null)
            {
               return instance = new DataRepository();
            }
            else
            {
               return instance;
            }
        }

        private DataRepository()
        {
            instance = this;
            db = new DatabaseHelper();
        }

        public List<EducationalProfile> GetProfileNameAndYear(){
            List<EducationalProfile> list = new List<EducationalProfile>();
            OleDbDataReader reader = db.GetReader("SELECT * FROM Профиль ;");
            while(reader.Read())
            {
                list.Add(new EducationalProfile(reader["Название_профиля"].ToString(), reader["Год_профиля"].ToString()));
            }
            reader.Close();
            return list;
        }

           public List<Discipline> GetDiscipline(EducationalProfile profile){
            List<Discipline> list = new List<Discipline>();
            int id = -1;
            OleDbDataReader reader = db.GetReader("SELECT Профиль.Название_профиля, Профиль.Год_профиля,Профиль.Код FROM Профиль WHERE (((Профиль.Название_профиля)='" + profile.NameProfile + "') AND ((Профиль.Год_профиля)='" + profile.YearProfile + "'));");
            while(reader.Read())
            {
                id = Convert.ToInt32(reader["Код"]);
            }
            reader.Close();
            reader = db.GetReader("SELECT Дисциплины_профиля.Дисциплины, Дисциплины_профиля.Код_профиля FROM Дисциплины_профиля WHERE (((Дисциплины_профиля.Код_профиля)=" + id + "));");
            while(reader.Read()){
                list.Add(new Discipline(reader["Дисциплины"].ToString()));
            }
            reader.Close();
            return list;
        }

    }
}
