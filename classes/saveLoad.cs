using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace classes
{
    public static class saveLoad
    {

        public static void saveData(List<singleEntry> dataList)
        {
            //Save data into binary file
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream("./savedData/dataSaved.sav", FileMode.Create);

            List<singleEntry> data = dataList;
            bf.Serialize(stream, data);
            stream.Close();
        }

        public static List<singleEntry> loadData()
        {
            //Open binary file and extract data
            List<singleEntry> data = new List<singleEntry>();
            if (File.Exists("./savedData/dataSaved.sav"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream stream = new FileStream("./savedData/dataSaved.sav", FileMode.Open);

                data = bf.Deserialize(stream) as List<singleEntry>;

                stream.Close();
                return data;
            }
            return data;
        } 
    }
}
