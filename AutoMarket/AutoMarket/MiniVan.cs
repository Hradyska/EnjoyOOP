namespace AutoMarket
{
    internal class MiniVan : Van, IMakeCar
    {
        private int _rowsOfSeats;
        private bool _hasSlidingDoors;
        public MiniVan(double price)
            : base(price)
        {
            MakeCar();
            GetFuelConsumption(8, 12);
        }

        public int RowsOfSeats
        {
            get { return _rowsOfSeats; } set { _rowsOfSeats = value; }
        }

        public bool HasSlidingDoors
        {
            get { return _hasSlidingDoors; }
            set { _hasSlidingDoors = value; }
        }

        public new void MakeCar()
        {
            Random random = new Random();
            if (random.Next(0, 100) < 50)
            {
                _hasSlidingDoors = true;
            }
            else
            {
                _hasSlidingDoors = false;
            }

            Seats = random.Next(5, 10);
            _rowsOfSeats = random.Next(2, 4);
        }

        public override string ToString()
        {
            return base.ToString() + $"; RowsOfSeats: {RowsOfSeats}; HasSlidingDoors: {HasSlidingDoors}";
        }
    }
}
