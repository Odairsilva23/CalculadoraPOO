using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.consoleapp
{
    class menu
    {
        public bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        public bool OpcaodeValidacao(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }

        public void Menu()
        {
            Console.WriteLine("Calculadora da Dona Maria em POO");
            Console.WriteLine("");
            Console.WriteLine("Escolha através do menu a Operação que Deseja Efetuar: ");
            Console.WriteLine("Digite 1 para Fazer uma Soma '+'. ");
            Console.WriteLine("Digite 2 para Fazer uma Subtração '-'. ");
            Console.WriteLine("Digite 3 para Fazer uma Multiplicação '*'. ");
            Console.WriteLine("Digite 4 para Fazer uma Divisão '/'. ");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas até o momento. ");
            Console.WriteLine("Digite S para sair do App.");
        }

    }
    

}
