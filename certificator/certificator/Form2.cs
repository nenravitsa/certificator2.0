using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sertificator;
using Sertificator;

namespace certificator
{
    public partial class Form2 : Form

    {
        private CompanyData company;
        private CoServicesData services;
        private CertificatData certificat;
        public Form2()
        {
            InitializeComponent();
        }

        
        private void PutDataFirma()
        {
            nameServ.Text = company.Name;
            nameClient.Text = company.Adress;
            nameAdmin.Text = certificat.Manager;
            tel.Text = company.Phone;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PutDataFirma();
            if (CreatePDF.SelfRef != null)
            {
                CreatePDF.SelfRef.Create();
            }
        }

    }
}
