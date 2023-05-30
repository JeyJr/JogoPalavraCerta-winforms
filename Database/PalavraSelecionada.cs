using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database
{
    public class PalavraSelecionada
    {
        private static PalavraSelecionada instance = new PalavraSelecionada();
        public static PalavraSelecionada Instance = instance ?? new PalavraSelecionada();

        public string Palavra { get; set; } = "";
    }
}
