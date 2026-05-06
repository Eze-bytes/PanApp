using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using Servicios;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsuarioMP usMP = new UsuarioMP();
            Usuario Us = new Usuario();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (usMP.Checkear_bd() == false)   // si no existe la BD
            {
                Application.Run(new Primer_ingresoFRM());

            }
            else
            {
                Application.Run(new AutenticacionFRM());   // si existe la bd se autentica
            }


        }
    }
}
