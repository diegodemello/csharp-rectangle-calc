namespace RectangleCalc
{
    internal class Rectangle
    {
        public double area(double width, double height)
        {
            return width * height;
        }

        public double perimeter(double width, double height)
        {
            return 2 *(width + height);
        }

        public double diagonal(double width, double height)
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }
    }
}
