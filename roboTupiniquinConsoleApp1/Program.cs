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

            Console.ReadLine();
        }
    }
}
