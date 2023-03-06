using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogicaNegocio
{
     public class UsuarioCLN
    {
        private UsuarioCAD objUsuarioCAD;
        

        public UsuarioCLN()
        {
            objUsuarioCAD = new UsuarioCAD();
            
        }

        public int validarUsuario(string idUsuario, string contraseña)
        {
            int miUsuario = Convert.ToInt32(idUsuario);
            int bandera = 0;
            bandera = objUsuarioCAD.validarUsuario(miUsuario, contraseña);
            return bandera;
        }

        

    }
}
