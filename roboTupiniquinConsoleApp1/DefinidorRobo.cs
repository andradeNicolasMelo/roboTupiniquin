// Responsavel pelas ações dos robos

namespace roboTupiniquinConsoleApp1
{
    internal class DefinidorRobo
    {
        public int roboEixoX;
        public int roboEixoY;
        public char direcao;

        public char[] comandosIndividuaisRobo;

        public void Exploracao()
        {
            Console.WriteLine("Qual a posição do robô e para onde ele esta olhando? ");
            string entradaPosicaoInicialRobo = "1 2 N";
            Console.WriteLine();

            TratamentoValoresCoordedasRobo(entradaPosicaoInicialRobo);
            
            Console.WriteLine("Qual a posição do robô e para onde ele esta olhando? ");
            string movimentacaDoRobo = "EMEMEMEMM";
            Console.WriteLine();

            comandosIndividuaisRobo = movimentacaDoRobo.ToCharArray();
        }

        public void TratamentoValoresCoordedasRobo(string entradaPosicaoInicialRobo)
        {
            string[] CoordenadasPosiciaoInicialRobo = entradaPosicaoInicialRobo.Split(' ');

            roboEixoX = Convert.ToInt32(CoordenadasPosiciaoInicialRobo[0]);
            roboEixoY = Convert.ToInt32(CoordenadasPosiciaoInicialRobo[1]);
            direcao = Convert.ToChar(CoordenadasPosiciaoInicialRobo[2]);
        }
    }
}
