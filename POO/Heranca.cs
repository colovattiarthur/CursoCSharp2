using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class Heranca {

        //criar classe CARRO

        public class Carro {
            protected readonly int VelocidadeMaxima;
            // a variavel VelocidadeMaxima sera transmitida por herança    
            // por isso que estamos usando o protected
            int VelocidadeAtual;
            // criando o construtor de carro
            public Carro(int velocidadeMaxima) {
                VelocidadeMaxima = velocidadeMaxima;

            }

            //criando metodo para acelerar o carro
            protected int AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAtual + delta;
                if (novaVelocidade < 0) {
                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAtual = VelocidadeMaxima;
                } else {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }
            public int Acelerar() {
                return AlterarVelocidade(10);
            }


            public int Frear() {
                return AlterarVelocidade(-10);
            }
        }
        //herança de Carro
        public class Uno : Carro {
            public Uno() : base(250) {
            }
        }

        public static void Executar() {
            Console.WriteLine("uno...");
            //instanciar
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine("lanborghini");
        }
        //Lanborghini carro2 = new Lanborghini();

    }

}
        
    
