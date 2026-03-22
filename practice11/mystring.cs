namespace practice11
{
    internal class Mystring
    {
        public static int Length(string a)
        {
            int length = 0;
            foreach (char c in a)
            {
                length++;
            }
            return length;
        }

        public static bool IsNullOrEmpty(string a)
        {
            if (a == "" || a == null) return true;
            else return false;

        }
        public static bool IsNullOrWhiteSpace(string a)
        {
            if (a == "" || a == null) return true;
            foreach (char c in a)
            {
                if (!char.IsWhiteSpace(c)) return false;
            }
            return true;
        }
        public static string Concat(string a, string b)
        {
            return a + b;
        }

        public static bool Equals(string a, string b)
        {
            return a == b;
        }
        public static int Compare(string a, string b)
        {
            int size = Mymath.Min(a.Length, b.Length);

            for (int i = 0; i < size; i++)
            {
                if (a[i] != b[i]) return a[i] - b[i];
            }
            return a.Length - b.Length;

        }
        public static int IndexOf(string s, char a)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == a) return i;
            }
            return -1;
        }
        public static int LastIndexOf(string s, char a)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == a) return i;
            }
            return -1;
        }
        public static char StartsWith(string s)
        {
            return (s[0]);
        }

        public static char EndsWith(string s)
        {
            return (s[s.Length - 1]);
        }
        public static bool Contains(string s, char a)
        {
            foreach (char c in s)
            {
                if (c == a) return true;
            }
            return false;
        }

        public static string Substring(string s, int startIndex, int length)
        {
            string result = "";
            for (int i = startIndex; i < startIndex + length && i < s.Length; i++)
            {
                result += s[i];
            }
            return result;
        }
        public static string Substring(string s, int startIndex)
        {
            string result = "";
            for (int i = startIndex; i < s.Length; i++)
            {
                result += s[i];
            }
            return result;
        }

        public static string Replace(string s, char oldChar, char newChar)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c == oldChar) result += newChar;
                else result += c;
            }
            return result;
        }

        public static string Insert(string s, int index, string value)
        {
            string result = "";
            for (int i = 0; i < index && i < s.Length; i++)
            {
                result += s[i];
            }
            result += value;
            for (int i = index; i < s.Length; i++)
            {
                result += s[i];
            }
            return result;
        }

        public static string Remove(string s, int startIndex, int length)
        {
            string result = "";
            for (int i = 0; i < startIndex && i < s.Length; i++)
            {
                result += s[i];
            }
            for (int i = startIndex + length; i < s.Length; i++)
            {
                result += s[i];
            }
            return result;
        }
        public static string Remove(string s, int startIndex)
        {
            string result = "";
            for (int i = 0; i < startIndex && i < s.Length; i++)
            {
                result += s[i];
            }

            return result;
        }

        public static string Trim(string s)
        {
            int startIndex = 0;
            int endIndex = s.Length - 1;
            while (startIndex <= endIndex && char.IsWhiteSpace(s[startIndex]))
            {
                startIndex++;
            }
            while (endIndex >= startIndex && char.IsWhiteSpace(s[endIndex]))
            {
                endIndex--;
            }
            return Substring(s, startIndex, endIndex - startIndex + 1);
        }

        public static string TrimStart(string s)
        {
            int startIndex = 0;
            while (startIndex < s.Length && char.IsWhiteSpace(s[startIndex]))
            {
                startIndex++;
            }
            return Substring(s, startIndex);
        }
        public static string TrimEnd(string s)
        {
            int endIndex = s.Length - 1;
            while (endIndex >= 0 && char.IsWhiteSpace(s[endIndex]))
            {
                endIndex--;
            }
            return Substring(s, 0, endIndex + 1);
        }

        public static string ToUpper(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (char.IsLower(c)) result += char.ToUpper(c);
                else result += c;
            }
            return result;
        }
        public static string ToLower(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (char.IsUpper(c)) result += char.ToLower(c);
                else result += c;
            }
            return result;
        }
        public static string[] Split(string s, char separators)
        {
            string[] result = new string[Length(s)];
            int index = 0;
            string current = "";
            foreach (char c in s)
            {
                if (c == separators)
                {
                    result[index++] = current;
                    current = "";
                }
                else
                {
                    current += c;
                }
            }
            if (current != "") result[index] = current;
            return result;
        }

        public static string Join(string[] strings, string separator)
        {
            string result = "";
            for (int i = 0; i < strings.Length; i++)
            {
                result += strings[i];
                if (i < strings.Length - 1) result += separator;
            }
            return result;
        }

        public static string Format(string template, object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                string stringValue = values[i].ToString();

                template = template.Replace("{" + i + "}", stringValue);
            }
            return template;

        }

        public static 
    }
}
