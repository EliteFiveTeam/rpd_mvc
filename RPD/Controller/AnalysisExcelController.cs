using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using RPD.Data;
using excel = Microsoft.Office.Interop.Excel; // подключение библиотеки excel и создание псевдонима "Alias"
using RPD.Data.Model;
using RPD.View;
using System.Threading;
using System.Diagnostics;

namespace RPD.Controller
{
    public class AnalysisExcelController
    {
        public const string TITLE_EXCEL_LIST = "титул";
        public const string TITLE_PLAN_LIST = "план";
        public const string EDUCATION_STANDARD = "Образовательный стандарт";
        public const string YEAR_PROFILE = "Год начала";
        public const string NAME_PROFILE = "Направление подготовки";
        public const string ACTIVITIES_PROFILE = "Виды";

        private IAnalysisExcelForm _view; 

        private excel.Application ExcelApp;
        private excel.Worksheet ExcelSheet; // Выбранный лист в excel
        private excel.Sheets Sheets; // Список листов в excel 

        private ProfileEducational profileEd;
        private List<Discipline> disciplines  = new List<Discipline>();
        private Discipline dis; 

        private int totalColumns = 0;
        private int totalRows = 0;
        private int sem = 0;
       

        public AnalysisExcelController(AnalysisExcelForm view)
        {
            _view = view;
            _view.SetController(this);
            initExcelApp();
        }


        private void initExcelApp()
        {
            ExcelApp = new excel.Application(); // создаем объект excel;
            ExcelApp.Visible = false; // показывает или скрывает файл Excel;

            
        }

        public void startAnalize(String filePath)
        {
            if (filePath == null)
            {
                _view.ShowError("Файл не был найден");
                return;
            }
            ExcelApp.Workbooks.Add(filePath);
            Sheets = ExcelApp.Worksheets;
            analysisTitleList();
            analysisPlanList();
        }


        private void CloseProcess()
        {
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();
            }
        }

        private void analysisTitleList()
        {
            profileEd = new ProfileEducational();
            ExcelSheet = getWorksheet(TITLE_EXCEL_LIST);
            var range = SearchWordRange(EDUCATION_STANDARD);
            profileEd.Standart = findStandartOrYear(range);
            range = SearchWordRange(YEAR_PROFILE);
            profileEd.Year = findStandartOrYear(range);
            range  = SearchWordRange(NAME_PROFILE);
            profileEd.Name = getNameProfile(range);
            profileEd.Direction = getDirection(range);
            range = SearchWordRange(ACTIVITIES_PROFILE);
            profileEd.Activities = getActivities(range.Column, range.Row);
            checkProfile();
        }

        private void analysisPlanList()
        {
            ExcelSheet = getWorksheet(TITLE_PLAN_LIST);
            for (int r = 6; r <= totalRows; r++)
            {
                bool isDiscipline = ExcelSheet.Cells[r, 3].Font.Bold != true && ExcelSheet.Cells[r, 1].Text.IndexOf("+") >= 0 || ExcelSheet.Cells[r, 3].Font.Bold != true && ExcelSheet.Cells[r, 1].Text.IndexOf("-") >= 0;
                if (isDiscipline)
                {
                    dis = new Discipline();
                    addDisciplineName(r);
                    for (int c = 4; c <= totalColumns; c++)
                    {
                        string titleName = ExcelSheet.Cells[3, c].Text.Replace(" ", "").Replace(".", "").ToLower();
                        string titleSemestr = ExcelSheet.Cells[2, c].Text.ToLower().Trim();
                        string text = ExcelSheet.Cells[r, c].Text;
                        if (text == null || text == "") continue;
                        addControl(titleName, text);
                        sem = (titleSemestr.IndexOf("сем") >= 0) ? Int32.Parse(titleSemestr.Substring(titleSemestr.Length - 1)) : sem ;
                        if (sem > 0)
                        {
                            addSemestrHours(sem, titleName, text);
                            continue;
                        }
                             
                    }
                    disciplines.Add(dis);
                    var count = disciplines.Count;
                }
            }
            
            CloseProcess();
  
        }



        private void addDisciplineName(int pos)
        {
            dis.Name = ExcelSheet.Cells[pos, 3].Text;
        }

        private void addSemestrHours(int semestr, String title, String text)
        {
            int value; 
            bool succsess = Int32.TryParse(text, out value);
            if (!succsess) return;
            switch (title)
                                {
                                    case "зет":
                                    case "зе":
                                        dis.semesters[semestr].ZET = value;
                                        break;
                                    case "итого":
                                        dis.semesters[semestr].Itogo = value;
                                        break;
                                    case "лек":
                                        dis.semesters[semestr].Lekc = value;
                                        break;
                                    case "лекинтер":
                                        dis.semesters[semestr].LekcInter = value;
                                        break;
                                    case "лаб":
                                        dis.semesters[semestr].Lab = value;
                                        break;
                                    case "лабинтер":
                                        dis.semesters[semestr].LabInter = value;
                                        break;
                                    case "пр":
                                        dis.semesters[semestr].Practice = value;
                                        break;
                                    case "принтер":
                                        dis.semesters[semestr].PractInter = value;
                                        break;
                                    case "элект":
                                    case "элек":
                                        dis.semesters[semestr].Elect = value;
                                        break;
                                    case "ср":
                                        dis.semesters[semestr].SR = value;
                                        break;
                                    case "ик":
                                        dis.semesters[semestr].Ik = value;
                                        break;
                                    case "катт":
                                        dis.semesters[semestr].Katt = value;
                                        break;
                                    case "каттэкз":
                                        dis.semesters[semestr].Kattex = value;
                                        break;
                                    case "кэ":
                                        dis.semesters[semestr].Ke = value;
                                        break;
                                    case "часыконт":
                                    case "контроль":
                                        dis.semesters[semestr].HoursCont = value;
                                        break;
                                    case "часыконтэлектр":
                                    case "контрэлектр":
                                        dis.semesters[semestr].HoursContElect = value;
                                        break;
                                }
           
        }

        private void addControl(String title, String text)
        {
            char[] numberSemestr = text.ToCharArray();
            switch (title)
            {
                case "экзамен":
                    foreach (char sem in numberSemestr)
                    {
                        dis.semesters[Int32.Parse(sem.ToString())].Control = title;
                    }
                    break;
                case "зачет":
                    foreach (char sem in numberSemestr)
                    {
                        dis.semesters[Int32.Parse(sem.ToString())].Control = title;
                    }
                    break;
                case "зачетсоц":
                    foreach (char sem in numberSemestr)
                    {
                        dis.semesters[Int32.Parse(sem.ToString())].Control = title;
                    }
                    break;
                case "кр":
                   foreach (char sem in numberSemestr)
                    {
                        dis.semesters[Int32.Parse(sem.ToString())].KR = true;
                    }
                   break;
            }
        }

        private void addCommonHourDiscipline()
        {

        }
       

        private String findStandartOrYear(excel.Range range)
        {
            var rangeColumn = range.Column;
            while (totalColumns > rangeColumn)
            {
                rangeColumn = ++rangeColumn;
                range = range.Next;
                if (range.get_Value() != null)
                {
                    return range.get_Value().Trim();
                }

            }
            return "";
        }

        private List<String> getActivities(int column, int row)
        {
            List<String> list = new List<string>();
            var rangeRow = row;
            while (totalRows > rangeRow)
            {
                rangeRow = ++rangeRow;
                var value = ExcelSheet.Cells[rangeRow, column - 1].Text;
                if (ExcelSheet.Cells[rangeRow, column - 1].Text.IndexOf("+") >= 0 && ExcelSheet.Cells[rangeRow, column].Text != "")
                {
                    list.Add(ExcelSheet.Cells[rangeRow, column].Text());
                }
                else if (ExcelSheet.Cells[rangeRow, column - 1].Text.IndexOf("-") >= 0)
                {
                    break;
                }
            }
            return list;
        }

        private String getNameProfile(excel.Range range)
        {
            String name = range.get_Value();
            name = name.Replace("Направление подготовки", "").Trim();
            int indexEnd = name.IndexOf("Направленность");
            name = name.Substring(0, indexEnd).Trim();
            return name;
        }

        private String getDirection(excel.Range range)
        {
            String name = range.get_Value();
            int index = name.IndexOf("\"");
            name = name.Substring(name.IndexOf("\"")+1, name.LastIndexOf("\"") - name.IndexOf("\"") - 1).Trim();
            return name;
        }


        private excel.Worksheet getWorksheet(String nameList)
        {
            var worksheet = (excel.Worksheet)Sheets.get_Item(nameList);
           // worksheet.UsedRange.Columns.ClearFormats();
          //  worksheet.UsedRange.Rows.ClearFormats();
            totalColumns = worksheet.UsedRange.Columns.Count;
            totalRows = worksheet.UsedRange.Rows.Count;
            return worksheet;
        }


        private excel.Range SearchWordRange(String findWord)
        {
            return ExcelSheet.Cells.Find(findWord, Type.Missing, excel.XlFindLookIn.xlValues, excel.XlLookAt.xlPart);
        }


        private void checkProfile()
        {
            if (profileEd.Activities != null)
                _view.ShowLogs("Виды деятельности загружены\n", Color.Green);
            else
                _view.ShowLogs("Виды деятельности не найдены\n", Color.Red);
            if (profileEd.Direction != null)
                _view.ShowLogs("Направление подготовки загружен\n", Color.Green);
            else
                _view.ShowLogs("Направление подготовки не найден\n", Color.Red);
            if (profileEd.Standart != null)
                _view.ShowLogs("Стандарт профиля загружен\n", Color.Green);
            else
                _view.ShowLogs("Стандарт профиля не найден\n", Color.Red);
            if (profileEd.Name != null)
                _view.ShowLogs("Профиль загружен\n", Color.Green);
            else
                _view.ShowLogs("Профиль не найден\n", Color.Red);
            if (profileEd.Year != null)
                _view.ShowLogs("Год профиля загружен\n", Color.Green);
            else
                _view.ShowLogs("Год профиля не найден\n", Color.Red);
        }

    }
}
