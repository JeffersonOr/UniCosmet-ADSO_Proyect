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
    {
        User user;
        User user1;
        public ArrayList userList { get; private set; }
        public UserController() {
            userList = new ArrayList();
        }
        public User SignUp(User user) {
            userList.Add(user);
            user1 = (User)userList[0];
            Console.WriteLine(user1.NickName);
            return user1;
        }

    }
}
