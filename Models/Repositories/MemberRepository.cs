using GerenciamentoClubesEsportivos.Models.Entities;
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
        private List<Member> Members;

        public MemberRepository()
        {
            Members = new List<Member>();
        }
        public List<Member> GetAll()
        {
            return Members;
        }
        public Member GetByID(string id)
        {
            return Members.FirstOrDefault(m => m.Id == id)!;
        }
        public void Add(Member member)
        {
            Guid newUuid = Guid.NewGuid();
            var lastMember = Members.LastOrDefault();
            member.Id = newUuid.ToString().Substring(0, 4);
            Members.Add(member);
        }
        public void Update(Member member)
        {
            Member existingMember = GetByID(member.Id);
            if (existingMember != null)
            {
                existingMember.Name = member.Name;
                existingMember.Email = member.Email;
                existingMember.CPF = member.CPF;
                existingMember.CEP = member.CEP;
                existingMember.PhoneNumber = member.PhoneNumber;
                existingMember.MembershipDate = member.MembershipDate;
            }
        }
        public void Delete(string id)
        {
            Member existingMember = GetByID(id);
            if (existingMember != null)
                Members.Remove(existingMember);
        }
        public List<Member> Search(string query)
        {
            return Members.Where(m => m.Name.ToLower().Contains(query.ToLower())).ToList();
        }
        public void AddAll(List<Member> members)
        {
            Members.AddRange(members);
        }
    }
}