/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailRPG
{
    public enum State
    {
        InDungeon,
        InFight,
        AfterFight,
        NotInDungeon
    }
    public class Fighter
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public List<string> Item { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public double HP { get; set; }
        public bool isFirstTimePlaying { get; set; }
        public State playerState { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Weapon: " + Weapon);
            sb.AppendLine("Item(s): " + "test");
            sb.AppendLine("XP: " + XP);
            sb.AppendLine("Level: " + Level);
            sb.AppendLine("HP: " + HP);
            sb.AppendLine("First Timer: " + isFirstTimePlaying);
            sb.AppendLine("State: " + playerState);
            return sb.ToString();
        }

    }
}
*/