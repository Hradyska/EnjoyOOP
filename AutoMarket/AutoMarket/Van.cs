namespace AutoMarket
{
    internal class Van : Car, IMakeCar
    {
        private int _seats;
        public Van(double price)
            : base(price)
        {
            MakeCar();
            GetFuelConsumption(15, 21);
        }

        public int Seats
        {
            get { return _seats; } set { _seats = value; }
        }

        public new void MakeCar()
        {
            Random rand = new Random();
            _seats = rand.Next(10, 19);
        }

        public override string ToString()
        {
            return base.ToString() + $"; Seats: {Seats}";
        }
    }
}
