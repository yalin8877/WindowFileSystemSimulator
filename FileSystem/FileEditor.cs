using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class FileEditor : Form
    {
        public FileEditor(string filedata)
        {
            InitializeComponent();
            FileData.Text = filedata;
        }

        public string filedata;

        private void button1_Click(object sender, EventArgs e)
        {
            filedata = this.FileData.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}