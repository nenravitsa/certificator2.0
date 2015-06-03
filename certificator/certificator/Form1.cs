using System;
using System.Windows.Forms;
using sertificator;
using Sertificator;

namespace certificator
{
    public partial class Form1 : Form
    {
        private CompanyData firma;
        public Form1()
        {
            InitializeComponent();
            firma = new CompanyData("Рога и массаж");
            
        }
     
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certificator 2.0 by Denis&Irina", "About programm",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateDB c = new CreateDB();
            c.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "pdf files (*.pdf)";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

    }
}
