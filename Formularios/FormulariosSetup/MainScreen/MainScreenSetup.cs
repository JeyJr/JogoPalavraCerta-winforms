using JogoPalavraCerta.Database.GameSetup;
using JogoPalavraCerta.Database.PointsSetup;
using JogoPalavraCerta.Database.SQL;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

namespace JogoPalavraCerta.Formularios.FormulariosSetup.MainScreen
{
    //Pontuação e dificuldade controle interno
    //Categoria controle no banco de dados (SQLSERVER)
    public sealed class MainScreenSetup
    {
        private ComboBox categoria;
        private ComboBox dificuldade;
        private Label pontos;
        private Button jogar;

        public MainScreenSetup(ComboBox categoria, ComboBox dificuldade, Label pontos, Button jogar)
        {
            this.categoria = categoria;
            this.dificuldade = dificuldade;
            this.pontos = pontos;
            this.jogar = jogar;

            PointsControl.Instance.DefinirCaminhoDoArquivoDePontos();
            SetValuesToComponentsInUI();
        }

        private async void SetValuesToComponentsInUI()
        {
            await Task.Run(() =>
            {
                InvokeComboBoxCategoria();
                InvokeComboBoxDificuldade();
                InvokeLabelPontos();
            }).ContinueWith( t =>
            {
                if (t.IsCompleted)
                {
                    jogar.Invoke((MethodInvoker)(() =>
                    {
                        jogar.Enabled = true;
                    }));
                }
            });
        }

        private void InvokeLabelPontos()
        {
            pontos.Invoke((MethodInvoker)(() =>
            {
                pontos.Text = PointsControl.Instance.ObterPontosArquivosDePontuacao();
            }));
        }
        private void InvokeComboBoxCategoria()
        {
            categoria.Invoke((MethodInvoker)(() =>
            {
                SetValuesToCategoria(categoria);
            }));
        }
        private void InvokeComboBoxDificuldade()
        {
            dificuldade.Invoke((MethodInvoker)(() =>
            {
                foreach (var item in Enum.GetValues(typeof(Dificuldade)))
                    dificuldade.Items.Add(item);

                dificuldade.SelectedIndex = 2;
            }));
        }
        private void SetValuesToCategoria(ComboBox comboBox)
        {
            try
            {
                using (var conn = new SqlConnection(StringConnection.UserPlayer))
                {
                    conn.Open();

                    DataTable tables = conn.GetSchema("Tables");
                    foreach (DataRow item in tables.Rows)
                        comboBox.Items.Add(item["TABLE_NAME"]);

                    comboBox.SelectedIndex = 0;

                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao carregar categorias!");
            }
        }
    }
}
