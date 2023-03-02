using System.Diagnostics;

namespace AutoMarket
{
    internal class Car : IMakeCar, IComparer<Car>
    {
        private string _petName;
        private MakeAuto _make;
        private double _fuelConsumption;
        private int _doors;
        private string _transmission;
        private double _price;
        public Car(double price)
        {
            PetName = string.Empty;
            MakeCar();
            FuelConsumption = 0;
            Price = price;
        }

        public Car(string petName, MakeAuto make, double fuelConsumption, int doors, string transmission, double price)
        {
            PetName = petName;
            Make = make;
            FuelConsumption = fuelConsumption;
            Doors = doors;
            Transmission = transmission;
            Price = price;
        }

        public string PetName
        {
            get { return _petName; }
            set { _petName = value; }
        }

        public MakeAuto Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }

        public string Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                _transmission = value;
            }
        }

        public double FuelConsumption
        {
            get { return _fuelConsumption; }
            set { _fuelConsumption = value; }
        }

        public void MakeCar()
        {
            Random random = new Random();
            int i = random.Next(0, 5);
            switch (i)
            {
                case 0: _make = MakeAuto.BMW; break;
                case 1: _make = MakeAuto.Ford; break;
                case 2: _make = MakeAuto.Volkswagen; break;
                case 3: _make = MakeAuto.Toyota; break;
                case 4: _make = MakeAuto.Nissan; break;
            }

            DoorsCount();
            GetTransmission();
        }

        public double GetFuelConsumption(int min, int max)
        {
            Random rand = new Random();
            _fuelConsumption = rand.Next(min, max);
            return _fuelConsumption;
        }

        public static void Sort(Car[] cars)
        {
            Array.Sort(cars, Comparer);
        }

        public int Compare(Car x, Car y)
        {
            if (x._fuelConsumption == y._fuelConsumption)
            {
                return 0;
            }

            return x._fuelConsumption < y._fuelConsumption ? -1 : 1;
        }

        public override string ToString()
        {
            return $"PetName: {PetName}; Type: {GetType()}; Make: {Make}; Doors: {Doors}; FuelConsumption: {FuelConsumption}; Transmission: {Transmission}; Price: {Price}$ ";
        }

        public bool Equals(Car car)
        {
            bool flag = false;
            if (Doors == car.Doors && FuelConsumption == car.FuelConsumption && Transmission == car.Transmission)
            {
                flag = true;
            }

            return flag;
        }

        private void DoorsCount()
        {
            Random random = new Random();
            _doors = random.Next(2, 5);
        }

        private void GetTransmission()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) > 50)
            {
                _transmission = "Automatic";
            }
            else
            {
                _transmission = "Manual";
            }
        }

        private static int Comparer(Car x, Car y)
        {
            if (x._fuelConsumption == y._fuelConsumption)
            {
                return 0;
            }

            return x._fuelConsumption < y._fuelConsumption ? -1 : 1;
        }
    }
}
