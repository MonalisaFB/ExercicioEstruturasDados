using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3TecProgramacao.OperacoesPilhas
{
    internal class Pilhas : IMenu
    {
        static void Main(string[] args)
        {
            string expressao1 = "(2+1)*80/(7-[√9 + {4² * 0}])";
            string expressao2 = "([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)";

            if(VerificarEspressao(expressao1))
                Console.WriteLine("A expressão 1 está balanceada.");
            else
                Console.WriteLine("A expressão 1 não está balanceada.");

            if (VerificarEspressao(expressao2))
                Console.WriteLine("A expressão 2 está balanceada.");
            else
                Console.WriteLine("A expressão 2 não está balanceada.");
        }

        private static bool VerificarEspressao(string expressao1)
        {
            throw new NotImplementedException();
        }

        public static bool VerificarExpressao(string expressao)
        {
            Stack<string> stack = new Stack<string>();

            foreach (string item in expressao)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if(stack.Count == 0)
                        return false;
                    string topo = stack.Pop();

                    if ((item == ')') && topo != '(' ||
                        (item == ']' && topo != '[') ||
                        (item == '}' && topo != '{')) ;
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
