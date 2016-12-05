using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyAndIndexer
{
    class IndexerRecord
    {
        private string[] date = new string[6];
        private string[] keys = { "Author", "Publisher", "Title", "Subject", "ISBN", "Comment" };

        public string this[int idx]
        {
            set
            {
                if (idx >= 0 && idx < date.Length)
                    date[idx] = value;
            }
            get
            {
                if (idx >= 0 && idx < date.Length)
                    return date[idx];
                return null;
            }
        }

        public string this[string key]
        {
            set
            {
                int idx = findIndex(key);
                this[idx] = value;     //访问的是date
            }
            get
            {
                return this[findIndex(key)];   //访问的是date
            }
        }

        private int findIndex(string key)
        {
            for(int i = 0; i < keys.Length; i++)
            {
                if (key == keys[i])
                    return i;
            }
            return -1;
        }
    }
}
