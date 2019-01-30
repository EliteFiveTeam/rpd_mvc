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
        public AnalysisWordForm()
        {
            InitializeComponent();
            SetController(new AnalisysWordController(this));
        }

        private void AnalysisWordForm_Load(object sender, EventArgs e)
        {

        }
        public void SetController(AnalisysWordController controller)
        {
            _controller = controller;
        }
    }
}
