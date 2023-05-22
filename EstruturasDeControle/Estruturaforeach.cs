﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class Estruturaforeach {
        public static void Executar() {
            var palavra = "Banana";
            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }
            //percorrendo um array
            var alunos = new string[] { "Jose", "Cleiton", "Maria", "Josenildo" };
            foreach ( var nome in alunos) {
                Console.WriteLine(nome);
            }
        }
    }
}
