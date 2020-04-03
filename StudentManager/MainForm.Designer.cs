namespace StudentManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDataStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGrouDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.AddNewStudentButton = new System.Windows.Forms.Button();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.StudentInfoPanel = new System.Windows.Forms.GroupBox();
            this.SaveStudentChanges = new System.Windows.Forms.Button();
            this.StudentGroupEdit = new System.Windows.Forms.TextBox();
            this.StudentRatingEdit = new System.Windows.Forms.NumericUpDown();
            this.StudentBirthdayEdit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentPatronymicEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentLastNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsDBOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGroupsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsDBSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GroupsEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.StudentInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRatingEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.GroupsEditMenuItem,
            this.HelpMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(504, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.toolStripMenuItem1,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDataStudentsMenuItem,
            this.OpenGrouDataMenuItem});
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenMenuItem.Text = "Открыть";
            // 
            // OpenDataStudentsMenuItem
            // 
            this.OpenDataStudentsMenuItem.Name = "OpenDataStudentsMenuItem";
            this.OpenDataStudentsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenDataStudentsMenuItem.Text = "Файл БД студентов";
            this.OpenDataStudentsMenuItem.Click += new System.EventHandler(this.OpenStudentsDBMenuItem_OnClick);
            // 
            // OpenGrouDataMenuItem
            // 
            this.OpenGrouDataMenuItem.Name = "OpenGrouDataMenuItem";
            this.OpenGrouDataMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenGrouDataMenuItem.Text = "Файл БД групп";
            this.OpenGrouDataMenuItem.Click += new System.EventHandler(this.OpenGroupDBMenuItem_OnClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_OnClick);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpMenuItem.Text = "Помощь";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutMenuItem.Text = "О программе";
            // 
            // StudentsList
            // 
            this.StudentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(12, 27);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(221, 186);
            this.StudentsList.TabIndex = 1;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.StudentsList_OnSelectedIndexChanged);
            // 
            // AddNewStudentButton
            // 
            this.AddNewStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewStudentButton.Location = new System.Drawing.Point(12, 226);
            this.AddNewStudentButton.Name = "AddNewStudentButton";
            this.AddNewStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewStudentButton.TabIndex = 2;
            this.AddNewStudentButton.Text = "Добавить";
            this.AddNewStudentButton.UseVisualStyleBackColor = true;
            this.AddNewStudentButton.Click += new System.EventHandler(this.AddNewStudentButton_Click);
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveStudentButton.Location = new System.Drawing.Point(158, 225);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveStudentButton.TabIndex = 3;
            this.RemoveStudentButton.Text = "Удалить";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // StudentInfoPanel
            // 
            this.StudentInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentInfoPanel.Controls.Add(this.SaveStudentChanges);
            this.StudentInfoPanel.Controls.Add(this.StudentGroupEdit);
            this.StudentInfoPanel.Controls.Add(this.StudentRatingEdit);
            this.StudentInfoPanel.Controls.Add(this.StudentBirthdayEdit);
            this.StudentInfoPanel.Controls.Add(this.label6);
            this.StudentInfoPanel.Controls.Add(this.label5);
            this.StudentInfoPanel.Controls.Add(this.label4);
            this.StudentInfoPanel.Controls.Add(this.StudentPatronymicEdit);
            this.StudentInfoPanel.Controls.Add(this.label3);
            this.StudentInfoPanel.Controls.Add(this.StudentNameEdit);
            this.StudentInfoPanel.Controls.Add(this.label2);
            this.StudentInfoPanel.Controls.Add(this.StudentLastNameEdit);
            this.StudentInfoPanel.Controls.Add(this.label1);
            this.StudentInfoPanel.Location = new System.Drawing.Point(239, 27);
            this.StudentInfoPanel.Name = "StudentInfoPanel";
            this.StudentInfoPanel.Size = new System.Drawing.Size(253, 222);
            this.StudentInfoPanel.TabIndex = 4;
            this.StudentInfoPanel.TabStop = false;
            this.StudentInfoPanel.Text = "Информация по студенту";
            // 
            // SaveStudentChanges
            // 
            this.SaveStudentChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStudentChanges.Location = new System.Drawing.Point(112, 193);
            this.SaveStudentChanges.Name = "SaveStudentChanges";
            this.SaveStudentChanges.Size = new System.Drawing.Size(135, 23);
            this.SaveStudentChanges.TabIndex = 12;
            this.SaveStudentChanges.Text = "Сохранить изменения";
            this.SaveStudentChanges.UseVisualStyleBackColor = true;
            this.SaveStudentChanges.Click += new System.EventHandler(this.SaveStudentChanges_Click);
            // 
            // StudentGroupEdit
            // 
            this.StudentGroupEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentGroupEdit.Location = new System.Drawing.Point(71, 153);
            this.StudentGroupEdit.Name = "StudentGroupEdit";
            this.StudentGroupEdit.ReadOnly = true;
            this.StudentGroupEdit.Size = new System.Drawing.Size(176, 20);
            this.StudentGroupEdit.TabIndex = 11;
            // 
            // StudentRatingEdit
            // 
            this.StudentRatingEdit.DecimalPlaces = 2;
            this.StudentRatingEdit.Location = new System.Drawing.Point(71, 127);
            this.StudentRatingEdit.Name = "StudentRatingEdit";
            this.StudentRatingEdit.Size = new System.Drawing.Size(97, 20);
            this.StudentRatingEdit.TabIndex = 10;
            // 
            // StudentBirthdayEdit
            // 
            this.StudentBirthdayEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentBirthdayEdit.Location = new System.Drawing.Point(100, 101);
            this.StudentBirthdayEdit.Name = "StudentBirthdayEdit";
            this.StudentBirthdayEdit.Size = new System.Drawing.Size(147, 20);
            this.StudentBirthdayEdit.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Группа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Рейтинг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения:";
            // 
            // StudentPatronymicEdit
            // 
            this.StudentPatronymicEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentPatronymicEdit.Location = new System.Drawing.Point(71, 74);
            this.StudentPatronymicEdit.Name = "StudentPatronymicEdit";
            this.StudentPatronymicEdit.Size = new System.Drawing.Size(176, 20);
            this.StudentPatronymicEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // StudentNameEdit
            // 
            this.StudentNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameEdit.Location = new System.Drawing.Point(71, 48);
            this.StudentNameEdit.Name = "StudentNameEdit";
            this.StudentNameEdit.Size = new System.Drawing.Size(176, 20);
            this.StudentNameEdit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // StudentLastNameEdit
            // 
            this.StudentLastNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentLastNameEdit.Location = new System.Drawing.Point(71, 22);
            this.StudentLastNameEdit.Name = "StudentLastNameEdit";
            this.StudentLastNameEdit.Size = new System.Drawing.Size(176, 20);
            this.StudentLastNameEdit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // StudentsDBOpenFileDialog
            // 
            this.StudentsDBOpenFileDialog.DefaultExt = "csv";
            this.StudentsDBOpenFileDialog.FileName = "Students.csv";
            this.StudentsDBOpenFileDialog.Filter = "Файлы csv (*.csv)|*.csv|Все файлы (*.*)|*.*";
            this.StudentsDBOpenFileDialog.RestoreDirectory = true;
            this.StudentsDBOpenFileDialog.Title = "Выбор файла базы данных студентов";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStudentsMenuItem,
            this.SaveGroupsMenuItem});
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            // 
            // SaveStudentsMenuItem
            // 
            this.SaveStudentsMenuItem.Name = "SaveStudentsMenuItem";
            this.SaveStudentsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveStudentsMenuItem.Text = "Студентов";
            this.SaveStudentsMenuItem.Click += new System.EventHandler(this.SaveStudentsDBMenuItem_OnClickOpenStudentsDBMenuItem_OnClick);
            // 
            // SaveGroupsMenuItem
            // 
            this.SaveGroupsMenuItem.Name = "SaveGroupsMenuItem";
            this.SaveGroupsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveGroupsMenuItem.Text = "Группы";
            this.SaveGroupsMenuItem.Click += new System.EventHandler(this.SaveGroupDBMenuItem_OnClick);
            // 
            // StudentsDBSaveFileDialog
            // 
            this.StudentsDBSaveFileDialog.DefaultExt = "csv";
            this.StudentsDBSaveFileDialog.FileName = "Students.csv";
            this.StudentsDBSaveFileDialog.Filter = "Файлы csv (*.csv)|*.csv|Все файлы (*.*)|*.*";
            this.StudentsDBSaveFileDialog.RestoreDirectory = true;
            this.StudentsDBSaveFileDialog.Title = "Выбор файла для сохранения БД студентов";
            // 
            // GroupsEditMenuItem
            // 
            this.GroupsEditMenuItem.Name = "GroupsEditMenuItem";
            this.GroupsEditMenuItem.Size = new System.Drawing.Size(61, 20);
            this.GroupsEditMenuItem.Text = "Группы";
            this.GroupsEditMenuItem.Click += new System.EventHandler(this.GroupsEditMenuItem_OnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.StudentInfoPanel);
            this.Controls.Add(this.RemoveStudentButton);
            this.Controls.Add(this.AddNewStudentButton);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "MainForm";
            this.Text = "Управление студентами";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StudentInfoPanel.ResumeLayout(false);
            this.StudentInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRatingEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDataStudentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenGrouDataMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.Button AddNewStudentButton;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.GroupBox StudentInfoPanel;
        private System.Windows.Forms.Button SaveStudentChanges;
        private System.Windows.Forms.TextBox StudentGroupEdit;
        private System.Windows.Forms.NumericUpDown StudentRatingEdit;
        private System.Windows.Forms.DateTimePicker StudentBirthdayEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentPatronymicEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentNameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentLastNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog StudentsDBOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveStudentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveGroupsMenuItem;
        private System.Windows.Forms.SaveFileDialog StudentsDBSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem GroupsEditMenuItem;
    }
}

