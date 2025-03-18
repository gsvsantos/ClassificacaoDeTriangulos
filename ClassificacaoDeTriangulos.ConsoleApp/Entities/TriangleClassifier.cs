namespace ClassificacaoDeTriangulos.ConsoleApp.Entities
{
    public class TriangleClassifier
    {
        public static bool IsAnTriangle(int sideX, int sideY, int sideZ)
        {
            return sideX + sideY > sideZ && sideX + sideZ > sideY && sideY + sideZ > sideX;
        }
        public static string FindTriangleType(int sideX, int sideY, int sideZ)
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
    }
}
