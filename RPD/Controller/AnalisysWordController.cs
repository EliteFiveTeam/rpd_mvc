using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPD.Data;
using RPD.Data.Model;
using RPD.View;
using System.Drawing;
using System.Diagnostics;
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;

namespace RPD.Controller
{
    public class AnalisysWordController
    {
        private IAnalysisWordForm _view;
        private word.Application WordApp;
        private String _wordFileName = null;
        private word.Range range;
        private word.ListParagraphs paragraphs;
        private Literature literature;
        private ParametersDiscipline parametersDiscipline;
        private List<Themes> themes = new List<Themes>();
        private Themes theme;
        private Discipline discipline;
        private ProfileEducational profileEducation;
        private Knowledge knowledge;

        private char[] signs = { '\f', '\n', '\r', '\t', '\v', '\0', ' ', '2', '3', '.', ')', ';' };

        private string variableforsearch;
        private int countchar;

        private string basic_litera_word;

        public String Basic_litera_word
        {
            get
            {
                return basic_litera_word;
            }
            set
            {
                range = WordApp.ActiveDocument.Range();
                if (range.Find.Execute(range.Find.Text = "Основная литература:"))
                {
                    basic_litera_word = "Основная литература:";
                }
                else if (range.Find.Execute(range.Find.Text = "Основная литература"))
                {
                    basic_litera_word = "Основная литература";
                }
            }
        }
        private string additional_litera_word;
        public String Additional_litera_word
        {
            get
            {
                return additional_litera_word;
            }
            set
            {
                range = WordApp.ActiveDocument.Range();
                if (range.Find.Execute(range.Find.Text = "Дополнительная литература:"))
                {
                    additional_litera_word = "Дополнительная литература:";
                }
                else if (range.Find.Execute(range.Find.Text = "Дополнительная литература"))
                {
                    additional_litera_word = "Дополнительная литература";
                }
            }
        }

        private string last_litera_word;
        public String Last_litera_word
        {
            get { return last_litera_word; }
            set { last_litera_word = "Перечень "; }
        }

        private string boldWordFlag;

        private string basic_range_word;
        private string add_range_word;


        public AnalisysWordController(IAnalysisWordForm view, String wordFileName)
        {
            _view = view;
            _wordFileName = wordFileName;
            WordApp = new word.Application(_wordFileName);
            WordApp.Visible = true;




        }
        public string SearchText(string wordText1, string wordText2, int numberof) // Поиск между двумя фрагментами - метод поиска 
        {
            Microsoft.Office.Interop.Word.Range range;//Range
            string st = "";
            // для чего? r = WordApp.ActiveDocument.Range(WordApp.ActiveDocument.TablesOfContents[1].Range.End, WordApp.ActiveDocument.Range().End);// попытка обойти содержание (tableofcontent - содержание)
            range = WordApp.ActiveDocument.Range();

            bool f = false;
            int firstOccurence = 0;
            int CountKFind = 0;

            range.Find.ClearFormatting(); //Сброс форматирований из предыдущих операций поиска
            range.Find.Text = wordText1 + "*" + wordText2;

            while (range.Find.Execute(Forward: true, Wrap: word.WdFindWrap.wdFindContinue, Format: false, MatchCase: false, MatchWholeWord: false, MatchAllWordForms: false, MatchSoundsLike: false, MatchWildcards: true) == true) // Проверка поиска, если нашёл фрагменты, то...
            {
                CountKFind = CountKFind + 1;// то счётчик найденных фрагментоd увеличивается на 1
                if (f)
                {
                    if (range.Start == firstOccurence)
                    { }
                    else
                    {
                        firstOccurence = range.Start;
                        f = true;
                    }
                }
                st = WordApp.ActiveDocument.Range(range.Start + wordText1.Length, range.End - wordText2.Length).Text; //убираем кл.
                range.Start = range.Start + wordText1.Length;
                range.End = range.End - wordText2.Length;
                if (CountKFind >= numberof) // если нужный по счету фрагмент найден
                {
                    // r = WordApp.ActiveDocument.Range(r.Start, r.End);
                    break;
                }
            }

            CountKFind = 0;

            if (range.Text != "")
            {
                if (st != "")
                {
                    range.Copy();
                }
                else //' если текст не найден очистим буфер обмена
                {
                    Clipboard.Clear();
                }
            }
            else
            {
                {
                    Clipboard.Clear();
                }
            }

            return st;
        }
        public void open_new_document()
        {
            WordApp.Documents.Open(_wordFileName, ReadOnly: true);
        }



        public void get_basicLiterature()
        {
            literature = new Literature();
            range = WordApp.ActiveDocument.Range();
            paragraphs = WordApp.ActiveDocument.ListParagraphs;
            Basic_litera_word = "Основная литература";
            Additional_litera_word = "Дополнительная литература";

            range.Find.Text = basic_litera_word + "*" + additional_litera_word;
            range.Find.Forward = true;
            range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
            range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ

            if (range.Find.Execute(range.Find.Text, false))// Проверка поиска, если нашёл фрагменты, то...
            {
                basic_range_word = WordApp.ActiveDocument.Range(range.Start + basic_litera_word.Length, range.End - additional_litera_word.Length).Text; //убираем кл.
                range.Start = range.Start + basic_litera_word.Length;

                for (int k = 2; k <= range.Paragraphs.Count; k++)
                {
                    if (range.Paragraphs[k].Range.Bold < 0)
                    {

                        boldWordFlag = range.Paragraphs[k].Range.Text;
                        if (boldWordFlag.Length > 2) { break; }

                    }
                }
                range.End = range.End - boldWordFlag.Length;
                basic_range_word = WordApp.ActiveDocument.Range(range.Start + basic_litera_word.Length, range.End - boldWordFlag.Length).Text;
                range.Find.Text = basic_litera_word + "*" + boldWordFlag;
                literature.LiteraBasicNoNum = SearchText(basic_litera_word, boldWordFlag, 1);
                if (literature.LiteraBasicNoNum != "")
                {
                    _view.pasteLiteraBasic();
                    _view.ShowLogs("Основная литература считана\n", Color.Green);
                }
                else if (literature.LiteraBasicNoNum == "")
                {
                    int count_ListParagraphs = range.ListParagraphs.Count;
                    if (count_ListParagraphs != 0)
                    {
                        object Start = range.ListParagraphs[1].Range.Start;
                        object End = range.ListParagraphs[count_ListParagraphs].Range.End;
                        word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                        myRange.Copy();
                        _view.pasteLiteraBasic();
                        for (int y = 1; y <= range.ListParagraphs.Count; y++)
                        {
                            string _paragraph = range.ListParagraphs[y].Range.Text;
                            literature.LiteraBasic.Add(_paragraph);
                        }
                        _view.ShowLogs("Основная литература считана\n", Color.Green);


                    }
                }
                else
                {
                    _view.ShowLogs("Основная литература не найдена\n", Color.Red);


                }

            }

        }
        public void get_addLiterature()
        {


            range = WordApp.ActiveDocument.Range();
            paragraphs = WordApp.ActiveDocument.ListParagraphs;
            Additional_litera_word = "Дополнительная литература";
            Last_litera_word = "Перечень ";

            range.Find.Text = additional_litera_word + "*" + last_litera_word;
            range.Find.Forward = true;
            range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
            range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ

            if (range.Find.Execute(range.Find.Text, false))// Проверка поиска, если нашёл фрагменты, то...
            {
                add_range_word = WordApp.ActiveDocument.Range(range.Start + additional_litera_word.Length, range.End - last_litera_word.Length).Text; //убираем кл.
                range.Start = range.Start + additional_litera_word.Length;

                for (int k = 2; k <= range.Paragraphs.Count; k++)
                {
                    if (range.Paragraphs[k].Range.Bold < 0)
                    {

                        boldWordFlag = range.Paragraphs[k].Range.Text;
                        if (boldWordFlag.Length > 2) { break; }

                    }
                }
                range.End = range.End - boldWordFlag.Length;
                basic_range_word = WordApp.ActiveDocument.Range(range.Start + additional_litera_word.Length, range.End - boldWordFlag.Length).Text;
                range.Find.Text = additional_litera_word + "*" + boldWordFlag;
                literature.LiteraAdditionalNoNum = SearchText(additional_litera_word, boldWordFlag, 1);
                if (literature.LiteraAdditionalNoNum != "")
                {
                    _view.pasteLiteraAdd();
                    _view.ShowLogs("Дополнительная литература считана\n", Color.Green);
                }
                else if (literature.LiteraAdditionalNoNum == "")
                {
                    int count_ListParagraphs = range.ListParagraphs.Count;
                    if (count_ListParagraphs != 0)
                    {
                        object Start = range.ListParagraphs[1].Range.Start;
                        object End = range.ListParagraphs[count_ListParagraphs].Range.End;
                        word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                        myRange.Copy();
                        _view.pasteLiteraAdd();
                        for (int y = 1; y <= range.ListParagraphs.Count; y++)
                        {
                            string _paragraph = range.ListParagraphs[y].Range.Text;
                            literature.LiteraAdditional.Add(_paragraph);

                        }
                        _view.ShowLogs("Дополнительная литература считана\n", Color.Green);


                    }
                }
                else
                {
                    _view.ShowLogs("Дополнительная литература не найдена\n", Color.Red);


                }

            }

        }

        public void getPurposeDiscipline()
        {
            parametersDiscipline = new ParametersDiscipline();
            variableforsearch = SearchText("явля?????", "Учебные задачи дисциплины", 2);
            if (variableforsearch == null) //' Если цели не попали в оглавление
            {
                variableforsearch = SearchText("явля?????", "Учебные задачи дисциплины", 1); // искомый текст после оглавления
                if (variableforsearch == null)
                {
                    _view.ShowLogs("Цели дисциплины не найдены\n", Color.Red);
                }

            }
            else
            {

                _view.ShowLogs("Цели дисциплины найдены\n", Color.Green);

                variableforsearch = variableforsearch.TrimEnd(signs);
                countchar = variableforsearch.IndexOf("явля");
                if (countchar > 0 && countchar < variableforsearch.Length - 9)
                {
                    parametersDiscipline.Purpose = variableforsearch.Remove(1, countchar + 9);
                }
                else
                {
                    parametersDiscipline.Purpose = variableforsearch;
                }
            }
        }

        public void getTasksDiscipline()
        {
            parametersDiscipline = new ParametersDiscipline();
            variableforsearch = SearchText("Учебные задачи дисциплины", "Место дисциплины", 2);
            if (variableforsearch == null)// ' Если задачи не попали в оглавление
            {
                variableforsearch = SearchText("Учебные задачи дисциплины", "Место дисциплины", 1);
                if (variableforsearch == null)
                {
                    _view.ShowLogs("Задачи дисциплины не найдены\n", Color.Red);
                }

            }
            else
            {

                _view.ShowLogs("Задачи дисциплины найдены\n", Color.Green);

                variableforsearch = variableforsearch.TrimEnd(signs);
                countchar = variableforsearch.IndexOf("явля");


                if (countchar > 0 && countchar < variableforsearch.Length - 9)
                {

                    parametersDiscipline.Tasks = variableforsearch.Remove(1, countchar + 9);

                }

                else
                {

                    parametersDiscipline.Tasks = variableforsearch; // записали цели

                }
            }
        }

        public void getKnowledgeBefore()
        {
            knowledge = new Knowledge();
            variableforsearch = SearchText("Знать:", "Уметь:", 1);
            knowledge.Knowledge_before = variableforsearch.TrimEnd(signs);
            variableforsearch = SearchText("Уметь:", "Владеть:", 1);
            knowledge.Skills_before = variableforsearch.TrimEnd(signs);
            variableforsearch = SearchText("Владеть:", ".", 1);
            knowledge.Own_before = variableforsearch.TrimEnd(signs);
            if (variableforsearch == null)
            {
                _view.ShowLogs("Знания, умения, навыки до не найдены\n", Color.Red);
            }
        }
        public void getKnowledgeAfter() 
        {
            knowledge = new Knowledge();
            variableforsearch = SearchText("Знать:", "Уметь:", 2);
            knowledge.Knowledge_after = variableforsearch.TrimEnd(signs);
            variableforsearch = SearchText("Уметь:", "Владеть:", 2);
            knowledge.Skills_after = variableforsearch.TrimEnd(signs);
            variableforsearch = SearchText("Владеть:", ".", 2);
            knowledge.Own_after = variableforsearch.TrimEnd(signs);
            if (variableforsearch == null)
            {
                _view.ShowLogs("Знания, умения, навыки после не найдены\n", Color.Red);
            }
        }


        public void getTableWithDisciplines()
        {
            
            byte razd = 1;  //'номер раздела
            int CountTems = 0;
            range.Find.Text = "Наименование";
            string texttable = range.Find.Text;
            if (WordApp.ActiveDocument.Tables.Count != 0)
            {
                try
                {
                    for (int i = 1; i <= WordApp.ActiveDocument.Tables.Count; i++)
                    {
                       
                        if (WordApp.ActiveDocument.Tables[i].Cell(1, 2).Range.Find.Execute(texttable))
                        {

                            int k = 0; // счетчик кол-во тем
                            //Action Progress = () => { rtb_Log.AppendText("Таблица с темами дисциплины считана\n", Color.Green); }; Invoke(Progress);
                            for (int n = 2; n <= WordApp.ActiveDocument.Tables[i].Rows.Count; n++)
                            { 
                                theme = new Themes();

                                if (WordApp.ActiveDocument.Tables[i].Rows[n].Cells.Count >= 5)
                                {
                                    if (WordApp.ActiveDocument.Tables[i].Rows[n].Cells[2].Range.Text.Length > 3) // проверка пустых значений названий тем
                                    {
                                         
                                        theme.Name  = WordApp.ActiveDocument.Tables[i].Cell(n, 2).Range.Text;
                                        theme.Contents = WordApp.ActiveDocument.Tables[i].Cell(n, 3).Range.Text;
                                        theme.Result = WordApp.ActiveDocument.Tables[i].Cell(n, 5).Range.Text;
                                        theme.FormStudies = WordApp.ActiveDocument.Tables[i].Cell(n, 6).Range.Text;
                                        CountTems++;
                                        k++; // кол-во тем
                                    }
                                }
                                themes.Add(theme);

                            }
                            break;
                        }
                        else
                        {
                            //Action Progress = () => { rtb_Log.AppendText("Таблица с темами дисциплины не найдена\n", Color.Red); }; Invoke(Progress);
                            if (i != 2)
                            {
                                razd += razd;  //' счетчик разделов срабатывает если их больше одного
                            }
                        }
                    }
                }
                catch { /*Action Progress = () => { rtb_Log.AppendText("Таблица с темами дисциплины не найдена\n", Color.Red); }; Invoke(Progress);*/ }

                parametersDiscipline.CountThemes = CountTems; //Записали количество тем в дисциплине
            }
            else
            {
                //Action Progress = () => { rtb_Log.AppendText("Таблица с темами дисциплины не найдена\n", Color.Red); }; Invoke(Progress);
            }

            Clipboard.Clear();

        }
        public void getUmo() 
        {
            variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "III. ОБРАЗОВАТЕЛЬНЫЕ ТЕХНОЛОГИИ", 2);
            if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
            {

                _view.pasteUMO();
                _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
            }
            else
            {
                variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "III. ОБРАЗОВАТЕЛЬНЫЕ ТЕХНОЛОГИИ", 1);
                if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
                {
                    _view.pasteUMO();
                    _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                }
                else
                {
                    variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "Рекомендуемые обучающие", 2);

                    if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
                    {
                        _view.pasteUMO();
                        _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                    }
                    else
                    {
                        variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "Рекомендуемые обучающие", 1);
                        if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
                        {
                            _view.pasteUMO();
                            _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                        }
                        else
                        {
                            variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "Материально-техническое обеспечение дисциплины", 2);
                            if (variableforsearch.Contains("Тема") && variableforsearch.Contains("Вопросы для самопроверки"))
                            {
                                _view.pasteUMO();
                                _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                            }
                            else
                            {
                                variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "Материально-техническое обеспечение дисциплины", 1);
                                if (variableforsearch.Contains("Тема") && variableforsearch.Contains("Вопросы для самопроверки"))
                                {
                                    _view.pasteUMO();
                                    _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                                }
                                else
                                {
                                    variableforsearch = SearchText("Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "Перечень материально-технической базы", 2);
                                    if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
                                    {
                                        _view.pasteUMO();
                                        _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                                    }
                                    else
                                    {
                                        variableforsearch = SearchText("5.4. Перечень учебно-методического обеспечения для самостоятельной работы обучающихся по дисциплине", "5.5. Перечень материально-технической базы", 1);
                                        if (variableforsearch.Contains("Тема 1.") & variableforsearch.Contains("Литература") & variableforsearch.Contains("Вопросы для самопроверки"))
                                        {
                                            _view.pasteUMO();
                                            _view.ShowLogs("Перечень УМО считаны\n", Color.Green);
                                        }
                                        else
                                        {
                                            _view.ShowLogs("Перечень УМО не считаны\n", Color.Red);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void getQuestionsForExam() 
        {
            
            //Поиск вопросов к экзамену/зачёту с учётом итогового контроля
            string keywordone = "Вопросы к";
            string keywordtwo = "VII.  МЕТОДИЧЕСКИЕ УКАЗАНИЯ";
            string keywordthree = "Итоговый контроль";
            string keywordfour = "Примеры тестов для контроля знаний";
            string newrange;

            // корректировка ключевых слов, ибо люди в каждой рп пишут по разному 
            if (range.Find.Execute(range.Find.Text = "Примеры тестов для контроля знаний:")) keywordfour = "Примеры тестов для контроля знаний:";

            range = WordApp.ActiveDocument.Range();

            if (range.Find.Execute(range.Find.Text = "VII. МЕТОДИЧЕСКИЕ УКАЗАНИЯ")) keywordtwo = "VII. МЕТОДИЧЕСКИЕ УКАЗАНИЯ";

            range = WordApp.ActiveDocument.Range();

            if (range.Find.Execute(range.Find.Text = "Вопросы к экзамену")) keywordone = "Вопросы к экзамену";
            else keywordone = "Вопросы к зачёту";

            range = WordApp.ActiveDocument.Range();

            variableforsearch = SearchText(keywordone, keywordfour, 1);
            if (variableforsearch != "")
            {
                // Поиск 
                range.Find.Text = keywordone + "*" + keywordfour;
                range.Find.Forward = true;
                string exf1 = range.Find.Text;
                range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
                range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ

                if (range.Find.Execute(exf1))// Проверка поиска, если нашёл фрагменты, то...
                {
                    newrange = WordApp.ActiveDocument.Range(range.Start + keywordone.Length, range.End - keywordfour.Length).Text; //убираем кл.
                    range.Start = range.Start + keywordone.Length;
                    range.End = range.End - keywordfour.Length;
                    int countquestion = range.Paragraphs.Count;
                    parametersDiscipline.CountQuestForEx = countquestion;
                    if (countquestion != 0)
                    {
                        parametersDiscipline.CountQuestForEx = countquestion;
                        if (countquestion != 0)
                        {
                            object Start = range.Paragraphs[1].Range.Start;
                            object End = range.Paragraphs[countquestion].Range.End;
                            word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                            myRange.Copy();
                            _view.pasteForExam();
                            _view.ShowLogs("Вопросы к экзамену/зачёту считаны\n", Color.Green);
                            for (int y = 1; y <= range.Paragraphs.Count; y++)
                            {
                                string onequestion = range.Paragraphs[y].Range.Text;
                                parametersDiscipline.questionforexam.Add(onequestion);
                            }
                        }


                    }

                }
            }
            variableforsearch = SearchText(keywordone, keywordthree, 1);

            if (variableforsearch != "")
            {
                // Поиск 
                range.Find.Text = keywordone + "*" + keywordthree;
                range.Find.Forward = true;
                string exf1 = range.Find.Text;
                range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
                range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ

                if (range.Find.Execute(exf1))// Проверка поиска, если нашёл фрагменты, то...
                {
                    newrange = WordApp.ActiveDocument.Range(range.Start + keywordone.Length, range.End - keywordthree.Length).Text; //убираем кл.
                    range.Start = range.Start + keywordone.Length;
                    range.End = range.End - keywordthree.Length;
                    int countquestion = range.Paragraphs.Count;
                    parametersDiscipline.CountQuestForEx = countquestion;
                    if (countquestion != 0)
                    {
                        object Start = range.Paragraphs[1].Range.Start;
                        object End = range.Paragraphs[countquestion].Range.End;
                        word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                        myRange.Copy();
                        _view.pasteForExam();
                        _view.ShowLogs("Вопросы к экзамену/зачёту считаны\n", Color.Green);
                        for (int y = 1; y <= range.ListParagraphs.Count; y++)
                        {
                            string onequestion = range.ListParagraphs[y].Range.Text;
                            parametersDiscipline.questionforexam.Add(onequestion);
                        }
                    }

                }
            }
            else
            {
                range.Find.Text = keywordone + "*" + keywordtwo;
                range.Find.Forward = true;
                string exf1 = range.Find.Text;
                range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
                range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ
                variableforsearch = SearchText(keywordone, keywordtwo, 1);
                if (variableforsearch == "")
                {
                    _view.ShowLogs("Вопросы для зачёта/экзамена не найдены\n", Color.Red);
                }
                if (range.Find.Execute(exf1))// Проверка поиска, если нашёл фрагменты, то...
                {
                    newrange = WordApp.ActiveDocument.Range(range.Start + keywordone.Length, range.End - keywordtwo.Length).Text; //убираем кл.
                    range.Start = range.Start + keywordone.Length;
                    range.End = range.End - keywordtwo.Length;
                    int countquestion = range.Paragraphs.Count;
                    parametersDiscipline.CountQuestForEx = countquestion;
                    if (countquestion != 0)
                    {
                        object Start = range.Paragraphs[1].Range.Start;
                        object End = range.Paragraphs[countquestion].Range.End;
                        word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                        myRange.Copy();
                        _view.pasteForExam();
                        _view.ShowLogs("Вопросы к экзамену/зачёту считаны\n", Color.Green);
                        for (int y = 1; y <= range.ListParagraphs.Count; y++)
                        {
                            string onequestion = range.ListParagraphs[y].Range.Text;
                            parametersDiscipline.questionforexam.Add(onequestion);
                        }
                    }
                    else
                    {
                        _view.ShowLogs("Некоррекнтый список вопросов к экзамену/зачёту\n", Color.Red);
                    }
                }
            }

            variableforsearch = SearchText(keywordthree, keywordtwo, 1);
            if (variableforsearch != "")
            {
                // Поиск 
                range.Find.Text = keywordthree + "*" + keywordtwo;
                range.Find.Forward = true;
                string exf1 = range.Find.Text;
                range.Find.Wrap = word.WdFindWrap.wdFindContinue; //при достижении конца документа поиск будет продолжаться с начала пока не будет достигнуто положение начала поиска
                range.Find.MatchWildcards = true;//подстановочные знаки ВКЛ

                if (range.Find.Execute(exf1))// Проверка поиска, если нашёл фрагменты, то...
                {
                    newrange = WordApp.ActiveDocument.Range(range.Start, range.End - keywordtwo.Length).Text; //убираем кл.
                    range.Start = range.Start;
                    range.End = range.End - keywordtwo.Length;
                    int countquestion = range.Paragraphs.Count;
                    if (countquestion != 0)
                    {
                        object Start = range.Paragraphs[1].Range.Start;
                        object End = range.Paragraphs[countquestion].Range.End;
                        word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
                        myRange.Copy();
                        _view.pasteForExam();
                        _view.ShowLogs("Итоговый контроль найден\n", Color.Green);
                    }
                }
            }
            else if (SearchText("Примеры тестов для контроля знаний:", "VII.  МЕТОДИЧЕСКИЕ УКАЗАНИЯ", 1) != "")
            {
                _view.pasteForExam();
            }
            else
            {
                _view.ShowLogs("Итоговый контроль не найден\n", Color.Red);
            }

        }
        public void ReplBookmark(string NameBookMark, ref RichTextBox rt, ref Microsoft.Office.Interop.Word.Application Word) // Замена закладки форматированным текстом из richtextbox-a
        {
            System.Drawing.Font cfont;
            rt.SelectAll();
            cfont = rt.SelectionFont;
            rt.Copy();
            Word.Selection.Find.ClearFormatting();
            Word.Selection.Find.Text = NameBookMark;
            Word.Selection.Find.Execute();
            Word.Selection.Font.Name = "Times New Roman";
            if (Clipboard.GetText() != "")
            {
                Word.Selection.Paste();
            }

            //' возвращаем курсор в начало документа
            Word.Selection.Range.Start = 1;
            Word.Selection.Range.End = 1;
        }
        public void FindReplace(string str_old, string str_new) // Замена фрагментов текста длинными кусками(больше 246 символ)
        {
            Microsoft.Office.Interop.Word.Range r;//Range
            r = WordApp.ActiveDocument.Range();
            r.Find.Text = str_old; // Находим слово которое нужно заменить
            if (str_new.Length > 246) // Проверка если длинна слова больше 246 символов 
            {
                string Str_long = str_new; // новая переменная для работы с кусками текста
                while (Str_long.Length > 0) // разьбиение строки на фрагменты и добавление в НРП
                {
                    if (Str_long.Length > 246)
                    {
                        r.Find.Replacement.Text = Str_long.Substring(0, 245) + "<Text>";
                        Str_long = Str_long.Substring(245, Str_long.Length - 245);
                        r.Find.Execute(r.Find.Text, Replace: word.WdReplace.wdReplaceAll);
                        r.Find.Text = "<Text>"; // хештег для поиска замены
                    }
                    else // если осталось меньше 246, добавляем последний кусок текста
                    {
                        r.Find.Replacement.Text = Str_long.Substring(0, Str_long.Length);
                        r.Find.Execute(r.Find.Text, Replace: word.WdReplace.wdReplaceAll);
                        break;
                    }
                }
            }
            else
            {
                r.Find.Replacement.Text = str_new;
                r.Find.Execute(r.Find.Text, Replace: word.WdReplace.wdReplaceAll);
            }

        }

        public void Ticket_For_Exam()
        {
            int c = 0;
            WordApp = new word.Application();
            WordApp.Visible = false;
            var Doc = WordApp.Documents.Add(Application.StartupPath + "/Билет_образец_спец.rtf");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            object fileName = path + "/Билет_образец_спец(Новый).rtf";
            Doc.SaveAs(ref fileName);

            Microsoft.Office.Interop.Word.Range range;
            range = WordApp.ActiveDocument.Range();

            int CountTickets = parametersDiscipline.CountQuestForEx;
            if (CountTickets % 2 != 0)
            {
                CountTickets = CountTickets + 1;
                CountTickets = parametersDiscipline.CountQuestForEx / 2;
            }
            else
            {
                CountTickets = parametersDiscipline.CountQuestForEx / 2;
            }



            int m1 = parametersDiscipline.questionforexam.Count;
            int[] NumberT = new int[CountTickets];

            int m21 = range.Paragraphs.Count;
            object Start = range.Paragraphs[1].Range.Start;
            object End = range.Paragraphs[m21].Range.End;
            word.Range myRange = WordApp.ActiveDocument.Range(Start, End);
            myRange.Copy();

            if (range.Find.Execute(range.Find.Text = "БИЛЕТ № 1"))
            {
                FindReplace("БИЛЕТ № 1", "БИЛЕТ № n");
            }
            for (int i = 1; i <= CountTickets; i++)
            {
                //NumberT[i] = new int [2];
                FindReplace("БИЛЕТ № n", "БИЛЕТ № " + i);
                FindReplace("#Дисциплина", discipline.Name);
                FindReplace("#Направление", profileEducation.Direction);
                if (c <= m1)
                {
                    FindReplace("#Вопрос1", parametersDiscipline.questionforexam[c]);
                    FindReplace("#Вопрос2", parametersDiscipline.questionforexam[c + 1]);

                }
                c = c + 2;
                myRange.Start = myRange.End;
                myRange.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
                myRange.Paste();
            }

            MessageBox.Show("Билеты на рабочем столе");
            Doc.SaveAs(ref fileName);
            CloseProcess();




        }

        public void CloseAnalisysDocument() { range.Application.ActiveDocument.Close(word.WdSaveOptions.wdDoNotSaveChanges); }

        public void CloseProcess()
        {
            Process[] List;
            List = Process.GetProcessesByName("WORD");
            foreach (Process proc in List)
            {
                proc.Kill();
            }
        }
        public void CloseDocument() 
        { 
            WordApp.Quit(); 
        }
    }

}
