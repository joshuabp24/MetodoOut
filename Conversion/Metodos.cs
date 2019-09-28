using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class Metodos
    {
        public void Convertir(int totalcentavos, out int pesos,out int centavo)
        {
            pesos = totalcentavos / 100;
            centavo = totalcentavos % 100;
        }
    }
}
