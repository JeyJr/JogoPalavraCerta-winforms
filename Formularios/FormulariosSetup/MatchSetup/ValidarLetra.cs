using JogoPalavraCerta.Database.PointsSetup;
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

            int qtdLetrasAcertadas = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i]) 
                {
                    builder[i] = letra;
                    qtdLetrasAcertadas++;
                }
            }

            //Dar pts para o jogador
            PointsControl.Instance.GanharPontosPorLetra(qtdLetrasAcertadas);
            LabelControl.Instance.AtualizarTextLblMatchPoints();

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

        public void VerificaSeAcertouAPalavra()
        {
            string palavra = PalavraDaPartida.Instance.PalavraAtual;

            //Verificar se acertou a palavra
            if (palavra == textoDaLabelPalavra)
            {
                MessageBox.Show("VITORIA!");
                PointsControl.Instance.SalvarPontosNoArquivoDePontuacao();
                //Jogar novamente?
            }
        }
    }
}
