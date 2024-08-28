using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCosmet.model;

namespace UniCosmet.controller
{
    internal class LoginController
    {
        User user;
        private ArrayList userList;
        
        public LoginController(ArrayList userList) { 
            this.userList = userList;
        }
        public bool Login(String nickName, String password)
        {
            Console.WriteLine(userList.ToString());
            if (user.NickName == nickName && user.NickName == password)
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
