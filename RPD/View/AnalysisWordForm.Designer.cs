namespace RPD.View
{
    partial class AnalysisWordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tab_Analysis_Pr = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb_ForExam = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb_Tems = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtb_LiteraBasic = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtb_Add_Litera = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_OpenWp = new System.Windows.Forms.Button();
            this.bt_create_newrp = new System.Windows.Forms.Button();
            this.Create_Ticket = new System.Windows.Forms.Button();
            this.bt_create_newfos = new System.Windows.Forms.Button();
            this.Create_ANOT = new System.Windows.Forms.Button();
            this.openFileWord = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_Analysis_Pr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tab_Analysis_Pr, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tab_Analysis_Pr
            // 
            this.tab_Analysis_Pr.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_Analysis_Pr.Controls.Add(this.tabPage1);
            this.tab_Analysis_Pr.Controls.Add(this.tabPage2);
            this.tab_Analysis_Pr.Controls.Add(this.tabPage3);
            this.tab_Analysis_Pr.Controls.Add(this.tabPage4);
            this.tab_Analysis_Pr.HotTrack = true;
            this.tab_Analysis_Pr.Location = new System.Drawing.Point(3, 3);
            this.tab_Analysis_Pr.Multiline = true;
            this.tab_Analysis_Pr.Name = "tab_Analysis_Pr";
            this.tab_Analysis_Pr.SelectedIndex = 0;
            this.tab_Analysis_Pr.Size = new System.Drawing.Size(772, 425);
            this.tab_Analysis_Pr.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tab_Analysis_Pr.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_ForExam);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вопросы к зачёту/экзамену";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb_ForExam
            // 
            this.rtb_ForExam.Location = new System.Drawing.Point(3, 6);
            this.rtb_ForExam.Name = "rtb_ForExam";
            this.rtb_ForExam.Size = new System.Drawing.Size(752, 381);
            this.rtb_ForExam.TabIndex = 0;
            this.rtb_ForExam.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb_Tems);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Перечень УМО";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtb_Tems
            // 
            this.rtb_Tems.Location = new System.Drawing.Point(0, 0);
            this.rtb_Tems.Name = "rtb_Tems";
            this.rtb_Tems.Size = new System.Drawing.Size(900, 421);
            this.rtb_Tems.TabIndex = 20;
            this.rtb_Tems.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb_LiteraBasic);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Основная литература";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtb_LiteraBasic
            // 
            this.rtb_LiteraBasic.Location = new System.Drawing.Point(0, 0);
            this.rtb_LiteraBasic.Name = "rtb_LiteraBasic";
            this.rtb_LiteraBasic.Size = new System.Drawing.Size(900, 421);
            this.rtb_LiteraBasic.TabIndex = 21;
            this.rtb_LiteraBasic.Text = "";
            this.rtb_LiteraBasic.TextChanged += new System.EventHandler(this.rtb_LiteraBasic_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtb_Add_Litera);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дополнительная литература";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtb_Add_Litera
            // 
            this.rtb_Add_Litera.Location = new System.Drawing.Point(0, 0);
            this.rtb_Add_Litera.Name = "rtb_Add_Litera";
            this.rtb_Add_Litera.Size = new System.Drawing.Size(900, 421);
            this.rtb_Add_Litera.TabIndex = 23;
            this.rtb_Add_Litera.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rtb_Log, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(781, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.775701F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.2243F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(409, 428);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_Log.Location = new System.Drawing.Point(3, 3);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_Log.Size = new System.Drawing.Size(403, 421);
            this.rtb_Log.TabIndex = 20;
            this.rtb_Log.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Clear, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_OpenWp, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_create_newrp, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Create_Ticket, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.bt_create_newfos, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Create_ANOT, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 434);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(517, 106);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Enabled = false;
            this.btn_Clear.Location = new System.Drawing.Point(3, 56);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(164, 47);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_OpenWp
            // 
            this.btn_OpenWp.Location = new System.Drawing.Point(3, 3);
            this.btn_OpenWp.Name = "btn_OpenWp";
            this.btn_OpenWp.Size = new System.Drawing.Size(167, 47);
            this.btn_OpenWp.TabIndex = 16;
            this.btn_OpenWp.Text = "Открыть старую РП и проанализировать";
            this.btn_OpenWp.UseVisualStyleBackColor = true;
            this.btn_OpenWp.Click += new System.EventHandler(this.btn_OpenWp_Click);
            // 
            // bt_create_newrp
            // 
            this.bt_create_newrp.Enabled = false;
            this.bt_create_newrp.Location = new System.Drawing.Point(176, 3);
            this.bt_create_newrp.Name = "bt_create_newrp";
            this.bt_create_newrp.Size = new System.Drawing.Size(167, 44);
            this.bt_create_newrp.TabIndex = 28;
            this.bt_create_newrp.Text = "Создать новую РП";
            this.bt_create_newrp.UseVisualStyleBackColor = true;
            this.bt_create_newrp.Click += new System.EventHandler(this.bt_create_newrp_Click);
            // 
            // Create_Ticket
            // 
            this.Create_Ticket.Enabled = false;
            this.Create_Ticket.Location = new System.Drawing.Point(176, 56);
            this.Create_Ticket.Name = "Create_Ticket";
            this.Create_Ticket.Size = new System.Drawing.Size(164, 47);
            this.Create_Ticket.TabIndex = 29;
            this.Create_Ticket.Text = "Создать билеты";
            this.Create_Ticket.UseVisualStyleBackColor = true;
            this.Create_Ticket.Click += new System.EventHandler(this.Create_Ticket_Click);
            // 
            // bt_create_newfos
            // 
            this.bt_create_newfos.Location = new System.Drawing.Point(349, 3);
            this.bt_create_newfos.Name = "bt_create_newfos";
            this.bt_create_newfos.Size = new System.Drawing.Size(165, 44);
            this.bt_create_newfos.TabIndex = 30;
            this.bt_create_newfos.Text = "Создать новую ФОС";
            this.bt_create_newfos.UseVisualStyleBackColor = true;
            // 
            // Create_ANOT
            // 
            this.Create_ANOT.Location = new System.Drawing.Point(349, 56);
            this.Create_ANOT.Name = "Create_ANOT";
            this.Create_ANOT.Size = new System.Drawing.Size(165, 47);
            this.Create_ANOT.TabIndex = 31;
            this.Create_ANOT.Text = "Создать новую Аннотацию";
            this.Create_ANOT.UseVisualStyleBackColor = true;
            // 
            // openFileWord
            // 
            this.openFileWord.FileName = "openFileWord";
            // 
            // AnalysisWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 566);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnalysisWordForm";
            this.Text = "AnalysisWordForm";
            this.Load += new System.EventHandler(this.AnalysisWordForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tab_Analysis_Pr.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tab_Analysis_Pr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtb_ForExam;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb_Tems;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtb_LiteraBasic;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtb_Add_Litera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_OpenWp;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button bt_create_newrp;
        private System.Windows.Forms.Button Create_Ticket;
        private System.Windows.Forms.Button bt_create_newfos;
        private System.Windows.Forms.Button Create_ANOT;
        private System.Windows.Forms.OpenFileDialog openFileWord;
    }
}