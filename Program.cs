using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            static double caja = 200.0; // Dinero en la caja al inicio
    static List<Comida> menu = new List<Comida>
    {
        new Comida("Hamburguesa", 5.0),
        new Comida("Pizza", 6.0),
        new Comida("Papas Fritas", 2.5),
        new Comida("Hot Dog", 3.0),
        new Comida("Pollo Frito", 7.0),
        new Comida("Taco", 4.0),
        new Comida("Ensalada", 3.5),
        new Comida("Refresco", 1.5),
        new Comida("Helado", 2.0)
    };

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Ingresar una orden");
            Console.WriteLine("2. Ver dinero en la caja");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IngresarOrden();
                    break;
                case 2:
                    VerDineroEnCaja();
                    break;
                case 3:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void IngresarOrden()
    {
        double total = 0.0;
        List<Comida> orden = new List<Comida>();

        Console.WriteLine("Menú:");

        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i].Nombre} - ${menu[i].Precio}");
        }

        while (true)
        {
            Console.Write("Seleccione un número de comida (0 para finalizar la orden): ");
            int numeroComida = Convert.ToInt32(Console.ReadLine());

            if (numeroComida == 0)
            {
                break;
            }
            else if (numeroComida >= 1 && numeroComida <= menu.Count)
            {
                Comida comidaSeleccionada = menu[numeroComida - 1];
                orden.Add(comidaSeleccionada);
                total += comidaSeleccionada.Precio;
            }
            else
            {
                Console.WriteLine("Número de comida no válido.");
            }
        }

        Console.Write("Ingrese el dinero del cliente en dólares: ");
        double dineroCliente = Convert.ToDouble(Console.ReadLine());

        if (dineroCliente < total)
        {
            Console.WriteLine("El dinero del cliente es insuficiente.");
        }
        else
        {
            caja += total;
            double cambio = dineroCliente - total;
            Console.WriteLine($"Cambio a dar: ${cambio}");
            Console.WriteLine("¡Pedido registrado con éxito!");
        }
    }

    static void VerDineroEnCaja()
    {
        Console.WriteLine($"Dinero en la caja: ${caja}");
    }
}

class Comida
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Comida(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
        }
    }
}