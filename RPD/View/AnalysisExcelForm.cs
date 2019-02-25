using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPD.Data.Model;
using System.Threading;
using RPD.Controller;

namespace RPD.View
{
    public partial class AnalysisExcelForm : Form, IAnalysisExcelForm
    {
        private AnalysisExcelController _controller;

        public AnalysisExcelForm()
        {
            InitializeComponent();
            SetController(new AnalysisExcelController(this));
        }

        private void AnalysisExcelForm_Load(object sender, EventArgs e)
        {

        }

        public void SetController(Controller.AnalysisExcelController controller)
        {
            _controller = controller;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }


        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileExcel = new OpenFileDialog();
            openFileExcel.Filter = "Файлы Excel(*.xls;*.xlsm)|*.xls;*.xlsm";
            if (openFileExcel.ShowDialog() == DialogResult.OK)
                _controller.startAnalize(openFileExcel.FileName);
            else
                return;
        }


        public void ShowLogs(String text, Color color)
        {
            Action Logs = () => { rtbLogs.AppendText(text, color); }; Invoke(Logs);
        }


        public void ShowProgressBar(int Max, int Value)
        {
            Action Progress = () => { progressBar.Maximum = Max; progressBar.Value = Value; }; Invoke(Progress);
        }
    }
}
