using JogoPalavraCerta.Database.GameSetup;
using JogoPalavraCerta.Database.SQL;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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

        string tempFolderPath = "";
        string tempFilePath = "";

        public MainScreenSetup(ComboBox categoria, ComboBox dificuldade, Label pontos, Button jogar)
        {
            this.categoria = categoria;
            this.dificuldade = dificuldade;
            this.pontos = pontos;
            this.jogar = jogar;

            SetFilePath();
            SetValuesToComponentsInUI();
        }

        private void SetFilePath()
        {
            tempFolderPath = Path.GetTempPath();
            tempFilePath = Path.Combine(tempFolderPath, "dataG.txt");
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
                try
                {
                    if (!File.Exists(tempFilePath))
                    {
                        using (var write = new StreamWriter(tempFilePath))
                        {
                            write.WriteLine("0");
                        }
                    }

                    using (var read = new StreamReader(tempFilePath))
                    {
                        pontos.Text = "Pontos: " + read.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Arquivo nao encontrado!");
                    throw;
                }
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
