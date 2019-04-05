namespace ConsoleApp1
{
    public static class CarExtensions
    {
        public static void Garer(this Car car, Garage<Car> garage)
        {
            garage.Rentrer(car);
        }

        public static void Garer(this Velo car, Garage<Velo> garage)
        {
            garage.Rentrer(car);
        }
    }
}