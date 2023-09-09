
using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        { 
        
         Console.WriteLine("\n*****CALCULADORA DEL PROMEDIO UNIVERSITARIO*****");

            
        //Solicitando al usuario o al estudiante que ingrese las notas del primer cómputo
        Console.WriteLine("\nIngrese las notas del Primer computo");
        Console.WriteLine("\nIngrese la nota del Laboratorio 1:");
        double Lab1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota del parcial 1:");
        double Parc1 = Convert.ToDouble(Console.ReadLine());

            
        //Solicitando al usuario o al estudiante que ingrese las notas del segundo cómputo
        
        Console.WriteLine("\nIngrese las notas del Segundo computo");
        Console.WriteLine("\nIngrese la nota del Laboratorio 2:");
        double Lab2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota del parcial 2:");
        double Parc2 = Convert.ToDouble(Console.ReadLine());

         //Solicitando al usuario o al estudiante que ingrese las notas del tercer cómputo
        Console.WriteLine("\nIngrese las notas del Tercer computo");
        Console.WriteLine("\nIngrese la nota del Laboratorio 3:");
        double Lab3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota del parcial 3:");
        double Parc3 = Convert.ToDouble(Console.ReadLine());


        //Calcular el promedio 
        double PromedioLab = (Lab1 + Lab2 + Lab3) * 0.60;
        double PromedioPrc = (Parc1 + Parc2 + Parc3) * 0.40;
        double NotaFinal = (PromedioLab / 3) + (PromedioPrc /3);

        Console.WriteLine("\nSu nota final fue: " + Math.Round(NotaFinal));

        //Comparacion de la nota final

            if (NotaFinal >=7)
                {
                     Console.WriteLine("\nUsted paso la materia con excelente nota.\n");
                }

            else if (NotaFinal >=6)
                {
                    Console.WriteLine("\nUsted paso la materia con nota baja.\n");
                }

             else

                {
                    Console.WriteLine("\nUsted paso la nota menor que 6, reprobo la materia\n");
                }

            Console.ReadKey();
        }
    }
}
