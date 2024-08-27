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
    public partial class SignUp : Form
    {
        UserController userController;
        public SignUp()
        {
            InitializeComponent();
        }

        private void bt_signUp_Click(object sender, EventArgs e)
        {
            String nickName = tb_nickName.Text;
            String password = tb_password.Text;
            
            //User user = userController.SignUp(nickName,password);
            User user = new User(nickName, password);
            MessageBox.Show("Registrado correctamen :)\n",
                 user.getNickName());

        }
    }
}
