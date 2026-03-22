namespace practice11
{
    internal class Mymath
    {
        public static int Min(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static int Abs(int a)
        {
            if (a < 0)
                return -a;
            else
                return a;
        }
        public static int Pow(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        public static int Sqrt(int a)
        {
            if (a < 0)
                Console.WriteLine("Cannot calculate square root of a negative number.");
            else if (a == 0 || a == 1)
                return a;
            int result = 0;
            while (result * result <= a)
            {
                result++;
            }
            return result - 1;
        }
        public static int Clamp(int a, int b, int c)
        {
            if (b < a)
                return a;
            else if (b > c)
                return c;
            else
                return b;
        }

        public static int Round(double a)
        {
            if (a - (int)a >= 0.5)
                return (int)a + 1;
            else
                return (int)a;
        }
        public static int Floor(double a)//??????
        {
            return (int)a;
        }
        public static  int Ceil(double a) //????
        {
            if (a - (int)a > 0)
                return (int)a + 1;
            else
                return (int)a;



        }
    }
}
