using Humanizer;

namespace MyGame
{
    public class Level(int lvl, Enemy.Toughness toughness)
    {
        public int GetNumRooms(int lvl)
        {
            lvl = int.Parse(args[0]);
            return lvl;
        }
        
        public int Difficulty(int lvl)
        {
            return lvl;
        }

        public int GetNumEnemies(int enemyCounter)
        {
            return enemyCounter;
        }

        public string GetToughness(Enemy.Toughness toughness)
        {
            return toughness;
        }

        public void SetEnemyInRoom(int room, string enemy)
        {
            string order = room.ToOrdinalWords();

        }
        public string PrintEnemies()
        {
            Console.WriteLine(Enemy.Toughness);
                
        }

        
        
        
        


        
    }
}