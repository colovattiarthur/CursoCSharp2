using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class Membros {
        public static void Executar() {

            /*instanciando a classe Pessoa 
             * e criando um objeto  pessoa1 */

            pessoa pessoa1  = new pessoa();

            pessoa1.Nome = "Cleiton peres";
            pessoa1.idade = 22;
            //crie mais um objeto e tente exibir no console
            
            pessoa pessoa2 = new pessoa();
            pessoa2.Nome = "Enzo oliveira";
            pessoa2.idade = 16;

            // Console.WriteLine($"olá {pessoa2.Nome} voce tem {pessoa2.idade} ");
            
        }
    }
}