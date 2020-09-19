using System;

namespace Ejercicios_Libro.Tarea_2
{
    public class Ejercicio4_1
    {
        public static void Ejercicio(){
        int number = 0;
        Console.WriteLine("Ingrese el numero del cual quiere ver su tabla: ");
        number = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        Console.WriteLine($"{i} X {number} = {number*i}");        
        }
    }
}