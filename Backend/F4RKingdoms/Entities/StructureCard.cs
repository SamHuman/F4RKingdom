using F4RKingdoms.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F4RKingdoms.Entities
{
    internal class StructureCard : Card
    {
        public int BuildingTime { get; set; }
        public StructureType StructureType { get; set; }

        public StructureCard() { }

        public StructureCard(string name, int influence, int resist, TypeCard type, int cost, Kingdom kingdom, int buildingTime, StructureType structureType) : base(name, influence, resist, type, cost, kingdom)
        {
            BuildingTime = buildingTime;
            StructureType = structureType;
        }
    }
}
