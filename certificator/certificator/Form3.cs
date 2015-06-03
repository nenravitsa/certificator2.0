using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sertificator;

namespace certificator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void PutDataServ()
        {
            nameServ.Text = company.Name;
            nameClient.Text = company.Adress;
        }
        private void button1_Click(object sender, EventArgs e)
        {
 
            DataLoadSave.SaveData(company);
        }
    }
}
