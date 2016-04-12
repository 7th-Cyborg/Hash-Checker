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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hash_Checker
{
    public partial class Main : Form
    {
        Hash_Check_MD5 _md5;
        Hash_Check_SHA1 _sha1;

        public Main()
        {
            InitializeComponent();
        }

        private void textFileName_DragDrop(object sender, DragEventArgs e)
        {
            //popunjavamo imena file-ova
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(files[0]);

            if ((fileInfo.Attributes & System.IO.FileAttributes.Directory) != System.IO.FileAttributes.Directory)
            {
                textFileName.Text = files[0];
                Hash_Calculate(files[0]);

                return;
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open txt file";
            open.Filter = "All files (*.*)|*.*";
            open.FilterIndex = 1;
            open.AddExtension = true;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                textFileName.Text = open.FileName;
                Hash_Calculate(open.FileName);
            }
        }


        private void textFileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        //Glavna funkcija
        private void Hash_Calculate(string str)
        {
            hashText1.Text = "";
            hashText1.BackColor = SystemColors.Window;
            hashText2.BackColor = SystemColors.Window;
            if (radioMD5.Checked == true)
            {
                
                _md5 = new Hash_Check_MD5();
                _md5.OnFinish += new OnFinishEventHandler(_md5_OnFinish);
                _md5.OnProgressUpdate += new OnProgressUpdateEventHandler(_md5_OnProgressUpdate);
                _md5.Check_Hash(str);
            }
            else 
            {
                
                _sha1 = new Hash_Check_SHA1();
                _sha1.OnFinish += new OnFinishEventHandler(_sha1_OnFinish);
                _sha1.OnProgressUpdate += new OnProgressUpdateEventHandler(_sha1_OnProgressUpdate);
                _sha1.Check_Hash(str);
            }
        }

        void _md5_OnProgressUpdate()
        {
            Invoke( new OnProgressUpdateEventHandler(_md5_OnProgressUpdate_Invoke),null);
        }
        void _md5_OnProgressUpdate_Invoke()
        {
            progressBar1.Value = _md5.Progress;
        }

        void _md5_OnFinish()
        {
            Invoke(new OnFinishEventHandler(_md5_OnFinish_Invoke),null);
        }
        void _md5_OnFinish_Invoke()
        {
            progressBar1.Value = 0;
            hashText1.Text = _md5.MD5_Hash;
        }



        void _sha1_OnProgressUpdate()
        {
            Invoke(new OnProgressUpdateEventHandler(_sha1_OnProgressUpdate_Invoke), null);
        }
        void _sha1_OnProgressUpdate_Invoke()
        {
            progressBar1.Value = _sha1.Progress;
        }

        void _sha1_OnFinish()
        {
            Invoke(new OnFinishEventHandler(_sha1_OnFinish_Invoke), null);
        }
        void _sha1_OnFinish_Invoke()
        {
            progressBar1.Value = 0;
            hashText1.Text = _sha1.SHA1_Hash;
        }


        private void comparebutt_Click(object sender, EventArgs e)
        {
            if (hashText1.Text.ToLower() == hashText2.Text.ToLower())
            {
                hashText1.BackColor = Color.LawnGreen;
                hashText2.BackColor = Color.LawnGreen;
            }
            else 
            {
                hashText1.BackColor = Color.Red;
                hashText2.BackColor = Color.Red;
            }
        }

        
    }
}
