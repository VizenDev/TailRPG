using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailRPG
{
    public class Fighter : Player
    {
        public void ChangeName(string newName)
        {
            Name = newName;
        }
        public void ChangeWeapon(string weapon)
        {
            Weapon = weapon;
        }
        public void AddItem(string item)
        {
            Item.Add(item);
        }
        public void RemoveItem(string item)
        {
            Item.Remove(item);
        }
        public void AddXP(int xp)
        {
            XP = XP + xp;
        }
        public void RemoveXP(int xp)
        {
            XP = XP - xp;
        }
        public void AddLevel(int level)
        {
            Level = Level + level;
        }
        public void RemoveLevel(int level)
        {
            Level = Level - level;
        }
        public void AddHP(double hp)
        {
            HP = HP + hp;
        }
        public void RemoveHP(double hp)
        {
            HP = HP - hp;
        }
        public void UpdateState(State state)
        {
            playerState = state;
        }

        public Player NewPlayerInstance()
        {
            Player player = new Player();
            Item = new List<string>();
            player.Name = "Test Player";
            player.Weapon = "Default Sword";
            Item.Add("Health I");
            player.XP = 0;
            player.Level = 1;
            player.HP = 20;
            isFirstTimePlaying = false;
            playerState = State.NotInDungeon;
            return player;
        }
    }
}