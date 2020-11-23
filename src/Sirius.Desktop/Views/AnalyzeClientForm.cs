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
    public partial class AnalyzeClientForm : Form
    {
        CostomerRequestView CostomerViews;
        private CostomerController CostomerController;
        public AnalyzeClientForm(CostomerRequestView costomerView)
        {
            InitializeComponent();
            CostomerController = new CostomerController();
            CostomerViews = costomerView;
           
        }

        private void disapprovedButton_Click(object sender, EventArgs e)
        {
            DisapprovedClientForm form = new DisapprovedClientForm(CostomerViews);
            
            form.ShowDialog();
            this.Close();
        }

        private void AnalyzeClientForm_Load(object sender, EventArgs e)
        {
            CostomerController = new CostomerController();

            var costomer = CostomerController.GetCustomerRequests(CostomerViews.Id);

            if (costomer != null)
            {
                
                fristNameTextBox.Text = CostomerViews.FristName;
                lastNameTextBox.Text = CostomerViews.LastName;
                cpfMaskedTextBox.Text = CostomerViews.CPF;
                birthDateMaskedTextBox.Text = Convert.ToString(CostomerViews.BirthDate);
                physicalPersonPhoneMaskedTextBox.Text = CostomerViews.Phone;
                emailTextBox.Text = CostomerViews.Email;
                cnpjMaskedTextBox.Text = CostomerViews.CNPJ;
                nickNameTextBox.Text = CostomerViews.Nickname;

            }

        }

        private void fristNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void physicalPersonPhoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
        
        private void ApproveCustomers()
        {
            
            CustomerModel customerModel = new CustomerModel(CostomerViews.Id,
                fristNameTextBox.Text,
                lastNameTextBox.Text,
                nickNameTextBox.Text,
                cpfMaskedTextBox.Text,
                cnpjMaskedTextBox.Text,
                physicalPersonPhoneMaskedTextBox.Text,
                emailTextBox.Text,
                CostomerViews.BirthDate,
                CostomerViews.CreateOn,
                CostomerViews.UpdatedOn,
                CostomerViews.Deleted,
                CostomerViews.UserModel
                ) ;

            CostomerController.ApproveCustomer(customerModel);
            MessageBox.Show("Cliente Aprovado com Sucesso!");
            ClearFields();
            
        }

        private void ClearFields()
        {
            fristNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            nickNameTextBox.Text = String.Empty;
            cpfMaskedTextBox.Text = String.Empty;
            cnpjMaskedTextBox.Text = String.Empty;           
            emailTextBox.Text = String.Empty;
            birthDateMaskedTextBox.Text = String.Empty;
            physicalPersonPhoneMaskedTextBox.Text = String.Empty;     
        }

        private void approvedButton_Click(object sender, EventArgs e)
        {
            ApproveCustomers();
            
            this.Close();
        }
    }
}
