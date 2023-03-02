using System.Security.Cryptography.X509Certificates;

namespace AutoMarket
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double totalPrice = 0;
            Car[] market = new Car(0).MakeMarket(out totalPrice);
            Car.Sort(market);
            Car wantCar = new Car(" ", MakeAuto.BMW, 10, 4, "Automatic", 28000);
            try
            {
                Car myNewCar = market.Find(wantCar);
                Console.WriteLine("My New Car: " + myNewCar.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}