
namespace fromeCommander
{
    partial class fromeCommander
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveAs = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.selectDirectory = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 450);
            this.panel1.TabIndex = 0;
            // 
            // saveAs
            // 
            this.saveAs.Enabled = false;
            this.saveAs.Location = new System.Drawing.Point(497, 45);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(31, 23);
            this.saveAs.TabIndex = 4;
            this.saveAs.Text = "S";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Enabled = false;
            this.deleteFile.ForeColor = System.Drawing.Color.Red;
            this.deleteFile.Location = new System.Drawing.Point(497, 16);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(31, 23);
            this.deleteFile.TabIndex = 3;
            this.deleteFile.Text = "X";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // openFile
            // 
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Location = new System.Drawing.Point(534, 11);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(116, 66);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Открыть файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // selectDirectory
            // 
            this.selectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirectory.Location = new System.Drawing.Point(12, 11);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(120, 66);
            this.selectDirectory.TabIndex = 1;
            this.selectDirectory.Text = "Выбрать каталог";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Info;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(653, 366);
            this.textBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(181)))), ((int)(((byte)(124)))));
            this.panel2.Controls.Add(this.selectDirectory);
            this.panel2.Controls.Add(this.saveAs);
            this.panel2.Controls.Add(this.openFile);
            this.panel2.Controls.Add(this.deleteFile);
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 89);
            this.panel2.TabIndex = 5;
            // 
            // fromeCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fromeCommander";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button selectDirectory;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Panel panel2;
    }
}

