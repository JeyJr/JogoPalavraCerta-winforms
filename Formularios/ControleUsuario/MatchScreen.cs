using JogoPalavraCerta.Database;
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

            string novoTexto = ValidarLetra.Instance.
                DefinirTamanhoDoTextoDaLabelPalavra(novaPalavra.Length);

            lblPalavra.Text = novoTexto;
        }

        private void btnConfirmarLetra_Click(object sender, EventArgs e)
        {
            btnSelected.Enabled = false;
            char letra = btnSelected.Text[0];

            if (!ValidarLetra.Instance.ValidarLetraSelecionada(letra))
            {
                //PERDE VIDA E CHANCE
                return;
            }

            //GANHA PONTO
            lblPalavra.Text = ValidarLetra.Instance.ExibirLetraNaPalavra(letra);
        }

    }
}
