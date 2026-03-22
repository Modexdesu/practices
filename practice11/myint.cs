namespace practice11
{
    internal class Myint
    {
        public static string Tostring(int a)
        {
            long n = a;
            bool negative = n < 0;
            if (negative) n = -n;

            if (n == 0) return "0";

            string s = "";
            while (n > 0)
            {
                int digit = (int)(n % 10);
                s = (char)('0' + digit) + s;
                n /= 10;
            }

            if (negative) s = "-" + s;
            return s;
        }
        public static bool Equals(int a, int b)
        {
            return a == b ? true : false;
        }
        public static int CompareTo(int a, int b)
        {
            if (a == b) return 0;
            return a < b ? -1 : 1;
        }
        public static int Parse(string a)
        {
            int result = 0;
            foreach (char c in a)
            {
                int digit = (int)(c % 10);
                result = result * 10 + digit;
            }
            return result;


        }
        public static bool Tryparse(string a,out int result)
        {
                     result=0;

            if (string.IsNullOrWhiteSpace(a)) return false;

            long longresult=0;

            foreach (char c in a)
            {
                if (!char.IsDigit(c)) return false;

                int digit = (int)(c % 10);
                longresult = longresult * 10 + digit;
                 
                if( longresult > int.MaxValue ) return false;

            }
            result = (int)longresult;
            return true;

        }
    }
}
