
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromeCommander));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diskSpace = new System.Windows.Forms.PictureBox();
            this.deleteFile = new System.Windows.Forms.PictureBox();
            this.copyFile = new System.Windows.Forms.PictureBox();
            this.fileInfo = new System.Windows.Forms.PictureBox();
            this.saveAs = new System.Windows.Forms.PictureBox();
            this.saveFile = new System.Windows.Forms.PictureBox();
            this.selectDirectory = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFile)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(181)))), ((int)(((byte)(124)))));
            this.panel2.Controls.Add(this.diskSpace);
            this.panel2.Controls.Add(this.deleteFile);
            this.panel2.Controls.Add(this.copyFile);
            this.panel2.Controls.Add(this.fileInfo);
            this.panel2.Controls.Add(this.saveAs);
            this.panel2.Controls.Add(this.saveFile);
            this.panel2.Controls.Add(this.selectDirectory);
            this.panel2.Controls.Add(this.openFile);
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 89);
            this.panel2.TabIndex = 5;
            // 
            // diskSpace
            // 
            this.diskSpace.Image = ((System.Drawing.Image)(resources.GetObject("diskSpace.Image")));
            this.diskSpace.Location = new System.Drawing.Point(477, 32);
            this.diskSpace.Name = "diskSpace";
            this.diskSpace.Size = new System.Drawing.Size(45, 45);
            this.diskSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diskSpace.TabIndex = 13;
            this.diskSpace.TabStop = false;
            this.diskSpace.UseWaitCursor = true;
            this.diskSpace.Click += new System.EventHandler(this.diskSpace_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Enabled = false;
            this.deleteFile.Image = ((System.Drawing.Image)(resources.GetObject("deleteFile.Image")));
            this.deleteFile.Location = new System.Drawing.Point(380, 47);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(30, 30);
            this.deleteFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteFile.TabIndex = 12;
            this.deleteFile.TabStop = false;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // copyFile
            // 
            this.copyFile.Enabled = false;
            this.copyFile.Image = ((System.Drawing.Image)(resources.GetObject("copyFile.Image")));
            this.copyFile.Location = new System.Drawing.Point(322, 47);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(30, 30);
            this.copyFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copyFile.TabIndex = 11;
            this.copyFile.TabStop = false;
            this.copyFile.Click += new System.EventHandler(this.copyFile_Click);
            // 
            // fileInfo
            // 
            this.fileInfo.Enabled = false;
            this.fileInfo.Image = ((System.Drawing.Image)(resources.GetObject("fileInfo.Image")));
            this.fileInfo.Location = new System.Drawing.Point(269, 47);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(30, 30);
            this.fileInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileInfo.TabIndex = 10;
            this.fileInfo.TabStop = false;
            this.fileInfo.Click += new System.EventHandler(this.fileInfo_Click);
            // 
            // saveAs
            // 
            this.saveAs.Enabled = false;
            this.saveAs.Image = ((System.Drawing.Image)(resources.GetObject("saveAs.Image")));
            this.saveAs.Location = new System.Drawing.Point(217, 49);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(28, 28);
            this.saveAs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveAs.TabIndex = 9;
            this.saveAs.TabStop = false;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // saveFile
            // 
            this.saveFile.Enabled = false;
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Location = new System.Drawing.Point(165, 47);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(30, 30);
            this.saveFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveFile.TabIndex = 8;
            this.saveFile.TabStop = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // selectDirectory
            // 
            this.selectDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirectory.Location = new System.Drawing.Point(12, 11);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(120, 66);
            this.selectDirectory.TabIndex = 1;
            this.selectDirectory.Text = "Выбрать каталог";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // openFile
            // 
            this.openFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Location = new System.Drawing.Point(534, 11);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(116, 66);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Открыть файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
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
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fromeCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "fromeCommander";
            this.Text = "fromeCommander";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diskSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button selectDirectory;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox saveFile;
        private System.Windows.Forms.PictureBox saveAs;
        private System.Windows.Forms.PictureBox fileInfo;
        private System.Windows.Forms.PictureBox copyFile;
        private System.Windows.Forms.PictureBox deleteFile;
        private System.Windows.Forms.PictureBox diskSpace;
    }
}

