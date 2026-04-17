 namespace tarea10
    {
        using System;
        using System.Collections.Generic;

        enum EstadoSolicitud
        {
            Pendiente = 0,
            EnProceso = 1,
            Completada = 2,
            Cancelada = 3
        }

        class Solicitud
        {
            public int Id { get; set; }
            public string NombreCliente { get; set; }
            public string Descripcion { get; set; }
            public EstadoSolicitud Estado { get; set; }

            public void Mostrar()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Cliente: {NombreCliente}");
                Console.WriteLine($"Descripción: {Descripcion}");
                Console.WriteLine($"Estado: {Estado}");
                Console.WriteLine("------------------------");
            }
        }

        class Program
        {
            static List<Solicitud> solicitudes = new List<Solicitud>();

            static void Main()
            {
                int opcion;

                do
                {
                    Console.WriteLine("\n------------------------");
                    Console.WriteLine("--- MENÚ ---");
                    Console.WriteLine("1. Registrar solicitud");
                    Console.WriteLine("2. Mostrar solicitudes");
                    Console.WriteLine("3. Cambiar estado");
                    Console.WriteLine("4. Buscar por ID");
                    Console.WriteLine("0. Salir");
                    Console.WriteLine("------------------------");
                    Console.WriteLine(" ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Entrada inválida.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            Registrar();
                            break;
                        case 2:
                            MostrarTodas();
                            break;
                        case 3:
                            CambiarEstado();
                            break;
                        case 4:
                            Buscar();
                            break;
                    }

                } while (opcion != 0);
            }

            static void Registrar()
            {
                Solicitud s = new Solicitud();

                Console.Write("ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("ID inválido.");
                    return;
                }

                
                if (solicitudes.Exists(x => x.Id == id))
                {
                    Console.WriteLine("Ese ID ya existe.");
                    return;
                }

                s.Id = id;

                Console.Write("Nombre cliente: ");
                s.NombreCliente = Console.ReadLine();

                Console.Write("Descripción: ");
                s.Descripcion = Console.ReadLine();

                s.Estado = EstadoSolicitud.Pendiente;

                solicitudes.Add(s);

                Console.WriteLine("✔ Solicitud registrada.");
            }

            static void MostrarTodas()
            {
                if (solicitudes.Count == 0)
                {
                    Console.WriteLine("No hay solicitudes registradas.");
                    return;
                }

                foreach (var s in solicitudes)
                {
                    s.Mostrar();
                }
            }

            static void CambiarEstado()
            {
                Console.Write("Ingrese ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("ID inválido.");
                    return;
                }

                var solicitud = solicitudes.Find(s => s.Id == id);

                if (solicitud != null)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Seleccione estado:");

                    foreach (var estado in Enum.GetValues(typeof(EstadoSolicitud)))
                    {
                        Console.WriteLine($"{(int)estado}. {estado}");
                    }

                    Console.WriteLine("------------------------");

                    if (!int.TryParse(Console.ReadLine(), out int opcion) ||
                        !Enum.IsDefined(typeof(EstadoSolicitud), opcion))
                    {
                        Console.WriteLine("Estado inválido.");
                        return;
                    }

                    solicitud.Estado = (EstadoSolicitud)opcion;

                    Console.WriteLine("✔ Estado actualizado.");
                }
                else
                {
                    Console.WriteLine("Solicitud no encontrada.");
                }
            }

            static void Buscar()
            {
                Console.Write("Ingrese ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("ID inválido.");
                    return;
                }

                var solicitud = solicitudes.Find(s => s.Id == id);

                if (solicitud != null)
                {
                    solicitud.Mostrar();
                }
                else
                {
                    Console.WriteLine("No encontrada.");
                }
            }
        }
}