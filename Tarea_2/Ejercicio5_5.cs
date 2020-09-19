using System;

namespace Ejercicios_Libro.Tarea_2
{
    public class Ejercicio5_5
    {
        private int number;
        private string NumberLetter;

        public string numeros()
        {
            switch (number)
            {
            case 1:
                NumberLetter = " Numero Uno";
                break;
            case 2:
                NumberLetter = " Numero Dos";
                break;
            case 3:
                NumberLetter = " Numero Tres";
                break;
            case 4:
                NumberLetter = " Numero Cuatro";
                break;
            case 5:
                NumberLetter = " Numero Cinco";
                break;
            case 6:
                NumberLetter = " Numero Seis";
                break;
            case 7:
                NumberLetter = " Numero Siete";
                break;
            case 8:
                NumberLetter = " Numero Ocho";
                break;
            case 9:
                NumberLetter = " Numero Nueve";
                break;
            case 10:
                NumberLetter = " Numero Diez";
                break;
            default:
                Console.WriteLine("Error 402");
                break;

            }
            return NumberLetter;
        }

        public void Inicializar()
        {   
            number = 0;
            NumberLetter = "";
            Console.WriteLine("Ingrese un numero del 1 al 10: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10 || number < 1)
                Console.WriteLine("Miop sorry pero usted ingreso un numero no valido");
            else
                Console.WriteLine($"El numero {number} es {numeros()}");


        }
    }
}