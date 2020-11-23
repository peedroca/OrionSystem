using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class CreateContractForm : Form
    {
        private CompanyView CompanyView;
        private CompanyController CompanyController;
        private SmartContractController SmartContractController;
        
        public CreateContractForm(CompanyView companyView)
        {
            InitializeComponent();
            CompanyView = companyView;
        }
        
        private void CreateContractForm_Load(object sender, EventArgs e)
        {
            CompanyController = new CompanyController();
            SmartContractController = new SmartContractController();
            ClearLabels();
        }
        
        private void addNewContractButton_Click(object sender, EventArgs e)
        {
            SaveContract();   
        }

        private void ClearFields()
        {
            titleTextBox.Text = string.Empty;
            descriptionRichTextBox.Text = string.Empty;
            terminationConditionRichTextBox.Text = string.Empty;
            conclusionConditionRichTextBox.Text = string.Empty;
            valueTextBox.Text = string.Empty;
        }
        
        private void ClearLabels()
        {
            titleLabel.Text = string.Empty;
            descriptionLabel.Text = string.Empty;
            terminationLabel.Text = string.Empty;
            conclusionConditionLabel.Text = string.Empty;
            valueLabel.Text = string.Empty;
        }
        
        private void SaveContract()
        {
            decimal valor = 0;
            
            if(!string.IsNullOrEmpty(valueTextBox.Text))
                valor = Convert.ToDecimal(valueTextBox.Text);

            var company = new CompanyModel(CompanyView.Id);                

            CreateSmartContractModel createSmartContractModel = new CreateSmartContractModel(titleTextBox.Text,
                descriptionRichTextBox.Text,
                terminationConditionRichTextBox.Text,
                conclusionConditionRichTextBox.Text,
                valor,
                company);

            if (createSmartContractModel.Invalid)
            {
                foreach(var item in createSmartContractModel.Notifications)
                {
                    switch (item.Property)
                    {
                        case "Título":
                            titleLabel.Text = item.Message;
                            break;
                        case "Descrição":
                            descriptionLabel.Text = item.Message;
                            break;
                        case "Condição de Término":
                            terminationLabel.Text = item.Message;
                            break;
                        case "Condição de Conclusão":
                            conclusionConditionLabel.Text = item.Message;
                            break;
                        case "Valor":
                            valueLabel.Text = item.Message;
                            break;                        
                    }                    
                }
            }
            else
            {
                SmartContractController.CreateSmartContract(createSmartContractModel);
                ClearFields();
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
