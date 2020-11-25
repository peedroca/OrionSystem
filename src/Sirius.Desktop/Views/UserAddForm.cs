using Sirius.Desktop.Controllers;
using Sirius.Domain.Enums;
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
    public partial class UserAddForm : Form
    {
        private UserController UserController;
        public UserAddForm()
        {
            InitializeComponent();
        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {
            UserController = new UserController();
            
        }

        private void SaveUser()
        {
            try
            {
                string fullName = fullNameTextBox.Text;
                string user = nameUserTextBox.Text;
                string email = emailTextBox.Text;

                if (string.IsNullOrEmpty(fullName))
                    throw new ArgumentException("Nome deve estar Preenchido.");
                if (string.IsNullOrEmpty(user))
                    throw new ArgumentException("Nome de usuário deve estar Preenchido.");
                if (string.IsNullOrEmpty(email))
                    throw new ArgumentException("E-Mail deve estar Preenchido.");

                UserController.CreateUser(fullName, user, email);
           
                this.Close();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro: " + e.Message);
            }
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            SaveUser();
        }
    }
}
