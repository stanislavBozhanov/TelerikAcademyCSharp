using System;
using System.Linq;

namespace Fire
{
    class Fire
    {
        public char fire = '#';
        public char top = '-';
        public char left = '\\';
        public char right = '/';
        public char blank = '.';

        public void TorchFireTopHalf(int n)
        {
            for (int i = n / 2; i >= 1; i--)
            {
                Console.Write(new string(this.blank, i - 1));
                Console.Write(new string(this.fire, 1));
                Console.Write(new string(this.blank, n - (2 * i)));
                Console.Write(new string(this.fire, 1));
                Console.Write(new string(this.blank, i - 1));
                Console.WriteLine();
            }
        }
        public void TorchFireBottomHalf(int n)
        {
            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(new string(this.blank, i));
                Console.Write(new string(this.fire, 1));
                Console.Write(new string(this.blank, n - 2 - 2 * i));
                Console.Write(new string(this.fire, 1));
                Console.Write(new string(this.blank, i));
                Console.WriteLine();
            }
        }
        public void TorchBody(int n)
        {
            for (int i = n / 2; i >= 1; i--)
            {
                Console.Write(new string(this.blank, (n / 2) - i));
                Console.Write(new string(this.left, i ));
                Console.Write(new string(this.right, i ));
                Console.Write(new string(this.blank, (n / 2) - i));
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Fire build = new Fire();
            int n = int.Parse(Console.ReadLine());
            build.TorchFireTopHalf(n);
            build.TorchFireBottomHalf(n);
            Console.WriteLine(new string(build.top, n));
            build.TorchBody(n);
        }
    }
}
