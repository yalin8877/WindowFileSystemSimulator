using System;
using System.Collections;
using System.Text;

namespace FileSystem
{
    [Serializable]
    public class FCB
    {
        public FCB()
        {
            //create_date = DateTime.Now;
        }
        public string file_name;
        public bool b_IsFile;
        public DateTime create_date;
        //DateTime last_update_date;

        public ArrayList indextable = new ArrayList();
    }
}
