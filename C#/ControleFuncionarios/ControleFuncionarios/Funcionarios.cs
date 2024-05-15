using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ControleFuncionarios
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string name, double salary)
        {
            Id = id;
            Nome = name;
            Salario = salary;
        }


        public void ReajustaSalario(double pocent)
        {
            Salario += (Salario * pocent) / 100;
        }

        public override string ToString()
        {
            return $"ID: {Id} // Nme: {Nome} // Salario: {Salario}";
        }
    }   
}
