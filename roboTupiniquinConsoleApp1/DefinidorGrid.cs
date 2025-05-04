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
            bool noWhile = true;
            do
            {
                Console.WriteLine("Qual o tamanho do While? ");
                string tamanho = Console.ReadLine();

                string[] eixosIndividuais = tamanho.Split(" ");

                if(eixosIndividuais.Length != 2)
                {
                    Console.WriteLine("Erro: voce deve digitar 2 valores");
                    continue;
                }

                if (!int.TryParse(eixosIndividuais[0], out gridEixoX))
                {
                    Console.WriteLine("Erro: O primiro valor não é um numero");
                    continue;
                }

                if (!int.TryParse(eixosIndividuais[1], out gridEixoX))
                {
                    Console.WriteLine("Erro: O segundo valor não é um numero");
                    continue;
                }

                noWhile = false;

            } while (noWhile);
        }
    }
}
