using System;

namespace Ejercicios_Libro.Tarea_2
{
    public class Ejercicio4_5
    {
        private int old;
        private int young;
        private int average;
        private int quantity;
        private int age;
        public void Ejercicio()
        {         
            Console.WriteLine("Ingrese cuantas personas desea evaluar? ");
            quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"{i+1}: Ingrese la edad de la persona: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                old = young = age;
                if (age < young)
                    young = age;
                if(age > old)
                    old = age;
                
                average += age;

            }
        Console.WriteLine($"El promedio de las edades son: {average/quantity}");
        Console.WriteLine($"La edad mas joven es de: {young}");
        Console.WriteLine($"La edad mas vieja es de: {old}");
        }
    }
}