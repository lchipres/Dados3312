using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Dado
    {
        static Random rnd= new Random();

        public Dado()
        {
        }

        public int lanzarDado()
        {
            int cara = 1;
            cara=rnd.Next(1, 7);
            return cara;
        }


    }
}
