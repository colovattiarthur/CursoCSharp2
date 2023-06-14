using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class ExercicioPolimorfismo {

        public class Cliente {

            public string Nome;
            public string tipo;
        }
        public class Fisico : Cliente { }
        public string Cpf;

        public class Juridico : Cliente {
            public string Cnpj;
        }

        public static void Executar() {
            Cliente pessoa = new Cliente();
            Fisico pessoa1 = new Fisico();
            Juridico pessoa2 = new Juridico();
            Console.WriteLine("Escreva se voce é fisico ou juridico");
            pessoa.tipo = Console.ReadLine();
           if (pessoa.tipo == "Juridico") {
                Console.WriteLine("Digite seu cnpj");
                pessoa2.Cnpj = Console.ReadLine();
                Console.WriteLine($"Seu cnpj é {pessoa2.Cnpj}");
            else (pessoa1.tipo == "Fisico"){
                    Console.WriteLine("Digite seu cpf");
                    pessoa2.Cnpj = Console.ReadLine();
                    Console.WriteLine($"Seu cpf é {pessoa1.tipo}");
                    }
                }
             }
            

