namespace roboTupiniquinConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefinidorGrid definidorGrid = new DefinidorGrid();
            definidorGrid.TamanhoGrid();

            DefinidorRobo dudu = new DefinidorRobo();
            dudu.Exploracao();

            Console.WriteLine($"Eixo X grid: {definidorGrid.gridEixoX}, Eixo Y grid: {definidorGrid.gridEixoY}");
            Console.WriteLine();

            Console.WriteLine($"Eixo X robo: {dudu.roboEixoX}, Eixo Y robo: {dudu.roboEixoY}, direção robo: {dudu.direcao}");
            Console.WriteLine(dudu.comandosIndividuaisRobo);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
