using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class pessoa {
        /* estamos colocando o tipo public porque quero
        que esse atributo fique visivel para a minha classe, 
        imagine que na vida real temos alguns atributos que precisam
        ser publicos e outros atributos precisam ser privados
        */
        public string Nome;
        public int idade;

        public string Apresentar() {
            return string.Format($"olá! me chamo {Nome} e tenho {idade} anos");
        }
        /* o metodo Format retorna uma string
         * formatada e imprime no console */

        public void ApresentarNoConsole() {
            //aqui eu vou chamar no console o metodo que eu criei que é o apresentar()
            Console.WriteLine(Apresentar());
        }
    }
}
