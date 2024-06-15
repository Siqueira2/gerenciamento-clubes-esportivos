using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Repositories
{
    internal class MemberRepository : ICRUDRepository<Member>
    {
        private List<Member> Members;
        private int sequencialId = 0;

        public MemberRepository()
        {
            Members = new List<Member>();
            Members.Add(new Member());
        }
        public List<Member> GetAll()
        {
            return Members.Where(m => m.Id != 0).ToList();
        }
        public Member GetByID(int id)
        {
            return Members.FirstOrDefault(m => m.Id == id)!;
        }
        public void Add(Member member)
        {
            member.Id = sequencialId + 1;
            sequencialId++;
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
        public void Delete(int id)
        {
            Member existingMember = GetByID(id);
            if (existingMember != null)
                Members.Remove(existingMember);
        }

        public void DeleteDependent(int id)
        {
            Member existingDependent = GetByID(id);
            if(existingDependent != null) Members.Remove(existingDependent);
        } 

        public List<Member> Search(string query)
        {
            return Members.Where(m => m.Name.ToLower().Contains(query.ToLower())).ToList();
        }
        public void AddAll(List<Member> members)
        {
            Members.AddRange(members);
        }

        public void AddDependent(Dependent dependent)
        {
            Member member = GetByID(dependent.MemberID);
            dependent.Id = sequencialId + 1;
            sequencialId++;
            member.Dependents.Add(dependent);
        }
    }
}