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

        
    }
}
