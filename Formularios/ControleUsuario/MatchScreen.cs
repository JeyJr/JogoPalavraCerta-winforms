using JogoPalavraCerta.Database.GameOver;
using JogoPalavraCerta.Database.PointsSetup;
using JogoPalavraCerta.Database.SQL;
using JogoPalavraCerta.Database.TentativasSetup;
using JogoPalavraCerta.Formularios;
using JogoPalavraCerta.Formularios.FormulariosSetup.MatchSetup;

namespace JogoPalavraCerta.ControleUsuario
{
    public partial class MatchScreen : UserControl, ICharacterClickHandler
    {
        readonly MatchSetup matchSetup;
        private Button btnSelected;


        public MatchScreen()
        {
            InitializeComponent();

            matchSetup = new MatchSetup(this, this);
        }

        public void btnSelectCharacter_Click(object? sender, EventArgs e)
        {
            btnConfirmarLetra.Enabled = true;

            if (sender is Button btn)
            {
                lblLetraSelecionada.Text = btn.Text;
                btnSelected = btn;
            }
        }

        private void MatchScreen_VisibleChanged(object sender, EventArgs e)
        {
            btnConfirmarLetra.Enabled = false;

            var novaPalavra = PalavraSelecionada.Instance.Palavra.ToUpper();
            PalavraDaPartida.Instance.DefinirPalavraDaPartidaAtual(novaPalavra);

            PointsControl.Instance.IniciarPontuancaoDaPartida();
            LabelControl.Instance.DefinirLabelTentativa(lblTentativas);
            LabelControl.Instance.DefinirLabelMatchPoints(lblPontos);

            LabelControl.Instance.AtualizarTextLblTentativas();
            LabelControl.Instance.AtualizarTextLblMatchPoints();

            lblPalavra.Text = "";
            lblLetraSelecionada.Text = "_";

            string novoTexto = ValidarLetra.Instance.
                DefinirTamanhoDoTextoDaLabelPalavra(novaPalavra.Length);

            lblPalavra.Text = novoTexto;
            matchSetup.ResetBtns();
        }

        private void btnConfirmarLetra_Click(object sender, EventArgs e)
        {
            btnSelected.Enabled = false;
            btnConfirmarLetra.Enabled = false;

            char letra = btnSelected.Text[0];

            if (!ValidarLetra.Instance.ValidarLetraSelecionada(letra))
            {
                TentativasControl.Instance.ErrouLetra();
                //Atualizar tentantivas
                
                GameOver.VerificarFimDeJogo();

                return;
            }

            
            lblPalavra.Text = ValidarLetra.Instance.ExibirLetraNaPalavra(letra);

            ValidarLetra.Instance.VerificaSeAcertouAPalavra();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ControleInterfaces.Instance.EnableMainScreen(true);
        }
    }
}
