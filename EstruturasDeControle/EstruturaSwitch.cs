using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {

            /*
            Console.WriteLine("Avalie o meu atendimento com uma nota 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota) {

                case 1:
                    Console.WriteLine("Péssimo!");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("bom!");
                    break;
                case 5:
                    Console.WriteLine("Excelente!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }
            */
            Console.WriteLine("digite um DDD");
            int.TryParse(Console.ReadLine(), out int ddd);

            switch (ddd) {
                case 61:
                    Console.WriteLine("Brasilía");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
              case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                    
            }





        }
    }
}
