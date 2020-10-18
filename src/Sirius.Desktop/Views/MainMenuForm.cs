using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void companyButton_Click_1(object sender, EventArgs e)
        {
            listCompanyControl1.BringToFront();
        }

        private void clientButton_Click_2(object sender, EventArgs e)
        {
            clientFormControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smartContractsFormControl1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reportFormControl1.BringToFront();
        }

        private void userButton_Click_1(object sender, EventArgs e)
        {
            userFormControl1.BringToFront();
        }

        private void chartButton_Click_1(object sender, EventArgs e)
        {
            chartFormControl1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
