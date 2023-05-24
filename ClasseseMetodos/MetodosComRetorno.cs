using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class MetodosComRetorno {

        class CalculadoraComum {

            public int Somar(int a, int b ) {
                return a + b;
            }
            public int Multiplicar (int a, int b) {
                return a * b;
            }
            public int Subtrair ( int a ,int b) {
                return a - b;
            }
        }
        public static void Executar() {

            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(27, 42);
            Console.WriteLine(resultado);

            Console.WriteLine(CalculadoraComum.Subtrair(5,18));



        }
    }
}
