using System;
using System.Windows.Forms;
using Sertificator;

namespace certificator
{
    public partial class Form1 : Form
    {
        private CompanyInfo firma;
        public Form1()
        {
            InitializeComponent();
            firma = new CompanyInfo("");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
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

        private void downloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataLoadSave.LoadData(ref firma);
            DataCompany();
        }

        private void DataCompany()
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
        }
    }
}
