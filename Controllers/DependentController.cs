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
        private ICRUDRepository<Dependent> repository;

        public DependentController(ICRUDRepository<Dependent> repository)
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
            repository.Add(dependent);
        }
        public void UpdateDependent(string id, string name, string cpf, string kinship, string memberId)
        {
            Dependent dependent = DependentFactory.Build(name, cpf, kinship, memberId);
            //var context = new ValidationContext(member);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(member, context, results, true);

            //if (!isValid)
            //  throw new Exception(results[0].ErrorMessage);
            dependent.Id = id;
            repository.Update(dependent);
        }
        public Dependent GetDependentByID(string id)
        {
            return repository.GetByID(id);
        }
        public List<Dependent> SearchByName(string name) {
            return repository.Search(name);
        }
        public void DeleteDependent(string id)
        {
            repository.Delete(id);
        }
        public List<Dependent> GetAllDependents()
        {
            List<Dependent> dependents = repository.GetAll();
            return dependents;
        }
    }
}