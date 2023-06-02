using JogoPalavraCerta.Database;
using JogoPalavraCerta.Forms.FormsSetup;
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
        MatchSetup matchSetup;
        string palavra = "";
        string textLabelInicial = "_";

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
                CheckIfWordHasCharSelected(lblLetraSelecionada.Text[0], btn);
            }
        }

        private void CheckIfWordHasCharSelected(char letra, Button btn)
        {
            
            if (!palavra.Any(c => c == letra))
            {
                //PERDER PONTO 
                return;
            }
            ShowCharInWord(letra);
            btn.Enabled = false;

        }

        private void ShowCharInWord(char letra)
        {
            StringBuilder builder = new StringBuilder(textLabelInicial);
            for (int i = 0; i < palavra.Length; i++)
            {
                if(letra == palavra[i])
                {
                    builder[i] = letra;
                }
            }

            textLabelInicial = builder.ToString();
            lblPalavra.Text = textLabelInicial;
        }

        private void MatchScreen_VisibleChanged(object sender, EventArgs e)
        {
            palavra = PalavraSelecionada.Instance.Palavra.ToUpper();
            lblPalavra.Text = "";
            foreach (char letra in palavra)
            {
                lblPalavra.Text += "_";
            }

            textLabelInicial = lblPalavra.Text;
        }
    }
}
