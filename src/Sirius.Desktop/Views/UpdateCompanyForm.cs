using Microsoft.Identity.Client;
using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
using Sirius.Domain.Models;
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
    public partial class UpdateCompanyForm : Form
    {
        private CompanyController CompanyController;
        private CompanyView CompanyView;

        public UpdateCompanyForm(CompanyView companyView)
        {
            InitializeComponent();

            CompanyController = new CompanyController();
            CompanyView = companyView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearLabels();
            razaoSocialTextBox.Text = CompanyView.Name;
            fantasiaTextBox.Text = CompanyView.Nickname;
            cnpjTextBox.Text = CompanyView.CNPJ;
            telefoneTextBox.Text = CompanyView.Phone;
            emailTextBox.Text = CompanyView.Email;
            inactiveCheckBox.Checked = CompanyView.Inactive;
            blockedCheckBox.Checked = CompanyView.Blocked;
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

        private void SaveCompany()
        {
            UpdateCompanyModel updateCompanyModel = new UpdateCompanyModel(CompanyView.Id, razaoSocialTextBox.Text
                , fantasiaTextBox.Text
                , cnpjTextBox.Text
                , telefoneTextBox.Text
                , emailTextBox.Text
                , inactiveCheckBox.Checked
                , blockedCheckBox.Checked);


            if (updateCompanyModel.Invalid)
            {
                foreach (var item in updateCompanyModel.Notifications)
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
                CompanyController.UpdateCompany(updateCompanyModel);
                
                this.Close();
            }
        }
    }
}
