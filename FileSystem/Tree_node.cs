using System;
using System.Collections;
using System.Text;

namespace FileSystem
{
    [Serializable]
    public class Tree_node
    {
        public Tree_node()
        {
            IsExisting = false;
            parent = -1;
        }
        public FCB fcb=new FCB();
        public bool IsExisting;

        public int parent;
        public ArrayList childrenIndex = new ArrayList();
    }
}
