using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"D:\PT2016\minprime", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);

            string line = reader.ReadToEnd();

            reader.Close();
            stream.Close();

            string[] arr = line.Split(new char[] { ' ', '\n', '\r' });
            int length = arr.Length;

            int min = 1000000;

            for (int i = 0; i < length; i++)
            {
                string element = arr[i];
                if (element != "")
                {
                    int value = Int32.Parse(element);

                    Boolean Prime = IsPrime(value);
                    if (Prime == true && value < min)
                    {
                        min = value;
                    }
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
        static bool IsPrime(int s)
        {
            int cnt = 0;
            for (int i = 2; i < Math.Sqrt(s); i++)
            {
                if (s % i == 0)
                {
                    cnt++;
                }

            }
            Boolean res = false;
            if (cnt == 0 && s != 1)
            {
                res = true;
            }
            return res;
        }
    }
}