using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCosmet.model
{
    /*Se establece la clase user para crear sus respectivos atributos
     * y asi usarlos para almacenar la informaccion
     */
    internal class User
    {
        public String NickName { get; set; }//atributo nombre de usuario get y set para la manipulacion
        public String Password { get; set; }//atributo contraseña de usuario get y set para la manipulacion

        public User(string nickName, string password)//contructor para darle entidad al objeto
        {
            NickName = nickName;
            Password = password;
        }

    }
}
