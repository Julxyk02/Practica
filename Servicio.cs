using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Servicio{
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public static void CrearServicio(Servicio[] servicios, int count){
            string continuar = "";
            do{
                Console.Write("Ingrese el servicio: ");
                string descripcion = Console.ReadLine();
                Console.Write("Ingrese el precio del servicio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                servicios[count++] = new Servicio { Descripcion = descripcion, Precio = precio };
                Console.WriteLine("Servicio agregado exitosamente.");
                Console.WriteLine("Deseas seguir solicitando mas servicios?[si/no]");
                continuar = Console.ReadLine();
            } while (continuar == "si");
        }
        public static void EliminarServicio(Servicio[] servicios, int count){
            Console.Write("Ingrese servicio a eliminar: ");
            string eliminar = Console.ReadLine();
            int indice = Array.IndexOf(servicios, eliminar);
            if (indice != -1){
                for (int i = indice; i < count - 1; i++){
                    servicios[i] = servicios[i + 1];
                }
                Array.Resize(ref servicios, count);
                count--;
                Console.WriteLine("Servicio eliminado.");
            }
        }
        public static void ListarServicios(Servicio[] servicios, int count){
            Console.WriteLine("--- Lista de Servicios ---");
            for (int i = 0; i < count; i++){
                Console.WriteLine($"{i}. {servicios[i].Descripcion} - S/ {servicios[i].Precio}");
            }
        }
    }
}
