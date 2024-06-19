using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Utils.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Repositories
{
    public class DependentRepository : ICRUDRepository<Dependent>
    {
        private List<Dependent> Dependents;

        public DependentRepository() { 
            Dependents = new List<Dependent>();
        }

        public void Add(Dependent entity)
        {
            Guid id = Guid.NewGuid();
            entity.Id = id.ToString().Substring(0, 4);
            Dependents.Add(entity);
        }

        public void AddAll(List<Dependent> members)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Dependent> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dependent GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<Dependent> GetByMemberId(string memberID) {
            return Dependents.Where(d => d.memberId == memberID).ToList();
        }
        public List<Dependent> Search(string query)
        {
            return Dependents.Where(d => d.Name.ToLower().Contains(query.ToLower())).ToList();
        }

        public void Update(Dependent entity)
        {
            Dependent existingDependent = GetByID(entity.Id);
            if (existingDependent != null)
            {
                existingDependent.Name = entity.Name;
                existingDependent.CPF = entity.CPF;
                existingDependent.kinship = entity.kinship;
                existingDependent.memberId = entity.memberId;
            }
        }
    }
}