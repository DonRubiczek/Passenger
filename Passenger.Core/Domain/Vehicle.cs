using System;

namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Name { get; protected set; }
        public int Seats { get; protected set; }
        public string Brand { get; protected set; }

        protected Vehicle()
        {

        }

        public Vehicle(string name, int seats, string brand)
        {
            SetName(name);
            SetSeats(seats);
            SetBrand(brand);
        } 

        private void SetBrand(string brand)
        {
            if(string.IsNullOrWhiteSpace(brand))
            {
                throw new Exception("Provide valid data");
            }
            if(Brand == brand)
            {
                return;
            }

            Brand = brand;
        }

        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Provide valid data");
            }
            if(Name == name)
            {
                return;
            }

            Name = name;
        }

        private void SetSeats(int seats)
        {
            if(seats < 0)
            {
                throw new Exception("Amount of seats must be greater than 0");
            }
            if(seats > 9)
            {
                throw new Exception("Amount of seats must be less than 9");
            }
            if(Seats == seats)
            {
                return;
            }

            Seats = seats;
        }
    }
}