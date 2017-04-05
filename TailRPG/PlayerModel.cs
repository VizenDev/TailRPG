using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailRPG
{
    public enum State
    {
        InDungeon,
        InFight,
        AfterFight,
        NotInDungeon
    }
    public class PlayerModel : DbContext
    {
        public DbSet<Player> Player { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=tbl_player.sqlite");
        }
    }

    public class Player
    {
        public ulong UID { get; set; }
        public string Name { get; set; }
        public string Weapon { get; set; }
        public List<string> Item { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public double HP { get; set; }
        public bool isFirstTimePlaying { get; set; }
        public State playerState { get; set; }
        public double MaxHealth(int level)
        {
            return level * 10;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Weapon: " + Weapon);
            sb.AppendLine("Item(s): " + "test");
            sb.AppendLine("XP: " + XP);
            sb.AppendLine("Level: " + Level);
            sb.AppendLine("HP: " + $"{HP}/{MaxHealth(Level)}");
            sb.AppendLine("First Timer: " + isFirstTimePlaying);
            sb.AppendLine("State: " + playerState);
            return sb.ToString();
        }
    }
}
