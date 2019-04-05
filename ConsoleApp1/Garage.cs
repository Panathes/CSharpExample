namespace ConsoleApp1
{
    public class Garage<T> where T : ICleanable
    {
        public T Chose { get; set; }

        public void Rentrer(T chose)
        {
            Chose = chose;
            Chose.Clean();
        }
    }
}