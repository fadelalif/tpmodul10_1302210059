namespace AljabarLibraries
{
    public class PersamaanKuadrat
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double diskriminan = (b * b) - (4 * a * c);

            if (diskriminan < 0)
            {
                return new double[] { };
            }
            else if (diskriminan == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }

        public double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double y1 = a * a;
            double y2 = 2 * a * b;
            double y3 = b * b;

            return new double[] { y1, y2, y3 };
        }
    }
}