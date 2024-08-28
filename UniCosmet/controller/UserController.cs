using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCosmet.model;

namespace UniCosmet.controller
{
    internal class UserController
        /*se establece la clase controlador
         * para manejar toda la logica desde aqui
         */
    {
        User user;//objeto de tipo user para crear un usuario y almecenarlo

        public ArrayList userList;//lista para simular una base de datos
        public UserController() {
            userList = new ArrayList();
        }
        public User SignUp(User user) {//metodo signUp para crear un usuario
            userList.Add(user);
            this.user = (User)userList[0];
            Console.WriteLine(user.NickName);
            return user;
        }

        public bool Login(String nickName, String password)//metodo login para validar si es usuario ingresado es correcto
        {
            Console.WriteLine(userList.ToString());
            if (user.NickName == nickName && user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
