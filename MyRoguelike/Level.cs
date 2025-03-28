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
        
        public string Difficulty(string lvl)
        {
            lvl = args[1];
            return lvl;
        }

        public string GetNumEnemies(int enemy)
        {
            return enemy;
        }

        public string GetToughness(int toughness)
        {
            return Enemy.Toughness;
        }

        public void SetEnemyInRoom(int room, string enemy)
        {
            string order = room.ToOrdinalWords();
            return Console.Write($"{order} room: {enemy}")
                
        }
        public string PrintEnemies()
        {
            return Console.Write($"{order} room: {enemy}")
        }

        
        
        
        


        
    }
}