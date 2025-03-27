

namespace Chronos
{

    class Program
    {

        private static void Main(string[] args)
        {
            int result = 0;
            Random r1 = new Random(Convert.ToInt32(args[1]));
            for (int i = 0; i < Convert.ToInt32(args[0]); i++)
            {
                int numeros = r1.Next(1,7);
                result += numeros;
            }
            Console.WriteLine(result);
        }

    }
}
