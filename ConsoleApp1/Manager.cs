namespace ConsoleApp1
{
    public class Manager
    {
        private readonly Garage<IVehicule> _garage;

        public Manager(Garage<IVehicule> garage)
        {
            _garage = garage;
        }
    }
}