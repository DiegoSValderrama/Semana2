using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IArmas> inventario = new List<IArmas>();
            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Agregar arco:");
                Console.WriteLine("3. Agregar flecha:");
                Console.WriteLine("4. Agregar pistola:");
                Console.WriteLine("5. Agregar bala:");
                Console.WriteLine("6. Agregar daga:");
                Console.WriteLine("7.Eliminar arma:");
                Console.WriteLine("8.Salir:");
                Console.WriteLine("Selecciona:");

                if (int. TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            VerInventario(inventario);
                            break;
                        case 2:
                            AgregarArco(inventario);
                            break;
                        case 3:
                            AgregarFlecha(inventario);
                            break;
                        case 4:
                            AgregarPistola(inventario);
                            break;
                        case 5:
                            AgregarBala(inventario);
                            break;
                        case 6:
                            AgregarDaga(inventario);
                            break;
                        case 7:
                            EliminarArma(inventario);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Función no encontrada, vuelva a intentar");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Función no encontrada, vuelva a intentar");
                }
            }
        }
        static void AgregarDaga (List<IArmas> inventario)
        {
            Console.WriteLine("Nombre del objeto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Daño del objeto: ");
            int damage = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Velocidad de ataque de objeto: ");
            double velocidadAtaque = double.Parse(Console.ReadLine());

            Console.WriteLine("Precio del objeto: ");
            double precio =double.Parse(Console.ReadLine());

            ArmaC daga = new ArmaC(nombre, damage, velocidadAtaque, precio);
            inventario.Add(daga);

            Console.WriteLine($"Daga '{nombre}' agregado");
        }
        static void AgregarArco(List<IArmas> inventario)
        {
            Console.WriteLine("Nombre del objeto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Daño del objeto: ");
            int damage = int.Parse(Console.ReadLine());

            Console.WriteLine("Velocidad de ataque de objeto: ");
            double velocidadAtaque = double.Parse(Console.ReadLine());

            Console.WriteLine("Precio del objeto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Nombre de la flecha: ");
            string nombreProyectil = Console.ReadLine();

            Console.Write("Daño de la flecha: ");
            int damageProyectil = int.Parse(Console.ReadLine());

            IProyectil flecha = new Proyectil(damageProyectil);
            ArmaD arco = new ArmaD(nombre, damage, velocidadAtaque, precio, flecha);
            inventario.Add(arco);

            Console.WriteLine($"Arco '{nombre}' con flecha '{nombreProyectil}' agregado al inventario.");
        }

        static void AgregarPistola(List<IArmas> inventario)
        {
            Console.Write("Nombre del objeto: ");
            string nombre = Console.ReadLine();

            Console.Write("Daño del objeto: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("Velocidad del objeto ");
            double velocidadAtaque = double.Parse(Console.ReadLine());

            Console.Write("Precio del objeto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Nombre de la bala: ");
            string nombreProyectil = Console.ReadLine();

            Console.Write("Daño de la bala: ");
            int damageProyectil = int.Parse(Console.ReadLine());

            IProyectil bala = new Proyectil(damageProyectil);
            ArmaD pistola = new ArmaD(nombre, damage, velocidadAtaque, precio, bala);
            inventario.Add(pistola);

            Console.WriteLine($"Pistola '{nombre}' con bala '{nombreProyectil}' agregada al inventario.");
        }
        static void AgregarFlecha(List<IArmas> inventario)
        {
            Console.Write("Nombre del objeto: ");
            string nombre = Console.ReadLine();

            Console.Write("Daño del objeto: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("Velocidad del objeto: ");
            double velocidadAtaque = double.Parse(Console.ReadLine());

            Console.Write("Precio de la flecha: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Nombre del arco que dispara la flecha: ");
            string nombreArma = Console.ReadLine();

            ArmaD flecha = new ArmaD(nombreArma, damage, velocidadAtaque, precio, new Proyectil(0));
            inventario.Add(flecha);

            Console.WriteLine($"Flecha '{nombre}' para el arco '{nombreArma}' agregada al inventario.");
        }
        static void AgregarBala(List<IArmas> inventario)
        {
            Console.Write("Nombre del objeto: ");
            string nombre = Console.ReadLine();

            Console.Write("Daño del objeto: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("Velocidad del objeto: ");
            double velocidadAtaque = double.Parse(Console.ReadLine());

            Console.Write("Precio de la bala: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Nombre de la pistola que dispara la bala: ");
            string nombreArma = Console.ReadLine();

            ArmaD bala = new ArmaD(nombreArma, damage, velocidadAtaque, precio, new Proyectil(0));
            inventario.Add(bala);

            Console.WriteLine($"Bala '{nombre}' para la pistola '{nombreArma}' agregada al inventario.");
        }
        static void VerInventario(List<IArmas> inventario)
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("Inventario vacío.");
            }
            else
            {
                Console.WriteLine("Inventario:");

                for (int i = 0; i < inventario.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventario[i].Nombre} (DPS: {inventario[i].CalcularDPS()}, Precio: {inventario[i].Precio})");
                }
            }
        }
        static void EliminarArma(List<IArmas> inventario)
        {
            VerInventario(inventario);

            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay armas para eliminar.");
                return;
            }

            Console.Write("Seleccione el número de arma que desea eliminar: ");

            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= inventario.Count)
            {
                string nombreArmaEliminada = inventario[seleccion - 1].Nombre;
                inventario.RemoveAt(seleccion - 1);
                Console.WriteLine($"Se ha eliminado '{nombreArmaEliminada}' del inventario.");
            }
            else
            {
                Console.WriteLine("Selección no válida. Intente nuevamente.");
            }
        }
    }
}
