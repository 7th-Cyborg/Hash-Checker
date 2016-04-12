/* This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. */
namespace Hash_Checker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioSHA1 = new System.Windows.Forms.RadioButton();
            this.radioMD5 = new System.Windows.Forms.RadioButton();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comparebutt = new System.Windows.Forms.Button();
            this.hashText2 = new System.Windows.Forms.TextBox();
            this.hashText1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.radioSHA1);
            this.groupBox1.Controls.Add(this.radioMD5);
            this.groupBox1.Controls.Add(this.textFileName);
            this.groupBox1.Controls.Add(this.openFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // radioSHA1
            // 
            this.radioSHA1.AutoSize = true;
            this.radioSHA1.Location = new System.Drawing.Point(60, 56);
            this.radioSHA1.Name = "radioSHA1";
            this.radioSHA1.Size = new System.Drawing.Size(53, 17);
            this.radioSHA1.TabIndex = 3;
            this.radioSHA1.Text = "SHA1";
            this.radioSHA1.UseVisualStyleBackColor = true;
            // 
            // radioMD5
            // 
            this.radioMD5.AutoSize = true;
            this.radioMD5.Checked = true;
            this.radioMD5.Location = new System.Drawing.Point(6, 56);
            this.radioMD5.Name = "radioMD5";
            this.radioMD5.Size = new System.Drawing.Size(48, 17);
            this.radioMD5.TabIndex = 2;
            this.radioMD5.TabStop = true;
            this.radioMD5.Text = "MD5";
            this.radioMD5.UseVisualStyleBackColor = true;
            // 
            // textFileName
            // 
            this.textFileName.AllowDrop = true;
            this.textFileName.Location = new System.Drawing.Point(6, 24);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(343, 20);
            this.textFileName.TabIndex = 1;
            this.textFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.textFileName_DragDrop);
            this.textFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.textFileName_DragEnter);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(355, 22);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Browse ...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comparebutt);
            this.groupBox2.Controls.Add(this.hashText2);
            this.groupBox2.Controls.Add(this.hashText1);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compare Result";
            // 
            // comparebutt
            // 
            this.comparebutt.Location = new System.Drawing.Point(182, 97);
            this.comparebutt.Name = "comparebutt";
            this.comparebutt.Size = new System.Drawing.Size(75, 23);
            this.comparebutt.TabIndex = 2;
            this.comparebutt.Text = "Compare";
            this.comparebutt.UseVisualStyleBackColor = true;
            this.comparebutt.Click += new System.EventHandler(this.comparebutt_Click);
            // 
            // hashText2
            // 
            this.hashText2.Location = new System.Drawing.Point(6, 71);
            this.hashText2.Name = "hashText2";
            this.hashText2.Size = new System.Drawing.Size(424, 20);
            this.hashText2.TabIndex = 1;
            // 
            // hashText1
            // 
            this.hashText1.Location = new System.Drawing.Point(6, 35);
            this.hashText1.Name = "hashText1";
            this.hashText1.Size = new System.Drawing.Size(424, 20);
            this.hashText1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Hash Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.RadioButton radioSHA1;
        private System.Windows.Forms.RadioButton radioMD5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button comparebutt;
        private System.Windows.Forms.TextBox hashText2;
        private System.Windows.Forms.TextBox hashText1;
    }
}

