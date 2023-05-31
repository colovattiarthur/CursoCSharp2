using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClasseseMetodos {
    class ExercicioGetSet {
        private class pessoa {
            private string nome;
            private int nascimento;
            private double  altura;


            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }
            }

            public int Nascimento {
                get {
                    return nascimento;
                }
                set {
                    nascimento = value;
                }
            }

            public double Altura {
                get {
                    return altura;
                }
                set {
                    altura = value;
                }
            }


            public void imprimir() {

                Console.WriteLine($"nome:  {Nome}   Altura: {altura}Nascimento: {Nascimento} ");

            }
            public int calculoidade() {

                return 2023 - nascimento;



            }
        }

        public static void Executar() {


            pessoa pessoa = new pessoa();


            pessoa.Nome = "Rodrigo";
            pessoa.Altura = 1.74;
            pessoa.Nascimento = 1994;

            Console.WriteLine($"seu nome é {pessoa.Nome} voce tem {pessoa.Altura} e nasceu em {pessoa.Nascimento}");


        }

    }
  
}




