namespace euklideszi_algoritmus
{
    internal class Program
    {
        public static void euklidesz(int a, int b)
        {

            int X;
            int Y;
            int d;

            List<int> x = new List<int>() { 1, 0 };
            List<int> y = new List<int>() { 0, 1 };
            List<int> r = new List<int>() { a, b };
            List<int> q = new List<int>() { 0 };

            int n = 0;

            if (r[n + 1] == 0)
            {
                X = x[n];
                Y = y[n];
                d = r[n];
                return;
            }

            while (r[n + 1] != 0)
            {
                q.Add(r[n] / r[n + 1]);
                r.Add(r[n] - r[n + 1] * q[n + 1]);
                //r.Add(r[n] % (r[n] - r[n + 1] * q[n + 1]));
                x.Add(x[n] - x[n + 1] * q[n + 1]);
                y.Add(y[n] - y[n + 1] * q[n + 1]);
                n++;
            }
            q.Insert(0, 0);

            
            string[] f = { "i", "q_i", "r_i", "x_i", "y_i", "r_i = a(x_i) + b(y_i)" };
            string vonal = "-----------------------------------------------------";
            Console.WriteLine(vonal);
            Console.WriteLine(String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", f[0].PadLeft(2).PadRight(3), f[1].PadLeft(4).PadRight(5), f[2].PadLeft(4).PadRight(5), f[3].PadLeft(4).PadRight(5), f[4].PadLeft(4).PadRight(5), f[5].PadLeft(22).PadRight(23)));
            Console.WriteLine(vonal);
            for (int i = 0; i <r.Count; i++)
            {
                Console.WriteLine(String.Format("|{0,2} |{1,4} |{2,4} |{3,4} |{4,4} | {5,22} |", $"{i}", q[i] == 0 ? "-" : q[i], r[i], r[i] == 0 ? "-" : x[i], r[i] == 0 ? "-" : y[i], r[i] == 0 ? "-" : $"{r[i]} = {a}({x[i]}) + {b}({y[i]})"));
            }
            Console.WriteLine(vonal);
        }

        static void Main(string[] args)
        {
            euklidesz(540, 372);
            //euklidesz(2024, 1526);

        }
    }
}