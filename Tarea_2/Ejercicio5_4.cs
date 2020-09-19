using System;

namespace Ejercicios_Libro.Tarea_2
{
    public class Ejercicio5_4
    {
        private int number;
         private int result;
        public int Factorial()
    {
        for (int i = 1; i <= number; i++)
            result *= i;
        return result;
    }

    public void Ejercicio()
    {
        number = 0;
        result = 1;

        Console.WriteLine("Ingrese el numero: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El factorial de {number} es: {Factorial()}");

    }
    }
}