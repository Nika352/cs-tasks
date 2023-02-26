
    public class Circle
    {
        private const double PI = 3.14;
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea(double r)
        {
            return PI * r * r;
        }

        public  double getPerimeter(double r)
        {
            return 2 * PI * r;
        }
    }
