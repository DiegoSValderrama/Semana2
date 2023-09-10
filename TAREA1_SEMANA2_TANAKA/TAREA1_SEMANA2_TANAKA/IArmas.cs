using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    interface IArmas
    {
        string Nombre { get; set; }
        int Damage { get; set; }
        double VelocidadAtaque { get; set; }
        double Precio { get; set; }

        double CalcularDPS();
    }
}
