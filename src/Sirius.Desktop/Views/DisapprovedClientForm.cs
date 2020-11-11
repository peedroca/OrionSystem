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
    public partial class DisapprovedClientForm : Form
    {
        CostomerRequestView CostomerView;
        private CostomerController CostomerController;
        public DisapprovedClientForm(CostomerRequestView costomerView)
        {
            InitializeComponent();
            CostomerView = costomerView;
            
        }

        private void DisapprovedClientForm_Load(object sender, EventArgs e)
        {
            
            CostomerController = new CostomerController();
            costomerTextBox.Text = CostomerView.FristName;
            label3.Text = string.Empty;

        }

        private void RefusualCostomer()
        {                                  
                CustomerRefusalModel customerRefusalModel = new CustomerRefusalModel(CostomerView.Id,
                  resonDisapprovedRichTextBox.Text,
                  CostomerView.CreateOn,
                  CostomerView.UpdatedOn,
                  CostomerView.Deleted
              );

                CostomerController.CostomerRefusal(customerRefusalModel);
            
        }

        private void resonDisapprovedButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resonDisapprovedRichTextBox.Text))
            {
                label3.Text = ("Motivo da Reprovação não Informada");
                
            }
            else
            {

                DialogResult delete = MessageBox.Show("Confirma a Rejeição do Cliente"
                    , "Rejeição"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    RefusualCostomer();
                    this.Close();
                }
            }
            
            
        }
    }
}
