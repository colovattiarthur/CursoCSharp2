using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            Console.WriteLine(" digite um numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro numero");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero + numero2;

            Console.WriteLine($"o resultado é {resultado} ");

            Console.WriteLine("digite uma base");
            double base1= double.Parse(Console.ReadLine());
            Console.WriteLine("digite uma altura");
            double altura = double.Parse(Console.ReadLine());

            double resultado2= (base1 * altura) / 2;

            Console.WriteLine($"o resultado é{ resultado2}");

            Console.WriteLine("digite uma nota");


        }
         
}

}
