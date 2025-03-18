namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Header();
                Console.Write("Informe o valor do X: ");
                int sideX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do Y: ");
                int sideY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do Z: ");
                int sideZ = Convert.ToInt32(Console.ReadLine());

                Header();
                Console.WriteLine("Valores Informados:");
                Console.WriteLine($"Lado X: {sideX}");
                Console.WriteLine($"Lado Y: {sideY}");
                Console.WriteLine($"Lado Z: {sideZ}");
                Console.WriteLine("\n/-----------------------------------------\\");

                bool isAValidTriangle = sideX + sideY > sideZ && sideX + sideZ > sideY && sideY + sideZ > sideX;

                if (isAValidTriangle == true)
                    Console.WriteLine("\nÉ um triângulo válido.");
                else
                    Console.WriteLine("\nOs valores informados não formam um triâgulo válido");

                Console.Write("\nDeseja continuar? (S/N) ");
                string optionContinue = Console.ReadLine()!.ToUpper();
                if (optionContinue != "S")
                {
                    Console.Clear();
                    Console.WriteLine("Adeus \\(T_T)");
                    break;
                }

            } while (true);
        }
        static void Header()
        {
            Console.Clear();
            Console.WriteLine("/-----------------------------------------\\");
            Console.WriteLine("        Classificador de Triângulos");
            Console.WriteLine("/-----------------------------------------\\\n");
        }
    }
}
