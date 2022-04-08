namespace FactoryPattern2.Interfaces
{
    public interface IFactory<out T>
    {
        public T Create(string s);
    }
}