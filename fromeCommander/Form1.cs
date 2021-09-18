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

namespace fromeCommander
{
    public partial class fromeCommander : Form
    {
        protected string selectedFilePath;

        public fromeCommander()
        {
            InitializeComponent();
        }

        private void setIconButton()
        {
            string pathToFile = Environment.CurrentDirectory + "\\..\\..\\img\\folder.png";

            selectDirectory.Image = Image.FromFile(pathToFile);
            selectDirectory.ImageAlign = ContentAlignment.MiddleRight;
            selectDirectory.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void selectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                if (FBD.SelectedPath != null)
                {
                    textBox.Clear();
                    string[] allFolders = Directory.GetDirectories(FBD.SelectedPath);
                    foreach (string folder in allFolders)
                    {
                        textBox.Text = textBox.Text + folder + System.Environment.NewLine;
                    }

                    string[] fullfilesPath = Directory.GetFiles(FBD.SelectedPath);
                    foreach (string file in fullfilesPath)
                    {
                        textBox.Text = textBox.Text + file + System.Environment.NewLine;
                    }

                    textBox.ReadOnly = true;
                }

            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            textBox.Clear(); //clear

            selectedFilePath = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(selectedFilePath);
            textBox.Text = fileText;

            copyFile.Enabled = true;
            saveAs.Enabled = true;
            fileInfo.Enabled = true;
            deleteFile.Enabled = true;
            textBox.ReadOnly = false;
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(selectedFilePath);

            DialogResult dialogResult = MessageBox.Show(
                "Вы действительно хотите удалить файл " + fileName + "?",
                "Удаление файла",
                MessageBoxButtons.YesNo
            );

            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(selectedFilePath);
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "unknown.txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
            }
        }

        private void fileInfo_Click(object sender, EventArgs e)
        {
            FileInfo thisFile = new FileInfo(selectedFilePath);

            if (thisFile.Exists)
            {
                string thisFileInfo = "Путь: " + thisFile.FullName + "\n";
                thisFileInfo += "Имя: " + thisFile.Name + "\n";
                thisFileInfo += "Дата создания: " + thisFile.LastWriteTime + "\n";
                thisFileInfo += "Дата изменения: " + thisFile.LastWriteTime + "\n";

                MessageBox.Show(thisFileInfo);
            }
            else
            {
                MessageBox.Show("Файл не существует");
            }
            
        }

        private void copyFile_Click(object sender, EventArgs e)
        {

        }
    }
}
