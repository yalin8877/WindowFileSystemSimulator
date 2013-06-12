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
                    DialogResult result = MessageBox.Show("新建前是否保存现有的文件系统？", "询问", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        Save();
                        filesystem.Format();
                        refresh();
                        MessageBox.Show("文件系统新建成功！", "提示", MessageBoxButtons.OK);
                        break;
                    }
                    else if (result == DialogResult.No)
                    {
                        filesystem.Format();
                        refresh();
                        MessageBox.Show("文件系统新建成功！", "提示", MessageBoxButtons.OK);
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
                MessageBox.Show("文件系统新建成功！", "提示", MessageBoxButtons.OK);
            }


        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("确定格式化文件系统？", "询问", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    filesystem.Format();
                    refresh();
                    MessageBox.Show("文件系统格式化成功！", "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ireturn = filesystem.NewFile(true);
            if (ireturn == -1)
            {
                MessageBox.Show("系统空间不足！", "提示", MessageBoxButtons.OK);
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
                MessageBox.Show("系统空间不足！", "提示", MessageBoxButtons.OK);
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

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.Copy(fileIndex);
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.Cut(fileIndex);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            filesystem.asked = false;
            if (filesystem.Delete(fileIndex, filesystem.DirNow) == 1)
            {
                refresh();
            }
            filesystem.asked = true;
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            int filePosition = filesystem.positionInDir(fileIndex);
            if (filesystem.rename(filePosition) == 1)
            {
                listView1.Items[fileIndex].Text = filesystem.Tree_space[filePosition].fcb.file_name;
            }
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fileIndex = listView1.SelectedItems[0].Index;
            string property = filesystem.Property(fileIndex);
            MessageBox.Show(property, "属性", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (filesystem.DirNow == 0)
                {
                    MessageBox.Show("已经到达最顶层目录！", "提示", MessageBoxButtons.OK);
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
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (filesystem.Copied == -1)
                {
                    MessageBox.Show("还未选择要粘贴的内容！", "提示", MessageBoxButtons.OK);
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

        //保存文件系统
        public void Save()
        {
            if (filesystem.initialized == false)
            {
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
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

        //保存文件系统（按钮事件）
        private void SaveSystemButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        //打开文件系统
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
                MessageBox.Show("文件名不正确！", "提示", MessageBoxButtons.OK);
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