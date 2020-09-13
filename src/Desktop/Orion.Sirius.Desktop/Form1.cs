using Orion.Sirius.Shared.Models;
using Orion.Sirius.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion.Sirius.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //test
                CostumersDataGridView.DataSource = ContactService.GetContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Costumer costumer = new Costumer()
                //{
                //    Name = textBox1.Text
                //};

                //CostumerService.SaveCostumer(costumer);

                Contact contact = new Contact()
                {
                    Number = textBox1.Text
                };

                ContactService.SaveContact(contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
