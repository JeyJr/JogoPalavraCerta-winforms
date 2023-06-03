using JogoPalavraCerta.Database.GameSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database.TentativasSetup
{
    public class TentativasControl
    {
        private static TentativasControl instance = new TentativasControl();
        private TentativasControl() { }
        public static TentativasControl Instance => instance ?? new TentativasControl();

        private const int multiplicadorDificuldade = 2;
        private const int multiplicadorMaxTentativas = 10;

        private int maxTentativas = 1;
        private int tentativasRestantes = 1;

        public int MaxTentativas => maxTentativas;
        public int TentativasRestantes => tentativasRestantes;


        public void DefinirNumeroDeTentativas(int indexDificuldade)
        {
            maxTentativas = multiplicadorMaxTentativas - (indexDificuldade * multiplicadorDificuldade);
            tentativasRestantes = maxTentativas;
        }

        public bool VerificarSeOJogoAcabou()
        {
            return tentativasRestantes > 0;
        }

        public void ErrouLetra()
        {
            tentativasRestantes--;
        }

    }
}
