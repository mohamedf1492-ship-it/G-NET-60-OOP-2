using System.Net.Sockets;

namespace oop2
#region part2
{
   /* enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }

    struct SeatLocation
    {
        public char Row;
        public int Number;

        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
    }

    class Ticket
    {
        private string movieName = "";
        private double price;
        private static int ticketCounter = 0;

        public int TicketId { get; private set; }

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    movieName = value;
                }
            }
        }

        public TicketType Type { get; set; }

        public SeatLocation Seat { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public double PriceAfterTax
        {
            get { return Price * 1.14; }
        }

        public Ticket(
            string movieName,
            TicketType type,
            SeatLocation seat,
            double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;

            ticketCounter++;
            TicketId = ticketCounter;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
    }

    class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                {
                    return tickets[index];
                }

                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                {
                    tickets[index] = value;
                }
            }
        }

        public Ticket GetMovieBy(string movieName)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null &&
                    tickets[i].MovieName == movieName)
                {
                    return tickets[i];
                }
            }

            return null;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }

            return false;
        }
    }

    static class BookingHelper
    {
        private static int referenceCounter = 0;

        public static double CalcGroupDiscount(
            int numberOfTickets,
            double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;

            if (numberOfTickets >= 5)
            {
                total = total * 0.90;
            }

            return total;
        }

        public static string GenerateBookingReference()
        {
            referenceCounter++;

            return "BK-" + referenceCounter;
        }*/
#endregion

        internal class Program
    {
        static void Main(string[] args)
        {
            #region part2

           /* Cinema cinema = new Cinema();

            Console.WriteLine("========== Ticket Booking ==========");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(
                    "\nEnter data for Ticket " + (i + 1) + ":");

                Console.Write("Movie Name: ");
                string movieName = Console.ReadLine();

                Console.Write(
                    "Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                int typeNumber = Convert.ToInt32(Console.ReadLine());

                TicketType type = (TicketType)typeNumber;

                Console.Write("Seat Row (A-Z): ");
                char row = Convert.ToChar(Console.ReadLine());

                Console.Write("Seat Number: ");
                int seatNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                SeatLocation seat =
                    new SeatLocation(row, seatNumber);

                Ticket ticket = new Ticket(
                    movieName,
                    type,
                    seat,
                    price);

                if (cinema.AddTicket(ticket))
                {
                    Console.WriteLine("Ticket added successfully.");
                }
                else
                {
                    Console.WriteLine("Cinema is full.");
                }
            }

            Console.WriteLine("\n========== All Tickets ==========");

            for (int i = 0; i < 3; i++)
            {
                Ticket ticket = cinema[i];

                if (ticket != null)
                {
                    Console.WriteLine(
                        "Ticket #" + ticket.TicketId +
                        " | " + ticket.MovieName +
                        " | " + ticket.Type +
                        " | Seat: " + ticket.Seat.Row +
                        "-" + ticket.Seat.Number +
                        " | Price: " + ticket.Price +
                        " EGP | After Tax: " +
                        ticket.PriceAfterTax + " EGP");
                }
            }

            Console.Write("\nEnter movie name to search: ");
            string searchName = Console.ReadLine();

            Ticket foundTicket = cinema.GetMovieBy(searchName);

            if (foundTicket != null)
            {
                Console.WriteLine(
                    "Movie Found: " + foundTicket.MovieName +
                    " | Ticket ID: " + foundTicket.TicketId);
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }

            Console.WriteLine(
                "\nTotal Tickets Sold: " +
                Ticket.GetTotalTicketsSold());

            Console.WriteLine(
                "Booking Reference: " +
                BookingHelper.GenerateBookingReference());

            Console.WriteLine(
                "Booking Reference: " +
                BookingHelper.GenerateBookingReference());

            double groupTotal =
                BookingHelper.CalcGroupDiscount(5, 80);

            Console.WriteLine(
                "Group Discount Total: " + groupTotal + " EGP");*/
            #endregion

        }
    }
}
