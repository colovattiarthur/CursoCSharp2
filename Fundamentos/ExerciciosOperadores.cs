﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosOperadores
    {
        public static void Executar()
        {
            
            Console.WriteLine("digite sua nota");
            double nota1  =double.Parse(Console.ReadLine());

            Console.WriteLine("digite sua nota");
            double nota2 = double.Parse  (Console.ReadLine());

            Console.WriteLine("digite sua nota");
            double nota3  = double.Parse (Console.ReadLine());


            double resultado = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"o resultado é {resultado}");
            

             Console.WriteLine("qual sua nota?");
             double N1 = double.Parse (Console.ReadLine());

             Console.WriteLine("digite sua nota?");
             double N2 = double.Parse  (Console.ReadLine());



        }
    }
}
