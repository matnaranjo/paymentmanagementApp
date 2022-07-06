using System;
using System.Collections.Generic;

namespace classes
{
    [System.Serializable]
    public class dataBase
    {
        public List<singleEntry> allEntries { get; set; }

        public dataBase()
        {   
            //instantiate data list
            allEntries = new List<singleEntry>();
        }


        public void loadEntry(singleEntry singleData)
        {   
            //Add single enty to list
            allEntries.Add(singleData);
        }

    }
}
