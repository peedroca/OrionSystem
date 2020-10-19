using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sirius.Desktop.Controllers;

namespace Sirius.Desktop.Views
{
    public partial class SmartContractsFormControl : UserControl
    {
        private SmartContractController SmartContractController;

        public SmartContractsFormControl()
        {
            InitializeComponent();
            
            
        }

        private void createContractButton_Click(object sender, EventArgs e)
        {
            //CreateContractForm form = new CreateContractForm();
            //form.ShowDialog();
        }

        private void SmartContractsFormControl_Load(object sender, EventArgs e)
        {
            SmartContractController = new SmartContractController();
            LoadSmartContract();
        }
        public void LoadSmartContract(long id = 0, string title = null)
        {
            var contracts = SmartContractController.GetSmartContracts(id, title);

            if (contracts != null && contracts.Count() > 0)
            {
                smartContractGridView.AutoGenerateColumns = false;
                smartContractGridView.DataSource = contracts;
            }
            else
                smartContractGridView.DataSource = null;
        }
    }
}
