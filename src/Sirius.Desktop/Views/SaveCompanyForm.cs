using Sirius.Desktop.Controllers;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private CompanyController CompanyController;

        public SaveCompanyForm()
        {
            InitializeComponent();
        }

        private void SaveCompanyForm_Load(object sender, EventArgs e)
        {
            CompanyController = new CompanyController();
            ClearLabels();
        }

        private void ClearLabels()
        {
            nameLabel.Text = string.Empty;
            nickNameLabel.Text = string.Empty;
            phoneLabel.Text = string.Empty;
            emailLabel.Text = string.Empty;
            cnpjLabel.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ClearLabels();
            SaveCompany();
            
        }

        private void ClearFields()
        {
            fantasiaTextBox.Text = string.Empty;
            cnpjTextBox.Text = string.Empty;
            telefoneTextBox.Text = string.Empty;
            razaoSocialTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
        }

        private void SaveCompany()
        {
            CreateCompanyModel createCompanyModel = new CreateCompanyModel(razaoSocialTextBox.Text
                , fantasiaTextBox.Text
                , cnpjTextBox.Text
                , telefoneTextBox.Text
                , emailTextBox.Text);

            if (createCompanyModel.Invalid)
            {
                foreach (var item in createCompanyModel.Notifications)
                {
                    switch (item.Property)
                    {
                        case "Email":
                            emailLabel.Text = item.Message;
                            break;
                        case "CNPJ":
                            cnpjLabel.Text = item.Message;
                            break;
                        case "Razão Social":
                            nameLabel.Text = item.Message;
                            break;
                    }
                }
            }
            else
            {
                CompanyController.CreateCompany(createCompanyModel);
                ClearFields();
                this.Close();
            }
        }
    }
}
