﻿namespace MyGame
{
    public class Enemy
    {

        
        private string name;
        public string GetName() => name;
        private float health;
        public float GetHealth() => health;
        private float shield;
        public float GetShield() => shield;

        private static int powerUpCount;
        public static int GetPowerUpCount() => powerUpCount;
        
        static Enemy()
        {
            powerUpCount = 0;
        }
        
        public void SetName(string newName)
        {
            if (newName.Length > 8) newName = newName.Substring(0, 8);
            name = newName;
        }
        
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public void PickPowerUp(Program.PowerUp powerUp, float value)
        {
            powerUpCount++;
            if (powerUp == Program.PowerUp.SHIELD)
            {
                shield += value;
                if (shield > 100) shield = 100;
                return;
            }
            health += value;
            if (health > 100) health = 100;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageLeft = -shield;
                shield = 0;
                health -= damageLeft;
                if (health < 0) health = 0;
            }
        }

        public enum Toughness
        {
            VeryEasy,
            Easy,
            Normal,
            Tough,
            Nightmare
        }


    }
}