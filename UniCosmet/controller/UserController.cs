using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniCosmet.model;

namespace UniCosmet.controller
{
    internal class UserController
    {
        User user;
        public UserController() {
            
        }

        public User SignUp(String nickName, String password) {
            user = new User(nickName, password);
            return user;
        }

        public bool Login(String nickName, String password) {
            if (user.getNickName() == nickName && user.getPassword() == password) {
                return true;
            }
            else {
                return false;
            }
            
        }
    }
}
