using System;

namespace ConsoleApp1
{
    public abstract class Car : ICar
    {
        public string Name { get; set; }

        protected string _engine;

        public void Start()
        {
            LockYourBelt();

            InitEngine();
            Console.WriteLine("Car: Start engine=" + _engine);
        }

        public void Accelerate(int velocity = 10)
        {
            Console.WriteLine("Car: Accelerate="+velocity);
        }

        protected virtual void InitEngine()
        {
            _engine = "gazol";
        }

        protected abstract void LockYourBelt();
        public void Clean()
        {
            Console.WriteLine("Car: clean car");
        }
    }
}