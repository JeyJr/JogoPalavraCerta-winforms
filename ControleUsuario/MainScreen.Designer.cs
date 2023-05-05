namespace JogoPalavraCerta.ControleUsuario
{
    partial class MainScreen
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
            lblPontos = new Label();
            pictureBoxLogo = new PictureBox();
            lblPalavraCerta = new Label();
            comboBoxCategoria = new ComboBox();
            lblCategoria = new Label();
            lblDificuldade = new Label();
            comboBoxDificuldade = new ComboBox();
            btnJogar = new Button();
            lblDevByJeyJunior = new Label();
            btnGitHub = new Button();
            btnLinkedin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblPontos
            // 
            lblPontos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPontos.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPontos.Location = new Point(0, 0);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(500, 47);
            lblPontos.TabIndex = 0;
            lblPontos.Text = "Pontos: 99999999999999";
            lblPontos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.BackColor = Color.IndianRed;
            pictureBoxLogo.Location = new Point(150, 50);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // lblPalavraCerta
            // 
            lblPalavraCerta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPalavraCerta.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraCerta.Location = new Point(150, 253);
            lblPalavraCerta.Name = "lblPalavraCerta";
            lblPalavraCerta.Size = new Size(200, 33);
            lblPalavraCerta.TabIndex = 2;
            lblPalavraCerta.Text = "Palavra Certa";
            lblPalavraCerta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(150, 349);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(200, 23);
            comboBoxCategoria.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(150, 323);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(200, 23);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDificuldade
            // 
            lblDificuldade.Location = new Point(150, 372);
            lblDificuldade.Name = "lblDificuldade";
            lblDificuldade.Size = new Size(200, 23);
            lblDificuldade.TabIndex = 5;
            lblDificuldade.Text = "Dificuldade";
            lblDificuldade.TextAlign = ContentAlignment.BottomCenter;
            // 
            // comboBoxDificuldade
            // 
            comboBoxDificuldade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDificuldade.FormattingEnabled = true;
            comboBoxDificuldade.Location = new Point(150, 398);
            comboBoxDificuldade.Name = "comboBoxDificuldade";
            comboBoxDificuldade.Size = new Size(200, 23);
            comboBoxDificuldade.TabIndex = 6;
            // 
            // btnJogar
            // 
            btnJogar.Location = new Point(150, 441);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(200, 37);
            btnJogar.TabIndex = 7;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            // 
            // lblDevByJeyJunior
            // 
            lblDevByJeyJunior.Location = new Point(150, 551);
            lblDevByJeyJunior.Name = "lblDevByJeyJunior";
            lblDevByJeyJunior.Size = new Size(200, 23);
            lblDevByJeyJunior.TabIndex = 8;
            lblDevByJeyJunior.Text = "Desenvolvido por JeyJunior";
            lblDevByJeyJunior.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnGitHub
            // 
            btnGitHub.Location = new Point(250, 516);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(32, 32);
            btnGitHub.TabIndex = 9;
            btnGitHub.UseVisualStyleBackColor = true;
            // 
            // btnLinkedin
            // 
            btnLinkedin.Location = new Point(214, 516);
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.Size = new Size(32, 32);
            btnLinkedin.TabIndex = 10;
            btnLinkedin.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLinkedin);
            Controls.Add(btnGitHub);
            Controls.Add(lblDevByJeyJunior);
            Controls.Add(btnJogar);
            Controls.Add(comboBoxDificuldade);
            Controls.Add(lblDificuldade);
            Controls.Add(lblCategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(lblPalavraCerta);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblPontos);
            Name = "MainScreen";
            Size = new Size(500, 650);
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPontos;
        private PictureBox pictureBoxLogo;
        private Label lblPalavraCerta;
        private ComboBox comboBoxCategoria;
        private Label lblCategoria;
        private Label lblDificuldade;
        private ComboBox comboBoxDificuldade;
        private Button btnJogar;
        private Label lblDevByJeyJunior;
        private Button btnGitHub;
        private Button btnLinkedin;
    }
}
