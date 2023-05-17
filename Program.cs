using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;

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
                {"EstruturaWhileEfor - Estruturas de controle", EstruturaWhileEfor.Executar }
            });

            central.SelecionarEExecutar();
        }
    }
}



