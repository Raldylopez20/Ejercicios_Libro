using System;

namespace Ejercicios_Libro.Tarea_2
{
    public class Ejercicio4_2
    {
        public static void Ejercicio(){
            int number,power;
            Console.WriteLine("Ingrese el numero el cual desea potenciar: ");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia: ");

            power = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine($"{number}^{power} = {Math.Pow(number, power)}");
        
        }
    }
}