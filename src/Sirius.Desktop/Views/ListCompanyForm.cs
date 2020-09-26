using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
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

        private void companiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var company = companiesDataGridView.CurrentRow.DataBoundItem as CompanyView;

            if(company == null || company.Id == 0)
            {
                return;
            }

            UpdateCompanyForm form = new UpdateCompanyForm(company);
            form.ShowDialog();

            LoadCompanies();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var company = companiesDataGridView.CurrentRow.DataBoundItem as CompanyView;
            if (company == null || company.Id == 0)
            {
                return;
            }

            DialogResult delete = MessageBox.Show("Confirma exclusão da empresa?"
                , "Exclusão"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                CompanyController.UpdateCompany(new Domain.Models.UpdateCompanyModel(company.Id
                , company.Name
                , company.Nickname
                , company.CNPJ
                , company.Phone
                , company.Email
                , true
                , company.Blocked));

                LoadCompanies();
            }

            
        }

        private void inactivButton_Click(object sender, EventArgs e)
        {
            var company = companiesDataGridView.CurrentRow.DataBoundItem as CompanyView;
            if (company == null || company.Id == 0)
            {
                return;
            }

            DialogResult delete = MessageBox.Show("Confirma Bloqueio da empresa?"
                , "Bloqueio"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                CompanyController.UpdateCompany(new Domain.Models.UpdateCompanyModel(company.Id
                , company.Name
                , company.Nickname
                , company.CNPJ
                , company.Phone
                , company.Email
                , company.Inactive
                , true));

                LoadCompanies();
            }
        }
    }
}
