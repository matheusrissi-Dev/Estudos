using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;
using System.Data;

namespace ReservaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Numero do quarto: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Data do check-In (dd/MM/yyyy): ");
                DateTime dateCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do check-Out (dd/MM/yyyy): ");
                DateTime dateCheckOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(number, dateCheckIn, dateCheckOut);
                Console.WriteLine($"Reserva: {reserva}");

                Console.WriteLine();
                Console.WriteLine("Entre com os dados atualizados da reserva");
                Console.Write("Data do check-In (dd/MM/yyyy): ");
                dateCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do check-Out (dd/MM/yyyy): ");
                dateCheckOut = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDates(dateCheckIn, dateCheckOut);
                Console.WriteLine($"Reserva: {reserva}");

            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
