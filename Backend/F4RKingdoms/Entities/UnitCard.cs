using F4RKingdoms.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F4RKingdoms.Entities
{
    internal class UnitCard : Card
    {
        public int Force { get; set; }
        public UnitRank Rank { get; set; }
        public int[,] Movement { get; set; }
        public int Teste { get; set; }
        public UnitCard() { }

        public UnitCard(string name, int influence, int resist, TypeCard type, int cost, Kingdom kingdom, UnitRank rank, int force) : base(name, influence, resist, type, cost, kingdom)
        {
            Rank = rank;
            Force = force;
        }

        public void MovimentRank(UnitRank rank)
        {
            switch (rank)
            {
                case UnitRank.Plebeian:
                    Movement = new int[1, 1];
                    Movement[1,1] = 1;
                    Movement[-1,-1] = 1;
                    Movement[0, 1] = 1;
                    Movement[1,0] = 1;
                    break;

                case UnitRank.Scout:
                    Movement = 2; break;

                case UnitRank.Knight:
                    Movement = 3; break;

                case UnitRank.Rogue:
                    Movement = 4; break;
            }
        }
    }
}
