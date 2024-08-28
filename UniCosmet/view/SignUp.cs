using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCosmet.controller;
using UniCosmet.model;

namespace UniCosmet.view
{
    internal partial class SignUp : Form
    {
        UserController userController;
        internal SignUp(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
        }

        private void bt_signUp_Click(object sender, EventArgs e)
        {
            String nickName = tb_nickName.Text;
            String password = tb_password.Text;

            User user = new User(nickName, password);
            User answer = userController.SignUp(user);
            MessageBox.Show("Registrado correctamen :)\n" + user.NickName);

        }
    }
}
