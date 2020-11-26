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
using Sirius.Desktop.Models;
using System.Security.AccessControl;

namespace Sirius.Desktop.Views
{
    public partial class ClientFormControl : UserControl
    {
        private CostomerController CostomerController;
        public ClientFormControl()
        {
            InitializeComponent();
        }

        private void analyzesButton_Click(object sender, EventArgs e)
        {
            RequestCostomerForm form = new RequestCostomerForm();
            form.ShowDialog();
            LoadCostomer();
        }

        private void ClientFormControl_Load(object sender, EventArgs e)
        {
            CostomerController = new CostomerController();
            LoadCostomer();
        }
        
        private void LoadCostomer(string fristName = null, long id = 0)
        {
            var costomer = CostomerController.GetCustomer(id, fristName);

            if (costomer != null && costomer.Count() > 0)
            {
                clientDataGridView.AutoGenerateColumns = false;
                clientDataGridView.DataSource = costomer;
            }
            else
                clientDataGridView.DataSource = null;

        }

        private void ConsultCostomerButton_Click(object sender, EventArgs e)
        {
            var costomer = clientDataGridView?.CurrentRow?.DataBoundItem as CostomerView;

            ConsultCustomerForm form = new ConsultCustomerForm(costomer);
            form.ShowDialog();
            LoadCostomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            long id = 0;
            if(!string.IsNullOrEmpty(idCustomerTextBox.Text))    
                 id = Convert.ToInt64(idCustomerTextBox.Text);

            if (string.IsNullOrEmpty(idCustomerTextBox.Text.Trim()))
                LoadCostomer(fristNameTextBox.Text);
            else
                LoadCostomer(fristNameTextBox.Text, id);
        }
    }
}
