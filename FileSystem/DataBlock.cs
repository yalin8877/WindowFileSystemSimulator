using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    [Serializable]
    public class DataBlock
    {
        public DataBlock()
        {
        }

        public char[] datablock = new char[512];
        
    }
}
