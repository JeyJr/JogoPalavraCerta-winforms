using JogoPalavraCerta.Database.GameSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database.PointsSetup
{
    public class PointsControl
    {
        private static int points; 
        private const int multiplicadorPontos = 2;
        private static int pontosPorLetra = 1;

        public static void DefinirPontosPorLetra(Dificuldade dificuldade)
        {
            pontosPorLetra = (int)dificuldade * multiplicadorPontos + 1;
        }

        public static void GanharPontos()
        {
            points += pontosPorLetra;
        }

        public static int ObterPontuacao()
        {
            return points;
        }
    }
}
