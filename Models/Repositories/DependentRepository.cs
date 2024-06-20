using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Utils.Database;
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
        private MockDatabase MockDatabase;

        public DependentRepository() {
            MockDatabase = MockDatabase.Instance;
        }

        public void Add(Dependent entity)
        {
            MockDatabase.AddDependent(entity);
        }

        public void AddAll(List<Dependent> dependents)
        {
            MockDatabase.AddAllDependents(dependents);
        }

        public void Delete(string id)
        {
            MockDatabase.DeleteDependent(id);
        }

        public List<Dependent> GetAll()
        {
            return MockDatabase.GetDependents();
        }

        public Dependent GetByID(string id)
        {
            return MockDatabase.GetDependentById(id);
        }

        public List<Dependent> GetByMemberId(string memberID) {
            return MockDatabase.GetDependents().Where(d => d.memberId == memberID).ToList();
        }
        public List<Dependent> Search(string query)
        {
            return MockDatabase.GetDependents().Where(d => d.Name.ToLower().Contains(query.ToLower())).ToList();
        }

        public void Update(Dependent entity)
        {
           MockDatabase.UpdateDependent(entity);
        }
    }
}