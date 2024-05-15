namespace DadosDeTrabalhador.Entities
{
    internal class HourContract
    {
        public  DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract() { }
        public HourContract(DateTime dateTime, double valuePerHour, int hours)
        {
            Date = dateTime;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
