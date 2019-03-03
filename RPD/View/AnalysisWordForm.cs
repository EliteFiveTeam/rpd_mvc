using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPD.Data.Model;
using RPD.Controller;


namespace RPD.View
{
    public partial class AnalysisWordForm : Form, IAnalysisWordForm
    {
        private AnalisysWordController _controller;
        private String _wordFileName = null;

        public AnalysisWordForm()
        {
            InitializeComponent();
            
            //SetController(new AnalisysWordController(this, _wordFileName));    
            
        }

        private void AnalysisWordForm_Load(object sender, EventArgs e)
        {

        }
       
        public void SetController(AnalisysWordController controller)
        {
            _controller = controller;
        }
        
   

        private void btn_OpenWp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileWord = new OpenFileDialog();
            openFileWord.Filter = "Файлы Word(*.doc)|*.doc|Word(*.docx)|*.docx";
            if (openFileWord.ShowDialog() == DialogResult.OK)
            {
                _wordFileName = openFileWord.FileName;
                SetController(new AnalisysWordController(this, _wordFileName));
                _controller.open_new_document();
            }
            if (_wordFileName == null)
            {
                return;
            }

            _controller.get_basicLiterature();
            _controller.get_addLiterature();
            _controller.getPurposeDiscipline();
            _controller.getTasksDiscipline();
            _controller.getKnowledgeBefore();
            _controller.getKnowledgeAfter();
            _controller.getTableWithDisciplines();
            _controller.getUmo();
            _controller.getQuestionsForExam();
            _controller.CloseAnalisysDocument();
            _controller.CloseDocument();

            btn_OpenWp.Enabled = false;
            
            if (btn_OpenWp.Enabled == false)
            {
                btn_Clear.Enabled = true;

            }
            else
            {
                btn_Clear.Enabled = false;
            }
            if (btn_OpenWp.Enabled == false)
            {
                bt_create_newrp.Enabled = true;
            }
            else
            {
                bt_create_newrp.Enabled = false;
            }
            if (btn_OpenWp.Enabled == false)
            {
                Create_Ticket.Enabled = true;
            }
            else
            {
                Create_Ticket.Enabled = false;
            }

        }

        private void bt_create_newrp_Click(object sender, EventArgs e)
        {
            
        }

        private void rtb_LiteraBasic_TextChanged(object sender, EventArgs e)
        {

        }



        public void pasteLiteraBasic()
        {
            rtb_LiteraBasic.Paste();
        }


        public void pasteLiteraAdd()
        {
            rtb_Add_Litera.Paste();
        }

        public void ShowLogs(String text, Color color)
        {
            rtb_Log.AppendText(text, color); 
        }



        public void pasteUMO()
        {
            rtb_Tems.Paste();
        }


        public void pasteForExam()
        {
            rtb_ForExam.Paste();
        }

        private void Create_Ticket_Click(object sender, EventArgs e)
        {
            _controller.Ticket_For_Exam();
            _controller.CloseDocument();
            Create_Ticket.Enabled = false;
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearWordForm();
            btn_Clear.Enabled = false;
            if (btn_Clear.Enabled == false)
            {
                Create_Ticket.Enabled = false;
                bt_create_newrp.Enabled = false;
            }
        }


        public void ClearWordForm()
        {

            Clipboard.Clear();
            rtb_Log.Clear();
            rtb_LiteraBasic.Clear();
            rtb_Add_Litera.Clear();
            rtb_ForExam.Clear();
            rtb_Tems.Clear();

            btn_OpenWp.Enabled = true;
        }
    }
}
