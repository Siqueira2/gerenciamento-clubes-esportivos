using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Utils.Database;
using GerenciamentoClubesEsportivos.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Repositories
{
    public class MemberRepository : ICRUDRepository<Member>
    {
        private MockDatabase MockDatabase;

        public MemberRepository()
        {
            MockDatabase = MockDatabase.Instance;
        }
        public List<Member> GetAll()
        {
            return MockDatabase.GetMembers();
        }
        public Member GetByID(string id)
        {
            return MockDatabase.GetMemberById(id);
        }
        public void Add(Member member)
        {
           MockDatabase.AddMember(member);
        }
        public void Update(Member member)
        {
            MockDatabase.UpdateMember(member);
        }
        public void Delete(string id)
        {
            MockDatabase.DeleteMember(id);
        }
        public List<Member> Search(string query)
        {
            return MockDatabase.GetMembers().Where(m => m.Name.ToLower().Contains(query.ToLower())).ToList();
        }
        public void AddAll(List<Member> members)
        {
            MockDatabase.AddAllMembers(members);
        }
    }
}