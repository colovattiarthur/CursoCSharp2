﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos {
    class Params {
        //usando a palavra params conseguimos criar varios tipos 
        // de parametros
        public static void Recepcionar (params string[ ] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine($"Ola {pessoa}");
            }
        }
        public static void Executar () {
            Recepcionar("Mario", "Cleiton", "Josefa", "Julia", "Rodolfo");
        }
    }
}
