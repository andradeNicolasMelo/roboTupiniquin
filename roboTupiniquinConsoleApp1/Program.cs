namespace roboTupiniquinConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefinidorGrid definidorGrid = new DefinidorGrid();

            definidorGrid.TamanhoGrid();

            Console.WriteLine($"Eixo X: {definidorGrid.gridEixoX}, Eixo Y: {definidorGrid.gridEixoY}");

            Console.ReadLine();
        }
    }
}
