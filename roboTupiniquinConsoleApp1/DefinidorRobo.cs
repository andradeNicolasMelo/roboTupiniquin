// Responsavel pelas ações dos robos

namespace roboTupiniquinConsoleApp1
{
    internal class DefinidorRobo
    {
        public int roboEixoX;
        public int roboEixoY;
        public char direcao;

        DefinidorGrid grid = new DefinidorGrid();
      

        public void Exploracao()
        {
            grid.TamanhoGrid();
            Console.WriteLine("Qual a posição do robô e para onde ele esta olhando? ");
            string entradaPosicaoInicialRobo = "-7 5 N";
            Console.WriteLine();

            TratamentoValoresCoordedasRobo(entradaPosicaoInicialRobo);
            
            Console.WriteLine("Qual a posição do robô e para onde ele esta olhando? ");
            string movimentacaDoRobo = "MMMDDDE";
            Console.WriteLine();

            char[] comandosIndividuaisRobo = movimentacaDoRobo.ToCharArray();

            Console.WriteLine(MovimentacaoDoRobo(comandosIndividuaisRobo));
        }

        public void TratamentoValoresCoordedasRobo(string entradaPosicaoInicialRobo)
        {
            string[] CoordenadasPosiciaoInicialRobo = entradaPosicaoInicialRobo.Split(' ');

            roboEixoX = Convert.ToInt32(CoordenadasPosiciaoInicialRobo[0]);
            roboEixoY = Convert.ToInt32(CoordenadasPosiciaoInicialRobo[1]);
            direcao = Convert.ToChar(CoordenadasPosiciaoInicialRobo[2]);
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
