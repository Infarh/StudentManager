namespace StudentManager
{
    partial class GroupsManagerWindow
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
            this.GroupsList = new System.Windows.Forms.ListBox();
            this.GroupDataPanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupDescriptionEdit = new System.Windows.Forms.TextBox();
            this.GroupCourseEdit = new System.Windows.Forms.NumericUpDown();
            this.GroupStudentsPanel = new System.Windows.Forms.GroupBox();
            this.GroupStudentsListBox = new System.Windows.Forms.ListBox();
            this.GroupDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCourseEdit)).BeginInit();
            this.GroupStudentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupsList
            // 
            this.GroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupsList.FormattingEnabled = true;
            this.GroupsList.Location = new System.Drawing.Point(12, 12);
            this.GroupsList.Name = "GroupsList";
            this.GroupsList.Size = new System.Drawing.Size(246, 368);
            this.GroupsList.TabIndex = 0;
            this.GroupsList.SelectedIndexChanged += new System.EventHandler(this.GroupsList_SelectedIndexChanged);
            // 
            // GroupDataPanel
            // 
            this.GroupDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDataPanel.Controls.Add(this.GroupStudentsPanel);
            this.GroupDataPanel.Controls.Add(this.GroupCourseEdit);
            this.GroupDataPanel.Controls.Add(this.label3);
            this.GroupDataPanel.Controls.Add(this.label2);
            this.GroupDataPanel.Controls.Add(this.GroupDescriptionEdit);
            this.GroupDataPanel.Controls.Add(this.GroupNameEdit);
            this.GroupDataPanel.Controls.Add(this.label1);
            this.GroupDataPanel.Location = new System.Drawing.Point(264, 12);
            this.GroupDataPanel.Name = "GroupDataPanel";
            this.GroupDataPanel.Size = new System.Drawing.Size(293, 409);
            this.GroupDataPanel.TabIndex = 1;
            this.GroupDataPanel.TabStop = false;
            this.GroupDataPanel.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // GroupNameEdit
            // 
            this.GroupNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameEdit.Location = new System.Drawing.Point(88, 24);
            this.GroupNameEdit.Name = "GroupNameEdit";
            this.GroupNameEdit.Size = new System.Drawing.Size(190, 20);
            this.GroupNameEdit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер курса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // GroupDescriptionEdit
            // 
            this.GroupDescriptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDescriptionEdit.Location = new System.Drawing.Point(88, 83);
            this.GroupDescriptionEdit.Name = "GroupDescriptionEdit";
            this.GroupDescriptionEdit.Size = new System.Drawing.Size(190, 20);
            this.GroupDescriptionEdit.TabIndex = 1;
            // 
            // GroupCourseEdit
            // 
            this.GroupCourseEdit.Location = new System.Drawing.Point(88, 53);
            this.GroupCourseEdit.Name = "GroupCourseEdit";
            this.GroupCourseEdit.Size = new System.Drawing.Size(81, 20);
            this.GroupCourseEdit.TabIndex = 3;
            // 
            // GroupStudentsPanel
            // 
            this.GroupStudentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupStudentsPanel.Controls.Add(this.GroupStudentsListBox);
            this.GroupStudentsPanel.Location = new System.Drawing.Point(12, 109);
            this.GroupStudentsPanel.Name = "GroupStudentsPanel";
            this.GroupStudentsPanel.Size = new System.Drawing.Size(275, 294);
            this.GroupStudentsPanel.TabIndex = 4;
            this.GroupStudentsPanel.TabStop = false;
            this.GroupStudentsPanel.Text = "Студенты";
            // 
            // GroupStudentsListBox
            // 
            this.GroupStudentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupStudentsListBox.FormattingEnabled = true;
            this.GroupStudentsListBox.Location = new System.Drawing.Point(3, 16);
            this.GroupStudentsListBox.Name = "GroupStudentsListBox";
            this.GroupStudentsListBox.Size = new System.Drawing.Size(269, 275);
            this.GroupStudentsListBox.TabIndex = 0;
            // 
            // GroupsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 433);
            this.Controls.Add(this.GroupDataPanel);
            this.Controls.Add(this.GroupsList);
            this.Name = "GroupsManagerWindow";
            this.Text = "Группы";
            this.GroupDataPanel.ResumeLayout(false);
            this.GroupDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCourseEdit)).EndInit();
            this.GroupStudentsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GroupsList;
        private System.Windows.Forms.GroupBox GroupDataPanel;
        private System.Windows.Forms.TextBox GroupNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupDescriptionEdit;
        private System.Windows.Forms.GroupBox GroupStudentsPanel;
        private System.Windows.Forms.ListBox GroupStudentsListBox;
        private System.Windows.Forms.NumericUpDown GroupCourseEdit;
    }
}