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
    public partial class RequestCostomerForm : Form
    {
        private CostomerController CostomerController;
        public RequestCostomerForm()
        {
            InitializeComponent();
        }

        private void RequestCostomerForm_Load(object sender, EventArgs e)
        {
            CostomerController = new CostomerController();
            LoadCostomer();
        }

        private void analyzesButton_Click(object sender, EventArgs e)
        {
            var costomer = clientDataGridView?.CurrentRow?.DataBoundItem as CostomerRequestView;

            AnalyzeClientForm form = new AnalyzeClientForm(costomer);
            form.ShowDialog();
            LoadCostomer();
            this.Close();
        }

        public void LoadCostomer(long id = 0, string fristName = null)
        {
            var costomer = CostomerController.GetCustomerRequests(id, fristName).Where(w => w.costumerRefusal == null)?.ToList();

            if (costomer != null && costomer.Count() > 0)
            {
                clientDataGridView.AutoGenerateColumns = false;
                clientDataGridView.DataSource = costomer;
            }
            else
                clientDataGridView.DataSource = null;

        }
    }
}
