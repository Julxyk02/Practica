using ConsoleApp1;

Mascota[] mascotas = new Mascota[100];
Servicio[] servicios = new Servicio[100];
Boleta[] boletas = new Boleta[100];

int count = 0;
string seguir = "";
int opcion;
do {
    Console.WriteLine("\n--- Menú Veterinaria ---");
    Console.WriteLine("1. Crear Servicio");
    Console.WriteLine("2. Eliminar Servicio");
    Console.WriteLine("3. Listar Servicios");
    Console.WriteLine("4. Crear Mascota");
    Console.WriteLine("5. Eliminar Mascota");
    Console.WriteLine("6. Listar Mascotas");
    Console.WriteLine("7. Crear Boleta");
    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: Servicio.CrearServicio(servicios, count); break;
        case 2: Servicio.EliminarServicio(servicios, count); break;
        case 3: Servicio.ListarServicios(servicios, count); break;
        case 4: Mascota.CrearMascota(mascotas, count); break;
        case 5: Mascota.EliminarMascota(mascotas, count); break;
        case 6: Mascota.ListarMascotas(mascotas, count); break;
        case 7: Boleta.CrearBoleta(boletas, count); break;
        default: Console.WriteLine("Opción inválida."); break;
    }
    Console.WriteLine("Regresar al menú [si/no]");
    seguir = Console.ReadLine();
} while (seguir == "si");