using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    public abstract class Arma : IArmas
    {
        public string Nombre { get; set; }
        public int Damage { get; set; }
        public double VelocidadAtaque { get; set; }
        public double Precio { get; set; }

        public Arma(string nombre, int damage, double velocidadAtaque, double precio)
        {
            Nombre = nombre;
            Damage = damage;
            VelocidadAtaque = velocidadAtaque;
            Precio = precio;
        }

        public abstract double CalcularDPS();
    }
}
