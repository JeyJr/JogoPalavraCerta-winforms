using JogoPalavraCerta.Database.GameSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database.PointsSetup
{
    public class PointsControl
    {
        private static PointsControl instance = new PointsControl();
        private PointsControl() { }
        public static PointsControl Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PointsControl();
                }

                return instance;
            }
        }

        private int points; 
        private const int multiplicadorPontos = 2;
        private int pontosPorLetra = 1;
        private int matchPoints = 0;

        string tempFolderPath = "";
        string tempFilePath = "";
        public string TempFilePath => tempFilePath;

        public void IniciarPontuancaoDaPartida()
        {
            matchPoints = 0;
        }

        public void DefinirPontosPorLetra(Dificuldade dificuldade)
        {
            pontosPorLetra = (int)dificuldade * multiplicadorPontos + 1;
        }

        public void GanharPontosDaPartida()
        {
            points += matchPoints;
        }

        public void GanharPontosPorLetra(int qtdLetrasAcertadas)
        {
            matchPoints += pontosPorLetra * qtdLetrasAcertadas;
        }

        public int ObterPontuacaoTotal()
        {
            return points;
        }

        public int ObterPontuacaoDaPartida()
        {
            return matchPoints;
        }


        //Criação do arquivo da pontuação
        public void DefinirCaminhoDoArquivoDePontos()
        {
            tempFolderPath = Path.GetTempPath();
            tempFilePath = Path.Combine(tempFolderPath, "dataG.txt");
        }

        public string ObterPontosArquivosDePontuacao()
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
                    return "Pontos: " + read.ReadLine();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo nao encontrado!");
                throw;
            }
        }

        public void SalvarPontosNoArquivoDePontuacao()
        {
            try
            {
                if (File.Exists(tempFilePath))
                {
                    using(var write = new StreamWriter(tempFilePath))
                    {
                        write.WriteLine(PointsControl.Instance.ObterPontuacaoTotal().ToString());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
