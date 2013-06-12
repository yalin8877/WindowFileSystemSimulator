using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileSystem
{
    [Serializable]
    public class FileSystem
    {
        public FileSystem()
        {
            DirNow = 0;
            Copied = -1;
            asked = false;
            Deleted = -1;

            for (int i = 0; i < 100; i++)
            {
                Tree_space[i] = new Tree_node();
            }
            for (int i = 0; i < 500; i++)
            {
                Free_space[i] = 1;//表示空闲状态
                Data_space[i] = new DataBlock();
            }
            try
            {
                Tree_space[0].fcb.file_name = "MainDirectory";
                Tree_space[0].fcb.b_IsFile = false;
                Tree_space[0].IsExisting = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public Tree_node[] Tree_space = new Tree_node[100];
        public int[] Free_space = new int[500];
        public DataBlock[] Data_space = new DataBlock[500];

        public int DirNow;
        public int Copied;
        public bool IsCopying;
        public int Deleted;

        public bool initialized;
        public bool asked;

        //格式化文件系统
        public void Format()
        {
            DirNow = 0;
            Copied = -1;
            initialized = true;
            asked = false;
            Deleted = -1;

            for (int i = 0; i < 100; i++)
            {
                Tree_space[i] = new Tree_node();
            }
            for (int i = 0; i < 500; i++)
            {
                Free_space[i] = 1;//表示空闲状态
                Data_space[i] = new DataBlock();
            }
            try
            {
                Tree_space[0].fcb.file_name = "MainDirectory";
                Tree_space[0].fcb.b_IsFile = false;
                Tree_space[0].IsExisting = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //新建文件（文件夹）：不成功，返回-1；取消，返回0；成功，返回FCB所在位置；
        public int NewFile(bool IsFile)
        {
            if (initialized == false)
            {
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
                return 0;
            }
            int fcb_position = first_unused();
            if (fcb_position == -1)
            {
                return -1;
            }
            if (IsFile == true)
            {
                FileInfo fnForm = new FileInfo();
                if (fnForm.ShowDialog() == DialogResult.OK)
                {
                    string newname = fnForm.sreturn;
                    for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
                    {
                        int temp = (int)Tree_space[DirNow].childrenIndex[i];
                        if (Tree_space[temp].fcb.b_IsFile == true && Tree_space[temp].fcb.file_name == newname)
                        {
                            MessageBox.Show("此文件名已存在！", "提示", MessageBoxButtons.OK);
                            return 0;
                        }
                    }
                    Tree_space[fcb_position].fcb.file_name = fnForm.sreturn;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                FolderInfo dnForm = new FolderInfo();
                if (dnForm.ShowDialog() == DialogResult.OK)
                {
                    string newname = dnForm.sreturn;
                    for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
                    {
                        int temp = (int)Tree_space[DirNow].childrenIndex[i];
                        if (Tree_space[temp].fcb.b_IsFile == false && Tree_space[temp].fcb.file_name == dnForm.sreturn)
                        {
                            MessageBox.Show("此文件夹名已存在！", "提示", MessageBoxButtons.OK);
                            return 0;
                        }
                    }
                    Tree_space[fcb_position].fcb.file_name = dnForm.sreturn;
                }
                else
                {
                    return 0;
                }
            }

            Tree_space[fcb_position].IsExisting = true;
            Tree_space[fcb_position].fcb.create_date = DateTime.Now;
            Tree_space[fcb_position].fcb.b_IsFile = IsFile;
            Tree_space[fcb_position].parent = DirNow;

            Tree_space[DirNow].childrenIndex.Add(fcb_position);

            return fcb_position;
        }

        //打开文件：修改成功，返回1；修改失败，返回0；
        public int OpenFile(int filePosition)
        {
            int blockNum = Tree_space[filePosition].fcb.indextable.Count;
            string filedata = "";
            for (int i = 0; i < blockNum; i++)
            {
                int blockIndex = (int)Tree_space[filePosition].fcb.indextable[i];
                for (int j = 0; j < 512; j++)
                {
                    if (Data_space[blockIndex].datablock[j] == '\0')
                        break;
                    filedata = filedata + Data_space[blockIndex].datablock[j];
                }
            }

            FileEditor fe = new FileEditor(filedata);
            if (fe.ShowDialog() == DialogResult.OK)
            {
                int blockNumNow = fe.filedata.Length / 512;
                if (fe.filedata.Length % 512 != 0)
                {
                    blockNumNow++;
                }
                if (blockNumNow >= blockNum)
                {
                    for (int i = 0; i < blockNumNow - blockNum; i++)
                    {
                        int newDataBlock = first_free();
                        if (newDataBlock == -1)
                        {
                            MessageBox.Show("系统空间（数据块部分）不足，修改失败！", "提示", MessageBoxButtons.OK);
                            return 0;
                        }
                        else
                        {
                            Tree_space[filePosition].fcb.indextable.Add(newDataBlock);
                            Free_space[newDataBlock] = 0;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < blockNum - blockNumNow; i++)
                    {
                        int toFree = Tree_space[filePosition].fcb.indextable.Count - 1;
                        Tree_space[filePosition].fcb.indextable.RemoveAt(toFree);
                        Data_space[toFree] = new DataBlock();
                        Free_space[toFree] = 1;
                    }
                }
                for (int i = 0; i < blockNumNow; i++)
                {
                    int blockIndex = (int)Tree_space[filePosition].fcb.indextable[i];
                    for (int j = 0; j < 512; j++)
                    {
                        if (i * 512 + j >= fe.filedata.Length)
                        {
                            Data_space[blockIndex].datablock[j] = '\0';
                            continue;
                        }
                        Data_space[blockIndex].datablock[j] = fe.filedata[i * 512 + j];
                    }
                }
            }
            return 1;
        }

        //打开文件夹
        public void OpenFolder(int filePostion)
        {
            DirNow = filePostion;
        }

        //复制文件
        public void Copy(int fileIndex)
        {
            Copied = positionInDir(fileIndex);
            IsCopying = true;
        }

        //剪切文件
        public void Cut(int fileIndex)
        {
            Copied = positionInDir(fileIndex);
            IsCopying = false;
        }

        //粘贴文件（夹）：成功，返回1；失败，返回0；
        public int Paste(int filePosition, int DirNow)
        {
            if (initialized == false)
            {
                MessageBox.Show("请先创建文件系统！", "提示", MessageBoxButtons.OK);
                return 0;
            }
            if (IsCopying == true)
            {
                if (Tree_space[filePosition].fcb.b_IsFile == true)
                {
                    return CopyPasteFile(filePosition, DirNow);
                }
                else
                {
                    if (IsChild(filePosition, DirNow) == true)
                    {
                        MessageBox.Show("该文件夹不可以粘贴在自己的子目录下！", "提示", MessageBoxButtons.OK);
                        return 0;
                    }
                    for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
                    {
                        int search = (int)Tree_space[DirNow].childrenIndex[i];
                        if (Tree_space[search].fcb.b_IsFile == false && Tree_space[search].fcb.file_name == Tree_space[filePosition].fcb.file_name)
                        {
                            MessageBox.Show("文件夹名称已存在，无法粘贴！", "提示", MessageBoxButtons.OK);
                            return 0;
                        }
                    }

                    int newPosition = first_unused();
                    if (newPosition == -1)
                    {
                        MessageBox.Show("系统空间（FCB部分）不足，粘贴失败！", "提示", MessageBoxButtons.OK);
                        return 0;
                    }
                    Tree_space[newPosition].fcb = Tree_space[filePosition].fcb;
                    Tree_space[newPosition].IsExisting = true;
                    Tree_space[newPosition].parent = DirNow;
                    Tree_space[DirNow].childrenIndex.Add(newPosition);

                    for (int i = 0; i < Tree_space[filePosition].childrenIndex.Count; i++)
                    {
                        if (Paste((int)Tree_space[filePosition].childrenIndex[i], newPosition) == 0)
                        {
                            return 0;
                        }
                    }
                    return 1;
                }
            }
            else
            {
                if (IsChild(filePosition, DirNow) == true)
                {
                    MessageBox.Show("该文件夹不可以粘贴在自己的子目录下！", "提示", MessageBoxButtons.OK);
                    return 0;
                }
                return CutPaste(filePosition, DirNow);
            }
        }

        //剪切粘贴的辅助函数：成功，返回1；失败，返回0；
        public int CutPaste(int filePosition, int DirNow)
        {
            try
            {
                for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
                {
                    int search = (int)Tree_space[DirNow].childrenIndex[i];
                    if ((Tree_space[filePosition].fcb.b_IsFile == Tree_space[search].fcb.b_IsFile) && (Tree_space[search].fcb.file_name == Tree_space[filePosition].fcb.file_name))
                    {
                        if (Tree_space[search].fcb.b_IsFile == false)
                        {
                            MessageBox.Show("文件夹名称已存在，无法粘贴！", "提示", MessageBoxButtons.OK);
                            return 0;
                        }
                        else
                        {
                            if (MessageBox.Show("有名字相同的文件，是否替换？", "询问", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return 0;
                            }
                            else
                            {
                                Deleted = search;
                                break;
                            }
                        }
                    }
                }


                int oldParent = Tree_space[filePosition].parent;
                Tree_space[oldParent].childrenIndex.Remove(filePosition);

                Tree_space[DirNow].childrenIndex.Remove(Deleted);
                Tree_space[DirNow].childrenIndex.Add(filePosition);
                Tree_space[filePosition].parent = DirNow;

                if (Deleted != -1)
                {
                    int parentPosition = Tree_space[Deleted].parent;
                    Tree_space[parentPosition].childrenIndex.Remove(Deleted);
                    DeleteFile(Deleted);
                }
                Deleted = -1;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

            return 1;
        }

        //复制粘贴文件的辅助函数：成功，返回1；失败，返回0；
        public int CopyPasteFile(int filePosition, int DirNow)
        {
            for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
            {
                int search = (int)Tree_space[DirNow].childrenIndex[i];
                if (Tree_space[search].fcb.b_IsFile == true && Tree_space[search].fcb.file_name == Tree_space[filePosition].fcb.file_name)
                {
                    if (MessageBox.Show("有名字相同的文件，是否替换？", "询问", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return 0;
                    }
                    else
                    {
                        Deleted = search;
                        break;
                    }
                }
            }

            int newPosition = first_unused();
            if (newPosition == -1)
            {
                MessageBox.Show("系统空间（FCB部分）不足，粘贴失败！", "提示", MessageBoxButtons.OK);
                return 0;
            }

            int blockNum = Tree_space[filePosition].fcb.indextable.Count;
            ArrayList newBlock = new ArrayList();
            for (int i = 0; i < blockNum; i++)
            {
                int temp = first_free();
                if (temp == -1)
                {
                    MessageBox.Show("系统空间不足（数据块部分），粘贴失败！", "提示", MessageBoxButtons.OK);
                    return 0;
                }
                else
                {
                    newBlock.Add(temp);
                }
            }

            Tree_space[newPosition].IsExisting = true;
            Tree_space[newPosition].fcb.b_IsFile = Tree_space[filePosition].fcb.b_IsFile;
            Tree_space[newPosition].fcb.create_date = Tree_space[filePosition].fcb.create_date;
            Tree_space[newPosition].fcb.file_name = Tree_space[filePosition].fcb.file_name;

            for (int i = 0; i < blockNum; i++)
            {
                Free_space[(int)newBlock[i]] = 0;
                //Data_space[(int)newBlock[i]] = Data_space[(int)Tree_space[filePosition].fcb.indextable[i]];
                for (int j = 0; j < 512; j++)
                {
                    Data_space[(int)newBlock[i]].datablock[j] = Data_space[(int)Tree_space[filePosition].fcb.indextable[i]].datablock[j];
                }
                Tree_space[newPosition].fcb.indextable.Add(newBlock[i]);
            }

            Tree_space[newPosition].parent = DirNow;
            Tree_space[DirNow].childrenIndex.Add(newPosition);

            if (Deleted != -1)
            {
                int parentPosition = Tree_space[Deleted].parent;
                Tree_space[parentPosition].childrenIndex.Remove(Deleted);
                DeleteFile(Deleted);
            }
            Deleted = -1;

            return 1;
        }

        //删除文件（文件夹）：成功，返回1；失败，返回0；
        public int Delete(int fileIndex, int DirNow)
        {
            DialogResult result = new DialogResult();
            if (asked == false)
            {
                asked = true;
                result = MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.OKCancel);
            }
            if (result == DialogResult.Cancel)
            {
                return 0;
            }
            else
            {
                int filePosition = (int)Tree_space[DirNow].childrenIndex[fileIndex];
                int parentPosition = Tree_space[filePosition].parent;
                Tree_space[parentPosition].childrenIndex.RemoveAt(fileIndex);

                if (Tree_space[filePosition].fcb.b_IsFile == true)
                {
                    DeleteFile(filePosition);
                }
                else
                {
                    for (int i = 0; i < Tree_space[filePosition].childrenIndex.Count; i++)
                    {
                        Delete(i, filePosition);
                    }
                    Tree_space[filePosition] = new Tree_node();
                }
                return 1;
            }

        }

        //辅助删除文件
        public void DeleteFile(int filePosition)
        {
            int blockNum = Tree_space[filePosition].fcb.indextable.Count;
            for (int i = 0; i < blockNum; i++)
            {
                Data_space[i] = new DataBlock();
                Free_space[i] = 1;
            }
            Tree_space[filePosition] = new Tree_node();
        }

        //重命名：成功，返回1；失败，返回0；
        public int rename(int filePosition)
        {
            RenameInfo rnForm = new RenameInfo();
            if (rnForm.ShowDialog() == DialogResult.OK)
            {
                string newname = rnForm.sreturn;
                for (int i = 0; i < Tree_space[DirNow].childrenIndex.Count; i++)
                {
                    int temp = (int)Tree_space[DirNow].childrenIndex[i];
                    if (Tree_space[temp].fcb.b_IsFile == Tree_space[filePosition].fcb.b_IsFile && Tree_space[temp].fcb.file_name == newname)
                    {
                        MessageBox.Show("此名称已存在！", "提示", MessageBoxButtons.OK);
                        return 0;
                    }
                }
                Tree_space[filePosition].fcb.file_name = rnForm.sreturn;
                return 1;
            }
            return 0;
        }

        //返回文件属性
        public string Property(int fileIndex)
        {
            int filePosition = positionInDir(fileIndex);
            string property = "";
            if (Tree_space[filePosition].fcb.b_IsFile == true)
            {
                property = "文件名称：";
            }
            else
            {
                property = "文件夹名称：";
            }
            property += Tree_space[filePosition].fcb.file_name;
            property += "\n创建日期：" + Tree_space[filePosition].fcb.create_date.ToString();
            return property;
        }

        //在目录文件中查找是否有空间可存放新的树结点（FCB）：有，返回空间序号；没有，返回-1；
        public int first_unused()
        {
            int i;
            for (i = 1; i < 100; i++)
            {
                if (Tree_space[i].IsExisting == false)
                {
                    return i;
                }
            }
            return -1;
        }

        //在空闲位图中查找空闲的数据块：有，返回数据块序号；没有，返回-1；
        public int first_free()
        {
            int i;
            for (i = 0; i < 500; i++)
            {
                if (Free_space[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        //根据文件面板上文件的索引位置得到文件在目录文件中的位置
        public int positionInDir(int index)
        {
            return (int)Tree_space[DirNow].childrenIndex[index];
        }

        //判断当前目录是否是所给目录的直接或间接子目录
        public bool IsChild(int filePosition, int DirNow)
        {
            if (filePosition == DirNow)
            {
                return true;
            }
            for (int i = 0; i < Tree_space[filePosition].childrenIndex.Count; i++)
            {
                if ((int)Tree_space[filePosition].childrenIndex[i] == DirNow)
                    return true;
            }
            for (int i = 0; i < Tree_space[filePosition].childrenIndex.Count; i++)
            {
                if (IsChild((int)Tree_space[filePosition].childrenIndex[i], DirNow) == true)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
