using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RPD.Data.Model;
using RPD.Controller;


namespace RPD.View
{
    public partial class Form1 : Form, IMainForm
    {
        private MainController _controller;
        private String pathFileWord = null;


        public Form1()
        {
            InitializeComponent();
            SetController(new MainController(this));
            _controller.getProfiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddProfile_Click(object sender, EventArgs e)
        {
            AnalysisExcelForm analysisExcelForm = new AnalysisExcelForm();
            analysisExcelForm.Owner = this;
            analysisExcelForm.ShowDialog();
        }


        private void listBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.getDiscipline(listBoxProfile.SelectedIndex);
        }


        public void ShowProfiles(List<ProfileEducational> profiles)
        {
            foreach (ProfileEducational profile in profiles)
            {
                listBoxProfile.Items.Add(profile.GetFullName());
            }
            if (listBoxProfile.Items.Count > 0) listBoxProfile.SetSelected(0, true);
           
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }


        public void ShowDisciplines(List<Discipline> disciplines)
        {
            if (listBoxDiscipline.Items.Count > 0)
            {
                listBoxDiscipline.Items.Clear();
            }
            foreach (Discipline discipline in disciplines)
            {
                listBoxDiscipline.Items.Add(discipline.Name);
            }
        }

        private void buttonPatternRP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileWord = new OpenFileDialog();
            openFileWord.Filter = "Файлы Word(*.doc)|*.doc|Word(*.docx)|*.docx";
            if (openFileWord.ShowDialog() == DialogResult.OK)
            {
                pathFileWord = openFileWord.FileName;
            }
            else
            {
                return;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
