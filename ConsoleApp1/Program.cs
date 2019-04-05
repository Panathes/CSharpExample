using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Box : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("Clean box");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
         

            var program = new Program();


            int? partnerId = null;
            partnerId = 42;

            if (partnerId.HasValue)
            {

            }


            Car toyota1 = new Toyota
            {
                Name = "gfds",
                Immatriculation = "gfds"
            };

            Car toyota3 = new Toyota();
            toyota3.Name = "jkjkl";



            Console.WriteLine("Start Toyota...");
                toyota1.Start();
            toyota1.Accelerate();



            //IClim clim = toyota1;
            //clim.ClimOn();
            //toyota1.ClimOff();
            //toyota1.ActiveClim();

            var garage = new Garage<Car>();
            garage.Rentrer(new Toyota());

            Car toyota2 = new Toyota();
            toyota2.Garer(garage);

            Toyota jesais = (Toyota) toyota2;
            

            var garageBox = new Garage<Box>(); 
            garageBox.Rentrer(new Box());



            Console.WriteLine($"{DateTime.Now.ToString(CultureInfo.CurrentCulture)} Calling API...");
            var res = program.GetNameFromApiTuple(1);
            
            Console.WriteLine($"{DateTime.Now.ToString(CultureInfo.CurrentCulture)} Calling API...");
            var res2 = program.GetNameFromApiTuple(2);

            Task.WaitAll(res, res2);

            Console.WriteLine($"{DateTime.Now.ToString(CultureInfo.CurrentCulture)} resultat:" + res.Result);
            Console.WriteLine($"{DateTime.Now.ToString(CultureInfo.CurrentCulture)} resultat2:" + res2.Result);

            Console.ReadLine();
        }

        public Task<ReturnType<int>> GetNameFromApiObject(int index)
        {
            return Task.Run(() => CallingApiObject(index));
        }

        public Task<(string, int)> GetNameFromApiTuple(int index)
        {
            return Task.Run(() => CallingApiTuple(index));
        }

        private ReturnType<T> CallingApiObject<T>(T index)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Call ended");
            return new ReturnType<T>
            {
                Index = index,
                Name = "toto"
            };
        }

        private (string, int) CallingApiTuple(int index)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Call ended");
            return ("toto", index);
        }

        //public void ModifyCar(Car toto, string name)
        //{
        //    toto.Name = name;

        //    Console.WriteLine("Addresse=" + toto.GetHashCode());

        //    toto = new Car();
        //    toto.Name = "Corrola";
        //    Console.WriteLine("Addresse=" + toto.GetHashCode());
        //}
    }

    public class ReturnType<T>
    {
        public string Name { get; set; }
        public T Index { get; set; }

        public override string ToString()
        {
            return Name + Index;
        }
    }
}
