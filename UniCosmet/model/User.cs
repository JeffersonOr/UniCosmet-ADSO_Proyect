using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCosmet.model
{
    internal class User
    {
        private String nickName { get; set; }
        private String password { get; set; }

        public User(String nickName, String password) {
            this.nickName = nickName;
            this.password = password;
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
