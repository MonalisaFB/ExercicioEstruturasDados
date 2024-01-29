using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula3TecProgramacao.OperacoesListas
{
    internal class Listas
    {
        public static void ExecutarOperacao()
        {

            var input = new List<string>{
            "Idiossincrasia",
            "Ambivalente",
            "Quimérica",
            "Perpendicular",
            "Efêmero",
            "Pletora",
            "Obnubilado",
            "Xilografia",
            "Quixote",
            "Inefável"
            };

            List<string> palavraCom10ouMaisletras = FiltrarPalavraCom10ouMaisletras(input);

            foreach (string srt in palavraCom10ouMaisletras)
            {
                Console.WriteLine(srt);
            }
        }

        public static List<string> FiltrarPalavraCom10ouMaisletras(List<string> listaDeString)
        {
            List<string> resultado = new List<string>();

            foreach (string srt in listaDeString)
            {
                if(srt.Length >= 10)
                {
                    resultado.Add(srt);
                }
            }
            return resultado;
        }
    }
}
