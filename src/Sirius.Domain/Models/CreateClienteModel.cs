using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class CreateClienteModel : Notifiable
    {
        public CreateClienteModel(string name, DateTime birthDate, string cpf, string password)
        {
            Name = name;
            BirthDate = birthDate;
            Cpf = cpf;
            Password = password;

            AddNotifications(new Contract()
                .HasMaxLen(Name, 40, "Name", "Name should have no more than 40 chars")
                .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
                .IsNotNullOrEmpty(Cpf, "CPF", "CPF should have at least 11 chars")
                .HasLen(Cpf, 11, "CPF", "CPF should have at least 11 chars")
                .IsTrue(CadastroValido(), "Password", "")
            );
        }

        private string Name { get; set; }

        private DateTime BirthDate { get; set; }

        private string Cpf { get; set; }

        private string Password { get; set; }

        bool CadastroValido()
        {
            // Validar o CPF
            return true;
        }
    }
}
