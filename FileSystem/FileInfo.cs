using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class FileInfo : Form
    {
        public FileInfo()
        {
            InitializeComponent();
        }

        public string sreturn;
       
        private void FileInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sreturn = FileName.Text;
            if (sreturn.Length == 0)
            {
                MessageBox.Show("�ļ�������Ϊ�գ�","��ʾ",MessageBoxButtons.OK);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}