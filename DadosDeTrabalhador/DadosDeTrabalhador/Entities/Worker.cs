using DadosDeTrabalhador.Entities.Enum;

namespace DadosDeTrabalhador.Entities
{
    internal class Worker
    {
        public  string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public  double BaseSalary { get; set; }
        public  Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }



        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContracts(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Renda(int mounth, int year)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Month == mounth &&  contract.Date.Year == year)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }



    }
}
