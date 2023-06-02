using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Formularios.FormulariosSetup.MatchSetup
{
    public sealed class ValidarLetra
    {
        private static ValidarLetra instance = new ValidarLetra();

        private ValidarLetra() { }

        public static ValidarLetra Instance => instance ?? new ValidarLetra();

        private string textoDaLabelPalavra = "";

        public string DefinirTamanhoDoTextoDaLabelPalavra(int size)
        {
            textoDaLabelPalavra = "";
            for (int i = 0; i < size; i++)
            {
                textoDaLabelPalavra += "_";
            }

            return FormatarPalavraParaUI();
        }

        public bool ValidarLetraSelecionada(char letra)
        {
            string palavra = PalavraDaPartida.Instance.PalavraAtual;
            return palavra.Any(c => c == letra);
        }

        public string ExibirLetraNaPalavra(char letra)
        {
            var builder = new StringBuilder(textoDaLabelPalavra);
            string palavra = PalavraDaPartida.Instance.PalavraAtual;


            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i]) builder[i] = letra;
            }

            textoDaLabelPalavra = builder.ToString();

            return FormatarPalavraParaUI();
        }

        private string FormatarPalavraParaUI()
        {
            string stringFormatada = "";

            for (int i = 0; i < textoDaLabelPalavra.Length; i++)
            {
                if(i == textoDaLabelPalavra.Length - 1)
                {
                    stringFormatada += textoDaLabelPalavra[i];
                    break;
                }

                stringFormatada += textoDaLabelPalavra[i] + " . ";
            }

            return stringFormatada;
        }
    }
}
