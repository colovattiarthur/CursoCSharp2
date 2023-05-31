using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class GetSet {
        class Cliente {

             /*o  modificador PRIVATE vai garantir 
             que somente a class Cliente vai ter acesso ao nome */
             private string nome;


            /* Entretanto havera momentos em que precisaremos tirar esse valor ou abstrair alguma informaçao 
             entao usamos GET ou SET
             GET PEGA O VALOR E O SET ENVIA O VALOR */
            
            /*GET e o SET precisam ser iguais ao nosso atributo
            *da classe Cliente porem com a primeira letra maiuscula */ 

            public string Nome {

                //aqui vamos especificar as nossas açoes
                get {
                    // para pegar o valor de NOME, eu vou usar o return
                    return nome;
                }
                set {
                   /*set vai servir para que eu envie um valor
                   entao esse value e o valor que o usuario 
                   vai me informar na outra classe */
                   nome = value;
                }
            }

        }

        public static void Executar() {
            /* Vamos instanciar um objeto da nossa classe Cliente*/
            Cliente cliente1 = new Cliente();

            /*Exemplo de GET cliente1.Nome; */

            //usando o SET para enviar uma informaçao
            cliente1.Nome = "Cleiton";
           
            Console.WriteLine(cliente1.Nome);


        }
    }
}