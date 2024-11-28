using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mascota{
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }
        public static void CrearMascota(Mascota[] mascotas, int count){
            string continua = "";
            do{
                Console.Write("Ingrese el nombre de la mascota: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la edad de la mascota: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la especie de la mascota: ");
                string especie = Console.ReadLine();

                mascotas[count] = new Mascota { Nombre = nombre, Edad = edad, Especie = especie };
                count++;
                Console.WriteLine("Mascota agregada exitosamente.");
                Console.WriteLine("Deseas seguir solicitando mas servicios?[si/no]");
                continua = Console.ReadLine();
            } while (continua == "si");
        }
        public static void EliminarMascota(Mascota[] mascotas, int count){
            Console.Write("Ingrese el numero de la mascota a eliminar: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice > 0){
                for (int i = indice; i < count - 1; i++){
                    mascotas[i] = mascotas[i + 1];
                }
                mascotas[count - 1] = null;
                count--;
                Console.WriteLine("Mascota eliminada.");
            }
        }
        public static void ListarMascotas(Mascota[] mascotas, int count){
            Console.WriteLine("--- Lista de Mascotas ---");
            for (int i = 0; i < count; i++){
                Console.WriteLine($"{i + 1}. {mascotas[i].Nombre}, {mascotas[i].Edad} años, {mascotas[i].Especie}");
            }
        }
    }
}
