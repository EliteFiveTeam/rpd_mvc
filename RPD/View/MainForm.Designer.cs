namespace RPD.View
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProfile = new System.Windows.Forms.ListBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.listBoxDiscipline = new System.Windows.Forms.ListBox();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.buttonSelectDiscipline = new System.Windows.Forms.Button();
            this.buttonPatternRP = new System.Windows.Forms.Button();
            this.buttonPatternFOS = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelPatternRP = new System.Windows.Forms.Label();
            this.labelPatternFOS = new System.Windows.Forms.Label();
            this.labelPatternAnatacia = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProfile
            // 
            this.listBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProfile.FormattingEnabled = true;
            this.listBoxProfile.Location = new System.Drawing.Point(11, 34);
            this.listBoxProfile.Margin = new System.Windows.Forms.Padding(11, 2, 11, 6);
            this.listBoxProfile.Name = "listBoxProfile";
            this.listBoxProfile.Size = new System.Drawing.Size(245, 303);
            this.listBoxProfile.TabIndex = 0;
            this.listBoxProfile.SelectedIndexChanged += new System.EventHandler(this.listBoxProfile_SelectedIndexChanged);
            // 
            // labelProfile
            // 
            this.labelProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Franklin Gothic Book", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfile.Location = new System.Drawing.Point(82, 4);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProfile.Size = new System.Drawing.Size(102, 28);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "Профиль";
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Font = new System.Drawing.Font("Franklin Gothic Book", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscipline.Location = new System.Drawing.Point(386, 4);
            this.labelDiscipline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(140, 28);
            this.labelDiscipline.TabIndex = 2;
            this.labelDiscipline.Text = "Дисциплины";
            this.labelDiscipline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxDiscipline
            // 
            this.listBoxDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDiscipline.FormattingEnabled = true;
            this.listBoxDiscipline.Location = new System.Drawing.Point(278, 34);
            this.listBoxDiscipline.Margin = new System.Windows.Forms.Padding(11, 2, 11, 6);
            this.listBoxDiscipline.Name = "listBoxDiscipline";
            this.listBoxDiscipline.Size = new System.Drawing.Size(356, 303);
            this.listBoxDiscipline.TabIndex = 3;
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProfile.AutoSize = true;
            this.buttonAddProfile.BackColor = System.Drawing.Color.LightGray;
            this.buttonAddProfile.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddProfile.Location = new System.Drawing.Point(11, 3);
            this.buttonAddProfile.Margin = new System.Windows.Forms.Padding(11, 2, 2, 2);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(130, 52);
            this.buttonAddProfile.TabIndex = 4;
            this.buttonAddProfile.Text = "Добавить профиль";
            this.buttonAddProfile.UseVisualStyleBackColor = false;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteProfile.Location = new System.Drawing.Point(145, 3);
            this.buttonDeleteProfile.Margin = new System.Windows.Forms.Padding(2, 2, 11, 2);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(116, 52);
            this.buttonDeleteProfile.TabIndex = 5;
            this.buttonDeleteProfile.Text = "Удалить профиль";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // buttonSelectDiscipline
            // 
            this.buttonSelectDiscipline.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelectDiscipline.BackColor = System.Drawing.Color.LightGray;
            this.buttonSelectDiscipline.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectDiscipline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSelectDiscipline.Location = new System.Drawing.Point(321, 3);
            this.buttonSelectDiscipline.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectDiscipline.Name = "buttonSelectDiscipline";
            this.buttonSelectDiscipline.Size = new System.Drawing.Size(274, 52);
            this.buttonSelectDiscipline.TabIndex = 6;
            this.buttonSelectDiscipline.Text = "Выбрать дисциплину";
            this.buttonSelectDiscipline.UseVisualStyleBackColor = false;
            // 
            // buttonPatternRP
            // 
            this.buttonPatternRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPatternRP.BackColor = System.Drawing.Color.LightGray;
            this.buttonPatternRP.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F);
            this.buttonPatternRP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPatternRP.Location = new System.Drawing.Point(243, 2);
            this.buttonPatternRP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPatternRP.Name = "buttonPatternRP";
            this.buttonPatternRP.Size = new System.Drawing.Size(102, 38);
            this.buttonPatternRP.TabIndex = 7;
            this.buttonPatternRP.Text = "Открыть";
            this.buttonPatternRP.UseVisualStyleBackColor = false;
            // 
            // buttonPatternFOS
            // 
            this.buttonPatternFOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPatternFOS.BackColor = System.Drawing.Color.LightGray;
            this.buttonPatternFOS.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F);
            this.buttonPatternFOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPatternFOS.Location = new System.Drawing.Point(243, 44);
            this.buttonPatternFOS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPatternFOS.Name = "buttonPatternFOS";
            this.buttonPatternFOS.Size = new System.Drawing.Size(102, 38);
            this.buttonPatternFOS.TabIndex = 8;
            this.buttonPatternFOS.Text = "Открыть";
            this.buttonPatternFOS.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(243, 86);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "Открыть";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // labelPatternRP
            // 
            this.labelPatternRP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPatternRP.AutoSize = true;
            this.labelPatternRP.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatternRP.Location = new System.Drawing.Point(2, 10);
            this.labelPatternRP.Margin = new System.Windows.Forms.Padding(2, 0, 11, 0);
            this.labelPatternRP.Name = "labelPatternRP";
            this.labelPatternRP.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelPatternRP.Size = new System.Drawing.Size(228, 21);
            this.labelPatternRP.TabIndex = 10;
            this.labelPatternRP.Text = "Шаблон рабочей программы";
            // 
            // labelPatternFOS
            // 
            this.labelPatternFOS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPatternFOS.AutoSize = true;
            this.labelPatternFOS.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatternFOS.Location = new System.Drawing.Point(2, 52);
            this.labelPatternFOS.Margin = new System.Windows.Forms.Padding(2, 0, 11, 0);
            this.labelPatternFOS.Name = "labelPatternFOS";
            this.labelPatternFOS.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelPatternFOS.Size = new System.Drawing.Size(113, 21);
            this.labelPatternFOS.TabIndex = 11;
            this.labelPatternFOS.Text = "Шаблон ФОС";
            // 
            // labelPatternAnatacia
            // 
            this.labelPatternAnatacia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPatternAnatacia.AutoSize = true;
            this.labelPatternAnatacia.Font = new System.Drawing.Font("Franklin Gothic Book", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatternAnatacia.Location = new System.Drawing.Point(2, 95);
            this.labelPatternAnatacia.Margin = new System.Windows.Forms.Padding(2, 0, 11, 0);
            this.labelPatternAnatacia.Name = "labelPatternAnatacia";
            this.labelPatternAnatacia.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelPatternAnatacia.Size = new System.Drawing.Size(150, 21);
            this.labelPatternAnatacia.TabIndex = 12;
            this.labelPatternAnatacia.Text = "Шаблон анатации";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51852F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxProfile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxDiscipline, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscipline, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProfile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 11, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.501187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.49881F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 344);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.24646F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.11628F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.67442F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteProfile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddProfile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelectDiscipline, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 350);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 57);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.labelPatternRP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPatternFOS, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPatternAnatacia, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonPatternRP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPatternFOS, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 428);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(11, 2, 11, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(658, 144);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(658, 572);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(674, 611);
            this.Name = "Form1";
            this.Text = "Главный экран";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProfile;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.ListBox listBoxDiscipline;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button buttonSelectDiscipline;
        private System.Windows.Forms.Button buttonPatternRP;
        private System.Windows.Forms.Button buttonPatternFOS;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelPatternRP;
        private System.Windows.Forms.Label labelPatternFOS;
        private System.Windows.Forms.Label labelPatternAnatacia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

