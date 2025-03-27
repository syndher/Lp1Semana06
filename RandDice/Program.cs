

namespace Chronos
{

    class Program
    {

        private static void Main(string[] args)
        {
            Random r1 = new Random(Convert.ToInt32(args[1]));
            for (int i = 0; i < Convert.ToInt32(args[0]); i++)
            Console.WriteLine(r1.Next(1,7));
        }

    }
}
