namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Header();
                int sideX = InputReader("X");
                int sideY = InputReader("Y");
                int sideZ = InputReader("Z");

                Header();
                ShowValues(sideX, sideY, sideZ);

                if (IsAnTriangle(sideX, sideY, sideZ))
                {
                    string triangleType = FindTriangleType(sideX, sideY, sideZ);


                    Console.WriteLine($"O triângulo é {triangleType}.");
                }
                else
                    Console.WriteLine("\nOs valores informados não formam um triâgulo válido");

                string optionContinue = ShowContinue();
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
        static int InputReader(string side)
        {
            int value;
            do
            {
                Console.Write($"Informe o valor do {side}: ");
                bool successfulyConverted = int.TryParse(Console.ReadLine()!, out value);
                if (successfulyConverted && value > 0)
                    break;

                Console.WriteLine("\n/---------------------------------------------------------------------\\");
                Console.WriteLine("Entrada inválida! Por favor, informe apenas números inteiros positivos.");
                Console.WriteLine("/---------------------------------------------------------------------\\\n");
            } while (true);

            return value;
        }
        static void ShowValues(int sideX, int sideY, int sideZ)
        {
            Console.WriteLine("Valores Informados:");
            Console.WriteLine($"Lado X: {sideX}");
            Console.WriteLine($"Lado Y: {sideY}");
            Console.WriteLine($"Lado Z: {sideZ}");
            Console.WriteLine("\n/-----------------------------------------\\");
        }
        static bool IsAnTriangle(int sideX, int sideY, int sideZ)
        {
            return sideX + sideY > sideZ && sideX + sideZ > sideY && sideY + sideZ > sideX;
        }
        static string FindTriangleType(int sideX, int sideY, int sideZ)
        {
            if (sideX == sideY && sideY == sideZ)
            {
                return "Equilátero";
            }
            else if (sideX != sideY && sideY != sideZ && sideX != sideZ)
            {
                return "Escaleno";
            }
            else
                return "Isósceles";
        }
        static string ShowContinue()
        {
            Console.Write("\nDeseja continuar? (S/N) ");
            string optionContinue = Console.ReadLine()!.ToUpper();
            return optionContinue;

        }
    }
}
