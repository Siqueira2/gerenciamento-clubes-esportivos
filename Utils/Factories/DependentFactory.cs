

using GerenciamentoClubesEsportivos.Models.Entities;

namespace GerenciamentoClubesEsportivos.Utils.Factories
{
    internal static class DependentFactory
    {
        public static Dependent Build(string name, string cpf, string kinship, int memberId)
        {
            return new Dependent
            {
                Name = name.ToUpper(),
                CPF = cpf,
                Kinship = kinship,
                MemberID = memberId
            };
        }
    }
}
