using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    [System.Serializable]
    public class singleEntry
    {
        public string month { get; set; }
        public string day { get; set; }
        public string year { get; set; }
        public string description { get; set; }
        public string value { get; set; }

        public singleEntry()
        {

        }

        public void loadPayment(string inMonth, string inDay, string inYear, string inDescription, string inValue)
        {   
            //save txtBoxes values
            month = inMonth;
            day = inDay;
            year = inYear;
            description = inDescription;
            value = inValue;
        }


    }
}
