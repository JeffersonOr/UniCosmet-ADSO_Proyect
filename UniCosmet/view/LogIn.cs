using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCosmet.controller;
using UniCosmet.view;

namespace UniCosmet
{
    public partial class LogIn : Form
    {
        LoginController loginController;
        ArrayList userList;
        public LogIn()
        {
            InitializeComponent();
            loginController = new LoginController(userList);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            String nickName = tb_nickName.Text;
            String password = tb_password.Text;
            bool answer = loginController.Login(nickName, password);
            if (answer) {
                MessageBox.Show("Ingresado correctamente ;)");
            }
            else {
                MessageBox.Show("Error contraseña o nombre invalidos :c");
            }
            
        }

        private void bt_signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void tb_nickName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
