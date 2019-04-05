using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    public class Toyota : Car, IClim
    {
        public string Immatriculation { get; set; }

        public new void Start()
        {
            base.Start();

            ClimOn();
        }

        protected override void InitEngine()
        {
            _engine = "elect";
        }

        protected override void LockYourBelt()
        {
            Console.WriteLine("Toyota: lock belt");
        }

        public void ClimOn()
        {
            Console.WriteLine("Climatistation ON");
        }

        public void ClimOff()
        {
            Console.WriteLine("Climatistation OFF");
        }

        public static string GetTypeName()
        {
            return "Toyota";
        }
    }
}