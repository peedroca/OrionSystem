using Sirius.Desktop.Controllers;
using Sirius.Domain.Interfaces;
using Sirius.Service;
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
    public partial class ListCompanyForm : Form
    {
        private CompanyController CompanyController;
        public ListCompanyForm()
        {
            InitializeComponent();
        }

        private void ListCompanyForm_Load(object sender, EventArgs e)
        {
            CompanyController = new CompanyController();
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            var companies = CompanyController.GetCompanies();

            if (companies != null && companies.Count() > 0)
            {
                companiesDataGridView.AutoGenerateColumns = false;
                companiesDataGridView.DataSource = companies;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SaveCompanyForm form = new SaveCompanyForm();
            form.ShowDialog();

            LoadCompanies();

        }
       
    }
}
