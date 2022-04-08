using FactoryPattern2.Interfaces;

namespace FactoryPattern2.Classes
{
    public class NonPlayerCharacter : ICharacter
    {
        public string Name { get; set; } = "Bob";
        public string Description { get; set; } = "He's Bob, you know, from accounting, you're pretty sure.";
        public string Inventory { get; set; } = "1 Ham Salad, 1 pencil (Durability: 50%), and 1 potion of Bobliness";
    }
}