using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    public class ArmaD : Arma
    {
        public IProyectil Proyectil { get; set; }

        public ArmaD(string nombre, int damage, double velocidadAtaque, double precio, IProyectil proyectil)
            : base(nombre, damage, velocidadAtaque, precio)
        {
            Proyectil = proyectil;
        }

        public override double CalcularDPS()
        {
            return (Damage + Proyectil.ObtenerDanioProyectil()) * VelocidadAtaque;
        }
    }
}
