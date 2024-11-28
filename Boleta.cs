using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boleta{
        public int Codigo { get; set; }
        public Mascota Mascota { get; set; }
        public Servicio Servicio { get; set; }
        public double Total { get; set; }
        public static void CrearBoleta(Boleta[] boletas, int count){ 
            Console.WriteLine("--- Boletas ---");
            for (int i = 0; i < count; i++){
                var boleta = boletas[i];
                Console.WriteLine($"Código: {boleta.Codigo}");
                Console.WriteLine($"Mascota: {boleta.Mascota.Nombre}");
                Console.WriteLine($"Servicios: {boleta.Servicio.Descripcion}");
                Console.WriteLine($"Total: S/ {boleta.Total}");
            }
        }
    }
}
