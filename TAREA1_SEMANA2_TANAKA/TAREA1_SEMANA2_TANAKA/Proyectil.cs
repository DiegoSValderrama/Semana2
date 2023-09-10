using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    public class Proyectil : IProyectil
    {
        public int DanioProyectil { get; set; }

        public Proyectil(int danioProyectil)
        {
            DanioProyectil = danioProyectil;
        }

        public int ObtenerDanioProyectil()
        {
            return DanioProyectil;
        }
    }
}
