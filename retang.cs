using System;
namespace POO
{
    public class retang
    {
        public float Alt;
        public float Larg;

        public float Area()
        {
            float area = Alt * Larg;
            return area;
        }

        public float Per()
        {
            float per = (2 * Alt) + (2 * Larg);
            return per;
        }
        public double Diag()
        {
            double diag = Math.Sqrt(Math.Pow(Alt, 2) + Math.Pow(Larg, 2));
            return diag;
        }

     
    }
}
