using ReservaHotel.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel.Entities
{
    internal class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckoOut { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkin, DateTime checkout)
        {
            NumeroQuarto = numeroQuarto;
            CheckIn = checkin;
            CheckoOut = checkout;

            if (CheckoOut <= CheckIn)
            {
                throw new DomainException("Check-Out deve ser posterios ao Check-In");
            }

        }


        public int Duration()
        {
            //TimeSpan duration = CheckoOut - CheckIn;
            TimeSpan duration = CheckoOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {

            DateTime now = DateTime.Now;
            if(CheckIn < now || CheckoOut < now)
            {
                throw new DomainException("Datas apresentadas devem ser futuras");
            }
            if(CheckoOut <= CheckIn)
            {
                throw new DomainException("Check-Out deve ser posterios ao Check-In");
            }

            CheckIn = checkin;
            CheckoOut = checkout;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Quarto: {NumeroQuarto}");
            sb.AppendLine($"CheckIn: {CheckIn.ToString("dd/MM/yyyy")} <-> CheckOut: {CheckoOut.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Duração: {Duration()} Dias");
            return sb.ToString();
        }

    }
}
