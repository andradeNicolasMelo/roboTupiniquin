// Responsavel pela definição do tamanho do grid

using System.Threading.Channels;

namespace roboTupiniquinConsoleApp1
{
    public class DefinidorGrid
    {
        public int gridEixoX;
        public int gridEixoY;
        public void TamanhoGrid()
        {
            Console.Write("Tamanho do grid: ");
            string gridInsercaoValores = "5 5";
            Console.WriteLine();

            Tratador(gridInsercaoValores);
        }

        public void Tratador(string gridInsercaoValores)
        {
            string[] TamanhoDeCadaEixo = gridInsercaoValores.Split(' ');

            gridEixoX = Convert.ToInt32(TamanhoDeCadaEixo[0]);
            gridEixoY = Convert.ToInt32(TamanhoDeCadaEixo[1]);
        }
    }
}
