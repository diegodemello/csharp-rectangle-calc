using System.Globalization;

namespace RectangleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre a largura e altura de um retângulo: ");
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + rectangle.area(width, height).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + rectangle.perimeter(width, height).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.diagonal(width, height).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
