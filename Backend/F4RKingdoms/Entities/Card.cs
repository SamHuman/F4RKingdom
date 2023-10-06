using F4RKingdoms.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F4RKingdoms.Entities
{
    internal class Card
    {
        public string Name { get; set; }
        public int Influence { get; set; }
        public int Resist { get; set; }
        public TypeCard Type { get; set; }
        public int Cost { get; set; }
        public Kingdom kingdom { get; set; }
        public List<CardEffect> Effect { get; set; } = new List<CardEffect>();

        public Card() { }

        public Card(string name, int influence, int resist, TypeCard type, int cost, Kingdom kingdom)
        {
            Name = name;
            Influence = influence;
            Resist = resist;
            Type = type;
            Cost = cost;
            this.kingdom = kingdom;
        }

        public void addEffect(CardEffect effect)
        {
            Effect.Add(effect);
        }
        public void removeEffect(CardEffect effect)
        {
            Effect.Remove(effect);
        }

    }
}
