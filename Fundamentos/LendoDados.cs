using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar(){
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("qual sua idade?");
            // fazendo a conversao de um inteiro 
            int idade = int.Parse(Console.ReadLine());


            Console.WriteLine("qual sua altura");
            double altura = Double.Parse(Console.ReadLine());
            Console.WriteLine($"ola {nome} voce tem {idade} anos e tem {altura}");


         }
    }
}
