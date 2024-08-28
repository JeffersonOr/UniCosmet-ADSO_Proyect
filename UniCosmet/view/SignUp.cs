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
        internal SignUp()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void bt_signUp_Click(object sender, EventArgs e)
        {
            String nickName = tb_nickName.Text;//contenedor para almacenar el nombre de usuario
            String password = tb_password.Text;//contenedor para almacenar la contraseña

            User user = new User(nickName, password);//variable para almacenar el usuario
            User answer = userController.SignUp(user);//llamamos el metodo y nos devuelve el usuario
            MessageBox.Show("Registrado correctamen :)\n" + user.NickName);

        }

        private void bt_loginLog_Click(object sender, EventArgs e)
        {
            String nickName = tb_nickNameLog.Text;
            String password = tb_passwordLog.Text;
            bool answer = userController.Login(nickName, password);//validamos el login
            if (answer)
            {
                MessageBox.Show("Ingresado correctamente ;)");
            }
            else
            {
                MessageBox.Show("Error contraseña o nombre invalidos :c");
            }
        }
    }
}
