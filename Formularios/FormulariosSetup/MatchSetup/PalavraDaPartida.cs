using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Formularios.FormulariosSetup.MatchSetup
{
    public sealed class PalavraDaPartida
    {
        private static PalavraDaPartida instance = new PalavraDaPartida();
        private PalavraDaPartida() { }
        public static PalavraDaPartida Instance => instance ?? new PalavraDaPartida();


        private string palavraAtual = "";
        public string PalavraAtual { get => palavraAtual;}

        public void DefinirPalavraDaPartidaAtual(string novaPalavra)
        {
            palavraAtual = novaPalavra;
        }

    }
}
