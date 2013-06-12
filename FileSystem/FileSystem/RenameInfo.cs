using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class RenameInfo : Form
    {
        public RenameInfo()
        {
            InitializeComponent();
        }

        public string sreturn;
        private void button1_Click(object sender, EventArgs e)
        {
            sreturn = Rename.Text;
            if (sreturn.Length == 0)
            {
                MessageBox.Show("名称不可为空！", "提示", MessageBoxButtons.OK);
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

        private void RenameInfo_Load(object sender, EventArgs e)
        {

        }
    }
}