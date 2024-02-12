using System;


namespace ConsoleApp2
{
    internal class Program
    {
 
        static void Main(string[] args)
        {

            while (true)
            {
                string option = menu();
                if (option.Equals("1"))
                {
                    Console.WriteLine("Zadaj n pre stvorec: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Stvorec stvorec = new Stvorec();
                    stvorec.Stvor(n);
                }
                if (option.Equals("2"))
                {
                    Console.WriteLine("Zadaj velkost trojuholnika");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Pyramida pyramida = new Pyramida();
                    pyramida.Pyr(n);
                }
                if (option.Equals("3"))
                {
                    Obdlznik obdlznik = new Obdlznik();
                    Console.WriteLine("Zadaj vysku obdlznika: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zadaj sirku obdlznika: ");
                    int m = Convert.ToInt32(Console.ReadLine());

                    obdlznik.Obdlz(n, m);
                }
                if (option.Equals("4")) {
                    return;
                }
            }
        }
        static string menu()
        {
            Console.WriteLine("1-> Stvorec\n2-> Pyramidu\n3-> Obdlznik\n4->Koniec");
            return Console.ReadLine();
        }
    }

    class Stvorec : Shape {
        public void Stvor(int n) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    shape();
                }
                Console.WriteLine('\n');
            }

    
        }
    }

    class Pyramida : Shape {
        public void Pyr(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    shape();
                }
                Console.WriteLine('\n');
            }
        }
    }

    class Obdlznik: Shape {
        public void Obdlz(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    shape();
                }
                Console.WriteLine('\n');
            }
        }
    }

    class Shape {
        public void shape() {
            Console.Write(" * ");
            }
         
    }
}
