using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj35347_Lampada
{
    class clsLampada
    {
        public bool VerificarLetraS(string letra)
        {
            if (letra == "n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }       

        public string verificarStatus(bool status)
        {
            if (status)
            {
                return "Status: Lâmpada ligada! ";
            }
            else
            {
                return "Status: Lâmpada desligada! ";
            }
        }

        public string verificarStatus2(bool status)
        {
            if (status)
            {
                return "Pressione alguma tecla para desligar a lâmpada. ";
            }
            else
            {
                return "Pressione alguma tecla para ligar a lâmpada. ";
            }
        }
    }
}
