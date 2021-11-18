using System;

namespace KabanovaLab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("|     x       |      y       |");
                for (double x = -3; x <= 2.5; x += 1.1)
                {
                    double y = 0;
                    if (x > 0)
                    {
                        double S = 0;
                        for (int k = 1; k <= 8; k++)
                        {
                            long F = 1;
                            for (int j = 1; j < k - 1; j++) F *= j;
                            S += (Math.Pow(-1, k) * Math.Pow(x, k)) / (k * F);
                        }
                        y = S;
                    }
                    else
                    {
                        y = Math.Tan(Math.Pow(Math.PI, x));
                    }

                    Console.WriteLine("|{0,13:F2}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}
