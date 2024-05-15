﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPedidosdeCliente.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do cliente");
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"Data de nascimento: {BirthDate}");

            return sb.ToString();
        }
    }
}
