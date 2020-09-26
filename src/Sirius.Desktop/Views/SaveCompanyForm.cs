using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
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
    public partial class SaveCompanyForm : Form
    {
        private ICompanyService companyService;

        public SaveCompanyForm()
        {
            InitializeComponent();
        }

        private void SaveCompanyForm_Load(object sender, EventArgs e)
        {
            companyService = new CompanyService(Settings.SiriusDbContext);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CreateCompanyModel createCompanyModel = new CreateCompanyModel(razaoSocialTextBox.Text
                , fantasiaTextBox.Text
                , cnpjTextBox.Text
                , telefoneTextBox.Text
                , emailTextBox.Text);

            if (createCompanyModel.Invalid)
            {
                MessageBox.Show(createCompanyModel.Notifications.First().Message);
                return;
            }
            
            var companyModel = companyService.CreateCompany(createCompanyModel);
            if (companyModel == null)
            {
                MessageBox.Show("Erro!");
            }
            else
            {
                MessageBox.Show("Empressa criada com sucesso!");
            }

        }
    }
}
