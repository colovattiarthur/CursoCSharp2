using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.EstruturasDeControle {
    class Exerciciosifelse {
        public static void Executar() {
            /*
            Console.WriteLine("Em que ano voce nasceu");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2023 - ano;
            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Voce tem {idade} pode votar");
            } else {
            Console.WriteLine($"voce tem {idade} Nao esta apto a votar");

             }*/
            /*
             * //exercicio 2
            Console.WriteLine("qual a sua senha de acesso");
            string senha = Console.ReadLine();

            if (senha == "7tazpHvJ") {
                Console.WriteLine("Acesso permitido");
            } else {
                Console.WriteLine("acesso negado");
            } 
            */
            //Exercicio 3
            /*
            Console.WriteLine("qual a nota do aluno");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("qual a nota do aluno2");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("qual a nota do aluno3");
            double n3 = double.Parse(Console.ReadLine());
            double nota = (n1 + n2 + n3)/3;
            if (nota >= 7) {
                Console.WriteLine("Aprovado");
            }else if(nota>=5 && nota<7){
                Console.WriteLine("Reprovado");
               */

            //Exercicio 4
            Console.WriteLine("qual a sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("qual seu peso");
            double peso = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);
            if (resultado < 18.5) {
                Console.WriteLine("Abaixo do peso");
            } else if (resultado > 18.5 && resultado < 24.9) {
                Console.WriteLine("Peso normal");
            } else if (resultado > 24.9 && resultado < 29.9) {
                Console.WriteLine("acima do peso");
            } else if (resultado > 29.9 && resultado < 34.9) {
                Console.WriteLine("obesidade grau 1");
            } else if (resultado > 34.9 && resultado < 39.9) {
                Console.WriteLine("obesidade grau 2");
            } else {
                Console.WriteLine("obesidade grau 3");

            }
        }

    }

}
        