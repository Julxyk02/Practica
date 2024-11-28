using ConsoleApp1;

Mascota[] mascotas = new Mascota[100];
Servicio[] servicios = new Servicio[100];
Boleta[] boletas = new Boleta[100];

int mascotaCount = 0, servicioCount = 0, boletaCount = 0;
string seguir = "";
int opcion;
do {
    Console.WriteLine("--- Menú Veterinaria ---");
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
        case 1: Servicio.CrearServicio(servicios, servicioCount); break;
        case 2: Servicio.EliminarServicio(servicios, servicioCount); break;
        case 3: Servicio.ListarServicios(servicios, servicioCount); break;
        case 4: Mascota.CrearMascota(mascotas, mascotaCount); break;
        case 5: Mascota.EliminarMascota(mascotas, mascotaCount); break;
        case 6: Mascota.ListarMascotas(mascotas, mascotaCount); break;
        case 7: Boleta.CrearBoleta(boletas, boletaCount); break;
        default: Console.WriteLine("Opción inválida."); break;
    }
    Console.WriteLine("Regresar al menú [si/no]");
    seguir = Console.ReadLine();
    Console.Clear();
} while (seguir == "si");
//**