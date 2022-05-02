namespace Animali
{
    public abstract class Animal
    {
        public abstract string Eat();

        public string GetDescription()
        {
            return Eat();
        }
    }
}