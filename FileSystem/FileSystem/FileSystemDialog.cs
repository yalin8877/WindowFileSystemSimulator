using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileSystem
{
    public partial class FileSystemDialog : Form
    {
        public FileSystemDialog()
        {
            InitializeComponent();
        }

        public SaveFileDialog saveForm = new SaveFileDialog();
        public OpenFileDialog openForm = new OpenFileDialog();

        public FileSystem filesystem = new FileSystem();

        private void NewSystemButton_Click(object sender, EventArgs e)
        {
            filesystem.initialized = true;
            int i;
            for (i = 1; i < 100; i++)
            {
                if (filesystem.Tree_space[i].IsExisting == true)
                {
                    DialogResult result = MessageBox.Show("�½�ǰ�Ƿ񱣴����е��ļ�ϵͳ��", "ѯ��", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        Save();
                        filesystem.Format();
                        refresh();
                        MessageBox.Show("�ļ�ϵͳ�½��ɹ���", "��ʾ", MessageBoxButtons.OK);
                        break;
                    }
                    else if (result == DialogResult.No)
                    {
                        filesystem.Format();
                        refresh();
                        MessageBox.Show("�ļ�ϵͳ�½��ɹ���", "��ʾ", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (i == 100)
            {
                filesystem.Format();
                refresh();
                MessageBox.Show("�ļ�ϵͳ�½��ɹ���", "��ʾ", MessageBoxButtons.OK);
            }


        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("���ȴ����ļ�ϵͳ��", "��ʾ", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("ȷ����ʽ���ļ�ϵͳ��", "ѯ��", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    filesystem.Format();
                    refresh();
                    MessageBox.Show("�ļ�ϵͳ��ʽ���ɹ���", "��ʾ", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ireturn = filesystem.NewFile(true);
            if (ireturn == -1)
            {
                MessageBox.Show("ϵͳ�ռ䲻�㣡", "��ʾ", MessageBoxButtons.OK);
            }
            else if (ireturn == 0)
            {
            }
            else
            {
                listView1.Items.Add(filesystem.Tree_space[ireturn].fcb.file_name, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ireturn = filesystem.NewFile(false);
            if (ireturn == -1)
            {
                MessageBox.Show("ϵͳ�ռ䲻�㣡", "��ʾ", MessageBoxButtons.OK);
            }
            else if (ireturn == 0)
            {
            }
            else
            {
                listView1.Items.Add(filesystem.Tree_space[ireturn].fcb.file_name, 1);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    Point p = new Point(e.X, e.Y);
                    contextMenuStrip2.Show(listView1, p);
                }
            }
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void open()
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            int filePosition = filesystem.positionInDir(fileIndex);
            if (filesystem.Tree_space[filePosition].fcb.b_IsFile == true)
            {
                filesystem.OpenFile(filePosition);
            }
            else
            {
                filesystem.OpenFolder(filePosition);
                refresh();
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.Copy(fileIndex);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.Cut(fileIndex);
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.asked = false;
            if (filesystem.Delete(fileIndex, filesystem.DirNow) == 1)
            {
                refresh();
            }
            filesystem.asked = true;
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            int filePosition = filesystem.positionInDir(fileIndex);
            if (filesystem.rename(filePosition) == 1)
            {
                listView1.Items[fileIndex].Text = filesystem.Tree_space[filePosition].fcb.file_name;
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            string property = filesystem.Property(fileIndex);
            MessageBox.Show(property, "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void refresh()
        {
            string allPath = "";
            int path = filesystem.DirNow;
            for (int i = 0; path != -1; i++)
            {
                string temp = filesystem.Tree_space[path].fcb.file_name;
                allPath = temp + "/" + allPath;
                path = filesystem.Tree_space[path].parent;
            }
            PathNow.Text = allPath;

            listView1.Items.Clear();
            for (int i = 0; i < filesystem.Tree_space[filesystem.DirNow].childrenIndex.Count; i++)
            {
                int fileindex = (int)filesystem.Tree_space[filesystem.DirNow].childrenIndex[i];
                if (filesystem.Tree_space[fileindex].fcb.b_IsFile == true)
                {
                    listView1.Items.Add(filesystem.Tree_space[fileindex].fcb.file_name, 0);
                }
                else
                {
                    listView1.Items.Add(filesystem.Tree_space[fileindex].fcb.file_name, 1);
                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("���ȴ����ļ�ϵͳ��", "��ʾ", MessageBoxButtons.OK);
            }
            else
            {
                if (filesystem.DirNow == 0)
                {
                    MessageBox.Show("�Ѿ��������Ŀ¼��", "��ʾ", MessageBoxButtons.OK);
                }
                else
                {
                    filesystem.DirNow = filesystem.Tree_space[filesystem.DirNow].parent;
                    refresh();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("���ȴ����ļ�ϵͳ��", "��ʾ", MessageBoxButtons.OK);
            }
            else
            {
                if (filesystem.Copied == -1)
                {
                    MessageBox.Show("��δѡ��Ҫճ�������ݣ�", "��ʾ", MessageBoxButtons.OK);
                }
                else
                {
                    if (filesystem.Paste(filesystem.Copied, filesystem.DirNow) == 1)
                    {
                        filesystem.Copied = -1;
                        refresh();
                    }
                }
            }
        }

        private void FileSystemDialog_Load(object sender, EventArgs e)
        {

        }

        //�����ļ�ϵͳ
        public void Save()
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("���ȴ����ļ�ϵͳ��", "��ʾ", MessageBoxButtons.OK);
            }
            else
            {
                saveForm.Filter = "fs files (*.fs)|*.fs";
                saveForm.FilterIndex = 0;
                if (saveForm.ShowDialog() == DialogResult.OK)
                {
                    string path = saveForm.FileName;
                    // System.IO.File.Create(path);
                    FileStream fs = System.IO.File.OpenWrite(path);
                    BinaryFormatter binFormatter = new BinaryFormatter();

                    binFormatter.Serialize(fs, filesystem);
                    fs.Close();
                }
            }
        }

        //�����ļ�ϵͳ����ť�¼���
        private void SaveSystemButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        //���ļ�ϵͳ
        private void OpenSystemButton_Click(object sender, EventArgs e)
        {
            try
            {
                openForm.Filter = "fs files (*.fs)|*.fs";
                openForm.FilterIndex = 0;
                if (openForm.ShowDialog() == DialogResult.OK)
                {
                    string path = openForm.FileName;
                    // System.IO.File.Create(path);
                    FileStream fs = System.IO.File.OpenRead(path);
                    BinaryFormatter binFormatter = new BinaryFormatter();

                    filesystem = (FileSystem)binFormatter.Deserialize(fs);
                    fs.Close();
                    filesystem.DirNow = 0;
                    refresh();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("�ļ�������ȷ��", "��ʾ", MessageBoxButtons.OK);
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                open();
            }
        }

        private void PathNow_TextChanged(object sender, EventArgs e)
        {

        }

    }

}