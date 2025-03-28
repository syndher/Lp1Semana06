

namespace MyGame
{

    class Program
    {

        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[int.Parse(args[0])];
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string input = Console.ReadLine();
                Enemy enemy = new Enemy(input);
                enemies[i] = enemy;
            }

            foreach (Enemy enemy in enemies) {
                Console.WriteLine(enemy.GetName());
            }
        }

    }
}
