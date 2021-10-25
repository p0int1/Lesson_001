namespace Task_2
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area
        {
            get  
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimertCalculator();
            }
        }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        double PerimertCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
}
