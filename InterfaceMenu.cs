using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAula3TecProgramacao.OperacoesDicionario;
using ExercicioAula3TecProgramacao.OperacoesFilas;
using ExercicioAula3TecProgramacao.OperacoesListas;
using ExercicioAula3TecProgramacao.OperacoesPilhas;


namespace ExercicioAula3TecProgramacao
{
    internal interface IMenu
    {
        class Menu
        {
            void ListarOperacoes();
            void SelecionarOperacoes();
        }
        
        internal class Menu : IMenu
        {
            static void ListarOperacoes()
            {
                Console.WriteLine("1. Operação Dicionario");
                Console.WriteLine("2. Operação Filas");
                Console.WriteLine("3. Operação Listas");
                Console.WriteLine("4. Operação Pilhas");
                Console.WriteLine("5. Sair");
            }

            static void SelecionarOperacao(int opcao)
            {
                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:Listas.ExecutarOperacao();
                        break;
                    case 4:
                        Console.WriteLine("Digite uma expressão para verificar se está balanceada:");
                        string expressao = Console.ReadLine();
                        bool estaBalanceada = Pilhas.VerificarExpressao(expressao);

                        if (estaBalanceada)
                            Console.WriteLine("A expressão está balanceada!");
                        else
                            Console.WriteLine("A expressão não está baçanceada!")
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
        
    
}
