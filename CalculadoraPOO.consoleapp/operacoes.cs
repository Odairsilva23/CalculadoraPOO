using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.consoleapp
{
    class operacoes
    {
        public string[] operacoesRealizadas = new string[50];
        public string opcao = "";
        public double resultado = 0;
        public int OperacoesRealizadas = 0;
        public string simboloOperacao = "";
        public double primeiroNumero, segundoNumero;

        public bool OpcaodeVisualizacao(string opcao)
        {
            return opcao == "5";
        }

        public void Operacoes(string opcao, ref double resultado, double primeiroNumero, double segundoNumero, ref string simboloOperacao)
        {

            switch (opcao)
            {
                case "1":

                    resultado = primeiroNumero + segundoNumero;
                    simboloOperacao = "+";
                    Console.WriteLine("A soma dos numeros Totalizaram: " + resultado); break;
                case "2":

                    resultado = primeiroNumero - segundoNumero;
                    simboloOperacao = "-";
                    Console.WriteLine("a subtração totalizou: " + resultado); break;
                case "3":

                    resultado = primeiroNumero * segundoNumero;
                    simboloOperacao = "*";
                    Console.WriteLine("o Resultado da sua Multiplicação foi: " + resultado); break;
                case "4":

                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Atenção na Operação de Divisão do segundo numero não pode ser igual ha 0");
                        break;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    simboloOperacao = "/";
                    Console.WriteLine("O resultado da sua divisão foi : " + resultado); break;

            }
        }

    }   

}
