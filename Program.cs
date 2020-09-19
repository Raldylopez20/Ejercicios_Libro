using System;
using Ejercicios_Libro.Tarea_2;

namespace Ejercicios_Libro
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Ejercicio4_5 ejercicio4_5 = new Ejercicio4_5();
            Ejercicio5_4 ejercicio5_4 = new Ejercicio5_4();
            Ejercicio5_5 ejercicio5_5 = new Ejercicio5_5();
            while(menu != 6)
            {
            Console.WriteLine("1-Ejercicio 4.1");
            Console.WriteLine("2-Ejercicio 4.2");
            Console.WriteLine("3-Ejercicio 4.5");
            Console.WriteLine("4-Ejercicio 5.4");
            Console.WriteLine("5-Ejercicio 5.5");
            Console.WriteLine("6-Salir");
            Console.WriteLine("Elija una opción: ");
            menu = Convert.ToInt32(Console.ReadLine());

                switch(menu)
                {
                case 1:
                    Ejercicio4_1.Ejercicio();
                    break;
                case 2:
                    Ejercicio4_2.Ejercicio();
                    break;
                case 3:
                    ejercicio4_5.Ejercicio();
                    break;
                case 4:
                    ejercicio5_4.Ejercicio();
                    break;
                case 5:
                    ejercicio5_5.Inicializar();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opción no existe");
                    break;
                }
            }
            
        }
    }
}
