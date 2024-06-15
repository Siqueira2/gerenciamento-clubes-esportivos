using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Models.Services;
using GerenciamentoClubesEsportivos.Utils.Factories;
using GerenciamentoClubesEsportivos.Utils.Interfaces;

namespace GerenciamentoClubesEsportivos.Controllers
{
    internal class MemberController
    {
        private ICRUDRepository<Member> repository;

        public MemberController(ICRUDRepository<Member> repository)
        {
            this.repository = repository;
        }

        public void AddMember(string name, string cpf, string email, string phoneNumber, string cep, DateTime membershipDate)
        {
            Member member = MemberFactory.Build(name, cpf, email, phoneNumber, cep, membershipDate);

            //var context = new ValidationContext(member);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(member, context, results, true);

            //if (!isValid)
              //  throw new Exception(results[0].ErrorMessage);

            repository.Add(member);
        }

        public void AddDependent(string name, string cpf, string kinship, int memberId)
        {
            Dependent dependent = DependentFactory.Build(name, cpf, kinship, memberId);

            //var context = new ValidationContext(dependent);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(dependent, context, results, true);

            //if (!isValid)
            //    throw new Exception(results[0].ErrorMessage);

            repository.AddDependent(dependent);
        }

        public List<Member> GetAllMembers()
        {
            return repository.GetAll();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Member> ImportFromXmlFile(string filePath)
        {
            List<Member> members = XmlService.DeserializeFromFile<Member>(filePath);
            if (members == null) return null;

            repository.AddAll(members);

            return members;
        }
        public void ExportAsXmlFile(List<Member> test)
        {
            XmlService.SerializeToFile(test, @"C:\Users\walys\source\repos", "Members");
        }
    }
}