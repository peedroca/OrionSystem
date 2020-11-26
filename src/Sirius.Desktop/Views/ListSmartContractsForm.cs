using Sirius.Desktop.Controllers;
using Sirius.Desktop.Models;
using Sirius.Domain.Entities;
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
    public partial class ListSmartContractsForm : Form
    {
        private CompanyView SelectedCompany;
        private SmartContractController contractController;

        public ListSmartContractsForm(CompanyView companyView)
        {
            InitializeComponent();
            SelectedCompany = companyView;
            contractController = new SmartContractController();
            
        }

        private void ListSmartContractsForm_Load(object sender, EventArgs e)
        {
            var contracts = contractController.GetSmartContracts(SelectedCompany.Id);
            
            if(contracts != null)
            {
                smartContractsDataGridView.AutoGenerateColumns = false;
                smartContractsDataGridView.DataSource = contracts;
            }
            else
                smartContractsDataGridView.DataSource = null;
            companyContractTextBox.Text = SelectedCompany.Name;
            
        }

        private void createContractButton_Click(object sender, EventArgs e)
        {
            CreateContractForm form = new CreateContractForm(SelectedCompany);
            this.Hide();
            form.ShowDialog();
            
            
        }

        private void smartContractsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultContractButton_Click(object sender, EventArgs e)
        {
            var contract = smartContractsDataGridView?.CurrentRow?.DataBoundItem as SmartContractViews;


            ConsultContractForm form = new ConsultContractForm(contract);
            form.ShowDialog();
            
        }
    }
}
