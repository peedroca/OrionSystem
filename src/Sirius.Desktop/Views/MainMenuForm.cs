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
            clientFormControl1.BringToFront();           
            reportFormControl1.BringToFront();
            
            chartFormControl1.BringToFront();
            listCompanyFormControl11.BringToFront();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            clientFormControl1.BringToFront();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportFormControl1.BringToFront();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserAddForm form = new UserAddForm();
            form.ShowDialog();
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            chartFormControl1.BringToFront();
        }

        private void companyButton_Click(object sender, EventArgs e)
        {
           listCompanyFormControl11.BringToFront();
        }
    }
}
