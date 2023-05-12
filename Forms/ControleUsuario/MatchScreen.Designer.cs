namespace JogoPalavraCerta.ControleUsuario
{
    partial class MatchScreen
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTentativas = new Label();
            progressBarTentativas = new ProgressBar();
            lblLetrasUtilizadas = new Label();
            lblPalavra = new Label();
            btnConfirmarLetra = new Button();
            lblLetraSelecionada = new Label();
            lblPontos = new Label();
            SuspendLayout();
            // 
            // lblTentativas
            // 
            lblTentativas.AutoSize = true;
            lblTentativas.Location = new Point(232, 65);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(63, 20);
            lblTentativas.TabIndex = 0;
            lblTentativas.Text = "100/100";
            // 
            // progressBarTentativas
            // 
            progressBarTentativas.Location = new Point(75, 115);
            progressBarTentativas.Margin = new Padding(3, 4, 3, 4);
            progressBarTentativas.Name = "progressBarTentativas";
            progressBarTentativas.Size = new Size(379, 13);
            progressBarTentativas.TabIndex = 1;
            // 
            // lblLetrasUtilizadas
            // 
            lblLetrasUtilizadas.AutoSize = true;
            lblLetrasUtilizadas.Location = new Point(210, 165);
            lblLetrasUtilizadas.Name = "lblLetrasUtilizadas";
            lblLetrasUtilizadas.Size = new Size(85, 20);
            lblLetrasUtilizadas.TabIndex = 2;
            lblLetrasUtilizadas.Text = "A B C D E ...";
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Location = new Point(223, 267);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(70, 20);
            lblPalavra.TabIndex = 3;
            lblPalavra.Text = "PALAVRA";
            // 
            // btnConfirmarLetra
            // 
            btnConfirmarLetra.Location = new Point(160, 456);
            btnConfirmarLetra.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarLetra.Name = "btnConfirmarLetra";
            btnConfirmarLetra.Size = new Size(198, 43);
            btnConfirmarLetra.TabIndex = 5;
            btnConfirmarLetra.Text = "Confirmar";
            btnConfirmarLetra.UseVisualStyleBackColor = true;
            // 
            // lblLetraSelecionada
            // 
            lblLetraSelecionada.AutoSize = true;
            lblLetraSelecionada.Location = new Point(232, 404);
            lblLetraSelecionada.Name = "lblLetraSelecionada";
            lblLetraSelecionada.Size = new Size(19, 20);
            lblLetraSelecionada.TabIndex = 6;
            lblLetraSelecionada.Text = "A";
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.Location = new Point(229, 21);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(92, 20);
            lblPontos.TabIndex = 7;
            lblPontos.Text = "Pontos: 0000";
            // 
            // MatchScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPontos);
            Controls.Add(lblLetraSelecionada);
            Controls.Add(btnConfirmarLetra);
            Controls.Add(lblPalavra);
            Controls.Add(lblLetrasUtilizadas);
            Controls.Add(progressBarTentativas);
            Controls.Add(lblTentativas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MatchScreen";
            Size = new Size(530, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTentativas;
        private ProgressBar progressBarTentativas;
        private Label lblLetrasUtilizadas;
        private Label lblPalavra;
        private Button btnConfirmarLetra;
        private Label lblLetraSelecionada;
        private Label lblPontos;
    }
}
