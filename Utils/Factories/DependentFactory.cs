using GerenciamentoClubesEsportivos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Utils.Factories
{
    internal static class DependentFactory
    {
        public static Dependent Build(string name, string cpf, string kinship, string memberId)
        {
            return new Dependent
            {
                Name = name,
                CPF = cpf,
                kinship = kinship,
                memberId = memberId
            };
        }
    }
}