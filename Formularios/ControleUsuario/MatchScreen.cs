using JogoPalavraCerta.Database.GameOver;
using JogoPalavraCerta.Database.SQL;
using JogoPalavraCerta.Database.TentativasSetup;
using JogoPalavraCerta.Formularios;
using JogoPalavraCerta.Formularios.FormulariosSetup.MatchSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


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
            if (sender is Button btn)
            {
                lblLetraSelecionada.Text = btn.Text;
                btnSelected = btn;
            }
        }

        private void MatchScreen_VisibleChanged(object sender, EventArgs e)
        {
            var novaPalavra = PalavraSelecionada.Instance.Palavra.ToUpper();
            PalavraDaPartida.Instance.DefinirPalavraDaPartidaAtual(novaPalavra);

            lblPalavra.Text = "";
            lblLetraSelecionada.Text = "_";
            lblTentativas.Text = TentativasControl.Instance.TentativasRestantes +
                "/" +
                TentativasControl.Instance.MaxTentativas;

            string novoTexto = ValidarLetra.Instance.
                DefinirTamanhoDoTextoDaLabelPalavra(novaPalavra.Length);

            lblPalavra.Text = novoTexto;
            matchSetup.ResetBtns();
        }

        private void btnConfirmarLetra_Click(object sender, EventArgs e)
        {
            btnSelected.Enabled = false;
            char letra = btnSelected.Text[0];

            if (!ValidarLetra.Instance.ValidarLetraSelecionada(letra))
            {
                TentativasControl.Instance.ErrouLetra();
                //Atualizar tentantivas
                
                GameOver.VerificarFimDeJogo();

                return;
            }

            //GANHA PONTO
            lblPalavra.Text = ValidarLetra.Instance.ExibirLetraNaPalavra(letra);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ControleInterfaces.Instance.EnableMainScreen(true);
        }
    }
}
