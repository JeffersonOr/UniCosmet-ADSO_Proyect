using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCosmet.model
{
    internal class User
    {
        public String NickName { get; set; }
        public String Password { get; set; }

        public User(string nickName, string password)
        {
            NickName = nickName;
            Password = password;
        }







        //public String getNickName() {
        //    return nickName;
        //}
        //public String getPassword() {
        //    return password;
        //}

        //public void setNickName(String nickName) {
        //    this.nickName = nickName;
        //}

        //public void setPassword(String password) { 
        //    this.password = password;
        //}

    }
}
