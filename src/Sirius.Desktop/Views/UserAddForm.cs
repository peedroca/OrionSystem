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
            long id = Convert.ToInt64(idUserTextBox.Text);
            var typeAccess = ETypeAccess.Comum;
            var typeUser = ETypeUser.Employee;
                       
            if (typeAccessComboBox.Text == "Administrador")
            {
                typeAccess = ETypeAccess.Admin;
            }
            if (typeAccessComboBox.Text == "Comum")
            {
                typeAccess = ETypeAccess.Comum;
            }
            if (typeUserComboBox.Text == "Empresa")
            {
                typeUser = ETypeUser.Company;
            }
            if (typeUserComboBox.Text == "Cliente")
            {
                typeUser = ETypeUser.Customer;
            }
            if (typeUserComboBox.Text == "Funcionario")
            {
                typeUser = ETypeUser.Employee;
            }


            UserModel userModel = new UserModel(id,
                nameUserTextBox.Text,
                passwordUserTextBox.Text,
                typeUser,
                typeAccess);
            //UserController.CreateUser(userModel);
            //ClearFields();
            this.Close();
        }

        private void ClearFields()
        {
            idUserTextBox.Text = string.Empty;
            nameUserTextBox.Text = string.Empty;
            passwordUserTextBox.Text = string.Empty;
            
        }
    }
}
