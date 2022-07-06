using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classes;
using System.IO;

namespace paymentManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dataBase workingDataBase = new dataBase();

        private void showData_Click(object sender, EventArgs e)
        {
            //update the data base everytime the user enters the showData window
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = workingDataBase.allEntries;
            //show checkpayment window and hide intro
            checkPaymentWindow.Size = addPaymentWindow.MaximumSize;
            introWindow.Size = introWindow.MinimumSize;
        }

        private void addData_Click(object sender, EventArgs e)
        {
            //show addpayment window and hide intro
            addPaymentWindow.Size = addPaymentWindow.MaximumSize;
            introWindow.Size = introWindow.MinimumSize;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   //close addpayment and show intro
            addPaymentWindow.Size = addPaymentWindow.MinimumSize;
            introWindow.Size = introWindow.MaximumSize;
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {   //close checkpayment and show intro
            checkPaymentWindow.Size = addPaymentWindow.MinimumSize;
            introWindow.Size = introWindow.MaximumSize;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get data from txt boxes and directory location
            string inputDay = datePayment.Value.Day.ToString();
            string inputMonth = datePayment.Value.Month.ToString();
            string inputYear = datePayment.Value.Year.ToString();
            string inputDescription = txtPaymentName.Text;
            string inputValue = txtValue.Text;
            string dir = "./savedData";
            //singleEntry object is created
            //singleEntry object is loaded with txt box data
            //singleEntry object is added to database list
            singleEntry workingSingleEntry = new singleEntry();
            workingSingleEntry.loadPayment(inputMonth, inputDay, inputYear, inputDescription, inputValue);
            workingDataBase.loadEntry(workingSingleEntry);
            //Condfirmation msg
            string confirmationMsg = string.Format("You have submited a new payment!\nDate: {0}/{1}/{2}\nDescription: {3}\nValue: {4}", inputMonth, inputDay, inputYear, inputDescription, inputValue);
            MessageBox.Show( confirmationMsg);
            //create folder if not created already
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            //data base is saved
            saveLoad.saveData(workingDataBase.allEntries);
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //load data
            workingDataBase.allEntries = saveLoad.loadData();
        }
    }
}
