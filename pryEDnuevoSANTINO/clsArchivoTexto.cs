using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregou una libreria que me permite procesar archivos 
using System.IO;

namespace pryEDnuevoSANTINO
{
    internal class clsArchivoTexto
    {
        //crreamos campo 
        public String NomArchi = "colores.txt";

        public void grabar()
        {
            //abrir archivo para escritura 
            StreamWriter ad = new StreamWriter(NomArchi);
            ad.WriteLine("hola!!");
            ad.Close();

        }

        public void grabar( String datos )
        {
            //abrir archivo para escritura 
            StreamWriter ad = new StreamWriter(NomArchi);
            ad.WriteLine( datos );
            ad.Close();

        }

    }




}

