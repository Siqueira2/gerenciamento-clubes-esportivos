using GerenciamentoClubesEsportivos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Utils.Interfaces
{
    public interface ICRUDRepository<T>
    {
        List<T> GetAll();
        List<T> Search(string query);
        T GetByID(string id);
        void Add(T entity);
        void AddAll(List<T> members);
        void Update(T entity);
        void Delete(string id);
    }
}