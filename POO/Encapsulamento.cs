using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;
namespace CursoCSharp.POO {
    
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido");
            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
        }
    }
    
    class Encapsulamento {



            public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido() .MeusAcessos(); 
            new AmigoProximo() .MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();




          

        }
    }
}
