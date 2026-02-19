using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public Seat Seat;

        private double Price;

        // Full constructor
        public Ticket(string movieName, TicketType type, Seat seat, double price)
            : this(movieName)   // Constructor chaining
        {
            Type = type;
            Seat = seat;
            Price = price;
        }

        // Default constructor
        public Ticket(string movieName)
        {
            MovieName = movieName;
            Type = TicketType.Standard;
            Seat = new Seat('A', 1);
            Price = 50;
        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
            Console.WriteLine($"Seat     : {Seat}");
            Console.WriteLine($"Price    : {Price:F2}");
        }
    }
}
