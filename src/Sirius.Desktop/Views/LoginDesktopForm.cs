using Sirius.Desktop.Controllers;
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
    public partial class LoginDesktopForm : Form
    {
        private UserController UserController;
        public LoginDesktopForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = userTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("O nome deve estar preenchido.");

                if (string.IsNullOrEmpty(password))
                    throw new ArgumentException("A senha deve estar preenchida.");

                var userModel = UserController.LoginUser(new Domain.Models.LoginUserModel(name, password));

                if(userModel == null)
                    throw new ArgumentException("Usuário e/ou senha incorreto(s).");

                this.Hide();
                MainMenuForm form1 = new MainMenuForm();
                form1.ShowDialog();
                this.Close(); //Abrir Form
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro... {ex.Message}");
            }
        }

        private void RememberButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginDesktopForm_Load(object sender, EventArgs e)
        {
            UserController = new UserController();
        }
    }
}
