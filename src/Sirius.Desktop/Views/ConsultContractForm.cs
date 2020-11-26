using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
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
    public partial class ConsultContractForm : Form
    {
        private SmartContractViews ContractViews;
        private SmartContractController SmartContractController;
        public ConsultContractForm(SmartContractViews smartContractViews)
        {
            InitializeComponent();

            SmartContractController = new SmartContractController();
            ContractViews = smartContractViews;
        }

        private void descriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultContractForm_Load(object sender, EventArgs e)
        {
            
            if (ContractViews == null)
            {
                MessageBox.Show("Empresa Não Tem Contratos Ativos!!");
                return;
            } 
            var contracts = SmartContractController.GetSmartContracts(ContractViews.Id) ;

            if (contracts != null)
            {
                ClearFields();
                titleRichTextBox.Text = ContractViews.Title;
                descriptionRichTextBox.Text = ContractViews.Description;
                terminationConditionRichTextBox.Text = ContractViews.TerminationCondition;
                conclusionConditionRichTextBox.Text = ContractViews.ConclusionCondition;
                valueRichTextBox.Text = Convert.ToString(ContractViews.Value);
            }
            else
            {
                MessageBox.Show("É nulo");
            }

            
        }

        private void ClearFields()
        {
            titleRichTextBox.Text = string.Empty;
            descriptionRichTextBox.Text = string.Empty;
            terminationConditionRichTextBox.Text = string.Empty;
            conclusionConditionRichTextBox.Text = string.Empty;
            valueRichTextBox.Text = string.Empty;
        }
    }
}
