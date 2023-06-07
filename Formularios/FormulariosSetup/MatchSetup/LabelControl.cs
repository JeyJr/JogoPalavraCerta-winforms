using JogoPalavraCerta.Database.PointsSetup;
using JogoPalavraCerta.Database.TentativasSetup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Formularios.FormulariosSetup.MatchSetup
{
    public class LabelControl
    {
        private static LabelControl instance = new LabelControl();
        private LabelControl() { }
        public static LabelControl Instance => instance ?? new LabelControl();

        private Label lblMatchPoints;
        private Label lblTentativas;

        public void DefinirLabelMatchPoints(Label matchPoints)
            => lblMatchPoints = matchPoints;
        
        public void DefinirLabelTentativa(Label labelTentativa) 
            => lblTentativas = labelTentativa;

        public void AtualizarTextLblTentativas()
        {
            lblTentativas.Text = $"" +
                $"{TentativasControl.Instance.TentativasRestantes} / " +
                $"{TentativasControl.Instance.MaxTentativas}";
        }

        public void AtualizarTextLblMatchPoints()
        {
            lblMatchPoints.Text = PointsControl.Instance
                .ObterPontuacaoDaPartida()
                .ToString();
        }

        private void ConsoleTesting() => Debug.WriteLine(lblMatchPoints.Text);
    }
}
