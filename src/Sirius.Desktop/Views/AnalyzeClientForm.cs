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
        public AnalyzeClientForm()
        {
            InitializeComponent();
        }

        private void disapprovedButton_Click(object sender, EventArgs e)
        {
            DisapprovedClientForm form = new DisapprovedClientForm();
            this.Hide();
            form.ShowDialog();
        }

        private void AnalyzeClientForm_Load(object sender, EventArgs e)
        {

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
    }
}
