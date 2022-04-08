using FactoryPattern2.Interfaces;

namespace FactoryPattern2.Classes
{
    public class PlayerCharacter : ICharacter
    {
        public string Name { get; set; } = "Dan of Tarth";
        public string Description { get; set; } = "Dan runs the kingdom of Tarth, which is his Sim village, but he's a good IT guy, you hope";
        public string PlayerName { get; set; } = "You";
    }
}