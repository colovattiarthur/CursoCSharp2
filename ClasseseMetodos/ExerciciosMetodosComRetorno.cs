using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class ExerciciosMetodosComRetorno {
        class Conversao {

            public double fahrenheit(double c) {
                return c * 1.8 + 32;

            }
            public double dólar(double a) {
                return a / 4.95;
            }
        }

        public static void Executar() {

            var conversao = new Conversao();
            double resultado = conversao.dólar(20);
            Console.WriteLine(resultado);

            double total = conversao.dólar(30);
            Console.WriteLine(total);
        }
    } 
}
