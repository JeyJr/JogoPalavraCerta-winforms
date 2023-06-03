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
            lblPalavra = new Label();
            btnConfirmarLetra = new Button();
            lblLetraSelecionada = new Label();
            lblPontos = new Label();
            btnVoltar = new Button();
            lblTitleTentativas = new Label();
            SuspendLayout();
            // 
            // lblTentativas
            // 
            lblTentativas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTentativas.ImageAlign = ContentAlignment.BottomRight;
            lblTentativas.Location = new Point(320, 97);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(132, 40);
            lblTentativas.TabIndex = 0;
            lblTentativas.Text = "100/100";
            lblTentativas.TextAlign = ContentAlignment.BottomRight;
            // 
            // progressBarTentativas
            // 
            progressBarTentativas.Location = new Point(73, 141);
            progressBarTentativas.Margin = new Padding(3, 4, 3, 4);
            progressBarTentativas.Name = "progressBarTentativas";
            progressBarTentativas.Size = new Size(379, 13);
            progressBarTentativas.TabIndex = 1;
            // 
            // lblPalavra
            // 
            lblPalavra.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavra.Location = new Point(0, 158);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(530, 121);
            lblPalavra.TabIndex = 3;
            lblPalavra.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            lblPalavra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmarLetra
            // 
            btnConfirmarLetra.Location = new Point(161, 461);
            btnConfirmarLetra.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarLetra.Name = "btnConfirmarLetra";
            btnConfirmarLetra.Size = new Size(198, 43);
            btnConfirmarLetra.TabIndex = 5;
            btnConfirmarLetra.Text = "Confirmar";
            btnConfirmarLetra.UseVisualStyleBackColor = true;
            btnConfirmarLetra.Click += btnConfirmarLetra_Click;
            // 
            // lblLetraSelecionada
            // 
            lblLetraSelecionada.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblLetraSelecionada.Location = new Point(0, 402);
            lblLetraSelecionada.Name = "lblLetraSelecionada";
            lblLetraSelecionada.Size = new Size(530, 55);
            lblLetraSelecionada.TabIndex = 6;
            lblLetraSelecionada.Text = "_";
            lblLetraSelecionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPontos
            // 
            lblPontos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos.Location = new Point(0, 35);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(530, 37);
            lblPontos.TabIndex = 7;
            lblPontos.Text = "00000000";
            lblPontos.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(3, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Início";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblTitleTentativas
            // 
            lblTitleTentativas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleTentativas.ImageAlign = ContentAlignment.BottomRight;
            lblTitleTentativas.Location = new Point(73, 97);
            lblTitleTentativas.Name = "lblTitleTentativas";
            lblTitleTentativas.Size = new Size(132, 40);
            lblTitleTentativas.TabIndex = 9;
            lblTitleTentativas.Text = "Tentativas:";
            lblTitleTentativas.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MatchScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitleTentativas);
            Controls.Add(btnVoltar);
            Controls.Add(lblPontos);
            Controls.Add(lblLetraSelecionada);
            Controls.Add(btnConfirmarLetra);
            Controls.Add(lblPalavra);
            Controls.Add(progressBarTentativas);
            Controls.Add(lblTentativas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MatchScreen";
            Size = new Size(530, 650);
            VisibleChanged += MatchScreen_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTentativas;
        private ProgressBar progressBarTentativas;
        private Label lblPalavra;
        private Button btnConfirmarLetra;
        private Label lblLetraSelecionada;
        private Label lblPontos;
        private Button btnVoltar;
        private Label lblTitleTentativas;
    }
}
