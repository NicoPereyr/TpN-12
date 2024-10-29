using Global01.Entidades;

namespace Global01.Consola
{
    internal class Program
    {
        static Vendedor vendedor = new Vendedor("Kiko");

        static string archivoPublicaciones = "publicaciones.txt";
        static string archivoVentas = "ventas.txt";

        static void Main(string[] args)
        {

            while (true)
            {
                MostrarMenu();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarPublicacion();
                        break;
                    case 2:
                        RealizarVenta();
                        break;
                    case 3:
                        MostrarListado();
                        break;
                    case 4:
                        MostrarReporteVentas();
                        break;
                    case 5:
                        GuardarDatos();
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Agregar publicación");
            Console.WriteLine("2. Realizar venta");
            Console.WriteLine("3. Mostrar listado de publicaciones");
            Console.WriteLine("4. Mostrar reporte de ventas");
            Console.WriteLine("5. Salir");
        }

        static void AgregarPublicacion()
        {
            Console.WriteLine("Ingrese el título de la publicación:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de publicación (Biografía/Comic):");
            string tipo = Console.ReadLine();

            Console.WriteLine("Ingrese el stock:");
            int stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio:");
            float importe = float.Parse(Console.ReadLine());

            Publicacion nuevaPublicacion;
            if (tipo.ToLower() == "biografía")
            {
                Console.WriteLine("Ingrese el autor:");
                string autor = Console.ReadLine();
                nuevaPublicacion = new Biografia(importe, nombre, stock);
            }
            else
            {
                Console.WriteLine("Ingrese si es a color:");
                bool esColor = Console.ReadLine()!.ToLower() == "si" ? true : false;
                nuevaPublicacion = new Comic(importe,nombre,stock,esColor);
            }

            if (vendedor + nuevaPublicacion)
            {

                Console.WriteLine("Publicación agregada correctamente.");
            }
        }

        static void RealizarVenta()
        {
            Console.WriteLine("Ingrese el título del producto que desea comprar:");
            string titulo = Console.ReadLine();

            // Buscar el producto en la lista de publicaciones
            Publicacion? productoEncontrado = vendedor.GetPublicaciones().FirstOrDefault(p => p.Nombre == titulo);

            if (productoEncontrado == null)
            {
                throw new Exception("Producto no encontrado");
            }

            Console.WriteLine("Ingrese la cantidad a comprar:");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            if (cantidad > productoEncontrado.GetStock())
            {
                Console.WriteLine("No hay suficiente stock.");
                return;
            }

            if (vendedor + productoEncontrado)
            {
                Console.WriteLine("Venta realizada correctamente.");

            }
        }

        static void MostrarListado()
        {
            Console.WriteLine("Listado de publicaciones:");
            foreach (var publicacion in vendedor.GetPublicaciones())
            {
                publicacion.ObtenerInformacion();
            }
        }

        static void MostrarReporteVentas()
        {
            Console.WriteLine("Reporte de ventas:");

            foreach (var venta in Vendedor.ObtenerVentas(vendedor))
            {
                Console.WriteLine($"Título: {venta.Publicacion.Nombre}, Cantidad vendida: {venta.Cantidad}");
            }
            Console.WriteLine($"Cantidad:{Vendedor.GetCantidadVendida(vendedor)}");
            Console.WriteLine($"Total...:{Vendedor.GetTotalVentas(vendedor)}");
        }



        static void GuardarDatos()
        {
            vendedor.GuardarDatos();
            Console.WriteLine("Datos guardados!!!");
        }
    }

}
