using FactoryPattern2.Interfaces;

namespace FactoryPattern2.Classes.Factories
{
    public class CharacterFactory : IFactory<ICharacter>
    {
        public ICharacter Create(string template)
        {
            return template switch
            {
                "1" => new NonPlayerCharacter(),
                "2" => new PlayerCharacter(),
                _ => null
            };
        }
    }
}