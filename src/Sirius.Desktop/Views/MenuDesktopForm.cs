using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class MenuDesktopForm : Form
    {
        private CompanyController CompanyController;
        public MenuDesktopForm()
        {
            InitializeComponent();
        }
        

               
        

        
        private void btnClient_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            ListCompanyForm form1 = new ListCompanyForm();
            form1.ShowDialog();
            this.Close();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SmartContractForm form1 = new SmartContractForm();
            form1.ShowDialog();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClientForm form1 = new ClientForm();
            form1.ShowDialog();
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MenuDesktopForm_Load(object sender, EventArgs e)
        {
            
        }
        ArrayList companies = new ArrayList();

        private void ChartTest (string name = null, string cnpj = null)
        {


            
            
        

            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserForm form1 = new UserForm();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReportForm form1 = new ReportForm();
            form1.ShowDialog();
            this.Close();
        }
    }
}
