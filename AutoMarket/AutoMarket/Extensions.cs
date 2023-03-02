namespace AutoMarket
{
    internal static class Extensions
    {
        public static Car[] MakeMarket(this Car car, out double totalprice)
        {
            Car[] market = new Car[100];
            totalprice = 0;
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                switch (random.Next(0, 4))
                {
                    case 0:
                        market[i] = (Sedan)new Sedan(random.Next(15000, 35000)); break;
                    case 1:
                        market[i] = (Pickup)new Pickup(random.Next(25000, 60000)); break;
                    case 2:
                        market[i] = (Van)new Van(random.Next(27000, 70000)); break;
                    case 3:
                        market[i] = (MiniVan)new MiniVan(random.Next(20000, 40000)); break;
                }

                Console.WriteLine(market[i].ToString());
                totalprice += market[i].Price;
            }

            Console.WriteLine($"Total Price = {totalprice} $");
            return market;
        }

        public static Car Find(this Car[] cars, Car car)
        {
            int i = 0;
            while (i < cars.Length)
            {
                if (car.Equals(cars[i]) && (car.Price > cars[i].Price))
                {
                    return cars[i];
                }

                i++;
            }

            throw new Exception("We don't have any car for you!");
        }
    }
}
