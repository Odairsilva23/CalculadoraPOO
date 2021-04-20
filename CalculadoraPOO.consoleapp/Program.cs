using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.consoleapp
{

    //Requisitos//
    /*A Dona Mariana precisa de um sistema para calcular operações matemáticas simples, como adição, subtração, multiplicação e divisão.Ela gostaria também de visualizar um histórico das operações realizadas.
     * Requisito 01
        Nossa calculadora deve ter a possibilidade de somar dois números

        Requisito 02
        Nossa calculadora deve ter a possibilidade fazer várias operações de soma

        Requisito 03
        Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

        Requisito 04
        Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática

        Requisito 05
        Nossa calculadora deve validar a opções do menu

        BUG 01
        Nossa calculadora deve realizar as operações com "0"

        Requisito 06
        Nossa calculadora deve permitir visualizar as operações já realizadas
        Critérios:

        1 - A descrição da operação realizada deve aparecer assim, exemplo:
           
         2 + 2 = 410 - 5 = 5    */

    class Program
    {
        static void Main(string[] args)
        {

            
            operacoes calculadora = new operacoes();
            while (true)
            {
                calculadora.Menu();

                calculadora.opcao = Console.ReadLine();

                if (calculadora.OpcaodeValidacao(calculadora.opcao))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção escolhida é  inválida Tente Novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (calculadora.OpcaodeVisualizacao(calculadora.opcao))
                {
                    if (calculadora.OperacoesRealizadas == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Nenhuma operação foi criada até o momento.");
                        Console.ResetColor();
                    }
                    else
                    {
                        for (int i = 0; i < calculadora.operacoesRealizadas.Length; i++)
                        {
                            if (calculadora.operacoesRealizadas[i] != null)
                                Console.WriteLine(calculadora.operacoesRealizadas[i]);
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (calculadora.EhOpcaoSair(calculadora.opcao))
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                calculadora.primeiroNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                calculadora.segundoNumero = Convert.ToDouble(Console.ReadLine());

                calculadora.Operacoes(calculadora.opcao, ref calculadora.resultado, calculadora.primeiroNumero, calculadora.segundoNumero, ref calculadora.simboloOperacao);

                string operacaoRealizada =
                    calculadora.primeiroNumero.ToString() + " " + calculadora.simboloOperacao + " " +
                    calculadora.segundoNumero.ToString() + " = " + calculadora.resultado.ToString();

                calculadora.operacoesRealizadas[calculadora.OperacoesRealizadas] = operacaoRealizada;

                calculadora.OperacoesRealizadas++;

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }

        }

    }
}