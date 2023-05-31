using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class ExercicioGetSet3 {
        class Animal {
            string nome;
            string tipo;

            public string Nome {
                get {
                    return (nome);
                }
                set {
                    nome = value;

                }

            }
            public string Tipo {
                get {
                    return tipo;
                }
                set {
                    if (tipo == "cachorro" || tipo == "gato" || tipo == "ave") {
                        tipo = value;
                    } else {
                        tipo = "ave";
                    }

                }
            }
        }

        public static void Executar() {

            Animal animal1 = new Animal();
            
            Console.WriteLine("digite o nome do animal");
            animal1.Nome = Console.ReadLine();

            Console.WriteLine("digite o tipo do animal");
            animal1.Tipo = Console.ReadLine();
            Console.WriteLine($"o nome do animal é {animal1.Nome} e o tipo é {animal1.Tipo}");



        }

    }
}








