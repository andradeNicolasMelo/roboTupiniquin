// Responsavel pelas ações dos robos

namespace roboTupiniquinConsoleApp1
{
    internal class DefinidorRobo
    {
        public int roboEixoX;
        public int roboEixoY;
        public char direcao;

        DefinidorGrid grid = new DefinidorGrid();

        private string entradaPosicaoInicialRobo;
        private string movimentacaDoRobo;

        public void Exploracao()
        {
            grid.TamanhoGrid();

            TratamentoValoresCoordedasRobo();
            
            char[] comandosIndividuaisRobo = movimentacaDoRobo.ToCharArray();

            Console.WriteLine(MovimentacaoDoRobo(comandosIndividuaisRobo));
        }

       

        public void TratamentoValoresCoordedasRobo()
        {
            bool usuarioNoWhile = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual a posição do robô e para onde ele esta olhando? ");
                entradaPosicaoInicialRobo = Console.ReadLine()!;
                
                string[] CoordenadasPosiciaoInicialRobo = entradaPosicaoInicialRobo.Split(' ');

                if (CoordenadasPosiciaoInicialRobo.Length != 3)
                {
                    Console.WriteLine("Erro: Você deve digitar exatamente dois números e uma direção (ex: 3 4 N).");
                    continue;
                }

                if (!int.TryParse(CoordenadasPosiciaoInicialRobo[0], out roboEixoX))
                {
                    Console.WriteLine("Erro: O primiro valor não é um numero");
                    Console.ReadLine();
                    continue;
                }

                if (!int.TryParse(CoordenadasPosiciaoInicialRobo[1], out roboEixoY))
                {
                    Console.WriteLine("Erro: O Segundo valor não é um numero");
                    Console.ReadLine();
                    continue;
                }

                direcao = CoordenadasPosiciaoInicialRobo[2].ToUpper()[0];
                if (direcao != 'N' && direcao != 'S' && direcao != 'L' && direcao != 'O')
                {

                    Console.WriteLine("É necessario que você digite os seguintes valore:");
                    Console.WriteLine("N - Norte   | S - Sul   | L - Leste   | O - Oeste");
                    Console.ReadLine();

                    continue;
                }

                usuarioNoWhile = false;

            } while (usuarioNoWhile);

            do
            {
                Console.Clear();
                Console.WriteLine("Qual a movimentação do robo? ");
                movimentacaDoRobo = Console.ReadLine()!.ToUpper();

                if (!movimentacaDoRobo.Contains("M") && !movimentacaDoRobo.Contains("E") && !movimentacaDoRobo.Contains("D"))
                {
                    Console.WriteLine("Erro: Necessario que o valor inserido tenha: M ou D ou E");
                    continue;
                }

                usuarioNoWhile = true;
            } while (!usuarioNoWhile);
        }

        public string MovimentacaoDoRobo(char[] comando)
        {
            for(int i = 0; i < comando.Length; i++)
            {
                char comandoAtual = comando[i];

                if(comandoAtual == 'E')
                {
                    VirarEsquerda();
                }

                else if(comandoAtual == 'D')
                {
                    VirarDireita();
                }

                else if (comandoAtual == 'M')
                {
                    Mover();
                    EvitadorDeUltrapassagem();
                }
            }

            string posicaoFinal = $"{roboEixoX} {roboEixoY} {direcao}";
            return posicaoFinal;
        }

        public void VirarEsquerda()
        {
            if(direcao == 'N')
            {
                direcao = 'O';
            }

            else if(direcao == 'O')
            {
                direcao = 'S';
            }

            else if(direcao == 'S')
            {
                direcao = 'L';
            }

            else if(direcao == 'L')
            {
                direcao = 'N';
            }
        }

        public void VirarDireita()
        {
            if (direcao == 'N')
            {
                direcao = 'L';
            }

            else if (direcao == 'L')
            {
                direcao = 'S';
            }

            else if (direcao == 'S')
            {
                direcao = 'O';
            }

            else if (direcao == 'O')
            {
                direcao = 'N';
            }
        }

        public void Mover()
        {
            if (direcao == 'N')
            {
                roboEixoY++;
            }

            else if (direcao == 'S')
            {
                roboEixoY--;
            }

            else if (direcao == 'L')
            {
                roboEixoX++;
            }

            else if (direcao == 'O')
            {
                roboEixoX--;
            }
        }

        public void EvitadorDeUltrapassagem()
        {
            while (roboEixoX > grid.gridEixoX)
            {
                roboEixoX--;
            }
            while (roboEixoX < 0)
            {
                roboEixoX++;
            }
            while (roboEixoY > grid.gridEixoY)
            {
                roboEixoY--;
            }
            while(roboEixoY < 0)
            {
                roboEixoY++;
            }
        }

    }
}
