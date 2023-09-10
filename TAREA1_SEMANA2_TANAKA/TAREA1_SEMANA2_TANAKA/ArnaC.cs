using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    public class ArmaC : Arma
    {
        public ArmaC(string nombre, int damage, double velocidadAtaque, double precio)
            : base(nombre, damage, velocidadAtaque, precio)
        {
        }

        public override double CalcularDPS()
        {
            return Damage * VelocidadAtaque;
        }
    }
}
