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
    public partial class ConsultCustomerForm : Form
    {
        CostomerView CostomerView;
        private CostomerController CostomerController;
        public ConsultCustomerForm(CostomerView costomerView)
        {
            InitializeComponent();
            CostomerController = new CostomerController();
            CostomerView = costomerView;
        }

        private void ConsultCustomerForm_Load(object sender, EventArgs e)
        {
            CostomerController = new CostomerController();

            var costomer = CostomerController.GetCustomer(CostomerView.Id, CostomerView.FristName);

            if (costomer != null)
            {
                
                fristNameTextBox.Text = CostomerView.FristName;
                lastNameTextBox.Text = CostomerView.LastName;
                cpfMaskedTextBox.Text = CostomerView.CPF;
                birthDateMaskedTextBox.Text = Convert.ToString(CostomerView.BirthDate);
                physicalPersonPhoneMaskedTextBox.Text = CostomerView.Phone;
                emailTextBox.Text = CostomerView.Email;
                nickNameTextBox.Text = CostomerView.Nickname;
                cnpjMaskedTextBox.Text = CostomerView.CNPJ;               
            }

        }
    }
}
