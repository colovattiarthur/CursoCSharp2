using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClasseseMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
              var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadoresaritmeticos - Fundamentos" ,OperadoresAritmeticos.Executar},
                {"ExerciciosOperadores-Fundamentos",Exerciciosifelse.Executar },
                {"EstruturaSwitch-Fundamentos",EstruturaSwitch.Executar},
                {"EstruturaWhileEfor - Estruturas de controle", EstruturaWhileEfor.Executar },
                {"Exercicio -EstruturaWhileEfor", ExercicioRepeticao.Executar },
                {"Estruturaforeach-Estrutura de controle", Estruturaforeach.Executar },
                //Classes e metodos
                {"Membros - Classes e Metodos",Membros.Executar},
                {"Construtores - Classes e Metodos",Construtores.Executar},
                {"ExerciciosMetodosComRetorno- Classes e Metodos",MetodosComRetorno.Executar},
                {"MetodosEstaticos - Classes e Metodos",MetodosEstaticos.Executar},
                {"Params - Classes e Metodos ",Params.Executar },
                {"GetSet -Classes e Metodos",GetSet.Executar },
                {"GeteSetSegundoExemplo - Classes e Metodos", GeteSetSegundoExemplo.Executar },
                {"ExercicioGetSet - Classes e Metodos", ExercicioGetSet.Executar},
                {"Exercicio2GetSet - Classes e metodos", Exercicos2GetSet.Executar},
                {"ExercicioGetSet3 -Classes e Metodos", ExercicioGetSet3.Executar},
                //colecoes
                {"Array - colecoes",Arrays.Executar},
                {"Queue - colecoes",Arrays.Executar},
                {" ColecoesQueue - colecoes",ColecoesQueue.Executar },
                {"ColecoesStack -Colecoes",ColecoesStack.Executar },
                //poo - programaçao Orientada a objeto
                {"Herança - POO ",Heranca.Executar },
                {"ConstrutorThis - POO", ConstrutorThis.Executar },
                {"Encapsulamento -POO",POO.Encapsulamento.Executar},
                  {"Polimorfismo -POO",Polimorfismo.Executar },
                  { "Polimorfismo -POO",ExercicioPolimorfismo.Executar }
                   {"Abstract POO",Abstract.Executar }
              });


            central.SelecionarEExecutar();
        }
    }
}

