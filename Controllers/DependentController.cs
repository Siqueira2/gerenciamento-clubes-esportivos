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
    public class DependentController
    {
        private ICRUDRepository<Member> repository;

        public DependentController(ICRUDRepository<Member> repository)
        {
            this.repository = repository;
        }

        public void AddDependent(string name, string cpf, string kinship, string memberId)
        {
            Dependent dependent = DependentFactory.Build(name, cpf, kinship, memberId);

            //var context = new ValidationContext(member);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(member, context, results, true);

            //if (!isValid)
              //  throw new Exception(results[0].ErrorMessage);

            //repository.AddDependent(dependent);
        }
        public void UpdateMember(string id, string name, string cpf, string email, string phoneNumber, string cep, DateTime membershipDate)
        {
            Member member = MemberFactory.Build(name, cpf, email, phoneNumber, cep, membershipDate);
            //var context = new ValidationContext(member);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(member, context, results, true);

            //if (!isValid)
              //  throw new Exception(results[0].ErrorMessage);

            repository.Update(member);
        }
        public Member GetMemberByID(string id)
        {
            return repository.GetByID(id);
        }
        public List<Member> SearchByName(string name) {
            return repository.Search(name);
        }
        public void DeleteMember(string id)
        {
            repository.Delete(id);
        }
        public List<Member> GetAllMembers()
        {
            return repository.GetAll();
        }

        public List<Member> ImportFromXmlFile(string filePath)
        {
            List<Member> members = XmlService.DeserializeFromFile<Member>(filePath);
            if (members == null) return null;

            repository.AddAll(members);

            return members;
        }
        public void ExportAsXmlFile(string FileName)
        {
            List<Member> members = GetAllMembers();
            XmlService.SerializeToFile(members, @"C:\", FileName);
        }
    }
}