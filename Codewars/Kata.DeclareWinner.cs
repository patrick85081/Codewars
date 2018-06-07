using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public partial class Kata
    {
        public static string DeclareWinner(
            Fighter fighter1, Fighter fighter2,
            string firstAttacker)
        {
            var fighters = new [] {fighter1, fighter2};

            var Attacker = fighters.Single(f => f.Name == firstAttacker);
            var Defender = fighters.Single(f => f.Name != firstAttacker);

            Defender.Health -= Attacker.DamagePerAttack;

            return Defender.Health <= 0 ? 
                Attacker.Name : 
                DeclareWinner(fighter1, fighter2, Defender.Name);
        }
    }

    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
