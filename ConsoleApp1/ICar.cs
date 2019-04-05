namespace ConsoleApp1
{
    public interface ICar : IVehicule
    {
        void Start();
        void Accelerate(int velocity);
    }
}