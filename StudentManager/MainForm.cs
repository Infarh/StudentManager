﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StudentManager.Models;
using StudentManager.Service;

namespace StudentManager
{
    public partial class MainForm : Form
    {
        private readonly List<Student> _Students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenStudentsDBMenuItem_OnClick(object sender, EventArgs e)
        {
            StudentsDBOpenFileDialog.InitialDirectory = Environment.CurrentDirectory;

            var dialog_result = StudentsDBOpenFileDialog.ShowDialog();
            if(dialog_result != DialogResult.OK) return;

            var data_file_name = StudentsDBOpenFileDialog.FileName;

            if (!File.Exists(data_file_name))
            {
                MessageBox.Show("Выбранный файл не существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var reader = File.OpenText(data_file_name))
            {
                var students = Extensions.ReadStudents(reader);

                _Students.Clear();
                _Students.AddRange(students);
            }

            StudentsList.Items.Clear();
            foreach (var student in _Students)
                StudentsList.Items.Add(student.LastName + " " + student.Name);
        }

        private void StudentsList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var students_list_box = (ListBox) sender;

            var selected_index = students_list_box.SelectedIndex;
            if(selected_index < 0) return;

            var student = _Students[selected_index];

            StudentLastNameEdit.Text = student.LastName;
            StudentNameEdit.Text = student.Name;
            StudentPatronymicEdit.Text = student.Patronymic;


        }

        private void SaveStudentChanges_Click(object sender, EventArgs e)
        {
            var selected_index = StudentsList.SelectedIndex;

            var student = _Students[selected_index];

            student.LastName = StudentLastNameEdit.Text;
            student.Name = StudentNameEdit.Text;
            student.Patronymic = StudentPatronymicEdit.Text;

            StudentsList.Items[selected_index] = student.LastName + " " + student.Name;
        }
    }
}
